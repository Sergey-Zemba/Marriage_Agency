using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values
{
    public class ViewValue
    {
        public ViewValue() { }

        public ViewValue(int position, string russian = "", string english = "", string japanese = "")
        {
            Position = position;
            Russian = russian;
            English = english;
            Japanese = japanese;
        }
        public string Russian { get; set; }
        public string English { get; set; }
        public string Japanese { get; set; }
        public int Position { get; set; }
    }
}