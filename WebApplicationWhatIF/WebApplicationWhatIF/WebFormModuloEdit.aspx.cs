using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormModuloEdit : System.Web.UI.Page
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

        protected void ObjectDataSource1_Updating(object sender, ObjectDataSourceMethodEventArgs e)
        {
            DropDownList drop = (DetailsView1.FindControl("DropDownList1") as DropDownList);
            Modelo.Disciplina d = (drop.Items[drop.SelectedIndex] as Modelo.Disciplina);
        }
    }
}