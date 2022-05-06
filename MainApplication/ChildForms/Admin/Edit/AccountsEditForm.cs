using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using MainApplication.GeneralFunctionality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.ChildForms.Admin.Edit
{
    public partial class AccountsEditForm : Form
    {
        private const string makeAdminCommand = "UPDATE Accounts SET IsAdmin = 1 WHERE Login = @log";
        private const string deleteAdminCommand = "UPDATE Accounts SET IsAdmin = 0 WHERE Login = @log";
        private const string deleteUserFromAccountsCommand = "DELETE FROM Accounts WHERE Login = @log";
        private const string deleteUserFromAthletesCommand = "DELETE FROM Athletes WHERE Login = @log";

        private AthleteCard athlete;
        private AthleteCard admin;

        public AccountsEditForm(AthleteCard admin)
        {
            this.admin = admin;
            InitializeComponent();
            AthletesComboBoxStuff();
        }

        private void FillAccountInfo(ref AthleteCard account)
        {
            ProfilePicture.ProfilePictureSet(ref InfoProfilePhoto, ref account);
            InfoSurname.Text = account.fullName.Surname;
            InfoName.Text = account.fullName.Name;
            InfoPatronymic.Text = account.fullName.Patronymic; 
            InfoGender.Text = account.Gender;
            InfoBirthDate.Text = account.BirthDate.ToShortDateString() + ", (" +account.CalculateAge().ToString() + ")";
            InfoNationality.Text = Constants.Countries[account.nationality]; 
            InfoEmail.Text = account.accountInfo.Email;
            InfoLogin.Text = account.accountInfo.Login;
            switch(account.accountInfo.isAdmin)
            {
                case true:
                    InfoStature.Text = "Администратор";
                    break;
                case false:
                    InfoStature.Text = "Пользователь";
                    break;
            }
            if (String.IsNullOrEmpty(InfoPatronymic.Text)) InfoPatronymic.Text = "не указано";
            if (String.IsNullOrEmpty(InfoNationality.Text)) InfoNationality.Text = "не указано";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MakeAdminBut_Click(object sender, EventArgs e)
        {
            if (athlete == null) return;

            if (athlete.accountInfo.Email == Constants.MAIN_ADMIN
                || (admin.accountInfo.Email != Constants.MAIN_ADMIN && athlete.accountInfo.isAdmin))
            {
                MessageBox.Show("У Вас недостаточно прав для данного действия!");
                return;
            }

            if (!athlete.accountInfo.isAdmin)
            {
                if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
                athlete.accountInfo.SetAdmin();

                SqlCommand makeAdmin = new SqlCommand(makeAdminCommand, Functionality.connection);
                makeAdmin.Parameters.AddWithValue("log", athlete.accountInfo.Login);
                makeAdmin.ExecuteNonQuery();

                FillAccountInfo(ref athlete);
            }
            else
            {
                MessageBox.Show("Пользователь уже является админом!");
            }
        }

        private void DelAdminBut_Click(object sender, EventArgs e)
        {
            if (athlete == null) return;

            if(athlete.accountInfo.Email == Constants.MAIN_ADMIN
                || (admin.accountInfo.Email != Constants.MAIN_ADMIN && athlete.accountInfo.isAdmin))
            {
                MessageBox.Show("У Вас недостаточно прав для данного действия!");
                return;
            }
            if (athlete.accountInfo.isAdmin)
            {
                if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
                athlete.accountInfo.DelAdmin();

                SqlCommand deleteAdmin = new SqlCommand(deleteAdminCommand, Functionality.connection);
                deleteAdmin.Parameters.AddWithValue("log", athlete.accountInfo.Login);
                deleteAdmin.ExecuteNonQuery();

                FillAccountInfo(ref athlete);
            }
            else
            {
                MessageBox.Show("Пользователь не является админом");
            }
        }

        private void DeleteUserBut_Click(object sender, EventArgs e)
        {
            if (athlete == null) return;

            if (athlete.accountInfo.Email == Constants.MAIN_ADMIN || athlete.accountInfo.isAdmin)
            {
                MessageBox.Show("У Вас недостаточно прав для данного действия!");
                return;
            }

            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();

            SqlCommand delFromAccounts = new SqlCommand(deleteUserFromAccountsCommand, Functionality.connection);
            delFromAccounts.Parameters.AddWithValue("log", athlete.accountInfo.Login);
            delFromAccounts.ExecuteNonQuery();

            SqlCommand delFromAthletes = new SqlCommand(deleteUserFromAthletesCommand, Functionality.connection);
            delFromAthletes.Parameters.AddWithValue("log", athlete.accountInfo.Login);
            delFromAthletes.ExecuteNonQuery();

            AthletesComboBox.Items.RemoveAt(AthletesComboBox.SelectedIndex);
        }

        private void AthletesComboBoxStuff()
        {
            AthletesComboBox.Items.Clear();
            if(Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
            SqlCommand stuff = new SqlCommand("SELECT Email FROM Accounts", Functionality.connection);
            SqlDataReader dataReader = stuff.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    AthletesComboBox.Items.Add(dataReader.GetValue(0).ToString());
                }
            }
            dataReader.Close();
        }

        private void AthletesComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AthletesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
            SqlCommand getAthlete = new SqlCommand("SELECT * FROM Accounts WHERE Email = @mail", Functionality.connection);
            getAthlete.Parameters.AddWithValue("mail", AthletesComboBox.Items[AthletesComboBox.SelectedIndex].ToString());
            SqlDataReader dataReader = getAthlete.ExecuteReader();

            if(dataReader.HasRows)
            {
                while(dataReader.Read())
                {
                    athlete = new AthleteCard
                        (
                        (string)dataReader.GetValue(Constants.ACCOUNT_TABLE_EMAIL),
                        (string)dataReader.GetValue(Constants.ACCOUNT_TABLE_LOGIN),
                        (string)dataReader.GetValue(Constants.ACCOUNT_TABLE_PASSWORD),
                        Convert.ToBoolean(dataReader.GetValue(Constants.ACCOUNT_TABLE_ISADMIN))
                        );
                }
                dataReader.Close();

                athlete = Functionality.GetAtheleteInfo(athlete);
                FillAccountInfo(ref athlete);
            }
        }
    }
}
