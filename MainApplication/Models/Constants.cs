﻿namespace AthletesRating.Models
{
    public class Constants
    {
        public const int ID_FIELD = 0;

        public const int ACCOUNT_TABLE_EMAIL = 1;
        public const int ACCOUNT_TABLE_LOGIN = 2;
        public const int ACCOUNT_TABLE_PASSWORD = 3;
        public const int ACCOUNT_TABLE_ISADMIN = 4;

        public const int ATHLETES_TABLE_SURNAME = 1;
        public const int ATHLETES_TABLE_NAME = 2;
        public const int ATHLETES_TABLE_PATRONYMIC = 3;
        public const int ATHLETES_TABLE_GENDER = 4;
        public const int ATHLETES_TABLE_BIRTHDATE = 5;
        public const int ATHLETES_TABLE_HEIGHT = 6;
        public const int ATHLETES_TABLE_WEIGHT = 7;
        public const int ATHLETES_TABLE_ACHIEVEMENTS = 8;
        public const int ATHLETES_TABLE_NATIONALITY = 9;
        public const int ATHLETES_TABLE_SPORT_TYPE = 10;

        public const int LABEL_USERINFO_SURNAME = 0;
        public const int LABEL_USERINFO_NAME = 1;
        public const int LABEL_USERINFO_PATRONYMIC = 2;
        public const int LABEL_USERINFO_BIRTHDATE = 3;
        public const int LABEL_USERINFO_GENDER = 4;
        public const int LABEL_USERINFO_EMAIL = 5;
        public const int LABEL_USERINFO_HEIGHT = 6;
        public const int LABEL_USERINFO_WEIGHT = 7;

        public const int CHANGEFULLNAME_SURNAME = 0;
        public const int CHANGEFULLNAME_NAME = 1;
        public const int CHANGEFULLNAME_PATRONYMIC = 2;

        public const int CHANGEPASSWORD_OLDPASS = 0;
        public const int CHANGEPASSWORD_NEWPASS = 1;
        public const int CHANGEPASSWORD_CONNEWPASS = 2;

        public const int WORLDLEVEL_ACHIEVEMENT = 4;
        public const int OLYMPICLEVEL_ACHIEVEMENT = 3;
        public const int LOCALLEVEL_ACHIEVEMENT = 1;

        public const string WORLDLEVEL = "Международный";
        public const string OLYMPICLEVEL = "Олимпиада";
        public const string LOCALLEVEL = "Локальный";

        public const string MAIN_ADMIN = "d.fatkhullin@mail.ru";

        public static string[] Levels = new string[]
        {
            "Локальный",
            "Олимпиада",
            "Международный"
        };

        public static string[] SportTypes = new string[]
        {
            "<не указан>",
            "Баскетбол",
            "Футбол",
            "Волейбол",
            "Хоккей",
            "Лёгкая атлетика",
            "Тяжелая атлетика" ,
            "Ганбол",
            "Киберспорт",
            "Гольф",
            "Бокс",
            "Формула-1"
        };

        public static string[] Countries = new string[]
        {
            "<не указан>",
            "Австралия (AU)",
            "Австрия (AT)",
            "Азербайджан (AZ)",
            "Аландские о-ва (AX)",
            "Албания (AL)",
            "Алжир (DZ)",
            "Американское Самоа (AS)",
            "Ангилья (AI)",
            "Ангола (AO)",
            "Андорра (AD)",
            "Антарктида (AQ)",
            "Антигуа и Барбуда (AG)",
            "Аргентина (AR)",
            "Армения (AM)",
            "Аруба (AW)",
            "Афганистан (AF)",
            "Багамы (BS)",
            "Бангладеш (BD)",
            "Барбадос (BB)",
            "Бахрейн (BH)",
            "Беларусь (BY)",
            "Белиз (BZ)",
            "Бельгия (BE)",
            "Бенин (BJ)",
            "Бермудские о-ва (BM)",
            "Болгария (BG)",
            "Боливия (BO)",
            "Бонэйр, Синт-Эстатиус и Саба (BQ)",
            "Босния и Герцеговина (BA)",
            "Ботсвана (BW)",
            "Бразилия (BR)",
            "Британская территория в Индийском океане (IO)",
            "Бруней-Даруссалам (BN)",
            "Буркина-Фасо (BF)",
            "Бурунди (BI)",
            "Бутан (BT)",
            "Вануату (VU)",
            "Ватикан (VA)",
            "Великобритания (GB)",
            "Венгрия (HU)",
            "Венесуэла (VE)",
            "Виргинские о-ва (Великобритания) (VG)",
            "Виргинские о-ва (США) (VI)",
            "Внешние малые о-ва (США) (UM)",
            "Восточный Тимор (TL)",
            "Вьетнам (VN)",
            "Габон (GA)",
            "Гаити (HT)",
            "Гайана (GY)",
            "Гамбия (GM)",
            "Гана (GH)",
            "Гваделупа (GP)",
            "Гватемала (GT)",
            "Гвинея (GN)",
            "Гвинея-Бисау (GW)",
            "Германия (DE)",
            "Гернси (GG)",
            "Гибралтар (GI)",
            "Гондурас (HN)",
            "Гонконг (САР) (HK)",
            "Гренада (GD)",
            "Гренландия (GL)",
            "Греция (GR)",
            "Грузия (GE)",
            "Гуам (GU)",
            "Дания (DK)",
            "Джерси (JE)",
            "Джибути (DJ)",
            "Доминика (DM)",
            "Доминиканская Республика (DO)",
            "Египет (EG)",
            "Замбия (ZM)",
            "Западная Сахара (EH)",
            "Зимбабве (ZW)",
            "Израиль (IL)",
            "Индия (IN)",
            "Индонезия (ID)",
            "Иордания (JO)",
            "Ирак (IQ)",
            "Иран (IR)",
            "Ирландия (IE)",
            "Исландия (IS)",
            "Испания (ES)",
            "Италия (IT)",
            "Йемен (YE)",
            "Кабо-Верде (CV)",
            "Казахстан (KZ)",
            "Камбоджа (KH)",
            "Камерун (CM)",
            "Канада (CA)",
            "Катар (QA)",
            "Кения (KE)",
            "Кипр (CY)",
            "Киргизия (KG)",
            "Кирибати (KI)",
            "Китай (CN)",
            "КНДР (KP)",
            "Кокосовые о-ва (CC)",
            "Колумбия (CO)",
            "Коморы (KM)",
            "Конго - Браззавиль (CG)",
            "Конго - Киншаса (CD)",
            "Коста-Рика (CR)",
            "Кот-д’Ивуар (CI)",
            "Куба (CU)",
            "Кувейт (KW)",
            "Кюрасао (CW)",
            "Лаос (LA)",
            "Латвия (LV)",
            "Лесото (LS)",
            "Либерия (LR)",
            "Ливан (LB)",
            "Ливия (LY)",
            "Литва (LT)",
            "Лихтенштейн (LI)",
            "Люксембург (LU)",
            "Маврикий (MU)",
            "Мавритания (MR)",
            "Мадагаскар (MG)",
            "Майотта (YT)",
            "Макао (САР) (MO)",
            "Малави (MW)",
            "Малайзия (MY)",
            "Мали (ML)",
            "Мальдивы (MV)",
            "Мальта (MT)",
            "Марокко (MA)",
            "Мартиника (MQ)",
            "Маршалловы Острова (MH)",
            "Мексика (MX)",
            "Мозамбик (MZ)",
            "Молдова (MD)",
            "Монако (MC)",
            "Монголия (MN)",
            "Монтсеррат (MS)",
            "Мьянма (Бирма) (MM)",
            "Намибия (NA)",
            "Науру (NR)",
            "Непал (NP)",
            "Нигер (NE)",
            "Нигерия (NG)",
            "Нидерланды (NL)",
            "Никарагуа (NI)",
            "Ниуэ (NU)",
            "Новая Зеландия (NZ)",
            "Новая Каледония (NC)",
            "Норвегия (NO)",
            "о-в Буве (BV)",
            "о-в Мэн (IM)",
            "о-в Норфолк (NF)",
            "о-в Рождества (CX)",
            "о-в Св. Елены (SH)",
            "о-ва Питкэрн (PN)",
            "о-ва Тёркс и Кайкос (TC)",
            "о-ва Херд и Макдональд (HM)",
            "ОАЭ (AE)",
            "Оман (OM)",
            "Острова Кайман (KY)",
            "Острова Кука (CK)",
            "Пакистан (PK)",
            "Палау (PW)",
            "Палестинские территории (PS)",
            "Панама (PA)",
            "Папуа — Новая Гвинея (PG)",
            "Парагвай (PY)",
            "Перу (PE)",
            "Польша (PL)",
            "Португалия (PT)",
            "Пуэрто-Рико (PR)",
            "Республика Корея (KR)",
            "Реюньон (RE)",
            "Россия (RU)",
            "Руанда (RW)",
            "Румыния (RO)",
            "Сальвадор (SV)",
            "Самоа (WS)",
            "Сан-Марино (SM)",
            "Сан-Томе и Принсипи (ST)",
            "Саудовская Аравия (SA)",
            "Северная Македония (MK)",
            "Северные Марианские о-ва (MP)",
            "Сейшельские Острова (SC)",
            "Сен-Бартелеми (BL)",
            "Сен-Мартен (MF)",
            "Сен-Пьер и Микелон (PM)",
            "Сенегал (SN)",
            "Сент-Винсент и Гренадины (VC)",
            "Сент-Китс и Невис (KN)",
            "Сент-Люсия (LC)",
            "Сербия (RS)",
            "Сингапур (SG)",
            "Синт-Мартен (SX)",
            "Сирия (SY)",
            "Словакия (SK)",
            "Словения (SI)",
            "Соединенные Штаты (US)",
            "Соломоновы Острова (SB)",
            "Сомали (SO)",
            "Судан (SD)",
            "Суринам (SR)",
            "Сьерра-Леоне (SL)",
            "Таджикистан (TJ)",
            "Таиланд (TH)",
            "Тайвань (TW)",
            "Танзания (TZ)",
            "Того (TG)",
            "Токелау (TK)",
            "Тонга (TO)",
            "Тринидад и Тобаго (TT)",
            "Тувалу (TV)",
            "Тунис (TN)",
            "Туркменистан (TM)",
            "Турция (TR)",
            "Уганда (UG)",
            "Узбекистан (UZ)",
            "Украина (UA)",
            "Уоллис и Футуна (WF)",
            "Уругвай (UY)",
            "Фарерские о-ва (FO)",
            "Федеративные Штаты Микронезии (FM)",
            "Фиджи (FJ)",
            "Филиппины (PH)",
            "Финляндия (FI)",
            "Фолклендские о-ва (FK)",
            "Франция (FR)",
            "Французская Гвиана (GF)",
            "Французская Полинезия (PF)",
            "Французские Южные территории (TF)",
            "Хорватия (HR)",
            "Центрально-Африканская Республика (CF)",
            "Чад (TD)",
            "Черногория (ME)",
            "Чехия (CZ)",
            "Чили (CL)",
            "Швейцария (CH)",
            "Швеция (SE)",
            "Шпицберген и Ян-Майен (SJ)",
            "Шри-Ланка (LK)",
            "Эквадор (EC)",
            "Экваториальная Гвинея (GQ)",
            "Эритрея (ER)",
            "Эсватини (SZ)",
            "Эстония (EE)",
            "Эфиопия (ET)",
            "Южная Георгия и Южные Сандвичевы о-ва (GS)",
            "Южно-Африканская Республика (ZA)",
            "Южный Судан (SS)",
            "Ямайка (JM)",
            "Япония (JP)"
        };
    }
}