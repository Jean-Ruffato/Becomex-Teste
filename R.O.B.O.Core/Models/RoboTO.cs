using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.O.B.O.Core.Models
{
    public class RoboTO
    {
        public int IdAcesso { get; set; }
        public int CotoveloEsquerdo { get; set; }
        public int CotoveloDireito { get; set; }
        public int PulsoEsquerdo { get; set; }
        public int PulsoDireito { get; set; }
        public int RotacaoCabeca { get; set; }
        public int InclinacaoCabeca { get; set; }
    }
}
