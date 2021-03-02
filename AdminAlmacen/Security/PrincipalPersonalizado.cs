using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace AdminAlmacen.Security
{
    public class PrincipalPersonalizado : IPrincipal
    {
        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
        public PersonalizedIdentity MiIdentidadPersonalizada
        {
            get { return (PersonalizedIdentity)Identity; }
            set { Identity = value; }
        }

        public PrincipalPersonalizado(PersonalizedIdentity identity)
        {
            Identity = identity;
        }
    }
}