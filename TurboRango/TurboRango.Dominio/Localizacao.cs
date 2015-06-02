using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboRango.Dominio
{
    internal class Restaurante
    {
        internal string Bairro { get; set; }
        internal int Latitude { get; set; }
        internal Categoria categoria { get; set; }

    }
}
