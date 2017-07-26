using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormCadastroAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data source=Valera;initial catalog=2017WhatIF;Persist Security Info=true;User ID=2017WhatIF;Password=Senha@123");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Aluno(nome, senha, email, escolaPublica, administrador)"
                + "" + "VALUES('" + TextBoxNome.Text + "', '" + TextBoxSenha.Text + "', '" + TextBoxEmail.Text + "', " + DropDownListEscola.SelectedItem.Value + ", 0)";
            cmd.Connection = sc;

            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();

            Response.Redirect("~/WebFormAutenticar.aspx");
        }
    }
}