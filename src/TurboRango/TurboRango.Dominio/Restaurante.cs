﻿using System;

namespace TurboRango.Dominio
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public int? Capacidade { get; set; }
        public bool? Lotado { get; set; }

        public Categoria Categoria { get; set; }

        public Contato Contato { get; set; }
        public Localizacao Localizacao { get; set; }



    }
}
