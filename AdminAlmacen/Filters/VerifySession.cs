using AdminAlmacen.Controllers;
using AdminAlmacen.Helper;
using AdminAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminAlmacen.Filters
{
    public class VerifySession : ActionFilterAttribute
    {
        private GlobalData oUser;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);
                oUser = (GlobalData)HttpContext.Current.Session["user"];
                if (oUser == null)
                {
                    if (filterContext.Controller is LoginController == false)
                        filterContext.HttpContext.Response.Redirect("~/Login/Index");
                }
                else
                {
                    var a = filterContext.ParentActionViewContext;
                    if (filterContext.Controller is LoginController == true)
                        filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
                    
            } catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Login/Index");
            }
            
        }
    }
}