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
        public AchivementDeleteForm()
        {
            InitializeComponent();
            for (int i = 0; i < Medal.Medals.Count; i++)
            {
                AchievementDeleteSelect.Items.Add(Medal.Medals[i].Name);
            }
        }

        private void AchievementDeleteBut_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Medal.Medals.Count; i++)
            {
                if(AchievementDeleteSelect.SelectedIndex.ToString() == Medal.Medals[i].Name)
                {
                    Medal.Medals.Remove(Medal.Medals[i]);
                    AchievementDeleteSelect.Items.Remove(AchievementDeleteSelect.SelectedItem);
                }
            }
        }

        private void AchievementDeleteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Medal.Medals.Count; i++)
            {
                if (AchievementDeleteSelect.SelectedItem.ToString() == Medal.Medals[i].Name)
                {
                    AchievementName.Text = Medal.Medals[i].Name;
                    AchievementPlace.Text = Convert.ToString(Medal.Medals[i].Place);
                    AchievementLevel.Text = Medal.Medals[i].Level;
                    AchievementDate.Text = Medal.Medals[i].ReceiveYear.ToString();
                }
            }
        }
    }
}
