using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class RespostaDoAlunoDesafio
    {
        public int idRespostaDoAlunoDesafio { get; set; }
        public Aluno aluno { get; set; }
        public int idAluno
        {
            get { return aluno.idAluno; }
            set { aluno.idAluno = value; }
        }

        public alternativaDesafio alternativadesafio { get; set; }
        public int idAlternativaDesafio
        {
            get { return alternativadesafio.idAlternativa; }
            set { alternativadesafio.idAlternativa = value; }
        }

        // Construtor
        public RespostaDoAlunoDesafio()
        {
            aluno = new Aluno();
            alternativadesafio = new alternativaDesafio();
        }
        public RespostaDoAlunoDesafio(string nome, int idAlternativaDesafio)
        {
            aluno = new Aluno();
            DAL.DALAluno dalaluno = new DAL.DALAluno();
            aluno = dalaluno.Select(nome)[0];

            alternativadesafio = new alternativaDesafio();
            DAL.DALAlternativaDesafio dalalternativa = new DAL.DALAlternativaDesafio();
            alternativadesafio = dalalternativa.Select(idAlternativaDesafio)[0];
        }

    }
}