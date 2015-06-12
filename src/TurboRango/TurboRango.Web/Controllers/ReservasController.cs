using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurboRango.Dominio;
using TurboRango.Web.Models;

namespace TurboRango.Web.Controllers
{
    public class ReservasController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Reservas
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult Reservas(CriarReservaViewModel novaReserva)
        {
            string mensagem = "não foi reservado!";
            if (ModelState.IsValid)
            {
                Reserva reserva = new Reserva
                {
                    IdRestaurante = novaReserva.IdRestaurante,
                    Lugares = novaReserva.Lugares,
                    VagasEstacionamento = novaReserva.VagasEstacionamento,
                    Data = novaReserva.Data ?? DateTime.Now
                };

                db.Reserva.Add(reserva);
                db.SaveChanges();
                mensagem = "Reservado!";
            }
            return Json(new { mensagem = mensagem }, JsonRequestBehavior.AllowGet);            
        }
    }
}