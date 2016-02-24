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
                {1, new ViewValue(1, "Аграрная промышленность", "Agricultural", "農林水産業")},
                {2, new ViewValue(2, "Горная промышленность", "Mining industry", "鉱業")},
                {3, new ViewValue(3, "Строительство", "Construction industry ", "建設業 ")},
                {4, new ViewValue(4, "Производство", "Manufacturing industry", "製造業 ")},
                {5, new ViewValue(5, "Продажи", "Retail business", "小売業")},
                {6, new ViewValue(6, "Ресторанный бизнес", "Restaurant business", "飲食業")},
                {7, new ViewValue(7, "Финансы", "Finance industry", "金融業")},
                {8, new ViewValue(8, "Страхование", "Insurance industry", "保険業")},
                {9, new ViewValue(9, "Недвижемость", "Real estate business", "不動産業 ")},
                {10, new ViewValue(10, "Логистика", "Transportation industry", "運輸業")},
                {11, new ViewValue(11, "Связь", "Telecommunications industry", "通信業 ")},
                {12, new ViewValue(12, "Наука", "Science", "学術")},
                {13, new ViewValue(13, "Искусство и культура", "Arts & Culture", "文化芸術")},
                {14, new ViewValue(14, "IT", "IT", "IT業")},
                {15, new ViewValue(15, "Образование", "Education", "教育")},
                {16, new ViewValue(16, "Сервис", "Service industry", "サービス業")},
                {17, new ViewValue(17, "Государственный сектор", "Public sector", "官業")},
                {18, new ViewValue(18, "Другое", "Оther", "その他")}
            };
        }
    }
}