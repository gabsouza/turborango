using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TurboRango.Importador.XML
{
    class RestauranteXML
    {
        IEnumerable<XElement> restaurantes;

        /// <summary>
        /// Constrói restaurantes a partir de um nome de arquivo
        /// </summary>
        public string NomeArquivo { get; private set; }

        public RestauranteXML(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
        }

        public IList<string> ObterNomes()
        {
            //var resultado = new List<string>();

            //var nodos = XDocument.Load(NomeArquivo).Descendants("restaurante");

            //foreach (var item in nodos)
            //{
            //  resultado.Add(item.Attribute("nome").Value);
            //}
            //return resultado;

            return XDocument.Load(NomeArquivo).Descendants("restaurante")
                .Select(n => n.Attribute("nome").Value, Categoria = n.Attribute("nome")).OrderBy(x => x.Nome).ToList();

            /*return (
                from n in XDocument.Load(NomeArquivo).Descendants("restaurante")
                orderby n.Attribute("nome").Value
                select n.Attribute("nome").Value
        ).ToList(); */
        } 

        public 

    }
}
