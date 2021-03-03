using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;
using AdminAlmacen.Security;

namespace AdminAlmacen.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult changeStore(IdentificatorViewModel model)
        {
            var currentUser = (PersonalizedIdentity)User.Identity;
            try
            {
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    var oUser = (from us in db.user where currentUser.id == us.id select us).FirstOrDefault();
                    oUser.id_defaultStore = model.id; //Int32.Parse(model.id);
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
    }
}