using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALDificuldade
    {
        private string connectionString = "";
        public DALDificuldade()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Dificuldade> Select(int idDificuldade)
        {
            Modelo.Dificuldade DALdif;
            // Cria Lista Vazia
            List<Modelo.Dificuldade> DALlistDif = new List<Modelo.Dificuldade>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Dificuldade Where idDificuldade = @idDificuldade";
            cmd.Parameters.AddWithValue("@idDificuldade", idDificuldade);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    DALdif = new Modelo.Dificuldade(
                        Convert.ToInt32(dr["idDificuldade"]),
                        dr["grau"].ToString()
                        );
                    // Adiciona a disciplina lida à lista
                    DALlistDif.Add(DALdif);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistDif;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Dificuldade> SelectAll() 
        {
            // Variavel para armazenar um livro
            Modelo.Dificuldade aDificuldade;
            // Cria Lista Vazia
            List<Modelo.Dificuldade> aListDificuldade = new List<Modelo.Dificuldade>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Dificuldade";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
  
                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aDificuldade = new Modelo.Dificuldade(Convert.ToInt32(dr["idDificuldade"]), dr["grau"].ToString());
                    // Adiciona o livro lido à lista
                    aListDificuldade.Add(aDificuldade);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListDificuldade;
       }
    }
}