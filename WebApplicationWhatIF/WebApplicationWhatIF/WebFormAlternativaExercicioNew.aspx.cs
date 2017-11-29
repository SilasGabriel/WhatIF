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
            Modelo.Exercicio exer = new Modelo.Exercicio();
            DAL.DALExercicio dalexercicio = new DAL.DALExercicio();
            exer = dalexercicio.Select(Convert.ToInt32(Session["idExercicio"]))[0];
            //Definindo variáveis que serão utilizadas na table
            TableRow tr1, tr2, tr3;
            TableCell tc0;
            Label titulo = new Label();
            Label questao = new Label();
            Image fotoquestao = new Image();


            //Adicionando título da questão do Desafio na table
            titulo.Text = exer.titulo;
            titulo.Font.Name = "Segoe UI Light";
            titulo.Font.Size = 16;
            titulo.Font.Bold = true;
            tc0 = new TableCell();
            tc0.Controls.Add(titulo);
            tr1 = new TableRow();
            tr1.Cells.Add(tc0);
            Table1.Rows.Add(tr1);

            //Adicionando imagem da questão do Desafio na table
            if (exer.fotoquestao != null)
            {
                fotoquestao.ImageUrl = "~/HandlerExercicio2.ashx?idExercicio=" + exer.idExercicio;
            }
            tc0 = new TableCell();
            tc0.Controls.Add(fotoquestao);
            tr2 = new TableRow();
            tr2.Cells.Add(tc0);
            Table1.Rows.Add(tr2);

            //Adicionando texto da questão do Desafio na table
            questao.Text = exer.questao;
            questao.Font.Name = "Segoe UI Light";
            questao.Font.Size = 14;
            questao.Font.Bold = true;
            tc0 = new TableCell();
            tc0.Controls.Add(questao);
            tr3 = new TableRow();
            tr3.Cells.Add(tc0);
            Table1.Rows.Add(tr3);
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