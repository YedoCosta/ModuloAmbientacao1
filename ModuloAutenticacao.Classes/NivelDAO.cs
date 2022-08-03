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


        public DataTable Pesquisar()
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Nivel ORDER BY codigo;";
           
            //datatable (cria o bando de dados na memoria;
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();



            return dataTable;
        }

        public string Deletar()
        {
            return "deletar";
        }


    }
}
/*
 
 
 testar depois
    https://www.c-sharpcorner.com/UploadFile/1e050f/insert-update-and-delete-record-in-datagridview-C-Sharp/
 
 
 */