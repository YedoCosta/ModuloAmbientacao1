using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    internal class Conexao
    {
        public static SqlConnection _conn;

        public static SqlConnection MinhaInstancia
        {
            get
            {
                //se não existe conexão.
                if (_conn == null)
                {
                    //criar a conexão com MySQL   //nos parênteses -connection string
                    _conn = new SqlConnection(@"Server = Lab206_16\SQLEXPRESS; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
                }
                //retorna a conexão
                return _conn;
            }
        }



    }
}
