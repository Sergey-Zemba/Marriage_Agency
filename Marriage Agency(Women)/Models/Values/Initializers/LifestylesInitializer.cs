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
                {1, new ViewValue(1, "Йога", "Yoga", "ヨガ")},
                {2, new ViewValue(2, "Проводить время с питомцами", "Spending time with pets", "ペット飼育")},
                {3, new ViewValue(3, "Шоппинг", "Shopping", "ショッピング")},
                {4, new ViewValue(4, "Интеренет шоппинг", "Internet shopping", "ネットショッピング")},
                {5, new ViewValue(5, "Мода", "Fashion", "ファッション")},
                {6, new ViewValue(6, "Макияж", "Makeup", "メイク")},
                {7, new ViewValue(7, "Заниматься интерьером", "Interior Design", "インテリア")},
                {8, new ViewValue(8, "Путешествия за границу", "Foreign tour", "海外旅行")},
                {9, new ViewValue(9, "Загорать", "Sunbathe", "日焼け")},
                {10, new ViewValue(10, "Садоводство", "Gardening", "ガーデニング")},
                {11, new ViewValue(11, "Рыбалка", "Fishing", "釣り")},
                {12, new ViewValue(12, "Лотереи", "Lottery", "宝くじ")},
                {13, new ViewValue(13, "Гадание", "Fortune-telling", "占い")},
                {14, new ViewValue(14, "Интернет", "Internet", "インターネット")},
                {15, new ViewValue(15, "Аниме", "Anime", "アニメ")},
                {16, new ViewValue(16, "Онлайн-игры", "Online games", "オンラインゲーム")},
                {17, new ViewValue(17, "Компьютерные игры", "Computer games", "コンピューターゲーム")},
                {18, new ViewValue(18, "Шахматы", "Chess", "チェス")},
                {19, new ViewValue(19, "Карточные игры", "Card games", "トランプ")},
                {20, new ViewValue(20, "Настольные игры", "Board games", "ボードゲーム")},
                {21, new ViewValue(21, "Фокусы", "Magic", "マジック")},
                {22, new ViewValue(22, "Общение", "Communication", "コミュニケーション")},
                {23, new ViewValue(23, "Ходить в поход", "Camping", "キャンプ")},
                {24, new ViewValue(24, "Кататься на авто", "Drive", "ドライブ")},
                {25, new ViewValue(25, "Волонтёрство", "Volunteering", "ボランティア")},
                {26, new ViewValue(26, "Посещать семинары", "Seminars", "セミナー")},
                {27, new ViewValue(27, "Ходить в аквариум", "Going to the aquarium", "水族館")},
                {28, new ViewValue(28, "Ходить в зоопарк", "Going to the zoo", "動物園")},
                {29, new ViewValue(29, "Ходить на концерты", "Going to concerts", "コンサート")},
                {30, new ViewValue(30, "Смотреть сериалы", "Watch TV shows", "ドラマ鑑賞")},
                {31, new ViewValue(31, "Смотреть кино", "Watch movies", "映画鑑賞")},
                {32, new ViewValue(32, "Слушать музыку", "Listen music", "音楽鑑賞")},
                {33, new ViewValue(33, "Юмор", "Humor", "お笑い")},
                {34, new ViewValue(34, "Коллекционирование", "Collecting", "収集")},
                {35, new ViewValue(35, "История", "History", "歴史")},
                {36, new ViewValue(36, "Железная дорога и поезда", "Railroad and train", "鉄道")},
                {37, new ViewValue(37, "Астрономия", "Astronomy", "天文学")},
                {38, new ViewValue(38, "Сон", "Sleep", "睡眠")},
                {39, new ViewValue(39, "Уборка", "Cleaning", "整理整頓")},
                {40, new ViewValue(40, "Проводить время с семьей", "Spend time with family", "家族と過ごす")},
                {41, new ViewValue(41, "Нет", "No", "なし")}
            };
        }
    }
}