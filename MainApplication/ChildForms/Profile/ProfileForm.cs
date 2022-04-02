using AthletesRating.GeneralFunctionality;
using SportsmansRating;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.ChildForms.Profile
{
    public partial class ProfileForm : Form
    {
        private AthleteCard athlete;
        private Label[] labels;
        public ProfileForm(AthleteCard card)
        {
            InitializeComponent();
            labels = new Label[8] { profileInfoSurname, profileInfoName, profileInfoPatronymic, profileInfoBirthDate, profileInfoGender, profileInfoEmail, profileInfoHeight, profileInfoWeight };
            athlete = card;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            Functionality.FillUserInfo(athlete, labels);
        }
    }
}
