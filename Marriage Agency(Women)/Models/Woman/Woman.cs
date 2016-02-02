using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Woman
{
    public class Woman
    {
        public bool Status { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Nationality { get; set; }
        public Religion Religion { get; set; }
        public string Job { get; set; }
        public Education Education { get; set; }
        public List<Language> Languages { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int NumberOfChildren { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public EyeColor EyeColor { get; set; }
        public HairColor HairColor { get; set; }
        public bool Smoking { get; set; }
        public bool Alcohol { get; set; }
        public int DesiredAge { get; set; }
        public string Hobby { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string Vk { get; set; }
        public string Twitter { get; set; }
        public bool InternationalPassport { get; set; }
    }
}