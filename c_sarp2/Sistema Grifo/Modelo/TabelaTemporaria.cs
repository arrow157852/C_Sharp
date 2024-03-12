using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Grifo.Modelo
{
    internal class TabelaTemporaria
    {
        public int temporarioID { get; set; }
        public String descricao { get; set; }
        public float valorTotal  { get; set; }
        public int quantidade { get; set; }
        public int CategoriaID { get; set; }
        public float valor  { get; set; }
    }
}
