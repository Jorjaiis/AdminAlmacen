using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminAlmacen.ViewModels
{
    public class ProviderViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public int? contact_name { get; set; }
        public int location { get; set; }

    }
}