using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class MasterPageAluno : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Nome"] != null) && (Session["Senha"] != null))
            {
                DAL.DALAluno dalalu = new DAL.DALAluno();
                if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
                {
                    Button5.Text = "Sair";
                    ImageButton1.ImageUrl = "HandlerAluno.ashx";
                }
                else
                {
                    Button5.Text = "Sair";
                    ImageButton1.ImageUrl = "HandlerAluno.ashx";
                }
            }
            else
            {
                Button5.Text = "Entrar";
                ImageButton1.AlternateText = " ";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormDisciplina.aspx?idDisciplina=2");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormDisciplina.aspx?idDisciplina=1");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebFormQuestãoDesafio.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Button5.Text == "Sair") {
                Session.Abandon();
                Response.Redirect("~/WebFormAutenticar.aspx");
            }
            if (Button5.Text == "Entrar") {
                Response.Redirect("~/WebFormAutenticar.aspx");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/WebFormEditarPerfil.aspx");
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/WebFormIndex.aspx");
        }
    }
}