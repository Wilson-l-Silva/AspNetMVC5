using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var p1 = new Pessoa
            {
                PessoaId = 1,
                Nome = "Wilson Lima",
                Tipo = "Pessoa Física"
            };

            var p2 = new Pessoa
            {
                PessoaId = 2,
                Nome = "Aline Fernandes",
                Tipo = "Pessoa Física"
            };

            //passando informações para viewdata
            ViewData["PessoaId"] = p1.PessoaId;
            ViewData["Nome"] = p1.Nome;
            ViewData["Tipo"] = p1.Tipo;

            //passandi informações para view com viewBag
            ViewBag.id = p2.PessoaId;
            ViewBag.nome = p2.Nome;
            ViewBag.tipoPessoa = p2.Tipo;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}