using AthletesRating.Forms;
using AthletesRating.Models;
using MainApplication.Forms;
using SportsmansRating;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AthletesRating.GeneralFunctionality
{
    internal class Functionality
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersDataBase"].ConnectionString);
        private static Regex passCheck = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,}$");
        private static bool passCorrect;

        public static AthleteCard GetAtheleteInfo(AthleteCard card)
        {
            SqlCommand getInfo = new SqlCommand("SELECT * FROM [Athletes] WHERE Login = @log", connection);
            getInfo.Parameters.AddWithValue("@log", card.accountInfo.Login);
            SqlDataReader reader = getInfo.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    card = new AthleteCard(
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_SURNAME),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_NAME),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_PATRONYMIC),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_GENDER),
                        (DateTime)reader.GetValue(Constants.ATHLETES_TABLE_BIRTHDATE),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_HEIGHT),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_WEIGHT),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_ACHIEVEMENTS),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_NATIONALITY),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_SPORT_TYPE),
                        card.accountInfo.Email,
                        card.accountInfo.Login,
                        card.accountInfo.Password,
                        card.accountInfo.isAdmin
                        );
                }
            }
            else
            {
                SqlCommand delete = new SqlCommand("DELETE FROM [Accounts] WHERE Login = @log", connection);
                delete.Parameters.AddWithValue("@log", card.accountInfo.Login);
                delete.ExecuteNonQuery();
                return null;
            }
            reader.Close();
            return card;
        }

        public static AthleteCard ChangeFullName(AthleteCard card, params TextBox[] boxes)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = null;
            if(!String.IsNullOrEmpty(boxes[Constants.CHANGEFULLNAME_SURNAME].Text))
            {
                command = new SqlCommand("UPDATE Athletes SET Surname = @value  WHERE Login = @log", connection);
                command.Parameters.AddWithValue("@value", boxes[Constants.CHANGEFULLNAME_SURNAME].Text);
                command.Parameters.AddWithValue("@log", card.accountInfo.Login);
                command.ExecuteNonQuery();

                card.SetFullName(new FullName(boxes[Constants.CHANGEFULLNAME_SURNAME].Text, card.fullName.Name, card.fullName.Patronymic));
            }
            if (!String.IsNullOrEmpty(boxes[Constants.CHANGEFULLNAME_NAME].Text))
            {
                command = new SqlCommand("UPDATE Athletes SET Name = @value  WHERE Login = @log", connection);
                command.Parameters.AddWithValue("@value", boxes[Constants.CHANGEFULLNAME_NAME].Text);
                command.Parameters.AddWithValue("@log", card.accountInfo.Login);
                command.ExecuteNonQuery();

                card.SetFullName(new FullName(card.fullName.Surname, boxes[Constants.CHANGEFULLNAME_NAME].Text, card.fullName.Patronymic));
            }
            if (!String.IsNullOrEmpty(boxes[Constants.CHANGEFULLNAME_PATRONYMIC].Text))
            {
                command = new SqlCommand("UPDATE Athletes SET Patronymic = @value  WHERE Login = @log", connection);
                command.Parameters.AddWithValue("@value", boxes[Constants.CHANGEFULLNAME_PATRONYMIC].Text);
                command.Parameters.AddWithValue("@log", card.accountInfo.Login);
                command.ExecuteNonQuery();

                card.SetFullName(new FullName(card.fullName.Surname, card.fullName.Name, boxes[Constants.CHANGEFULLNAME_PATRONYMIC].Text));
            }
            foreach (TextBox box in boxes) box.Text = "";
            return card;
        }

        public static bool PasswordTextChanged(TextBox pass)
        {
            if (!passCheck.IsMatch(pass.Text))
            {
                passCorrect = false;
            }
            else
            {
                passCorrect = true;
            }
            return passCorrect;
        }

        public static bool PasswordConfirmTextChanged(TextBox newPassCon, TextBox newPass)
        {
            if (!passCheck.IsMatch(newPassCon.Text) || newPassCon.Text != newPass.Text)
            {
                passCorrect = false;
            }
            else
            {
                passCorrect = true;
            }
            return passCorrect;
        }

        public static AthleteCard ChangePassword(AthleteCard card, params TextBox[] boxes)
        {
            if(card.accountInfo.Password + Security.AddSult() == Security.GenerateHash(boxes[Constants.CHANGEPASSWORD_OLDPASS].Text).ToString() + Security.AddSult())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand changePass = new SqlCommand("UPDATE Accounts SET Password = @pass WHERE Login = @log", connection);
                changePass.Parameters.AddWithValue("@pass", Security.GenerateHash(boxes[Constants.CHANGEPASSWORD_NEWPASS].Text).ToString());
                changePass.Parameters.AddWithValue("@log", card.accountInfo.Login);
                changePass.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
            foreach (TextBox box in boxes) box.Text = "";
            return card;
        }

        public static void DeleteAccount(AthleteCard card)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand deleteFromAccounts = new SqlCommand("DELETE FROM Accounts WHERE Login = @log", connection);
            deleteFromAccounts.Parameters.AddWithValue("@log", card.accountInfo.Login);
            SqlCommand deleteFromAthletes = new SqlCommand("DELETE FROM Athletes WHERE Login = @log", connection);
            deleteFromAthletes.Parameters.AddWithValue("@log", card.accountInfo.Login);
            deleteFromAccounts.ExecuteNonQuery();
            deleteFromAthletes.ExecuteNonQuery();
        }

        public static void AccountExit(MainForm main)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
            main.Hide();
        }

        public static AthleteCard ParametersChange(AthleteCard card, TextBox height, TextBox weight)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            if (!String.IsNullOrEmpty(height.Text))
            {
                SqlCommand heightChange = new SqlCommand("UPDATE Athletes SET Height = @height WHERE Login = @log", connection);
                heightChange.Parameters.AddWithValue("height", height.Text);
                heightChange.Parameters.AddWithValue("@log", card.accountInfo.Login);
                heightChange.ExecuteNonQuery();
                card.SetHeight(Convert.ToInt32(height.Text));
            }
            if (!String.IsNullOrEmpty(weight.Text))
            {
                SqlCommand weightChange = new SqlCommand("UPDATE Athletes SET Weight = @weight WHERE Login = @log", connection);
                weightChange.Parameters.AddWithValue("weight", weight.Text);
                weightChange.Parameters.AddWithValue("@log", card.accountInfo.Login);
                weightChange.ExecuteNonQuery();
                card.SetWeight(Convert.ToInt32(weight.Text));
            }
            weight.Text = "";
            height.Text = "";
            return card;
        }

        public static AthleteCard BirthDateChange(AthleteCard card, DateTimePicker timePicker)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            
                SqlCommand birthDateChange = new SqlCommand("UPDATE Athletes SET BirthDate = @birthDate WHERE Login = @log", connection);
                birthDateChange.Parameters.AddWithValue("birthDate", timePicker.Value);
                birthDateChange.Parameters.AddWithValue("@log", card.accountInfo.Login);
                birthDateChange.ExecuteNonQuery();
                card.SetBirthDate(timePicker.Value);
            
            return card;
        }

        public static AthleteCard NationalityChange(AthleteCard card, ComboBox comboBox)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand birthDateChange = new SqlCommand("UPDATE Athletes SET Nationality = @nationality WHERE Login = @log", connection);
            birthDateChange.Parameters.AddWithValue("nationality", comboBox.Items[comboBox.SelectedIndex].ToString());
            birthDateChange.Parameters.AddWithValue("@log", card.accountInfo.Login);
            birthDateChange.ExecuteNonQuery();
            card.SetNationality(comboBox.SelectedIndex);

            return card;
        }

        public static AthleteCard SportTypeChange(AthleteCard card, ComboBox comboBox)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand birthDateChange = new SqlCommand("UPDATE Athletes SET SportType = @sportType WHERE Login = @log", connection);
            birthDateChange.Parameters.AddWithValue("sportType", comboBox.Items[comboBox.SelectedIndex].ToString());
            birthDateChange.Parameters.AddWithValue("@log", card.accountInfo.Login);
            birthDateChange.ExecuteNonQuery();
            card.SetSportType(comboBox.SelectedIndex);

            return card;
        }

        public static void ComboBoxStuff(ref ComboBox cb, ref string[] data)
        {
            cb.Items.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                cb.Items.Add(data[i]);
            }
        }
    }
}
