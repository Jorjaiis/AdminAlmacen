using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminAlmacen.Filters
{
    public class MainController: Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.a = "a";
            base.OnActionExecuting(filterContext);
        }
    }
}