using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurboRango.Dominio;
using TurboRango.Web.Models;

namespace TurboRango.Web.Controllers
{
    public class ReservasController: Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Reservas
        public ActionResult Index()
        {

            return View();
        }

        [AllowAnonymous]
        public JsonResult Reservas()
        {
            //db.Reserva.Add(reserva);

            return Json(new { mensagem = "Reservado!" }, JsonRequestBehavior.AllowGet);
        }
    }
}