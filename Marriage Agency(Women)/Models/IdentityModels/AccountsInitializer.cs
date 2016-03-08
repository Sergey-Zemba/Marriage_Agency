using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.Characteristics;

namespace Marriage_Agency_Women_.Models.IdentityModels
{
    public class AccountsInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //Values.Values values = new Values.Values();
            //IDictionary<int, ViewValue> languages = values.Languages;
            //ICollection<Language> dbLanguages = new List<Language>();

            //foreach (KeyValuePair<int, ViewValue> keyValue in languages)
            //{
            //    dbLanguages.Add(new Language(keyValue.Key));
            //}
            //context.Languages.AddRange(dbLanguages);
            ICollection<Activity> activities = new List<Activity>
            {
                new Activity(1, "Горная промышленность", "Mining industry", "鉱業"),
                new Activity(2, "Строительство", "Construction industry ", "建設業 "), 
                new Activity(3, "Производство", "Manufacturing industry", "製造業 "),
                new Activity(4, "Продажи", "Retail business", "小売業"),
                new Activity(5, "Ресторанный бизнес", "Restaurant business", "飲食業"),
                new Activity(6, "Финансы", "Finance industry", "金融業"),
                new Activity(7, "Страхование", "Insurance industry", "保険業"),
                new Activity(8, "Недвижимость", "Real estate business", "不動産業 "),
                new Activity(9, "Логистика", "Transportation industry", "運輸業"),
                new Activity(10, "Связь", "Telecommunications industry", "通信業 "),
                new Activity(11, "Наука", "Science", "学術"),
                new Activity(12, "Искусство и культура", "Arts & Culture", "文化芸術"),
                new Activity(13, "IT", "IT", "IT業"),
                new Activity(14, "Образование", "Education", "教育"),
                new Activity(15, "Сервис", "Service industry", "サービス業"),
                new Activity(16, "Государственный сектор", "Public sector", "官業"),
                new Activity(17, "Другое", "Оther", "その他")
            };
            ICollection<Alcohol> alcohols = new List<Alcohol>
            {
                new Alcohol(1, "Нет", "No", "いいえ"),
                new Alcohol(2, "Да, только по праздникам", "Yes, only on holidays", "祭日にだけ"),
                new Alcohol(3, "Да, раз в месяц", "Yes, once a month", "月に一度程度"),
                new Alcohol(4, "Да, раз в неделю", "Yes, once a week", "週に一度程度")
            };
            ICollection<DesiredAge> desiredAges = new List<DesiredAge>
            {
                new DesiredAge(1, "Нет", "No", "なし"),
                new DesiredAge(2, "До 30 лет", "Up to 30 years", "30 歳まで"),
                new DesiredAge(3, "До 35 лет", "Up to 35 years", "35 歳まで"),
                new DesiredAge(4, "До 40 лет", "Up to 40 years", "40 歳まで"),
                new DesiredAge(5, "До 45 лет", "Up to 45 years", "45 歳まで"),
                new DesiredAge(6, "До 50 лет", "Up to 50 years", "50 歳まで"),
                new DesiredAge(7, "До 55 лет", "Up to 55 years", "55 歳まで"),
                new DesiredAge(8, "До 60 лет", "Up to 60 years", "60 歳まで"),
            };
            ICollection<Education> educations = new List<Education>
            {
                new Education(1, "Аспирантура", "Graduate school", ""),
                new Education(2, "Университет", "University", "大学"),
                new Education(3, "ПТУ", "Vocational school", "専門学校"),
                new Education(4, "Средняя школа", "High school", "高等学校"),
                new Education(5, "Учусь", "Student", "在学中")
            };
            ICollection<EyeColor> eyeColors = new List<EyeColor>
            {
                new EyeColor(1, "Голубые", "Blue", "青色"),
                new EyeColor(2, "Серые", "Gray", "灰色"),
                new EyeColor(3, "Зеленые", "Green", "緑色"),
                new EyeColor(4, "Светло-коричневые", "Hazel", "淡褐色"),
                new EyeColor(5, "Темно-коричневые", "Brown", "濃褐色"),
            };
            ICollection<HairColor> hairColors = new List<HairColor>
            {
                new HairColor(1, "Тёмные", "Black", "黒髪"),
                new HairColor(2, "Каштановые", "Brown", "栗毛"),
                new HairColor(3, "Светлые", "Blond", "金髪"),
                new HairColor(4, "Тёмные", "Black", "黒髪")
            };
            ICollection<Hobby> hobbies = new List<Hobby>
            {
                new Hobby(1, "Футбол", "Football", "サッカー"),
                new Hobby(2, "Волейбол", "Volleyball", "バレーボール"),
                new Hobby(3, "Баскетбол", "Basketball", "バスケットボール"),
                new Hobby(4, "Бейсбол", "Baseball", "野球"),
                new Hobby(5, "Ходьба", "Walking", "ウォーキング"),
                new Hobby(6, "Марафон", "Marathon", "マラソン"),
                new Hobby(7, "Езда на велосипеде", "Bicycling", "サイクリング"),
                new Hobby(8, "Пейнтбол", "Paintball", "ペイントボール"),
                new Hobby(9, "Стрельба", "Shooting", "射撃"),
                new Hobby(10, "Формула 1", "F1", "F1"),
                new Hobby(11, "Бодибилдинг", "Body-building", "ボディビルディング"),
                new Hobby(12, "Гольф", "Golf", "ゴルフ"),
                new Hobby(13, "Верховая езда", "Horseback riding", "乗馬"),
                new Hobby(14, "Теннис", "Tennis", "テニス"),
                new Hobby(15, "Настольный теннис", "Table tennis", "卓球"),
                new Hobby(16, "Бадминтон", "Badminton", "バドミントン"),
                new Hobby(17, "Плавание", "Swimming", "水泳"),
                new Hobby(18, "Дайвинг", "Diving", "ダイビング"),
                new Hobby(19, "Серфинг", "Surfing", "サーフィン"),
                new Hobby(20, "Бильярд", "Billiards", "ビリヤード"),
                new Hobby(21, "Боулинг", "Bowling", "ボウリング"),
                new Hobby(22, "Катание на коньках", "Skating", "アイススケート"),
                new Hobby(23, "Катание на лыжах", "Skiing", "スキー"),
                new Hobby(24, "Катание на скейтборде", "Skateboarding", "スケートボード"),
                new Hobby(25, "Альпинизм", "Mountaineering", "登山"),
                new Hobby(26, "Борьба", "Wrestling", "レスリング"),
                new Hobby(27, "Бокс", "Boxing", "ボクシング"),
                new Hobby(28, "Айкидо", "Aikido", "合気道"),
                new Hobby(29, "Каратэ", "Karate", "空手"),
                new Hobby(30, "Дзюдо", "Judo", "柔道"),
                new Hobby(31, "Рисование", "Painting", "絵画"),
                new Hobby(32, "Вязание", "Knitting", "編み物"),
                new Hobby(33, "Вышивание", "Crocheting", "刺繍"),
                new Hobby(34, "Фотографии", "Photos", "写真"),
                new Hobby(35, "Ручная работа", "Handicraft", "手芸"),
                new Hobby(36, "Скульптурное дело", "Carving", "彫刻"),
                new Hobby(37, "Керамическое дело", "Pottery", "陶芸"),
                new Hobby(38, "Моделирование", "Modeling", "模型"),
                new Hobby(39, "Игра на пианино", "Play the piano", "ピアノ"),
                new Hobby(40, "Игра на гитаре", "Play the guitar", "ギター"),
                new Hobby(41, "Игра на саксофоне", "Play the  saxophone", "サックス"),
                new Hobby(42, "Игра на трубе", "Play the  trumpet", "トランペット"),
                new Hobby(43, "Игра на барабанах", "Play the  drums", "ドラム"),
                new Hobby(44, "Игра на скрипке", "Play the violin", "バイオリン"),
                new Hobby(45, "Игра на флейте", "Play the flute", "フルート"),
                new Hobby(46, "Пение", "Singing", "歌"),
                new Hobby(47, "Караоке", "Karaoke", "カラオケ"),
                new Hobby(48, "Хор", "Singing in a choir", "合唱"),
                new Hobby(49, "Джазовые танцы", "Jazz dance", "ジャズダンス"),
                new Hobby(50, "Бальные танцы", "Ballroom dance", "社交ダンス"),
                new Hobby(51, "Вальсовые танцы", "Waltz dance", "ワルツ"),
                new Hobby(52, "Балетные танцы", "Ballet dance", "バレエ"),
                new Hobby(53, "Сальса", "Salsa", "サルサ"),
                new Hobby(54, "Самба", "Samba", "ズンバ"),
                new Hobby(55, "Брейк данс", "Brakedance", "ブレイクダンス"),
                new Hobby(56, "DJ", "DJ", "DJ"),
                new Hobby(57, "Сочинять музыку", "Compose music", "作曲"),
                new Hobby(58, "Мюзикл", "Musical", "ミュージカル"),
                new Hobby(59, "Нет", "No", "なし")
            };
            ICollection<InternationalPassport> internationalPassports = new List<InternationalPassport>
            {
                new InternationalPassport(1, "Да", "Yes", "はい"),
                new InternationalPassport(1, "Нет", "No", "いいえ")
            };
            ICollection<Job> jobs = new List<Job>
            {
                new Job(1, "Должностное лицо", "Executive", "役員"),
                new Job(2, "Сотрудник компании", "Employee", "会社員"),
                new Job(3, "Частный предприниматель", "Self-employment", "自営業 "),
                new Job(4, "Частный специалист", "Professional", "専門家 "),
                new Job(5, "Госслужащий", "Public servant", "公務員"),
                new Job(6, "Студент", "Student", "学生 "),
                new Job(7, "Домохозяйка", "Housewife", "家事手伝い "),
                new Job(8, "Неполная занятость", "Underemployment", "パート"),
                new Job(9, "В поисках работы", "Looking for work", "無職"),
                new Job(10, "Другое", "Оther", "その他")
            };
            ICollection<Knowledge> knowledges = new List<Knowledge>
            {
                new Knowledge(1, "Кулинария", "Cooking", "料理"),
                new Knowledge(2, "Кондитерские изделия", "Pastry making", "お菓子作り"),
                new Knowledge(3, "Прогулка по ресторанам", "Eating tour", "食べ歩き"),
                new Knowledge(4, "Кафе-тур", "Cafe Tours", "カフェめぐり"),
                new Knowledge(5, "Чай", "Tea", "紅茶"),
                new Knowledge(6, "Кофе", "Coffee", "コーヒー"),
                new Knowledge(7, "Коктейли", "Cocktails", "カクテル"),
                new Knowledge(8, "Духи", "Perfumes", "香水"),
                new Knowledge(9, "Поэзия", "Poetry", "詩"),
                new Knowledge(10, "Чтение", "Reading", "読書"),
                new Knowledge(11, "Писание", "Writing", "執筆"),
                new Knowledge(12, "Массаж", "Massage", "マッサージ"),
                new Knowledge(13, "Медитация", "Meditation", "瞑想"),
                new Knowledge(14, "Изучение языков", "Language Learning", "語学"),
                new Knowledge(15, "Тренировка мозга", "Brain Workout", "脳力トレーニング"),
                new Knowledge(16, "Форекс", "Forex", "FX取引"),
                new Knowledge(17, "Изобретения", "Invention", "発明"),
                new Knowledge(18, "Отгадывать загадки", "Riddles", "クイズ"),
                new Knowledge(19, "Приобретение квалификации", "Qualification acquisition", "資格取得"),
                new Knowledge(20, "Физика", "Physics", "物理学"),
                new Knowledge(21, "Психология", "Psychology", "心理学"),
                new Knowledge(22, "Программирование", "Programming", "プログラミング"),
                new Knowledge(23, "3D графика", "3D graphics", "3Dグラフィック"),
                new Knowledge(24, "Радиоконструктор", "Radio constructor", "電子工作"),
                new Knowledge(25, "Роботы", "Robots", "ロボット"),
                new Knowledge(26, "Косплей", "Cosplay", "コスプレ"),
                new Knowledge(27, "Динозавры", "Dinosaurs", "恐竜"),
                new Knowledge(28, "Военное дело", "Military", "軍事"),
                new Knowledge(29, "Посещать заседания судов", "Court hearing", "裁判傍聴"),
                new Knowledge(30, "НЛО", "UFO", "UFO"),
                new Knowledge(31, "Нет", "No", "なし")
            };
            ICollection<Language> languages = new List<Language>
            {
                new Language(1, "Английский", "English", "英語"),
                new Language(2, "Китайский", "Chinese", "中国語"),
                new Language(3, "Японский", "Japanese", "日本語"),
                new Language(4, "Испанский", "Spanish", "スペイン語"),
                new Language(5, "Немецкий", "German", "ドイツ語"),
                new Language(6, "Французский", "French", "フランス語"),
                new Language(7, "Итальянский", "Italian", "イタリア語"),
                new Language(8, "Португальский", "Portuguese", "ポルトガル語"),
                new Language(9, "Турецкий", "Turkish", "トルコ語"),
                new Language(10, "Арабский", "Arabic", "アラビア語"),
                new Language(11, "Корейский", "Korean", "韓国語"),
                new Language(12, "Бенгальский", "Bengali", "ベンガル語"),
                new Language(13, "Хинди", "Hindi", "ヒンディー語"),
                new Language(14, "Яванский", "Javanese", "ジャワ語"),
                new Language(15, "Вьетнамский", "Vietnamese", "ベトナム語"),
                new Language(16, "Урду", "Urdu", "ウルドゥー語"),
                new Language(17, "Панджаби", "Punjabi", "パンジャブ語"),
                new Language(18, "Гуджарати", "Gujarati", "グジャラート語"),
                new Language(19, "Тайский", "Thai", "タイ語"),
                new Language(20, "Польский", "Polish", "ポーランド語"),
                new Language(21, "Малаялам", "Malayalam", "マラヤーラム語"),
                new Language(22, "Бирманский", "Burmese", "ビルマ語"),
                new Language(23, "Азербайджанский", "Azerbaijani", "アゼルバイジャン語"),
                new Language(24, "Персидский", "Persian", "ペルシア語"),
                new Language(25, "Румынский", "Romanian", "ルーマニア語"),
                new Language(26, "Майтхили", "Maithili", "マイティリー語"),
                new Language(27, "Сербохорватский", "Serbo-Croatian", "セルボクロアチア語"),
                new Language(28, "Узбекский", "Uzbek", "ウズベク語"),
                new Language(29, "Йоруба", "Yoruba", "ヨルバ語"),
                new Language(30, "Нидерландский", "Dutch", "オランダ語"),
                new Language(31, "Синдхи", "Sindhi", "シンド語"),
                new Language(32, "Индонезийский", "Indonesian", "インドネシア語"),
                new Language(33, "Тагальский", "Tagalog", "タガログ語"),
                new Language(34, "Непальский", "Nepali", "ネパール語"),
                new Language(35, "Ассамский", "Assamese", "アッサム語"),
                new Language(36, "Венгерский", "Hungarian", "ハンガリー語"),
                new Language(37, "Сингальский", "Sinhalese", "シンハラ語"),
                new Language(38, "Греческий", "Greek", "ギリシャ語"),
                new Language(39, "Чешский", "Czech", "チェコ語")
            };
            ICollection<Level> levels = new List<Level>
            {
                new Level(1, "Базовый", "Elementary", "エレメンタリー"),
                new Level(2, "Средний", "Intermediate", "中間体"),
                new Level(3, "Продвинутый", "Upper", "アッパー"),
                new Level(4, "Родной", "Native", "ネイティブ")
            };
            ICollection<Lifestyle> lifestyles = new List<Lifestyle>
            {
                new Lifestyle(1, "Йога", "Yoga", "ヨガ"),
                new Lifestyle(2, "Проводить время с питомцами", "Spending time with pets", "ペット飼育"),
                new Lifestyle(3, "Шоппинг", "Shopping", "ショッピング"),
                new Lifestyle(4, "Интеренет шоппинг", "Internet shopping", "ネットショッピング"),
                new Lifestyle(5, "Мода", "Fashion", "ファッション"),
                new Lifestyle(6, "Макияж", "Makeup", "メイク"),
                new Lifestyle(7, "Заниматься интерьером", "Interior Design", "インテリア"),
                new Lifestyle(8, "Путешествия за границу", "Foreign tour", "海外旅行"),
                new Lifestyle(9, "Загорать", "Sunbathe", "日焼け"),
                new Lifestyle(10, "Садоводство", "Gardening", "ガーデニング"),
                new Lifestyle(11, "Рыбалка", "Fishing", "釣り"),
                new Lifestyle(12, "Лотереи", "Lottery", "宝くじ"),
                new Lifestyle(13, "Гадание", "Fortune-telling", "占い"),
                new Lifestyle(14, "Интернет", "Internet", "インターネット"),
                new Lifestyle(15, "Аниме", "Anime", "アニメ"),
                new Lifestyle(16, "Онлайн-игры", "Online games", "オンラインゲーム"),
                new Lifestyle(17, "Компьютерные игры", "Computer games", "コンピューターゲーム"),
                new Lifestyle(18, "Шахматы", "Chess", "チェス"),
                new Lifestyle(19, "Карточные игры", "Card games", "トランプ"),
                new Lifestyle(20, "Настольные игры", "Board games", "ボードゲーム"),
                new Lifestyle(21, "Фокусы", "Magic", "マジック"),
                new Lifestyle(22, "Общение", "Communication", "コミュニケーション"),
                new Lifestyle(23, "Ходить в поход", "Camping", "キャンプ"),
                new Lifestyle(24, "Кататься на авто", "Drive", "ドライブ"),
                new Lifestyle(25, "Волонтёрство", "Volunteering", "ボランティア"),
                new Lifestyle(26, "Посещать семинары", "Seminars", "セミナー"),
                new Lifestyle(27, "Ходить в аквариум", "Going to the aquarium", "水族館"),
                new Lifestyle(28, "Ходить в зоопарк", "Going to the zoo", "動物園"),
                new Lifestyle(29, "Ходить на концерты", "Going to concerts", "コンサート"),
                new Lifestyle(30, "Смотреть сериалы", "Watch TV shows", "ドラマ鑑賞"),
                new Lifestyle(31, "Смотреть кино", "Watch movies", "映画鑑賞"),
                new Lifestyle(32, "Слушать музыку", "Listen music", "音楽鑑賞"),
                new Lifestyle(33, "Юмор", "Humor", "お笑い"),
                new Lifestyle(34, "Коллекционирование", "Collecting", "収集"),
                new Lifestyle(35, "История", "History", "歴史"),
                new Lifestyle(36, "Железная дорога и поезда", "Railroad and train", "鉄道"),
                new Lifestyle(37, "Астрономия", "Astronomy", "天文学"),
                new Lifestyle(38, "Сон", "Sleep", "睡眠"),
                new Lifestyle(39, "Уборка", "Cleaning", "整理整頓"),
                new Lifestyle(40, "Проводить время с семьей", "Spend time with family", "家族と過ごす"),
                new Lifestyle(41, "Нет", "No", "なし")
            };
            ICollection<Location> locations = new List<Location>
            {
                new Location(1, "Крым", "Crimea", "クリミア半島"),
                new Location(2, "Винницкая область", "Vinnytsia Oblast", "ヴィーンヌィツャ州"),
                new Location(3, "Волынская область", "Volyn Oblast", "ヴォルィーニ州"),
                new Location(4, "Днепропетровская область", "Dnipropetrovsk Oblast", "ドニプロペトロウシク州"),
                new Location(5, "Донецкая область", "Donetsk Oblast", "ドネツク州"),
                new Location(6, "Житомирская область", "Zhytomyr Oblast", "ジトームィル州"),
                new Location(7, "Закарпатская область", "Zakarpattia Oblast", "ザカルパッチャ州"),
                new Location(8, "Запорожская область", "Zaporizhia Oblast", "ザポリージャ州"),
                new Location(9, "Ивано-Франковская область", "Ivano-Frankivsk Oblast", "イヴァーノ=フランキーウシク州"),
                new Location(-10, "Киев", "Kiev", "キエフ市"),
                new Location(11, "Киевская область", "Kiev Oblast", "キエフ州"),
                new Location(12, "Кировоградская область", "Kirovohrad Oblast", "キロヴォフラード州"),
                new Location(13, "Луганская область", "Lugansk Oblast", "ルガンスク州"),
                new Location(14, "Львовская область", "Lviv Oblast", "リヴィウ州"),
                new Location(15, "Николаевская область", "Nikolaevkskaya Oblast", "ニコラーエフ州"),
                new Location(16, "Одесская область", "Odessa Oblast", "オデッサ州"),
                new Location(17, "Полтавская область", "Poltava Oblast", "ポルタヴァ州"),
                new Location(18, "Ровенская область", "Rovenskaya Oblast", "ロブノ州"),
                new Location(19, "Сумская область", "Sumy Oblast", "スームィ州"),
                new Location(20, "Тернопольская область", "Ternopil Oblast", "テルノーピリ州"),
                new Location(21, "Харьковская область", "Kharkov Oblast", "ハリコフ州"),
                new Location(22, "Херсонская область", "Kherson Oblast", "ヘルソン州"),
                new Location(23, "Хмельницкая область", "Khmelnitsky Oblast", "フメリニツキー州"),
                new Location(24, "Черкасская область", "Cherkasy Oblast", "チェルカースィ州"),
                new Location(25, "Черниговская область", "Chernihiv Oblast", "チェルニーヒウ州"),
                new Location(26, "Черновицкая область", "Chernivtsi Oblast", "チェルニウツィー州")
            };
            ICollection<NumberOfChildren> numbersOfChildren = new List<NumberOfChildren>
            {
                new NumberOfChildren(1, "Нет", "No", "なし"),
                new NumberOfChildren(2, "Один", "One", "1 人"),
                new NumberOfChildren(3, "Двое", "Two", "2 人"),
                new NumberOfChildren(4, "Трое", "Three", "3 人"),
                new NumberOfChildren(5, "Более трех", "More than three", "3 人以上")
            };
            ICollection<Relationship> relationships = new List<Relationship>
            {
                new Relationship(1, "Нет", "No", "なし"),
                new Relationship(2, "Была замужем", "Yes", "あり"),
                new Relationship(3, "Вдова", "Widow", "未亡人"),
                new Relationship(4, "В отношениях", "NO", "なし")
            };
            ICollection<Religion> religions = new List<Religion>
            {
                new Religion(1, "Христианство", "Christian", "キリスト教"),
                new Religion(2, "Мусульманство", "Muslim", "イスラム教"),
                new Religion(3, "Буддизм", "Buddhism", "仏教"),
                new Religion(4, "Иррелигиозность", "Irreligion", "無宗教"),
                new Religion(5, "Другое", "Оther", "その他")
            };
            ICollection<Shape> shapes = new List<Shape>
            {
                new Shape(1, "Худое", "Slender", "細身"),
                new Shape(2, "Спортивное", "Athletic", "アスリート"),
                new Shape(3, "Стандартное", "Standards", "標準"),
                new Shape(4, "Роскошное", "Voluptuous", "官能的"),
                new Shape(5, "Полное", "Plump", "豊満")
            };
            ICollection<Smoking> smokings = new List<Smoking>
            {
                new Smoking(1, "Да", "Yes", "はい"),
                new Smoking(1, "Нет", "No", "いいえ")
            };
            context.Activities.AddRange(activities);
            context.Alcohols.AddRange(alcohols);
            context.DesiredAges.AddRange(desiredAges);
            context.Educations.AddRange(educations);
            context.EyeColors.AddRange(eyeColors);
            context.HairColors.AddRange(hairColors);
            context.Hobbies.AddRange(hobbies);
            context.InternationalPassports.AddRange(internationalPassports);
            context.Jobs.AddRange(jobs);
            context.Knowledges.AddRange(knowledges);
            context.Languages.AddRange(languages);
            context.Levels.AddRange(levels);
            context.Lifestyles.AddRange(lifestyles);
            context.Locations.AddRange(locations);
            context.NumbersOfChildren.AddRange(numbersOfChildren);
            context.Relationships.AddRange(relationships);
            context.Religions.AddRange(religions);
            context.Shapes.AddRange(shapes);
            context.Smokings.AddRange(smokings);
            base.Seed(context);
        }
    }
}