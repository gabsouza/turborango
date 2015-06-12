using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurboRango.Web.Models
{
    public class CriarReservaViewModel
    {
        public int IdRestaurante { get; set; }
        public int Lugares { get; set; }
        public int VagasEstacionamento { get; set; }
        public DateTime? Data { get; set; }
    }
}