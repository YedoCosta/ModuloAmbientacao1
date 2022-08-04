using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    public class Conexao
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
                    //abaixo conexao banco computador senai
                    _conn = new SqlConnection(@"Server = Lab206_4; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");

                    //abaixo conexao banco notebook
                    //_conn = new SqlConnection(@"Server = CLEISSIM; Database = ProjetoEstoquev; Uid = sa; Pwd = cleissim;");
                }
                //retorna a conexão
                return _conn;
            }
        }



    }
}
