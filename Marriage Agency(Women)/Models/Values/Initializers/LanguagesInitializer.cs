using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class LanguagesInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Английский", "", "")},
                {2, new ViewValue(2, "Китайский", "", "")},
                {3, new ViewValue(3, "Японский", "", "")},
                {4, new ViewValue(4, "Испанский", "", "")},
                {5, new ViewValue(5, "Немецкий", "", "")},
                {6, new ViewValue(6, "Французский", "", "")},
                {7, new ViewValue(7, "Итальянский", "", "")},
                {8, new ViewValue(8, "Португальский", "", "")},
                {9, new ViewValue(9, "Турецкий", "", "")},
                {10, new ViewValue(10, "Арабский", "", "")},
                {11, new ViewValue(11, "Корейский", "", "")},
                {12, new ViewValue(12, "Бенгальский", "", "")},
                {13, new ViewValue(13, "Хинди", "", "")},
                {14, new ViewValue(14, "Яванский", "", "")},
                {15, new ViewValue(15, "Вьетнамский", "", "")},
                {16, new ViewValue(16, "Урду", "", "")},
                {17, new ViewValue(17, "Панджаби", "", "")},
                {18, new ViewValue(18, "Гуджарати", "", "")},
                {19, new ViewValue(19, "Тайский", "", "")},
                {20, new ViewValue(20, "Польский", "", "")},
                {21, new ViewValue(21, "Малаялам", "", "")},
                {22, new ViewValue(22, "Бирманский", "", "")},
                {23, new ViewValue(23, "Азербайджанский", "", "")},
                {24, new ViewValue(24, "Персидский", "", "")},
                {25, new ViewValue(25, "Румынский", "", "")},
                {26, new ViewValue(26, "Майтхили", "", "")},
                {27, new ViewValue(27, "Сербохорватский", "", "")},
                {28, new ViewValue(28, "Узбекский", "", "")},
                {29, new ViewValue(29, "Йоруба", "", "")},
                {30, new ViewValue(30, "Нидерландский", "", "")},
                {31, new ViewValue(31, "Синдхи", "", "")},
                {32, new ViewValue(32, "Индонезийский", "", "")},
                {33, new ViewValue(33, "Тагальский", "", "")},
                {34, new ViewValue(34, "Непальский", "", "")},
                {35, new ViewValue(35, "Ассамский", "", "")},
                {36, new ViewValue(36, "Венгерский", "", "")},
                {37, new ViewValue(37, "Сингальский", "", "")},
                {38, new ViewValue(38, "Греческий", "", "")},
                {39, new ViewValue(39, "Чешский", "", "")}
            };
        }
    }
}