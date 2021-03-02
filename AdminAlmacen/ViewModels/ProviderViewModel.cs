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
        public string rfc { get; set; }
        public string address { get; set; }
        public int location { get; set; }

    }
}