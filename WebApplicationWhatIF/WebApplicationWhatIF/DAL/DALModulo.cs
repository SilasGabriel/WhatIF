using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Modulo> SelectAll(){
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
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Disciplina dis = new Modelo.Disciplina();
                    DALDisciplina daldis = new DALDisciplina();
                    dis = (daldis.Select(Convert.ToInt32(dr["idDisciplina"])))[0];
                    Modelo.Modulo mod = new Modelo.Modulo();
                    DALmodulo = new Modelo.Modulo(
                        dr["idModulo"].ToString(),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        dis
                        );
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
        public List<Modelo.Modulo> Select(int idModulo)
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
            cmd.CommandText = "Select * from Modulo Where idModulo = @idModulo";
            cmd.Parameters.AddWithValue("@idModulo", idModulo);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Disciplina dis = new Modelo.Disciplina();
                    DALDisciplina daldis = new DALDisciplina();
                    dis = (daldis.Select(Convert.ToInt32(dr["idDisciplina"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    DALmodulo = new Modelo.Modulo(
                        dr["idModulo"].ToString(),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        dis
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
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            Modelo.Disciplina dis = new Modelo.Disciplina();
            dis = obj.disciplina;
            cmd.CommandText = "INSERT INTO Modulo(titulo, descricao, idDisciplina) VALUES(@titulo, @descricao, @idDisciplina)";
            cmd.Parameters.AddWithValue("@titulo", obj.titulo);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@idDisciplina", dis.idDisciplina);
            cmd.Connection = sc;

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
            Modelo.Disciplina dis = new Modelo.Disciplina();
            dis = obj.disciplina;
            SqlCommand cmd = new SqlCommand("UPDATE Modulo SET titulo = @titulo, descricao = @descricao, idDisciplina = @idDisciplina WHERE idModulo = @idModulo", conn);
            cmd.Parameters.AddWithValue("@idModulo", obj.idModulo);
            cmd.Parameters.AddWithValue("@titulo", obj.titulo);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@idDisciplina", dis.idDisciplina);           
            // Executa Comando
            cmd.ExecuteNonQuery();

        }

    }
}