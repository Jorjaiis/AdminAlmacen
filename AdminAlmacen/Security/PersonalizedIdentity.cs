using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web.Security;
using System.Web;

namespace AdminAlmacen.Security
{
    public class PersonalizedIdentity : IIdentity
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public IIdentity Identity { get; set; }
        public PersonalizedIdentity(IIdentity identity)
        {
            this.Identity = identity;
            var user = Membership.GetUser(identity.Name) as UserMembership;
            id = user.id;
            first_name = user.first_name;
            email = user.email;
            password = user.password;
        }

        public string Name { get { return email; } }
        public string AuthenticationType { get { return Identity.AuthenticationType; } }
        public bool IsAuthenticated { get { return Identity.IsAuthenticated; } }
    }
}