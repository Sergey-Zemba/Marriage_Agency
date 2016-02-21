using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class LocationsInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Крым", "", "")},
                {2, new ViewValue(2, "Винницкая область", "", "")},
                {3, new ViewValue(3, "Волынская область", "", "")},
                {4, new ViewValue(4, "Днепропетровская область", "", "")},
                {5, new ViewValue(5, "Донецкая область", "", "")},
                {6, new ViewValue(6, "Житомирская область", "", "")},
                {7, new ViewValue(7, "Закарпатская область", "", "")},
                {8, new ViewValue(8, "Запорожская область", "", "")},
                {9, new ViewValue(9, "Ивано-Франковская область", "", "")},
                {10, new ViewValue(-10, "Киев", "", "")},
                {11, new ViewValue(11, "Киевская область", "", "")},
                {12, new ViewValue(12, "Кировоградская область", "", "")},
                {13, new ViewValue(13, "Луганская область", "", "")},
                {14, new ViewValue(14, "Львовская область", "", "")},
                {15, new ViewValue(15, "Николаевская область", "", "")},
                {16, new ViewValue(16, "Одесская область", "", "")},
                {17, new ViewValue(17, "Полтавская область", "", "")},
                {18, new ViewValue(18, "Ровенская область", "", "")},
                {19, new ViewValue(19, "Сумская область", "", "")},
                {20, new ViewValue(20, "Тернопольская область", "", "")},
                {21, new ViewValue(21, "Харьковская область", "", "")},
                {22, new ViewValue(22, "Херсонская область", "", "")},
                {23, new ViewValue(23, "Хмельницкая область", "", "")},
                {24, new ViewValue(24, "Черкасская область", "", "")},
                {25, new ViewValue(25, "Черниговская область", "", "")},
                {26, new ViewValue(26, "Черновицкая область", "", "")}
            };
        }
    }
}