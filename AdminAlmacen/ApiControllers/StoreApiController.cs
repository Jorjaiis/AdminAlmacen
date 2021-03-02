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
    public class StoreApiController : ApiController
    {
        [ActionName("getStore")]
        [HttpGet]
        public ApiReply getStore(int id_user, int id_store){
            ApiReply reply = new ApiReply();
            reply.result = 0;
            try
            {
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    List<StoreViewModel> oStore = (from st in db.store
                                                   from su in db.user_store
                                                   where su.id_user == id_user && st.id == su.id_store && st.id != id_store
                                                   select new StoreViewModel
                                                   {
                                                       id = st.id,
                                                       name = st.name
                                                   }).ToList();
                    //Envia respuesta a usuario
                    reply.result = 0;
                    if (oStore.Count >0)
                    {
                        reply.message = "Tiendas disponibles";
                        reply.data = oStore;
                    }
                    else
                    {
                        reply.message = "Solo cuentas con el almacen actual";
                    }
                }
            }
            catch(Exception ex)
            {
                reply.message = "Ocurrio un error en el servidor";
            }
            return reply;
        }
    }
}
