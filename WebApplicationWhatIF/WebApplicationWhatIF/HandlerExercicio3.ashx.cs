using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF
{
    /// <summary>
    /// Summary description for HandlerExercicio3
    /// </summary>
    public class HandlerExercicio3 : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            int codigo;
            List<Modelo.Exercicio> aListExercicio;
            Modelo.Exercicio exercicio;
            DAL.DALExercicio dalexercicio;

            codigo = Convert.ToInt32(context.Session["idExercicio"]);

            // Instancia objeto da camada de negocio
            dalexercicio = new DAL.DALExercicio();
            // Chama metodo de select passando o pub_id
            aListExercicio = dalexercicio.Select(codigo);

            if (aListExercicio.Count > 0)
            {
                exercicio = aListExercicio[0];
                if (exercicio.fotoquestao != null)
                {
                    context.Response.ContentType = exercicio.fotoquestao.ToString();
                    context.Response.BinaryWrite(exercicio.fotoquestao);
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