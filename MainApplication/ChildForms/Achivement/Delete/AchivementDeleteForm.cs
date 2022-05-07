using System;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;

namespace MainApplication.ChildForms.Achivement.Delete
{
    public partial class AchivementDeleteForm : Form
    {
        public AchivementDeleteForm(ref AthleteCard card)
        {
            InitializeComponent();
            this.card = card;
            for (int i = 0; i < card.GetAchievements().Count; i++)
            {
                AchievementDeleteSelect.Items.Add(card.GetAchievements()[i].Name);
            }
        }

        AthleteCard card;

        private void AchievementDeleteBut_Click(object sender, EventArgs e)
        {
            if (AchievementDeleteSelect.SelectedIndex == -1) return;

            card.GetAchievements().RemoveAt(AchievementDeleteSelect.SelectedIndex);
            AchievementDeleteSelect.Items.RemoveAt(AchievementDeleteSelect.SelectedIndex);
            Functionality.RecordAchivements(card);
            Close();
        }

        private void AchievementDeleteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < card.GetAchievements().Count; i++)
            {
                if (AchievementDeleteSelect.SelectedItem.ToString() == card.GetAchievements()[i].Name)
                {
                    AchievementName.Text = card.GetAchievements()[i].Name;
                    AchievementPlace.Text = Convert.ToString(card.GetAchievements()[i].Place);
                    AchievementLevel.Text = card.GetAchievements()[i].Level;
                    AchievementDate.Text = card.GetAchievements()[i].ReceiveYear.ToString();
                }
            }
        }

        private void AchievementDeleteSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
