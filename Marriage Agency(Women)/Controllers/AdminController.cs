using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Marriage_Agency_Women_.Models.IdentityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace Marriage_Agency_Women_.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext _applicationDbContext;
        private ApplicationRoleManager _roleManager;

        public AdminController() { }

        public AdminController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            RoleManager = roleManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private ApplicationDbContext DbContext
        {
            get
            {
                if (_applicationDbContext == null)
                {
                    _applicationDbContext = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
                }
                return _applicationDbContext;
            }
        }

        private ApplicationRoleManager RoleManager
        {
            get
            {
                if (_roleManager == null)
                {
                    _roleManager = HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
                }
                return _roleManager;
            }
            set { _roleManager = value; } 
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowAccounts()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            IdentityUserRole userRole = RoleManager.FindByName("user").Users.FirstOrDefault();
            if (userRole != null)
            {
                users = UserManager.Users.Where(u => u.Roles.Select(r => r.RoleId).Contains(userRole.RoleId)).ToList();
            }

            List<ApplicationUser> admins = new List<ApplicationUser>();

            IdentityUserRole adminRole = RoleManager.FindByName("admin").Users.FirstOrDefault();
            if (adminRole != null)
            {
                admins = UserManager.Users.Where(u => u.Roles.Select(r => r.RoleId).Contains(adminRole.RoleId)).ToList();
            }

            ViewBag.admins = admins;
            return View(users);
        }
    }
}