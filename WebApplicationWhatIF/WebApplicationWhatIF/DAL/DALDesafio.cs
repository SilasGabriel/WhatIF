using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALDesafio
    {
        private string connectionString = "";
        public DALDesafio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Desafio obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            Modelo.Dificuldade dificuldade = new Modelo.Dificuldade();
            dificuldade = obj.dificuldade;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Desafio(titulo, questao, fotoquestao, idDificuldade)"
                + "" + "VALUES(@titulo, @questao, @fotoquestao, @idDificuldade)";
            cmd.Parameters.AddWithValue("@titulo", obj.titulo);
            cmd.Parameters.AddWithValue("@questao", obj.questao);
            cmd.Parameters.AddWithValue("@fotoquestao", obj.fotoquestao);
            cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
            cmd.Connection = sc;

            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }
        //Insert Sem Foto
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void InsertSemFoto(Modelo.Desafio obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            Modelo.Dificuldade dificuldade = new Modelo.Dificuldade();
            dificuldade = obj.dificuldade;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Desafio(titulo, questao, idDificuldade)"
                + "" + "VALUES(@titulo, @questao, @idDificuldade)";
            cmd.Parameters.AddWithValue("@titulo", obj.titulo);
            cmd.Parameters.AddWithValue("@questao", obj.questao);
            cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
            cmd.Connection = sc;

            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Desafio> Select(int idDesafio)
        {
            Modelo.Desafio DALdesafio;
            // Cria Lista Vazia
            List<Modelo.Desafio> DALlistDes = new List<Modelo.Desafio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Desafio Where idDesafio = @idDesafio";
            cmd.Parameters.AddWithValue("@idDesafio", idDesafio);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    try
                    {
                        DALdesafio = new Modelo.Desafio(
                            Convert.ToInt32(dr["idDesafio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            (byte[])dr["fotoquestao"],
                            Convert.ToInt32(dr["idDificuldade"])
                            );
                    }
                    catch (InvalidCastException)
                    {
                        DALdesafio = new Modelo.Desafio(
                            Convert.ToInt32(dr["idDesafio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            null,
                            Convert.ToInt32(dr["idDificuldade"])
                            );
                    }
                    DALlistDes.Add(DALdesafio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistDes;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Desafio> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Desafio aDesafio;
            // Cria Lista Vazia
            List<Modelo.Desafio> aListDesafio = new List<Modelo.Desafio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Desafio";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    try
                    {
                        aDesafio = new Modelo.Desafio(
                            Convert.ToInt32(dr["idDesafio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            (byte[])dr["fotoquestao"],
                            Convert.ToInt32(dr["idDificuldade"])
                            );
                    }
                    catch (InvalidCastException)
                    {
                        aDesafio = new Modelo.Desafio(
                            Convert.ToInt32(dr["idDesafio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            null,
                            Convert.ToInt32(dr["idDificuldade"])
                            );
                    }
                    // Adiciona o livro lido à lista
                    aListDesafio.Add(aDesafio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListDesafio;
        }
        
        //Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Desafio obj)
        {
            Modelo.Dificuldade dificuldade = new Modelo.Dificuldade();
            dificuldade = obj.dificuldade;
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            if (obj.fotoquestao != null)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Desafio SET titulo = @titulo, questao = @questao, fotoquestao = @fotoquestao, idDificuldade = @idDificuldade WHERE idDesafio = @idDesafio", conn);
                cmd.Parameters.AddWithValue("@idDesafio", obj.idDesafio);
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@questao", obj.questao);
                cmd.Parameters.AddWithValue("@fotoquestao", obj.fotoquestao);
                cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
                // Executa Comando
                cmd.ExecuteNonQuery();
            }
            else {
                SqlCommand cmd = new SqlCommand("UPDATE Desafio SET titulo = @titulo, questao = @questao, idDificuldade = @idDificuldade WHERE idDesafio = @idDesafio", conn);
                cmd.Parameters.AddWithValue("@idDesafio", obj.idDesafio);
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@questao", obj.questao);
                cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
                // Executa Comando
                cmd.ExecuteNonQuery();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void UpdateDesafioSemFoto(Modelo.Desafio obj)
        {
            Modelo.Dificuldade dificuldade = new Modelo.Dificuldade();
            dificuldade = obj.dificuldade;
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = new SqlCommand("UPDATE Desafio SET titulo = @titulo, questao = @questao, idDesafio = @idDesafio WHERE idDesafio = @idDesafio", conn);
            cmd.Parameters.AddWithValue("@idDesafio", obj.idDesafio);
            cmd.Parameters.AddWithValue("@titulo", obj.titulo);
            cmd.Parameters.AddWithValue("@questao", obj.questao);
            cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
            // Executa Comando
            cmd.ExecuteNonQuery();
        }
        //Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void DeleteTeste(Modelo.Desafio obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Desafio WHERE idDesafio = @idDesafio", conn);
            cmd.Parameters.AddWithValue("@idDesafio", obj.idDesafio);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
        //Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Desafio obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd1 = new SqlCommand("Delete FROM alternativaDesafio WHERE idDesafio = @idDesafio", conn);
            cmd1.Parameters.AddWithValue("idDesafio", obj.idDesafio);
            cmd1.ExecuteNonQuery();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Desafio WHERE idDesafio = @idDesafio", conn);
            cmd.Parameters.AddWithValue("@idDesafio", obj.idDesafio);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
    }
}