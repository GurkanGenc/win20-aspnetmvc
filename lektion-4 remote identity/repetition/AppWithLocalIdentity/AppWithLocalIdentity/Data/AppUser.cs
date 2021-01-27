using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppWithLocalIdentity.Data
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string LastName { get; set; }

        
        [Column(TypeName = "nvarchar(100)")]
        public string AddressLine { get; set; }

        
        [Column(TypeName = "char(5)")]
        public string ZipCode { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }
    }
}
