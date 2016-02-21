﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class HairColorsInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Тёмные", "", "")},
                {2, new ViewValue(2, "Каштановые", "", "")},
                {3, new ViewValue(3, "Светлые", "", "")},
                {4, new ViewValue(4, "Рыжие", "", "")}
            };
        }
    }
}