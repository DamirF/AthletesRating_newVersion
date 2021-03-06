using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using SportsmansRating;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MainApplication.ChildForms.Settings
{
    public partial class AccountSettingsForm : Form
    {
        AthleteCard athlete;
        private Regex passCheck = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,}$");
        private bool passCorrect, passConCorrect;

        public AccountSettingsForm(AthleteCard athlete)
        {
            InitializeComponent();
            this.athlete = athlete;
            passCorrect = false;
            passConCorrect = false;
            newPassConError.Text = "";
            newPassError.Text = "";
            BirthDateChange.Value = this.athlete.BirthDate;

            if (this.athlete.accountInfo.Email == Constants.MAIN_ADMIN) 
                deleteAccountBut.Enabled = false;

            Functionality.ComboBoxStuff(ref natCB, ref Constants.Countries);
            if(athlete.nationality != 0) natCB.SelectedIndex = natCB.Items.IndexOf(Constants.Countries[athlete.nationality]);
            else natCB.SelectedIndex = 0;

            Functionality.ComboBoxStuff(ref STCB, ref Constants.SportTypes);
            if (athlete.sportType != 0) STCB.SelectedIndex = STCB.Items.IndexOf(Constants.SportTypes[athlete.sportType]);
            else STCB.SelectedIndex = 0;

            natCB.Text = natCB.Items[natCB.SelectedIndex].ToString();
            STCB.Text = STCB.Items[STCB.SelectedIndex].ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HeightChangeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar)) e.Handled = true;
        }

        #region Click Events
        private void deleteAccountBut_Click(object sender, EventArgs e)
        {
            if (athlete.accountInfo.Password + Security.AddSult() == Security.GenerateHash(deleteAccountPassTB.Text) + Security.AddSult())
            {
                Functionality.DeleteAccount(athlete);
                Close();
                AuthorizationForm authorization = new AuthorizationForm();
                authorization.Show();
                
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void nameChangeBut_Click(object sender, EventArgs e)
        {
            if (Security.GenerateHash(nameChangeConfirmTB.Text) + Security.AddSult() == athlete.accountInfo.Password + Security.AddSult())
            {
                athlete = Functionality.ChangeFullName(athlete, lastNameChangeTB, firstNameChangeTB, patronymicChangeTB);
                nameChangeConfirmTB.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void ConfirmParametersChange_Click(object sender, EventArgs e)
        {
            if (HeightChangeTB.Text == "" && WeightChangeTB.Text == "") return;
            athlete = Functionality.ParametersChange(athlete, HeightChangeTB, WeightChangeTB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            athlete = Functionality.BirthDateChange(athlete, BirthDateChange);
        }

        private void passChangeBut_Click(object sender, EventArgs e)
        {
            if (passCorrect && passConCorrect)
            {
                athlete = Functionality.ChangePassword(athlete, oldPassTB, newPassTB, newPassConfirmTB);
            }
        }

        private void natChangeBut_Click(object sender, EventArgs e)
        {
            if (natCB.SelectedIndex == -1) return;
            athlete = Functionality.NationalityChange(athlete, natCB.SelectedIndex);
        }

        private void spChangeBut_Click(object sender, EventArgs e)
        {
            if (STCB.SelectedIndex == -1) return;
            athlete = Functionality.SportTypeChange(athlete, STCB.SelectedIndex);
        }
        #endregion

        #region TextChanged Events
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

        private void natCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
        #endregion
    }
}
