using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AthletesRating.Models;

namespace MainApplication.ChildForms.Achivement.Add
{
    public partial class AchivementAddForm : Form
    {
        public AchivementAddForm(ref AthleteCard card)
        {
            InitializeComponent();
            this.card = card;
        }

        Medal medal;
        AthleteCard card;

        private void AchievementAddBut_Click(object sender, EventArgs e)
        {
            medal = new Medal(int.Parse(AchievementPlaceAddTextBox.Text), AchievementNameAddTextBox.Text, AchievementLvlAddTextBox.Text, AchievementReceiveDateAdd.Value);
            card.GetAchievements().Add(medal);
        }
    }
}
