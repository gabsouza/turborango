using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboRango.Dominio
{
    internal class Restaurante
    {
        internal string Name { get; set; }
        internal int Capacidade { get; set; }
        internal Categoria categoria { get; set; }

    }
}
