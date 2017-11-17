using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormDesafio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.Desafio desafio;

            // Instancia objeto da camada de negocio
            DAL.DALDesafio daldesafio = new DAL.DALDesafio();
            //Para o caso do usuário executar o preview
            if (Session["verif"] == "true") 
            {
                desafio = new Modelo.Desafio(TextBox1.Text, TextBox2.Text, (byte[])Session["ImageBytes"]);
                daldesafio.Insert(desafio);
            }
            else
            {
                Session["ImageBytes"] = FileUpload1.FileBytes;
                Image1.ImageUrl = "~/HandlerDesafio.ashx";
                
                //Caso o usuário não selecione nenhum arquivo, o insert ocorrerá sem a foto da questão
                if (FileUpload1.HasFile == false)
                {
                    // Instancia objeto da camada de negocio
                    desafio = new Modelo.Desafio(TextBox1.Text, TextBox2.Text);
                    daldesafio.InsertSemFoto(desafio);
                }
                else
                {
                    desafio = new Modelo.Desafio(TextBox1.Text, TextBox2.Text, (byte[])Session["ImageBytes"]);
                    daldesafio.Insert(desafio);
                }
            }
                Response.Redirect("~/WebFormIndex.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                Session["ImageBytes"] = FileUpload1.FileBytes;
                Image1.ImageUrl = "~/HandlerDesafio.ashx";
                Session["verif"] = "true";
            }
        }
    }
}