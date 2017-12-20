using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWhatIF
{
    public partial class WebFormExercicioUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!((Session["Nome"] != null) && (Session["Senha"] != null)))
            {
                Response.Redirect("~/WebFormAutenticar.aspx");
            }
            List<Modelo.Exercicio> exercicios = new List<Modelo.Exercicio>();
            DAL.DALExercicio dalexercicio = new DAL.DALExercicio();
            exercicios = dalexercicio.SelectAllIdMateria(Convert.ToInt32(Request.QueryString["idMateria"]));
            for(int i = 0; i < exercicios.Count; i++){
                if (i == 0) {
                    //Definindo variáveis que serão utilizadas na table
                    TableRow tr1, tr2, tr3;
                    TableCell tc0, tc1;
                    Label titulo = new Label();
                    Label dificuldade = new Label();
                    Label questao = new Label();
                    Image fotoquestao = new Image();

                    DAL.DALExercicio dalexer = new DAL.DALExercicio();
                    Modelo.Exercicio exer = new Modelo.Exercicio();
                    exer = dalexer.Select(exercicios[i].idExercicio)[0];

                    //Adicionando título da questão do Exercício na table
                    titulo.Text = exer.titulo;
                    titulo.Font.Name = "Segoe UI Light";
                    titulo.Font.Size = 16;
                    titulo.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(titulo);

                    DAL.DALDificuldade daldif = new DAL.DALDificuldade();
                    Modelo.Dificuldade dif = new Modelo.Dificuldade();
                    dif = daldif.Select(exercicios[i].idDificuldade)[0];

                    dificuldade.Text = "Nível: " + dif.grau;
                    dificuldade.Font.Name = "Segoe UI Light";
                    dificuldade.Font.Size = 14;
                    dificuldade.Font.Bold = true;
                    tc1 = new TableCell();
                    tc1.Controls.Add(dificuldade);
                    
                    tr1 = new TableRow();
                    tr1.Cells.Add(tc0);
                    tr1.Cells.Add(tc1);
                    Table1.Rows.Add(tr1);

                    //Adicionando imagem da questão do Exercício na table
                    if (exer.fotoquestao != null)
                    {
                        fotoquestao.ImageUrl = "~/HandlerExercicio2.ashx?idExercicio=" + exer.idExercicio;
                    }
                    tc0 = new TableCell();
                    tc0.Controls.Add(fotoquestao);
                    tr2 = new TableRow();
                    tr2.Cells.Add(tc0);
                    Table1.Rows.Add(tr2);

                    //Adicionando texto da questão do Exercício na table
                    questao.Text = exer.questao;
                    questao.Font.Name = "Segoe UI Light";
                    questao.Font.Size = 14;
                    questao.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(questao);
                    tr3 = new TableRow();
                    tr3.Cells.Add(tc0);
                    Table1.Rows.Add(tr3);

                    DAL.DALAlternativaExercicio dalalterna = new DAL.DALAlternativaExercicio();
                    List<Modelo.alternativaExercicio> alterna = new List<Modelo.alternativaExercicio>();
                    int aux;
                    for (int j = 0; j < dalalterna.calcAlterna(exer.idExercicio); j++)
                    {
                        aux = dalalterna.idAlternativa(exer.idExercicio)[j];
                        alterna.Add(dalalterna.Select(aux)[0]);
                        if (j == 0)
                        {
                            Label1.Text = alterna[j].texto;
                            RadioButton1.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton1.Font.Name = "Arial";
                            }
                            else RadioButton1.Font.Name = "Segoe UI Light";
                        }
                        if (j == 1)
                        {
                            Label2.Text = alterna[j].texto;
                            RadioButton2.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton2.Font.Name = "Arial";
                            }
                            else RadioButton2.Font.Name = "Segoe UI Light";
                        }
                        if (j == 2)
                        {
                            Label3.Text = alterna[j].texto;
                            RadioButton3.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton3.Font.Name = "Arial";
                            }
                            else RadioButton3.Font.Name = "Segoe UI Light";
                        }
                        if (j == 3)
                        {
                            Label4.Text = alterna[j].texto;
                            RadioButton4.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton4.Font.Name = "Arial";
                            }
                            else RadioButton4.Font.Name = "Segoe UI Light";
                        }
                        if (j == 4)
                        {
                            Label5.Text = alterna[j].texto;
                            RadioButton5.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton5.Font.Name = "Arial";
                            }
                            else RadioButton5.Font.Name = "Segoe UI Light";
                        }
                    }
                }
                if (i == 1)
                {
                    //Definindo variáveis que serão utilizadas na table
                    TableRow tr1, tr2, tr3;
                    TableCell tc0, tc1;
                    Label titulo = new Label();
                    Label dificuldade = new Label();
                    Label questao = new Label();
                    Image fotoquestao = new Image();

                    DAL.DALExercicio dalexer = new DAL.DALExercicio();
                    Modelo.Exercicio exer = new Modelo.Exercicio();
                    exer = dalexer.Select(exercicios[i].idExercicio)[0];

                    //Adicionando título da questão do Exercício na table
                    titulo.Text = exer.titulo;
                    titulo.Font.Name = "Segoe UI Light";
                    titulo.Font.Size = 16;
                    titulo.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(titulo);

                    DAL.DALDificuldade daldif = new DAL.DALDificuldade();
                    Modelo.Dificuldade dif = new Modelo.Dificuldade();
                    dif = daldif.Select(exercicios[i].idDificuldade)[0];

                    dificuldade.Text = "Nível: " + dif.grau;
                    dificuldade.Font.Name = "Segoe UI Light";
                    dificuldade.Font.Size = 14;
                    dificuldade.Font.Bold = true;
                    tc1 = new TableCell();
                    tc1.Controls.Add(dificuldade);

                    tr1 = new TableRow();
                    tr1.Cells.Add(tc0);
                    tr1.Cells.Add(tc1);
                    Table2.Rows.Add(tr1);

                    //Adicionando imagem da questão do Exercício na table
                    if (exer.fotoquestao != null)
                    {
                        fotoquestao.ImageUrl = "~/HandlerExercicio2.ashx?idExercicio=" + exer.idExercicio;
                    }
                    tc0 = new TableCell();
                    tc0.Controls.Add(fotoquestao);
                    tr2 = new TableRow();
                    tr2.Cells.Add(tc0);
                    Table2.Rows.Add(tr2);

                    //Adicionando texto da questão do Exercício na table
                    questao.Text = exer.questao;
                    questao.Font.Name = "Segoe UI Light";
                    questao.Font.Size = 14;
                    questao.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(questao);
                    tr3 = new TableRow();
                    tr3.Cells.Add(tc0);
                    Table2.Rows.Add(tr3);

                    DAL.DALAlternativaExercicio dalalterna = new DAL.DALAlternativaExercicio();
                    List<Modelo.alternativaExercicio> alterna = new List<Modelo.alternativaExercicio>();
                    int aux;
                    for (int j = 0; j < dalalterna.calcAlterna(exer.idExercicio); j++)
                    {
                        aux = dalalterna.idAlternativa(exer.idExercicio)[j];
                        alterna.Add(dalalterna.Select(aux)[0]);
                        if (j == 0)
                        {
                            Label6.Text = alterna[j].texto;
                            RadioButton6.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton6.Font.Name = "Arial";
                            }
                            else RadioButton6.Font.Name = "Segoe UI Light";
                        }
                        if (j == 1)
                        {
                            Label7.Text = alterna[j].texto;
                            RadioButton7.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton7.Font.Name = "Arial";
                            }
                            else RadioButton7.Font.Name = "Segoe UI Light";
                        }
                        if (j == 2)
                        {
                            Label8.Text = alterna[j].texto;
                            RadioButton8.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton8.Font.Name = "Arial";
                            }
                            else RadioButton8.Font.Name = "Segoe UI Light";
                        }
                        if (j == 3)
                        {
                            Label9.Text = alterna[j].texto;
                            RadioButton9.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton9.Font.Name = "Arial";
                            }
                            else RadioButton9.Font.Name = "Segoe UI Light";
                        }
                        if (j == 4)
                        {
                            Label10.Text = alterna[j].texto;
                            RadioButton10.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton10.Font.Name = "Arial";
                            }
                            else RadioButton10.Font.Name = "Segoe UI Light";
                        }
                    }
                }
                if (i == 2)
                {
                    //Definindo variáveis que serão utilizadas na table
                    TableRow tr1, tr2, tr3;
                    TableCell tc0, tc1;
                    Label titulo = new Label();
                    Label dificuldade = new Label();
                    Label questao = new Label();
                    Image fotoquestao = new Image();

                    DAL.DALExercicio dalexer = new DAL.DALExercicio();
                    Modelo.Exercicio exer = new Modelo.Exercicio();
                    exer = dalexer.Select(exercicios[i].idExercicio)[0];

                    //Adicionando título da questão do Exercício na table
                    titulo.Text = exer.titulo;
                    titulo.Font.Name = "Segoe UI Light";
                    titulo.Font.Size = 16;
                    titulo.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(titulo);

                    DAL.DALDificuldade daldif = new DAL.DALDificuldade();
                    Modelo.Dificuldade dif = new Modelo.Dificuldade();
                    dif = daldif.Select(exercicios[i].idDificuldade)[0];

                    dificuldade.Text = "Nível: " + dif.grau;
                    dificuldade.Font.Name = "Segoe UI Light";
                    dificuldade.Font.Size = 14;
                    dificuldade.Font.Bold = true;
                    tc1 = new TableCell();
                    tc1.Controls.Add(dificuldade);
                    
                    tr1 = new TableRow();
                    tr1.Cells.Add(tc0);
                    tr1.Cells.Add(tc1);
                    Table3.Rows.Add(tr1);

                    //Adicionando imagem da questão do Exercício na table
                    if (exer.fotoquestao != null)
                    {
                        fotoquestao.ImageUrl = "~/HandlerExercicio2.ashx?idExercicio=" + exer.idExercicio;
                    }
                    tc0 = new TableCell();
                    tc0.Controls.Add(fotoquestao);
                    tr2 = new TableRow();
                    tr2.Cells.Add(tc0);
                    Table3.Rows.Add(tr2);

                    //Adicionando texto da questão do Exercício na table
                    questao.Text = exer.questao;
                    questao.Font.Name = "Segoe UI Light";
                    questao.Font.Size = 14;
                    questao.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(questao);
                    tr3 = new TableRow();
                    tr3.Cells.Add(tc0);
                    Table3.Rows.Add(tr3);

                    DAL.DALAlternativaExercicio dalalterna = new DAL.DALAlternativaExercicio();
                    List<Modelo.alternativaExercicio> alterna = new List<Modelo.alternativaExercicio>();
                    int aux;
                    for (int j = 0; j < dalalterna.calcAlterna(exer.idExercicio); j++)
                    {
                        aux = dalalterna.idAlternativa(exer.idExercicio)[j];
                        alterna.Add(dalalterna.Select(aux)[0]);
                        if (j == 0)
                        {
                            Label11.Text = alterna[j].texto;
                            RadioButton11.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton11.Font.Name = "Arial";
                            }
                            else RadioButton11.Font.Name = "Segoe UI Light";
                        }
                        if (j == 1)
                        {
                            Label12.Text = alterna[j].texto;
                            RadioButton12.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton12.Font.Name = "Arial";
                            }
                            else RadioButton12.Font.Name = "Segoe UI Light";
                        }
                        if (j == 2)
                        {
                            Label13.Text = alterna[j].texto;
                            RadioButton13.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton13.Font.Name = "Arial";
                            }
                            else RadioButton13.Font.Name = "Segoe UI Light";
                        }
                        if (j == 3)
                        {
                            Label14.Text = alterna[j].texto;
                            RadioButton14.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton14.Font.Name = "Arial";
                            }
                            else RadioButton14.Font.Name = "Segoe UI Light";
                        }
                        if (j == 4)
                        {
                            Label15.Text = alterna[j].texto;
                            RadioButton15.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton15.Font.Name = "Arial";
                            }
                            else RadioButton15.Font.Name = "Segoe UI Light";
                        }
                    }
                }
                if (i == 3)
                {
                    //Definindo variáveis que serão utilizadas na table
                    TableRow tr1, tr2, tr3;
                    TableCell tc0, tc1;
                    Label titulo = new Label();
                    Label dificuldade = new Label();
                    Label questao = new Label();
                    Image fotoquestao = new Image();

                    DAL.DALExercicio dalexer = new DAL.DALExercicio();
                    Modelo.Exercicio exer = new Modelo.Exercicio();
                    exer = dalexer.Select(exercicios[i].idExercicio)[0];

                    //Adicionando título da questão do Exercício na table
                    titulo.Text = exer.titulo;
                    titulo.Font.Name = "Segoe UI Light";
                    titulo.Font.Size = 16;
                    titulo.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(titulo);

                    DAL.DALDificuldade daldif = new DAL.DALDificuldade();
                    Modelo.Dificuldade dif = new Modelo.Dificuldade();
                    dif = daldif.Select(exercicios[i].idDificuldade)[0];

                    dificuldade.Text = "Nível: " + dif.grau;
                    dificuldade.Font.Name = "Segoe UI Light";
                    dificuldade.Font.Size = 14;
                    dificuldade.Font.Bold = true;
                    tc1 = new TableCell();
                    tc1.Controls.Add(dificuldade);

                    tr1 = new TableRow();
                    tr1.Cells.Add(tc0);
                    tr1.Cells.Add(tc1);
                    Table4.Rows.Add(tr1);

                    //Adicionando imagem da questão do Exercício na table
                    if (exer.fotoquestao != null)
                    {
                        fotoquestao.ImageUrl = "~/HandlerExercicio2.ashx?idExercicio=" + exer.idExercicio;
                    }
                    tc0 = new TableCell();
                    tc0.Controls.Add(fotoquestao);
                    tr2 = new TableRow();
                    tr2.Cells.Add(tc0);
                    Table4.Rows.Add(tr2);

                    //Adicionando texto da questão do Exercício na table
                    questao.Text = exer.questao;
                    questao.Font.Name = "Segoe UI Light";
                    questao.Font.Size = 14;
                    questao.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(questao);
                    tr3 = new TableRow();
                    tr3.Cells.Add(tc0);
                    Table4.Rows.Add(tr3);

                    DAL.DALAlternativaExercicio dalalterna = new DAL.DALAlternativaExercicio();
                    List<Modelo.alternativaExercicio> alterna = new List<Modelo.alternativaExercicio>();
                    int aux;
                    for (int j = 0; j < dalalterna.calcAlterna(exer.idExercicio); j++)
                    {
                        aux = dalalterna.idAlternativa(exer.idExercicio)[j];
                        alterna.Add(dalalterna.Select(aux)[0]);
                        if (j == 0)
                        {
                            Label16.Text = alterna[j].texto;
                            RadioButton16.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton16.Font.Name = "Arial";
                            }
                            else RadioButton16.Font.Name = "Segoe UI Light";
                        }
                        if (j == 1)
                        {
                            Label17.Text = alterna[j].texto;
                            RadioButton17.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton17.Font.Name = "Arial";
                            }
                            else RadioButton17.Font.Name = "Segoe UI Light";
                        }
                        if (j == 2)
                        {
                            Label18.Text = alterna[j].texto;
                            RadioButton18.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton18.Font.Name = "Arial";
                            }
                            else RadioButton18.Font.Name = "Segoe UI Light";
                        }
                        if (j == 3)
                        {
                            Label19.Text = alterna[j].texto;
                            RadioButton19.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton19.Font.Name = "Arial";
                            }
                            else RadioButton19.Font.Name = "Segoe UI Light";
                        }
                        if (j == 4)
                        {
                            Label20.Text = alterna[j].texto;
                            RadioButton20.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton20.Font.Name = "Arial";
                            }
                            else RadioButton20.Font.Name = "Segoe UI Light";
                        }
                    }
                }
                if (i == 4)
                {
                    //Definindo variáveis que serão utilizadas na table
                    TableRow tr1, tr2, tr3;
                    TableCell tc0, tc1;
                    Label titulo = new Label();
                    Label dificuldade = new Label();
                    Label questao = new Label();
                    Image fotoquestao = new Image();

                    DAL.DALExercicio dalexer = new DAL.DALExercicio();
                    Modelo.Exercicio exer = new Modelo.Exercicio();
                    exer = dalexer.Select(exercicios[i].idExercicio)[0];

                    //Adicionando título da questão do Exercício na table
                    titulo.Text = exer.titulo;
                    titulo.Font.Name = "Segoe UI Light";
                    titulo.Font.Size = 16;
                    titulo.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(titulo);

                    DAL.DALDificuldade daldif = new DAL.DALDificuldade();
                    Modelo.Dificuldade dif = new Modelo.Dificuldade();
                    dif = daldif.Select(exercicios[i].idDificuldade)[0];

                    dificuldade.Text = "Nível: " + dif.grau;
                    dificuldade.Font.Name = "Segoe UI Light";
                    dificuldade.Font.Size = 14;
                    dificuldade.Font.Bold = true;
                    tc1 = new TableCell();
                    tc1.Controls.Add(dificuldade);

                    tr1 = new TableRow();
                    tr1.Cells.Add(tc0);
                    tr1.Cells.Add(tc1);
                    Table5.Rows.Add(tr1);

                    //Adicionando imagem da questão do Exercício na table
                    if (exer.fotoquestao != null)
                    {
                        fotoquestao.ImageUrl = "~/HandlerExercicio2.ashx?idExercicio=" + exer.idExercicio;
                    }
                    tc0 = new TableCell();
                    tc0.Controls.Add(fotoquestao);
                    tr2 = new TableRow();
                    tr2.Cells.Add(tc0);
                    Table5.Rows.Add(tr2);

                    //Adicionando texto da questão do Exercício na table
                    questao.Text = exer.questao;
                    questao.Font.Name = "Segoe UI Light";
                    questao.Font.Size = 14;
                    questao.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(questao);
                    tr3 = new TableRow();
                    tr3.Cells.Add(tc0);
                    Table5.Rows.Add(tr3);

                    DAL.DALAlternativaExercicio dalalterna = new DAL.DALAlternativaExercicio();
                    List<Modelo.alternativaExercicio> alterna = new List<Modelo.alternativaExercicio>();
                    int aux;
                    for (int j = 0; j < dalalterna.calcAlterna(exer.idExercicio); j++)
                    {
                        aux = dalalterna.idAlternativa(exer.idExercicio)[j];
                        alterna.Add(dalalterna.Select(aux)[0]);
                        if (j == 0)
                        {
                            Label21.Text = alterna[j].texto;
                            RadioButton21.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton21.Font.Name = "Arial";
                            }
                            else RadioButton21.Font.Name = "Segoe UI Light";
                        }
                        if (j == 1)
                        {
                            Label22.Text = alterna[j].texto;
                            RadioButton22.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton22.Font.Name = "Arial";
                            }
                            else RadioButton22.Font.Name = "Segoe UI Light";
                        }
                        if (j == 2)
                        {
                            Label23.Text = alterna[j].texto;
                            RadioButton23.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton23.Font.Name = "Arial";
                            }
                            else RadioButton23.Font.Name = "Segoe UI Light";
                        }
                        if (j == 3)
                        {
                            Label24.Text = alterna[j].texto;
                            RadioButton24.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton24.Font.Name = "Arial";
                            }
                            else RadioButton24.Font.Name = "Segoe UI Light";
                        }
                        if (j == 4)
                        {
                            Label25.Text = alterna[j].texto;
                            RadioButton25.Visible = true;
                            if (alterna[j].correta == true)
                            {
                                RadioButton25.Font.Name = "Arial";
                            }
                            else RadioButton25.Font.Name = "Segoe UI Light";
                        }
                    }
                }
            }
            DAL.DALMateria mat = new DAL.DALMateria();
            Modelo.Materia mate = new Modelo.Materia();
            mate = mat.Select(Convert.ToInt32(Request.QueryString["idMateria"]))[0];
            HyperLink3.Text = mate.titulo;
            HyperLink3.NavigateUrl = "~/WebFormMateriaUsuario.aspx?idMateria=" + mate.idModulo;

            DAL.DALModulo mod = new DAL.DALModulo();
            Modelo.Modulo modulo = new Modelo.Modulo();
            modulo = mod.Select(Convert.ToInt32(mate.idModulo))[0];
            HyperLink2.Text = modulo.titulo;
            HyperLink2.NavigateUrl = "~/WebFormMateria.aspx?idModulo=" + mate.idModulo;

            DAL.DALDisciplina disc = new DAL.DALDisciplina();
            Modelo.Disciplina disciplina = new Modelo.Disciplina();
            disciplina = disc.Select(modulo.idDisciplina)[0];
            HyperLink1.Text = disciplina.nome;
            HyperLink1.NavigateUrl = "~/WebFormDisciplina.aspx?idDisciplina=" + disciplina.idDisciplina;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Modelo.Exercicio> exercicios = new List<Modelo.Exercicio>();
            DAL.DALExercicio dalexercicio = new DAL.DALExercicio();
            exercicios = dalexercicio.SelectAllIdMateria(Convert.ToInt32(Request.QueryString["idMateria"]));
            
            DAL.DALAlternativaExercicio dalalterna = new DAL.DALAlternativaExercicio();
            List<Modelo.alternativaExercicio> alterna;

            DAL.DALRespostaDoAlunoExercicio dalresposta = new DAL.DALRespostaDoAlunoExercicio();
            Modelo.RespostaDoAlunoExercicio resposta;
            string nome = Session["Nome"].ToString();
            for (int j = 0; j < exercicios.Count; j++)
            {
                if (j == 0)
                {
                    alterna = new List<Modelo.alternativaExercicio>();
                    alterna = dalalterna.SelectAll(exercicios[j].idExercicio);
                    for (int i = 0; i < dalalterna.calcAlterna(exercicios[j].idExercicio); i++)
                    {
                        if (i == 0)
                        {
                            if ((RadioButton1.Font.Name == "Arial") && (RadioButton1.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton2.Checked) && (RadioButton2.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton3.Checked) && (RadioButton3.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton4.Checked) && (RadioButton4.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton5.Checked) && (RadioButton5.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 1)
                        {
                            if ((RadioButton2.Font.Name == "Arial") && (RadioButton2.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton1.Checked) && (RadioButton1.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton3.Checked) && (RadioButton3.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton4.Checked) && (RadioButton4.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton5.Checked) && (RadioButton5.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 2)
                        {
                            if ((RadioButton3.Font.Name == "Arial") && (RadioButton3.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton1.Checked) && (RadioButton1.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton2.Checked) && (RadioButton2.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton4.Checked) && (RadioButton4.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton5.Checked) && (RadioButton5.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 3)
                        {
                            if ((RadioButton4.Font.Name == "Arial") && (RadioButton4.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton1.Checked) && (RadioButton1.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton2.Checked) && (RadioButton2.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton3.Checked) && (RadioButton3.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton5.Checked) && (RadioButton5.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 4)
                        {
                            if ((RadioButton5.Font.Name == "Arial") && (RadioButton5.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton1.Checked) && (RadioButton1.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton2.Checked) && (RadioButton2.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton3.Checked) && (RadioButton3.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton4.Checked) && (RadioButton4.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                    }
                }
                
                if (j == 1) {
                    alterna = new List<Modelo.alternativaExercicio>();
                    alterna = dalalterna.SelectAll(exercicios[j].idExercicio);
                    for (int i = 0; i < dalalterna.calcAlterna(exercicios[j].idExercicio); i++)
                    {
                        if (i == 0)
                        {
                            if ((RadioButton6.Font.Name == "Arial") && (RadioButton6.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton7.Checked) && (RadioButton7.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton8.Checked) && (RadioButton8.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton9.Checked) && (RadioButton9.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton10.Checked) && (RadioButton10.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 1)
                        {
                            if ((RadioButton7.Font.Name == "Arial") && (RadioButton7.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton6.Checked) && (RadioButton6.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton8.Checked) && (RadioButton8.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton9.Checked) && (RadioButton9.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton10.Checked) && (RadioButton10.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label26.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 2)
                        {
                            if ((RadioButton8.Font.Name == "Arial") && (RadioButton8.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton6.Checked) && (RadioButton6.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton7.Checked) && (RadioButton7.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton9.Checked) && (RadioButton9.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton10.Checked) && (RadioButton10.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 3)
                        {
                            if ((RadioButton9.Font.Name == "Arial") && (RadioButton9.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton6.Checked) && (RadioButton6.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton7.Checked) && (RadioButton7.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton8.Checked) && (RadioButton8.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton10.Checked) && (RadioButton10.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 4)
                        {
                            if ((RadioButton10.Font.Name == "Arial") && (RadioButton10.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton6.Checked) && (RadioButton6.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton7.Checked) && (RadioButton7.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton8.Checked) && (RadioButton8.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton9.Checked) && (RadioButton9.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label27.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                    }
                }

                if (j == 2) {
                    alterna = new List<Modelo.alternativaExercicio>();
                    alterna = dalalterna.SelectAll(exercicios[j].idExercicio);
                    for (int i = 0; i < dalalterna.calcAlterna(exercicios[j].idExercicio); i++)
                    {
                        if (i == 0)
                        {
                            if ((RadioButton11.Font.Name == "Arial") && (RadioButton11.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton12.Checked) && (RadioButton12.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton13.Checked) && (RadioButton13.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton14.Checked) && (RadioButton14.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton15.Checked) && (RadioButton15.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 1)
                        {
                            if ((RadioButton12.Font.Name == "Arial") && (RadioButton12.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton11.Checked) && (RadioButton11.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton13.Checked) && (RadioButton13.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton14.Checked) && (RadioButton14.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton15.Checked) && (RadioButton15.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 2)
                        {
                            if ((RadioButton13.Font.Name == "Arial") && (RadioButton13.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton11.Checked) && (RadioButton11.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton12.Checked) && (RadioButton12.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton14.Checked) && (RadioButton14.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton15.Checked) && (RadioButton15.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 3)
                        {
                            if ((RadioButton14.Font.Name == "Arial") && (RadioButton14.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton11.Checked) && (RadioButton11.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton12.Checked) && (RadioButton12.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton13.Checked) && (RadioButton13.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton15.Checked) && (RadioButton15.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 4)
                        {
                            if ((RadioButton15.Font.Name == "Arial") && (RadioButton15.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton11.Checked) && (RadioButton11.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton12.Checked) && (RadioButton12.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton13.Checked) && (RadioButton13.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton14.Checked) && (RadioButton14.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label28.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                    }
                }

                if (j == 3) {
                    alterna = new List<Modelo.alternativaExercicio>();
                    alterna = dalalterna.SelectAll(exercicios[j].idExercicio);
                    for (int i = 0; i < dalalterna.calcAlterna(exercicios[j].idExercicio); i++)
                    {
                        if (i == 0)
                        {
                            if ((RadioButton16.Font.Name == "Arial") && (RadioButton16.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton17.Checked) && (RadioButton17.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton18.Checked) && (RadioButton18.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton19.Checked) && (RadioButton19.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton20.Checked) && (RadioButton20.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 1)
                        {
                            if ((RadioButton17.Font.Name == "Arial") && (RadioButton17.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton16.Checked) && (RadioButton16.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton18.Checked) && (RadioButton18.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton19.Checked) && (RadioButton19.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton20.Checked) && (RadioButton20.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 2)
                        {
                            if ((RadioButton18.Font.Name == "Arial") && (RadioButton18.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton16.Checked) && (RadioButton16.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton17.Checked) && (RadioButton17.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton19.Checked) && (RadioButton19.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton20.Checked) && (RadioButton20.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 3)
                        {
                            if ((RadioButton19.Font.Name == "Arial") && (RadioButton19.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton16.Checked) && (RadioButton16.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton17.Checked) && (RadioButton17.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton18.Checked) && (RadioButton18.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton20.Checked) && (RadioButton20.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 4)
                        {
                            if ((RadioButton20.Font.Name == "Arial") && (RadioButton20.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton16.Checked) && (RadioButton16.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton17.Checked) && (RadioButton17.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton18.Checked) && (RadioButton18.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton19.Checked) && (RadioButton19.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label29.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                    }
                }

                if (j == 4) 
                {
                    alterna = new List<Modelo.alternativaExercicio>();
                    alterna = dalalterna.SelectAll(exercicios[j].idExercicio);
                    for (int i = 0; i < dalalterna.calcAlterna(exercicios[j].idExercicio); i++)
                    {
                        if (i == 0)
                        {
                            if ((RadioButton21.Font.Name == "Arial") && (RadioButton21.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton22.Checked) && (RadioButton22.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton23.Checked) && (RadioButton23.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton24.Checked) && (RadioButton24.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton25.Checked) && (RadioButton25.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 1)
                        {
                            if ((RadioButton22.Font.Name == "Arial") && (RadioButton22.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton21.Checked) && (RadioButton21.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton23.Checked) && (RadioButton23.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton24.Checked) && (RadioButton24.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton25.Checked) && (RadioButton25.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 2)
                        {
                            if ((RadioButton23.Font.Name == "Arial") && (RadioButton23.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton21.Checked) && (RadioButton21.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton22.Checked) && (RadioButton22.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton24.Checked) && (RadioButton24.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton25.Checked) && (RadioButton25.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 3)
                        {
                            if ((RadioButton24.Font.Name == "Arial") && (RadioButton24.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton21.Checked) && (RadioButton21.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton22.Checked) && (RadioButton22.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton23.Checked) && (RadioButton23.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton25.Checked) && (RadioButton25.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[4].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                        if (i == 4)
                        {
                            if ((RadioButton25.Font.Name == "Arial") && (RadioButton25.Checked))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[i].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "&#10003;";
                                break;
                            }
                            else if ((RadioButton21.Checked) && (RadioButton21.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[0].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton22.Checked) && (RadioButton22.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[1].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton23.Checked) && (RadioButton23.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[2].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                            else if ((RadioButton24.Checked) && (RadioButton24.Font.Name != "Arial"))
                            {
                                resposta = new Modelo.RespostaDoAlunoExercicio(nome, alterna[3].idAlternativa);
                                dalresposta.Insert(resposta);
                                Label30.Text = "<g style='color: red;'>X</g>";
                                break;
                            }
                        }
                    }
                }
            }
        }

    
    }
}