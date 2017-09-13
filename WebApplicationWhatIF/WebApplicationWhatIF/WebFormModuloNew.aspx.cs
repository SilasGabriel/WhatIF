using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormModuloNew : System.Web.UI.Page
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
            DAL.DALModulo dalmodulo = new DAL.DALModulo();
            Modelo.Disciplina dis = new Modelo.Disciplina();
            DAL.DALDisciplina daldis = new DAL.DALDisciplina();
            dis = (daldis.Select(Convert.ToInt32(DisciplinaId.Text)))[0];
            Modelo.Modulo mod = new Modelo.Modulo();
            mod.titulo = TituloId.Text;
            mod.descricao = DescricaoId.Text;
            mod.disciplina = dis;
            dalmodulo.Insert(mod);
            Response.Redirect("~/WebFormModulo.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebFormAutenticar.aspx");
        }
    }
}