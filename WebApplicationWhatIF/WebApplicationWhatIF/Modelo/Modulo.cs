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
        public int idDisciplina
        {
            get { return disciplina.idDisciplina; }
            set { disciplina.idDisciplina = value; }
        }
        // Construtor
        public Modulo()
        {
            this.idModulo = "";
            this.titulo = "";
            this.descricao = "";
            disciplina = new Disciplina();
        }
        public Modulo(string idModulo, string titulo, string descricao, int idDisciplina)
        {
            this.idModulo = idModulo;
            this.titulo = titulo;
            this.descricao = descricao;
            disciplina = new Disciplina();
            DAL.DALDisciplina daldis = new DAL.DALDisciplina();
            disciplina = daldis.Select(idDisciplina)[0];
        }
    }​
}