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
                {1, new ViewValue(1, "Кулинария", "Cooking", "料理")},
                {2, new ViewValue(2, "Кондитерские изделия", "Pastry making", "お菓子作り")},
                {3, new ViewValue(3, "Прогулка по ресторанам", "Eating tour", "食べ歩き")},
                {4, new ViewValue(4, "Кафе-тур", "Cafe Tours", "カフェめぐり")},
                {5, new ViewValue(5, "Чай", "Tea", "紅茶")},
                {6, new ViewValue(6, "Кофе", "Coffee", "コーヒー")},
                {7, new ViewValue(7, "Коктейли", "Cocktails", "カクテル")},
                {8, new ViewValue(8, "Духи", "Perfumes", "香水")},
                {9, new ViewValue(9, "Поэзия", "Poetry", "詩")},
                {10, new ViewValue(10, "Чтение", "Reading", "読書")},
                {11, new ViewValue(11, "Писание", "Writing", "執筆")},
                {12, new ViewValue(12, "Массаж", "Massage", "マッサージ")},
                {13, new ViewValue(13, "Медитация", "Meditation", "瞑想")},
                {14, new ViewValue(14, "Изучение языков", "Language Learning", "語学")},
                {15, new ViewValue(15, "Тренировка мозга", "Brain Workout", "脳力トレーニング")},
                {16, new ViewValue(16, "Форекс", "Forex", "FX取引")},
                {17, new ViewValue(17, "Изобретения", "Invention", "発明")},
                {18, new ViewValue(18, "Отгадывать загадки", "Riddles", "クイズ")},
                {19, new ViewValue(19, "Приобретение квалификации", "Qualification acquisition", "資格取得")},
                {20, new ViewValue(20, "Физика", "Physics", "物理学")},
                {21, new ViewValue(21, "Психология", "Psychology", "心理学")},
                {22, new ViewValue(22, "Программирование", "Programming", "プログラミング")},
                {23, new ViewValue(23, "3D графика", "3D graphics", "3Dグラフィック")},
                {24, new ViewValue(24, "Радиоконструктор", "Radio constructor", "電子工作")},
                {25, new ViewValue(25, "Роботы", "Robots", "ロボット")},
                {26, new ViewValue(26, "Косплей", "Cosplay", "コスプレ")},
                {27, new ViewValue(27, "Динозавры", "Dinosaurs", "恐竜")},
                {28, new ViewValue(28, "Военное дело", "Military", "軍事")},
                {29, new ViewValue(29, "Посещать заседания судов", "Court hearing", "裁判傍聴")},
                {30, new ViewValue(30, "НЛО", "UFO", "UFO")},
                {31, new ViewValue(31, "Нет", "No", "なし")}
            };
        }
    }
}