using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AthletesRating.Models;

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
            for(int i = 0; i < card.GetAchievements().Count; i++)
            {
                if(AchievementDeleteSelect.SelectedIndex.ToString() == card.GetAchievements()[i].Name)
                {
                    card.GetAchievements().RemoveAt(i);
                    AchievementDeleteSelect.Items.Remove(AchievementDeleteSelect.SelectedItem);
                }
            }
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
    }
}
