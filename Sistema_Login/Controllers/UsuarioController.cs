using Sistema_Login.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Login.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Validacao()
        {
            var usuario = new Usuario();
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Validacao(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult Login(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Felipe",
                "Polyana",
                "Julio",
                "Eny"
            };
            return Json(bdExemplo.All(y => y.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}