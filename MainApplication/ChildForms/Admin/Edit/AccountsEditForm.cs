using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
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
        AthleteCard athlete;
        private Label[] labels;
        public AccountsEditForm()
        {
            InitializeComponent();
            labels = new Label[] { profileInfoSurname, profileInfoName, profileInfoPatronymic, profileInfoBirthDate, profileInfoGender, profileInfoEmail, profileInfoHeight, profileInfoWeight };
            AthletesComboBoxStuff();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MakeAdminBut_Click(object sender, EventArgs e)
        {

        }

        private void DelAdminBut_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUserBut_Click(object sender, EventArgs e)
        {

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
                        (int)dataReader.GetValue(Constants.ID_FIELD),
                        (string)dataReader.GetValue(Constants.ACCOUNT_TABLE_EMAIL),
                        (string)dataReader.GetValue(Constants.ACCOUNT_TABLE_LOGIN),
                        (string)dataReader.GetValue(Constants.ACCOUNT_TABLE_PASSWORD),
                        Convert.ToBoolean(dataReader.GetValue(Constants.ACCOUNT_TABLE_ISADMIN))
                        );
                }
                dataReader.Close();

                athlete = Functionality.GetAtheleteInfo(athlete);
                Functionality.FillUserInfo(athlete, labels);
            }
        }
    }
}
