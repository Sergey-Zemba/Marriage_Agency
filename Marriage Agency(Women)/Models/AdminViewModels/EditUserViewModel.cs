using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.SharedViewModels;

namespace Marriage_Agency_Women_.Models.AdminViewModels
{
    public class EditUserViewModel : BaseViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Номер анкеты")]
        public int Number { get; set; }

        [Required]
        [Display(Name = "Прописка")]
        public int ResidencePermit { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Статус подтвержден")]
        public bool Status { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Email подтвержден")]
        public bool EmailConfirmed { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Дата создания")]
        public DateTime CreationDate { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Последняя активность")]
        public DateTime LastLoginTime { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Пароль")]
        public string OpenPassword { get; set; }

        [Required]
        [Display(Name = "Заметки")]
        public string Notes { get; set; }
    }
}