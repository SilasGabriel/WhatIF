﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string leitorAdm = string.Empty;
            bool aux = false;
            using (SqlConnection connection = new SqlConnection("Data source=Valera;initial catalog=2017WhatIF;Persist Security Info=true; User ID=2017WhatIF;Password=Senha@123"))
            {
                using (SqlCommand command = new SqlCommand("SELECT administrador FROM Aluno WHERE nome='" + Session["Nome"] + "' and senha='" + Session["Senha"] + "'", connection))
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
            if (aux)
            {
                HyperLink adm = new HyperLink();
                adm.Text = "CRUDs do ADM";
                adm.NavigateUrl = "~/WebFormAdministrador.aspx";
                Page.Controls.Add(adm);
            }
            else
            {
                Label user = new Label();
                user.Text = "Bem-vindo, usuário";
                Page.Controls.Add(user);
            }

        }
    }
}