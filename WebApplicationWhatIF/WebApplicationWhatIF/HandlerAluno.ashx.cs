﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF
{
    /// <summary>
    /// Summary description for HandlerAluno
    /// </summary>
    public class HandlerAluno : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            string nome;
            List<Modelo.Aluno> aListAluno;
            Modelo.Aluno aluno;
            DAL.DALAluno dalaluno;

            nome = context.Session["Nome"].ToString();

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