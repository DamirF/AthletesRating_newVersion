namespace MainApplication.ChildForms.Achivement.Add
{
    partial class AchivementAddForm
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
            this.AchievementNameAddTextBox = new System.Windows.Forms.TextBox();
            this.AchievementPlaceAddTextBox = new System.Windows.Forms.TextBox();
            this.AchievementName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AchievementReceiveDateAdd = new System.Windows.Forms.DateTimePicker();
            this.AchievementAddBut = new System.Windows.Forms.Button();
            this.AchievementLevelAddComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AchievementNameAddTextBox
            // 
            this.AchievementNameAddTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementNameAddTextBox.Location = new System.Drawing.Point(14, 51);
            this.AchievementNameAddTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementNameAddTextBox.Name = "AchievementNameAddTextBox";
            this.AchievementNameAddTextBox.Size = new System.Drawing.Size(500, 36);
            this.AchievementNameAddTextBox.TabIndex = 0;
            // 
            // AchievementPlaceAddTextBox
            // 
            this.AchievementPlaceAddTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementPlaceAddTextBox.Location = new System.Drawing.Point(14, 248);
            this.AchievementPlaceAddTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementPlaceAddTextBox.Name = "AchievementPlaceAddTextBox";
            this.AchievementPlaceAddTextBox.Size = new System.Drawing.Size(500, 36);
            this.AchievementPlaceAddTextBox.TabIndex = 2;
            this.AchievementPlaceAddTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AchievementPlaceAddTextBox_KeyPress);
            // 
            // AchievementName
            // 
            this.AchievementName.AutoSize = true;
            this.AchievementName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AchievementName.ForeColor = System.Drawing.Color.White;
            this.AchievementName.Location = new System.Drawing.Point(14, 12);
            this.AchievementName.Name = "AchievementName";
            this.AchievementName.Size = new System.Drawing.Size(241, 35);
            this.AchievementName.TabIndex = 4;
            this.AchievementName.Text = "Название события";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Уровень события";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Место";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата события";
            // 
            // AchievementReceiveDateAdd
            // 
            this.AchievementReceiveDateAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementReceiveDateAdd.Location = new System.Drawing.Point(14, 356);
            this.AchievementReceiveDateAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementReceiveDateAdd.Name = "AchievementReceiveDateAdd";
            this.AchievementReceiveDateAdd.Size = new System.Drawing.Size(500, 36);
            this.AchievementReceiveDateAdd.TabIndex = 8;
            // 
            // AchievementAddBut
            // 
            this.AchievementAddBut.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementAddBut.Location = new System.Drawing.Point(14, 459);
            this.AchievementAddBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AchievementAddBut.Name = "AchievementAddBut";
            this.AchievementAddBut.Size = new System.Drawing.Size(500, 49);
            this.AchievementAddBut.TabIndex = 9;
            this.AchievementAddBut.Text = "Добавить достижение";
            this.AchievementAddBut.UseVisualStyleBackColor = true;
            this.AchievementAddBut.Click += new System.EventHandler(this.AchievementAddBut_Click);
            // 
            // AchievementLevelAddComboBox
            // 
            this.AchievementLevelAddComboBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AchievementLevelAddComboBox.FormattingEnabled = true;
            this.AchievementLevelAddComboBox.Location = new System.Drawing.Point(14, 144);
            this.AchievementLevelAddComboBox.Name = "AchievementLevelAddComboBox";
            this.AchievementLevelAddComboBox.Size = new System.Drawing.Size(500, 38);
            this.AchievementLevelAddComboBox.TabIndex = 10;
            this.AchievementLevelAddComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AchievementLevelAddComboBox_KeyPress);
            // 
            // AchivementAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(540, 522);
            this.Controls.Add(this.AchievementLevelAddComboBox);
            this.Controls.Add(this.AchievementAddBut);
            this.Controls.Add(this.AchievementReceiveDateAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AchievementName);
            this.Controls.Add(this.AchievementPlaceAddTextBox);
            this.Controls.Add(this.AchievementNameAddTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(558, 569);
            this.MinimumSize = new System.Drawing.Size(558, 569);
            this.Name = "AchivementAddForm";
            this.Text = "AchivementAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AchievementNameAddTextBox;
        private System.Windows.Forms.TextBox AchievementPlaceAddTextBox;
        private System.Windows.Forms.Label AchievementName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker AchievementReceiveDateAdd;
        private System.Windows.Forms.Button AchievementAddBut;
        private System.Windows.Forms.ComboBox AchievementLevelAddComboBox;
    }
}