using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AthletesRating.Forms;
using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using MainApplication.Forms;

namespace SportsmansRating
{
    public partial class AuthorizationForm : Form
    {
        private static AthleteCard athlete = null;

        private readonly string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
        private bool mailIsCorrect, passIsCorrect;
        private Regex passCheck = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,}$");
        private readonly string symbols = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";
        private Timer timer;
        private int sendInterval;
        private string emailVerCode = "";
        private string EmailPassRecovery;

        public AuthorizationForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }

        
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
            RecoveryPanel.Visible = false;
            mailIsCorrect = false;
            passIsCorrect = false;
            sendInterval = 0;
        }

        public static AthleteCard GetAthlete() => athlete;

        private void passwordRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!EmailVerificationMessage.CheckForInternetConnection())
            {
                MessageBox.Show("Проверьте подключение к интернету!");
                return;
            }
            RecoveryPanel.Visible = true;
            verInfo.Visible = false; ;
            EmailVerTB.Visible = false;
            ConEmailBut.Visible = false;
            SaveBut.Enabled = false;
            Text = "Восстановление пароля";
        }

        private void registrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!EmailVerificationMessage.CheckForInternetConnection())
            {
                MessageBox.Show("Проверьте подключение к интернету!");
                return;
            }
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
        }

        private void signINbut_Click(object sender, EventArgs e)
        {
            if(loginTB.Text == "stuff" && passwordTB.Text == "stuff")
            {
                StuffScr stuff = new StuffScr();
                stuff.ShowDialog();
                loginTB.Text = passwordTB.Text = "";
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersDataBase"].ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand authorize = new SqlCommand("SELECT * FROM [Accounts] WHERE Login = @login AND Password + @sult = @password", sqlConnection);
                    authorize.Parameters.AddWithValue("@login", loginTB.Text);
                    authorize.Parameters.AddWithValue("@sult", Security.AddSult());
                    authorize.Parameters.AddWithValue("@password", Security.GenerateHash(passwordTB.Text) + Security.AddSult());

                    SqlDataReader accountsReader = authorize.ExecuteReader();

                    if (accountsReader.HasRows)
                    {


                        while (accountsReader.Read())
                        {
                            athlete = new AthleteCard
                                (
                                    (string)accountsReader.GetValue(Constants.ACCOUNT_TABLE_EMAIL),
                                    (string)accountsReader.GetValue(Constants.ACCOUNT_TABLE_LOGIN),
                                    (string)accountsReader.GetValue(Constants.ACCOUNT_TABLE_PASSWORD),
                                    Convert.ToBoolean(accountsReader.GetValue(Constants.ACCOUNT_TABLE_ISADMIN))
                                );
                        }

                        Hide();
                        MainForm main = new MainForm();
                        main.Show();
                        Functionality.connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                    accountsReader.Close();

                }
            }
        }

        #region Rassword Recovery

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            if(EmailTB.TextLength == 0) EmailErrorLabel.Text = "";
            if (!Regex.IsMatch(EmailTB.Text, cond))
            {
                EmailErrorLabel.Text = "Недопустимый адрес!";
                mailIsCorrect = false;
            }
            else
            {
                EmailErrorLabel.Text = "";
                mailIsCorrect = true;
            }
        }

        private void newPassTB_TextChanged(object sender, EventArgs e)
        {
            if (!passCheck.IsMatch(newPassTB.Text))
            {
                PassError.Text = "Пароль некорректный!";
                passIsCorrect = false;
            }
            else
            {
                PassError.Text = "";
                passIsCorrect = true;
            }

            if (newPassTB.TextLength == 0) PassError.Text = "";

            if (newPassConTB.Text != newPassTB.Text && newPassConTB.Text != "")
            {
                ConPassError.Text = "Пароди не совпадают!";
                passIsCorrect = false;
            }
            else
            {
                ConPassError.Text = "";
                passIsCorrect = true;
            }
        }

        private void newPassConTB_TextChanged(object sender, EventArgs e)
        {
            if (newPassConTB.Text != newPassTB.Text)
            {
                ConPassError.Text = "Пароди не совпадают!";
                passIsCorrect = false;
            }
            else
            {
                ConPassError.Text = "";
                passIsCorrect = true;
            }
        }

        private void SendCodeBut_Click(object sender, EventArgs e)
        {

            if (!mailIsCorrect || EmailTB.TextLength == 0) return;

            SqlCommand emailCount = new SqlCommand($"SELECT COUNT(Email) FROM Accounts WHERE Email LIKE '{EmailTB.Text}'", Functionality.connection);

            if (Convert.ToUInt32(emailCount.ExecuteScalar()) == 0)
            {
                MessageBox.Show("Пользоваиеля с таким E-mail не существует!");
                return;
            }
            EmailPassRecovery = EmailTB.Text;
            verInfo.Visible = true;
            EmailVerTB.Visible = true;
            ConEmailBut.Visible = true;
            emailVerCode = "";
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                emailVerCode += symbols[rnd.Next(symbols.Length)];
            }

            try
            {
                EmailVerificationMessage.SendMessage(EmailTB.Text, emailVerCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                timer.Start();
            }
        }

        private void ConEmailBut_Click(object sender, EventArgs e)
        {
            if (EmailVerTB.Text == "") return;
            if (EmailVerTB.Text != emailVerCode)
            {
                EmailVerTB.Text = "Неверный код!";
            }
            else
            {
                SaveBut.Enabled = true;
            }
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (!passIsCorrect) return;
            else
            {
                SqlCommand passRec = new SqlCommand("UPDATE Users SET password = @nPass WHERE Email = @mail", Functionality.connection);
                passRec.Parameters.AddWithValue("@nPass", Security.GenerateHash(newPassTB.Text).ToString());
                passRec.Parameters.AddWithValue("@mail", EmailPassRecovery);
                passRec.ExecuteNonQuery();
                MessageBox.Show("Пароль успешно изменен");
                RecoveryPanel.Visible = false;
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            RecoveryPanel.Visible = false;
            Text = "Авторизация";
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void passRecView_MouseDown(object sender, MouseEventArgs e)
        {
            newPassTB.UseSystemPasswordChar = false;
        }

        private void passRecView_MouseUp(object sender, MouseEventArgs e)
        {
            newPassTB.UseSystemPasswordChar = true;
        }

        private void passRecConView_MouseDown(object sender, MouseEventArgs e)
        {
            newPassConTB.UseSystemPasswordChar=false;
        }

        private void passRecConView_MouseUp(object sender, MouseEventArgs e)
        {
            newPassConTB.UseSystemPasswordChar = true;
        }

        private void passView_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTB.UseSystemPasswordChar = false;
        }

        private void passView_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTB.UseSystemPasswordChar = true;
        }

        private void withoutAccBut_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm("withoutAccount");
            mainForm.Show();
            Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sendInterval++;
            timerLabel.Text = "00:" + (61 - sendInterval).ToString();
            if (sendInterval > 60)
            {
                SendCodeBut.Enabled = true;
                timer.Stop();
                sendInterval = 0;
                timerLabel.Text = "";
            }
        }

        #endregion

    }
}
