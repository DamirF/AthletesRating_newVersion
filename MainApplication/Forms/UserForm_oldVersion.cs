using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using SportsmansRating;

namespace AthletesRating.Forms
{
    public partial class UserForm_oldVersion : Form
    {
        private AthleteCard athlete;
        private Label[] labels;
        private Regex passCheck = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,}$");
        private bool passCorrect, passConCorrect;

        public UserForm_oldVersion()
        {
            InitializeComponent();
            athlete = AuthorizationForm.GetAthlete();
            labels = new Label[8] { UserInfoSurname, UserInfoName, UserInfoPatronymic, UserInfoBirthDate, UserInfoGender, UserInfoEmail, UserInfoHeight, UserInfoWeight };
            passCorrect = false;
            passConCorrect = false;
            newPassError.Text = "";
            newPassConError.Text = "";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if(Functionality.connection.State == ConnectionState.Closed)Functionality.connection.Open();
            athlete = Functionality.GetAtheleteInfo(athlete);
            if(athlete == null)
            {
                AuthorizationForm authorization = new AuthorizationForm();
                authorization.Show();
                MessageBox.Show("Не удалось найти информацию пользователя.\nАккаунт удален.\nПожалуйста, пройдите повторную регистрацию.");
                Close();
                return;
            }
            Functionality.FillUserInfo(athlete, labels);

            BirthDateChange.Value = athlete.GetBirthDate();
        }

        private void nameChangeBut_Click(object sender, EventArgs e)
        {

            if (Security.GenerateHash(nameChangeConfirmTB.Text) + Security.GenerateHash(DateTime.Now.ToString()).ToString() == athlete.GetAccountInfo().GetPassword() + Security.GenerateHash(DateTime.Now.ToString()).ToString())
            {
                athlete = Functionality.ChangeFullName(athlete, lastNameChangeTB, firstNameChangeTB, patronymicChangeTB);
                Functionality.FillUserInfo(athlete, labels);
                nameChangeConfirmTB.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void deleteAccountBut_Click(object sender, EventArgs e)
        {
            if(athlete.GetAccountInfo().GetPassword() + Security.AddSult() == Security.GenerateHash(deleteAccountPassTB.Text) + Security.AddSult())
            {
                Functionality.DeleteAccount(athlete);
                Functionality.AccountExit(this);
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void ExitAccountBut_Click(object sender, EventArgs e)
        {
            Functionality.AccountExit(this);
        }

        private void ParametersTextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar)) e.Handled = true;
        }

        private void ConfirmParametersChange_Click(object sender, EventArgs e)
        {
            if (HeightChangeTB.Text == "" && WeightChangeTB.Text == "") return;
            athlete = Functionality.ParametersChange(athlete, HeightChangeTB, WeightChangeTB);
            Functionality.FillUserInfo(athlete, labels);
        }

        private void ConfirmNewBirthDate_Click(object sender, EventArgs e)
        {
            athlete = Functionality.BirthDateChange(athlete, BirthDateChange);
            UserInfoBirthDate.Text = athlete.GetBirthDate().ToShortDateString();
        }

        private void newPassTB_TextChanged(object sender, EventArgs e)
        {
            if (passCheck.IsMatch(newPassTB.Text))
            {
                passCorrect = true;
                newPassError.Text = "";
            }
            else
            {
                passCorrect = false;
                newPassError.Text = "Пароль неккоректный!";
            }
            if (newPassTB.TextLength == 0)
            {
                passCorrect = false;
                newPassError.Text = "";
            }
        }

        private void passChangeBut_Click(object sender, EventArgs e)
        {
            if(passCorrect && passConCorrect)
            {
                athlete = Functionality.ChangePassword(athlete, oldPassTB, newPassTB, newPassConfirmTB);
            }
        }

        private void newPassConfirmTB_TextChanged(object sender, EventArgs e)
        {
            if (!passCheck.IsMatch(newPassConfirmTB.Text) || newPassConfirmTB.Text != newPassTB.Text)
            {
                passConCorrect = false;
                newPassConError.Text = "Пароли не совпадают!";
            }
            else
            {
                passConCorrect = true;
                newPassConError.Text = "";
            }
            if (newPassConfirmTB.TextLength == 0)
            {
                passConCorrect = false;
                newPassConError.Text = "";
            }
        }
    }
}
