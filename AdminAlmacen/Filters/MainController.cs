using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminAlmacen.Security;
using AdminAlmacen.Models;
namespace AdminAlmacen.Filters
{
    public class MainController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            var current_user = (PersonalizedIdentity)User.Identity;
            using (AlmacenDBEntities db = new AlmacenDBEntities())
            {
                var oUser = (from us in db.user where us.id == current_user.id select us).FirstOrDefault();
                List<store> oStore = (from st in db.store from us in db.user_store
                                      where us.id_user == oUser.id && us.id_store == st.id select st).ToList();
                ViewBag.name_user = oUser.first_name;
                ViewBag.name_store = oStore.First().name;
                ViewBag.id_store = oStore.First().id;
            }
        }

    }
}