using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboRango.Dominio;
using TurboRango.ImportadorXML;

namespace TurboRango.Importador.XML
{
    class Program
    {
        static void Main(string[] args)
        {

            const string nomeArquivo = "restaurantes.xml";
            var restauranteXML = new RestaurantesXML(nomeArquivo);
            var nomes = restauranteXML.ObterNomes();

            var connString = @"Data Source=.;Initial Catalog=TurboRango_dev;";
            var acessoAoBanco = new CarinhaQueManipulaOBanco(connString);

            acessoAoBanco.Inserir(new Contato
            {
                Site = "www.dogao.gif",
                Telefone = "55555555"

            });
    }
    }
}
