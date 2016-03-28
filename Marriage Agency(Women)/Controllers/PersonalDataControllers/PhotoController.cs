using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marriage_Agency_Women_.Models.IdentityModels;

namespace Marriage_Agency_Women_.Controllers.PersonalDataControllers
{
    public class PhotoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Photo
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Photos.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}