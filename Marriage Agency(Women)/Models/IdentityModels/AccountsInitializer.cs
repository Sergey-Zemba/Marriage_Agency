using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Marriage_Agency_Women_.Models.Characteristics;
using Marriage_Agency_Women_.Models.Values;

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
            context.Activities.AddRange(activities);
            base.Seed(context);
        }
    }
}