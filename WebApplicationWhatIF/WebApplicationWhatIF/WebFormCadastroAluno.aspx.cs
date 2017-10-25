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
            Modelo.Aluno aluno = new Modelo.Aluno(TextBoxNome.Text, TextBoxSenha.Text, TextBoxEmail.Text, escolaPublica, false, null);
            // FAZER IR FOTO PADRAO
            WebApplicationWhatIF.DAL.DALAluno dalaluno = new WebApplicationWhatIF.DAL.DALAluno();
            dalaluno.Insert(aluno);
            Response.Redirect("~/WebFormAutenticar.aspx");
        }
    }
}