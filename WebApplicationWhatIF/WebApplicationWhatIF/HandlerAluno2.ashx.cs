using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF
{
    /// <summary>
    /// Summary description for HandlerAluno2
    /// </summary>
    public class HandlerAluno2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string nome;
            List<Modelo.Aluno> aListAluno;
            Modelo.Aluno aluno;
            DAL.DALAluno dalaluno;

            nome = context.Request.QueryString["Nome"].ToString();

            // Instancia objeto da camada de negocio
            dalaluno = new DAL.DALAluno();
            // Chama metodo de select passando o pub_id
            aListAluno = dalaluno.Select(nome);

            if (aListAluno.Count > 0)
            {
                aluno = aListAluno[0];
                if (aluno.fotoperfil != null)
                {
                    context.Response.ContentType = aluno.fotoperfil.ToString();
                    context.Response.BinaryWrite(aluno.fotoperfil);
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}