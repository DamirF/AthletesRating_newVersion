namespace MainApplication.TestElement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AthCard = new System.Windows.Forms.Panel();
            this.panelRating = new System.Windows.Forms.Panel();
            this.Rating = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Panel();
            this.nationality = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.AthletePatronymic = new System.Windows.Forms.Label();
            this.AthleteName = new System.Windows.Forms.Label();
            this.AthleteSurname = new System.Windows.Forms.Label();
            this.ProfilePhoto = new System.Windows.Forms.PictureBox();
            this.Achivements = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sportTypeLabel = new System.Windows.Forms.Label();
            this.AthCard.SuspendLayout();
            this.panelRating.SuspendLayout();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePhoto)).BeginInit();
            this.Achivements.SuspendLayout();
            this.SuspendLayout();
            // 
            // AthCard
            // 
            this.AthCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AthCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AthCard.Controls.Add(this.panelRating);
            this.AthCard.Controls.Add(this.Info);
            this.AthCard.Controls.Add(this.Achivements);
            this.AthCard.Location = new System.Drawing.Point(50, 91);
            this.AthCard.Name = "AthCard";
            this.AthCard.Size = new System.Drawing.Size(1400, 320);
            this.AthCard.TabIndex = 0;
            // 
            // panelRating
            // 
            this.panelRating.Controls.Add(this.Rating);
            this.panelRating.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRating.Location = new System.Drawing.Point(1304, 0);
            this.panelRating.Name = "panelRating";
            this.panelRating.Size = new System.Drawing.Size(94, 318);
            this.panelRating.TabIndex = 7;
            // 
            // Rating
            // 
            this.Rating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rating.AutoSize = true;
            this.Rating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rating.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rating.Location = new System.Drawing.Point(15, 10);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(69, 56);
            this.Rating.TabIndex = 6;
            this.Rating.Text = "78";
            // 
            // Info
            // 
            this.Info.Controls.Add(this.sportTypeLabel);
            this.Info.Controls.Add(this.nationality);
            this.Info.Controls.Add(this.BirthDate);
            this.Info.Controls.Add(this.AthletePatronymic);
            this.Info.Controls.Add(this.AthleteName);
            this.Info.Controls.Add(this.AthleteSurname);
            this.Info.Controls.Add(this.ProfilePhoto);
            this.Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(590, 318);
            this.Info.TabIndex = 6;
            // 
            // nationality
            // 
            this.nationality.AutoSize = true;
            this.nationality.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationality.Location = new System.Drawing.Point(245, 282);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(65, 28);
            this.nationality.TabIndex = 13;
            this.nationality.Text = "label3";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BirthDate.Location = new System.Drawing.Point(245, 210);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(65, 28);
            this.BirthDate.TabIndex = 12;
            this.BirthDate.Text = "label2";
            // 
            // sportTypeLabel
            // 
            this.sportTypeLabel.AutoSize = true;
            this.sportTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sportTypeLabel.Location = new System.Drawing.Point(245, 254);
            this.sportTypeLabel.Name = "sportTypeLabel";
            this.sportTypeLabel.Size = new System.Drawing.Size(65, 28);
            this.sportTypeLabel.TabIndex = 14;
            this.sportTypeLabel.Text = "label3";
            // 
            // AthletePatronymic
            // 
            this.AthletePatronymic.AutoSize = true;
            this.AthletePatronymic.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AthletePatronymic.Location = new System.Drawing.Point(245, 149);
            this.AthletePatronymic.Name = "AthletePatronymic";
            this.AthletePatronymic.Size = new System.Drawing.Size(109, 46);
            this.AthletePatronymic.TabIndex = 11;
            this.AthletePatronymic.Text = "label3";
            // 
            // AthleteName
            // 
            this.AthleteName.AutoSize = true;
            this.AthleteName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AthleteName.Location = new System.Drawing.Point(245, 80);
            this.AthleteName.Name = "AthleteName";
            this.AthleteName.Size = new System.Drawing.Size(109, 46);
            this.AthleteName.TabIndex = 10;
            this.AthleteName.Text = "label2";
            // 
            // AthleteSurname
            // 
            this.AthleteSurname.AutoSize = true;
            this.AthleteSurname.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AthleteSurname.Location = new System.Drawing.Point(245, 10);
            this.AthleteSurname.Name = "AthleteSurname";
            this.AthleteSurname.Size = new System.Drawing.Size(109, 46);
            this.AthleteSurname.TabIndex = 9;
            this.AthleteSurname.Text = "label1";
            // 
            // ProfilePhoto
            // 
            this.ProfilePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePhoto.Location = new System.Drawing.Point(14, 10);
            this.ProfilePhoto.Name = "ProfilePhoto";
            this.ProfilePhoto.Size = new System.Drawing.Size(225, 300);
            this.ProfilePhoto.TabIndex = 8;
            this.ProfilePhoto.TabStop = false;
            // 
            // Achivements
            // 
            this.Achivements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Achivements.AutoScroll = true;
            this.Achivements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Achivements.Controls.Add(this.panel1);
            this.Achivements.Location = new System.Drawing.Point(596, 10);
            this.Achivements.Name = "Achivements";
            this.Achivements.Size = new System.Drawing.Size(702, 300);
            this.Achivements.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 100);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 799);
            this.Controls.Add(this.AthCard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AthCard.ResumeLayout(false);
            this.panelRating.ResumeLayout(false);
            this.panelRating.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePhoto)).EndInit();
            this.Achivements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AthCard;
        private System.Windows.Forms.Panel Achivements;
        private System.Windows.Forms.Panel panelRating;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.Label nationality;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label AthletePatronymic;
        private System.Windows.Forms.Label AthleteName;
        private System.Windows.Forms.Label AthleteSurname;
        private System.Windows.Forms.PictureBox ProfilePhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sportTypeLabel;
    }
}