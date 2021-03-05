using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;
using AdminAlmacen.Security;
using Newtonsoft.Json;

namespace AdminAlmacen.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult changeStore(StoreViewModel model)
        {
            var currentUser = (PersonalizedIdentity)User.Identity;
            try
            {
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    var oUser = (from us in db.user where currentUser.id == us.id select us).FirstOrDefault();
                    oUser.id_defaultStore = model.id;
                    db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public string changeStore2(StoreViewModel model)
        {
            ApiReply reply = new ApiReply() { result = 1 };
            var currentUser = (PersonalizedIdentity)User.Identity;
            try
            {
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    var oUser = (from us in db.user where currentUser.id == us.id select us).FirstOrDefault();
                    var oStore = (from st in db.user_store where model.id == st.id_store && oUser.id == st.id_user select st).FirstOrDefault();
                    if (oStore==null)
                    {
                        reply.message = "Error de Sucursal";
                        return JsonConvert.SerializeObject(reply);
                    }
                    oUser.id_defaultStore = model.id;
                    db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                
                reply.result = 0;
                reply.message = "Cambio de Sucursal con exito";
                return JsonConvert.SerializeObject(reply);
            }
            catch (Exception ex)
            {
                reply.message = "Error al Actualizar Almacen";
                return JsonConvert.SerializeObject(reply);
            }


        }
    }
}