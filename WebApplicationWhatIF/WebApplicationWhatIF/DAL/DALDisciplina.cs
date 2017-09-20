using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALDisciplina
    {
        private string connectionString = "";
        public DALDisciplina()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Disciplina> Select(int idDisciplina)
        {
            Modelo.Disciplina DALdis;
            // Cria Lista Vazia
            List<Modelo.Disciplina> DALlistDis = new List<Modelo.Disciplina>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Disciplina Where idDisciplina = @idDisciplina";
            cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    DALdis = new Modelo.Disciplina(
                        Convert.ToInt32(dr["idDisciplina"]),
                        dr["nome"].ToString()
                        );
                    // Adiciona a disciplina lida à lista
                    DALlistDis.Add(DALdis);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistDis;
        }
        //SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Disciplina> SelectAll() 
        {
            // Variavel para armazenar um livro
            Modelo.Disciplina aDisciplina;
            // Cria Lista Vazia
            List<Modelo.Disciplina> aListDisciplina = new List<Modelo.Disciplina> ();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Disciplina";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
  
                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aDisciplina = new Modelo.Disciplina(Convert.ToInt32(dr["idDisciplina"]), dr["nome"].ToString());
                    // Adiciona o livro lido à lista
                    aListDisciplina.Add(aDisciplina);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListDisciplina;
       }
    }
}