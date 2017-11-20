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
        // Construtor
        public Desafio()
        {
            this.titulo = "";
            this.questao = ""; 
            this.fotoquestao = null;
        }
        public Desafio(string titulo, string questao)
        {
            this.titulo = titulo;
            this.questao = questao;
        }
        public Desafio(string titulo, string questao, byte[] fotoquestao)
        {
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
        }
        public Desafio(int idDesafio, string titulo, string questao, byte[] fotoquestao)
        {
            this.idDesafio = idDesafio;
            this.titulo = titulo;
            this.questao = questao;
            this.fotoquestao = fotoquestao;
        }
    }
}