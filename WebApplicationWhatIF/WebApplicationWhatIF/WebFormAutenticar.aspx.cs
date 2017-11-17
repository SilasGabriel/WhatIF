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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEntrar_Click(object sender, EventArgs e)
        {
            WebApplicationWhatIF.DAL.DALAluno dalaluno = new WebApplicationWhatIF.DAL.DALAluno();
            bool verif = dalaluno.Autenticar(TextBoxLogin.Text, TextBoxSenha.Text);
            if (verif)
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