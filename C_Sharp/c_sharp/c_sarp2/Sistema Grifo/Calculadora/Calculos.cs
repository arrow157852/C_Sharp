using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using Sistema_Grifo.contexto;
using Sistema_Grifo.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using Newtonsoft.Json;
using Microsoft.VisualBasic.Logging;
using MySqlX.XDevAPI.Common;
using Serilog;
using Log = Serilog.Log;
using Microsoft.Extensions.Options;
using Mysqlx.Session;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Grifo.Calculadora
{
    public class Calculos
    {
        int diasCaptor;
        int diasAnel;
        int diasDescidas;
        int diasAterramento;
        int diasProtecaoMecanica;
        public List<int> idsmaterial { get; set; }

        public List<int> idsMaodeObra { get; set; }
        public List<int> idsmaterialdescidas { get; set; }
        public List<int> idsmaterialaterramento { get; set; }
        public List<int> idsmaterialCaptor { get; set; }
        public List<int> quantidsmaterialdescidas { get; set; }
        public List<int> idsmaterialdescidasGeral { get; set; }
        public List<int> idsmaterialdescidasGerais { get; set; }
        public List<int> quantidadecaptor { get; set; }
        public List<int> quantidadeaterrameno { get; set; }
        int barraChata = 0;
        int parafusoDe6mm = 0;
        int parafusoDeEmenda = 0;
        int parafusoDe8mm = 0;
        int cobre = 0;
        int afastador = 0;
        
        int cordoalha = 0;
        int presilha = 0;
        
        int rebar = 0;
        int clips = 0;
        int aterrainsert = 0;
        int miniMastro = 0;
        int mastro = 0;
        int vedaCalha = 0;
        int barraChatadescida = 0;
        int parafusoDe6mmdescida = 0;
        int parafusoDeEmendadescida = 0;
        int parafusoDe8mmdescida = 0;
        int cobredescida = 0;
        int afastadordescida = 0;
        
        int presilhadescida = 0;
        int cordoalhadescida = 0;
        
        int rebardescida = 0;
        int clipsdescida = 0;
        int aterrainsertdescida = 0;
        int cordoalhaaterramento = 0;
        int clipsaterramento = 0;
        int rebaraterramento = 0;
        int barraChataCaptor = 0;
        int parafusoDe6mmCaptor = 0;
        int cobreCaptor = 0;

        public void Uniao(string material, bool botao)
        {
            var consulta = new Consulta();
            if (idsmaterialdescidas != null || idsmaterialCaptor != null || idsmaterialaterramento != null)
            {
                idsmaterial = new List<int>();
                List<int> idsmaterialdescidasGerais = new List<int>();

                if (idsmaterialdescidas != null || idsmaterialCaptor != null || idsmaterialaterramento != null)
                {
                    idsmaterial.AddRange(idsmaterialdescidas ?? Enumerable.Empty<int>());
                    idsmaterial.AddRange(idsmaterialCaptor ?? Enumerable.Empty<int>());
                    idsmaterial.AddRange(idsmaterialaterramento ?? Enumerable.Empty<int>());

                    if (material.Equals("Barra chata") || material.Equals("Cobre") || material.Equals("Rebar") ||
                        material.Equals("Cordoalha"))
                    {
                        idsmaterialdescidasGerais.AddRange(Enumerable.Range(1, 12));
                    }

                }
                if (quantidadeaterrameno!=null || quantidadecaptor!=null || quantidsmaterialdescidas!=null)
                {
                    if (material == "Barra chata")
                    {
                        barraChata = barraChataCaptor + barraChatadescida;
                        parafusoDe6mm = parafusoDe6mmCaptor+ parafusoDe6mmdescida;
                        parafusoDeEmenda = parafusoDeEmendadescida;
                        parafusoDe8mm = parafusoDe8mmdescida;
                        cobre= cobreCaptor+ cobredescida;
                        afastador = cobre;
                        cordoalha = cordoalhaaterramento + cordoalhadescida;
                        presilha = presilhadescida;
                        clips= clipsaterramento+clipsdescida;
                       

                        quantidsmaterialdescidas = new List<int> { barraChata, parafusoDe6mm, parafusoDeEmenda, parafusoDe8mm,miniMastro,mastro,vedaCalha ,cordoalha,clips};
                    }
                    else if (material == "Cobre")
                    {
                        quantidsmaterialdescidas = new List<int> { cobre, afastador, parafusoDe6mm, miniMastro, mastro, vedaCalha };
                    }
                    else if (material == "Cordoalha")
                    {
                        quantidsmaterialdescidas = new List<int> { cordoalha, presilha, parafusoDe6mm, parafusoDe8mm ,miniMastro, mastro, vedaCalha }; ;
                    }
                    else if (material == "Rebar")
                    {
                        quantidsmaterialdescidas = new List<int> { rebar, clips, aterrainsert, barraChata, parafusoDe6mm, miniMastro, mastro, vedaCalha };
                    }

                }


                if (botao)
                {
                    consulta.inserir(idsmaterial.Distinct().ToList(), material, "Material");
                    total(idsmaterialdescidasGerais.Distinct().ToList(), quantidsmaterialdescidas.ToList());
                }
            }
        }


        public void descida(float perimetroSpda, float alturaSpda, string material,string np)
        {
            var consulta = new Consulta();
            using (UserControl2 u = new UserControl2())
            using (var context = new AppDbcontext())



            {
                int descidas = 0;
                int anelDeEquilibrio = 0;

                if (np.Equals("1") || np.Equals("2"))
                {
                    descidas = (int)perimetroSpda / 12;
                    anelDeEquilibrio = (int)((alturaSpda / 10) - 1);
                }
                else if (np.Equals("3"))
                {
                    descidas = (int)perimetroSpda / 18;
                    anelDeEquilibrio = (int)(alturaSpda / 15) - 1;
                }
                else if (np.Equals("4"))
                {

                    descidas = (int)perimetroSpda / 24;
                    anelDeEquilibrio = (int)(alturaSpda / 20) - 1;
                }






                if (material == "Barra chata")
                {
                    int barraChatasdecidas = (int)((alturaSpda / 6) * descidas);
                    int barraChatasanel;
                    if (anelDeEquilibrio > 1)
                    {
                        barraChatasanel = (int)((anelDeEquilibrio * (perimetroSpda / 6)));
                    }
                    else
                    {
                        barraChatasanel = 0;
                    }
                     barraChatadescida = barraChatasanel + barraChatasdecidas;
                    parafusoDe6mmdescida = (int)((barraChatasanel + barraChatasdecidas) * 8);
                    parafusoDeEmendadescida = (int)((barraChatasdecidas) * 2);
                    parafusoDe8mmdescida = (int)(descidas * 4);
                    idsmaterialdescidas = new List<int> { 42, 74, 75, 76 };

                    















                    diasProtecaoMecanica = (diasDescidas / 6);

                    diasAnel = ((barraChatasdecidas + barraChatasanel) * 6) / 36;
                    diasDescidas = ((barraChatasdecidas + barraChatasanel) * 6) / 48;






                }
                else if (material == "cobre")
                {
                    int cobredescidas = (int)(alturaSpda * descidas);
                    int cobreAnel;
                    if (anelDeEquilibrio > 1)
                    {
                        cobreAnel = (int)((anelDeEquilibrio * (perimetroSpda / 6)));
                    }
                    else
                    {
                        cobreAnel = 0;
                    }
                    cobredescida = cobredescidas + cobreAnel;
                    afastadordescida = cobredescidas + cobreAnel;
                    parafusoDe6mmdescida = afastador;
                    diasAnel = ((cobredescidas + cobreAnel) / 36);
                    diasDescidas = ((cobredescidas + cobreAnel) / 48);

                    diasProtecaoMecanica = (diasDescidas / 6);
                    idsmaterialdescidas = new List<int> { 5, 52, 76 };
                    
                    



                }
                else if (material == "Cordoalha")
                {
                    int cordoalhaDescidas = (int)(alturaSpda * descidas);
                    int cordoalhaAnel;
                    if (anelDeEquilibrio > 1)
                    {
                        cordoalhaAnel = (int)((anelDeEquilibrio * (perimetroSpda / 6)));
                    }
                    else
                    {
                        cordoalhaAnel = 0;
                    }
                    presilhadescida = cordoalhaAnel + cordoalhaDescidas;
                    cordoalhadescida = cordoalhaDescidas + cordoalhaAnel;
                    parafusoDe6mmdescida = presilha;
                    parafusoDe8mmdescida = (int)(descidas * 4);
                    diasAnel = ((cordoalhaDescidas + cordoalhaAnel) / 36);
                    diasDescidas = ((cordoalhaDescidas + cordoalhaAnel) / 48);

                    diasProtecaoMecanica = (diasDescidas / 6);

                    idsmaterialdescidas = new List<int> { 8, 53, 75, 76 };
                    
                    


                }
                else if (material == "Rebar")
                {
                    int rebarDescidas = (int)(alturaSpda / 3) * descidas;
                    int rebarAnel;
                    if (anelDeEquilibrio > 1)
                    {
                        rebarAnel = (int)((anelDeEquilibrio * (perimetroSpda / 6)));
                    }
                    else
                    {
                        rebarAnel = 0;
                    }
                    rebardescida = rebarDescidas + rebarAnel;
                    clipsdescida = (rebarAnel + rebarDescidas) * 3;
                    aterrainsertdescida = descidas * 2;
                    diasAnel = anelDeEquilibrio;
                    diasDescidas = (int)(alturaSpda / 2.88);
                    idsmaterialdescidas = new List<int> { 2, 24, 1 };
                    
                    


                }




            }


        }

        public void maoDeObra(string material)
        {
            var consulta = new Consulta();
            idsMaodeObra = new List<int> { 15, 16 };
            consulta.inserir(idsMaodeObra, material, "Mao de obra");
        }

        public void aterramento(float perimetroSpda, float alturaSpda, string material, string np)
        {
            var consulta = new Consulta();
            using (UserControl2 u = new UserControl2())
            {
                int descidas = 0;
                int anelDeEquilibrio = 0;

                if (np.Equals("1") || np.Equals("2"))
                {
                    descidas = (int)perimetroSpda / 12;
                    anelDeEquilibrio = (int)((alturaSpda / 10) - 1);
                }
                else if (np.Equals("3"))
                {
                    descidas = (int)perimetroSpda / 18;
                    anelDeEquilibrio = (int)(alturaSpda / 15 - 1);
                }
                else if (np.Equals("4"))
                {

                    descidas = (int)perimetroSpda / 24;
                    anelDeEquilibrio = (int)(alturaSpda / 20 - 1);
                }


                if (material == "Barra chata" || material == "Cordoalha" || material == "cobre")
                {
                    cordoalhaaterramento = descidas * 4;
                    clipsaterramento = descidas*4;
                    idsmaterialaterramento = new List<int> { 9, 24 };

                   
                   



                }
                else if (material == "rebar")
                {
                    rebaraterramento = descidas * 12;
                    clipsaterramento = rebar * 3;
                    idsmaterialaterramento = new List<int> { 3, 24 };
                   
                   

                }
                diasAterramento = descidas / 6;
            }
        }
        public void Captor(float perimetroSpda, float alturaSpda, string material, float perimetrocaptor)
        {
            var consulta = new Consulta();
            using (UserControl2 u = new UserControl2())
            using (AppDbcontext context = new AppDbcontext())
            {


                if (material == "Barra chata" || material == "Cordoalha" || material == "Rebar")
                {
                    barraChataCaptor = (int)perimetrocaptor / 6;
                     miniMastro = (int)perimetroSpda / 5;
                     mastro = 1;
                     vedaCalha = (int)(perimetrocaptor * 0.03);
                    parafusoDe6mmCaptor = barraChata * 8;
                    idsmaterialCaptor = new List<int> { 42, 59, 68, 39 };

                    diasCaptor = ((barraChata * 6) / 108);
                    quantidadecaptor = new List<int> { barraChata, miniMastro, mastro, vedaCalha, parafusoDe6mm };
                    

                }
                else if (material == "Cobre")
                {
                    cobreCaptor = (int)(perimetrocaptor + (perimetrocaptor * 0.2));
                     afastador = cobre;
                     mastro = 1;
                     vedaCalha = (int)(perimetrocaptor * 0.03);
                     parafusoDe6mm = cobre;
                    idsmaterialCaptor = new List<int> { 42, 59, 68, 39 };
                    quantidadecaptor = new List<int> { cobre, afastador, mastro, vedaCalha, parafusoDe6mm };
                    

                    diasCaptor = (cobre / 108);
                }

            }
        }
        public void total(List<int> lista, List<int> quantidades)
        {
            using (AppDbcontext context = new AppDbcontext())
            {
                var materiaisSelecionados = context.GeralResults
                    .Where(m => lista.Contains(m.id))
                    .ToList();

                if (materiaisSelecionados.Any())
                {
                    var materiaisAgrupados = materiaisSelecionados.GroupBy(m => m.item);

                    foreach (var grupo in materiaisAgrupados)
                    {
                        int quantidadeTotal = 0;
                        float valorTotal = 0;

                        foreach (var material in grupo)
                        {
                            // Encontra a quantidade correspondente ao ID do material na lista de quantidades
                            int indice = lista.IndexOf(material.id);
                            if (indice != -1 && indice < quantidades.Count)
                            {
                                int quantidadeMaterial = quantidades[indice];
                                quantidadeTotal += quantidadeMaterial;
                                valorTotal += material.valor_unidade * quantidadeMaterial;
                            }
                        }

                        var materialComValorTotal = new TabelaTemporaria
                        {
                            descricao = grupo.Key, // chave é o item
                            CategoriaID = grupo.First().CategoriaID,
                            valor = grupo.First().valor_unidade,
                            quantidade = quantidadeTotal,
                            valorTotal = valorTotal
                        };

                        context.tabelaTemporarias.Add(materialComValorTotal);
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}














