using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF
{
    /// <summary>
    /// Summary description for HandlerDesafio3
    /// </summary>
    public class HandlerDesafio3 : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            int codigo;
            List<Modelo.Desafio> aListDesafio;
            Modelo.Desafio desafio;
            DAL.DALDesafio daldesafio;

            codigo = Convert.ToInt32(context.Session["idDesafio"]);

            // Instancia objeto da camada de negocio
            daldesafio = new DAL.DALDesafio();
            // Chama metodo de select passando o pub_id
            aListDesafio = daldesafio.Select(codigo);

            if (aListDesafio.Count > 0)
            {
                desafio = aListDesafio[0];
                if (desafio.fotoquestao != null)
                {
                    context.Response.ContentType = desafio.fotoquestao.ToString();
                    context.Response.BinaryWrite(desafio.fotoquestao);
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