using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.IdentityModels;
using Microsoft.AspNet.Identity;

namespace Marriage_Agency_Women_.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Имя латиницей")]
        public string NameInRoman { get; set; }

        [Required]
        [Display(Name = "Дата рождения")]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Место проживания")]
        public int Location { get; set; }

        [Display(Name = "Прописка")]
        public string ResidencePermit { get; set; }

        [Required]
        [Display(Name = "Вера")]
        public int Religion { get; set; }

        [Required]
        [Display(Name = "Сфера работы")]
        public int Activity { get; set; }

        [Required]
        [Display(Name = "Должность")]
        public int Post { get; set; }

        [Required]
        [Display(Name = "Образование")]
        public int Education { get; set; }
      
        [Display(Name = "Языки")]
        public ICollection<int> Languages { get; set; }

        [Required]
        [Display(Name = "Семейное положение")]
        public int MaritalStatus { get; set; }

        [Required]
        [Display(Name = "Дети")]
        public int NumberOfChildren { get; set; }

        [Required]
        [Display(Name = "Рост")]
        public int Height { get; set; }

        [Required]
        [Display(Name = "Вес")]
        public int Weight { get; set; }

        [Required]
        [Display(Name = "Фигура")]
        public int Figure { get; set; }
       
        [Required]
        [Display(Name = "Цвет глаз")]
        public int EyeColor { get; set; }

        [Required]
        [Display(Name = "Цвет волос")]
        public int HairColor { get; set; }

        [Required]
        [Display(Name = "Курение")]
        public bool Smoking { get; set; }

        [Required]
        [Display(Name = "Алкоголь")]
        public int Alcohol { get; set; }

        [Required]
        [Display(Name = "Желанный возраст партнера")]
        public int DesiredAge { get; set; }

        [Display(Name = "Спорт, искусство и музыка")]
        public int Hobby { get; set; }
       
        [Display(Name = "Образ жизни и развлечения")]
        public int Lifestyle { get; set; }

        [Display(Name = "Еда и знания")]
        public int Knowledge { get; set; }

        // PhoneNumber из IdentityUser
        [Required]
        [Display(Name = "Номер мобильного")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

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
    }
}