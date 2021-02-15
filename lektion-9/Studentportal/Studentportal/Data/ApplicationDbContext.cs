using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Studentportal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studentportal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<SchoolCourse> SchoolCourses { get; set; }
    }
}
