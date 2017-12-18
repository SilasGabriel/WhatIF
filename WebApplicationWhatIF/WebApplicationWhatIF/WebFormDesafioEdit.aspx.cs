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

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALDesafio daldesafio = new DAL.DALDesafio();
            Modelo.Desafio desafio = new Modelo.Desafio();
            desafio = daldesafio.Select(Convert.ToInt32(Session["idDesafio"]))[0];
            foreach (DataListItem dli in DataList1.Items)
            {
                TextBox tx = (TextBox)dli.FindControl("TextBox3");
                desafio.titulo = tx.Text;
            }
            foreach (DataListItem dli in DataList2.Items)
            {
                TextBox tx2 = (TextBox)dli.FindControl("TextBox4");
                desafio.questao = tx2.Text;
            }
            if ((desafio.fotoquestao != null) && (FileUpload1.FileName == ""))
            {
                desafio = new Modelo.Desafio(desafio.idDesafio, desafio.titulo, desafio.questao, desafio.fotoquestao, Convert.ToInt32(DropDownList1.SelectedValue));
            }
            else
            {
                desafio = new Modelo.Desafio(desafio.idDesafio, desafio.titulo, desafio.questao, FileUpload1.FileBytes, Convert.ToInt32(DropDownList1.SelectedValue));
            }
            daldesafio.Update(desafio);
            Response.Redirect("~/WebFormDesafio.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormDesafio.aspx");
        }
    }
}