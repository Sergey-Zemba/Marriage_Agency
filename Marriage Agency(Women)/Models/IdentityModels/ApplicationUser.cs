using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Marriage_Agency_Women_.Models.Characteristics;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Marriage_Agency_Women_.Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {

        // Id уже есть в IdentityUser
        //public int Id { get; set; }
        [Display(Name = "Дата создания анкеты")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Последний вход")]
        public DateTime LastLoginTime { get; set; }

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
        public int ResidencePermit { get; set; }

        [Display(Name = "Вера")]
        public virtual Religion Religion { get; set; }

        [Display(Name = "Сфера работы")]
        public virtual Activity Activity { get; set; }

        [Display(Name = "Должность")]
        public virtual Job Job { get; set; }

        [Display(Name = "Образование")]
        public virtual Education Education { get; set; }

        [Display(Name = "Языки")]
        public virtual ICollection<Language> Languages { get; set; }

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
        public bool Smoking { get; set; }

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

        // PhoneNumber дублирует свойство из IdentityUser
        // public string PhoneNumber { get; set; }
        // Email уже есть в IdentityUser
        //public string Email { get; set; }

        [Display(Name = "Скайп")]
        public string Skype { get; set; }

        [Display(Name = "Фейсбук")]
        public string Facebook { get; set; }

        [Display(Name = "Вконтакте")]
        public string Vk { get; set; }

        [Display(Name = "Твиттер")]
        public string Twitter { get; set; }

        [Display(Name = "Загранпаспорт")]
        public bool InternationalPassport { get; set; }

        // ??
        [Display(Name = "Статус")]
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