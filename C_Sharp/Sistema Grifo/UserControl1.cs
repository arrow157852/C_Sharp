using System;
using System.Windows.Forms;
using Sistema_Grifo.contexto;
using Sistema_Grifo.Modelo;
using System.Linq;
using Sistema_Grifo.Calculadora;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Grifo
{
    public partial class UserControl1 : UserControl
    {
        private object dados;
        AppDbcontext context = new AppDbcontext();
        Consulta consulta = new Consulta();
        Calculos calc = new Calculos();



        public UserControl1()
        {
            InitializeComponent();
            habilitabotoes(true);
            habilitacampos(false);
            tbid.Enabled = false;
            gbTemporario.Enabled = false;

        }



        private void button3_Click(object sender, EventArgs e)
        {


            string itemSelecionado = cbtabela.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(itemSelecionado))
            {
                MessageBox.Show("Por favor, selecione uma tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float valorTotal = (float)nudvalortotal.Value;
            int quantidade = (int)nudquantidade.Value;
            string descricao = tbdescricao.Text.Trim();
            int tipo = 0;

            if (cbtabela.SelectedItem.ToString().Equals("TabelaTemporaria"))
            {
                string categoria = cbcategoria.SelectedItem.ToString();



                if (categoria == "Material")
                {
                    tipo = 2;


                }
                else if (categoria == "Mão de obra")
                {
                    tipo = 1;
                }
                else if (categoria == "Custos diversos")
                {
                    tipo = 3;
                }

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("Por favor, insira valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            using (var baseDeDados = new AppDbcontext())
            {
                float valor = (float)numericUpDown1.Value;
                try
                {
                    if (itemSelecionado == "Material")
                    {
                        var material = new Material
                        {
                            material = descricao,
                            valor_unidade = valor
                        };
                        baseDeDados.Materials.Add(material);
                    }
                    else if (itemSelecionado == "Mão de obra")
                    {
                        var maoDeObra = new MaoDeObra
                        {
                            Nome_cargo = descricao,
                            valor_cargo = valor
                        };
                        baseDeDados.MaoDeObras.Add(maoDeObra);
                    }
                    else if (itemSelecionado == "Diversos")
                    {
                        var diversos = new Diversos
                        {
                            Descricao = descricao,
                            valor_diversos = valor
                        };
                        baseDeDados.Diversoss.Add(diversos);
                    }
                    else if (itemSelecionado == "TabelaTemporaria")
                    {
                        var tabelaTemporaria = new TabelaTemporaria
                        {
                            descricao = descricao,
                            valor = valor,
                            quantidade = quantidade,
                            valorTotal = valorTotal,
                            CategoriaID = tipo

                        };

                        baseDeDados.tabelaTemporarias.Add(tabelaTemporaria);
                    }


                    baseDeDados.SaveChanges();
                    MessageBox.Show("Registro realizado com sucesso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }

            consulta.ConsultarDados(tbconsulta.Text, cbtabela.SelectedItem.ToString(), dgvconsulta);
            limpacampos();




        }


        private void cbtabela_SelectedIndexChanged(object sender, EventArgs e)
        {



        }





        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void tbconsulta_TextChanged(object sender, EventArgs e)
        {
            if (cbtabela.SelectedItem == null)
            {

                MessageBox.Show(" selecione um tipo de registro ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                consulta.ConsultarDados(tbconsulta.Text, cbtabela.SelectedItem.ToString(), dgvconsulta);
            }
        }

        private void AlterarCliente(int id, string nome, int quantidade, float valorTotal, float valor, AppDbcontext context)
        {
            tbid.Enabled = true;
            string itemSelecionado = cbtabela.SelectedItem?.ToString();
            try
            {
                if (itemSelecionado.Equals("Material"))
                {
                    var registro = context.Materials.Find(id);
                    registro.material = nome;
                    registro.valor_unidade = valor;

                }
                else if (itemSelecionado.Equals("Mão de obra"))
                {
                    var registro = context.MaoDeObras.Find(id);
                    registro.Nome_cargo = nome;
                    registro.valor_cargo = valor;
                }
                else if (itemSelecionado.Equals("Diversos"))
                {
                    var registro = context.Diversoss.Find(id);
                    registro.Descricao = nome;
                    registro.valor_diversos = valor;
                }
                else if (itemSelecionado.Equals("TabelaTemporaria"))
                {
                    var registro = context.tabelaTemporarias.Find(id);
                    registro.descricao = nome;
                    registro.valor = valor;
                    registro.quantidade = quantidade;
                    registro.valorTotal = valorTotal;

                }
                context.SaveChanges();
                consulta.ConsultarDados(tbconsulta.Text, cbtabela.SelectedItem.ToString(), dgvconsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }






        private void habilitabotoes(Boolean estado)
        {
            bnovo.Enabled = estado;
            balterar.Enabled = !estado;
            bsalvar.Enabled = !estado;
            bexcluir.Enabled = !estado;
            bcancelar.Enabled = !estado;

        }
        private void habilitacampos(Boolean estado)
        {

            numericUpDown1.Enabled = estado;
            tbdescricao.Enabled = estado;
            tbconsulta.Enabled = estado;
            cbtabela.Enabled = estado;

        }

        private void limpacampos()
        {
            tbdescricao.Text = string.Empty;
            tbid.Text = string.Empty;
            tbconsulta.Text = string.Empty;
            numericUpDown1.Text = string.Empty;
            nudquantidade.Text = string.Empty;
            nudvalortotal.Text = string.Empty;
        }

        private void bnovo_Click(object sender, EventArgs e)
        {



        }

        private void dgvconsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            limpacampos();
        }

        private void excluir()
        {
            using (var baseDeDados = new AppDbcontext())
            {
                string itemSelecionados = cbtabela.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(itemSelecionados))
                {
                    MessageBox.Show("Por favor, selecione uma tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string descricao = tbdescricao.Text.Trim();
                float valor = (float)numericUpDown1.Value;
                int id = int.Parse(tbid.Text);
                int quantidade = (int)nudquantidade.Value;
                float valorTotal = (float)nudvalortotal.Value;
                DialogResult confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este item?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    if (itemSelecionados == "Material")
                    {
                        var material = new Material
                        {
                            material = descricao,
                            valor_unidade = valor,
                            id = id

                        };
                        baseDeDados.Materials.Remove(material);
                    }
                    else if (itemSelecionados == "Mão de obra")
                    {
                        var maoDeObra = new MaoDeObra
                        {
                            Nome_cargo = descricao,
                            valor_cargo = valor,
                            cargosID = id
                        };
                        baseDeDados.MaoDeObras.Remove(maoDeObra);
                    }
                    else if (itemSelecionados == "Diversos")
                    {
                        var diversos = new Diversos
                        {
                            Descricao = descricao,
                            valor_diversos = valor,
                            CustoID = id
                        };
                        baseDeDados.Diversoss.Remove(diversos);
                    }
                    else if (itemSelecionados == "TabelaTemporaria")
                    {
                        var temporaria = new TabelaTemporaria
                        {
                            descricao = descricao,
                            valor = valor,
                            temporarioID = id,
                            quantidade = quantidade,
                            valorTotal = valorTotal

                        };
                        baseDeDados.tabelaTemporarias.Remove(temporaria);
                    }


                    baseDeDados.SaveChanges();
                }
            }
        }
        private void bexcluir_Click(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudvalortotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void nudquantidade_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1 != null || nudquantidade != null)
            {
                nudvalortotal.Value = numericUpDown1.Value * nudquantidade.Value;
            }
        }

        private void bnovo_Click_1(object sender, EventArgs e)
        {
            bnovo.Enabled = false;
            cbtabela.Enabled = true;
        }

        private void balterar_Click(object sender, EventArgs e)
        {
            AppDbcontext context = new AppDbcontext();
            int ids = int.Parse(tbid.Text);
            AlterarCliente(ids, tbdescricao.Text, (int)nudquantidade.Value, (float)nudvalortotal.Value, (float)numericUpDown1.Value, context);
            calc.idsmaterial.Add(int.Parse(tbid.Text));
            limpacampos();
        }

        private void bexcluir_Click_1(object sender, EventArgs e)
        {
            excluir();
            consulta.ConsultarDados(tbconsulta.Text, cbtabela.SelectedItem.ToString(), dgvconsulta);
            limpacampos();
            string itemSelecionado = cbtabela.SelectedItem?.ToString();
        }

        private void bcancelar_Click_1(object sender, EventArgs e)
        {
            limpacampos();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbtabela_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            consulta.ConsultarDados(tbconsulta.Text, cbtabela.SelectedItem.ToString(), dgvconsulta);
            habilitabotoes(false);
            habilitacampos(true);
            if (!cbtabela.SelectedItem.Equals("TabelaTemporaria"))
            {
                gbTemporario.Enabled = false;
            }
            else if (cbtabela.SelectedItem.Equals("TabelaTemporaria"))
            {
                gbTemporario.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged_2(object sender, EventArgs e)
        {
            if (numericUpDown1 != null || nudquantidade != null)
            {
                nudvalortotal.Value = numericUpDown1.Value * nudquantidade.Value;
            }
        }

        private void nudquantidade_ValueChanged_1(object sender, EventArgs e)
        {
            if (numericUpDown1 != null || nudquantidade != null)
            {
                nudvalortotal.Value = numericUpDown1.Value * nudquantidade.Value;
            }
        }

        private void dgvconsulta_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvconsulta.Rows[e.RowIndex];
            string itemSelecionado = cbtabela.SelectedItem?.ToString();
            if (itemSelecionado.Equals("Material"))
            {
                // Supondo que 'Id' e 'Material' são as colunas relevantes para a tabela de Material
                tbid.Text = row.Cells["Id"].Value.ToString();
                tbdescricao.Text = row.Cells["Material"].Value.ToString();
                numericUpDown1.Text = row.Cells["valor_unidade"].Value.ToString();
            }
            else if (itemSelecionado.Equals("Mão de obra"))
            {
                // Supondo que 'Id' e 'Nome_cargo' são as colunas relevantes para a tabela de Mão de obra
                tbid.Text = row.Cells["cargosID"].Value.ToString();
                tbdescricao.Text = row.Cells["Nome_cargo"].Value.ToString();
                numericUpDown1.Text = row.Cells["valor_cargo"].Value.ToString();
            }
            else if (itemSelecionado.Equals("Diversos"))
            {
                // Supondo que 'Id' e 'Descricao' são as colunas relevantes para a tabela de Diversos
                tbid.Text = row.Cells["CustoID"].Value.ToString();
                tbdescricao.Text = row.Cells["Descricao"].Value.ToString();
                numericUpDown1.Text = row.Cells["valor_diversos"].Value.ToString();
            }
            else if (itemSelecionado.Equals("TabelaTemporaria"))
            {
                // Supondo que 'Id' e 'Descricao' são as colunas relevantes para a tabela de Diversos
                tbid.Text = row.Cells["temporarioID"].Value.ToString();
                tbdescricao.Text = row.Cells["descricao"].Value.ToString();
                numericUpDown1.Text = row.Cells["valor"].Value.ToString();
                nudquantidade.Text = row.Cells["quantidade"].Value.ToString();
                nudvalortotal.Text = row.Cells["valorTotal"].Value.ToString();
            }
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            var geralresult = context.GeralResults.ToList();
            var tabelTemporaria = context.tabelaTemporarias.ToList();
            context.GeralResults.RemoveRange(geralresult);
            context.tabelaTemporarias.RemoveRange(tabelTemporaria);
            context.Configuracoesapps.RemoveRange(context.Configuracoesapps.ToList());
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
    }
}





