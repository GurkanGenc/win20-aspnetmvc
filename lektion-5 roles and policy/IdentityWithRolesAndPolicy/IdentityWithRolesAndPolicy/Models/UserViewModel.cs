using IdentityWithRolesAndPolicy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityWithRolesAndPolicy.Models
{
    public class UserViewModel : ApplicationUser
    {
        public ICollection<string> Roles { get; set; }
    }
}
