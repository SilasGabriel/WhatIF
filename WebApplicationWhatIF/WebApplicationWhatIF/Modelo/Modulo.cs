using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Modulo
    {
        public string idModulo { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public Disciplina disciplina { get; set; }
        // Construtor
        public Modulo()
        {
            this.idModulo = "";
            this.titulo = "";
            this.descricao = "";
            this.disciplina = new Disciplina();
        }
        public Modulo(string idModulo, string titulo, string descricao, Disciplina disciplina)
        {
            this.idModulo = idModulo;
            this.titulo = titulo;
            this.descricao = descricao;
            this.disciplina = disciplina;
        }
    }​
}