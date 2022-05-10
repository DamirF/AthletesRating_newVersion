using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.Forms
{
    public partial class StuffScr : Form
    {

        static string alph = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";
        private static List<string> logins = new List<string>();
        private static string domen = "@mail.ru";

        public StuffScr()
        {
            InitializeComponent();
        }

        private void Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsNumber(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Count.Text);
            if (count > 300) return;

            AthleteCard athlete;
            Random random = new Random();
            logins.Clear();
            GenLogin(count);
            string gender = "";
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();

            for (int i = 0; i < count; i++)
            {
                switch(random.Next(0,2))
                {
                    case 0:
                        gender = "Мужской";
                        break;
                    case 1:
                        gender = "Женский";
                        break;
                }
                athlete = new AthleteCard("Surname", "Name", "Patronymic", gender, DateTime.Now, logins[i]+domen, logins[i], Security.GenerateHash("Qwerty123").ToString(), false);
                athlete.NewUserRegistration(Functionality.connection, "gen");
            }
        }

        private static void GenLogin(int count)
        {
            string login;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                do
                {
                    login = "";
                    for (int j = 0; j < 10; j++)
                    {
                        login += alph[rand.Next(alph.Length)];
                    }
                } while (logins.Contains(login));
                logins.Add(login);
            }
        }
    }
}
