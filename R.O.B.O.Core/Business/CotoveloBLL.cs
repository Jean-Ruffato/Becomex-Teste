using R.O.B.O.Core.DataAccess;
using R.O.B.O.Core.Interfaces;
using R.O.B.O.Core.Models;
using R.O.B.O.Core.Utils;
using System.Collections.Generic;

namespace R.O.B.O.Core.Business
{
    public class CotoveloBLL : RoboDAL, ICotovelo
    {
        public CotoveloBLL()
        {
        }

        public RetornoTO ContrairCotoveloEsquerdo()
        {
            RetornoTO retornoObj = new RetornoTO();
            List<RoboTO> listaRobo = Buscar();
            RoboTO roboObj = new RoboTO();

            if (listaRobo.Count < 1)
            {
                roboObj = new RoboTO
                {
                    CotoveloEsquerdo = (int)Contracao.EmRepouso,
                    CotoveloDireito = (int)Contracao.EmRepouso,
                    PulsoEsquerdo = (int)Rotacao.EstadoEmRepouso,
                    PulsoDireito = (int)Rotacao.EstadoEmRepouso,
                    RotacaoCabeca = (int)Rotacao.EstadoEmRepouso,
                    InclinacaoCabeca = (int)Inclinacao.EmRepouso
                };

                Inserir(roboObj);
            }
            else if (listaRobo.Count > 0)
            {
                roboObj.CotoveloEsquerdo = listaRobo[0].CotoveloEsquerdo;
                roboObj.CotoveloDireito = listaRobo[0].CotoveloDireito;
                roboObj.PulsoEsquerdo = listaRobo[0].PulsoEsquerdo;
                roboObj.PulsoDireito = listaRobo[0].PulsoDireito;
                roboObj.RotacaoCabeca = listaRobo[0].RotacaoCabeca;
                roboObj.InclinacaoCabeca = listaRobo[0].InclinacaoCabeca;

                switch (listaRobo[0].CotoveloEsquerdo)
                {
                    case (int)Contracao.EmRepouso:
                        roboObj.CotoveloEsquerdo = (int)Contracao.LevementeContraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.LevementeContraido:
                        roboObj.CotoveloEsquerdo = (int)Contracao.Contraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.Contraido:
                        roboObj.CotoveloEsquerdo = (int)Contracao.FortementeContraido;
                        retornoObj.Status = "sucesso";
                        break;                   
                    case (int)Contracao.FortementeContraido:
                        roboObj.CotoveloEsquerdo = (int)Contracao.FortementeContraido;
                        retornoObj.Mensagem = "Cotovelo já está fortemente contraído";
                        retornoObj.Status = "erro";
                        break;
                }


                retornoObj.EstadoAtual = roboObj.CotoveloEsquerdo.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }
        public RetornoTO ContrairCotoveloDireito()
        {
            RetornoTO retornoObj = new RetornoTO();
            List<RoboTO> listaRobo = Buscar();
            RoboTO roboObj = new RoboTO();

            if (listaRobo.Count < 1)
            {
                roboObj = new RoboTO
                {
                    CotoveloEsquerdo = (int)Contracao.EmRepouso,
                    CotoveloDireito = (int)Contracao.EmRepouso,
                    PulsoEsquerdo = (int)Rotacao.EstadoEmRepouso,
                    PulsoDireito = (int)Rotacao.EstadoEmRepouso,
                    RotacaoCabeca = (int)Rotacao.EstadoEmRepouso,
                    InclinacaoCabeca = (int)Inclinacao.EmRepouso
                };

                Inserir(roboObj);
            }
            else if (listaRobo.Count > 0)
            {
                roboObj.CotoveloEsquerdo = listaRobo[0].CotoveloEsquerdo;
                roboObj.CotoveloDireito = listaRobo[0].CotoveloDireito;
                roboObj.PulsoEsquerdo = listaRobo[0].PulsoEsquerdo;
                roboObj.PulsoDireito = listaRobo[0].PulsoDireito;
                roboObj.RotacaoCabeca = listaRobo[0].RotacaoCabeca;
                roboObj.InclinacaoCabeca = listaRobo[0].InclinacaoCabeca;

                switch (listaRobo[0].CotoveloDireito)
                {
                    case (int)Contracao.EmRepouso:
                        roboObj.CotoveloDireito = (int)Contracao.LevementeContraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.LevementeContraido:
                        roboObj.CotoveloDireito = (int)Contracao.Contraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.Contraido:
                        roboObj.CotoveloDireito = (int)Contracao.FortementeContraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.FortementeContraido:
                        roboObj.CotoveloDireito = (int)Contracao.FortementeContraido;
                        retornoObj.Mensagem = "Cotovelo já está fortemente contraído";
                        retornoObj.Status = "erro";
                        break;
                }


                retornoObj.EstadoAtual = roboObj.CotoveloDireito.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }
        public RetornoTO DescontrairCotoveloEsquerdo()
        {
            RetornoTO retornoObj = new RetornoTO();
            List<RoboTO> listaRobo = Buscar();
            RoboTO roboObj = new RoboTO();

            if (listaRobo.Count < 1)
            {
                roboObj = new RoboTO
                {
                    CotoveloEsquerdo = (int)Contracao.EmRepouso,
                    CotoveloDireito = (int)Contracao.EmRepouso,
                    PulsoEsquerdo = (int)Rotacao.EstadoEmRepouso,
                    PulsoDireito = (int)Rotacao.EstadoEmRepouso,
                    RotacaoCabeca = (int)Rotacao.EstadoEmRepouso,
                    InclinacaoCabeca = (int)Inclinacao.EmRepouso
                };

                Inserir(roboObj);
            }
            else if (listaRobo.Count > 0)
            {
                roboObj.CotoveloEsquerdo = listaRobo[0].CotoveloEsquerdo;
                roboObj.CotoveloDireito = listaRobo[0].CotoveloDireito;
                roboObj.PulsoEsquerdo = listaRobo[0].PulsoEsquerdo;
                roboObj.PulsoDireito = listaRobo[0].PulsoDireito;
                roboObj.RotacaoCabeca = listaRobo[0].RotacaoCabeca;
                roboObj.InclinacaoCabeca = listaRobo[0].InclinacaoCabeca;

                switch (listaRobo[0].CotoveloEsquerdo)
                {
                    case (int)Contracao.FortementeContraido:
                        roboObj.CotoveloEsquerdo = (int)Contracao.Contraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.Contraido:
                        roboObj.CotoveloEsquerdo = (int)Contracao.LevementeContraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.LevementeContraido:
                        roboObj.CotoveloEsquerdo = (int)Contracao.EmRepouso;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.EmRepouso:
                        roboObj.CotoveloEsquerdo = (int)Contracao.EmRepouso;
                        retornoObj.Mensagem = "O Cotovelo já está em repouso";
                        retornoObj.Status = "erro";
                        break;
                }


                retornoObj.EstadoAtual = roboObj.CotoveloEsquerdo.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }
        public RetornoTO DescontrairCotoveloDireito()
        {
            RetornoTO retornoObj = new RetornoTO();
            List<RoboTO> listaRobo = Buscar();
            RoboTO roboObj = new RoboTO();

            if (listaRobo.Count < 1)
            {
                roboObj = new RoboTO
                {
                    CotoveloEsquerdo = (int)Contracao.EmRepouso,
                    CotoveloDireito = (int)Contracao.EmRepouso,
                    PulsoEsquerdo = (int)Rotacao.EstadoEmRepouso,
                    PulsoDireito = (int)Rotacao.EstadoEmRepouso,
                    RotacaoCabeca = (int)Rotacao.EstadoEmRepouso,
                    InclinacaoCabeca = (int)Inclinacao.EmRepouso
                };

                Inserir(roboObj);
            }
            else if (listaRobo.Count > 0)
            {
                roboObj.CotoveloEsquerdo = listaRobo[0].CotoveloEsquerdo;
                roboObj.CotoveloDireito = listaRobo[0].CotoveloDireito;
                roboObj.PulsoEsquerdo = listaRobo[0].PulsoEsquerdo;
                roboObj.PulsoDireito = listaRobo[0].PulsoDireito;
                roboObj.RotacaoCabeca = listaRobo[0].RotacaoCabeca;
                roboObj.InclinacaoCabeca = listaRobo[0].InclinacaoCabeca;

                switch (listaRobo[0].CotoveloDireito)
                {
                    case (int)Contracao.FortementeContraido:
                        roboObj.CotoveloDireito = (int)Contracao.Contraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.Contraido:
                        roboObj.CotoveloDireito = (int)Contracao.LevementeContraido;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.LevementeContraido:
                        roboObj.CotoveloDireito = (int)Contracao.EmRepouso;
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Contracao.EmRepouso:
                        roboObj.CotoveloDireito = (int)Contracao.EmRepouso;
                        retornoObj.Mensagem = "O Cotovelo já está em repouso";
                        retornoObj.Status = "erro";
                        break;
                }


                retornoObj.EstadoAtual = roboObj.CotoveloDireito.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }
    }
}
