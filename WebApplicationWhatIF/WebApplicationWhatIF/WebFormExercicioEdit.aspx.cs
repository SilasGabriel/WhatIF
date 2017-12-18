using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormExercicioEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALAluno dalalu = new DAL.DALAluno();
            if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
            {
                Response.Redirect("~/WebFormIndex.aspx");
            }
            Session["idExercicio"] = Request.QueryString["idExercicio"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALExercicio dalexercicio = new DAL.DALExercicio();
            Modelo.Exercicio exercicio = new Modelo.Exercicio();
            exercicio = dalexercicio.Select(Convert.ToInt32(Request.QueryString["idExercicio"]))[0];
            foreach (DataListItem dli in DataList1.Items)
            {
                TextBox tx = (TextBox)dli.FindControl("TextBox1");
                exercicio.titulo = tx.Text;
            }
            foreach (DataListItem dli in DataList2.Items)
            {
                TextBox tx2 = (TextBox)dli.FindControl("TextBox2");
                exercicio.questao = tx2.Text;
            }
            if ((exercicio.fotoquestao != null) && (FileUpload1.FileName == ""))
            {
                exercicio = new Modelo.Exercicio(exercicio.idExercicio, exercicio.titulo, exercicio.questao, exercicio.fotoquestao, Convert.ToInt32(Session["idMateria"]), Convert.ToInt32(DropDownList1.SelectedValue));
            }
            else
            {
                exercicio = new Modelo.Exercicio(exercicio.idExercicio, exercicio.titulo, exercicio.questao, FileUpload1.FileBytes, Convert.ToInt32(Session["idMateria"]), Convert.ToInt32(DropDownList1.SelectedValue));
            }
            dalexercicio.Update(exercicio);
            Response.Redirect("~/WebFormExercicioNew.aspx?idMateria=" + Session["idMateria"].ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormExercicioNew.aspx?idMateria=" + Session["idMateria"].ToString());
        }
    }
}