using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloAutenticacao.Classes
{
    public class NivelDAO
    {

        public string Inserir(string nome)
        {
            // Abrindo a conexao com banco de dados
            Conexao.MinhaInstancia.Open();

            // Definindo o tipo de comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();

            // Definindo DML
            comando.CommandType = System.Data.CommandType.Text;

            // Iniciando DML (Data Manipulation Language)
            comando.CommandText = "INSERT INTO Nivel(nome)Values(@Nome)";

            // Adicionando parametros contra SQL Injection!            
            comando.Parameters.Add(new SqlParameter("@Nome", nome));

            // Esta tudo pronto! Vamos esxecutar o comando
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Nivel Cadastrado";

        }


        public string Atualizar()
        {
            
            return "atualizar";
        }
        public string Pesquisar() { 
        
            return "pesquisar";
        }

        public string Deletar()
        {
            return "deletar";
        }


            /*
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = (@"Server = CLEISSIM; Database = ProjetoEstoquev; Uid = sa; Pwd = cleissim;");
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select nome from Nivel";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbNivel.DisplayMember = "nome";
            cbNivel.DataSource = dt;
            cn.Close();
            */
            
        
    }
}
