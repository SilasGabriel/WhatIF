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
            //Definindo variáveis que serão utilizadas na table
            TableRow tr1, tr2, tr3;
            TableCell tc0;
            Label titulo = new Label();
            Label questao = new Label();
            Image fotoquestao = new Image();
            Label c = new Label();

            DAL.DALDesafio daldes = new DAL.DALDesafio();
            Modelo.Desafio des = new Modelo.Desafio();
            des = daldes.Select(Convert.ToInt32(Session["idDesafio"]))[0];
            string codigo = Session["idDesafio"].ToString();

            //Adicionando título da questão do Desafio na table
            titulo.Text = des.titulo;
            titulo.Font.Name = "Segoe UI Light";
            titulo.Font.Size = 16;
            titulo.Font.Bold = true;
            tc0 = new TableCell();
            tc0.Controls.Add(titulo);
            tr1 = new TableRow();
            tr1.Cells.Add(tc0);
            Table1.Rows.Add(tr1);

            //Adicionando imagem da questão do Desafio na table
            if (des.fotoquestao != null)
            {
                fotoquestao.ImageUrl = "~/HandlerDesafio2.ashx?idDesafio=" + codigo;
            }
            tc0 = new TableCell();
            tc0.Controls.Add(fotoquestao);
            tr2 = new TableRow();
            tr2.Cells.Add(tc0);
            Table1.Rows.Add(tr2);

            //Adicionando texto da questão do Desafio na table
            questao.Text = des.questao;
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALAlternativaDesafio dalaterna = new DAL.DALAlternativaDesafio();
            Modelo.alternativaDesafio alterna;
            if (dalaterna.calcAlterna(Convert.ToInt32(Session["idDesafio"])) < 5)
            {
                if ((!dalaterna.verifCorreta(Convert.ToInt32(Session["idDesafio"]))) && (Session["correta"] == "verdade"))
                {
                    alterna = new Modelo.alternativaDesafio(TextBox1.Text, true, Convert.ToInt32(Session["idDesafio"]));
                    dalaterna.Insert(alterna);
                    Response.Redirect("~/WebFormAlternativaDesafioNew.aspx");
                }
                else
                {
                    if (Session["correta"] != "verdade")
                    {
                        if ((!dalaterna.verifCorreta(Convert.ToInt32(Session["idDesafio"]))) && (dalaterna.calcAlterna(Convert.ToInt32(Session["idDesafio"])) == 4)) Label1.Text = "Você precisa ter pelo menos 1 alternativa correta";
                        else
                        {
                            alterna = new Modelo.alternativaDesafio(TextBox1.Text, false, Convert.ToInt32(Session["idDesafio"]));
                            dalaterna.Insert(alterna);
                            Response.Redirect("~/WebFormAlternativaDesafioNew.aspx");
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