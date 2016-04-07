using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Marriage_Agency_Women_.Models;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.Characteristics.Files;
using Marriage_Agency_Women_.Models.IdentityModels;
using Marriage_Agency_Women_.Models.ManageViewModels;

namespace Marriage_Agency_Women_.Controllers
{
    [Authorize]
    public class ManageController : ApplicationBaseController
    {
        public ManageController()
        {
        }

        public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
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
                FirstLanguage = user.FirstLanguage.Id,
                FirstLanguageLevel = user.FirstLanguageLevel.Id,
                SecondLanguage = user.SecondLanguage.Id,
                SecondLanguageLevel = user.SecondLanguageLevel.Id,
                ThirdLanguage = user.ThirdLanguage.Id,
                ThirdLanguageLevel = user.ThirdLanguageLevel.Id,
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
                InternationalPassport = user.InternationalPassport.Id,
                FilePaths = user.FilePaths
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

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditViewModel model, HttpPostedFileBase upload, ICollection<HttpPostedFileBase> files)
        {
            if (ModelState.IsValid)
            {


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
                user.FirstLanguage = DbContext.Languages.Find(model.FirstLanguage);
                user.FirstLanguageLevel = DbContext.Levels.Find(model.FirstLanguageLevel);
                user.SecondLanguage = DbContext.Languages.Find(model.SecondLanguage);
                user.SecondLanguageLevel = DbContext.Levels.Find(model.SecondLanguageLevel);
                user.ThirdLanguage = DbContext.Languages.Find(model.ThirdLanguage);
                user.ThirdLanguageLevel = DbContext.Levels.Find(model.ThirdLanguageLevel);

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

                user.Status = false;
                if (upload != null && upload.ContentLength > 0)
                {
                    if (user.FilePaths.Any(f => f.FileType == FileType.Avatar))
                    {
                        DbContext.FilePaths.Remove(user.FilePaths.First(f => f.FileType == FileType.Avatar));
                    }
                    string localFileName = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(upload.FileName);
                    string pathToSave = System.IO.Path.Combine(Server.MapPath("~/Content/Images"), localFileName);
                    var relativePath = MakeRelative(pathToSave, Server.MapPath("~"));
                    upload.SaveAs(pathToSave);
                    var avatar = new FilePath
                    {
                        FileName = localFileName,
                        PathName = relativePath,
                        FileType = FileType.Avatar
                    };
                    user.FilePaths.Add(avatar);
                }
                foreach (var file in files)
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        string extension = System.IO.Path.GetExtension(file.FileName).ToLower();
                        if (file.ContentLength < 5242880 && (extension == ".jpg" || extension == ".jpeg"))
                        {
                            string localFileName = Guid.NewGuid().ToString() + extension;
                            string pathToSave = System.IO.Path.Combine(Server.MapPath("~/Content/Images"), localFileName);
                            var relativePath = MakeRelative(pathToSave, Server.MapPath("~"));
                            file.SaveAs(pathToSave);
                            var photo = new FilePath
                            {
                                FileName = localFileName,
                                PathName = "/" + relativePath,
                                FileType = FileType.Photo
                            };
                            user.FilePaths.Add(photo);
                            string thumbnailPathName = CreateThumbnail(localFileName, 100);
                            var relativeThumbnailPath = MakeRelative(thumbnailPathName, Server.MapPath("~"));
                            var thumbnail = new FilePath
                            {
                                FileName = localFileName,
                                PathName = "/" + relativeThumbnailPath,
                                FileType = FileType.Thumbnail
                            };
                            user.FilePaths.Add(thumbnail);
                        }
                    }
                }
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
                    user.OpenPassword = model.NewPassword;
                    await UserManager.UpdateAsync(user);
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

        private string CreateThumbnail(string source, int maxSize)
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

        private static string MakeRelative(string filePath, string referencePath)
        {
            var fileUri = new Uri(filePath);
            var referenceUri = new Uri(referencePath);
            return referenceUri.MakeRelativeUri(fileUri).ToString();
        }
        #region Helpers
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