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

        public void uniao(string material, bool botao)
        {
            var consulta = new Consulta();
            if (idsmaterialdescidas != null && idsmaterialCaptor != null && idsmaterialaterramento != null)
            {
                idsmaterial = idsmaterialdescidas.Union(idsmaterialCaptor.Union(idsmaterialaterramento)).ToList();
            }
            else if (idsmaterialdescidas != null && idsmaterialCaptor != null)
            {
                idsmaterial = idsmaterialdescidas.Union(idsmaterialCaptor).ToList();
            }
            else if (idsmaterialaterramento != null && idsmaterialdescidas != null)
            {
                idsmaterial = idsmaterialdescidas.Union(idsmaterialaterramento).ToList();
            }
            else if (idsmaterialCaptor != null && idsmaterialaterramento != null)
            {
                idsmaterial = idsmaterialCaptor.Union(idsmaterialaterramento).ToList();
            }
            else
            {
                if (idsmaterialCaptor != null)
                {
                    idsmaterial = idsmaterialCaptor.ToList();
                }
                else if (idsmaterialaterramento != null)
                {
                    idsmaterial = idsmaterialaterramento.ToList();
                }
                else
                {
                    idsmaterial = idsmaterialdescidas.ToList();
                }
            }
            if (botao)
                consulta.inserir(idsmaterial, material, "Material");
        }
        public void descida(float perimetroSpda, float alturaSpda, string material, string np)
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
                    anelDeEquilibrio = (int)(alturaSpda / 15 - 1);
                }
                else if (np.Equals("4"))
                {

                    descidas = (int)perimetroSpda / 24;
                    anelDeEquilibrio = (int)(alturaSpda / 20 - 1);
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
                    int barraChatas = barraChatasanel + barraChatasdecidas;
                    int quantparafusoDe6mm = (int)((barraChatasanel + barraChatasdecidas) * 8);
                    int quantparafusoDeemenda = (int)((barraChatasdecidas) * 2);
                    int quantparafusoDe8mm = (int)(descidas * 4);
                    idsmaterialdescidas = new List<int> { 42, 74, 75, 76 };
                    quantidsmaterialdescidas = new List<int> { barraChatas, quantparafusoDe6mm, quantparafusoDeemenda, quantparafusoDe8mm };
                    total(idsmaterialdescidas, quantidsmaterialdescidas, "Material");















                    diasProtecaoMecanica = (diasDescidas / 6);

                    diasAnel = (((barraChatasdecidas + barraChatasanel) * 6) / 36);
                    diasDescidas = (((barraChatasdecidas + barraChatasanel) * 6) / 48);
                    context.SaveChanges();


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
                    int cobre = cobredescidas + cobreAnel;
                    int afastador = cobredescidas + cobreAnel;
                    int parafusoDe6mm = afastador;
                    diasAnel = ((cobredescidas + cobreAnel) / 36);
                    diasDescidas = ((cobredescidas + cobreAnel) / 48);

                    diasProtecaoMecanica = (diasDescidas / 6);
                    idsmaterialdescidas = new List<int> { 5, 52, 76 };
                    quantidsmaterialdescidas = new List<int> { cobre, afastador, parafusoDe6mm };
                    total(idsmaterialdescidas, quantidsmaterialdescidas, "Material");



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
                    int presilha = cordoalhaAnel + cordoalhaDescidas;
                    int cordoalha = cordoalhaDescidas + cordoalhaAnel;
                    int parafusoDe6mm = presilha;
                    int parafusoDe8mm = (int)(descidas * 4);
                    diasAnel = ((cordoalhaDescidas + cordoalhaAnel) / 36);
                    diasDescidas = ((cordoalhaDescidas + cordoalhaAnel) / 48);

                    diasProtecaoMecanica = (diasDescidas / 6);

                    idsmaterialdescidas = new List<int> { 8, 53, 75, 76 };
                    quantidsmaterialdescidas = new List<int> { cordoalha, presilha, parafusoDe6mm, parafusoDe8mm };
                    total(idsmaterialdescidas, quantidsmaterialdescidas, "Material");



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
                    int rebar = rebarDescidas + rebarAnel;
                    int clips = (rebarAnel + rebarDescidas) * 3;
                    int aterrainsert = descidas * 2;
                    diasAnel = anelDeEquilibrio;
                    diasDescidas = (int)(alturaSpda / 2.88);
                    idsmaterialdescidas = new List<int> { 2, 24, 1 };
                    quantidsmaterialdescidas = new List<int> { rebar, clips, aterrainsert };
                    total(idsmaterialdescidas, quantidsmaterialdescidas, "Material");


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
                    int cordoalha = descidas * 4;
                    int clips = cordoalha;
                    idsmaterialaterramento = new List<int> { 9, 24 };
                    
                    quantidsmaterialdescidas = new List<int> { cordoalha, clips };
                    total(idsmaterialaterramento, quantidsmaterialdescidas, "Material");



                }
                else if (material == "rebar")
                {
                    int rebar = descidas * 12;
                    int clips = rebar * 3;
                    idsmaterialaterramento = new List<int> { 3, 24 };
                    quantidsmaterialdescidas = new List<int> { rebar, clips };
                    total(idsmaterialaterramento, quantidsmaterialdescidas, "Material");

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
                    int barraChatas = (int)perimetrocaptor / 6;
                    int miniMastro = (int)perimetroSpda / 5;
                    int mastro = 1;
                    int vedaCalha = (int)(perimetrocaptor * 0.03);
                    int parafusoDe6mm = barraChatas * 8;
                    idsmaterialCaptor = new List<int> { 42, 59, 68, 39 };

                    diasCaptor = ((barraChatas * 6) / 108);
                    quantidsmaterialdescidas = new List<int> { barraChatas, miniMastro, mastro, vedaCalha, parafusoDe6mm };
                    total(idsmaterialCaptor, quantidsmaterialdescidas, "Material");

                }
                else if (material == "Cobre")
                {
                    int cobre = (int)(perimetrocaptor + (perimetrocaptor * 0.2));
                    int afastador = cobre;
                    int mastro = 1;
                    int vedaCalha = (int)(perimetrocaptor * 0.03);
                    int parafusoDe6mm = cobre;
                    idsmaterialCaptor = new List<int> { 42, 59, 68, 39 };
                    quantidsmaterialdescidas = new List<int> { cobre, afastador, mastro, vedaCalha, parafusoDe6mm };
                    total(idsmaterialCaptor, quantidsmaterialdescidas, "Material");

                    diasCaptor = (cobre / 108);
                }

            }
        }
        public void total(List<int> lista, List<int> quantidades, string itemselecionado)
        {
            var consulta = new Consulta();
           

            using (AppDbcontext context = new AppDbcontext())
            {
                dynamic dados = null;

                foreach (var item in lista)
                {
                    dados = consulta.SelectGeralResult(item, itemselecionado);

                    foreach (var result in dados)
                    {
                        foreach (var quantidade in quantidades)
                        {
                            var valorTotal = quantidade * result.valor_unidade;

                            var  material = new TabelaTemporaria
                            {
                                descricao = result.descricao,
                                valor = result.valor_unidade,
                                quantidade = quantidade,
                                valorTotal = valorTotal,
                                CategoriaID = result.CategoriaID,
                            };
                            context.tabelaTemporarias.Add(material);

                        }
                        
                    }
                }

                context.SaveChanges();
            }
        } }}

    








