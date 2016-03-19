using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Marriage_Agency_Women_.Models;
using Marriage_Agency_Women_.Models.AccountViewModels;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.IdentityModels;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Marriage_Agency_Women_.Controllers
{
    [Authorize]
    public class AccountController : ApplicationBaseController
    {
        public AccountController() { }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public FileContentResult GetExcel()
        {
            var fileDownloadName = "Users.xlsx";
            const string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            ExcelPackage package = GenerateExcelFile(DbContext.Users.ToList());
            var fcr = new FileContentResult(package.GetAsByteArray(), contentType);
            fcr.FileDownloadName = fileDownloadName;
            return fcr;
        }
        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                var user = await UserManager.FindAsync(model.Email, model.Password);
                if (user != null)
                {
                    if (user.EmailConfirmed == true)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        return RedirectToLocal(returnUrl);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Не подтвержден email.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неверный логин или пароль");
                }
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }

        //
        // GET: /Account/VerifyCode
        [AllowAnonymous]
        public async Task<ActionResult> VerifyCode(string provider, string returnUrl, bool rememberMe)
        {
            // Require that the user has already logged in via username/password or external login
            if (!await SignInManager.HasBeenVerifiedAsync())
            {
                return View("Error");
            }
            return View(new VerifyCodeViewModel { Provider = provider, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/VerifyCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // The following code protects for brute force attacks against the two factor codes. 
            // If a user enters incorrect codes for a specified amount of time then the user account 
            // will be locked out for a specified amount of time. 
            // You can configure the account lockout settings in IdentityConfig
            var result = await SignInManager.TwoFactorSignInAsync(model.Provider, model.Code, isPersistent: model.RememberMe, rememberBrowser: model.RememberBrowser);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(model.ReturnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid code.");
                    return View(model);
            }
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
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
            ViewBag.PersonalData = personalData;
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    NameInRoman = model.NameInRoman,
                    Birthday = model.Birthday,
                    Location = DbContext.Locations.Find(model.Location),
                    //ResidencePermit = model.Location, // не ошибка
                    Religion = DbContext.Religions.Find(model.Religion),
                    Activity = DbContext.Activities.Find(model.Activity),
                    Job = DbContext.Jobs.Find(model.Job),
                    Education = DbContext.Educations.Find(model.Education),
                    FirstLanguage = DbContext.Languages.Find(model.FirstLanguage),
                    FirstLanguageLevel = DbContext.Levels.Find(model.FirstLanguageLevel),
                    SecondLanguage = DbContext.Languages.Find(model.SecondLanguage),
                    SecondLanguageLevel = DbContext.Levels.Find(model.SecondLanguageLevel),
                    ThirdLanguage = DbContext.Languages.Find(model.ThirdLanguage),
                    ThirdLanguageLevel = DbContext.Levels.Find(model.ThirdLanguageLevel),
                    Relationship = DbContext.Relationships.Find(model.Relationship),
                    NumberOfChildren = DbContext.NumbersOfChildren.Find(model.NumberOfChildren),
                    Height = model.Height,
                    Weight = model.Weight,
                    Shape = DbContext.Shapes.Find(model.Shape),
                    EyeColor = DbContext.EyeColors.Find(model.EyeColor),
                    HairColor = DbContext.HairColors.Find(model.HairColor),
                    Smoking = DbContext.Smokings.Find(model.Smoking),
                    Alcohol = DbContext.Alcohols.Find(model.Alcohol),
                    DesiredAge = DbContext.DesiredAges.Find(model.DesiredAge),
                    Hobby = DbContext.Hobbies.Find(model.Hobby),
                    Lifestyle = DbContext.Lifestyles.Find(model.Lifestyle),
                    Knowledge = DbContext.Knowledges.Find(model.Knowledge),
                    PhoneNumber = "+38" + model.PhoneNumber,
                    Skype = model.Skype,
                    Facebook = model.Facebook,
                    Vk = model.Vk,
                    Twitter = model.Twitter,
                    InternationalPassport = DbContext.InternationalPassports.Find(model.InternationalPassport),
                    CreationDate = DateTime.Now,
                    LastLoginTime = DateTime.Now
                };
                // инкрементировать номер анкеты. Пока нули дубасят.

                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await UserManager.AddToRoleAsync(user.Id, "user");
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    var code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code },
                        protocol: Request.Url.Scheme);
                    await
                        UserManager.SendEmailAsync(user.Id, "Confirm your account",
                            "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");
                    return View("DisplayEmail");

                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var result = await UserManager.ConfirmEmailAsync(userId, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }

        //
        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //
        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return View("ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                // string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                // var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);		
                // await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                // return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ForgotPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View();
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            var result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            AddErrors(result);
            return View();
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

        //
        // GET: /Account/SendCode
        [AllowAnonymous]
        public async Task<ActionResult> SendCode(string returnUrl, bool rememberMe)
        {
            var userId = await SignInManager.GetVerifiedUserIdAsync();
            if (userId == null)
            {
                return View("Error");
            }
            var userFactors = await UserManager.GetValidTwoFactorProvidersAsync(userId);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            return View(new SendCodeViewModel { Providers = factorOptions, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/SendCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Generate the token and send it
            if (!await SignInManager.SendTwoFactorCodeAsync(model.SelectedProvider))
            {
                return View("Error");
            }
            return RedirectToAction("VerifyCode", new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }

        //
        // GET: /Account/ExternalLoginCallback
        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl)
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            // Sign in the user with this external login provider if the user already has a login
            var result = await SignInManager.ExternalSignInAsync(loginInfo, isPersistent: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = false });
                case SignInStatus.Failure:
                default:
                    // If the user does not have an account, then prompt the user to create an account
                    ViewBag.ReturnUrl = returnUrl;
                    ViewBag.LoginProvider = loginInfo.Login.LoginProvider;
                    return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = loginInfo.Email });
            }
        }

        //
        // POST: /Account/ExternalLoginConfirmation
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Manage");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await UserManager.AddLoginAsync(user.Id, info.Login);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        return RedirectToLocal(returnUrl);
                    }
                }
                AddErrors(result);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<JsonResult> CheckEmail(string email)
        {

            bool result = false;
            if (email != null)
            {
                ApplicationUser user = await UserManager.FindByEmailAsync(email);
                if (user == null)
                {
                    result = true;
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private static ExcelPackage GenerateExcelFile(List<ApplicationUser> dataSource)
        {
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet 1");
            ws.Cells[1, 1].Value = "Id";
            ws.Cells[1, 2].Value = "Имя";
            ws.Cells[1, 3].Value = "Фамилия";
            ws.Cells[1, 4].Value = "Имя латиницей";
            ws.Cells[1, 5].Value = "Дата рождения";
            ws.Cells[1, 6].Value = "Возраст";
            ws.Cells[1, 7].Value = "Телефон";
            ws.Cells[1, 8].Value = "Email";
            ws.Cells[1, 9].Value = "Пароль";
            ws.Cells[1, 10].Value = "Место проживания";
            ws.Cells[1, 11].Value = "Вера";
            ws.Cells[1, 12].Value = "Сфера работы";
            ws.Cells[1, 13].Value = "Должность";
            ws.Cells[1, 14].Value = "Первый язык";
            ws.Cells[1, 15].Value = "Уровень";
            ws.Cells[1, 16].Value = "Второй язык";
            ws.Cells[1, 17].Value = "Уровень";
            ws.Cells[1, 18].Value = "Третий язык";
            ws.Cells[1, 19].Value = "Уровень";
            ws.Cells[1, 20].Value = "Семейное положение";
            ws.Cells[1, 21].Value = "Дети";
            ws.Cells[1, 22].Value = "Рост";
            ws.Cells[1, 23].Value = "Вес";
            ws.Cells[1, 24].Value = "Фигура";
            ws.Cells[1, 25].Value = "Цвет глаз";
            ws.Cells[1, 26].Value = "Цвет волос";
            ws.Cells[1, 27].Value = "Курение";
            ws.Cells[1, 28].Value = "Алкоголь";
            ws.Cells[1, 29].Value = "Желаемый возраст";
            ws.Cells[1, 30].Value = "Хобби";
            ws.Cells[1, 31].Value = "Образ жизни";
            ws.Cells[1, 32].Value = "Еда и знания";
            ws.Cells[1, 33].Value = "Skype";
            ws.Cells[1, 34].Value = "Facebook";
            ws.Cells[1, 35].Value = "Vk";
            ws.Cells[1, 36].Value = "Twitter";
            ws.Cells[1, 37].Value = "Загранпаспорт";
            ws.Cells[1, 38].Value = "Статус";
            for (int i = 0; i < dataSource.Count(); i++)
            {
                ws.Cells[i + 2, 1].Value = dataSource.ElementAt(i).Id;
                ws.Cells[i + 2, 2].Value = dataSource.ElementAt(i).FirstName;
                ws.Cells[i + 2, 3].Value = dataSource.ElementAt(i).LastName;
                ws.Cells[i + 2, 4].Value = dataSource.ElementAt(i).NameInRoman;
                ws.Cells[i + 2, 5].Value = dataSource.ElementAt(i).Birthday;
                ws.Cells[i + 2, 6].Value = dataSource.ElementAt(i).Age;
                ws.Cells[i + 2, 7].Value = dataSource.ElementAt(i).PhoneNumber;
                ws.Cells[i + 2, 8].Value = dataSource.ElementAt(i).Email;
                ws.Cells[i + 2, 9].Value = dataSource.ElementAt(i).PasswordHash;
                ws.Cells[i + 2, 10].Value = dataSource.ElementAt(i).Location.RussianName;
                ws.Cells[i + 2, 11].Value = dataSource.ElementAt(i).Religion.RussianName;
                ws.Cells[i + 2, 12].Value = dataSource.ElementAt(i).Activity.RussianName;
                ws.Cells[i + 2, 13].Value = dataSource.ElementAt(i).Job.RussianName;
                ws.Cells[i + 2, 14].Value = dataSource.ElementAt(i).FirstLanguage.RussianName;
                ws.Cells[i + 2, 15].Value = dataSource.ElementAt(i).FirstLanguageLevel.RussianName;
                ws.Cells[i + 2, 16].Value = dataSource.ElementAt(i).SecondLanguage.RussianName;
                ws.Cells[i + 2, 17].Value = dataSource.ElementAt(i).SecondLanguageLevel.RussianName;
                ws.Cells[i + 2, 18].Value = dataSource.ElementAt(i).ThirdLanguage.RussianName;
                ws.Cells[i + 2, 19].Value = dataSource.ElementAt(i).ThirdLanguageLevel.RussianName;
                ws.Cells[i + 2, 20].Value = dataSource.ElementAt(i).Relationship.RussianName;
                ws.Cells[i + 2, 21].Value = dataSource.ElementAt(i).NumberOfChildren.RussianName;
                ws.Cells[i + 2, 22].Value = dataSource.ElementAt(i).Height;
                ws.Cells[i + 2, 23].Value = dataSource.ElementAt(i).Weight;
                ws.Cells[i + 2, 24].Value = dataSource.ElementAt(i).Shape.RussianName;
                ws.Cells[i + 2, 25].Value = dataSource.ElementAt(i).EyeColor.RussianName;
                ws.Cells[i + 2, 26].Value = dataSource.ElementAt(i).HairColor.RussianName;
                ws.Cells[i + 2, 27].Value = dataSource.ElementAt(i).Smoking.RussianName;
                ws.Cells[i + 2, 28].Value = dataSource.ElementAt(i).Alcohol.RussianName;
                ws.Cells[i + 2, 29].Value = dataSource.ElementAt(i).DesiredAge.RussianName;
                ws.Cells[i + 2, 30].Value = dataSource.ElementAt(i).Hobby.RussianName;
                ws.Cells[i + 2, 31].Value = dataSource.ElementAt(i).Lifestyle.RussianName;
                ws.Cells[i + 2, 32].Value = dataSource.ElementAt(i).Knowledge.RussianName;
                ws.Cells[i + 2, 33].Value = dataSource.ElementAt(i).Skype;
                ws.Cells[i + 2, 34].Value = dataSource.ElementAt(i).Facebook;
                ws.Cells[i + 2, 35].Value = dataSource.ElementAt(i).Vk;
                ws.Cells[i + 2, 36].Value = dataSource.ElementAt(i).Twitter;
                ws.Cells[i + 2, 37].Value = dataSource.ElementAt(i).InternationalPassport.RussianName;
                ws.Cells[i + 2, 38].Value = dataSource.ElementAt(i).Status;
            }
            using (ExcelRange rng = ws.Cells["A1:AL1"])
            {
                rng.Style.Font.Bold = true;
                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                rng.Style.Fill.BackgroundColor.SetColor(Color.Gold);
                rng.Style.Font.Color.SetColor(Color.Black);
            }
            return pck;
        }

        #region Helpers
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion
    }
}