using R.O.B.O.Core.Models;

namespace R.O.B.O.Core.Interfaces
{
    public interface ICotovelo
    {
        RetornoTO ContrairCotoveloEsquerdo();
        RetornoTO DescontrairCotoveloEsquerdo();
        RetornoTO ContrairCotoveloDireito();
        RetornoTO DescontrairCotoveloDireito();
    }
}
