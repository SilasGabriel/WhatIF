﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWhatIF
{
    /// <summary>
    /// Summary description for HandlerExercicio
    /// </summary>
    public class HandlerExercicio : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if ((context.Session["ImageBytes1"]) != null)
            {
                byte[] image = (byte[])(context.Session["ImageBytes1"]);
                context.Response.ContentType = "image/JPEG";
                context.Response.BinaryWrite(image);
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