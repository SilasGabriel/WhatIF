using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALModulo
    {
        string connectionString = "";

        public DALModulo()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                      ["2017WhatIFConnectionString"].ConnectionString;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Modulo> SelectAll(){
            // Variavel para armazenar um livro
            Modelo.Modulo DALmodulo;
            // Cria Lista Vazia
            List<Modelo.Modulo> DALlistModulo = new List<Modelo.Modulo>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Modulo";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    DALmodulo = new Modelo.Modulo(
                        dr["idModulo"].ToString(),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        dr["idDisciplina"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    DALlistModulo.Add(DALmodulo);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistModulo;
        }

        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Modulo> Select(string idModulo)
        {
            // Variavel para armazenar um livro
            Modelo.Modulo DALmodulo;
            // Cria Lista Vazia
            List<Modelo.Modulo> DALlistModulo = new List<Modelo.Modulo>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Titles Where idModulo = @idModulo";
            cmd.Parameters.AddWithValue("@idModulo", idModulo);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    DALmodulo = new Modelo.Modulo(
                        dr["idModulo"].ToString(),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        dr["idDisciplina"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    DALlistModulo.Add(DALmodulo);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistModulo;
        }

        //Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Modulo obj){
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Modulo WHERE idModulo = @idModulo", conn);
            cmd.Parameters.AddWithValue("@idModulo", obj.idModulo);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        //Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Modulo obj)
        {
            SqlConnection sc = new SqlConnection("Data source=Valera;initial catalog=2017WhatIF;Persist Security Info=true;User ID=2017WhatIF;Password=Senha@123");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Modulo(idModulo, titulo, descricao, idDisciplina)"
                + "" + "VALUES('" + obj.idModulo + "', '" + obj.titulo + "', '" + obj.descricao + "', " + obj.idDisciplina + ")";
            cmd.Connection = sc;

            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }

        //Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Modulo obj) { 
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Modulo SET titulo = @titulo, descricao = @descricao, idDisciplina = @idDisciplina WHERE idModulo = @idModulo", conn);
            cmd.Parameters.AddWithValue("@idModulo", obj.idModulo);
            cmd.Parameters.AddWithValue("@titulo", obj.titulo);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@idDisciplina", obj.idDisciplina);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

    }
}