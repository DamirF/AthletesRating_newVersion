using AthletesRating.Models;
using MainApplication.ChildForms.Achivement.Add;
using MainApplication.GeneralFunctionality;
using MainApplication.Models;
using System;
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
            UserInfoNationality.Text = Constants.Countries[athlete.nationality];
            UserInfoSportType.Text = Constants.SportTypes[athlete.sportType];
            UserInfoHeight.Text = athlete.Height.ToString() + " см";
            UserInfoWeight.Text = athlete.Weight.ToString() + " кг";
            UserInfoRating.Text = athlete.CalculateRating();

            AchivementCard.FillContent(ref panelAchivements, ref athlete);

            if (String.IsNullOrEmpty(UserInfoNationality.Text)) UserInfoNationality.Text = "не указан";
            if (String.IsNullOrEmpty(UserInfoSportType.Text)) UserInfoSportType.Text = "не указан";
        }

        private void AddAchivementBtn_Click(object sender, EventArgs e)
        {
            AchivementAddForm add = new AchivementAddForm();
            add.ShowDialog();
            Invalidate();
        }
    }
}
