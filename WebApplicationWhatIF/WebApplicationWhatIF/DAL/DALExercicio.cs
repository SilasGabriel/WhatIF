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
    public class DALExercicio
    {
        string connectionString = "";

        public DALExercicio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Exercicio> Select(int idExercicio)
        {
            Modelo.Exercicio DALexercicio;
            // Cria Lista Vazia
            List<Modelo.Exercicio> DALlistExer = new List<Modelo.Exercicio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Exercicio Where idExercicio = @idExercicio";
            cmd.Parameters.AddWithValue("@idExercicio", idExercicio);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Materia materia = new Modelo.Materia();
                    DALMateria dalmateria = new DALMateria();
                    materia = (dalmateria.Select(Convert.ToInt32(dr["idMateria"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    try
                    {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            (byte[])dr["fotoquestao"],
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    catch (InvalidCastException) {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            null,
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    if (DALexercicio.idMateria != null)
                        DALexercicio.materia = dalmateria.Select(DALexercicio.idMateria)[0];
                    // Adiciona o livro lido à lista
                    DALlistExer.Add(DALexercicio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistExer;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Exercicio> SelectAll()
        {
            Modelo.Exercicio DALexercicio;
            // Cria Lista Vazia
            List<Modelo.Exercicio> DALlistExer = new List<Modelo.Exercicio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Exercicio";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Materia materia = new Modelo.Materia();
                    DALMateria dalmateria = new DALMateria();
                    materia = (dalmateria.Select(Convert.ToInt32(dr["idMateria"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    try
                    {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            (byte[])dr["fotoquestao"],
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    catch (InvalidCastException)
                    {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            null,
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    if (DALexercicio.idMateria != null)
                        DALexercicio.materia = dalmateria.Select(DALexercicio.idMateria)[0];
                    // Adiciona o livro lido à lista
                    DALlistExer.Add(DALexercicio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistExer;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Exercicio> SelectAllIdMateria(int idMateria)
        {
            Modelo.Exercicio DALexercicio;
            // Cria Lista Vazia
            List<Modelo.Exercicio> DALlistExer = new List<Modelo.Exercicio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Exercicio where idMateria = @idMateria";
            cmd.Parameters.AddWithValue("@idMateria", idMateria);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Materia materia = new Modelo.Materia();
                    DALMateria dalmateria = new DALMateria();
                    materia = (dalmateria.Select(Convert.ToInt32(dr["idMateria"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    try
                    {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            (byte[])dr["fotoquestao"],
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    catch (InvalidCastException)
                    {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            null,
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    if (DALexercicio.idMateria != null)
                        DALexercicio.materia = dalmateria.Select(DALexercicio.idMateria)[0];
                    // Adiciona o livro lido à lista
                    DALlistExer.Add(DALexercicio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistExer;
        }
        //Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Exercicio obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            Modelo.Materia materia = new Modelo.Materia();
            materia = obj.materia;
            Modelo.Dificuldade dificuldade = new Modelo.Dificuldade();
            dificuldade = obj.dificuldade;
            if (obj.fotoquestao != null)
            {
                cmd.CommandText = "INSERT INTO Exercicio(titulo, questao, fotoquestao, idMateria, idDificuldade) VALUES(@titulo, @questao, @fotoquestao, @idMateria, @idDificuldade)";
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@questao", obj.questao);
                cmd.Parameters.AddWithValue("@fotoquestao", obj.fotoquestao);
                cmd.Parameters.AddWithValue("@idMateria", materia.idMateria);
                cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
                cmd.Connection = sc;
            }
            else 
            {
                cmd.CommandText = "INSERT INTO Exercicio(titulo, questao, idMateria, idDificuldade) VALUES(@titulo, @questao, @idMateria, @idDificuldade)";
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@questao", obj.questao);
                cmd.Parameters.AddWithValue("@idMateria", materia.idMateria);
                cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
                cmd.Connection = sc;
            }
            cmd.ExecuteNonQuery();
            sc.Close();
        }
        //Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Exercicio obj) 
        {
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            Modelo.Materia materia = new Modelo.Materia();
            materia = obj.materia;
            Modelo.Dificuldade dificuldade = new Modelo.Dificuldade();
            dificuldade = obj.dificuldade;
            if (obj.fotoquestao != null)
            {
                cmd.CommandText = "UPDATE Exercicio SET titulo = @titulo, questao = @questao, fotoquestao = @fotoquestao, idMateria = @idMateria, idDificuldade = @idDificuldade WHERE idExercicio = @idExercicio";
                cmd.Parameters.AddWithValue("@idExercicio", obj.idExercicio);
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@questao", obj.questao);
                cmd.Parameters.AddWithValue("@fotoquestao", obj.fotoquestao);
                cmd.Parameters.AddWithValue("@idMateria", materia.idMateria);
                cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
                cmd.Connection = sc;
            }
            else
            {
                cmd.CommandText = "UPDATE Exercicio SET titulo = @titulo, questao = @questao, idMateria = @idMateria, idDificuldade = @idDificuldade WHERE idExercicio = @idExercicio";
                cmd.Parameters.AddWithValue("@idExercicio", obj.idExercicio);
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@questao", obj.questao);
                cmd.Parameters.AddWithValue("@idMateria", materia.idMateria);
                cmd.Parameters.AddWithValue("@idDificuldade", dificuldade.idDificuldade);
                cmd.Connection = sc;
            }
            cmd.ExecuteNonQuery();
            sc.Close();
        }
        //Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Exercicio obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd1 = new SqlCommand("Delete FROM alternativaExercicio WHERE idExercicio = @idExercicio", conn);
            cmd1.Parameters.AddWithValue("idExercicio", obj.idExercicio);
            cmd1.ExecuteNonQuery();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Exercicio WHERE idExercicio = @idExercicio", conn);
            cmd.Parameters.AddWithValue("@idExercicio", obj.idExercicio);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public DataSet SelectData(int idExercicio)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Exercicio Where idExercicio = @idExercicio";
            cmd.Parameters.AddWithValue("@idExercicio", idExercicio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Exercicio> SelectAllIDdif(int idDific)
        {
            Modelo.Exercicio DALexercicio;
            // Cria Lista Vazia
            List<Modelo.Exercicio> DALlistExer = new List<Modelo.Exercicio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Exercicio Where idDificuldade = @idDificuldade";
            cmd.Parameters.AddWithValue("@idDificuldade", idDific);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Materia materia = new Modelo.Materia();
                    DALMateria dalmateria = new DALMateria();
                    materia = (dalmateria.Select(Convert.ToInt32(dr["idMateria"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    try
                    {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            (byte[])dr["fotoquestao"],
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    catch (InvalidCastException)
                    {
                        DALexercicio = new Modelo.Exercicio(
                           Convert.ToInt32(dr["idExercicio"]),
                            dr["titulo"].ToString(),
                            dr["questao"].ToString(),
                            null,
                            Convert.ToInt32(dr["idMateria"]),
                            Convert.ToInt32(dr["idDificuldade"]));
                    }
                    if (DALexercicio.idMateria != null)
                        DALexercicio.materia = dalmateria.Select(DALexercicio.idMateria)[0];
                    // Adiciona o livro lido à lista
                    DALlistExer.Add(DALexercicio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistExer;
        }
    }
}