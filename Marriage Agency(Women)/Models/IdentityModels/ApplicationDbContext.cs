using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Marriage_Agency_Women_.Models.IdentityModels
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        static ApplicationDbContext()
        {
            Database.SetInitializer(new AccountsInitializer());
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Language> Languages { get; set; } 

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}