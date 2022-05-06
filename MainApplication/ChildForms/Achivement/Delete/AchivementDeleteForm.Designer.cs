namespace MainApplication.ChildForms.Achivement.Delete
{
    partial class AchivementDeleteForm
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
            this.AchievementDeleteSelect = new System.Windows.Forms.ComboBox();
            this.AchievementName = new System.Windows.Forms.Label();
            this.AchievementLevel = new System.Windows.Forms.Label();
            this.AchievementPlace = new System.Windows.Forms.Label();
            this.AchievementDate = new System.Windows.Forms.Label();
            this.AchievementDeleteBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AchievementDeleteSelect
            // 
            this.AchievementDeleteSelect.FormattingEnabled = true;
            this.AchievementDeleteSelect.Location = new System.Drawing.Point(12, 12);
            this.AchievementDeleteSelect.Name = "AchievementDeleteSelect";
            this.AchievementDeleteSelect.Size = new System.Drawing.Size(776, 23);
            this.AchievementDeleteSelect.TabIndex = 0;
            this.AchievementDeleteSelect.SelectedIndexChanged += new System.EventHandler(this.AchievementDeleteSelect_SelectedIndexChanged);
            // 
            // AchievementName
            // 
            this.AchievementName.AutoSize = true;
            this.AchievementName.Location = new System.Drawing.Point(12, 51);
            this.AchievementName.Name = "AchievementName";
            this.AchievementName.Size = new System.Drawing.Size(38, 15);
            this.AchievementName.TabIndex = 1;
            this.AchievementName.Text = "label1";
            // 
            // AchievementLevel
            // 
            this.AchievementLevel.AutoSize = true;
            this.AchievementLevel.Location = new System.Drawing.Point(12, 95);
            this.AchievementLevel.Name = "AchievementLevel";
            this.AchievementLevel.Size = new System.Drawing.Size(38, 15);
            this.AchievementLevel.TabIndex = 2;
            this.AchievementLevel.Text = "label2";
            // 
            // AchievementPlace
            // 
            this.AchievementPlace.AutoSize = true;
            this.AchievementPlace.Location = new System.Drawing.Point(12, 147);
            this.AchievementPlace.Name = "AchievementPlace";
            this.AchievementPlace.Size = new System.Drawing.Size(38, 15);
            this.AchievementPlace.TabIndex = 3;
            this.AchievementPlace.Text = "label3";
            // 
            // AchievementDate
            // 
            this.AchievementDate.AutoSize = true;
            this.AchievementDate.Location = new System.Drawing.Point(12, 195);
            this.AchievementDate.Name = "AchievementDate";
            this.AchievementDate.Size = new System.Drawing.Size(38, 15);
            this.AchievementDate.TabIndex = 4;
            this.AchievementDate.Text = "label4";
            // 
            // AchievementDeleteBut
            // 
            this.AchievementDeleteBut.Location = new System.Drawing.Point(12, 238);
            this.AchievementDeleteBut.Name = "AchievementDeleteBut";
            this.AchievementDeleteBut.Size = new System.Drawing.Size(153, 23);
            this.AchievementDeleteBut.TabIndex = 5;
            this.AchievementDeleteBut.Text = "Удалить достижение";
            this.AchievementDeleteBut.UseVisualStyleBackColor = true;
            this.AchievementDeleteBut.Click += new System.EventHandler(this.AchievementDeleteBut_Click);
            // 
            // AchivementDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AchievementDeleteBut);
            this.Controls.Add(this.AchievementDate);
            this.Controls.Add(this.AchievementPlace);
            this.Controls.Add(this.AchievementLevel);
            this.Controls.Add(this.AchievementName);
            this.Controls.Add(this.AchievementDeleteSelect);
            this.Name = "AchivementDeleteForm";
            this.Text = "AchivementDeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementDeleteSelect;
        private System.Windows.Forms.Label AchievementName;
        private System.Windows.Forms.Label AchievementLevel;
        private System.Windows.Forms.Label AchievementPlace;
        private System.Windows.Forms.Label AchievementDate;
        private System.Windows.Forms.Button AchievementDeleteBut;
    }
}