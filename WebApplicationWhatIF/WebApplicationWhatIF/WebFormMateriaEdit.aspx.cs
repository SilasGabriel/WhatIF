using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormMateriaEdit : System.Web.UI.Page
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
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            Modelo.Materia materia = new Modelo.Materia();
            materia = dalmateria.Select(Convert.ToInt32(Request.QueryString["idMateria"]))[0];
            foreach (DataListItem dli in DataList1.Items)
            {
                TextBox tx = (TextBox)dli.FindControl("TextBox1");
                materia.titulo = tx.Text;
            }
            foreach (DataListItem dli in DataList2.Items)
            {
                TextBox tx2 = (TextBox)dli.FindControl("TextBox2");
                materia.descricao = tx2.Text;
            }    
            if ((materia.fotomateria != null) && (FileUpload1.FileName == ""))
            {
                materia = new Modelo.Materia(materia.idMateria, materia.titulo, materia.descricao, materia.fotomateria, Session["idModulo"].ToString());
            }
            else 
            {
                materia = new Modelo.Materia(materia.idMateria, materia.titulo, materia.descricao, FileUpload1.FileBytes, Session["idModulo"].ToString());
            }
            dalmateria.Update(materia);
            Session["idMateria"] = materia.idMateria;
            Response.Redirect("~/WebFormMateriaNew.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormMateriaNew.aspx");
        }
    }
}