using MainApplication.GeneralFunctionality;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.Models
{
    public class Card
    {
        private static readonly int margin = 20;

        #region Fields
        private static Panel AthCard;
        private static Panel Achivements;
        private static Panel panelRating;
        private static Label Rating;
        private static Panel Info;
        private static Label nationality;
        private static Label sportTypeLabel;
        private static Label BirthDate;
        private static Label AthletePatronymic;
        private static Label AthleteName;
        private static Label AthleteSurname;
        private static PictureBox ProfilePhoto;
        #endregion

        public static void CreateCard(AthleteCard athlete, int index)
        {
            #region Create
            AthCard = new Panel();
            panelRating = new Panel();
            Rating = new Label();
            Info = new Panel();
            nationality = new Label();
            sportTypeLabel = new Label();
            BirthDate = new Label();
            AthletePatronymic = new Label();
            AthleteName = new Label();
            AthleteSurname = new Label();
            ProfilePhoto = new PictureBox();
            Achivements = new Panel();
            AthCard.SuspendLayout();
            panelRating.SuspendLayout();
            Info.SuspendLayout();

            #region Properties
            // 
            // AthCard
            // 
            AthCard.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            AthCard.BorderStyle = BorderStyle.FixedSingle;
            AthCard.Controls.Add(panelRating);
            AthCard.Controls.Add(Info);
            AthCard.Controls.Add(Achivements);
            AthCard.Size = new System.Drawing.Size(1400, 320);
            AthCard.Location = new System.Drawing.Point(50, index * AthCard.Size.Height + margin * (index + 1));
            AthCard.Name = "AthCard";
            AthCard.TabIndex = 0;
            // 
            // panelRating
            // 
            panelRating.Controls.Add(Rating);
            panelRating.Dock = DockStyle.Right;
            panelRating.Location = new System.Drawing.Point(1304, 0);
            panelRating.Name = "panelRating";
            panelRating.Size = new System.Drawing.Size(94, 318);
            panelRating.TabIndex = 7;
            // 
            // Rating
            // 
            Rating.Anchor = AnchorStyles.Top;
            Rating.AutoSize = true;
            Rating.BorderStyle = BorderStyle.FixedSingle;
            Rating.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Rating.Location = new System.Drawing.Point(15, 10);
            Rating.Name = "Rating";
            Rating.Size = new System.Drawing.Size(69, 56);
            Rating.TabIndex = 6;
            Rating.Text = "78";
            // 
            // Info
            // 
            Info.Controls.Add(sportTypeLabel);
            Info.Controls.Add(nationality);
            Info.Controls.Add(BirthDate);
            Info.Controls.Add(AthletePatronymic);
            Info.Controls.Add(AthleteName);
            Info.Controls.Add(AthleteSurname);
            Info.Controls.Add(ProfilePhoto);
            Info.Dock = DockStyle.Left;
            Info.Location = new System.Drawing.Point(0, 0);
            Info.Name = "Info";
            Info.Size = new System.Drawing.Size(590, 318);
            Info.TabIndex = 6;
            // 
            // nationality
            // 
            nationality.AutoSize = true;
            nationality.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nationality.Location = new System.Drawing.Point(245, 282);
            nationality.Name = "nationality";
            nationality.Size = new System.Drawing.Size(65, 28);
            nationality.TabIndex = 13;
            nationality.Text = "label3";
            // 
            // BirthDate
            // 
            BirthDate.AutoSize = true;
            BirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BirthDate.Location = new System.Drawing.Point(245, 210);
            BirthDate.Name = "BirthDate";
            BirthDate.Size = new System.Drawing.Size(65, 28);
            BirthDate.TabIndex = 12;
            BirthDate.Text = "label2";
            // 
            // sportTypeLabel
            // 
            sportTypeLabel.AutoSize = true;
            sportTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            sportTypeLabel.Location = new System.Drawing.Point(245, 254);
            sportTypeLabel.Name = "sportTypeLabel";
            sportTypeLabel.Size = new System.Drawing.Size(65, 28);
            sportTypeLabel.TabIndex = 14;
            sportTypeLabel.Text = "label3";
            // 
            // AthletePatronymic
            // 
            AthletePatronymic.AutoSize = true;
            AthletePatronymic.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AthletePatronymic.Location = new System.Drawing.Point(245, 130);
            AthletePatronymic.Name = "AthletePatronymic";
            AthletePatronymic.Size = new System.Drawing.Size(109, 46);
            AthletePatronymic.TabIndex = 11;
            AthletePatronymic.Text = "label3";
            // 
            // AthleteName
            // 
            AthleteName.AutoSize = true;
            AthleteName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AthleteName.Location = new System.Drawing.Point(245, 70);
            AthleteName.Name = "AthleteName";
            AthleteName.Size = new System.Drawing.Size(109, 46);
            AthleteName.TabIndex = 10;
            AthleteName.Text = "label2";
            // 
            // AthleteSurname
            // 
            AthleteSurname.AutoSize = true;
            AthleteSurname.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AthleteSurname.Location = new System.Drawing.Point(245, 10);
            AthleteSurname.Name = "AthleteSurname";
            AthleteSurname.Size = new System.Drawing.Size(109, 46);
            AthleteSurname.TabIndex = 9;
            AthleteSurname.Text = "label1";
            // 
            // ProfilePhoto
            // 
            ProfilePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ProfilePhoto.Location = new System.Drawing.Point(14, 10);
            ProfilePhoto.Name = "ProfilePhoto";
            ProfilePhoto.Size = new System.Drawing.Size(225, 300);
            ProfilePhoto.TabIndex = 8;
            ProfilePhoto.TabStop = false;
            // 
            // Achivements
            // 
            Achivements.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            Achivements.AutoScroll = true;
            Achivements.BorderStyle = BorderStyle.FixedSingle;
            Achivements.Location = new System.Drawing.Point(596, 10);
            Achivements.Name = "Achivements";
            Achivements.Size = new System.Drawing.Size(702, 300);
            Achivements.TabIndex = 4;
            #endregion

            AthCard.ResumeLayout(false);
            panelRating.ResumeLayout(false);
            panelRating.PerformLayout();
            Info.ResumeLayout(false);
            Info.PerformLayout();
            #endregion

            ProfilePicture.ProfilePictureSet(ref ProfilePhoto, ref athlete);
            AthleteSurname.Text = athlete.fullName.Surname;
            AthleteName.Text = athlete.fullName.Name;
            AthletePatronymic.Text = athlete.fullName.Patronymic;
            BirthDate.Text = $"{athlete.BirthDate.ToShortDateString()}, ({athlete.CalculateAge()})";
            sportTypeLabel.Text = athlete.sportType;
            nationality.Text = athlete.nationality;
            AchivementCard.FillContent(ref Achivements, ref athlete);
        }

        public static void FillContent(ref Panel content, ref List<AthleteCard> athletes)
        {
            if (athletes.Count == 0) return;
            content.Controls.Clear();
            for(int i = 0; i < athletes.Count; i++)
            {
                CreateCard(athletes[i], i);
                content.Controls.Add(AthCard);
            }
        }
    }
}
