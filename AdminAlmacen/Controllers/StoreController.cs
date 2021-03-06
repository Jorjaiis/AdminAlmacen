using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;
using AdminAlmacen.Security;
using AdminAlmacen.Filters;
namespace AdminAlmacen.Controllers
{
    [Authorize]
    public class StoreController : MainController
    {
        // GET: Store
        public ActionResult Index_Store()
        {
            return View();
        }

        
    }
}