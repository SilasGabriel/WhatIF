using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class alternativaDesafio
    {
        public int idAlternativa { get; set; }
        public string texto { get; set; }
        public bool correta { get; set; }
        public Desafio desafio { get; set; }
        public int idDesafio
        {
            get { return desafio.idDesafio; }
            set { desafio.idDesafio = value; }
        }
        // Construtor
        public alternativaDesafio()
        {
            this.texto = "";
            this.correta = false;
            desafio = new Desafio();
        }
        public alternativaDesafio(int idAlternativa, string texto, bool correta, int idDesafio)
        {
            this.idAlternativa = idAlternativa;
            this.texto = texto;
            this.correta = correta;
            desafio = new Desafio();
            DAL.DALDesafio daldesafio = new DAL.DALDesafio();
            desafio = daldesafio.Select(idDesafio)[0];
        }
        public alternativaDesafio(string texto, bool correta, int idDesafio)
        {
            this.texto = texto;
            this.correta = correta;
            desafio = new Desafio();
            DAL.DALDesafio daldesafio = new DAL.DALDesafio();
            desafio = daldesafio.Select(idDesafio)[0];
        }
    }
}