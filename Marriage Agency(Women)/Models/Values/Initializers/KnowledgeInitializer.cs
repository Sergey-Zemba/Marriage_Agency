using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class KnowledgeInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
           dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Кулинария", "", "")},
                {2, new ViewValue(2, "Кондитерские изделия", "", "")},
                {3, new ViewValue(3, "Прогулка по ресторанам", "", "")},
                {4, new ViewValue(4, "Кафе-тур", "", "")},
                {5, new ViewValue(5, "Чай", "", "")},
                {6, new ViewValue(6, "Кофе", "", "")},
                {7, new ViewValue(7, "Коктейли", "", "")},
                {8, new ViewValue(8, "Духи", "", "")},
                {9, new ViewValue(9, "Поэзия", "", "")},
                {10, new ViewValue(10, "Чтение", "", "")},
                {11, new ViewValue(11, "Писание", "", "")},
                {12, new ViewValue(12, "Массаж", "", "")},
                {13, new ViewValue(13, "Медитация", "", "")},
                {14, new ViewValue(14, "Изучение языков", "", "")},
                {15, new ViewValue(15, "Тренировка мозга", "", "")},
                {16, new ViewValue(16, "Форекс", "", "")},
                {17, new ViewValue(17, "Изобретения", "", "")},
                {18, new ViewValue(18, "Отгадывать загадки", "", "")},
                {19, new ViewValue(19, "Приобретение квалификации", "", "")},
                {20, new ViewValue(20, "Физика", "", "")},
                {21, new ViewValue(21, "Психология", "", "")},
                {22, new ViewValue(22, "Программирование", "", "")},
                {23, new ViewValue(23, "3D графика", "", "")},
                {24, new ViewValue(24, "Радиоконструктор", "", "")},
                {25, new ViewValue(25, "Роботы", "", "")},
                {26, new ViewValue(26, "Косплей", "", "")},
                {27, new ViewValue(27, "Динозавры", "", "")},
                {28, new ViewValue(28, "Военное дело", "", "")},
                {29, new ViewValue(29, "Посещать заседания судов", "", "")},
                {30, new ViewValue(30, "НЛО", "", "")},
                {31, new ViewValue(31, "Нет", "", "")}
            };
        }
    }
}