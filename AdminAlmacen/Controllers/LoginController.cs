using AdminAlmacen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminAlmacen.Models;
using AdminAlmacen.Helper;
using System.Web.Security;

namespace AdminAlmacen.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel us)
        {
            try
            {
                if(Membership.ValidateUser(us.email.Trim(), us.password))
                {
                    FormsAuthentication.RedirectFromLoginPage(us.email,false);
                    return null;
                }
                else
                {
                    ViewBag.data_error = "Insert Username and Password.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.login_error = "Ocurrio un error, intente de nuevo";
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }


    }
}