using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormQuestãoDesafio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!((Session["Nome"] != null) && (Session["Senha"] != null)))
            {
               Response.Redirect("~/WebFormAutenticar.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Define a label como vazia e os radiobutton vazios
            Label6.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            RadioButton5.Checked = false;

            //Definindo variáveis que serão utilizadas na table
            TableRow tr1, tr2, tr3;
            TableCell tc0;
            Label titulo = new Label();
            Label questao = new Label();
            Image fotoquestao = new Image();
            Label c = new Label();

            int codigo = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            DAL.DALDesafio daldes = new DAL.DALDesafio();
            Modelo.Desafio des = new Modelo.Desafio();
            des = daldes.Select(codigo)[0];
            
            //Adicionando título da questão do Desafio na table
            titulo.Text = des.titulo;
            titulo.Font.Name = "Segoe UI Light";
            titulo.Font.Size = 16;
            titulo.Font.Bold = true;
            tc0 = new TableCell();
            tc0.Controls.Add(titulo);
            tr1 = new TableRow();
            tr1.Cells.Add(tc0);
            Table1.Rows.Add(tr1);
            
            //Adicionando imagem da questão do Desafio na table
            if (des.fotoquestao != null) {
                fotoquestao.ImageUrl = "~/HandlerDesafio2.ashx?idDesafio=" + codigo;
            }
            tc0 = new TableCell();
            tc0.Controls.Add(fotoquestao);
            tr2 = new TableRow();
            tr2.Cells.Add(tc0);
            Table1.Rows.Add(tr2);
            
            //Adicionando texto da questão do Desafio na table
            questao.Text = des.questao;
            questao.Font.Name = "Segoe UI Light";
            questao.Font.Size = 14;
            questao.Font.Bold = true;
            tc0 = new TableCell();
            tc0.Controls.Add(questao);
            tr3 = new TableRow();
            tr3.Cells.Add(tc0);
            Table1.Rows.Add(tr3);

            DAL.DALAlternativaDesafio dalalterna = new DAL.DALAlternativaDesafio();
            List<Modelo.alternativaDesafio> alterna = new List<Modelo.alternativaDesafio>();
            int aux;
            for (int i = 0; i < dalalterna.calcAlterna(codigo); i++)
            {
                aux = dalalterna.idAlternativa(codigo)[i];
                alterna.Add(dalalterna.Select(aux)[0]);
                if (i == 0) 
                { 
                    Label1.Text = alterna[i].texto;
                    RadioButton1.Visible = true;
                    if (alterna[i].correta == true)
                    {
                        RadioButton1.Font.Name = "Arial";
                    }
                    else RadioButton1.Font.Name = "Segoe UI Light";
                }
                if (i == 1) 
                { 
                    Label2.Text = alterna[i].texto;
                    RadioButton2.Visible = true;
                    if (alterna[i].correta == true)
                    {
                        RadioButton2.Font.Name = "Arial";
                    }
                    else RadioButton2.Font.Name = "Segoe UI Light";
                }
                if (i == 2) 
                { 
                    Label3.Text = alterna[i].texto;
                    RadioButton3.Visible = true;
                    if (alterna[i].correta == true)
                    {
                        RadioButton3.Font.Name = "Arial";
                    }
                    else RadioButton3.Font.Name = "Segoe UI Light";
                }
                if (i == 3) 
                { 
                    Label4.Text = alterna[i].texto;
                    RadioButton4.Visible = true;
                    if (alterna[i].correta == true)
                    {
                        RadioButton4.Font.Name = "Arial";
                    }
                    else RadioButton4.Font.Name = "Segoe UI Light";
                }
                if (i == 4) 
                { 
                    Label5.Text = alterna[i].texto;
                    RadioButton5.Visible = true;
                    if (alterna[i].correta == true)
                    {
                        RadioButton5.Font.Name = "Arial";
                    }
                    else RadioButton5.Font.Name = "Segoe UI Light";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Definindo variáveis que serão utilizadas na table
            TableRow tr1, tr2, tr3;
            TableCell tc0;
            Label titulo = new Label();
            Label questao = new Label();
            Image fotoquestao = new Image();
            Label c = new Label();

            int codigo = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            DAL.DALDesafio daldes = new DAL.DALDesafio();
            Modelo.Desafio des = new Modelo.Desafio();
            des = daldes.Select(codigo)[0];

            //Adicionando título da questão do Desafio na table
            titulo.Text = des.titulo;
            titulo.Font.Name = "Segoe UI Light";
            titulo.Font.Size = 16;
            titulo.Font.Bold = true;
            tc0 = new TableCell();
            tc0.Controls.Add(titulo);
            tr1 = new TableRow();
            tr1.Cells.Add(tc0);
            Table1.Rows.Add(tr1);

            //Adicionando imagem da questão do Desafio na table
            if (des.fotoquestao != null)
            {
                fotoquestao.ImageUrl = "~/HandlerDesafio2.ashx?idDesafio=" + codigo;
            }
            tc0 = new TableCell();
            tc0.Controls.Add(fotoquestao);
            tr2 = new TableRow();
            tr2.Cells.Add(tc0);
            Table1.Rows.Add(tr2);

            //Adicionando texto da questão do Desafio na table
            questao.Text = des.questao;
            questao.Font.Name = "Segoe UI Light";
            questao.Font.Size = 14;
            questao.Font.Bold = true;
            tc0 = new TableCell();
            tc0.Controls.Add(questao);
            tr3 = new TableRow();
            tr3.Cells.Add(tc0);
            Table1.Rows.Add(tr3);
            
            DAL.DALAlternativaDesafio dalalterna = new DAL.DALAlternativaDesafio();
            for (int i = 0; i < dalalterna.calcAlterna(codigo); i++)
            {
                if (i == 0)
                {
                    if ((RadioButton1.Font.Name == "Arial") && (RadioButton1.Checked))
                    {
                        Label6.Text = "&#10003;";
                        break;
                    }
                    else Label6.Text = "<g style='color: red;'>X</g>";
                }
                if (i == 1)
                {
                    if ((RadioButton2.Font.Name == "Arial") && (RadioButton2.Checked))
                    {
                        Label6.Text = "&#10003;";
                        break;
                    }
                    else Label6.Text = "<g style='color: red;'>X</g>";
                }
                if (i == 2)
                {
                    if ((RadioButton3.Font.Name == "Arial") && (RadioButton3.Checked))
                    {
                        Label6.Text = "&#10003;";
                        break;
                    }
                    else Label6.Text = "<g style='color: red;'>X</g>";
                }
                if (i == 3)
                {
                    if ((RadioButton4.Font.Name == "Arial") && (RadioButton4.Checked))
                    {
                        Label6.Text = "&#10003;";
                        break;
                    }
                    else Label6.Text = "<g style='color: red;'>X</g>";
                }
                if (i == 4)
                {
                    if ((RadioButton5.Font.Name == "Arial") && (RadioButton5.Checked))
                    {
                        Label6.Text = "&#10003;";
                        break;
                    }
                    else Label6.Text = "<g style='color: red;'>X</g>";
                }
            }
        }
    }
}