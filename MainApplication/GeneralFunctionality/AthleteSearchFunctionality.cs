using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using MainApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.GeneralFunctionality
{
    public class AthleteSearchFunctionality
    {
        public static List<AthleteCard> FindAll()
        {
            List<AthleteCard> list = new List<AthleteCard>();
            AthleteCard athlete;
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
            SqlCommand start = new SqlCommand("SELECT * FROM Athletes", Functionality.connection);
            SqlDataReader reader = start.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    athlete = new AthleteCard
                        (
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_SURNAME),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_NAME),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_PATRONYMIC),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_GENDER),
                        (DateTime)reader.GetValue(Constants.ATHLETES_TABLE_BIRTHDATE),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_HEIGHT),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_WEIGHT),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_ACHIEVEMENTS),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_NATIONALITY),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_SPORT_TYPE)
                        );
                    list.Add(athlete);
                }
            }

            reader.Close();
            return list;
        }
    }
}
