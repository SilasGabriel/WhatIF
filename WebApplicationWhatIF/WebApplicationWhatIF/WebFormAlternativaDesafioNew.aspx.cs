using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormAlternativaDesafioNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALAlternativaDesafio dalaterna = new DAL.DALAlternativaDesafio();
            Modelo.alternativaDesafio alterna;
            if ((!dalaterna.verifCorreta(Convert.ToInt32(Session["idDesafio"]))) && (Session["correta"] == "verdade"))
            {
                    alterna = new Modelo.alternativaDesafio(TextBox1.Text, true, Convert.ToInt32(Session["idDesafio"]));
                    dalaterna.Insert(alterna);
                    Response.Redirect("~/WebFormAlternativaDesafioNew.aspx");
            }
            else
            {
                if (Session["correta"] != "verdade") {
                    alterna = new Modelo.alternativaDesafio(TextBox1.Text, false, Convert.ToInt32(Session["idDesafio"]));
                    dalaterna.Insert(alterna);
                    Response.Redirect("~/WebFormAlternativaDesafioNew.aspx");
                }
                else Label1.Text = "A questão já possui uma alternativa correta, você não pode adicionar outra";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                int codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);

                DAL.DALAlternativaDesafio dalalterna = new DAL.DALAlternativaDesafio();
                Modelo.alternativaDesafio alterna = new Modelo.alternativaDesafio();
                alterna = dalalterna.Select(codigo)[0];
                dalalterna.Delete(alterna);
                // Chama a tela de edição
                Response.Redirect("~\\WebFormAlternativaDesafioNew.aspx");
            }
        }
    }
}