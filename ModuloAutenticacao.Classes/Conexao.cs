using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    internal class Conexao
    {
        public static DbConnection _conn;

        public static SqlConnection MinhaInstancia { get; set; }

    }
}
