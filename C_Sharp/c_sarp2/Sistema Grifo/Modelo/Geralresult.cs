using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Grifo.Modelo
{
    internal class Geralresult
    {
        public int id { get; set; }
        public String item { get; set; }
        public int CategoriaID { get; set; }
        public float valor_unidade { get; set; }
    }
}
