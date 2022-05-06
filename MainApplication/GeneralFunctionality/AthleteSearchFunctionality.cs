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
        private static string and = " AND";
        private static string where = " WHERE";
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
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_NATIONALITY),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_SPORT_TYPE)
                        );
                    list.Add(athlete);
                }
            }

            reader.Close();
            return list;
        }

        public static List<AthleteCard> SewrchWithParameters(ref Control[] controls)
        {
            TextBox fullName = (TextBox)controls[0];
            ComboBox sportType = (ComboBox)controls[1];
            ComboBox nationality = (ComboBox)controls[2];

            AthleteCard athlete;
            List<AthleteCard> list = new List<AthleteCard>();
            List<AthleteCard> tempList = new List<AthleteCard>();
            int paramsCount = 0;

            if(sportType.SelectedIndex != 0) paramsCount++;
            if(nationality.SelectedIndex != 0) paramsCount++;

            string command = "SELECT * FROM Athletes";

            if (paramsCount != 0) command += where;
            if (sportType.SelectedIndex != 0) command += $" SportType = {sportType.SelectedIndex}";
            if (paramsCount > 1) command += and;
            if (nationality.SelectedIndex != 0) command += $" Nationality = '{nationality.SelectedIndex}'";

            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
            SqlCommand search = new SqlCommand(command, Functionality.connection);
            SqlDataReader reader = search.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
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
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_NATIONALITY),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_SPORT_TYPE)
                        );
                    tempList.Add(athlete);
                }
            }

            reader.Close();

            if(string.IsNullOrEmpty(fullName.Text))
            {
                return tempList;
            }
            else
            {
                string fullname;
                for(int i = 0; i < tempList.Count; i++)
                {
                    fullname = tempList[i].fullName.Surname + " " + tempList[i].fullName.Name + " " + tempList[i].fullName.Patronymic;
                    if (fullname.Contains(fullName.Text)) list.Add(tempList[i]);
                }
                return list;
            }
        }
    }
}
