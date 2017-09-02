﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        //[DataObjectMethod(DataObjectMethodType.Select)]
        //public void Select()
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Aluno obj)
        {
            SqlConnection sc = new SqlConnection("Data source=Valera;initial catalog=2017WhatIF;Persist Security Info=true;User ID=2017WhatIF;Password=Senha@123");

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

    }
}