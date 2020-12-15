using R.O.B.O.Core.DataAccess;
using R.O.B.O.Core.Interfaces;
using R.O.B.O.Core.Models;
using R.O.B.O.Core.Utils;
using System.Collections.Generic;

namespace R.O.B.O.Core.Business
{
    public class PulsoBLL: RoboDAL, IPulso
    {
        public PulsoBLL()
        {
        }

        public RetornoTO RotacionarPulsoEsquerdoPositivo()
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

                if (listaRobo[0].CotoveloEsquerdo != (int)Contracao.FortementeContraido)
                {
                    retornoObj.Mensagem = "O Cotovelo deve estar fortemente contraído para rotacionar";
                    retornoObj.Status = "erro";
                }
                else
                {
                    switch (listaRobo[0].PulsoEsquerdo)
                    {
                        case (int)Rotacao.EstadoNegativo2:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoNegativo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo1:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoEmRepouso;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoEmRepouso:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo1:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo2:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo3;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo3:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo4;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo4:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo4;
                            retornoObj.Mensagem = "Alcançado limite de rotação";
                            retornoObj.Status = "erro";
                            break;
                    }
                }

                retornoObj.EstadoAtual = roboObj.PulsoEsquerdo.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }

        public RetornoTO RotacionarPulsoEsquerdoNegativo()
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

                if (listaRobo[0].CotoveloEsquerdo != (int)Contracao.FortementeContraido)
                {
                    retornoObj.Mensagem = "O Cotovelo deve estar fortemente contraído para rotacionar";
                    retornoObj.Status = "erro";
                }
                else
                {
                    switch (listaRobo[0].PulsoEsquerdo)
                    {
                        case (int)Rotacao.EstadoPositivo4:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo3;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo3:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo2:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoPositivo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo1:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoEmRepouso;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoEmRepouso:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoNegativo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo1:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoNegativo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo2:
                            roboObj.PulsoEsquerdo = (int)Rotacao.EstadoNegativo2;
                            retornoObj.Mensagem = "Alcançado limite de rotação";
                            retornoObj.Status = "erro";
                            break;
                    }
                }

                retornoObj.EstadoAtual = roboObj.PulsoEsquerdo.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }

        public RetornoTO RotacionarPulsoDireitoPositivo()
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

                if (listaRobo[0].CotoveloDireito != (int)Contracao.FortementeContraido)
                {
                    retornoObj.Mensagem = "O Cotovelo deve estar fortemente contraído para rotacionar";
                    retornoObj.Status = "erro";
                }
                else
                {
                    switch (listaRobo[0].PulsoDireito)
                    {
                        case (int)Rotacao.EstadoNegativo2:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoNegativo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo1:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoEmRepouso;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoEmRepouso:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo1:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo2:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo3;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo3:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo4;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo4:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo4;
                            retornoObj.Mensagem = "Alcançado limite de rotação";
                            retornoObj.Status = "erro";
                            break;
                    }
                }

                retornoObj.EstadoAtual = roboObj.PulsoDireito.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }
        
        public RetornoTO RotacionarPulsoDireitoNegativo()
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

                if (listaRobo[0].CotoveloDireito != (int)Contracao.FortementeContraido)
                {
                    retornoObj.Mensagem = "O Cotovelo deve estar fortemente contraído para rotacionar";
                    retornoObj.Status = "erro";
                }
                else
                {
                    switch (listaRobo[0].PulsoDireito)
                    {
                        case (int)Rotacao.EstadoPositivo4:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo3;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo3:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo2:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoPositivo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo1:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoEmRepouso;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoEmRepouso:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoNegativo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo1:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoNegativo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo2:
                            roboObj.PulsoDireito = (int)Rotacao.EstadoNegativo2;
                            retornoObj.Mensagem = "Alcançado limite de rotação";
                            retornoObj.Status = "erro";
                            break;
                    }
                }

                retornoObj.EstadoAtual = roboObj.PulsoDireito.ToString();

                Atualizar(roboObj);
            }
            return retornoObj;
        }
    }
}
