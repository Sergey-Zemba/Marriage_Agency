using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class ActivitiesInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Аграрная промышленность", "", "")},
                {2, new ViewValue(2, "Горная промышленность", "", "")},
                {3, new ViewValue(3, "Строительство", "", "")},
                {4, new ViewValue(4, "Производство", "", "")},
                {5, new ViewValue(5, "Продажи", "", "")},
                {6, new ViewValue(6, "Ресторанный бизнес", "", "")},
                {7, new ViewValue(7, "Финансы", "", "")},
                {8, new ViewValue(8, "Страхование", "", "")},
                {9, new ViewValue(9, "Недвижемость", "", "")},
                {10, new ViewValue(10, "Логистика", "", "")},
                {11, new ViewValue(11, "Связь", "", "")},
                {12, new ViewValue(12, "Наука", "", "")},
                {13, new ViewValue(13, "Искусство и культура", "", "")},
                {14, new ViewValue(14, "IT", "", "")},
                {15, new ViewValue(15, "Образование", "", "")},
                {16, new ViewValue(16, "Сервис", "", "")},
                {17, new ViewValue(17, "Государственный сектор", "", "")},
                {18, new ViewValue(18, "Другое", "", "")}
            };
        }
    }
}