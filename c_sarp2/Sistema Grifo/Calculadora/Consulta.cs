using Sistema_Grifo.contexto;
using System;
using System.Collections.Generic;
using System.Linq;
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
                dataGridView.Columns[0].Visible = false;
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
                    case "tabelaTemporaria":
                        return context.tabelaTemporarias
                                        .Select(d => new { d.temporarioID,d.descricao, d.valor, d.quantidade, d.valorTotal })
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
                                       .Select(d => new { d.temporarioID,d.descricao, d.valor, d.quantidade, d.valorTotal })
                                       .ToList();
                    default:
                        return null;
                }
            }

        }
    }
}