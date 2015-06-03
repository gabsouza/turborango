using System;

namespace TurboRango.Dominio
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public int? Capacidade { get; set; }
        public bool? Lotado { get; set; }

        public Categoria categoria { get; set; }

        public Contato contato { get; set; }
        public Localizacao localizacao { get; set; }



    }
}
