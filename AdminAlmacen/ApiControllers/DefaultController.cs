using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;

namespace AdminAlmacen.ApiControllers
{
    public class DefaultController : ApiController
    {
        [ActionName("Helloworld")]
        [HttpGet]
        public ApiReply Helloworld()
        {
            ApiReply reply = new ApiReply();
            reply.result = 400;
            reply.message = "Se ejecuto de manera correcta";
            return reply;
        }
    }
}
