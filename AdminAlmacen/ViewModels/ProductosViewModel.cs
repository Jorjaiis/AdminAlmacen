using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminAlmacen.ViewModels
{
    public class ProductosViewModel
    {
        public Guid id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
    }
}