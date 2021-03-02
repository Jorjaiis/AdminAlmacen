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
                var oStore = (from st in db.store where oUser.id_defaultStore == st.id select st).FirstOrDefault();
                ViewBag.name_user = oUser.first_name;
                ViewBag.id_user = oUser.id;
                ViewBag.id_store = oStore.id;
                ViewBag.name_store = oStore.name;
            }
        }

    }
}