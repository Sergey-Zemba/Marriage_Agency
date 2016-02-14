using System.Collections.Generic;

namespace Marriage_Agency_Women_.Models.Woman
{
    public class DropdownValuesProvider
    {
        private Dictionary<int, string> _locations;
        private Dictionary<int, string> _religions;
        private Dictionary<int, string> _activities;
        private Dictionary<int, string> _posts;
        private Dictionary<int, string> _educations;
        private Dictionary<int, string> _languages;
        private Dictionary<int, string> _relationships;
        private Dictionary<int, string> _numberOfChildren;
        private Dictionary<int, string> _figures;
        private Dictionary<int, string> _eyeColors;
        private Dictionary<int, string> _hairColors;
        private Dictionary<int, string> _alcohol;
        private Dictionary<int, string> _desiredAges;
        private Dictionary<int, string> _hobbies;
        private Dictionary<int, string> _lifestyles;
        private Dictionary<int, string> _knowledge;

        //
        //
        //
        public IDictionary<int, string> Locations
        {
            get
            {
                if (_locations == null)
                {
                    LocationsInit();
                }
                return _locations;
            }
            private set { _locations = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> Religions
        {
            get
            {
                if (_religions == null)
                {
                    ReligionsInit();
                }
                return _religions;
            }
            private set { _religions = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> Activities
        {
            get {
                if (_activities == null)
                {
                    InitActivities();
                }
                return _activities;
            }
            private set { _activities = (Dictionary<int, string>) value; }
        }

        public IDictionary<int, string> Posts
        {
            get
            {
                if (_posts == null)
                {
                    InitPosts();
                }
                return _posts;
            }
            private set { _posts = (Dictionary<int, string>) value; }
        }

        public IDictionary<int, string> Educations
        {
            get
            {
                if (_educations == null)
                {
                    InitEducations();
                }
                return _educations;
            }
            private set { _educations = (Dictionary<int, string>) value; }
        }

        public IDictionary<int, string> Languages
        {
            get
            {
                if (_languages == null)
                {
                    InitLanguages();
                }
                return _languages;
            }
            private set { _languages = (Dictionary<int, string>) value; }
        }

        public IDictionary<int, string> Relationships
        {
            get
            {
                if (_relationships == null)
                {
                    InitRelationships();
                }
                return _relationships;
            }
            private set { _relationships = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> NumberOfChildren
        {
            get
            {
                if (_numberOfChildren == null)
                {
                    InitNumberOfChildren();
                }
                return _numberOfChildren;
            }
            private set { _numberOfChildren = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> Figures
        {
            get
            {
                if (_figures == null)
                {
                    InitFigures();
                }
                return _figures;
            }
            private set { _figures = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> EyeColors
        {
            get
            {
                if (_eyeColors == null)
                {
                    InitEyeColors();
                }
                return _eyeColors;
            }
            private set { _eyeColors = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> HairColors
        {
            get
            {
                if (_hairColors == null)
                {
                    InitHairColors();
                }
                return _hairColors;
            }
            private set { _hairColors = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> Alcohol
        {
            get
            {
                if (_alcohol == null)
                {
                    InitAlcohol();
                }
                return _alcohol;
            }
            private set { _alcohol = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> DesiredAges
        {
            get
            {
                if (_desiredAges == null)
                {
                    InitDesiredAges();
                }
                return _desiredAges;
            }
            private set { _desiredAges = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> Hobbies
        {
            get
            {
                if (_hobbies == null)
                {
                    InitHobbies();
                }
                return _hobbies;
            }
            private set { _hobbies = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> Lifestyles
        {
            get
            {
                if (_lifestyles == null)
                {
                    InitLifestyles();
                }
                return _lifestyles;
            }
            private set { _lifestyles = (Dictionary<int, string>)value; }
        }

        public IDictionary<int, string> Knowledge
        {
            get
            {
                if (_knowledge == null)
                {
                    InitKnowledge();
                }
                return _knowledge;
            }
            private set { _knowledge = (Dictionary<int, string>)value; }
        }

        // 
        //
        //
        private void LocationsInit()
        {
            Locations = new Dictionary<int, string>
            {
                {1, "Крым"},
                {2, "Винницкая область"},
                {3, "Волынская область"},
                {4, "Днепропетровская область"},
                {5, "Донецкая область"},
                {6, "Житомирская область"},
                {7, "Закарпатская область"},
                {8, "Запорожская область"},
                {9, "Ивано-Франковская область"},
                {10, "Киев"},
                {11, "Киевская область"},
                {12, "Кировоградская область"},
                {13, "Луганская область"},
                {14, "Львовская область"},
                {15, "Николаевская область"},
                {16, "Одесская область"},
                {17, "Полтавская область"},
                {18, "Ровенская область"},
                {19, "Сумская область"},
                {20, "Тернопольская область"},
                {21, "Харьковская область"},
                {22, "Харьковская область"},
                {23, "Хмельницкая область"},
                {24, "Черкасская область"},
                {25, "Черниговская область"},
                {26, "Черновицкая область"}
            };
        }

        private void ReligionsInit()
        {
            Religions = new Dictionary<int, string>
            {
                {1, "Христианство"},
                {2, "Мусульманство"},
                {3, "Буддизм"},
                {4, "Иррелигиозность"},
                {5, "Другое"}
            };
        }

        private void InitActivities()
        {
            Activities = new Dictionary<int, string>
            {
                {1, "Аграрная промышленность"},
                {2, "Горная промышленность"},
                {3, "Строительство"},
                {4, "Производство"},
                {5, "Продажи"},
                {6, "Ресторанный бизнес"},
                {7, "Финансы"},
                {8, "Страхование"},
                {9, "Недвижемость"},
                {10, "Логистика"},
                {11, "Связь"},
                {12, "Наука"},
                {13, "Искусство и культура"},
                {14, "IT"},
                {15, "Образование"},
                {16, "Сервис"},
                {17, "Государственный сектор"},
                {18, "Другое"},
            };
        }

        private void InitPosts()
        {
            Posts = new Dictionary<int, string>
            {
                {1, "Должностное лицо"},
                {2, "Сотрудник компании"},
                {3, "Частный предприниматель"},
                {4, "Частный специалист"},
                {5, "Госслужащий"},
                {6, "Студент"},
                {7, "Домохозяйка"},
                {8, "Неполная занятость"},
                {9, "В поисках работы"},
                {10, "Другое"}
            };
        }

        private void InitEducations()
        {
            Educations = new Dictionary<int, string>
            {
                {1, "Аспирантура"},
                {2, "Университет"},
                {3, "ПТУ"},
                {4, "Средняя школа"},
                {5, "Учусь"}
            };
        }

        private void InitLanguages()
        {
            Languages = new Dictionary<int, string>
            {
                {1, "Английский"},
                {2, "Китайский"},
                {3, "Японский"},
                {4, "Испанский"},
                {5, "Немецкий"},
                {6, "Французский"},
                {7, "Итальянский"},
                {8, "Португальский"},
                {9, "Турецкий"},
                {10, "Арабский"},
                {11, "Корейский"},
                {12, "Бенгальский"},
                {13, "Хинди"},
                {14, "Яванский"},
                {15, "Вьетнамский"},
                {16, "Урду"},
                {17, "Панджаби"},
                {18, "Гуджарати"},
                {19, "Тайский"},
                {20, "Польский"},
                {21, "Малаялам"},
                {22, "Бирманский"},
                {23, "Азербайджанский"},
                {24, "Персидский"},
                {25, "Румынский"},
                {26, "Майтхили"},
                {27, "Сербохорватский"},
                {28, "Узбекский"},
                {29, "Йоруба"},
                {30, "Нидерландский"},
                {31, "Синдхи"},
                {32, "Индонезийский"},
                {33, "Тагальский"},
                {34, "Непальский"},
                {35, "Ассамский"},
                {36, "Венгерский"},
                {37, "Сингальский"},
                {38, "Греческий"},
                {39, "Чешский"}
            };
        }

        private void InitRelationships()
        {
            Relationships = new Dictionary<int, string>
            {
                {1, "Нет"},
                {1, "Была замужем"},
                {1, "Вдова"},
                {1, "В отношениях"}
            };
        }

        private void InitNumberOfChildren()
        {
            NumberOfChildren = new Dictionary<int, string>
            {
                {1, "Нет"},
                {2, "Один"},
                {3, "Двое"},
                {4, "Трое"},
                {5, "Более трех"}
            };
        }

        private void InitFigures()
        {
            Figures = new Dictionary<int, string>
            {
                {1, "Худое"},
                {2, "Спортивное"},
                {3, "Стандартное"},
                {4, "Роскошное"},
                {5, "Полное"}
            };   
        }

        private void InitEyeColors()
        {
            EyeColors = new Dictionary<int, string>
            {
                {1, "Голубые"},
                {2, "Серые"},
                {3, "Зеленые"},
                {4, "Светло-коричневые"},
                {5, "Темно-коричневые"}
            };
        }

        private void InitHairColors()
        {
            HairColors = new Dictionary<int, string>
            {
                {1, "Тёмные"},
                {2, "Каштановые"},
                {3, "Светлые"},
                {4, "Рыжие"}
            };
        }

        private void InitAlcohol()
        {
            Alcohol = new Dictionary<int, string>
            {
                {1, "Нет"},
                {2, "Да, только по праздникам"},
                {3, "Да, раз в месяц"},
                {4, "Да, раз в неделю"}
            };
        }

        private void InitDesiredAges()
        {
            DesiredAges = new Dictionary<int, string>
            {
                {1, "Нет"},
                {2, "До 30 лет"},
                {3, "До 35 лет"},
                {4, "До 40 лет"},
                {5, "До 45 лет"},
                {6, "До 50 лет"},
                {7, "До 55 лет"},
                {8, "До 60 лет "}
            };
        }

        private void InitHobbies()
        {
            Hobbies = new Dictionary<int, string>
            {
                {1, "Футбол"},
                {2, "Волейбол"},
                {3, "Баскетбол"},
                {4, "Бейсбол"},
                {5, "Ходьба"},
                {6, "Марафон"},
                {7, "Езда на велосипеде"},
                {8, "Пейнтбол"},
                {9, "Стрельба"},
                {10, "Формула 1"},
                {11, "Бодибилдинг"},
                {12, "Гольф"},
                {13, "Верховая езда"},
                {14, "Теннис"},
                {15, "Настольный теннис"},
                {16, "Бадминтон"},
                {17, "Плавание"},
                {18, "Дайвинг"},
                {19, "Серфинг"},
                {20, "Бильярд"},
                {21, "Боулинг"},
                {22, "Катание на коньках"},
                {23, "Катание на лыжах"},
                {24, "Катание на скейтборде"},
                {25, "Альпинизм"},
                {26, "Борьба"},
                {27, "Бокс"},
                {28, "Айкидо"},
                {29, "Каратэ"},
                {30, "Дзюдо"},
                {31, "Рисование"},
                {32, "Вязание"},
                {33, "Вышивание"},
                {34, "Фотографии"},
                {35, "Ручная работа"},
                {36, "Скульптурное дело"},
                {37, "Керамическое дело"},
                {38, "Моделирование"},
                {39, "Игра на пианино"},
                {40, "Игра на гитаре"},
                {41, "Игра на саксофоне"},
                {42, "Игра на трубе"},
                {43, "Игра на барабанах"},
                {44, "Игра на скрипке"},
                {45, "Игра на флейте"},
                {46, "Пение"},
                {47, "Караоке"},
                {48, "Хор"},
                {49, "Джазовые танцы"},
                {50, "Бальные танцы"},
                {51, "Вальсовые танцы"},
                {52, "Балетные танцы"},
                {53, "Сальса"},
                {54, "Самба"},
                {55, "Брейк данс"},
                {56, "DJ"},
                {57, "Сочинять музыку"},
                {58, "Мюзикл"},
                {59, "Нет"}
            };
        }

        private void InitLifestyles()
        {
            Lifestyles = new Dictionary<int, string>
            {
                {1, "Йога"},
                {2, "Проводить время с питомцами "},
                {3, "Шоппинг"},
                {4, "Интеренет шоппинг"},
                {5, "Мода"},
                {6, "Макияж"},
                {7, "Заниматься интерьером"},
                {8, "Путешествия за границу"},
                {9, "Загорать"},
                {10, "Садоводство"},
                {11, "Рыбалка"},
                {12, "Лотереи"},
                {13, "Гадание"},
                {14, "Интернет"},
                {15, "Аниме"},
                {16, "Онлайн-игры"},
                {17, "Компьютерные игры"},
                {18, "Шахматы"},
                {19, "Карточные игры"},
                {20, "Настольные игры"},
                {21, "Фокусы"},
                {22, "Общение"},
                {23, "Ходить в поход"},
                {24, "Кататься на авто"},
                {25, "Волонтёрство"},
                {26, "Посещать семинары"},
                {27, "Ходить в аквариум"},
                {28, "Ходить в зоопарк"},
                {29, "Ходить на концерты"},
                {30, "Смотреть сериалы"},
                {31, "Смотреть кино"},
                {32, "Слушать музыку"},
                {33, "Юмор"},
                {34, "Коллекционирование"},
                {35, "История"},
                {36, "Железная дорога и поезда"},
                {37, "Астрономия"},
                {38, "Сон"},
                {39, "Уборка"},
                {40, "Проводить время с семьей"},
                {41, "Нет"}
            };
        }

        private void InitKnowledge()
        {
            Knowledge = new Dictionary<int, string>
            {
                {1, "Кулинария "},
                {2, "Кондитерские изделия"},
                {3, "Прогулка по ресторанам"},
                {4, "Кафе-тур"},
                {5, "Чай"},
                {6, "Кофе"},
                {7, "Коктейли"},
                {8, "Духи"},
                {9, "Поэзия"},
                {10, "Чтение"},
                {11, "Писание"},
                {12, "Массаж"},
                {13, "Медитация"},
                {14, "Изучение языков"},
                {15, "Тренировка мозга"},
                {16, "Форекс"},
                {17, "Изобретения"},
                {18, "Отгадывать загадки"},
                {19, "Приобретение квалификации"},
                {20, "Физика"},
                {21, "Психология"},
                {22, "Программирование"},
                {23, "3D графика"},
                {24, "Радиоконструктор"},
                {25, "Роботы"},
                {26, "Косплей"},
                {27, "Динозавры"},
                {28, "Военное дело"},
                {29, "Посещать заседания судов"},
                {30, "НЛО"},
                {31, "Нет"}
            };
        }
    }
}