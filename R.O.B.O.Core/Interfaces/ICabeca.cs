using R.O.B.O.Core.Models;

namespace R.O.B.O.Core.Interfaces
{
    public interface ICabeca
    {
        RetornoTO RotacionarCabecaPositivo();
        RetornoTO RotacionarCabecaNegativo();
        RetornoTO InclinarCabecaParaCima();
        RetornoTO InclinarCabecaParaBaixo();
    }
}
