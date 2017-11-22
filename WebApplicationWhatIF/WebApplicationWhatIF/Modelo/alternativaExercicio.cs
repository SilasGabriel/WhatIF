using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class alternativaExercicio
    {
        public int idAlternativa { get; set; }
        public string texto { get; set; }
        public bool correta { get; set; }
        public Exercicio exercicio { get; set; }
        public int idExercicio
        {
            get { return exercicio.idExercicio; }
            set { exercicio.idExercicio = value; }
        }
        // Construtor
        public alternativaExercicio()
        {
            this.texto = "";
            this.correta = false;
            exercicio = new Exercicio();
        }
        public alternativaExercicio(int idAlternativa, string texto, bool correta, int idExercicio)
        {
            this.idAlternativa = idAlternativa;
            this.texto = texto;
            this.correta = correta;
            exercicio = new Exercicio();
            DAL.DALExercicio daldexercicio = new DAL.DALExercicio();
            exercicio = daldexercicio.Select(idExercicio)[0];
        }
        public alternativaExercicio(string texto, bool correta, int idExercicio)
        {
            this.texto = texto;
            this.correta = correta;
            exercicio = new Exercicio();
            DAL.DALExercicio daldexercicio = new DAL.DALExercicio();
            exercicio = daldexercicio.Select(idExercicio)[0];
        }
    }
}