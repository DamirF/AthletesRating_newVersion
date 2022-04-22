using AthletesRating.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AthletesRating.Forms
{
    public partial class RegistrationForm : Form
    {
        #region Fields
        private SqlConnection connection = null;
        private Regex passCheck = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,}$");
        private readonly string symbols = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";
        private readonly string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
        private string emailVerCode;
        private Timer timer;
        private int sendInterval;
        private bool mailIsCorrect, passIsCorrect;
        #endregion
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersDataBase"].ConnectionString);
            connection.Open();

            GenderCB.SelectedIndex = 0;
            GenderCB.Text = GenderCB.Items[0].ToString();
            RegBut.Enabled = false;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            sendInterval = 60;
            mailIsCorrect = false;
            passIsCorrect = false;
        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(sendInterval > 9) timerLabel.Text = "00:" + (--sendInterval).ToString();
            else timerLabel.Text = "00:0" + (--sendInterval).ToString();
            if (sendInterval == 0)
            {
                EmailVerificationBut.Enabled = true;
                timer.Stop();
                sendInterval = 0;
                timerLabel.Text = "";
            }
        }

        private bool CheckFields(params string[] fields)
        {
            bool allowRegistration = true;
            foreach (string field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    allowRegistration = false;
                    break;
                }
            }
            return allowRegistration;
        }

        #region TextChanged Events

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EmailTB.Text, cond))
            {
                EmailError.Text = "Недопустимый адрес!";
                mailIsCorrect = false;
                loginTB.Text = "";
            }
            else
            {
                EmailError.Text = "";
                mailIsCorrect = true;
                int sInd = EmailTB.Text.IndexOf('@');
                loginTB.Text = EmailTB.Text.Substring(0, sInd);
            }
            if (EmailTB.TextLength == 0)
            {
                EmailError.Text = "";
                loginTB.Text = "";
            }
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            if (!passCheck.IsMatch(passwordTB.Text))
            {
                passError.Text = "Пароль некорректный!";
                passIsCorrect = false;
            }
            else
            {
                passError.Text = "";
                passIsCorrect = true;
            }
            if(passwordTB.TextLength == 0)
            {
                passError.Text = "";
            }
        }

        private void conPassTB_TextChanged(object sender, EventArgs e)
        {
            if (conPassTB.Text != passwordTB.Text)
            {
                conPassError.Text = "Пароди не совпадают!";
                passIsCorrect = false;
            }
            else
            {
                conPassError.Text = "";
                passIsCorrect = true;
            }
            if (conPassTB.TextLength == 0)
            {
                conPassError.Text = "";
            }
        }
        #endregion

        #region Click Events
        private void EmailVerification_Click(object sender, EventArgs e)
        {
            if (!CheckFields(UserSurname.Text, UserName.Text, EmailTB.Text) || !passIsCorrect || !mailIsCorrect) return;

            SqlCommand emailCount = new SqlCommand("SELECT COUNT(Email) FROM Accounts WHERE Email = @email", connection);
            emailCount.Parameters.AddWithValue("@email", EmailTB.Text);

            SqlCommand loginCount = new SqlCommand("SELECT COUNT(Login) FROM Accounts WHERE Login = @log", connection);
            loginCount.Parameters.AddWithValue("@log", loginTB.Text);

            if (Convert.ToUInt32(emailCount.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Пользователь с таким E-mail уже зарегистрирован!");
                return;
            }
            else if(Convert.ToUInt32(loginCount.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Логин занят!");
                return;
            }

            EVerLabel.Visible = true;
            EmailVerificationTB.Visible = true;
            timerInfoLabel.Visible = true;
            emailVerCode = "";
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                emailVerCode += symbols[rnd.Next(symbols.Length)];
            }

            try
            {
                EmailVerificationMessage.SendMessage(EmailTB.Text, emailVerCode);
                timer.Start();

                RegBut.Enabled = true;
                EmailVerificationBut.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            if (EmailVerificationTB.Text == "") return;
            if (EmailVerificationTB.Text != emailVerCode)
            {
                EmailVerificationTB.Text = "Неверный код!";
            }
            else
            {
                AthleteCard newAthlete = new AthleteCard(UserSurname.Text, UserName.Text, UserPatronymic.Text, GenderCB.Text, DateTime.Parse(BirthDateTP.Text), EmailTB.Text, loginTB.Text, Security.GenerateHash(passwordTB.Text).ToString(), false);
                newAthlete.NewUserRegistration(connection);
                MessageBox.Show("Пользователь успешно зарегистрирован");
                Close();
            }

        }
        #endregion

        #region Password Visible
        private void passView_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTB.UseSystemPasswordChar = false;
        }

        private void passView_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTB.UseSystemPasswordChar = true;
        }

        private void passConView_MouseDown(object sender, MouseEventArgs e)
        {
            conPassTB.UseSystemPasswordChar = false;
        }

        private void passConView_MouseUp(object sender, MouseEventArgs e)
        {
            conPassTB.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
