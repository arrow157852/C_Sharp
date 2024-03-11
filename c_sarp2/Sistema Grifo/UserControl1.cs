using System;
using System.Windows.Forms;
using Sistema_Grifo.contexto;
using Sistema_Grifo.Modelo;
using System.Linq;

namespace Sistema_Grifo
{
    public partial class UserControl1 : UserControl
    {
        private object dados;
        AppDbcontext context = new AppDbcontext();

        public UserControl1()
        {
            InitializeComponent();
            habilitabotoes(true);
            habilitacampos(false);
            tbid.Enabled = false;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            string itemSelecionado = cbtabela.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(itemSelecionado))
            {
                MessageBox.Show("Por favor, selecione uma tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string descricao = tbdescricao.Text.Trim();
            float valor;

            if (string.IsNullOrEmpty(descricao) || !float.TryParse(numericUpDown1.ToString(), out valor))
            {
                MessageBox.Show("Por favor, insira valores válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var baseDeDados = new AppDbcontext())
            {
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

            consultarDados();
            limpacampos();
        }

        private void consultarDados()
        {
            string descricao = tbconsulta.Text.Trim();
            string itemSelecionado = cbtabela.SelectedItem.ToString();

            if (string.IsNullOrEmpty(descricao))
            {
                dgvconsulta.DataSource = ObterDados(itemSelecionado);
            }
            else
            {
                dgvconsulta.DataSource = ObterDadosFiltrados(itemSelecionado, descricao);
            }


            dgvconsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvconsulta.Columns[0].Visible = false;
        }

        private object ObterDadosFiltrados(string itemSelecionado, string descricao)
        {
            switch (itemSelecionado)
            {
                case "Material":
                    return context.Materials
                                   .Where(m => m.material.Contains(descricao))
                                   .Select(m => new { m.id, m.material, m.valor_unidade })
                                   .ToList();
                case "Mão de obra":
                    return context.MaoDeObras
                                   .Where(mo => mo.Nome_cargo.Contains(descricao))
                                   .Select(mo => new { mo.cargosID, mo.Nome_cargo, mo.valor_cargo })
                                   .ToList();
                case "Diversos":
                    return context.Diversoss
                                   .Where(d => d.Descricao.Contains(descricao))
                                   .Select(d => new { d.CategoriaID, d.Descricao, d.valor_diversos })
                                   .ToList();
                default:
                    return null;
            }
        }

        private object ObterDados(string itemSelecionado)
        {
            switch (itemSelecionado)
            {
                case "Material":
                    return context.Materials
                                   .Select(m => new { m.id, m.material, m.valor_unidade })
                                   .ToList();
                case "Mão de obra":
                    return context.MaoDeObras
                                   .Select(mo => new { mo.cargosID, mo.Nome_cargo, mo.valor_cargo })
                                   .ToList();
                case "Diversos":
                    return context.Diversoss
                                   .Select(d => new { d.CategoriaID, d.Descricao, d.valor_diversos })
                                   .ToList();
                default:
                    return null;
            }
        }



        private void cbtabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarDados();
            habilitabotoes(false);
            habilitacampos(true);


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
                consultarDados();
            }
        }

        private void AlterarCliente(int id, string nome, float valor, AppDbcontext context)
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
                context.SaveChanges();
                consultarDados();
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
            AppDbcontext context = new AppDbcontext();
            int ids = int.Parse(tbid.Text);
            AlterarCliente(ids, tbdescricao.Text, (float)numericUpDown1.Value, context);
            limpacampos();
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
        }

        private void bnovo_Click(object sender, EventArgs e)
        {
            bnovo.Enabled = false;
            cbtabela.Enabled = true;


        }

        private void dgvconsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


                baseDeDados.SaveChanges();
            }
        }
        private void bexcluir_Click(object sender, EventArgs e)
        {
            excluir();
            consultarDados();
            limpacampos();
            string itemSelecionado = cbtabela.SelectedItem?.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}





