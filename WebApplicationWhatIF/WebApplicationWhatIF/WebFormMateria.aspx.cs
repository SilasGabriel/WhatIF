using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableRow tr1;
            TableCell tc0;
            string idModulo = Request.QueryString["idModulo"];
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            List<Modelo.Materia> ListMateria = new List<Modelo.Materia>();
            ListMateria = dalmateria.SelectAllIdModulo(Convert.ToInt32(idModulo));
            for (int i = 0; i < ListMateria.Count; i++)
            {
                HyperLink link = new HyperLink();
                link.NavigateUrl = "~/WebFormMateriaUsuario.aspx?idMateria=" + ListMateria[i].idMateria;
                link.Text = ListMateria[i].titulo;
                link.Font.Name = "Segoe UI Light";
                link.Font.Size = 16;
                link.Font.Bold = true;
                tc0 = new TableCell();
                tc0.Controls.Add(link);
                tr1 = new TableRow();
                tr1.Cells.Add(tc0);
                Table1.Rows.Add(tr1);
            }
        }
    }
}