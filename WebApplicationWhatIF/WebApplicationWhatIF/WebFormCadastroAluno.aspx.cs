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
            bool escolaPublica = Convert.ToBoolean(DropDownListEscola.SelectedItem.Value);
            WebApplicationWhatIF.DAL.DALAluno dalaluno = new WebApplicationWhatIF.DAL.DALAluno();
            List<Modelo.Aluno> alunoverif = new List<Modelo.Aluno>();
            alunoverif = dalaluno.Select(TextBoxNome.Text);
            if (alunoverif.Count == 0)
            {
                Modelo.Aluno aluno = new Modelo.Aluno(TextBoxNome.Text, TextBoxSenha.Text, TextBoxEmail.Text, escolaPublica, false, null);
                // FAZER IR FOTO PADRAO
                dalaluno.InsertNovoAluno(aluno);
                Response.Redirect("~/WebFormAutenticar.aspx");
            }
            else {
                Label1.Text = "Nome do usuário já está sendo usado.";
            }
        }
    }
}