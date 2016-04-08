using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marriage_Agency_Women_.Models.Characteristics.Files;
using Marriage_Agency_Women_.Models.IdentityModels;

namespace Marriage_Agency_Women_.Controllers.PersonalDataControllers
{
    public class FilePathController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Route("FilePath/Delete/{id}")]
        public void Delete(int id)
        {
            FilePath filePath = db.FilePaths.Find(id);
            IEnumerable<FilePath> filePathsToDelete = db.FilePaths.Where(f => f.FileName == filePath.FileName);
            db.FilePaths.RemoveRange(filePathsToDelete);
            db.SaveChanges();
        }
    }
}