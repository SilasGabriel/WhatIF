using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Desafio
    {
        public int idDesafio { get; set; }
        public string titulo { get; set; }
        public string questao { get; set; }
        public byte[] fotoquestao { get; set; }
        public Dificuldade dificuldade { get; set; }
        public int idDificuldade
        {
            get { return dificuldade.idDificuldade; }
            set { dificuldade.idDificuldade = value; }
        }
        // Construtor
        public Desafio()
        {
            this.titulo = "";
            this.questao = ""; 
            this.fotoquestao = null;
        }
        public Desafio(string titulo, string questao, int idDificuldade)
        {
            this.titulo = titulo;
            this.questao = questao;
            dificuldade = new Dificuldade();
            DAL.DALDificuldade daldificuldade = new DAL.DALDificuldade();
            dificuldade = daldificuldade.Select(idDificuldade)[0];
        }
        public Desafio(string titulo, string questao, byte[] fotoquestao, int idDificuldade)
        {
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
            dificuldade = new Dificuldade();
            DAL.DALDificuldade daldificuldade = new DAL.DALDificuldade();
            dificuldade = daldificuldade.Select(idDificuldade)[0];
        }
        public Desafio(int idDesafio, string titulo, string questao, byte[] fotoquestao, int idDificuldade)
        {
            this.idDesafio = idDesafio;
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
            dificuldade = new Dificuldade();
            DAL.DALDificuldade daldificuldade = new DAL.DALDificuldade();
            dificuldade = daldificuldade.Select(idDificuldade)[0];
        }
    }
}