using System;

namespace TurboRango.Dominio
{
    public class Restaurante
    {
        public string Nome { get; private set; }
        public int? Capacidade { get; private set; }
        public bool? Lotado { get; private set; }

        public Categoria categoria { get; set; }

        public Contato contato { get; set; }
        public Localizacao localizacao { get; set; }



    }
}
