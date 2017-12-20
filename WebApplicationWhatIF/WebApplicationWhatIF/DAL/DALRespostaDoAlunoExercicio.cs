using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.DAL
{
    public class DALRespostaDoAlunoExercicio
    {
        string connectionString = "";

        public DALRespostaDoAlunoExercicio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["2017WhatIFConnectionString"].ConnectionString;
        }
        //Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.RespostaDoAlunoExercicio obj)
        {
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO respostaDoAlunoExercicio(idAlternativa, idAluno) VALUES(@idAlternativa, @idAluno)";
            cmd.Parameters.AddWithValue("@idAlternativa", obj.idAlternativaExercicio);
            cmd.Parameters.AddWithValue("@idAluno", obj.idAluno);
            cmd.Connection = sc;

            cmd.ExecuteNonQuery();
            sc.Close();
        }
        //Select pelo idAlternativa
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.RespostaDoAlunoExercicio> Select(int idAlternativa, string nome)
        {
            // Variavel para armazenar um modulo
            Modelo.RespostaDoAlunoExercicio DALresp;
            Modelo.Aluno aluno = new Modelo.Aluno();
            DALAluno dalaluno = new DALAluno();
            aluno = (dalaluno.Select(nome))[0];
            // Cria Lista Vazia
            List<Modelo.RespostaDoAlunoExercicio> DALlistResp = new List<Modelo.RespostaDoAlunoExercicio>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from respostaDoAlunoExercicio Where idAlternativa = @idAlternativa and idAluno = @idAluno";
            cmd.Parameters.AddWithValue("@idAlternativa", idAlternativa);
            cmd.Parameters.AddWithValue("@idAluno", aluno.idAluno);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do modulo do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    DALresp = new Modelo.RespostaDoAlunoExercicio(
                        Convert.ToInt32(dr["idResposta"]),
                        aluno.nome,
                        Convert.ToInt32(dr["idAluno"]));

                    DALlistResp.Add(DALresp);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return DALlistResp;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public int[] SelectAllCertaIdModulo(int idModulo, string nome) {
            int[] cont = new int[2];
            DALMateria dalmat = new DALMateria();
            List<Modelo.Materia> mat = new List<Modelo.Materia>();
            mat = dalmat.SelectAllIdModulo(idModulo);
            foreach (Modelo.Materia materia in mat)
            {
                DALExercicio dalexer = new DALExercicio();
                List<Modelo.Exercicio> exer = new List<Modelo.Exercicio>();
                exer = dalexer.SelectAllIdMateria(materia.idMateria);
                foreach (Modelo.Exercicio exercicio in exer)
                {
                    DALAlternativaExercicio dalalterna = new DALAlternativaExercicio();
                    List<Modelo.alternativaExercicio> alterna = new List<Modelo.alternativaExercicio>();
                    alterna = dalalterna.SelectAll(exercicio.idExercicio);
                    foreach(Modelo.alternativaExercicio alternativa in alterna)
                    {
                        DALRespostaDoAlunoExercicio dalresp = new DALRespostaDoAlunoExercicio();
                        List<Modelo.RespostaDoAlunoExercicio> resp = new List<Modelo.RespostaDoAlunoExercicio>();
                        resp = dalresp.Select(alternativa.idAlternativa, nome);
                        if (resp.Count > 0)
                        {
                            if (alternativa.correta) cont[0]++;
                            else cont[1]++;
                        }
                    }
                }
            }
            return cont;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public int[] SelectAllCertaIdDisciplina(int idDisciplina, string nome)
        {
            int[] cont = new int[2];
            DAL.DALModulo dalmod = new DAL.DALModulo();
            List<Modelo.Modulo> mod = new List<Modelo.Modulo>();
            mod = dalmod.SelectAllIdDisciplina(idDisciplina);
            foreach (Modelo.Modulo modulo in mod)
            { 
                DALMateria dalmat = new DALMateria();
                List<Modelo.Materia> mat = new List<Modelo.Materia>();
                mat = dalmat.SelectAllIdModulo(Convert.ToInt32(modulo.idModulo));
                foreach (Modelo.Materia materia in mat)
                {
                    DALExercicio dalexer = new DALExercicio();
                    List<Modelo.Exercicio> exer = new List<Modelo.Exercicio>();
                    exer = dalexer.SelectAllIdMateria(materia.idMateria);
                    foreach (Modelo.Exercicio exercicio in exer)
                    {
                        DALAlternativaExercicio dalalterna = new DALAlternativaExercicio();
                        List<Modelo.alternativaExercicio> alterna = new List<Modelo.alternativaExercicio>();
                        alterna = dalalterna.SelectAll(exercicio.idExercicio);
                        foreach (Modelo.alternativaExercicio alternativa in alterna)
                        {
                            DALRespostaDoAlunoExercicio dalresp = new DALRespostaDoAlunoExercicio();
                            List<Modelo.RespostaDoAlunoExercicio> resp = new List<Modelo.RespostaDoAlunoExercicio>();
                            resp = dalresp.Select(alternativa.idAlternativa, nome);
                            if (resp.Count > 0)
                            {
                                if (alternativa.correta) cont[0]++;
                                else cont[1]++;
                            }
                        }
                    }
                }
            }
            return cont;
        }
    }
}