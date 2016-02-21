using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class LifestylesInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Йога", "", "")},
                {2, new ViewValue(2, "Проводить время с питомцами", "", "")},
                {3, new ViewValue(3, "Шоппинг", "", "")},
                {4, new ViewValue(4, "Интеренет шоппинг", "", "")},
                {5, new ViewValue(5, "Мода", "", "")},
                {6, new ViewValue(6, "Макияж", "", "")},
                {7, new ViewValue(7, "Заниматься интерьером", "", "")},
                {8, new ViewValue(8, "Путешествия за границу", "", "")},
                {9, new ViewValue(9, "Загорать", "", "")},
                {10, new ViewValue(10, "Садоводство", "", "")},
                {11, new ViewValue(11, "Рыбалка", "", "")},
                {12, new ViewValue(12, "Лотереи", "", "")},
                {13, new ViewValue(13, "Гадание", "", "")},
                {14, new ViewValue(14, "Интернет", "", "")},
                {15, new ViewValue(15, "Аниме", "", "")},
                {16, new ViewValue(16, "Онлайн-игры", "", "")},
                {17, new ViewValue(17, "Компьютерные игры", "", "")},
                {18, new ViewValue(18, "Шахматы", "", "")},
                {19, new ViewValue(19, "Карточные игры", "", "")},
                {20, new ViewValue(20, "Настольные игры", "", "")},
                {21, new ViewValue(21, "Фокусы", "", "")},
                {22, new ViewValue(22, "Общение", "", "")},
                {23, new ViewValue(23, "Ходить в поход", "", "")},
                {24, new ViewValue(24, "Кататься на авто", "", "")},
                {25, new ViewValue(25, "Волонтёрство", "", "")},
                {26, new ViewValue(26, "Посещать семинары", "", "")},
                {27, new ViewValue(27, "Ходить в аквариум", "", "")},
                {28, new ViewValue(28, "Ходить в зоопарк", "", "")},
                {29, new ViewValue(29, "Ходить на концерты", "", "")},
                {30, new ViewValue(30, "Смотреть сериалы", "", "")},
                {31, new ViewValue(31, "Смотреть кино", "", "")},
                {32, new ViewValue(32, "Слушать музыку", "", "")},
                {33, new ViewValue(33, "Юмор", "", "")},
                {34, new ViewValue(34, "Коллекционирование", "", "")},
                {35, new ViewValue(35, "История", "", "")},
                {36, new ViewValue(36, "Железная дорога и поезда", "", "")},
                {37, new ViewValue(37, "Астрономия", "", "")},
                {38, new ViewValue(38, "Сон", "", "")},
                {39, new ViewValue(39, "Уборка", "", "")},
                {40, new ViewValue(40, "Проводить время с семьей", "", "")},
                {41, new ViewValue(41, "Нет", "", "")}
            };
        }
    }
}