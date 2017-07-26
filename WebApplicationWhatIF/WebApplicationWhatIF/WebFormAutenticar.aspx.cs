using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormAutenticar : System.Web.UI.Page
    {
        private SqlCommand cmd = new SqlCommand();
        private SqlConnection con = new SqlConnection();
        private SqlDataAdapter sda = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data source=Valera;initial catalog=2017WhatIF;Persist Security Info=true; User ID=2017WhatIF;Password=Senha@123";
            con.Open();
        }

        protected void ButtonEntrar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Aluno where nome='" + TextBoxLogin.Text + "' and senha='" + TextBoxSenha.Text + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Aluno");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["Nome"] = TextBoxLogin.Text;
                Session["Senha"] = TextBoxSenha.Text;
                Response.Redirect("~/WebFormIndex.aspx");
            }
            else
            {
                teste.Text = "Usuário inválido!";
            }


        }
    }
}