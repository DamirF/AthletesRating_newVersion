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
            this.AchievementDeleteBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AchievementDate = new System.Windows.Forms.Label();
            this.AchievementPlace = new System.Windows.Forms.Label();
            this.AchievementLevel = new System.Windows.Forms.Label();
            this.AchievementName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AchievementDeleteSelect
            // 
            this.AchievementDeleteSelect.FormattingEnabled = true;
            this.AchievementDeleteSelect.Location = new System.Drawing.Point(14, 16);
            this.AchievementDeleteSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementDeleteSelect.Name = "AchievementDeleteSelect";
            this.AchievementDeleteSelect.Size = new System.Drawing.Size(529, 28);
            this.AchievementDeleteSelect.TabIndex = 0;
            this.AchievementDeleteSelect.SelectedIndexChanged += new System.EventHandler(this.AchievementDeleteSelect_SelectedIndexChanged);
            this.AchievementDeleteSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AchievementDeleteSelect_KeyPress);
            // 
            // AchievementDeleteBut
            // 
            this.AchievementDeleteBut.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementDeleteBut.ForeColor = System.Drawing.Color.Black;
            this.AchievementDeleteBut.Location = new System.Drawing.Point(14, 360);
            this.AchievementDeleteBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementDeleteBut.Name = "AchievementDeleteBut";
            this.AchievementDeleteBut.Size = new System.Drawing.Size(529, 46);
            this.AchievementDeleteBut.TabIndex = 5;
            this.AchievementDeleteBut.Text = "Удалить достижение";
            this.AchievementDeleteBut.UseVisualStyleBackColor = true;
            this.AchievementDeleteBut.Click += new System.EventHandler(this.AchievementDeleteBut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AchievementDate);
            this.panel1.Controls.Add(this.AchievementPlace);
            this.panel1.Controls.Add(this.AchievementLevel);
            this.panel1.Controls.Add(this.AchievementName);
            this.panel1.Location = new System.Drawing.Point(14, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 293);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(231, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Место:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Уровень:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название эвента:";
            // 
            // AchievementDate
            // 
            this.AchievementDate.AutoSize = true;
            this.AchievementDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementDate.ForeColor = System.Drawing.Color.White;
            this.AchievementDate.Location = new System.Drawing.Point(310, 232);
            this.AchievementDate.Name = "AchievementDate";
            this.AchievementDate.Size = new System.Drawing.Size(80, 35);
            this.AchievementDate.TabIndex = 8;
            this.AchievementDate.Text = ". . . . . .";
            // 
            // AchievementPlace
            // 
            this.AchievementPlace.AutoSize = true;
            this.AchievementPlace.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementPlace.ForeColor = System.Drawing.Color.White;
            this.AchievementPlace.Location = new System.Drawing.Point(116, 232);
            this.AchievementPlace.Name = "AchievementPlace";
            this.AchievementPlace.Size = new System.Drawing.Size(80, 35);
            this.AchievementPlace.TabIndex = 7;
            this.AchievementPlace.Text = ". . . . . .";
            // 
            // AchievementLevel
            // 
            this.AchievementLevel.AutoSize = true;
            this.AchievementLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementLevel.ForeColor = System.Drawing.Color.White;
            this.AchievementLevel.Location = new System.Drawing.Point(141, 162);
            this.AchievementLevel.Name = "AchievementLevel";
            this.AchievementLevel.Size = new System.Drawing.Size(80, 35);
            this.AchievementLevel.TabIndex = 6;
            this.AchievementLevel.Text = ". . . . . .";
            // 
            // AchievementName
            // 
            this.AchievementName.AutoSize = true;
            this.AchievementName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementName.ForeColor = System.Drawing.Color.White;
            this.AchievementName.Location = new System.Drawing.Point(18, 65);
            this.AchievementName.Name = "AchievementName";
            this.AchievementName.Size = new System.Drawing.Size(80, 35);
            this.AchievementName.TabIndex = 5;
            this.AchievementName.Text = ". . . . . .";
            // 
            // AchivementDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(560, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AchievementDeleteBut);
            this.Controls.Add(this.AchievementDeleteSelect);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(578, 466);
            this.MinimumSize = new System.Drawing.Size(578, 466);
            this.Name = "AchivementDeleteForm";
            this.Text = "AchivementDeleteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementDeleteSelect;
        private System.Windows.Forms.Button AchievementDeleteBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AchievementDate;
        private System.Windows.Forms.Label AchievementPlace;
        private System.Windows.Forms.Label AchievementLevel;
        private System.Windows.Forms.Label AchievementName;
    }
}