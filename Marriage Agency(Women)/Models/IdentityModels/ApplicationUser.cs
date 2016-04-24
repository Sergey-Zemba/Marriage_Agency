using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.Characteristics.Files;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Marriage_Agency_Women_.Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Дата создания анкеты")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Последний вход")]
        public DateTime LastLoginTime { get; set; }

        [Display(Name = "Пароль")]
        public string OpenPassword { get; set; }

        [Display(Name = "Номер")]
        public int Number { get; set; }

        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Имя латиницей")]
        public string NameInRoman { get; set; }

        [Display(Name = "Дата рождения")]
        [Column(TypeName = "DateTime2")]
        public DateTime Birthday { get; set; }

        [NotMapped]
        [Display(Name = "Возраст")]
        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }

        [Display(Name = "Место проживания")]
        public virtual Location Location { get; set; }

        [Display(Name = "Прописка")]
        public virtual ResidencePermit ResidencePermit { get; set; }

        [Display(Name = "Вера")]
        public virtual Religion Religion { get; set; }

        [Display(Name = "Сфера работы")]
        public virtual Activity Activity { get; set; }

        [Display(Name = "Должность")]
        public virtual Job Job { get; set; }

        [Display(Name = "Образование")]
        public virtual Education Education { get; set; }

        [Display(Name = "Первый язык")]
        public virtual Language FirstLanguage { get; set; }

        [Display(Name = "Уровень")]
        public virtual Level FirstLanguageLevel { get; set; }

        [Display(Name = "Второй язык")]
        public virtual Language SecondLanguage { get; set; }

        [Display(Name = "Уровень")]
        public virtual Level SecondLanguageLevel { get; set; }

        [Display(Name = "Третий язык")]
        public virtual Language ThirdLanguage { get; set; }

        [Display(Name = "Уровень")]
        public virtual Level ThirdLanguageLevel { get; set; }

        [Display(Name = "Семейное положение")]
        public virtual Relationship Relationship { get; set; }

        [Display(Name = "Дети")]
        public virtual NumberOfChildren NumberOfChildren { get; set; }

        [Display(Name = "Рост")]
        public int Height { get; set; }

        [Display(Name = "Вес")]
        public int Weight { get; set; }

        [Display(Name = "Фигура")]
        public virtual Shape Shape { get; set; }

        [Display(Name = "Цвет глаз")]
        public virtual EyeColor EyeColor { get; set; }

        [Display(Name = "Цвет волос")]
        public virtual HairColor HairColor { get; set; }

        [Display(Name = "Курение")]
        public virtual Smoking Smoking { get; set; }

        [Display(Name = "Алкоголь")]
        public virtual Alcohol Alcohol { get; set; }

        [Display(Name = "Желанный возраст партнера")]
        public virtual DesiredAge DesiredAge { get; set; }

        [Display(Name = "Спорт, искусство и музыка")]
        public virtual Hobby Hobby { get; set; }

        [Display(Name = "Образ жизни и развлечения")]
        public virtual Lifestyle Lifestyle { get; set; }

        [Display(Name = "Еда и знания")]
        public virtual Knowledge Knowledge { get; set; }

        [Display(Name = "Скайп")]
        public string Skype { get; set; }

        [Display(Name = "Фейсбук")]
        public string Facebook { get; set; }

        [Display(Name = "Вконтакте")]
        public string Vk { get; set; }

        [Display(Name = "Твиттер")]
        public string Twitter { get; set; }

        [Display(Name = "Загранпаспорт")]
        public virtual InternationalPassport InternationalPassport { get; set; }

        [Display(Name = "Заметки")]
        public string Notes { get; set; }

        public virtual ICollection<FilePath> FilePaths { get; set; }
        // ??
        [Display(Name = "Статус подтвержден")]
        public bool Status { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}