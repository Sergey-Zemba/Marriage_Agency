using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.AccountViewModels;
using Marriage_Agency_Women_.Models.SharedViewModels;
using Microsoft.AspNet.Identity;

namespace Marriage_Agency_Women_.Models.ManageViewModels
{
    public class EditViewModel : BaseViewModel
    {
        public bool HasPassword { get; set; }
    }
}