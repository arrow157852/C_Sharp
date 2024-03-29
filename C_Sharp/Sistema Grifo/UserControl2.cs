﻿using Microsoft.EntityFrameworkCore;
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
        public UserControl2()
        {
            InitializeComponent();
            gbspda.Enabled = false;
            gblaudo.Enabled = false;
            gbaterramento.Enabled = false;
            
            dgvconsulta.DataSource = consulta.ObterDados("TabelaTemporaria");
            consulta.ConsultarDados("", "tabelaTemporaria", dgvconsulta);
            dgvconsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void tbservico_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbservico.SelectedItem.ToString())
            {
                case "SPDA":
                    gbspda.Enabled = true;
                    gblaudo.Enabled = false;
                    gbaterramento.Enabled = false;
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
            context.GeralResults.RemoveRange(geralresult);
            context.tabelaTemporarias.RemoveRange(tabelTemporaria);
            context.SaveChanges();
            var totalRegistros = context.GeralResults.Count();
            if (totalRegistros == 0)
            {
                // Esta parte pode variar dependendo do provedor de banco de dados
                context.Database.ExecuteSqlRaw("ALTER TABLE geralresult AUTO_INCREMENT = 1");
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
            context.GeralResults.RemoveRange(geralresult);
            context.tabelaTemporarias.RemoveRange(tabelTemporaria);
            context.SaveChanges();
            var totalRegistros = context.GeralResults.Count();
            if (totalRegistros == 0)
            {
                // Esta parte pode variar dependendo do provedor de banco de dados
                context.Database.ExecuteSqlRaw("ALTER TABLE geralresult AUTO_INCREMENT = 1");
                context.Database.ExecuteSqlRaw("ALTER TABLE tabelatemporaria AUTO_INCREMENT = 1");
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

           
            float valor = context.tabelaTemporarias.Sum(m => m.valorTotal);
            nudtotal.Value = (decimal)valor;

            
            var maodeobra = context.tabelaTemporarias.Where(m => m.CategoriaID == 1).Sum(m => m.valorTotal);
            var material = context.tabelaTemporarias.Where(m => m.CategoriaID == 2).Sum(m => m.valorTotal);

            
            nudmmaodeobra.Value = maodeobra == 0 ? 0 : (decimal)((((float)nudmargemmao.Value * maodeobra) / 100));
            nudmmaterial.Value = material == 0 ? 0 : (decimal)((((float)nudmargemmaterial.Value * material) / 100));

            
            var totalscomissao = (float)(nudmmaterial.Value + nudmmaodeobra.Value);
            var comissao = (((float)nudcomissao.Value * valor) / 100);

            
            float imposto = (((float)nudimp.Value * (comissao + totalscomissao)) / 100);
            nudimposto.Value = (decimal)imposto;

            
            nudtotalimposto.Value = nudtotal.Value + nudmmaterial.Value + nudmmaodeobra.Value + nudimposto.Value;

           
            dgvconsulta.DataSource = consulta.ObterDados("TabelaTemporaria");
            dgvconsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            var materiaisPorCategoria = context.tabelaTemporarias.Where(m => m.CategoriaID == 1).Sum(m=>m.valorTotal);


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var materiaisPorCategoria = context.tabelaTemporarias.Where(m => m.CategoriaID == 2).ToList();
        }
    }
}
