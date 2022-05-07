using System;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;

namespace MainApplication.ChildForms.Achivement.Edit
{
    public partial class AchivementEditForm : Form
    {
        public AchivementEditForm(ref AthleteCard card)
        {
            this.card = card;
            InitializeComponent();
            Functionality.ComboBoxStuff(ref EventLevel, ref Constants.Levels);
            for(int i = 0; i < card.GetAchievements().Count; i++)
            {
                AchievementEditSelect.Items.Add(card.GetAchievements()[i].Name);
            }
        }

        AthleteCard card;

        private void AchievementEditBut_Click(object sender, EventArgs e)
        {
            if (AchievementEditSelect.SelectedIndex == -1) return;

            Medal medal;
            medal = new Medal(int.Parse(AchievementPlaceEditTextBox.Text), AchievementNameEditTextBox.Text, EventLevel.Text, AchievementDateEdit.Value);

            if(card.GetAchievements()[AchievementEditSelect.SelectedIndex] != medal)
            {
                card.GetAchievements()[AchievementEditSelect.SelectedIndex] = medal;
                Functionality.RecordAchivements(card);
                Close();
            }
        }

        private void AchievementEditSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < card.GetAchievements().Count; i++)
            {
                if(AchievementEditSelect.SelectedItem.ToString() == card.GetAchievements()[i].Name)
                {
                    AchievementNameEditTextBox.Text = card.GetAchievements()[i].Name;
                    AchievementPlaceEditTextBox.Text = Convert.ToString(card.GetAchievements()[i].Place);
                    EventLevel.SelectedIndex = Array.IndexOf(Constants.Levels, card.GetAchievements()[i].Level);
                    EventLevel.Text = EventLevel.Items[EventLevel.SelectedIndex].ToString();
                    AchievementDateEdit.Text = card.GetAchievements()[i].ReceiveYear.ToString();
                }
            }
        }

        private void EventLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AchievementPlaceEditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsNumber(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void AchievementEditSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}
