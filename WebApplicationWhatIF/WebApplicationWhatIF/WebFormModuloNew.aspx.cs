using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormModuloNew : System.Web.UI.Page
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
            if (aux == false)
            {
                Response.Redirect("~/WebFormIndex.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int disciplinaid = int.Parse(DisciplinaId.Text);
            Modelo.Modulo mod = new Modelo.Modulo(0, Titulo.Text, Descricao.Text, disciplinaid);
            WebApplicationWhatIF.DAL.DALModulo dalmodulo = new WebApplicationWhatIF.DAL.DALModulo();
            dalmodulo.Insert(mod);
           
            Response.Redirect("~/WebFormModulo.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebFormAutenticar.aspx");
        }
    }
}