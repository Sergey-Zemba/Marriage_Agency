using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Values.Initializers
{
    public class LocationsInitializer : IValuesInitializer
    {
        public void Init(out IDictionary<int, ViewValue> dictionary)
        {
            dictionary = new Dictionary<int, ViewValue>
            {
                {1, new ViewValue(1, "Крым", "Crimea", "クリミア半島")},
                {2, new ViewValue(2, "Винницкая область", "Vinnytsia Oblast", "ヴィーンヌィツャ州")},
                {3, new ViewValue(3, "Волынская область", "Volyn Oblast", "ヴォルィーニ州")},
                {4, new ViewValue(4, "Днепропетровская область", "Dnipropetrovsk Oblast", "ドニプロペトロウシク州")},
                {5, new ViewValue(5, "Донецкая область", "Donetsk Oblast", "ドネツク州")},
                {6, new ViewValue(6, "Житомирская область", "Zhytomyr Oblast", "ジトームィル州")},
                {7, new ViewValue(7, "Закарпатская область", "Zakarpattia Oblast", "ザカルパッチャ州")},
                {8, new ViewValue(8, "Запорожская область", "Zaporizhia Oblast", "ザポリージャ州")},
                {9, new ViewValue(9, "Ивано-Франковская область", "Ivano-Frankivsk Oblast", "イヴァーノ=フランキーウシク州")},
                {10, new ViewValue(-10, "Киев", "Kiev", "キエフ市")},
                {11, new ViewValue(11, "Киевская область", "Kiev Oblast", "キエフ州")},
                {12, new ViewValue(12, "Кировоградская область", "Kirovohrad Oblast", "キロヴォフラード州")},
                {13, new ViewValue(13, "Луганская область", "Lugansk Oblast", "ルガンスク州")},
                {14, new ViewValue(14, "Львовская область", "Lviv Oblast", "リヴィウ州")},
                {15, new ViewValue(15, "Николаевская область", "Nikolaevkskaya Oblast", "ニコラーエフ州")},
                {16, new ViewValue(16, "Одесская область", "Odessa Oblast", "オデッサ州")},
                {17, new ViewValue(17, "Полтавская область", "Poltava Oblast", "ポルタヴァ州")},
                {18, new ViewValue(18, "Ровенская область", "Rovenskaya Oblast", "ロブノ州")},
                {19, new ViewValue(19, "Сумская область", "Sumy Oblast", "スームィ州")},
                {20, new ViewValue(20, "Тернопольская область", "Ternopil Oblast", "テルノーピリ州")},
                {21, new ViewValue(21, "Харьковская область", "Kharkov Oblast", "ハリコフ州")},
                {22, new ViewValue(22, "Херсонская область", "Kherson Oblast", "ヘルソン州")},
                {23, new ViewValue(23, "Хмельницкая область", "Khmelnitsky Oblast", "フメリニツキー州")},
                {24, new ViewValue(24, "Черкасская область", "Cherkasy Oblast", "チェルカースィ州")},
                {25, new ViewValue(25, "Черниговская область", "Chernihiv Oblast", "チェルニーヒウ州")},
                {26, new ViewValue(26, "Черновицкая область", "Chernivtsi Oblast", "チェルニウツィー州")}
            };
        }
    }
}