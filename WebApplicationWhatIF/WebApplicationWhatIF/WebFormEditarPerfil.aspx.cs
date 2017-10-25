using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormEditarPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.Aluno aluno;

            // Instancia objeto da camada de negocio
            DAL.DALAluno dalaluno = new DAL.DALAluno();

            // Chama metodo de insert passando o objeto preenchido
            aluno = dalaluno.Select(Session["Nome"].ToString())[0];

            // Instancia um Objeto de Livro com as informações fornecidas
            aluno.fotoperfil = FileUpload1.FileBytes;

            // Instancia objeto da camada de negocio
            dalaluno.Update(aluno);

            // Chama metodo de insert passando o objeto preenchido
            //dalaluno.Insert(aluno);

        }
    }
}