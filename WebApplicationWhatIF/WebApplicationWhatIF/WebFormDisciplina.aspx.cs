using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormDisciplina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableRow tr1;
            TableCell tc0, tc1;
            string idDisciplina = Request.QueryString["idDisciplina"];
            DAL.DALModulo dalmodulo = new DAL.DALModulo();
            List<Modelo.Modulo> ListModulo = new List<Modelo.Modulo>();
            ListModulo = dalmodulo.SelectAllIdDisciplina(Convert.ToInt32(idDisciplina));
            for(int i = 0; i < ListModulo.Count; i++) {
                HyperLink link = new HyperLink();
                link.NavigateUrl = "~/WebFormMateria.aspx?idModulo=" + ListModulo[i].idModulo;
                link.Text = ListModulo[i].titulo;
                link.Font.Name = "Segoe UI Light";
                link.Font.Size = 16;
                link.Font.Bold = true;
                Label descricao = new Label();
                descricao.Text = ListModulo[i].descricao;
                descricao.Font.Name = "Segoe UI Light";
                descricao.Font.Size = 12;
                tc0 = new TableCell();
                tc1 = new TableCell();
                tc0.Controls.Add(link);
                tc1.Controls.Add(descricao);
                tr1 = new TableRow();
                tr1.Cells.Add(tc0);
                tr1.Cells.Add(tc1);
                Table1.Rows.Add(tr1);
            }
            DAL.DALDisciplina disc = new DAL.DALDisciplina();
            Modelo.Disciplina disciplina = new Modelo.Disciplina();
            disciplina = disc.Select(Convert.ToInt32(idDisciplina))[0];
            Label1.Text = disciplina.nome;
        }
    }
}