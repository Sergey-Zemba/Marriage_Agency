using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.IdentityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Marriage_Agency_Women_.Controllers
{
    public abstract class ApplicationBaseController : Controller
    {
        // Fields
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext _applicationDbContext;
        private ApplicationRoleManager _roleManager;
        private IAuthenticationManager _authenticationManager;

        // Used for XSRF protection when adding external logins
        protected const string XsrfKey = "XsrfId";


        // Properties
        protected ApplicationSignInManager SignInManager
        {
            get { return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>(); }
            set { _signInManager = value; }
        }

        protected ApplicationUserManager UserManager
        {
            get { return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            set { _userManager = value; }
        }

        protected ApplicationDbContext DbContext
        {
            get { return _applicationDbContext ?? HttpContext.GetOwinContext().Get<ApplicationDbContext>(); }
            set { _applicationDbContext = value; }
        }

        protected ApplicationRoleManager RoleManager
        {
            get { return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>(); }
            set { _roleManager = value; }
        }

        protected IAuthenticationManager AuthenticationManager
        {
            get { return _authenticationManager ?? HttpContext.GetOwinContext().Authentication; }
            set { _authenticationManager = value; }
        }



        // Methods
        protected IList<SelectListItem> GetSelectListItems(List<PersonalData> personalData)
        {
            List<SelectListItem> listToReturn = new List<SelectListItem>();
            foreach (PersonalData data in personalData.OrderBy(d => d.Position))
            {
                SelectListItem item = new SelectListItem();
                item.Value = data.Id.ToString();
                item.Text = data.RussianName;
                listToReturn.Add(item);
            }
            return listToReturn;
        }

        protected IDictionary<string, IList<SelectListItem>> GetSelectListItemsDictionary()
        {
            IDictionary<string, IList<SelectListItem>> personalData = new Dictionary<string, IList<SelectListItem>>();
            IList<SelectListItem> data = null;

            data = GetSelectListItems(new List<PersonalData>(DbContext.Activities));
            personalData.Add("activities", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Alcohols));
            personalData.Add("alcohols", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.DesiredAges));
            personalData.Add("desiredAges", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Educations));
            personalData.Add("educations", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.EyeColors));
            personalData.Add("eyeColors", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.HairColors));
            personalData.Add("hairColors", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Hobbies));
            personalData.Add("hobbies", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.InternationalPassports));
            personalData.Add("internationalPassports", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Jobs));
            personalData.Add("jobs", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Knowledges));
            personalData.Add("knowledges", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Languages));
            personalData.Add("languages", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Levels));
            personalData.Add("levels", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Lifestyles));
            personalData.Add("lifestyles", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Locations));
            personalData.Add("locations", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.NumbersOfChildren));
            personalData.Add("numbersOfChildren", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Relationships));
            personalData.Add("relationships", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Religions));
            personalData.Add("religions", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Shapes));
            personalData.Add("shapes", data);

            data = GetSelectListItems(new List<PersonalData>(DbContext.Smokings));
            personalData.Add("smokings", data);


            return personalData;
        }

        protected string CreateThumbnail(string source, int maxSize)
        {
            Image image = Image.FromFile(Server.MapPath("~/Content/Images/" + source));
            double ratio = (double)image.Size.Width / image.Size.Height;
            int thumbnailWidth = maxSize, thumbnailHeight = maxSize;
            if (ratio > 1.0)
            {
                thumbnailHeight = (int)(100 / ratio);
            }
            else if (ratio < 1.0)
            {
                thumbnailWidth = (int)(100 * ratio);
            }
            Bitmap thumbnailBitmap = new Bitmap(thumbnailWidth, thumbnailHeight);
            Graphics thumbnailGraph = Graphics.FromImage(thumbnailBitmap);
            thumbnailGraph.CompositingQuality = CompositingQuality.HighQuality;
            thumbnailGraph.SmoothingMode = SmoothingMode.HighQuality;
            thumbnailGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imageRectangle = new Rectangle(0, 0, thumbnailWidth, thumbnailHeight);
            thumbnailGraph.DrawImage(image, imageRectangle);
            string pathToSave = System.IO.Path.Combine(Server.MapPath("~/Content/Images/Thumbnails"), source);
            thumbnailBitmap.Save(pathToSave);
            thumbnailGraph.Dispose();
            thumbnailBitmap.Dispose();
            image.Dispose();
            return pathToSave;
        }

        protected static string MakeRelative(string filePath, string referencePath)
        {
            var fileUri = new Uri(filePath);
            var referenceUri = new Uri(referencePath);
            return referenceUri.MakeRelativeUri(fileUri).ToString();
        }

        protected void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }

                if (_applicationDbContext != null)
                {
                    _applicationDbContext.Dispose();
                    _applicationDbContext = null;
                }

                if (_roleManager != null)
                {
                    _roleManager.Dispose();
                    _roleManager = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}