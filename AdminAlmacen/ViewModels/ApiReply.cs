using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminAlmacen.ViewModels
{
    public class ApiReply
    {
        public int result { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}