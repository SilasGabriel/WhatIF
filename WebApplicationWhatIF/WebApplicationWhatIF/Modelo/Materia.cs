using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF.Modelo
{
    public class Materia
    {
        public int idMateria { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public byte[] fotomateria {get; set;}
        public Modulo modulo { get; set; }
        public string idModulo
        {
            get { return modulo.idModulo; }
            set { modulo.idModulo = value; }
        }
        // Construtor
        public Materia()
        {
            this.titulo = "";
            this.descricao = "";
            modulo = new Modulo();
        }
        public Materia(int idMateria, string titulo, string descricao, byte[] fotomateria, string idModulo)
        {
            this.idMateria = idMateria;
            this.titulo = titulo;
            this.descricao = descricao;
            this.fotomateria = fotomateria;
            modulo = new Modulo();
            DAL.DALModulo dalmodulo = new DAL.DALModulo();
            modulo = dalmodulo.Select(Convert.ToInt32(idModulo))[0];
        }
        public Materia(string titulo, string descricao, byte[] fotomateria, string idModulo)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.fotomateria = fotomateria;
            modulo = new Modulo();
            DAL.DALModulo dalmodulo = new DAL.DALModulo();
            modulo = dalmodulo.Select(Convert.ToInt32(idModulo))[0];
        }
    }
}