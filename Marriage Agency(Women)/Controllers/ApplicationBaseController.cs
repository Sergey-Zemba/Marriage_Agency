using System;
using System.Collections.Generic;
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