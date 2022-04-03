namespace AthletesRating.Models
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

        public const string MAIN_ADMIN = "d.fatkhullin@mail.ru";
    }
}