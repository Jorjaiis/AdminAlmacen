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
            string email = us.email;
            string password = us.password;
            try
            {
                if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
                {
                    ViewBag.data_error = "Insert Username and Password.";
                    return View();
                }
                
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    var pass = Encrypt.GetSHA256(password.Trim());
                    user oUser = (from user in db.user where user.email == email.Trim() && user.password == pass select user).FirstOrDefault();
                    if (oUser == null)
                    {
                        ViewBag.login_error = "Username or Password incorrect.";
                        return View();
                    }
                    List<StoreViewModel> oStore = (from aux_us in db.user_store from aux_s in db.store
                                     where aux_us.id_user == oUser.id && aux_us.id_store == aux_s.id
                                     select new StoreViewModel { id= aux_s.id, name=aux_s.name}).ToList();
                    GlobalData gd = new GlobalData();
                    gd.id_user = oUser.id;
                    gd.name_user = oUser.first_name;
                    gd.id_store = oStore.First().id;
                    gd.name_store = oStore.First().name;
                    FormsAuthentication.SetAuthCookie((oUser.id).ToString(), true);
                    Session["user"] = gd;
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.login_error = ex.Message;
                return View("Ocurrio un error");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["user"] = null;
            return RedirectToAction("Index");
        }


    }
}