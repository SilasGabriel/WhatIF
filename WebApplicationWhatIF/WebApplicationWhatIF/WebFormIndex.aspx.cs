using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Nome"] != null) && (Session["Senha"] != null))
            {
                DAL.DALAluno dalalu = new DAL.DALAluno();
                if (!dalalu.verifADM(Session["Nome"], Session["Senha"]))
                {
                    Label user = new Label();
                    user.Text = "Bem-vindo, " + Session["nome"];
                    div1.Controls.Add(user);
                }
                else
                {
                    HyperLink adm = new HyperLink();
                    adm.Text = "Página do Administrador";
                    adm.NavigateUrl = "~/WebFormAdministrador.aspx";
                    Label nomeadm = new Label();
                    nomeadm.Text = "Bem-vindo, " + Session["nome"]+"<br />";
                    div1.Controls.Add(nomeadm);
                    div1.Controls.Add(adm);
                }
            }
            else {
                Response.Redirect("~/WebFormAutenticar.aspx");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebFormAutenticar.aspx");
        }
    }
}