using Sistema_Grifo.contexto;
using Sistema_Grifo.Modelo;
using System;
using System.Collections.Generic;
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
        float alturaSpda = (float)u.PublicNudAltura.Value;
        var descidas = 0;
        var anelDeEquilibrio = 0;
         switch (int.Parse(u.PublicCbnp.Text))
            
                case 1:
                case 2:
                    descidas = (int) perimetroSpda / 10;
        anelDeEquilibrio = (int) perimetroSpda / 10;

                    break;
                case 3:
                    descidas = (int) perimetroSpda / 15;
        anelDeEquilibrio = (int) perimetroSpda / 15;
                    break;
                case 4:
                    descidas = (int) perimetroSpda / 20;
        anelDeEquilibrio = (int) perimetroSpda / 20;
                    break;
        
            

        private void Captor()
        {
            


            float perimetroSpda = (float)u.PublicNudPerimetro.Value;


           

        }





    }
}


