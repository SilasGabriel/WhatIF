using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormDesafioEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALAluno dalalu = new DAL.DALAluno();
            if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
            {
                Response.Redirect("~/WebFormIndex.aspx");
            }
        }

        protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
        {
            // Verifica se o comando é "Editar"
            if (e.CommandName == "Excluir")
            {
                int codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = Convert.ToInt32(DetailsView1.Rows[1].Cells[1].Text);

                DAL.DALDesafio daldesafio = new DAL.DALDesafio();
                Modelo.Desafio desafio = new Modelo.Desafio();
                desafio = daldesafio.Select(codigo)[0];
                daldesafio.Delete(desafio);
                // Chama a tela de edição
                Response.Redirect("~\\WebFormDesafio.aspx");
            }
        }
    }
}