using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormModulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALAluno dalalu = new DAL.DALAluno();
            if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
            {
                Response.Redirect("~/WebFormIndex.aspx");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Verifica se o comando é "Editar"
            if (e.CommandName == "Editar")
            {
                string codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = GridView1.Rows[index].Cells[0].Text;

                // Grava código do Livro na sessão
                Session["idModulo"] = codigo;

                // Chama a tela de edição
                Response.Redirect("~\\WebFormModuloEdit.aspx");
            }

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebFormAutenticar.aspx");
        }
    }
}