using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALAluno dalalu = new DAL.DALAluno();
            if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
                {
                    Response.Redirect("~/WebFormIndex.aspx");
                }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebFormAutenticar.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/WebFormModulo.aspx");
        }
        
        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/WebFormDesafio.aspx");
        }

        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/WebFormListaDeAlunos.aspx");
        }
    }
}