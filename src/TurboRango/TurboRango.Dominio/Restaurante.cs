using System;

namespace TurboRango.Dominio
{
    internal class Restaurante
    {
        internal string Nome { get; set; }
        internal int Capacidade { get; set; }

        internal Categoria categoria { get; set; }

        internal Contato contato { get; set; }
        internal Localizacao localizacao { get; set; }



    }
}
