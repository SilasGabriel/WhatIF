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
            TextBox tx;
            TextBox tx2;
            foreach (DataListItem dli in DataList1.Items)
            {
                tx = (TextBox)dli.FindControl("TextBox1");
                aluno.nome = tx.Text;
                Session["Nome"] = tx.Text;
            }
            foreach (DataListItem dli in DataList2.Items)
            {
                tx2 = (TextBox)dli.FindControl("TextBox2");
                aluno.email = tx2.Text;
            }
            aluno.escolaPublica = Convert.ToBoolean(DropDownListEscola.SelectedItem.Value);
            //Caso o usuário não selecione nenhum arquivo, o upload ocorrerá sem a foto de perfil
            if (FileUpload1.FileName == "")
            {
                // Instancia objeto da camada de negocio
                dalaluno.UpdatePerfilSemFoto(aluno);
            }
            else
            {
                aluno.fotoperfil = FileUpload1.FileBytes;
                dalaluno.Update(aluno);
            }
            //Muda o nome na sessão
            Response.Redirect("~/WebFormIndex.aspx");
        }
    }
}