using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.IdentityModels;

namespace Marriage_Agency_Women_.Models.Characteristics.Files
{
    public class FilePath
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }

        public FileType FileType { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}