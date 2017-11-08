using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALAluno
    {
        private string connectionString = "";
        public DALAluno()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }

        // FAZER IR A FOTO PADRÃO
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Aluno obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            int auxEscolaPublica;
            if (obj.escolaPublica) auxEscolaPublica = 1;
            else auxEscolaPublica = 0;
            cmd.CommandText = "INSERT INTO Aluno(nome, senha, email, escolaPublica, administrador)"
                + "" + "VALUES(@nome, @senha, @email, @escolaPublica, @administrador, @fotoperfil)";
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@escolaPublica", auxEscolaPublica);
            cmd.Parameters.AddWithValue("@administrador", 0);
            cmd.Parameters.AddWithValue("@fotoperfil", obj.fotoperfil);
            cmd.Connection = sc;

            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }

        //Inserir novo aluno
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void InsertNovoAluno(Modelo.Aluno obj)
        {
            Byte[] imagem = File.ReadAllBytes(System.Web.HttpContext.Current.Server.MapPath("./Images/iconePerfil.jpg"));
         
            SqlConnection sc = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            int auxEscolaPublica;
            if (obj.escolaPublica) auxEscolaPublica = 1;
            else auxEscolaPublica = 0;
            cmd.CommandText = "INSERT INTO Aluno(nome, senha, email, escolaPublica, administrador, fotoperfil)"
                + "" + "VALUES(@nome, @senha, @email, @escolaPublica, @administrador, @fotoperfil)";
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@escolaPublica", auxEscolaPublica);
            cmd.Parameters.AddWithValue("@administrador", 0);
            cmd.Parameters.AddWithValue("@fotoperfil", imagem);
            cmd.Connection = sc;

            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }
        // FAZER INJECTION SORT, FAZER CRIAR O OBJETO ALUNO
        [DataObjectMethod(DataObjectMethodType.Select)]
        public bool Autenticar(string nome, string senha) 
        { 
            SqlConnection sc = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;
            cmd.CommandText = "SELECT * from Aluno WHERE nome = @nome and senha = @senha";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            sda.SelectCommand = cmd;
            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
            sda.Fill(ds, "Aluno");
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        //Verificar
        [DataObjectMethod(DataObjectMethodType.Select)]
        public bool verifADM(object nome, object senha){
         string leitorAdm = string.Empty;
            bool aux = false;    
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT administrador from Aluno WHERE nome = @nome and senha = @senha";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Connection = connection;
                using (cmd)
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            leitorAdm = reader[0].ToString();
                            aux = Convert.ToBoolean(leitorAdm);
                        }
                    }
                }
            }
            return aux;
        }

        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Aluno> Select(string nome)
        {
            Modelo.Aluno DALaluno;
            // Cria Lista Vazia
            List<Modelo.Aluno> DALlistAlu = new List<Modelo.Aluno>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Aluno Where nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    try
                    {
                        DALaluno = new Modelo.Aluno(
                            Convert.ToInt32(dr["idAluno"]),
                            dr["nome"].ToString(),
                            dr["senha"].ToString(),
                            dr["email"].ToString(),
                            Convert.ToBoolean(dr["escolaPublica"]),
                            Convert.ToBoolean(dr["administrador"]),
                            (byte[])dr["fotoperfil"]
                            );
                    }
                    catch (InvalidCastException) {
                        DALaluno = new Modelo.Aluno(
                            Convert.ToInt32(dr["idAluno"]),
                            dr["nome"].ToString(),
                            dr["senha"].ToString(),
                            dr["email"].ToString(),
                            Convert.ToBoolean(dr["escolaPublica"]),
                            Convert.ToBoolean(dr["administrador"]),
                            null
                            );
                    }
                    // Adiciona a disciplina lida à lista
                    DALlistAlu.Add(DALaluno);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistAlu;
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public DataSet SelectData(string nome)
        {
            // Cria Lista Vazia
            List<Modelo.Aluno> DALlistAlu = new List<Modelo.Aluno>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Aluno Where nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Aluno> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Aluno aAluno;
            // Cria Lista Vazia
            List<Modelo.Aluno> aListAluno = new List<Modelo.Aluno>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Aluno";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aAluno = new Modelo.Aluno(
                        Convert.ToInt32(dr["idAluno"]),
                        dr["nome"].ToString(),
                        dr["senha"].ToString(),
                        dr["email"].ToString(),
                        Convert.ToBoolean(dr["escolaPublica"]),
                        Convert.ToBoolean(dr["administrador"]),
                        (byte[])dr["fotoperfil"]
                        );
                    // Adiciona o livro lido à lista
                    aListAluno.Add(aAluno);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListAluno;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Aluno> SelectAdm()
        {
            // Variavel para armazenar um livro
            Modelo.Aluno aAluno;
            // Cria Lista Vazia
            List<Modelo.Aluno> aListAluno = new List<Modelo.Aluno>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Aluno where administrador = 1";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aAluno = new Modelo.Aluno(
                        Convert.ToInt32(dr["idAluno"]),
                        dr["nome"].ToString(),
                        dr["senha"].ToString(),
                        dr["email"].ToString(),
                        Convert.ToBoolean(dr["escolaPublica"]),
                        Convert.ToBoolean(dr["administrador"]),
                        (byte[])dr["fotoperfil"]
                        );
                    // Adiciona o livro lido à lista
                    aListAluno.Add(aAluno);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListAluno;
        }
        //Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Aluno obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = new SqlCommand("UPDATE Aluno SET nome = @nome, senha = @senha, email = @email, escolaPublica = @escolaPublica, administrador = @administrador, fotoperfil = @fotoperfil WHERE idAluno = @idAluno", conn);
            cmd.Parameters.AddWithValue("@idAluno", obj.idAluno);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@escolaPublica", obj.escolaPublica);
            cmd.Parameters.AddWithValue("@administrador", obj.administrador);
            cmd.Parameters.AddWithValue("@fotoperfil", obj.fotoperfil);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
        //Update DetailsView
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void UpdateDetailsView(Modelo.Aluno obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = new SqlCommand("UPDATE Aluno SET nome = @nome, senha = @senha, email = @email, escolaPublica = @escolaPublica, administrador = @administrador WHERE idAluno = @idAluno", conn);
            cmd.Parameters.AddWithValue("@idAluno", obj.idAluno);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@escolaPublica", obj.escolaPublica);
            cmd.Parameters.AddWithValue("@administrador", obj.administrador);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
    }
}