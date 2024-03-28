using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Sistema_Grifo.contexto;
using Sistema_Grifo.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Grifo.Calculadora
{
    internal class Consulta
    {




        public void ConsultarDados(string descricao, string itemSelecionado, DataGridView dataGridView)
        {
            try
            {
                if (string.IsNullOrEmpty(descricao))
                {
                    dataGridView.DataSource = ObterDados(itemSelecionado);
                }
                else
                {
                    dataGridView.DataSource = ObterDadosFiltrados(itemSelecionado, descricao);
                }

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }



        public object ObterDados(string itemSelecionado)
        {

            using (AppDbcontext context = new AppDbcontext())
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
                                       .Select(d => new { d.CustoID, d.Descricao, d.valor_diversos })
                                       .ToList();
                    case "TabelaTemporaria":
                        return context.tabelaTemporarias
                                        .Select(d => new { d.temporarioID, d.descricao, d.valor, d.quantidade, d.valorTotal })
                                        .ToList();
                    default:
                        return null;
                }
            }
        }


        public object ObterDadosFiltrados(string itemSelecionado, string descricao)
        {

            using (AppDbcontext context = new AppDbcontext())
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
                                       .Select(d => new { d.CustoID, d.Descricao, d.valor_diversos })
                                       .ToList();
                    case "TabelaTemporaria":
                        return context.tabelaTemporarias
                                       .Where(d => d.descricao.Contains(descricao))
                                       .Select(d => new { d.temporarioID, d.descricao, d.valor, d.quantidade, d.valorTotal })
                                       .ToList();
                    default:
                        return null;
                }

            }

        }
        public void inserir(List<int> idsmaterial, string itemCombobox, string tabela)
        {
            using (AppDbcontext context = new AppDbcontext())
            {

                foreach (var itemId in idsmaterial)
                {

                    var novoRegistro = new Geralresult();
                    switch (tabela)
                    {
                        case "Material":
                            var produtoMaterial = context.Materials.FirstOrDefault(p => p.id == itemId);
                            if (produtoMaterial != null)
                            {
                                novoRegistro.valor_unidade = produtoMaterial.valor_unidade;
                                novoRegistro.CategoriaID = produtoMaterial.CategoriaID;
                                novoRegistro.item = produtoMaterial.material;
                                context.GeralResults.Add(novoRegistro);
                            }
                            break;

                        case "Mao de obra":
                            var produtoMaoDeObra = context.MaoDeObras.FirstOrDefault(p => p.cargosID == itemId);
                            if (produtoMaoDeObra != null)
                            {
                                novoRegistro.valor_unidade = produtoMaoDeObra.valor_cargo;
                                novoRegistro.CategoriaID = produtoMaoDeObra.CategoriaID;
                                novoRegistro.item = produtoMaoDeObra.Nome_cargo;
                                context.GeralResults.Add(novoRegistro);
                            }
                            break;

                        case "Custos diversos":
                            var produtoDiversos = context.Diversoss.FirstOrDefault(p => p.CustoID == itemId);
                            if (produtoDiversos != null)
                            {
                                novoRegistro.valor_unidade = produtoDiversos.valor_diversos;
                                novoRegistro.CategoriaID = produtoDiversos.CategoriaID;
                                novoRegistro.item = produtoDiversos.Descricao;
                                context.GeralResults.Add(novoRegistro);
                            }
                            break;

                        default:
                            // Trate aqui o caso em que o nome da tabela não é reconhecido
                            break;
                    }
                }
                context.SaveChanges();
            }
        }
        public void consultaTabelaTemporaria(NumericUpDown nudtotal, NumericUpDown nudimposto, NumericUpDown nudtotalimposto, NumericUpDown nudimp, NumericUpDown nudmmao, NumericUpDown nudmmaterial, NumericUpDown nudmargemmao, NumericUpDown nudmargemmaterial, NumericUpDown nudcomissao)
        {
            using (AppDbcontext context = new AppDbcontext())
            {


                float total = context.tabelaTemporarias.Sum(m => m.valorTotal);
                nudtotal.Value = (decimal)total;

                var totalmaodeobra = context.tabelaTemporarias.Where(m => m.CategoriaID == 1).Sum(m => m.valorTotal);
                var totalmaterial = context.tabelaTemporarias.Where(m => m.CategoriaID == 2).Sum(m => m.valorTotal);

                // Calculate nudmmao.Value and nudmmaterial.Value, ensure to handle division by zero if necessary
                nudmmao.Value = totalmaodeobra == 0 ? 0 : (decimal)((((float)nudmargemmao.Value * totalmaodeobra) / 100));
                nudmmaterial.Value = totalmaterial == 0 ? 0 : (decimal)((((float)nudmargemmaterial.Value * totalmaterial) / 100));

                var totalscomissao = (float)(nudmmaterial.Value + nudmmao.Value);
                var comissao = (((float)nudcomissao.Value * totalscomissao) / 100);

                float imposto = (((float)nudimp.Value * (comissao+totalscomissao)) / 100);
                nudimposto.Value = (decimal)imposto;

                nudtotalimposto.Value = (decimal)((float)nudtotal.Value + (float)nudmargemmaterial.Value+ (float)nudmargemmao.Value+(float)nudimposto.Value);
            }


        }


    }
}





