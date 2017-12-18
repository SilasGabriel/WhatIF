using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Dificuldade
    {
        public int idDificuldade { get; set; }
        public string grau { get; set; }
        //Construtor
        public Dificuldade()
        {
            this.grau = "";
        }
        public Dificuldade(int idDificuldade, string grau)
        {
            this.idDificuldade = idDificuldade;
            this.grau = grau;
        }
    }
}