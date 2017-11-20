using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormMateriaNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "") Label4.Text = "A matéria deve possuir um título";
            else if (TextBox2.Text == "") { Label4.Text = ""; Label5.Text = "A matéria deve possuir uma descrição"; }
            else
            {
                DAL.DALMateria dalmateria = new DAL.DALMateria();
                Modelo.Materia materia = new Modelo.Materia(TextBox1.Text, TextBox2.Text, FileUpload1.FileBytes, Session["idModulo"].ToString());
                dalmateria.Insert(materia);
                Session["idMateria"] = materia.idMateria;
                Response.Redirect("~/WebFormMateriaNew.aspx");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Verifica se o comando é "Excluir"
            if (e.CommandName == "Excluir")
            {
                int codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);

                DAL.DALMateria dalmateria = new DAL.DALMateria();
                Modelo.Materia materia = new Modelo.Materia();
                materia = dalmateria.Select(codigo)[0];
                dalmateria.Delete(materia);
                // Chama a tela de edição
                Response.Redirect("~\\WebFormMateriaNew.aspx");
            }
        }
    }
}