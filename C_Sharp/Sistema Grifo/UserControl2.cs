using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using MySqlX.XDevAPI;
using Sistema_Grifo.Calculadora;
using Sistema_Grifo.contexto;
using Sistema_Grifo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;

namespace Sistema_Grifo
{
    public partial class UserControl2 : System.Windows.Forms.UserControl
    {
        Calculos calc = new Calculos();
        Consulta consulta = new Consulta();
        AppDbcontext context = new AppDbcontext();
        decimal maodeobra;
        decimal material;
        decimal margemmao;
        decimal margemmaterial;
        decimal comisao;
        decimal percntilimp;
        public UserControl2()
        {
            InitializeComponent();
            gbspda.Enabled = false;
            gblaudo.Enabled = false;
            gbaterramento.Enabled = false;

            

        }

        private void tbservico_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbservico.SelectedItem.ToString())
            {
                case "SPDA":
                    gbspda.Enabled = true;
                    gblaudo.Enabled = false;
                    gbaterramento.Enabled = false;

                    var produtos = context.Configuracoesapps
                         .Where(p => p.id == 1)
                         .ToList();
                    decimal maodeobra = (decimal)context.tabelaTemporarias.Where(m => m.CategoriaID == 1).Sum(m => m.valorTotal);
                    decimal material = (decimal)context.tabelaTemporarias.Where(m => m.CategoriaID == 2).Sum(m => m.valorTotal);
                    foreach (var item in produtos)
                    {
                         margemmao = item.nud_margem_mao;
                        margemmaterial = item.nud_margem_material;
                        comisao = item.nud_comissao;
                        percntilimp = item.nud_Imp;
                    }
                    // Atualizar os valores nos controles NumericUpDown de mão de obra e material
                    nudmmaodeobra.Value = maodeobra == 0 ? 0 : (decimal)(maodeobra + ((margemmao * maodeobra) / 100));
                    nudmmaterial.Value = material == 0 ? 0 : (decimal)(material + ((margemmaterial * material) / 100));

                    // Calcular e exibir o valor total
                    float valor = context.tabelaTemporarias.Sum(m => m.valorTotal);
                    nudtotal.Value = (decimal)valor;

                    // Calcular a comissão
                    var comissao = (((float)comisao * valor) / 100);

                    // Calcular o imposto
                    var totalscomissao = (float)(nudmmaterial.Value + nudmmaodeobra.Value);
                    float imposto = ((((float) percntilimp* (comissao + totalscomissao)) / 100));
                    nudimposto.Value = (decimal)imposto;

                    // Atualizar o valor total com imposto
                    nudtotalimposto.Value = nudmmaterial.Value + nudmmaodeobra.Value + nudimposto.Value;

                    // Atualizar configurações do aplicativo no banco de dados
                    // Criar um novo objeto Configuracoesapp
                    var novaConfiguracao = new Configuracoesapp
                    {
                        nud_Imp = (int)nudimp.Value,
                        nud_margem_mao = (int)nudmmaodeobra.Value,
                        nud_margem_material = (int)nudmmaterial.Value,
                        nud_comissao = (int)nudcomissao.Value
                    };
                    dgvconsulta.DataSource = consulta.ObterDados("TabelaTemporaria");
                    dgvconsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    break;
            
                case "Laudo":
                    gblaudo.Enabled = true;
                    gbspda.Enabled = false;
                    gbaterramento.Enabled = false;
                    break;
                case "Aterramento":
                    gbaterramento.Enabled = true;
                    gblaudo.Enabled = false;
                    gbspda.Enabled = false;
                    break;
                default:
                    gbspda.Enabled = false;
                    gblaudo.Enabled = false;
                    gbaterramento.Enabled = false;
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var geralresult = context.GeralResults.ToList();
            var tabelTemporaria = context.tabelaTemporarias.ToList();
            var parametros = context.Configuracoesapps.ToList();
            context.GeralResults.RemoveRange(geralresult);
            context.tabelaTemporarias.RemoveRange(tabelTemporaria);
            
            context.Configuracoesapps.RemoveRange(parametros);
            context.SaveChanges();
            var totalRegistros = context.GeralResults.Count();
            if (totalRegistros == 0)
            {
                // Esta parte pode variar dependendo do provedor de banco de dados
                context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('geralresult', RESEED, 1);");
                context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('tabelatemporaria', RESEED, 1);");
                context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('configuracoesapp', RESEED, 1);");
            }
            Application.Exit(); 
        }



        private void balterar_Click(object sender, EventArgs e)
        {

        }

        private void cbmaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bsalvar_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void UserControl2_Load(object sender, EventArgs e)
        {

        }





        private void label_Click(object sender, EventArgs e)
        {

        }

        private void cbcaptor_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void cbdescidas_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void cbaterramento_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var geralresult = context.GeralResults.ToList();
            var tabelTemporaria = context.tabelaTemporarias.ToList();
            var parametros = context.Configuracoesapps.ToList();
            context.GeralResults.RemoveRange(geralresult);
            context.tabelaTemporarias.RemoveRange(tabelTemporaria);
            
            context.SaveChanges();
            calc.quantidsmaterialdescidas.Clear();
            var totalRegistros = context.GeralResults.Count();
            if (totalRegistros == 0)
            {
                // Esta parte pode variar dependendo do provedor de banco de dados
                context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('geralresult', RESEED, 1);");
                context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('tabelatemporaria', RESEED, 1);");
                


            }
            dgvconsulta.DataSource = consulta.ObterDados("TabelaTemporaria");
        }

        private void bcalc_Click(object sender, EventArgs e)
        {
         
                if (cbaterramento.Checked)
                {
                    calc.aterramento((float)nudperimetro.Value, (float)nudaltura.Value, cbmaterial.SelectedItem.ToString(), cbnp.SelectedItem.ToString());
                }
                if (cbcaptor.Checked)
                {
                    calc.Captor((float)nudperimetro.Value, (float)nudaltura.Value, cbmaterial.SelectedItem.ToString(), (float)nudpcaptor.Value);
                }
                if (cbdescidas.Checked)
                {
                    calc.descida((float)nudperimetro.Value, (float)nudaltura.Value, cbmaterial.SelectedItem.ToString(), cbnp.SelectedItem.ToString());
                }
            
        




            bool botao = true;

            calc.Uniao(cbmaterial.SelectedItem.ToString(), botao);

            AtualizarValores();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var materiaisPorCategoria = context.tabelaTemporarias.Where(m => m.CategoriaID == 1).Sum(m => m.valorTotal);


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var materiaisPorCategoria = context.tabelaTemporarias.Where(m => m.CategoriaID == 2).ToList();
        }


        // Função onde você usa esses valores
        public void AtualizarValores()
        {
            using (AppDbcontext context = new AppDbcontext())
            {
                // Calcular mão de obra e material
                decimal maodeobra = (decimal)context.tabelaTemporarias.Where(m => m.CategoriaID == 1).Sum(m => m.valorTotal);
                decimal material = (decimal)context.tabelaTemporarias.Where(m => m.CategoriaID == 2).Sum(m => m.valorTotal);

                // Atualizar os valores nos controles NumericUpDown de mão de obra e material
                nudmmaodeobra.Value = maodeobra == 0 ? 0 : (decimal)(maodeobra + ((nudmargemmao.Value * maodeobra) / 100));
                nudmmaterial.Value = material == 0 ? 0 : (decimal)(material + ((nudmargemmaterial.Value * material) / 100));

                // Calcular e exibir o valor total
                float valor = context.tabelaTemporarias.Sum(m => m.valorTotal);
                nudtotal.Value = (decimal)valor;

                // Calcular a comissão
                var comissao = (((float)nudcomissao.Value * valor) / 100);

                // Calcular o imposto
                var totalscomissao = (float)(nudmmaterial.Value + nudmmaodeobra.Value);
                float imposto = ((((float)nudimp.Value * (comissao + totalscomissao)) / 100));
                nudimposto.Value = (decimal)imposto;

                // Atualizar o valor total com imposto
                nudtotalimposto.Value = nudmmaterial.Value + nudmmaodeobra.Value + nudimposto.Value;

                // Atualizar configurações do aplicativo no banco de dados
                // Criar um novo objeto Configuracoesapp
                var novaConfiguracao = new Configuracoesapp
                {
                    nud_Imp = (int)nudimp.Value,
                    nud_margem_mao = (int)nudmargemmao.Value,
                    nud_margem_material = (int)nudmargemmaterial.Value,
                    nud_comissao = (int)nudcomissao.Value
                };

                // Adicionar o novo objeto ao contexto
                context.Configuracoesapps.Add(novaConfiguracao);

                // Salvar as mudanças no banco de dados
                context.SaveChanges();


                // Exibir os dados na DataGridView
                dgvconsulta.DataSource = consulta.ObterDados("TabelaTemporaria");
                dgvconsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void nudimp_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
