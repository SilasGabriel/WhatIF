using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Modulo
    {
        public int idModulo { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public int idDisciplina { get; set; }
        // Construtor
        public Modulo()
        {
            this.idModulo = 0;
            this.titulo = "";
            this.descricao = "";
            this.idDisciplina = 0;
        }
        public Modulo(int idModulo, string titulo, string descricao, int idDisciplina)
        {
            this.idModulo = idModulo;
            this.titulo = titulo;
            this.descricao = descricao;
            this.idDisciplina = idDisciplina;
        }
    }​
}