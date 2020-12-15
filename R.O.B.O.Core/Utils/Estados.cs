using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.O.B.O.Core.Utils
{
    public enum Rotacao
    {
        EstadoNegativo1 = -45,
        EstadoNegativo2 = -90,
        EstadoEmRepouso = 0,
        EstadoPositivo1 = 45,
        EstadoPositivo2 = 90,
        EstadoPositivo3 = 135,
        EstadoPositivo4 = 180
    }

    public enum Inclinacao
    {
        EmRepouso = 0,
        ParaCima = 1,
        ParaBaixo = -1
    }

    public enum Contracao
    {
        EmRepouso = 0,
        LevementeContraido = -1,
        Contraido = -2,
        FortementeContraido = -3
    }
    public enum RotacaoCabeca
    {
        EstadoNegativo1 = -45,
        EstadoNegativo2 = -90,
        EstadoEmRepouso = 0,
        EstadoPositivo1 = 45,
        EstadoPositivo2 = 90
    }
}
