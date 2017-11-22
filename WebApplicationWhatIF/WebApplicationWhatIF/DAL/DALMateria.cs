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
    public class DALMateria
    {
        string connectionString = "";

        public DALMateria()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Materia> SelectAll(){
            Modelo.Materia DALmateria;
            // Cria Lista Vazia
            List<Modelo.Materia> DALlistMateria = new List<Modelo.Materia>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Materia";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Modulo mod = new Modelo.Modulo();
                    DALModulo dalmod = new DALModulo();
                    mod = (dalmod.Select(Convert.ToInt32(dr["idModulo"])))[0];
                    DALmateria = new Modelo.Materia(
                        Convert.ToInt32(dr["idMateria"]),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        (byte[])dr["fotomateria"],
                        dr["idModulo"].ToString());
                        
                    if (DALmateria.idModulo != null)
                        DALmateria.modulo = dalmod.Select(Convert.ToInt32(DALmateria.idModulo))[0]; 
                        // Adiciona o livro lido à lista
                    DALlistMateria.Add(DALmateria);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistMateria;
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Materia> Select(int idMateria)
        {
            // Variavel para armazenar um modulo
            Modelo.Materia DALmateria;
            // Cria Lista Vazia
            List<Modelo.Materia> DALlistMateria = new List<Modelo.Materia>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Materia Where idMateria = @idMateria";
            cmd.Parameters.AddWithValue("@idMateria", idMateria);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do modulo do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Modulo mod = new Modelo.Modulo();
                    DALModulo dalmod = new DALModulo();
                    mod = (dalmod.Select(Convert.ToInt32(dr["idModulo"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    DALmateria = new Modelo.Materia(
                        Convert.ToInt32(dr["idMateria"]),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        (byte[])dr["fotomateria"],
                        dr["idModulo"].ToString());

                    if (DALmateria.idModulo != null)
                        DALmateria.modulo = dalmod.Select(Convert.ToInt32(DALmateria.idModulo))[0];
                    // Adiciona o livro lido à lista
                    DALlistMateria.Add(DALmateria);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistMateria;
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Materia SelectTeste(int idMateria)
        {
            // Variavel para armazenar um modulo
            Modelo.Materia DALmateria = new Modelo.Materia();
            // Cria Lista Vazia
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Materia Where idMateria = @idMateria";
            cmd.Parameters.AddWithValue("@idMateria", idMateria);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do modulo do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Modulo mod = new Modelo.Modulo();
                    DALModulo dalmod = new DALModulo();
                    mod = (dalmod.Select(Convert.ToInt32(dr["idModulo"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    DALmateria = new Modelo.Materia(
                        Convert.ToInt32(dr["idMateria"]),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        (byte[])dr["fotomateria"],
                        dr["idModulo"].ToString());

                    if (DALmateria.idModulo != null)
                        DALmateria.modulo = dalmod.Select(Convert.ToInt32(DALmateria.idModulo))[0];
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALmateria;
        }
        //SelectAllIdMatéria
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Materia> SelectAllIdModulo(int idModulo)
        {
            Modelo.Materia DALmateria;
            // Cria Lista Vazia
            List<Modelo.Materia> DALlistMateria = new List<Modelo.Materia>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Materia where idModulo = @idModulo";
            cmd.Parameters.AddWithValue("@idModulo", idModulo);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Modulo mod = new Modelo.Modulo();
                    DALModulo dalmod = new DALModulo();
                    mod = (dalmod.Select(Convert.ToInt32(dr["idModulo"])))[0];
                    DALmateria = new Modelo.Materia(
                        Convert.ToInt32(dr["idMateria"]),
                        dr["titulo"].ToString(),
                        dr["descricao"].ToString(),
                        (byte[])dr["fotomateria"],
                        dr["idModulo"].ToString());

                    if (DALmateria.idModulo != null)
                        DALmateria.modulo = dalmod.Select(Convert.ToInt32(DALmateria.idModulo))[0];
                    // Adiciona o livro lido à lista
                    DALlistMateria.Add(DALmateria);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistMateria;
        }
        //Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Materia obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            List<Modelo.Exercicio> exercicio = new List<Modelo.Exercicio>();
            DAL.DALExercicio dalexer = new DAL.DALExercicio();
            exercicio = dalexer.SelectAllIdMateria(obj.idMateria);
            for (int i = 0; i < exercicio.Count; i++)
            {
                SqlCommand cmd2 = new SqlCommand("DELETE FROM alternativaExercicio WHERE idExercicio = @idExercicio", conn);
                cmd2.Parameters.AddWithValue("@idExercicio", exercicio[i].idExercicio);
                cmd2.ExecuteNonQuery();
            }
            SqlCommand cmd1 = new SqlCommand("DELETE FROM Exercicio WHERE idMateria = @idMateria", conn);
            cmd1.Parameters.AddWithValue("@idMateria", obj.idMateria);
            SqlCommand cmd = new SqlCommand("DELETE FROM Materia WHERE idMateria = @idMateria", conn);
            cmd.Parameters.AddWithValue("@idMateria", obj.idMateria);

            // Executa Comando
            cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
        }
        //Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Materia obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            Modelo.Modulo mod = new Modelo.Modulo();
            mod = obj.modulo;
            cmd.CommandText = "INSERT INTO Materia(titulo, descricao, fotomateria, idModulo) VALUES(@titulo, @descricao, @fotomateria, @idModulo)";
            cmd.Parameters.AddWithValue("@titulo", obj.titulo);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@fotomateria", obj.fotomateria);
            cmd.Parameters.AddWithValue("@idModulo", obj.idModulo);
            cmd.Connection = sc;

            cmd.ExecuteNonQuery();
            sc.Close();
        }
        //Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Materia obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            Modelo.Modulo mod = new Modelo.Modulo();
            mod.idModulo = obj.idModulo;
            SqlCommand cmd;
            if (obj.fotomateria != null)
            {
                cmd = new SqlCommand("UPDATE Materia SET titulo = @titulo, descricao = @descricao, fotomateria = @fotomateria, idModulo = @idModulo WHERE idMateria = @idMateria", conn);
                cmd.Parameters.AddWithValue("@idMateria", obj.idMateria);
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@fotomateria", obj.fotomateria);
                cmd.Parameters.AddWithValue("@idModulo", Convert.ToInt32(mod.idModulo));
            }
            else 
            {
                cmd = new SqlCommand("UPDATE Materia SET titulo = @titulo, descricao = @descricao, idModulo = @idModulo WHERE idMateria = @idMateria", conn);
                cmd.Parameters.AddWithValue("@idMateria", obj.idMateria);
                cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@idModulo", Convert.ToInt32(mod.idModulo));
            }
            // Executa Comando
            cmd.ExecuteNonQuery();
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public DataSet SelectData(int idMateria)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Materia Where idMateria = @idMateria";
            cmd.Parameters.AddWithValue("@idMateria", idMateria);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}