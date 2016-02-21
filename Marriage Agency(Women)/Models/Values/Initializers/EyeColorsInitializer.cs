using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class EyeColorsInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Голубые", "", "")},
                {2, new ViewValue(2, "Серые", "", "")},
                {3, new ViewValue(3, "Зеленые", "", "")},
                {4, new ViewValue(4, "Светло-коричневые", "", "")},
                {5, new ViewValue(5, "Темно-коричневые", "", "")}
            };
        }
    }
}