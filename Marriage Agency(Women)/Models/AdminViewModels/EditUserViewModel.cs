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
        [Required]
        [Display(Name = "Номер анкеты")]
        public int Number { get; set; }

        [Required]
        [Display(Name = "Прописка")]
        public int ResidencePermit { get; set; }
    }
}