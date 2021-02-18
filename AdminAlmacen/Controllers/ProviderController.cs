using AdminAlmacen.Helper;
using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminAlmacen.Filters;
namespace AdminAlmacen.Controllers
{
    public class ProviderController : MainController
    {
        // GET: Provider
        public ActionResult Index_Provider()
        {
            try
            {
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
                return View("Error", "Shared");
                /*List<ProviderViewModel> oProvider = new List<ProviderViewModel>();
                ViewBag.error = "Ha ocurrido un Error: " + ex;
                return View(oProvider);*/
            }
        }

        // GET: Provider/Create
        public ActionResult CreateProvider()
        {
            try
            {
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
                return View("Error","Shared");
            }
        }

        // POST: Provider/Create
        [HttpPost]
        public ActionResult CreateProvider(ProviderViewModel model)
        {
            try
            {
                using (AlmacenDBEntities db = new AlmacenDBEntities())
                {
                    provider oProvider = new provider();
                    oProvider.name = model.name;
                    oProvider.phone = model.phone;
                    oProvider.rfc = model.rfc;
                    oProvider.id_location = model.location;
                    oProvider.address = model.address;
                    db.provider.Add(oProvider);
                    db.SaveChanges();
                }
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
