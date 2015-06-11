using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboRango.Dominio
{
    public class Reserva : Entidade
    {
        public int IdRestaurante { get; set; }
        public int Lugares { get; set; }
        public int VagasEstacionamento { get; set; }
        public DateTime Data { get; set; }
    }
}
