using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormExercicioNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALAluno dalalu = new DAL.DALAluno();
            if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
            {
                Response.Redirect("~/WebFormIndex.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.Exercicio exercicio;

            // Instancia objeto da camada de negocio
            DAL.DALExercicio dalexercicio = new DAL.DALExercicio();
            //Para o caso do usuário executar o preview
            if (Session["verif1"] == "true")
            {
                exercicio = new Modelo.Exercicio(TextBox1.Text, TextBox2.Text, (byte[])Session["ImageBytes1"], Convert.ToInt32(Request.QueryString["idMateria"]), Convert.ToInt32(DropDownList1.SelectedValue));
                dalexercicio.Insert(exercicio);
            }
            else
            {
                Session["ImageBytes1"] = FileUpload1.FileBytes;
                Image1.ImageUrl = "~/HandlerExercicio.ashx";

                //Caso o usuário não selecione nenhum arquivo, o insert ocorrerá sem a foto da questão
                if (FileUpload1.HasFile == false)
                {
                    // Instancia objeto da camada de negocio
                    exercicio = new Modelo.Exercicio(TextBox1.Text, TextBox2.Text, Convert.ToInt32(Request.QueryString["idMateria"]), Convert.ToInt32(DropDownList1.SelectedValue));
                    dalexercicio.Insert(exercicio);
                }
                else
                {
                    exercicio = new Modelo.Exercicio(TextBox1.Text, TextBox2.Text, (byte[])Session["ImageBytes1"], Convert.ToInt32(Request.QueryString["idMateria"]), Convert.ToInt32(DropDownList1.SelectedValue));
                    dalexercicio.Insert(exercicio);
                }
            }
            Response.Redirect("~/WebFormExercicioNew.aspx?idMateria=" + Convert.ToInt32(Request.QueryString["idMateria"]));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                Session["ImageBytes1"] = FileUpload1.FileBytes;
                Image1.ImageUrl = "~/HandlerExercicio.ashx";
                Session["verif1"] = "true";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Verifica se o comando é "Adicionar alternativas"
            if (e.CommandName == "Addalterna")
            {
                string codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = GridView1.Rows[index].Cells[0].Text;

                // Grava código do Livro na sessão
                Session["idMateria"] = Request.QueryString["idMateria"];
                Session["idExercicio"] = codigo;
                Session["correta"] = "falso";

                // Chama a tela de edição
                Response.Redirect("~\\WebFormAlternativaExercicioNew.aspx");
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
                Session["idMateria"] = Request.QueryString["idMateria"];
                Session["idExercicio"] = codigo;
                Session["correta"] = "verdade";

                // Chama a tela de edição
                Response.Redirect("~\\WebFormAlternativaExercicioNew.aspx");
            }
            // Verifica se o comando é "Adicionar alternativa correta"
            if (e.CommandName == "Editar")
            {
                string codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = GridView1.Rows[index].Cells[0].Text;
                Session["idMateria"] = GridView1.Rows[index].Cells[3].Text;
                Session["idExercicio"] = GridView1.Rows[index].Cells[0].Text;
                // Chama a tela de edição
                Response.Redirect("~\\WebFormExercicioEdit.aspx?idExercicio=" + codigo);
            }
            // Verifica se o comando é "Adicionar alternativa correta"
            if (e.CommandName == "Excluir")
            {
                int codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);
                DAL.DALExercicio dalexerc = new DAL.DALExercicio();
                Modelo.Exercicio exercicio = new Modelo.Exercicio();
                exercicio = dalexerc.Select(codigo)[0];
                dalexerc.Delete(exercicio);
                // Chama a tela de edição
                Response.Redirect("~\\WebFormExercicioNew.aspx?idMateria=" + GridView1.Rows[index].Cells[3].Text);
            }
        }
    }
}