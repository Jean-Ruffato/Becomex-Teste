using R.O.B.O.Core.DataAccess;
using R.O.B.O.Core.Interfaces;
using R.O.B.O.Core.Models;
using R.O.B.O.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace R.O.B.O.Core.Business
{
    public class CabecaBLL : RoboDAL, ICabeca
    {
        public CabecaBLL()
        {
        }

        public RetornoTO RotacionarCabecaPositivo()
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

                if (listaRobo[0].InclinacaoCabeca == (int)Inclinacao.ParaBaixo)
                {
                    retornoObj.Mensagem = "Não é possível rotacionar enquanto a cabeça estiver inclinada para baixo";
                    retornoObj.Status = "erro";
                }
                else
                {
                    switch (listaRobo[0].RotacaoCabeca)
                    {
                        case (int)Rotacao.EstadoNegativo2:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoNegativo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo1:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoEmRepouso;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoEmRepouso:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoPositivo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo1:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoPositivo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo2:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoPositivo2;
                            retornoObj.Mensagem = "Alcançado limite de rotação";
                            retornoObj.Status = "erro";
                            break;
                    }
                }
            }
            retornoObj.EstadoAtual = roboObj.RotacaoCabeca.ToString();

            Atualizar(roboObj);

            return retornoObj;
        }

        public RetornoTO RotacionarCabecaNegativo()
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

                if (listaRobo[0].InclinacaoCabeca == (int)Inclinacao.ParaBaixo)
                {
                    retornoObj.Mensagem = "Não é possível rotacionar enquanto a cabeça estiver inclinada para baixo";
                    retornoObj.Status = "erro";
                }
                else
                {
                    switch (listaRobo[0].RotacaoCabeca)
                    {
                        case (int)Rotacao.EstadoPositivo2:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoPositivo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoPositivo1:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoEmRepouso;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoEmRepouso:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoNegativo1;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo1:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoNegativo2;
                            retornoObj.Status = "sucesso";
                            break;
                        case (int)Rotacao.EstadoNegativo2:
                            roboObj.RotacaoCabeca = (int)Rotacao.EstadoNegativo2;
                            retornoObj.Mensagem = "Alcançado limite de rotação";
                            retornoObj.Status = "erro";
                            break;
                    }
                }
            }

            retornoObj.EstadoAtual = roboObj.RotacaoCabeca.ToString();

            Atualizar(roboObj);

            return retornoObj;
        }

        public RetornoTO InclinarCabecaParaCima()
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

                switch (listaRobo[0].InclinacaoCabeca)
                {
                    case (int)Inclinacao.EmRepouso:
                        roboObj.InclinacaoCabeca = (int)Inclinacao.ParaCima;
                        retornoObj.Mensagem = "";
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Inclinacao.ParaBaixo:
                        roboObj.InclinacaoCabeca = (int)Inclinacao.EmRepouso;
                        retornoObj.Mensagem = "";
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Inclinacao.ParaCima:
                        roboObj.InclinacaoCabeca = (int)Inclinacao.ParaCima;
                        retornoObj.Mensagem = "A cabeça já está erguida";
                        retornoObj.Status = "erro";
                        break;
                }
            }

            retornoObj.EstadoAtual = roboObj.InclinacaoCabeca.ToString();

            Atualizar(roboObj);

            return retornoObj;
        }

        public RetornoTO InclinarCabecaParaBaixo()
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

                switch (listaRobo[0].InclinacaoCabeca)
                {
                    case (int)Inclinacao.EmRepouso:
                        roboObj.InclinacaoCabeca = (int)Inclinacao.ParaBaixo;
                        retornoObj.Mensagem = "";
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Inclinacao.ParaCima:
                        roboObj.InclinacaoCabeca = (int)Inclinacao.EmRepouso;
                        retornoObj.Mensagem = "";
                        retornoObj.Status = "sucesso";
                        break;
                    case (int)Inclinacao.ParaBaixo:
                        roboObj.InclinacaoCabeca = (int)Inclinacao.ParaBaixo;
                        retornoObj.Mensagem = "A cabeça já está abaixada";
                        retornoObj.Status = "erro";
                        break;
                }
            }

            retornoObj.EstadoAtual = roboObj.InclinacaoCabeca.ToString();

            Atualizar(roboObj);

            return retornoObj;
        }

    }
}
