using R.O.B.O.Core.Business;
using R.O.B.O.Core.Interfaces;
using R.O.B.O.Core.Models;
using System.Web.Mvc;

namespace R.O.B.O.Api.Controllers
{
    public class CotoveloController : Controller
    {
        [HttpPost]
        public ActionResult ContrairCotoveloEsquerdo()
        {
            ICotovelo cotovelo = new CotoveloBLL();

            RetornoTO retornoObj = cotovelo.ContrairCotoveloEsquerdo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }

        [HttpPost]
        public ActionResult ContrairCotoveloDireito()
        {
            ICotovelo cotovelo = new CotoveloBLL();

            RetornoTO retornoObj = cotovelo.ContrairCotoveloDireito();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }
        [HttpPost]
        public ActionResult DescontrairCotoveloEsquerdo()
        {
            ICotovelo cotovelo = new CotoveloBLL();

            RetornoTO retornoObj = cotovelo.DescontrairCotoveloEsquerdo();

            RetornoTO resultado = new RetornoTO
            {
                EstadoAtual = retornoObj.EstadoAtual,
                Status = retornoObj.Status,
                Mensagem = retornoObj.Mensagem
            };
            return Json(resultado);
        }

        [HttpPost]
        public ActionResult DescontrairCotoveloDireito()
        {
            ICotovelo cotovelo = new CotoveloBLL();

            RetornoTO retornoObj = cotovelo.DescontrairCotoveloDireito();

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