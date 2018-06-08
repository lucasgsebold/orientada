using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Modelo
{
    public class Conta
    {
        public int cnt_numero { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public double valor { get; set; }
        public string tipo { get; set; }
        public string situacao { get; set; }
        public int pes_codigo { get; set; }
    }
}
