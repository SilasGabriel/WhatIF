using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Disciplina
    {
        public int idDisciplina { get; set; }
        public string nome { get; set; }
        //Construtor
        public Disciplina()
        {
            this.nome = "";
        }
        public Disciplina(int idDisciplina,string nome)
        {
            this.idDisciplina = idDisciplina;
            this.nome = nome;
        }
    }
}