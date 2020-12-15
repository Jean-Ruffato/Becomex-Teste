using R.O.B.O.Core.Business;
using R.O.B.O.Core.Interfaces;
using R.O.B.O.Core.Models;
using System.Web.Mvc;

namespace R.O.B.O.Api.Controllers
{
    public class PulsoController : Controller
    {

        [HttpPost]
        public ActionResult RotacionarPulsoEsquerdoPositivo()
        {
            IPulso pulso = new PulsoBLL();

            RetornoTO retornoObj = pulso.RotacionarPulsoEsquerdoPositivo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }

        [HttpPost]
        public ActionResult RotacionarPulsoDireitoPositivo()
        {
            IPulso pulso = new PulsoBLL();

            RetornoTO retornoObj = pulso.RotacionarPulsoDireitoPositivo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }
        [HttpPost]
        public ActionResult RotacionarPulsoEsquerdoNegativo()
        {
            IPulso pulso = new PulsoBLL();

            RetornoTO retornoObj = pulso.RotacionarPulsoEsquerdoNegativo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }

        [HttpPost]
        public ActionResult RotacionarPulsoDireitoNegativo()
        {
            IPulso pulso = new PulsoBLL();

            RetornoTO retornoObj = pulso.RotacionarPulsoDireitoNegativo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }
    }
}