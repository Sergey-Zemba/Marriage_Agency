using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.IdentityModels
{
    public class Language
    {
        public Language()
        {
            Users = new List<ApplicationUser>();
        }

        public Language(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; } 
    }
}