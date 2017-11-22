using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormAlternativaExercicioNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALAluno dalalu = new DAL.DALAluno();
            if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
            {
                Response.Redirect("~/WebFormIndex.aspx");
            }
            HyperLink1.NavigateUrl = "~/WebFormExercicioNew.aspx?idMateria=" + Session["idMateria"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALAlternativaExercicio dalaterna = new DAL.DALAlternativaExercicio();
            Modelo.alternativaExercicio alterna;
            if (dalaterna.calcAlterna(Convert.ToInt32(Session["idExercicio"])) < 5)
            {
                if ((!dalaterna.verifCorreta(Convert.ToInt32(Session["idExercicio"]))) && (Session["correta"] == "verdade"))
                {
                    alterna = new Modelo.alternativaExercicio(TextBox1.Text, true, Convert.ToInt32(Session["idExercicio"]));
                    dalaterna.Insert(alterna);
                    Response.Redirect("~/WebFormAlternativaExercicioNew.aspx");
                }
                else
                {
                    if (Session["correta"] != "verdade")
                    {
                        if ((!dalaterna.verifCorreta(Convert.ToInt32(Session["idExercicio"]))) && (dalaterna.calcAlterna(Convert.ToInt32(Session["idExercicio"])) == 4)) Label1.Text = "A questão precisa ter pelo menos 1 alternativa correta";
                        else
                        {
                            alterna = new Modelo.alternativaExercicio(TextBox1.Text, false, Convert.ToInt32(Session["idExercicio"]));
                            dalaterna.Insert(alterna);
                            Response.Redirect("~/WebFormAlternativaExercicioNew.aspx");
                        }
                    }
                    else Label1.Text = "A questão já possui uma alternativa correta, você não pode adicionar outra";
                }
            }
            else Label1.Text = "A questão só pode possuir no máximo 5 alternativas";
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

                DAL.DALAlternativaExercicio dalalterna = new DAL.DALAlternativaExercicio();
                Modelo.alternativaExercicio alterna = new Modelo.alternativaExercicio();
                alterna = dalalterna.Select(codigo)[0];
                dalalterna.Delete(alterna);
                // Chama a tela de edição
                Response.Redirect("~\\WebFormAlternativaExercicioNew.aspx");
            }
        }
    }
}