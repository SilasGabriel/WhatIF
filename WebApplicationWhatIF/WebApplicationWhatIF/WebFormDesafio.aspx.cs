using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormDesafio1 : System.Web.UI.Page
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
                Session["idDesafio"] = codigo;

                Session["idDificuldade"] = GridView1.Rows[index].Cells[3].Text;

                // Chama a tela de edição
                Response.Redirect("~\\WebFormDesafioEdit.aspx");
            }
            // Verifica se o comando é "Adicionar alternativas"
            if (e.CommandName == "Addalterna")
            {
                string codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = GridView1.Rows[index].Cells[0].Text;

                // Grava código do Livro na sessão
                Session["idDesafio"] = codigo;
                Session["correta"] = "falso";

                // Chama a tela de edição
                Response.Redirect("~\\WebFormAlternativaDesafioNew.aspx");
            }
            // Verifica se o comando é "Adicionar alternativa correta"
            if (e.CommandName == "Addcorreta")
            {
                string codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = GridView1.Rows[index].Cells[0].Text;

                // Grava código do Livro na sessão
                Session["idDesafio"] = codigo;
                Session["correta"] = "verdade";

                // Chama a tela de edição
                Response.Redirect("~\\WebFormAlternativaDesafioNew.aspx");
            }
            if (e.CommandName == "Excluir")
            {
                string codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = GridView1.Rows[index].Cells[0].Text;

                // Grava código do Livro na sessão
                DAL.DALDesafio daldes = new DAL.DALDesafio();
                Modelo.Desafio des = new Modelo.Desafio();
                des = daldes.Select(Convert.ToInt32(codigo))[0];
                daldes.Delete(des);

                // Chama a tela de edição
                Response.Redirect("~\\WebFormDesafio.aspx");
            }
        }
    }
}