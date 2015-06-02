using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboRango.Dominio
{
    internal enum Categoria
    {
        [Description("Comun")]
        COMUN,

        [Description("Cozinha natural")]
        COZINHANATURAL,

        [Description("CozinhaMexicana")]
        COZINHAMEXICANA,

        [Description("CozinhaMexicana")]
        CHURRASCARIA,

        [Description("CozinhaMexicana")]
        COZINHAJAPONESA,

        [Description("CozinhaMexicana")]
        FASTFOOD,

        [Description("CozinhaMexicana")]
        PIZARRIA,
    }
}
