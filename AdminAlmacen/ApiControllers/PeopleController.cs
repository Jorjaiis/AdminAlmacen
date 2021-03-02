using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web.Http;
using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;

namespace AdminAlmacen.ApiControllers
{
    public class PeopleController : ApiController
    {
        AlmacenDBEntities db = new AlmacenDBEntities();
        /*[ActionName("DeleteBanco")]
        [HttpGet]
        public HttpResponseMessage DeleteBanco(Guid? id_Banco = null)
        {

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var json = "";
            try
            {
                Bancos banco = db.Bancos.FirstOrDefault(x => x.id_Banco == id_Banco);
                if (banco != null)
                {

                    db.Bancos.Remove(banco);
                    db.SaveChanges();
                    json = serializer.Serialize(new
                    {
                        success = true,
                        message = "Eliminado con éxito."
                    });

                }
                else
                {
                    json = serializer.Serialize(new
                    {
                        success = false,
                        message = "Registro no encontrado"
                    });
                }
            }
            catch (Exception e)
            {
                json = serializer.Serialize(new
                {
                    success = false,
                    message = "Error el borrar registro: " + e.Message
                });

            }
            return new HttpResponseMessage()
            {
                Content = new StringContent(json.ToString(), Encoding.UTF8, "application/json")
            };

        }*/

        [ActionName("Helloworld")]
        [HttpGet]
        public ApiReply Helloworld()
        {
            ApiReply reply = new ApiReply();
            reply.result = 400;
            reply.message = "Se ejecuto de manera correcta";
            return reply;
        }

        [ActionName("AddData")]
        [HttpGet]
        public HttpResponseMessage AddData()
        {
            ApiReply reply = new ApiReply();
            reply.result = 400;
            reply.message = "Se ejecuto de manera correcta";
            
            return new HttpResponseMessage()
            {
                Content = new ObjectContent<ApiReply>(reply, new JsonMediaTypeFormatter(), "application/json")
            };
        }
    }
}
