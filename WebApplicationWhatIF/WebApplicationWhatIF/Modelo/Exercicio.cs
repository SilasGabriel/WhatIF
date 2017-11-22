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
        // Construtor
        public Exercicio()
        {
            this.titulo = "";
            this.questao = ""; 
            this.fotoquestao = null;
            materia = new Materia();
        }
        public Exercicio(string titulo, string questao, int idMateria)
        {
            this.titulo = titulo;
            this.questao = questao;
            materia = new Materia();
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            materia = dalmateria.Select(idMateria)[0];
        }
        public Exercicio(string titulo, string questao, byte[] fotoquestao, int idMateria)
        {
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
            materia = new Materia();
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            materia = dalmateria.Select(idMateria)[0];
        }
        public Exercicio(int idExercicio, string titulo, string questao, byte[] fotoquestao, int idMateria)
        {
            this.idExercicio = idExercicio;
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
            materia = new Materia();
            DAL.DALMateria dalmateria = new DAL.DALMateria();
            materia = dalmateria.Select(idMateria)[0];
        }
    }
}