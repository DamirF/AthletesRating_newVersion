using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AthletesRating.Models;

namespace MainApplication.ChildForms.Achivement.Edit
{
    public partial class AchivementEditForm : Form
    {
        public AchivementEditForm(ref AthleteCard card)
        {
            this.card = card;
            InitializeComponent();
            for(int i = 0; i < card.GetAchievements().Count; i++)
            {
                AchievementEditSelect.Items.Add(card.GetAchievements()[i].Name);
            }
        }

        AthleteCard card;

        private void AchievementEditBut_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < card.GetAchievements().Count; i++)
            {
                if (AchievementEditSelect.SelectedItem.ToString() == card.GetAchievements()[i].Name)
                {
                    card.GetAchievements()[i] = new Medal(int.Parse(AchievementPlaceEditTextBox.Text), AchievementNameEditTextBox.Text, AchievementLvlEditTextBox.Text, AchievementDateEdit.Value);
                }
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
                    AchievementLvlEditTextBox.Text = card.GetAchievements()[i].Level;
                    AchievementDateEdit.Text = card.GetAchievements()[i].ReceiveYear.ToString();
                }
            }
        }
    }
}
