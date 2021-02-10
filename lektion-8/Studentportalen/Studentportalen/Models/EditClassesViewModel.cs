using Studentportalen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentportalen.Models
{
    public class EditClassesViewModel
    {
        public SchoolClass CurrentClass { get; set; }
        public IEnumerable<ApplicationUser> Teachers { get; set; }
    }
}
