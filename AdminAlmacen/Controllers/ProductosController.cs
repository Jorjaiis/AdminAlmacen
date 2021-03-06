using AdminAlmacen.Models;
using AdminAlmacen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminAlmacen.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            /*List<ProductosViewModel> productos;
            using (AlmacenEntities db = new AlmacenEntities())
            {
                productos = (from prod in db.productos select new ProductosViewModel
                             {
                                 id = prod.id,
                                 codigo = prod.codigo,
                                 nombre = prod.nombre,
                                 descripcion = prod.descripcion,
                                 costo = prod.costo
                             }).ToList();
            }
            return View(productos);*/
            return View();
        }

        public ActionResult Editar(Guid id)
        {
            
            /*List<ProductosViewModel> productos;
            using (AlmacenEntities db = new AlmacenEntities())
            {
                var prodq = db.productos.Find(id);
                productos = (from prod in db.productos
                             select new ProductosViewModel
                             {
                                 id = prod.id,
                                 codigo = prod.codigo,
                                 nombre = prod.nombre,
                                 descripcion = prod.descripcion,
                                 costo = prod.costo
                             }).ToList();
            }*/
            //return View(productos);
            return View();
        }
    }
}