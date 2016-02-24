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
                {1, new ViewValue(1, "Голубые", "Blue", "青色")},
                {2, new ViewValue(2, "Серые", "Gray", "灰色")},
                {3, new ViewValue(3, "Зеленые", "Green", "緑色")},
                {4, new ViewValue(4, "Светло-коричневые", "Hazel", "淡褐色")},
                {5, new ViewValue(5, "Темно-коричневые", "Brown", "濃褐色")}
            };
        }
    }
}