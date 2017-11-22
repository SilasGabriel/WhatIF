using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF
{
    /// <summary>
    /// Summary description for HandlerMateria2
    /// </summary>
    public class HandlerMateria2 : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            int idMateria;
            List<Modelo.Materia> aListMateria;
            Modelo.Materia materia;
            DAL.DALMateria dalmateria;

            idMateria = Convert.ToInt32(context.Session["idMateria"]);
            
            // Instancia objeto da camada de negocio
            dalmateria = new DAL.DALMateria();
            // Chama metodo de select passando o pub_id
            aListMateria = dalmateria.Select(idMateria);

            if (aListMateria.Count > 0)
            {
                materia = aListMateria[0];
                if (materia.fotomateria != null)
                {
                    context.Response.ContentType = materia.fotomateria.ToString();
                    context.Response.BinaryWrite(materia.fotomateria);
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