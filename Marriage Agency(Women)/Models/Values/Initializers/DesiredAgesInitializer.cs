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
                {1, new ViewValue(1, "Нет", "No", "なし")},
                {2, new ViewValue(2, "До 30 лет", "Up to 30 years", "30 歳まで")},
                {3, new ViewValue(3, "До 35 лет", "Up to 35 years", "35 歳まで")},
                {4, new ViewValue(4, "До 40 лет", "Up to 40 years", "40 歳まで")},
                {5, new ViewValue(5, "До 45 лет", "Up to 45 years", "45 歳まで")},
                {6, new ViewValue(6, "До 50 лет", "Up to 50 years", "50 歳まで")},
                {7, new ViewValue(7, "До 55 лет", "Up to 55 years", "55 歳まで")},
                {8, new ViewValue(8, "До 60 лет", "Up to 60 years", "60 歳まで")}
            };
        }
    }
}