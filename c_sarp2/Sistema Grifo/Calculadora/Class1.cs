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
    internal class Class1

    {
        AppDbcontext context = new AppDbcontext();
        UserControl2 u = new UserControl2();
        private void descidas() {
            float perimetroSpda = (float)u.PublicNudPerimetro.Value;
            float alturaSpda = (float)u.PublicNudAltura.Value;
            string material = u.PublicCbMaterial.Text;
            var descidas = 0;
            var anelDeEquilibrio = 0;
            int publicCbnpValue = int.Parse(u.PublicCbnp.Text);

            if (publicCbnpValue == 1 || publicCbnpValue == 2)
            {
                descidas = (int)perimetroSpda / 12;
                anelDeEquilibrio = (int)perimetroSpda / 10;
            }
            else if (publicCbnpValue == 3)
            {
                descidas = (int)perimetroSpda / 18;
                anelDeEquilibrio = (int)perimetroSpda / 15;
            }
            else if (publicCbnpValue == 4)
            {
                descidas = (int)perimetroSpda / 24;
                anelDeEquilibrio = (int)perimetroSpda / 20;
            }


            if (material == "Barra chata" )
            {
                int barraChatasdecidas = (int)((alturaSpda/6)*descidas);
                int barraChatasanel = (int)(anelDeEquilibrio * (perimetroSpda / 6));
                int parafusoDe6mm = (int)((barraChatasanel + barraChatasdecidas) * 8);
                
                
            }
            else if (material == "cobre")
            {
                int cobre = (int)(perimetrocaptor + (perimetrocaptor * 0.2));

            }
            else if (material == "cobre")
            {
                int cobre = (int)(perimetrocaptor + (perimetrocaptor * 0.2));

            }
            else if (material == "cobre")
            {
                int cobre = (int)(perimetrocaptor + (perimetrocaptor * 0.2));

            }


        }


        private void Captor()
        {
            string  material = u.PublicCbMaterial.Text;
            float perimetroSpda = (float)u.PublicNudPerimetro.Value;
            float perimetrocaptor = (float)u.PublicNudPcaptor.Value;



            if (material == "Barra chata"|| material == "Cordoalha"|| material == "Rebar")
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


