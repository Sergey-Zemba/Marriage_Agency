using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class DesiredAgesInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Нет", "", "")},
                {2, new ViewValue(2, "До 30 лет", "", "")},
                {3, new ViewValue(3, "До 35 лет", "", "")},
                {4, new ViewValue(4, "До 40 лет", "", "")},
                {5, new ViewValue(5, "До 45 лет", "", "")},
                {6, new ViewValue(6, "До 50 лет", "", "")},
                {7, new ViewValue(7, "До 55 лет", "", "")},
                {8, new ViewValue(8, "До 60 лет", "", "")}
            };
        }
    }
}