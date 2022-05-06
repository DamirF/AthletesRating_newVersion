namespace MainApplication.ChildForms.Achivement.Edit
{
    partial class AchivementEditForm
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
            this.AchievementEditSelect = new System.Windows.Forms.ComboBox();
            this.AchievementNameEditTextBox = new System.Windows.Forms.TextBox();
            this.AchievementLvlEditTextBox = new System.Windows.Forms.TextBox();
            this.AchievementPlaceEditTextBox = new System.Windows.Forms.TextBox();
            this.AchievementDateEdit = new System.Windows.Forms.DateTimePicker();
            this.AchievementEditBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AchievementEditSelect
            // 
            this.AchievementEditSelect.FormattingEnabled = true;
            this.AchievementEditSelect.Location = new System.Drawing.Point(12, 12);
            this.AchievementEditSelect.Name = "AchievementEditSelect";
            this.AchievementEditSelect.Size = new System.Drawing.Size(776, 23);
            this.AchievementEditSelect.TabIndex = 0;
            this.AchievementEditSelect.SelectedIndexChanged += new System.EventHandler(this.AchievementEditSelect_SelectedIndexChanged);
            // 
            // AchievementNameEditTextBox
            // 
            this.AchievementNameEditTextBox.Location = new System.Drawing.Point(12, 69);
            this.AchievementNameEditTextBox.Name = "AchievementNameEditTextBox";
            this.AchievementNameEditTextBox.Size = new System.Drawing.Size(454, 23);
            this.AchievementNameEditTextBox.TabIndex = 1;
            // 
            // AchievementLvlEditTextBox
            // 
            this.AchievementLvlEditTextBox.Location = new System.Drawing.Point(12, 155);
            this.AchievementLvlEditTextBox.Name = "AchievementLvlEditTextBox";
            this.AchievementLvlEditTextBox.Size = new System.Drawing.Size(454, 23);
            this.AchievementLvlEditTextBox.TabIndex = 2;
            // 
            // AchievementPlaceEditTextBox
            // 
            this.AchievementPlaceEditTextBox.Location = new System.Drawing.Point(12, 236);
            this.AchievementPlaceEditTextBox.Name = "AchievementPlaceEditTextBox";
            this.AchievementPlaceEditTextBox.Size = new System.Drawing.Size(454, 23);
            this.AchievementPlaceEditTextBox.TabIndex = 3;
            // 
            // AchievementDateEdit
            // 
            this.AchievementDateEdit.Location = new System.Drawing.Point(12, 312);
            this.AchievementDateEdit.Name = "AchievementDateEdit";
            this.AchievementDateEdit.Size = new System.Drawing.Size(454, 23);
            this.AchievementDateEdit.TabIndex = 4;
            // 
            // AchievementEditBut
            // 
            this.AchievementEditBut.Location = new System.Drawing.Point(12, 386);
            this.AchievementEditBut.Name = "AchievementEditBut";
            this.AchievementEditBut.Size = new System.Drawing.Size(204, 23);
            this.AchievementEditBut.TabIndex = 5;
            this.AchievementEditBut.Text = "Редактировать достижение";
            this.AchievementEditBut.UseVisualStyleBackColor = true;
            this.AchievementEditBut.Click += new System.EventHandler(this.AchievementEditBut_Click);
            // 
            // AchivementEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AchievementEditBut);
            this.Controls.Add(this.AchievementDateEdit);
            this.Controls.Add(this.AchievementPlaceEditTextBox);
            this.Controls.Add(this.AchievementLvlEditTextBox);
            this.Controls.Add(this.AchievementNameEditTextBox);
            this.Controls.Add(this.AchievementEditSelect);
            this.Name = "AchivementEditForm";
            this.Text = "AchivementEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementEditSelect;
        private System.Windows.Forms.TextBox AchievementNameEditTextBox;
        private System.Windows.Forms.TextBox AchievementLvlEditTextBox;
        private System.Windows.Forms.TextBox AchievementPlaceEditTextBox;
        private System.Windows.Forms.DateTimePicker AchievementDateEdit;
        private System.Windows.Forms.Button AchievementEditBut;
    }
}