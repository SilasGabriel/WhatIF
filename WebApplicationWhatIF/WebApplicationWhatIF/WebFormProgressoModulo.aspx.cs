using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormProgressoModulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALModulo dalmod = new DAL.DALModulo();
            Modelo.Modulo mod = new Modelo.Modulo();
            mod = dalmod.Select(Convert.ToInt32(Session["idModulo"]))[0];
            Label5.Text = mod.titulo;
            DAL.DALRespostaDoAlunoExercicio dalresp = new DAL.DALRespostaDoAlunoExercicio();
            int[] aux = dalresp.SelectAllCertaIdModulo(Convert.ToInt32(Session["idModulo"]), Session["Nome"].ToString());
            Label3.Text = aux[0].ToString();
            Label4.Text = aux[1].ToString();
        }
    }
}