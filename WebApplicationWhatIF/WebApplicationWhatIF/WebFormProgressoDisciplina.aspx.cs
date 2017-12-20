using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormProgressoDisciplina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALDisciplina daldis = new DAL.DALDisciplina();
            Modelo.Disciplina dis = new Modelo.Disciplina();
            int aux1 = Convert.ToInt32(Session["idDisciplina"]);
            dis = daldis.Select(aux1)[0];
            Label5.Text = dis.nome;
            DAL.DALRespostaDoAlunoExercicio dalresp = new DAL.DALRespostaDoAlunoExercicio();
            int[] aux = dalresp.SelectAllCertaIdDisciplina(Convert.ToInt32(Session["idDisciplina"]), Session["Nome"].ToString());
            Label3.Text = aux[0].ToString();
            Label4.Text = aux[1].ToString();
        }
    }
}