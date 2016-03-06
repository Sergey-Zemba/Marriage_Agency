using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.Characteristics;

namespace Marriage_Agency_Women_.Models.SharedViewModels
{
    public class BaseViewModel
    {
        private const string PhoneNumberRegexp =
            @"^0(?:(?:39)|(?:50)|(?:63)|(?:66)|(?:67)|(?:68)|(?:91)|(?:92)|(?:93)|(?:94)|(?:95)|(?:96)|(?:97)|(?:98)|(?:99))\d{7}$";

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [RegularExpression(@"^[а-яіїєґА-ЯІЇЄҐ\-\s]{3,}$", ErrorMessage = "Поле должно содержать только русские или украинские буквы")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [RegularExpression(@"^[а-яіїєґА-ЯІЇЄҐ\-\s]{3,}$", ErrorMessage = "Поле должно содержать только русские или украинские буквы")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле {0} является обязательным")]
        [RegularExpression(@"^[A-z\s]{1,}$", ErrorMessage = "Поле должно содержать только латинские буквы")]
        [Display(Name = "Имя латиницей")]
        public string NameInRoman { get; set; }

        [Required]
        [Display(Name = "Дата рождения")]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Место проживания")]
        public Location Location { get; set; }

        [Required]
        [Display(Name = "Вера")]
        public Religion Religion { get; set; }

        [Required]
        [Display(Name = "Сфера работы")]
        public Activity Activity { get; set; }

        [Required]
        [Display(Name = "Должность")]
        public Job Job { get; set; }

        [Required]
        [Display(Name = "Образование")]
        public Education Education { get; set; }

        [Display(Name = "Языки")]
        public ICollection<Language> Languages { get; set; }

        [Required]
        [Display(Name = "Семейное положение")]
        public Relationship Relationship { get; set; }

        [Required]
        [Display(Name = "Дети")]
        public NumberOfChildren NumberOfChildren { get; set; }

        [Required]
        [Range(140, 200, ErrorMessage = "Значение должно быть в пределах от {1} до {2}")]
        [Display(Name = "Рост")]
        public int Height { get; set; }

        [Required]
        [Range(40, 100, ErrorMessage = "Значение должно быть в пределах от {1} до {2}")]
        [Display(Name = "Вес")]
        public int Weight { get; set; }

        [Required]
        [Display(Name = "Фигура")]
        public Shape Shape { get; set; }

        [Required]
        [Display(Name = "Цвет глаз")]
        public EyeColor EyeColor { get; set; }

        [Required]
        [Display(Name = "Цвет волос")]
        public HairColor HairColor { get; set; }

        [Required]
        [Display(Name = "Курение")]
        public Smoking Smoking { get; set; }

        [Required]
        [Display(Name = "Алкоголь")]
        public Alcohol Alcohol { get; set; }

        [Required]
        [Display(Name = "Желанный возраст партнера")]
        public DesiredAge DesiredAge { get; set; }

        [Display(Name = "Спорт, искусство и музыка")]
        public Hobby Hobby { get; set; }

        [Display(Name = "Образ жизни и развлечения")]
        public Lifestyle Lifestyle { get; set; }

        [Display(Name = "Еда и знания")]
        public Knowledge Knowledge { get; set; }

        // PhoneNumber из IdentityUser
        [Required]
        [RegularExpression(PhoneNumberRegexp, ErrorMessage = "Номер телефона указан в неверном формате")]
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
        public InternationalPassport InternationalPassport { get; set; }
    }
}