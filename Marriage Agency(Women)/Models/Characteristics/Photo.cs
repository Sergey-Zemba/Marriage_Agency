using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.IdentityModels;

namespace Marriage_Agency_Women_.Models.Characteristics
{
    public class Photo
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}