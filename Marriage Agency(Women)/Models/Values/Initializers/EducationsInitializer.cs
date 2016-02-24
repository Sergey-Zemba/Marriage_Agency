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
                {1, new ViewValue(1, "Аспирантура", "Graduate school", "")},
                {2, new ViewValue(2, "Университет", "University", "大学")},
                {3, new ViewValue(3, "ПТУ", "Vocational school", "専門学校")},
                {4, new ViewValue(4, "Средняя школа", "High school", "高等学校")},
                {5, new ViewValue(5, "Учусь", "Student", "在学中")}
            };
        }
    }
}