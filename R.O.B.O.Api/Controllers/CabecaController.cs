using R.O.B.O.Core.Business;
using R.O.B.O.Core.Interfaces;
using R.O.B.O.Core.Models;

using System.Web.Mvc;

namespace R.O.B.O.Api.Controllers
{
    public class CabecaController : Controller
    {
        [HttpPost]
        public ActionResult InclinarCabecaParaBaixo()
        {
            ICabeca cabeca = new CabecaBLL();

            RetornoTO retornoObj = cabeca.InclinarCabecaParaBaixo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }

        [HttpPost]
        public ActionResult InclinarCabecaParaCima()
        {
            ICabeca cabeca = new CabecaBLL();

            RetornoTO retornoObj = cabeca.InclinarCabecaParaCima();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }
        [HttpPost]
        public ActionResult RotacionarCabecaPositivo()
        {
            ICabeca cabeca = new CabecaBLL();

            RetornoTO retornoObj = cabeca.RotacionarCabecaPositivo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }

        [HttpPost]
        public ActionResult RotacionarCabecaNegativo()
        {
            ICabeca cabeca = new CabecaBLL();

            RetornoTO retornoObj = cabeca.RotacionarCabecaNegativo();

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