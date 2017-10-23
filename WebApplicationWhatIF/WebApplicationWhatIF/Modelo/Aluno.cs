using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Aluno
    {
        public int idAluno { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public bool escolaPublica { get; set; }
        public Boolean administrador { get; set; }
        public byte[] fotoperfil { get; set; }
        // Construtor
        public Aluno()
        {
            this.nome = "";
            this.senha = ""; 
            this.email = "";
            //this.escolaPublica = false;
            this.administrador = false;
            this.fotoperfil = null;
        }
        public Aluno(string nome, string senha, string email, bool escolaPublica, bool administrador, byte[] fotoperfil)
        {
            this.nome = nome;
            this.senha = senha;
            this.email = email;
            this.escolaPublica = escolaPublica;
            this.administrador = administrador;
            this.fotoperfil = fotoperfil;
        }

    }
}