using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminAlmacen.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }

    }

    public class StoreViewModel
    {
        public int id;
        public string name;
    }
}