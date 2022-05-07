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
            this.AchievementPlaceEditTextBox = new System.Windows.Forms.TextBox();
            this.AchievementDateEdit = new System.Windows.Forms.DateTimePicker();
            this.AchievementEditBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EventLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AchievementEditSelect
            // 
            this.AchievementEditSelect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementEditSelect.FormattingEnabled = true;
            this.AchievementEditSelect.Location = new System.Drawing.Point(14, 16);
            this.AchievementEditSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementEditSelect.Name = "AchievementEditSelect";
            this.AchievementEditSelect.Size = new System.Drawing.Size(516, 33);
            this.AchievementEditSelect.TabIndex = 0;
            this.AchievementEditSelect.SelectedIndexChanged += new System.EventHandler(this.AchievementEditSelect_SelectedIndexChanged);
            this.AchievementEditSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AchievementEditSelect_KeyPress);
            // 
            // AchievementNameEditTextBox
            // 
            this.AchievementNameEditTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementNameEditTextBox.Location = new System.Drawing.Point(14, 111);
            this.AchievementNameEditTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementNameEditTextBox.Name = "AchievementNameEditTextBox";
            this.AchievementNameEditTextBox.Size = new System.Drawing.Size(516, 41);
            this.AchievementNameEditTextBox.TabIndex = 1;
            // 
            // AchievementPlaceEditTextBox
            // 
            this.AchievementPlaceEditTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementPlaceEditTextBox.Location = new System.Drawing.Point(14, 326);
            this.AchievementPlaceEditTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementPlaceEditTextBox.Name = "AchievementPlaceEditTextBox";
            this.AchievementPlaceEditTextBox.Size = new System.Drawing.Size(182, 41);
            this.AchievementPlaceEditTextBox.TabIndex = 3;
            this.AchievementPlaceEditTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AchievementPlaceEditTextBox_KeyPress);
            // 
            // AchievementDateEdit
            // 
            this.AchievementDateEdit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementDateEdit.Location = new System.Drawing.Point(243, 326);
            this.AchievementDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementDateEdit.Name = "AchievementDateEdit";
            this.AchievementDateEdit.Size = new System.Drawing.Size(287, 41);
            this.AchievementDateEdit.TabIndex = 4;
            // 
            // AchievementEditBut
            // 
            this.AchievementEditBut.ForeColor = System.Drawing.Color.Black;
            this.AchievementEditBut.Location = new System.Drawing.Point(12, 412);
            this.AchievementEditBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementEditBut.Name = "AchievementEditBut";
            this.AchievementEditBut.Size = new System.Drawing.Size(518, 46);
            this.AchievementEditBut.TabIndex = 5;
            this.AchievementEditBut.Text = "Сохранить";
            this.AchievementEditBut.UseVisualStyleBackColor = true;
            this.AchievementEditBut.Click += new System.EventHandler(this.AchievementEditBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название эвента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Уровень:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Место:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(243, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата:";
            // 
            // EventLevel
            // 
            this.EventLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventLevel.FormattingEnabled = true;
            this.EventLevel.Location = new System.Drawing.Point(14, 213);
            this.EventLevel.Name = "EventLevel";
            this.EventLevel.Size = new System.Drawing.Size(516, 43);
            this.EventLevel.TabIndex = 10;
            this.EventLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EventLevel_KeyPress);
            // 
            // AchivementEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(551, 486);
            this.Controls.Add(this.EventLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AchievementEditBut);
            this.Controls.Add(this.AchievementDateEdit);
            this.Controls.Add(this.AchievementPlaceEditTextBox);
            this.Controls.Add(this.AchievementNameEditTextBox);
            this.Controls.Add(this.AchievementEditSelect);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(569, 533);
            this.MinimumSize = new System.Drawing.Size(569, 533);
            this.Name = "AchivementEditForm";
            this.Text = "AchivementEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementEditSelect;
        private System.Windows.Forms.TextBox AchievementNameEditTextBox;
        private System.Windows.Forms.TextBox AchievementPlaceEditTextBox;
        private System.Windows.Forms.DateTimePicker AchievementDateEdit;
        private System.Windows.Forms.Button AchievementEditBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EventLevel;
    }
}