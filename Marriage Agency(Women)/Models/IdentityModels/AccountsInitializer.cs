using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.Values;

namespace Marriage_Agency_Women_.Models.IdentityModels
{
    public class AccountsInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Values.Values values = new Values.Values();
            IDictionary<int, ViewValue> languages = values.Languages;
            ICollection<Language> dbLanguages = new List<Language>();

            foreach (KeyValuePair<int, ViewValue> keyValue in languages)
            {
                dbLanguages.Add(new Language(keyValue.Key));
            }
            context.Languages.AddRange(dbLanguages);
            base.Seed(context);
        }
    }
}