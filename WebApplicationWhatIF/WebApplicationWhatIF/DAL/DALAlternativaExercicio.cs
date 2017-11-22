using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALAlternativaExercicio
    {
        string connectionString = "";

        public DALAlternativaExercicio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.alternativaExercicio> SelectAll(int idExercicio){
            Modelo.alternativaExercicio DALalternativaExercicio;
            // Cria Lista Vazia
            List<Modelo.alternativaExercicio> DALlistAlternativaExercicio = new List<Modelo.alternativaExercicio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from alternativaExercicio where idExercicio = @idExercicio";
            cmd.Parameters.AddWithValue("@idExercicio", idExercicio);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Exercicio exercicio = new Modelo.Exercicio();
                    DALExercicio dalexercicio = new DALExercicio();
                    exercicio = (dalexercicio.Select(Convert.ToInt32(dr["idExercicio"])))[0];
                    DALalternativaExercicio = new Modelo.alternativaExercicio(
                        Convert.ToInt32(dr["idAlternativa"]),
                        dr["texto"].ToString(),
                        Convert.ToBoolean(dr["correta"]),
                        Convert.ToInt32(dr["idExercicio"]));
                        
                    if (DALalternativaExercicio.idExercicio != null)
                        DALalternativaExercicio.exercicio = dalexercicio.Select(DALalternativaExercicio.idExercicio)[0]; 
                        // Adiciona o livro lido à lista
                    DALlistAlternativaExercicio.Add(DALalternativaExercicio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistAlternativaExercicio;
        }

        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.alternativaExercicio> Select(int idAlternativa)
        {
            Modelo.alternativaExercicio DALalternativaExercicio;
            // Cria Lista Vazia
            List<Modelo.alternativaExercicio> DALlistAlternativaExercicio = new List<Modelo.alternativaExercicio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from alternativaExercicio where idAlternativa = @idAlternativa";
            cmd.Parameters.AddWithValue("@idAlternativa", idAlternativa);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    Modelo.Exercicio exercicio = new Modelo.Exercicio();
                    DALExercicio dalexercicio = new DALExercicio();
                    exercicio = (dalexercicio.Select(Convert.ToInt32(dr["idExercicio"])))[0];
                    DALalternativaExercicio = new Modelo.alternativaExercicio(
                        Convert.ToInt32(dr["idAlternativa"]),
                        dr["texto"].ToString(),
                        Convert.ToBoolean(dr["correta"]),
                        Convert.ToInt32(dr["idExercicio"]));

                    if (DALalternativaExercicio.idExercicio != null)
                        DALalternativaExercicio.exercicio = dalexercicio.Select(DALalternativaExercicio.idExercicio)[0];
                    // Adiciona o livro lido à lista
                    DALlistAlternativaExercicio.Add(DALalternativaExercicio);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistAlternativaExercicio;
        }

        //Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.alternativaExercicio obj){
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM alternativaExercicio WHERE idAlternativa = @idAlternativa", conn);
            cmd.Parameters.AddWithValue("@idAlternativa", obj.idAlternativa);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        //Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.alternativaExercicio obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            Modelo.Exercicio exercicio = new Modelo.Exercicio();
            exercicio = obj.exercicio;
            cmd.CommandText = "INSERT INTO alternativaExercicio(texto, correta, idExercicio) VALUES(@texto, @correta, @idExercicio)";
            cmd.Parameters.AddWithValue("@texto", obj.texto);
            cmd.Parameters.AddWithValue("@correta", obj.correta);
            cmd.Parameters.AddWithValue("@idExercicio", exercicio.idExercicio);
            cmd.Connection = sc;

            cmd.ExecuteNonQuery();
            sc.Close();
        }

        //Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.alternativaExercicio obj)
        { 
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            Modelo.Exercicio exercicio = new Modelo.Exercicio();
            exercicio.idExercicio = obj.idExercicio;
            SqlCommand cmd = new SqlCommand("UPDATE alternativaExercicio SET texto = @texto, correta = @correta, idExercicio = @idExercicio WHERE idAlternativa = @idAlternativa", conn);
            cmd.Parameters.AddWithValue("@idAlternativa", obj.idAlternativa);
            cmd.Parameters.AddWithValue("@texto", obj.texto);
            cmd.Parameters.AddWithValue("@correta", obj.correta);
            cmd.Parameters.AddWithValue("@idExercicio", exercicio.idExercicio);
            // Executa Comando
            cmd.ExecuteNonQuery();

        }
        //Verificar se já existe alguma alternativa correta
        [DataObjectMethod(DataObjectMethodType.Select)]
        public bool verifCorreta(int idExercicio)
        {
            string leitorCorreta = string.Empty;
            bool aux = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT correta from alternativaExercicio WHERE idExercicio = @idExercicio";
                cmd.Parameters.AddWithValue("@idExercicio", idExercicio);
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
        public int calcAlterna(int idExercicio)
        {
            int aux = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT idAlternativa from alternativaExercicio WHERE idExercicio = @idExercicio";
                cmd.Parameters.AddWithValue("@idExercicio", idExercicio);
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
        //Retorna os ids das alternativas numa List de inteiros
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<int> idAlternativa(int idExercicio)
        {
            int leitor = 0;
            //int cont = 1;
            List<int> lista = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT idAlternativa from alternativaExercicio WHERE idExercicio = @idExercicio";
                cmd.Parameters.AddWithValue("@idExercicio", idExercicio);
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