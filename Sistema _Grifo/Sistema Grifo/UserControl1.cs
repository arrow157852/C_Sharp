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

namespace Sistema_Grifo
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbtabela.SelectedItem != null && cbtabela.SelectedItem.ToString().Equals("Mão de obra"))
            {
                if (!string.IsNullOrEmpty(tbdescricao.Text))
                {
                    using (var baseDeDados = new AppDbcontext())
                    {

                        try
                        {
                            var maoDeObra = new MaoDeObra
                            {
                                Nome_cargo = tbdescricao.Text,
                                valor_cargo = float.Parse(tbvalor.Text)
                            };
                            baseDeDados.MaoDeObras.Add(maoDeObra);

                            baseDeDados.SaveChanges();
                            MessageBox.Show("registro realizado com  suceso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro ao atualizar banco de dados: " + ex.Message + "\nStackTrace: " + ex.StackTrace + ex.Source, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(ex.Message); Console.WriteLine(ex.Source); Console.WriteLine(ex.StackTrace);

                        }
                    }

                }
                else if (cbtabela.SelectedItem != null && cbtabela.SelectedItem.ToString().Equals("Material"))
                {
                    if (!string.IsNullOrEmpty(tbdescricao.Text))
                    {
                        using (var baseDeDados = new AppDbcontext())
                        {
                            try
                            {
                                var material = new Material
                                {
                                    material = tbdescricao.Text,
                                    valor_unidade = float.Parse(tbvalor.Text)
                                };
                                baseDeDados.Materials.Add(material);

                                baseDeDados.SaveChanges();
                                MessageBox.Show("registro realizado com  suceso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Erro ao atualizar banco de dados: " + ex.Message + "\nStackTrace: " + ex.StackTrace + ex.Source, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Console.WriteLine(ex.Message); Console.WriteLine(ex.Source); Console.WriteLine(ex.StackTrace);

                            }

                        }

                    }
                    else if (cbtabela.SelectedItem != null && cbtabela.SelectedItem.ToString().Equals("Diversos"))
                    {
                        if (!string.IsNullOrEmpty(tbdescricao.Text))
                        {
                            using (var baseDeDados = new AppDbcontext())
                            {
                                try
                                {
                                    var diversos = new Diversos
                                    {
                                        Descricao = tbdescricao.Text,
                                        valor_diversos = float.Parse(tbvalor.Text)
                                    };
                                    baseDeDados.Diversoss.Add(diversos);

                                    baseDeDados.SaveChanges();
                                    MessageBox.Show("registro realizado com  suceso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Erro ao atualizar banco de dados: " + ex.Message + "\nStackTrace: " + ex.StackTrace + ex.Source, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Console.WriteLine(ex.Message); Console.WriteLine(ex.Source); Console.WriteLine(ex.StackTrace);

                                }

                            }

                        }
                        else
                        {

                            MessageBox.Show("Por favor, insira um nome de cargo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // ou outra ação adequada

                        }


                    }
                }


            }
        }
    }
}

