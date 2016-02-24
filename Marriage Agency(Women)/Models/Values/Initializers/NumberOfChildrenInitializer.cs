using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class NumberOfChildrenInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
             dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Нет", "No", "なし")},
                {2, new ViewValue(2, "Один", "One", "1 人")},
                {3, new ViewValue(3, "Двое", "Two", "2 人")},
                {4, new ViewValue(4, "Трое", "Three", "3 人")},
                {5, new ViewValue(5, "Более трех", "More than three", "3 人以上")}
             
            };
        }
    }
}