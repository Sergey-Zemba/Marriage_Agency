﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Characteristics
{
    public class Activity : PersonalData
    {
        public Activity() : base()
        {
            
        }
        public Activity(int position, string russian, string english, string japanese) : base(position, russian, english, japanese)
        {
        }
    }
}