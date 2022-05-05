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
        public AchivementEditForm()
        {
            InitializeComponent();
            for(int i = 0; i < Medal.Medals.Count; i++)
            {
                AchievementEditSelect.Items.Add(Medal.Medals[i].Name);
            }
        }

        private void AchievementEditBut_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Medal.Medals.Count; i++)
            {
                if (AchievementEditSelect.SelectedItem.ToString() == Medal.Medals[i].Name)
                {
                    Medal.Medals[i] = new Medal(int.Parse(AchievementPlaceEditTextBox.Text), AchievementNameEditTextBox.Text, AchievementLvlEditTextBox.Text, AchievementDateEdit.Value);
                }
            }
        }

        private void AchievementEditSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Medal.Medals.Count; i++)
            {
                if(AchievementEditSelect.SelectedItem.ToString() == Medal.Medals[i].Name)
                {
                    AchievementNameEditTextBox.Text = Medal.Medals[i].Name;
                    AchievementPlaceEditTextBox.Text = Convert.ToString(Medal.Medals[i].Place);
                    AchievementLvlEditTextBox.Text = Medal.Medals[i].Level;
                    AchievementDateEdit.Text = Medal.Medals[i].ReceiveYear.ToString();
                }
            }
        }
    }
}
