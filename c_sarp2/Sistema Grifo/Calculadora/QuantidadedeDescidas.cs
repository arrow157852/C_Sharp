using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Grifo.Calculadora
{
    internal class QuantidadedeDescidas
    {
        public struct ValoresQuantidade
        {
            public int Descidas;
            public int AnelDeEquilibrio;
        }
        public ValoresQuantidade quantDescidas()
        {
            UserControl2 u = new UserControl2();
            int descidas = 0;
            int anelDeEquilibrio= 0;
            int publicCbnpValue = int.Parse(u.cbnp.Text);
            float perimetroSpda = (float)u.nudperimetro.Value;
            float alturaSpda = (float)u.nudaltura.Value;

            if (publicCbnpValue == 1 || publicCbnpValue == 2)
            {
                descidas = (int)perimetroSpda / 12;
                anelDeEquilibrio = (int)(alturaSpda / 10 - 1);
            }
            else if (publicCbnpValue == 3)
            {
                descidas = (int)perimetroSpda / 18;
                anelDeEquilibrio = (int)(alturaSpda / 15 - 1);
            }
            else if (publicCbnpValue == 4)
            {

                descidas = (int)perimetroSpda / 24;
                anelDeEquilibrio = (int)(alturaSpda / 20 - 1);
            }
            return new ValoresQuantidade { Descidas = descidas, AnelDeEquilibrio = anelDeEquilibrio };
        }
       
    }
}

