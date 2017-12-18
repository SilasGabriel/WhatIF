using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Exercicio
    {
        public int idExercicio { get; set; }
        public string titulo { get; set; }
        public string questao { get; set; }
        public byte[] fotoquestao { get; set; }
        public Materia materia { get; set; }
        public int idMateria
        {
            get { return materia.idMateria; }
            set { materia.idMateria = value; }
        }
        public Dificuldade dificuldade { get; set; }
        public int idDificuldade
        {
            get { return dificuldade.idDificuldade; }
            set { dificuldade.idDificuldade = value; }
        }
        // Construtor
        public Exercicio()
        {
            this.titulo = "";
            this.questao = ""; 
            this.fotoquestao = null;
            materia = new Materia();
            dificuldade = new Dificuldade();
        }
        public Exercicio(string titulo, string questao, int idMateria, int idDificuldade)
        {
            this.titulo = titulo;
            this.questao = questao;
            materia = new Materia();
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            materia = dalmateria.Select(idMateria)[0];
            dificuldade = new Dificuldade();
            DAL.DALDificuldade daldificuldade = new DAL.DALDificuldade();
            dificuldade = daldificuldade.Select(idDificuldade)[0];
        }
        public Exercicio(string titulo, string questao, byte[] fotoquestao, int idMateria, int idDificuldade)
        {
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
            materia = new Materia();
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            materia = dalmateria.Select(idMateria)[0];
            dificuldade = new Dificuldade();
            DAL.DALDificuldade daldificuldade = new DAL.DALDificuldade();
            dificuldade = daldificuldade.Select(idDificuldade)[0];
        }
        public Exercicio(int idExercicio, string titulo, string questao, byte[] fotoquestao, int idMateria, int idDificuldade)
        {
            this.idExercicio = idExercicio;
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
            materia = new Materia();
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            materia = dalmateria.Select(idMateria)[0];
            dificuldade = new Dificuldade();
            DAL.DALDificuldade daldificuldade = new DAL.DALDificuldade();
            dificuldade = daldificuldade.Select(idDificuldade)[0];
        }
    }
}