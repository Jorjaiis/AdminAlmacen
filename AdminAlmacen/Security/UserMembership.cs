using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using AdminAlmacen.Helper;
using AdminAlmacen.Models;

namespace AdminAlmacen.Security
{
    public class UserMembership : MembershipUser
    {
        public int id { get; set; }
        public string  first_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public UserMembership(user us)
        {
            id = us.id;
            first_name = us.first_name;
            email = us.email;
            password = Encrypt.GetSHA256(us.password);
        }
    }
}