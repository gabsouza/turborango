using System.ComponentModel;

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
}
