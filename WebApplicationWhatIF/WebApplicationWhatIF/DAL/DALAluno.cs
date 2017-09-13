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
    public class DALAluno
    {
        private string connectionString = "";
        public DALAluno()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
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
                + "" + "VALUES('" + obj.nome + "', '" + obj.senha + "', '" + obj.email + "', " + auxEscolaPublica + ", 0)";
            cmd.Connection = sc;

            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public bool Autenticar(string nome, string senha) 
        { 
            SqlConnection sc = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;
            cmd.CommandText = "select * from Aluno where nome='" + nome + "' and senha='" + senha + "'";
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
                using (SqlCommand command = new SqlCommand("SELECT administrador FROM Aluno WHERE nome='" + nome+ "' and senha='" + senha + "'", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
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
    }
}