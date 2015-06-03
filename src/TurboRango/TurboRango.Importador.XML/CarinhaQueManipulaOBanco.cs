using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboRango.Importador.XML
{
    class CarinhaQueManipulaOBanco
    {
        private string connectionString;

        public CarinhaQueManipulaOBanco(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void Inserir(Dominio.Contato contato)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            string comandoSQL = "INSERT INTO [dbo].[Contato] ([Site],[Telefone]) VALUES (@Site, @Telefone)";
            SqlCommand inserirContato = new SqlCommand(comandoSQL, connection);
            inserirContato.Parameters.Add("@Site", SqlDbType.NVarChar).Value = contato.Site;
            inserirContato.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = contato.Telefone;

            connection.Open();
            int resultado = inserirContato.ExecuteNonQuery();
        }
    }
}
