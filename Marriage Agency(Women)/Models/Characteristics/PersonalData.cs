using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Characteristics
{
    public abstract class PersonalData
    {
        public PersonalData()
        {
            
        }
        public PersonalData(int position, string russian, string english, string japanese)
        {
            Position = position;
            RussianName = russian;
            EnglishName = english;
            JapaneseName = japanese;
        }
        

        public int Id { get; set; }
        public int Position { get; set; }
        public string RussianName { get; set; }
        public string EnglishName { get; set; }
        public string JapaneseName { get; set; }
    }
}