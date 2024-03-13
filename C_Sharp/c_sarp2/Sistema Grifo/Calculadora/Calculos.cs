using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Sistema_Grifo.contexto;
using Sistema_Grifo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Sistema_Grifo.Calculadora
{
    public class Calculos
    {
        QuantidadedeDescidas quantDescidas = new QuantidadedeDescidas();


        public void descidas()
        {
            using (UserControl2 u = new UserControl2())
            {
                float perimetroSpda = (float)u.nudperimetro.Value;
                float alturaSpda = (float)u.nudaltura.Value;
                string material = u.cbmaterial.Text;
                var descidas = quantDescidas.quantDescidas().Descidas;
                var anelDeEquilibrio = quantDescidas.quantDescidas().AnelDeEquilibrio;

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

                    int parafusoDe6mm = (int)((barraChatasanel + barraChatasdecidas) * 8);
                    int parafusoDeemenda = (int)((barraChatasdecidas) * 2);
                    int parafusoDe8mm = (int)(descidas * 4);
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
                    int afastador = cobredescidas + cobreAnel;
                    int parafusoDe6mm = afastador;
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

                    int parafusoDe6mm = presilha;
                    int parafusoDe8mm = (int)(descidas * 4);
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
                    int clips = (rebarAnel + rebarDescidas) * 3;
                    int aterrainsert = descidas * 2;
                }
            }
        }

        public void aterramento()
        {
            using (UserControl2 u = new UserControl2())
            {
                string material = u.cbmaterial.Text;
                float perimetroSpda = (float)u.nudperimetro.Value;
                var descidas = quantDescidas.quantDescidas().Descidas;
                var anelDeEquilibrio = quantDescidas.quantDescidas().AnelDeEquilibrio;

                if (material == "Barra chata" || material == "Cordoalha" || material == "cobre")
                {
                    int cordoalha = descidas * 4;
                    int clips = cordoalha;
                }
                else if (material == "rebar")
                {
                    int rebar = descidas * 12;
                    int clips = rebar * 3;
                }
            }
        }
        public void Captor()
        {
            using (UserControl2 u = new UserControl2())
            {
                string material = u.cbmaterial.Text;
                float perimetroSpda = (float)u.nudperimetro.Value;
                float perimetrocaptor = (float)u.nudpcaptor.Value;

                if (material == "Barra chata" || material == "Cordoalha" || material == "Rebar")
                {
                    int barraChatas = (int)perimetrocaptor / 6;
                    int miniMastro = (int)perimetroSpda / 5;
                    int mastro = 1;
                    int vedaCalha = (int)(perimetrocaptor * 0.03);
                    int parafusoDe6mm = barraChatas * 8;
                }
                else if (material == "Cobre")
                {
                    int cobre = (int)(perimetrocaptor + (perimetrocaptor * 0.2));
                    int afastador = cobre;
                    int mastro = 1;
                    int vedaCalha = (int)(perimetrocaptor * 0.03);
                    int parafusoDe6mm = cobre;
                }
            }
        }
    }
}






