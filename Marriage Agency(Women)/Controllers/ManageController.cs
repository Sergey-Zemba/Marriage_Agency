using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Marriage_Agency_Women_.Models;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.IdentityModels;
using Marriage_Agency_Women_.Models.ManageViewModels;

namespace Marriage_Agency_Women_.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext _applicationDbContext;

        public ManageController()
        {
        }

        public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
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

        //
        // GET: /Manage/Index
        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            //
            // Перенести содержимое метода в другое место (скорее всего в Edit(get)), индексная будет другой
            //
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
                : message == ManageMessageId.Error ? "An error has occurred."
                : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
                : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
                : "";

            var userId = User.Identity.GetUserId();
            ApplicationUser user = await UserManager.FindByIdAsync(userId);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            //ICollection<int> languages = new List<int>();
            //if (user.Languages != null)
            //{
            //    foreach (Language language in user.Languages)
            //    {
            //        languages.Add(language.Id);
            //    }
            //}

            EditViewModel model = new EditViewModel
            {
                HasPassword = HasPassword(),

                FirstName = user.FirstName,
                LastName = user.LastName,
                NameInRoman = user.NameInRoman,
                Birthday = user.Birthday,
                Location = user.Location.Id,
                Religion = user.Religion.Id,
                Activity = user.Activity.Id,
                Job = user.Job.Id,
                Education = user.Education.Id,
                //Languages = languages,
                Relationship = user.Relationship.Id,
                NumberOfChildren = user.NumberOfChildren.Id,
                Height = user.Height,
                Weight = user.Weight,
                Shape = user.Shape.Id,
                EyeColor = user.EyeColor.Id,
                HairColor = user.HairColor.Id,
                Smoking = user.Smoking.Id,
                Alcohol = user.Alcohol.Id,
                DesiredAge = user.DesiredAge.Id,
                Hobby = user.Hobby.Id,
                Lifestyle = user.Lifestyle.Id,
                Knowledge = user.Knowledge.Id,
                PhoneNumber = user.PhoneNumber.Substring(3),
                Skype = user.Skype,
                Facebook = user.Facebook,
                Vk = user.Vk,
                Twitter = user.Twitter,
                InternationalPassport = user.InternationalPassport.Id
            };

            IDictionary<string, IList<SelectListItem>> personalData = new Dictionary<string, IList<SelectListItem>>();
            IList<SelectListItem> data = GetSelectListItems(new List<PersonalData>(DbContext.Activities));
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

            ViewBag.languages = DbContext.Languages.ToList();

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
            ViewBag.PersonalData = personalData;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditViewModel model)
        {
            if (ModelState.IsValid)
            {
                //List<Language> languages = new List<Language>();

                //if (model.Languages != null)
                //{
                //    foreach (int id in model.Languages)
                //    {
                //        var lang = DbContext.Languages.Find(id);
                //        languages.Add(lang);
                //    }
                //}

                var userName = User.Identity.Name;
                var user = await UserManager.FindByNameAsync(userName);

                if (user == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.NameInRoman = model.NameInRoman;
                user.Birthday = model.Birthday;
                user.Location = DbContext.Locations.Find(model.Location);
                user.Religion = DbContext.Religions.Find(model.Religion);
                user.Activity = DbContext.Activities.Find(model.Activity);
                user.Job = DbContext.Jobs.Find(model.Job);
                user.Education = DbContext.Educations.Find(model.Education);

                // Очистка обязательна, иначе Cannot insert duplicate key in object
                //user.Languages.Clear();
                //user.Languages = languages;

                user.Relationship = DbContext.Relationships.Find(model.Relationship);
                user.NumberOfChildren = DbContext.NumbersOfChildren.Find(model.NumberOfChildren);
                user.Height = model.Height;
                user.Weight = model.Weight;
                user.Shape = DbContext.Shapes.Find(model.Shape);
                user.EyeColor = DbContext.EyeColors.Find(model.EyeColor);
                user.HairColor = DbContext.HairColors.Find(model.HairColor);
                user.Smoking = DbContext.Smokings.Find(model.Smoking);
                user.Alcohol = DbContext.Alcohols.Find(model.Alcohol);
                user.DesiredAge = DbContext.DesiredAges.Find(model.DesiredAge);
                user.Hobby = DbContext.Hobbies.Find(model.Hobby);
                user.Lifestyle = DbContext.Lifestyles.Find(model.Lifestyle);
                user.Knowledge = DbContext.Knowledges.Find(model.Knowledge);
                user.PhoneNumber = "+38" + model.PhoneNumber;
                user.Skype = model.Skype;
                user.Facebook = model.Facebook;
                user.Vk = model.Vk;
                user.Twitter = model.Twitter;
                user.InternationalPassport = DbContext.InternationalPassports.Find(model.InternationalPassport);

                var result = await UserManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    ManageMessageId message = ManageMessageId.EditSuccess;
                    return RedirectToAction("Index", new { Message = message });
                }
                AddErrors(result);
            }

            IDictionary<string, IList<SelectListItem>> personalData = new Dictionary<string, IList<SelectListItem>>();
            IList<SelectListItem> data = GetSelectListItems(new List<PersonalData>(DbContext.Activities));
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

            ViewBag.languages = DbContext.Languages.ToList();

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
            ViewBag.PersonalData = personalData;

            return View("Index", model);
        }

        //
        // POST: /Manage/RemoveLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveLogin(string loginProvider, string providerKey)
        {
            ManageMessageId? message;
            var result = await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                message = ManageMessageId.RemoveLoginSuccess;
            }
            else
            {
                message = ManageMessageId.Error;
            }
            return RedirectToAction("ManageLogins", new { Message = message });
        }

        //
        // GET: /Manage/AddPhoneNumber
        public ActionResult AddPhoneNumber()
        {
            return View();
        }

        //
        // POST: /Manage/AddPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddPhoneNumber(AddPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Generate the token and send it
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), model.Number);
            if (UserManager.SmsService != null)
            {
                var message = new IdentityMessage
                {
                    Destination = model.Number,
                    Body = "Your security code is: " + code
                };
                await UserManager.SmsService.SendAsync(message);
            }
            return RedirectToAction("VerifyPhoneNumber", new { PhoneNumber = model.Number });
        }

        //
        // POST: /Manage/EnableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EnableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), true);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // POST: /Manage/DisableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DisableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), false);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // GET: /Manage/VerifyPhoneNumber
        public async Task<ActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), phoneNumber);
            // Send an SMS through the SMS provider to verify the phone number
            return phoneNumber == null ? View("Error") : View(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });
        }

        //
        // POST: /Manage/VerifyPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyPhoneNumber(VerifyPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePhoneNumberAsync(User.Identity.GetUserId(), model.PhoneNumber, model.Code);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.AddPhoneSuccess });
            }
            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Failed to verify phone");
            return View(model);
        }

        //
        // GET: /Manage/RemovePhoneNumber
        public async Task<ActionResult> RemovePhoneNumber()
        {
            var result = await UserManager.SetPhoneNumberAsync(User.Identity.GetUserId(), null);
            if (!result.Succeeded)
            {
                return RedirectToAction("Index", new { Message = ManageMessageId.Error });
            }
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", new { Message = ManageMessageId.RemovePhoneSuccess });
        }

        //
        // GET: /Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.ChangePasswordSuccess });
            }
            AddErrors(result);
            return View(model);
        }

        //
        // GET: /Manage/SetPassword
        public ActionResult SetPassword()
        {
            return View();
        }

        //
        // POST: /Manage/SetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetPassword(SetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
                if (result.Succeeded)
                {
                    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                    if (user != null)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    }
                    return RedirectToAction("Index", new { Message = ManageMessageId.SetPasswordSuccess });
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Manage/ManageLogins
        public async Task<ActionResult> ManageLogins(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : message == ManageMessageId.Error ? "An error has occurred."
                : "";
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user == null)
            {
                return View("Error");
            }
            var userLogins = await UserManager.GetLoginsAsync(User.Identity.GetUserId());
            var otherLogins = AuthenticationManager.GetExternalAuthenticationTypes().Where(auth => userLogins.All(ul => auth.AuthenticationType != ul.LoginProvider)).ToList();
            ViewBag.ShowRemoveButton = user.PasswordHash != null || userLogins.Count > 1;
            return View(new ManageLoginsViewModel
            {
                CurrentLogins = userLogins,
                OtherLogins = otherLogins
            });
        }

        //
        // POST: /Manage/LinkLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LinkLogin(string provider)
        {
            // Request a redirect to the external login provider to link a login for the current user
            return new AccountController.ChallengeResult(provider, Url.Action("LinkLoginCallback", "Manage"), User.Identity.GetUserId());
        }

        //
        // GET: /Manage/LinkLoginCallback
        public async Task<ActionResult> LinkLoginCallback()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId());
            if (loginInfo == null)
            {
                return RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
            }
            var result = await UserManager.AddLoginAsync(User.Identity.GetUserId(), loginInfo.Login);
            return result.Succeeded ? RedirectToAction("ManageLogins") : RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
        }

        #region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        public IList<SelectListItem> GetSelectListItems(List<PersonalData> personalData)
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

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        private bool HasPhoneNumber()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PhoneNumber != null;
            }
            return false;
        }

        #endregion
    }
}