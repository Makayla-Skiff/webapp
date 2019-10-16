using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SLTPage.Data;

namespace SLTPage.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SLTPage.Data.SLT> SLT { get; set; }
        public DbSet<SLTPage.Data.Admin> Admin { get; set; }
        public DbSet<SLTPage.Data.Department_Owner> Department_Owner { get; set; }
    }
}
