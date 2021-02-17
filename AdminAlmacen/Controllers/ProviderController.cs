using AdminAlmacen.Helper;
using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminAlmacen.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider
        public ActionResult Index_Provider()
        {
            try
            {
                if (Session["user"] == null)
                {
                    return View();
                }
                var user = (GlobalData)Session["user"];
                ViewBag.name_user = user.name_user;
                ViewBag.name_store = user.name_store;
                List<ProviderViewModel> oProvider;
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    oProvider = (from pro in db.provider select new ProviderViewModel
                    {
                        id = pro.id,
                        name = pro.name,
                        phone = pro.phone,
                        address = pro.address,
                        rfc = pro.rfc
                    }).ToList();

                }
                return View(oProvider);
            }
            catch (Exception ex)
            {
                List<ProviderViewModel> oProvider = new List<ProviderViewModel>();
                ViewBag.error = "Ha ocurrido un Error: " + ex;
                return View(oProvider);
            }
        }

        // GET: Provider/Create
        public ActionResult CreateProvider()
        {
            try
            {
                if (Session["user"] == null)
                {
                    return View();
                }
                var user = (GlobalData)Session["user"];
                ViewBag.name_user = user.name_user;
                ViewBag.name_store = user.name_store;
                List<CountryViewModel> countries;
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    countries = (from co in db.country select new CountryViewModel { 
                        id = co.id,
                        name = co.name
                    }).ToList();
                }
                return View(countries);
            }
            catch (Exception ex)
            {
                return View();
            }
            
            


            return View();
        }

        // POST: Provider/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Provider/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Provider/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Provider/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Provider/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
