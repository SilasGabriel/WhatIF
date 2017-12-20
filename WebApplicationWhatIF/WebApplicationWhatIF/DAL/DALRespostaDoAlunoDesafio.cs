using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALRespostaDoAlunoDesafio
    {
        string connectionString = "";

        public DALRespostaDoAlunoDesafio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.RespostaDoAlunoDesafio obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            //Modelo.alternativaDesafio alterna = new Modelo.alternativaDesafio();
            //alterna = obj.alternativadesafio;
            cmd.CommandText = "INSERT INTO respostaDoAlunoDesafio(idAlternativa, idAluno) VALUES(@idAlternativa, @idAluno)";
            cmd.Parameters.AddWithValue("@idAlternativa", obj.idAlternativaDesafio);
            cmd.Parameters.AddWithValue("@idAluno", obj.idAluno);
            cmd.Connection = sc;

            cmd.ExecuteNonQuery();
            sc.Close();
        }
    }
}