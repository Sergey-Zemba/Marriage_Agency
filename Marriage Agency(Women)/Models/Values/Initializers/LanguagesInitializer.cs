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
                {1, new ViewValue(1, "Английский", "English", "英語")},
                {2, new ViewValue(2, "Китайский", "Chinese", "中国語")},
                {3, new ViewValue(3, "Японский", "Japanese", "日本語")},
                {4, new ViewValue(4, "Испанский", "Spanish", "スペイン語")},
                {5, new ViewValue(5, "Немецкий", "German", "ドイツ語")},
                {6, new ViewValue(6, "Французский", "French", "フランス語")},
                {7, new ViewValue(7, "Итальянский", "Italian", "イタリア語")},
                {8, new ViewValue(8, "Португальский", "Portuguese", "ポルトガル語")},
                {9, new ViewValue(9, "Турецкий", "Turkish", "トルコ語")},
                {10, new ViewValue(10, "Арабский", "Arabic", "アラビア語")},
                {11, new ViewValue(11, "Корейский", "Korean", "韓国語")},
                {12, new ViewValue(12, "Бенгальский", "Bengali", "ベンガル語")},
                {13, new ViewValue(13, "Хинди", "Hindi", "ヒンディー語")},
                {14, new ViewValue(14, "Яванский", "Javanese", "ジャワ語")},
                {15, new ViewValue(15, "Вьетнамский", "Vietnamese", "ベトナム語")},
                {16, new ViewValue(16, "Урду", "Urdu", "ウルドゥー語")},
                {17, new ViewValue(17, "Панджаби", "Punjabi", "パンジャブ語")},
                {18, new ViewValue(18, "Гуджарати", "Gujarati", "グジャラート語")},
                {19, new ViewValue(19, "Тайский", "Thai", "タイ語")},
                {20, new ViewValue(20, "Польский", "Polish", "ポーランド語")},
                {21, new ViewValue(21, "Малаялам", "Malayalam", "マラヤーラム語")},
                {22, new ViewValue(22, "Бирманский", "Burmese", "ビルマ語")},
                {23, new ViewValue(23, "Азербайджанский", "Azerbaijani", "アゼルバイジャン語")},
                {24, new ViewValue(24, "Персидский", "Persian", "ペルシア語")},
                {25, new ViewValue(25, "Румынский", "Romanian", "ルーマニア語")},
                {26, new ViewValue(26, "Майтхили", "Maithili", "マイティリー語")},
                {27, new ViewValue(27, "Сербохорватский", "Serbo-Croatian", "セルボクロアチア語")},
                {28, new ViewValue(28, "Узбекский", "Uzbek", "ウズベク語")},
                {29, new ViewValue(29, "Йоруба", "Yoruba", "ヨルバ語")},
                {30, new ViewValue(30, "Нидерландский", "Dutch", "オランダ語")},
                {31, new ViewValue(31, "Синдхи", "Sindhi", "シンド語")},
                {32, new ViewValue(32, "Индонезийский", "Indonesian", "インドネシア語")},
                {33, new ViewValue(33, "Тагальский", "Tagalog", "タガログ語")},
                {34, new ViewValue(34, "Непальский", "Nepali", "ネパール語")},
                {35, new ViewValue(35, "Ассамский", "Assamese", "アッサム語")},
                {36, new ViewValue(36, "Венгерский", "Hungarian", "ハンガリー語")},
                {37, new ViewValue(37, "Сингальский", "Sinhalese", "シンハラ語")},
                {38, new ViewValue(38, "Греческий", "Greek", "ギリシャ語")},
                {39, new ViewValue(39, "Чешский", "Czech", "チェコ語")}
            };
        }
    }
}