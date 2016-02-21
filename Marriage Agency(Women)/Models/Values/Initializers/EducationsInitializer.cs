using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class EducationsInitializer : IValuesInitializer
    {

        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Аспирантура", "", "")},
                {2, new ViewValue(2, "Университет", "", "")},
                {3, new ViewValue(3, "ПТУ", "", "")},
                {4, new ViewValue(4, "Средняя школа", "", "")},
                {5, new ViewValue(5, "Учусь", "", "")}
            };
        }
    }
}