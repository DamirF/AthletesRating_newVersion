using System;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;

namespace MainApplication.ChildForms.Achivement.Add
{
    public partial class AchivementAddForm : Form
    {
        public AchivementAddForm(ref AthleteCard card)
        {
            InitializeComponent();
            Functionality.ComboBoxStuff(ref AchievementLevelAddComboBox, ref Constants.Levels);
            this.card = card;
        }

        Medal medal;
        AthleteCard card;

        private void AchievementAddBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AchievementNameAddTextBox.Text) || AchievementLevelAddComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(AchievementPlaceAddTextBox.Text)) return;
            medal = new Medal(int.Parse(AchievementPlaceAddTextBox.Text), AchievementNameAddTextBox.Text, AchievementLevelAddComboBox.Text, AchievementReceiveDateAdd.Value);
            card.GetAchievements().Add(medal);
            Functionality.RecordAchivements(card);
            Close();
        }

        private void AchievementPlaceAddTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void AchievementLevelAddComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
