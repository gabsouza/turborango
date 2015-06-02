using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboRango.Dominio;

namespace TurboRango.Importador.XML
{
    class Program
    {
        static void Main(string[] args)
        {

            const string nomeArquivo = "restaurantes.xml";
            var restauranteXML = new RestauranteXML(nomeArquivo);
            var nomes = restauranteXML.ObterNomes();
        }
    }
}
