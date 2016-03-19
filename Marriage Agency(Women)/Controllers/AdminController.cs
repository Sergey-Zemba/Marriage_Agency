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
    public class AdminController : ApplicationBaseController
    {
        public AdminController() { }

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