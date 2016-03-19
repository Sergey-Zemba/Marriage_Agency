using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Marriage_Agency_Women_.Models.IdentityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Marriage_Agency_Women_.Controllers
{
    [Authorize(Roles = "admin,superadmin,editor")]
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
            List<ApplicationUser> users = GetUsersInRole("user");
            List<ApplicationUser> admins = GetUsersInRole("admin");

            ViewBag.admins = admins;
            return View(users);
        }

        public FileContentResult GetExcel()
        {
            List<ApplicationUser> users = GetUsersInRole("user");

            ExcelPackage package = GenerateExcelFile(users);

            string fileDownloadName = "Users.xlsx";
            const string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return new FileContentResult(package.GetAsByteArray(), contentType)
            {
                FileDownloadName = fileDownloadName
            };
        }

        private ExcelPackage GenerateExcelFile(List<ApplicationUser> dataSource)
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
                ws.Cells[i + 2, 5].Value = dataSource.ElementAt(i).Birthday.ToLongDateString();
                ws.Cells[i + 2, 6].Value = dataSource.ElementAt(i).Age;
                ws.Cells[i + 2, 7].Value = dataSource.ElementAt(i).PhoneNumber;
                ws.Cells[i + 2, 8].Value = dataSource.ElementAt(i).Email;
                ws.Cells[i + 2, 9].Value = dataSource.ElementAt(i).OpenPassword;
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

                if (dataSource.ElementAt(i).Status == true)
                {
                    ws.Cells[i + 2, 38].Value = "Подтвержден";
                }
                else
                {
                    ws.Cells[i + 2, 38].Value = "Не подтвержден";
                }
                
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

        private List<ApplicationUser> GetUsersInRole(string roleName)
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            IdentityUserRole userRole = RoleManager.FindByName(roleName).Users.FirstOrDefault();
            if (userRole != null)
            {
                users = UserManager.Users.Where(u => u.Roles.Select(r => r.RoleId).Contains(userRole.RoleId)).ToList();
            }

            return users;
        } 
        #endregion
    }
}