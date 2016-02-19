using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.IdentityModels
{
    public class AccountsInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            DropdownValuesProvider values = new DropdownValuesProvider();
            IDictionary<int, string> languages = values.Languages;
            ICollection<Language> dbLanguages = new List<Language>();

            foreach (KeyValuePair<int, string> keyValue in languages)
            {
                dbLanguages.Add(new Language(keyValue.Key));
            }
            context.Languages.AddRange(dbLanguages);
            base.Seed(context);
        }
    }
}