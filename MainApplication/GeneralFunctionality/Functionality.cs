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
            SqlCommand getInfo = new SqlCommand("SELECT * FROM [Athletes] WHERE Id = @id", connection);
            getInfo.Parameters.AddWithValue("@id", card.GetID());
            SqlDataReader reader = getInfo.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    card = new AthleteCard(
                        card.GetID(),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_SURNAME),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_NAME),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_PATRONYMIC),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_GENDER),
                        (DateTime)reader.GetValue(Constants.ATHLETES_TABLE_BIRTHDATE),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_HEIGHT),
                        (int)reader.GetValue(Constants.ATHLETES_TABLE_WEIGHT),
                        (string)reader.GetValue(Constants.ATHLETES_TABLE_ACHIEVEMENTS),
                        card.GetAccountInfo().GetEmail(),
                        card.GetAccountInfo().GetLogin(),
                        card.GetAccountInfo().GetPassword(),
                        card.GetAccountInfo().IsAdmin()
                        );
                }
            }
            else
            {
                SqlCommand delete = new SqlCommand("DELETE FROM [Accounts] WHERE Id = @id", connection);
                delete.Parameters.AddWithValue("@id", card.GetID());
                delete.ExecuteNonQuery();
                return null;
            }
            reader.Close();
            return card;
        }

        public static void FillUserInfo(AthleteCard athlete, params Label[] labels)
        {
            if (athlete == null || labels.Length < 8) return;
            labels[Constants.LABEL_USERINFO_SURNAME].Text = athlete.GetFullName().GetSurname();
            labels[Constants.LABEL_USERINFO_NAME].Text = athlete.GetFullName().GetName();
            labels[Constants.LABEL_USERINFO_PATRONYMIC].Text = athlete.GetFullName().GetPatronymic();
            labels[Constants.LABEL_USERINFO_BIRTHDATE].Text = athlete.GetBirthDate().ToShortDateString();
            labels[Constants.LABEL_USERINFO_GENDER].Text = athlete.GetGender();
            labels[Constants.LABEL_USERINFO_EMAIL].Text = athlete.GetAccountInfo().GetEmail();
            labels[Constants.LABEL_USERINFO_HEIGHT].Text = athlete.GetHeight().ToString() + " см";
            labels[Constants.LABEL_USERINFO_WEIGHT].Text = athlete.GetWeight().ToString() + " кг";
        }

        public static AthleteCard ChangeFullName(AthleteCard card, params TextBox[] boxes)
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = null;
            if(!String.IsNullOrEmpty(boxes[Constants.CHANGEFULLNAME_SURNAME].Text))
            {
                command = new SqlCommand("UPDATE Athletes SET Surname = @value WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@value", boxes[Constants.CHANGEFULLNAME_SURNAME].Text);
                command.Parameters.AddWithValue("@id", card.GetID());
                command.ExecuteNonQuery();

                card.SetFullName(new FullName(boxes[Constants.CHANGEFULLNAME_SURNAME].Text, card.GetFullName().GetName(), card.GetFullName().GetPatronymic()));
            }
            if (!String.IsNullOrEmpty(boxes[Constants.CHANGEFULLNAME_NAME].Text))
            {
                command = new SqlCommand("UPDATE Athletes SET Name = @value WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@value", boxes[Constants.CHANGEFULLNAME_NAME].Text);
                command.Parameters.AddWithValue("@id", card.GetID());
                command.ExecuteNonQuery();

                card.SetFullName(new FullName(card.GetFullName().GetSurname(), boxes[Constants.CHANGEFULLNAME_NAME].Text, card.GetFullName().GetPatronymic()));
            }
            if (!String.IsNullOrEmpty(boxes[Constants.CHANGEFULLNAME_PATRONYMIC].Text))
            {
                command = new SqlCommand("UPDATE Athletes SET Patronymic = @value WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@value", boxes[Constants.CHANGEFULLNAME_PATRONYMIC].Text);
                command.Parameters.AddWithValue("@id", card.GetID());
                command.ExecuteNonQuery();

                card.SetFullName(new FullName(card.GetFullName().GetSurname(), card.GetFullName().GetName(), boxes[Constants.CHANGEFULLNAME_PATRONYMIC].Text));
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
            if(card.GetAccountInfo().GetPassword() + Security.AddSult() == Security.GenerateHash(boxes[Constants.CHANGEPASSWORD_OLDPASS].Text).ToString() + Security.AddSult())
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand changePass = new SqlCommand("UPDATE Accounts SET Password = @pass WHERE Id = @id", connection);
                changePass.Parameters.AddWithValue("@pass", Security.GenerateHash(boxes[Constants.CHANGEPASSWORD_NEWPASS].Text).ToString());
                changePass.Parameters.AddWithValue("@id", card.GetID());
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
            SqlCommand deleteFromAccounts = new SqlCommand("DELETE FROM Accounts WHERE Id = @id", connection);
            deleteFromAccounts.Parameters.AddWithValue("@id", card.GetID());
            SqlCommand deleteFromAthletes = new SqlCommand("DELETE FROM Athletes WHERE Id = @id", connection);
            deleteFromAthletes.Parameters.AddWithValue("@id", card.GetID());
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
                SqlCommand heightChange = new SqlCommand("UPDATE Athletes SET Height = @height WHERE Id = @id", connection);
                heightChange.Parameters.AddWithValue("height", height.Text);
                heightChange.Parameters.AddWithValue("id", card.GetID());
                heightChange.ExecuteNonQuery();
                card.SetHeight(Convert.ToInt32(height.Text));
            }
            if (!String.IsNullOrEmpty(weight.Text))
            {
                SqlCommand weightChange = new SqlCommand("UPDATE Athletes SET Weight = @weight WHERE Id = @id", connection);
                weightChange.Parameters.AddWithValue("weight", weight.Text);
                weightChange.Parameters.AddWithValue("id", card.GetID());
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
            
                SqlCommand birthDateChange = new SqlCommand("UPDATE Athletes SET BirthDate = @birthDate WHERE Id = @id", connection);
                birthDateChange.Parameters.AddWithValue("birthDate", timePicker.Value);
                birthDateChange.Parameters.AddWithValue("id", card.GetID());
                birthDateChange.ExecuteNonQuery();
                card.SetBirthDate(timePicker.Value);
            
            return card;
        }
    }
}
