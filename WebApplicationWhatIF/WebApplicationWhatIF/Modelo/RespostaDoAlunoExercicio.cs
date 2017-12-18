using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class RespostaDoAlunoExercicio
    {
        public int idRespostaDoAlunoExercicio { get; set; }
        public Aluno aluno { get; set; }
        public int idAluno
        {
            get { return aluno.idAluno; }
            set { aluno.idAluno = value; }
        }

        public alternativaExercicio alternativaexercicio { get; set; }
        public int idAlternativaExercicio{
            get { return alternativaexercicio.idAlternativa; }
            set { alternativaexercicio.idAlternativa = value; }
        }

        // Construtor
        public RespostaDoAlunoExercicio(){
            aluno = new Aluno();
            alternativaexercicio = new alternativaExercicio();
        }
        public RespostaDoAlunoExercicio(string nome, int idAlternativaExercicio){
            aluno = new Aluno();
            DAL.DALAluno dalaluno = new DAL.DALAluno();
            aluno = dalaluno.Select(nome)[0];

            alternativaexercicio = new alternativaExercicio();
            DAL.DALAlternativaExercicio dalalternativa = new DAL.DALAlternativaExercicio();
            alternativaexercicio = dalalternativa.Select(idAlternativaExercicio)[0];
        }
    }
}