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
                {1, new ViewValue(1, "Футбол", "Football", "サッカー")},
                {2, new ViewValue(2, "Волейбол", "Volleyball", "バレーボール")},
                {3, new ViewValue(3, "Баскетбол", "Basketball", "バスケットボール")},
                {4, new ViewValue(4, "Бейсбол", "Baseball", "野球")},
                {5, new ViewValue(5, "Ходьба", "Walking", "ウォーキング")},
                {6, new ViewValue(6, "Марафон", "Marathon", "マラソン")},
                {7, new ViewValue(7, "Езда на велосипеде", "Bicycling", "サイクリング")},
                {8, new ViewValue(8, "Пейнтбол", "Paintball", "ペイントボール")},
                {9, new ViewValue(9, "Стрельба", "Shooting", "射撃")},
                {10, new ViewValue(10, "Формула 1", "F1", "F1")},
                {11, new ViewValue(11, "Бодибилдинг", "Body-building", "ボディビルディング")},
                {12, new ViewValue(12, "Гольф", "Golf", "ゴルフ")},
                {13, new ViewValue(13, "Верховая езда", "Horseback riding", "乗馬")},
                {14, new ViewValue(14, "Теннис", "Tennis", "テニス")},
                {15, new ViewValue(15, "Настольный теннис", "Table tennis", "卓球")},
                {16, new ViewValue(16, "Бадминтон", "Badminton", "バドミントン")},
                {17, new ViewValue(17, "Плавание", "Swimming", "水泳")},
                {18, new ViewValue(18, "Дайвинг", "Diving", "ダイビング")},
                {19, new ViewValue(19, "Серфинг", "Surfing", "サーフィン")},
                {20, new ViewValue(20, "Бильярд", "Billiards", "ビリヤード")},
                {21, new ViewValue(21, "Боулинг", "Bowling", "ボウリング")},
                {22, new ViewValue(22, "Катание на коньках", "Skating", "アイススケート")},
                {23, new ViewValue(23, "Катание на лыжах", "Skiing", "スキー")},
                {24, new ViewValue(24, "Катание на скейтборде", "Skateboarding", "スケートボード")},
                {25, new ViewValue(25, "Альпинизм", "Mountaineering", "登山")},
                {26, new ViewValue(26, "Борьба", "Wrestling", "レスリング")},
                {27, new ViewValue(27, "Бокс", "Boxing", "ボクシング")},
                {28, new ViewValue(28, "Айкидо", "Aikido", "合気道")},
                {29, new ViewValue(29, "Каратэ", "Karate", "空手")},
                {30, new ViewValue(30, "Дзюдо", "Judo", "柔道")},
                {31, new ViewValue(31, "Рисование", "Painting", "絵画")},
                {32, new ViewValue(32, "Вязание", "Knitting", "編み物")},
                {33, new ViewValue(33, "Вышивание", "Crocheting", "刺繍")},
                {34, new ViewValue(34, "Фотографии", "Photos", "写真")},
                {35, new ViewValue(35, "Ручная работа", "Handicraft", "手芸")},
                {36, new ViewValue(36, "Скульптурное дело", "Carving", "彫刻")},
                {37, new ViewValue(37, "Керамическое дело", "Pottery", "陶芸")},
                {38, new ViewValue(38, "Моделирование", "Modeling", "模型")},
                {39, new ViewValue(39, "Игра на пианино", "Play the piano", "ピアノ")},
                {40, new ViewValue(40, "Игра на гитаре", "Play the guitar", "ギター")},
                {41, new ViewValue(41, "Игра на саксофоне", "Play the  saxophone", "サックス")},
                {42, new ViewValue(42, "Игра на трубе", "Play the  trumpet", "トランペット")},
                {43, new ViewValue(43, "Игра на барабанах", "Play the  drums", "ドラム")},
                {44, new ViewValue(44, "Игра на скрипке", "Play the violin", "バイオリン")},
                {45, new ViewValue(45, "Игра на флейте", "Play the flute", "フルート")},
                {46, new ViewValue(46, "Пение", "Singing", "歌")},
                {47, new ViewValue(47, "Караоке", "Karaoke", "カラオケ")},
                {48, new ViewValue(48, "Хор", "Singing in a choir", "合唱")},
                {49, new ViewValue(49, "Джазовые танцы", "Jazz dance", "ジャズダンス")},
                {50, new ViewValue(50, "Бальные танцы", "Ballroom dance", "社交ダンス")},
                {51, new ViewValue(51, "Вальсовые танцы", "Waltz dance", "ワルツ")},
                {52, new ViewValue(52, "Балетные танцы", "Ballet dance", "バレエ")},
                {53, new ViewValue(53, "Сальса", "Salsa", "サルサ")},
                {54, new ViewValue(54, "Самба", "Samba", "ズンバ")},
                {55, new ViewValue(55, "Брейк данс", "Brakedance", "ブレイクダンス")},
                {56, new ViewValue(56, "DJ", "DJ", "DJ")},
                {57, new ViewValue(57, "Сочинять музыку", "Compose music", "作曲")},
                {58, new ViewValue(58, "Мюзикл", "Musical", "ミュージカル")},
                {59, new ViewValue(59, "Нет", "No", "なし")}
            };
        }
    }
}