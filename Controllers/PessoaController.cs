using AprendendoMVC2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AprendendoMVC2.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        
        public ActionResult Resultado(Pessoa pessoa)
        {            
            return View(pessoa);
        }

        public ActionResult LoginUnico(string Login)
        {
            var bancoDeNomes = new Collection<String>{"wellington", "administrador"};                        

            return Json(bancoDeNomes.All(x =>x.ToLower() != Login.ToLower()),JsonRequestBehavior.AllowGet); 

        }
    }
}
