using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class HobbiesInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Футбол", "", "")},
                {2, new ViewValue(2, "Волейбол", "", "")},
                {3, new ViewValue(3, "Баскетбол", "", "")},
                {4, new ViewValue(4, "Бейсбол", "", "")},
                {5, new ViewValue(5, "Ходьба", "", "")},
                {6, new ViewValue(6, "Марафон", "", "")},
                {7, new ViewValue(7, "Езда на велосипеде", "", "")},
                {8, new ViewValue(8, "Пейнтбол", "", "")},
                {9, new ViewValue(9, "Стрельба", "", "")},
                {10, new ViewValue(10, "Формула 1", "", "")},
                {11, new ViewValue(11, "Бодибилдинг", "", "")},
                {12, new ViewValue(12, "Гольф", "", "")},
                {13, new ViewValue(13, "Верховая езда", "", "")},
                {14, new ViewValue(14, "Теннис", "", "")},
                {15, new ViewValue(15, "Настольный теннис", "", "")},
                {16, new ViewValue(16, "Бадминтон", "", "")},
                {17, new ViewValue(17, "Плавание", "", "")},
                {18, new ViewValue(18, "Дайвинг", "", "")},
                {19, new ViewValue(19, "Серфинг", "", "")},
                {20, new ViewValue(20, "Бильярд", "", "")},
                {21, new ViewValue(21, "Боулинг", "", "")},
                {22, new ViewValue(22, "Катание на коньках", "", "")},
                {23, new ViewValue(23, "Катание на лыжах", "", "")},
                {24, new ViewValue(24, "Катание на скейтборде", "", "")},
                {25, new ViewValue(25, "Альпинизм", "", "")},
                {26, new ViewValue(26, "Борьба", "", "")},
                {27, new ViewValue(27, "Бокс", "", "")},
                {28, new ViewValue(28, "Айкидо", "", "")},
                {29, new ViewValue(29, "Каратэ", "", "")},
                {30, new ViewValue(30, "Дзюдо", "", "")},
                {31, new ViewValue(31, "Рисование", "", "")},
                {32, new ViewValue(32, "Вязание", "", "")},
                {33, new ViewValue(33, "Вышивание", "", "")},
                {34, new ViewValue(34, "Фотографии", "", "")},
                {35, new ViewValue(35, "Ручная работа", "", "")},
                {36, new ViewValue(36, "Скульптурное дело", "", "")},
                {37, new ViewValue(37, "Керамическое дело", "", "")},
                {38, new ViewValue(38, "Моделирование", "", "")},
                {39, new ViewValue(39, "Игра на пианино", "", "")},
                {40, new ViewValue(40, "Игра на гитаре", "", "")},
                {41, new ViewValue(41, "Игра на саксофоне", "", "")},
                {42, new ViewValue(42, "Игра на трубе", "", "")},
                {43, new ViewValue(43, "Игра на барабанах", "", "")},
                {44, new ViewValue(44, "Игра на скрипке", "", "")},
                {45, new ViewValue(45, "Игра на флейте", "", "")},
                {46, new ViewValue(46, "Пение", "", "")},
                {47, new ViewValue(47, "Караоке", "", "")},
                {48, new ViewValue(48, "Хор", "", "")},
                {49, new ViewValue(49, "Джазовые танцы", "", "")},
                {50, new ViewValue(50, "Бальные танцы", "", "")},
                {51, new ViewValue(51, "Вальсовые танцы", "", "")},
                {52, new ViewValue(52, "Балетные танцы", "", "")},
                {53, new ViewValue(53, "Сальса", "", "")},
                {54, new ViewValue(54, "Самба", "", "")},
                {55, new ViewValue(55, "Брейк данс", "", "")},
                {56, new ViewValue(56, "DJ", "", "")},
                {57, new ViewValue(57, "Сочинять музыку", "", "")},
                {58, new ViewValue(58, "Мюзикл", "", "")},
                {59, new ViewValue(59, "Нет", "", "")}
            };
        }
    }
}