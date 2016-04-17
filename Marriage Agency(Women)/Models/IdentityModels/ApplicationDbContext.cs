using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.Characteristics.Files;
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

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }
        public DbSet<DesiredAge> DesiredAges { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EyeColor> EyeColors { get; set; }
        public DbSet<HairColor> HairColors { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<InternationalPassport> InternationalPassports { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Knowledge> Knowledges { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Lifestyle> Lifestyles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ResidencePermit> ResidencePermits { get; set; } 
        public DbSet<NumberOfChildren> NumbersOfChildren { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<Smoking> Smokings { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}