using R.O.B.O.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace R.O.B.O.Core.Interfaces
{
    public interface IPulso
    {
        RetornoTO RotacionarPulsoEsquerdoPositivo();
        RetornoTO RotacionarPulsoEsquerdoNegativo();
        RetornoTO RotacionarPulsoDireitoPositivo();
        RetornoTO RotacionarPulsoDireitoNegativo();
    }
}
