using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Studentportalen.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studentportalen.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolClass> Classes { get; set; }
    }
}
