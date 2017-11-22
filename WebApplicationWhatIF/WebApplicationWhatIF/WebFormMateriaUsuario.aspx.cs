using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormMateriaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableRow tr1, tr2, tr3, tr4;
            TableCell tc0, tc1, tc2, tc3;
            string idMateria = Request.QueryString["idMateria"];
            int aux = Convert.ToInt32(idMateria);
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            Modelo.Materia materia = dalmateria.SelectTeste(aux);
                
           //Adicionando componentes da Label
                Label label = new Label();
                label.Text = materia.titulo;
                label.Font.Name = "Segoe UI Light";
                label.Font.Size = 20;
                label.Font.Bold = true;
                Label descricao = new Label();
                descricao.Text = materia.descricao;
                descricao.Font.Name = "Segoe UI Light";
                descricao.Font.Size = 12;
                
            //Add Imagem
                Image imagem = new Image();
                imagem.ImageUrl = "~/HandlerMateria2.ashx";
                tc0 = new TableCell();
                tc1 = new TableCell();
                tc2 = new TableCell();
                tc0.Controls.Add(label);
                tc1.Controls.Add(descricao);
                tc2.Controls.Add(imagem);
                
            //Add Link Fazer exercício
                HyperLink link = new HyperLink();
                link.NavigateUrl = "~/WebFormExercicioUsuario.aspx?idMateria=" + idMateria;
                link.Text = "Fazer o exercício";
                link.Font.Name = "Segoe UI Light";
                link.Font.Size = 12;
                tc3 = new TableCell();
                tc3.Controls.Add(link);
   
                tr1 = new TableRow();
                tr2 = new TableRow();
                tr3 = new TableRow();
                tr3 = new TableRow();
                tr4 = new TableRow();

                tr1.Cells.Add(tc0);
                tr2.Cells.Add(tc1);
                tr3.Cells.Add(tc2);
                tr4.Cells.Add(tc3);
                Table1.Rows.Add(tr1);
                Table1.Rows.Add(tr2);
                Table1.Rows.Add(tr3);
                Table1.Rows.Add(tr4);
        }
    }
}