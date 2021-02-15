using Studentportal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Studentportal.Models
{
    public class SchoolClass
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Id { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        public ApplicationUser Manager { get; set; }


        public virtual ICollection<ApplicationUser> Students { get; set; }
        public virtual ICollection<SchoolCourse> Courses { get; set; }
    }
}
