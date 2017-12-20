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
            double Qfacil = 0;
            double QMedio = 0;
            double QDificil = 0;
            List<Modelo.Exercicio> exercicios = new List<Modelo.Exercicio>();
            DAL.DALExercicio dalexe = new DAL.DALExercicio();
            exercicios = dalexe.SelectAllIDdif(1);
            List<Modelo.RespostaDoAlunoExercicio> resp = new List<Modelo.RespostaDoAlunoExercicio>();
            DAL.DALRespostaDoAlunoExercicio dalresp = new DAL.DALRespostaDoAlunoExercicio();
            resp = dalresp.SelectAllIdDif(1, Session["Nome"].ToString());

            int aux1 = resp.Count;
            int aux2 = exercicios.Count;
            Qfacil = Math.Round(((1.0 * aux1 / aux2) * 100), 2);
            exercicios = dalexe.SelectAllIDdif(2);
            resp = dalresp.SelectAllIdDif(2, Session["Nome"].ToString());
            aux1 = resp.Count;
            aux2 = exercicios.Count;
            QMedio = Math.Round(((1.0 * aux1 / aux2) * 100), 2);
            exercicios = dalexe.SelectAllIDdif(3);
            resp = dalresp.SelectAllIdDif(3, Session["Nome"].ToString());
            aux1 = resp.Count;
            aux2 = exercicios.Count;
            QDificil = Math.Round(((1.0 * aux1 / aux2) * 100), 2);
            Label1.Text = Qfacil.ToString()+"%";
            Label2.Text = QMedio.ToString()+"%";
            Label3.Text = QDificil.ToString()+"%";
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebFormAutenticar.aspx");
        }
    }
}