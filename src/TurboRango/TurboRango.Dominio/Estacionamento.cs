using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboRango.Dominio
{
    public class Estacionamento: Entidade
    {
        public decimal Preco { get; set; }
        public int QuantidadeVagas { get; set; }
    }
}
