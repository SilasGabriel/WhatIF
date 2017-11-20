using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALAlternativaDesafio
    {
        string connectionString = "";

        public DALAlternativaDesafio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.alternativaDesafio> SelectAll(int idDesafio){
            Modelo.alternativaDesafio DALalternativaDesafio;
            // Cria Lista Vazia
            List<Modelo.alternativaDesafio> DALlistAlternativaDesafio = new List<Modelo.alternativaDesafio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from alternativaDesafio where idDesafio = @idDesafio";
            cmd.Parameters.AddWithValue("@idDesafio", idDesafio);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Desafio desafio = new Modelo.Desafio();
                    DALDesafio daldesafio = new DALDesafio();
                    desafio = (daldesafio.Select(Convert.ToInt32(dr["idDesafio"])))[0];
                    DALalternativaDesafio = new Modelo.alternativaDesafio(
                        Convert.ToInt32(dr["idAlternativa"]),
                        dr["texto"].ToString(),
                        Convert.ToBoolean(dr["correta"]),
                        Convert.ToInt32(dr["idDesafio"]));
                        
                    if (DALalternativaDesafio.idDesafio != null)
                        DALalternativaDesafio.desafio = daldesafio.Select(DALalternativaDesafio.idDesafio)[0]; 
                        // Adiciona o livro lido à lista
                    DALlistAlternativaDesafio.Add(DALalternativaDesafio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistAlternativaDesafio;
        }

        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.alternativaDesafio> Select(int idAlternativa)
        {
            // Variavel para armazenar um modulo
            Modelo.alternativaDesafio DALalternativaDesafio;
            // Cria Lista Vazia
            List<Modelo.alternativaDesafio> DALlistAlternativaDesafio = new List<Modelo.alternativaDesafio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from alternativaDesafio Where idAlternativa = @idAlternativa";
            cmd.Parameters.AddWithValue("@idAlternativa", idAlternativa);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do modulo do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Desafio desafio = new Modelo.Desafio();
                    DALDesafio daldesafio = new DALDesafio();
                    desafio = (daldesafio.Select(Convert.ToInt32(dr["idDesafio"])))[0];
                    // Cria objeto com dados lidos do banco de dados
                    DALalternativaDesafio = new Modelo.alternativaDesafio(
                       Convert.ToInt32(dr["idAlternativa"]),
                        dr["texto"].ToString(),
                        Convert.ToBoolean(dr["correta"]),
                        Convert.ToInt32(dr["idDesafio"]));

                    if (DALalternativaDesafio.idDesafio != null)
                        DALalternativaDesafio.desafio = daldesafio.Select(DALalternativaDesafio.idDesafio)[0];
                    // Adiciona o livro lido à lista
                    DALlistAlternativaDesafio.Add(DALalternativaDesafio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistAlternativaDesafio;
        }

        //Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.alternativaDesafio obj){
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM alternativaDesafio WHERE idAlternativa = @idAlternativa", conn);
            cmd.Parameters.AddWithValue("@idAlternativa", obj.idAlternativa);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        //Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.alternativaDesafio obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            Modelo.Desafio desafio = new Modelo.Desafio();
            desafio = obj.desafio;
            cmd.CommandText = "INSERT INTO alternativaDesafio(texto, correta, idDesafio) VALUES(@texto, @correta, @idDesafio)";
            cmd.Parameters.AddWithValue("@texto", obj.texto);
            cmd.Parameters.AddWithValue("@correta", obj.correta);
            cmd.Parameters.AddWithValue("@idDesafio", desafio.idDesafio);
            cmd.Connection = sc;

            cmd.ExecuteNonQuery();
            sc.Close();
        }

        //Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.alternativaDesafio obj)
        { 
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            Modelo.Desafio desafio = new Modelo.Desafio();
            desafio.idDesafio = obj.idDesafio;
            SqlCommand cmd = new SqlCommand("UPDATE alternativaDesafio SET texto = @texto, correta = @correta, idDesafio = @idDesafio WHERE idAlternativa = @idAlternativa", conn);
            cmd.Parameters.AddWithValue("@idAlternativa", obj.idAlternativa);
            cmd.Parameters.AddWithValue("@texto", obj.texto);
            cmd.Parameters.AddWithValue("@correta", obj.correta);
            cmd.Parameters.AddWithValue("@idDesafio", desafio.idDesafio);
            // Executa Comando
            cmd.ExecuteNonQuery();

        }
        //Verificar se já existe alguma alternativa correta
        [DataObjectMethod(DataObjectMethodType.Select)]
        public bool verifCorreta(int idDesafio)
        {
            string leitorCorreta = string.Empty;
            bool aux = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT correta from alternativaDesafio WHERE idDesafio = @idDesafio";
                cmd.Parameters.AddWithValue("@idDesafio", idDesafio);
                cmd.Connection = connection;
                using (cmd)
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            leitorCorreta = reader[0].ToString();
                            aux = Convert.ToBoolean(leitorCorreta);
                            if (aux == true) return aux;
                        }
                    }
                }
            }
            return aux;
        }

        //Calcula o número de alternativas
        [DataObjectMethod(DataObjectMethodType.Select)]
        public int calcAlterna(int idDesafio)
        {
            int aux = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT idAlternativa from alternativaDesafio WHERE idDesafio = @idDesafio";
                cmd.Parameters.AddWithValue("@idDesafio", idDesafio);
                cmd.Connection = connection;
                using (cmd)
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            aux++;
                        }
                    }
                }
            }
            return aux;
        }
        //Verificar se já existe alguma alternativa correta
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<int> idAlternativa(int idDesafio)
        {
            int leitor = 0;
            //int cont = 1;
            List<int> lista = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT idAlternativa from alternativaDesafio WHERE idDesafio = @idDesafio";
                cmd.Parameters.AddWithValue("@idDesafio", idDesafio);
                cmd.Connection = connection;
                using (cmd)
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            leitor = Convert.ToInt32(reader[0]);
                            lista.Add(leitor);
                            //cont++;
                        }
                    }
                }
            }
            return lista;
        }
    }
}