using AthletesRating.GeneralFunctionality;
using MainApplication.GeneralFunctionality;
using MainApplication.Models;
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
        public ProfileForm(AthleteCard card)
        {
            InitializeComponent();
            athlete = card;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            ProfilePicture.ProfilePictureSet(ref UserInfoPhoto, ref athlete);
            UserInfoSurname.Text = athlete.fullName.Surname;
            UserInfoName.Text = athlete.fullName.Name;
            UserInfoPatronymic.Text = athlete.fullName.Patronymic;
            UserInfoGender.Text = athlete.Gender;
            UserInfoEmail.Text = athlete.accountInfo.Email;
            UserInfoBirthDate.Text = athlete.BirthDate.ToShortDateString();
            UserInfoAge.Text = athlete.CalculateAge().ToString();
            UserInfoNationality.Text = athlete.nationality;
            UserInfoSportType.Text = athlete.sportType;
            UserInfoHeight.Text = athlete.Height.ToString() + " см";
            UserInfoWeight.Text = athlete.Weight.ToString() +" кг";
            UserInfoRating.Text = athlete.CalculateRating();

            AchivementCard.FillContent(ref panelAchivements, ref athlete);

            if (String.IsNullOrEmpty(UserInfoNationality.Text)) UserInfoNationality.Text = "не указан";
            if (String.IsNullOrEmpty(UserInfoSportType.Text)) UserInfoSportType.Text = "не указан";
        }
    }
}
