using AthletesRating.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainApplication.Models
{
    public class AchivementCard
    {
        private static readonly int margin = 8;

        private static Panel EventCard;
        private static Panel InfPanel;
        private static Label Place;
        private static Label EventLevel;
        private static Label EventName;
        private static Label EventDate;

        public static void CreateCard(Medal medal, int index)
        {
            #region Create
            EventCard = new Panel();
            InfPanel = new Panel();
            EventDate = new Label();
            Place = new Label();
            EventLevel = new Label();
            EventName = new Label();
            EventCard.SuspendLayout();
            InfPanel.SuspendLayout();

            #region Properties
            // 
            // EventCard
            // 
            EventCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            EventCard.Controls.Add(InfPanel);
            EventCard.Controls.Add(EventLevel);
            EventCard.Controls.Add(EventName);
            EventCard.Size = new System.Drawing.Size(670, 100);
            EventCard.Location = new System.Drawing.Point(16, index * EventCard.Size.Height + margin * (index + 1));
            EventCard.Name = "EventCard";
            EventCard.TabIndex = 0;
            // 
            // InfPanel
            // 
            InfPanel.Controls.Add(EventDate);
            InfPanel.Controls.Add(Place);
            InfPanel.Dock = System.Windows.Forms.DockStyle.Right;
            InfPanel.Location = new System.Drawing.Point(536, 0);
            InfPanel.Name = "InfPanel";
            InfPanel.Size = new System.Drawing.Size(130, 96);
            InfPanel.TabIndex = 2;
            // 
            // EventDate
            // 
            EventDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            EventDate.Location = new System.Drawing.Point(11, 62);
            EventDate.Name = "EventDate";
            EventDate.Size = new System.Drawing.Size(108, 25);
            EventDate.TabIndex = 1;
            EventDate.Text = "...";
            // 
            // Place
            // 
            Place.AutoSize = true;
            Place.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Place.Location = new System.Drawing.Point(60, 0);
            Place.Name = "Place";
            Place.Size = new System.Drawing.Size(66, 47);
            Place.TabIndex = 0;
            Place.Text = "...";
            // 
            // EventLevel
            // 
            EventLevel.AutoSize = true;
            EventLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            EventLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            EventLevel.Location = new System.Drawing.Point(12, 57);
            EventLevel.Name = "EventLevel";
            EventLevel.Size = new System.Drawing.Size(95, 30);
            EventLevel.TabIndex = 1;
            EventLevel.Text = "...";
            // 
            // EventName
            // 
            EventName.AutoSize = true;
            EventName.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            EventName.Location = new System.Drawing.Point(12, 9);
            EventName.Name = "EventName";
            EventName.Size = new System.Drawing.Size(465, 37);
            EventName.TabIndex = 0;
            EventName.Text = "...";
            #endregion

            EventCard.ResumeLayout(false);
            EventCard.PerformLayout();
            InfPanel.ResumeLayout(false);
            InfPanel.PerformLayout();
            #endregion

            EventName.Text = medal.Name;
            EventLevel.Text = medal.Level;
            EventDate.Text = medal.ReceiveYear.ToShortDateString();
            Place.Text = medal.Place.ToString();
        }

        public static void FillContent(ref Panel content, ref AthleteCard athlete)
        {
            content.Controls.Clear();
            List<Medal> medals = athlete.GetAchievements();
            for (int i = 0; i < medals.Count; i++)
            {
                CreateCard(medals[i], i);
                content.Controls.Add(EventCard);
            }
        }
    }
}
