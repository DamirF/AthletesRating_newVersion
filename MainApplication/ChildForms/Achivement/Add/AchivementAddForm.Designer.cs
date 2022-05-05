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
            this.AchievementLvlAddTextBox = new System.Windows.Forms.TextBox();
            this.AchievementName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AchievementReceiveDateAdd = new System.Windows.Forms.DateTimePicker();
            this.AchievementAddBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AchievementNameAddTextBox
            // 
            this.AchievementNameAddTextBox.Location = new System.Drawing.Point(12, 38);
            this.AchievementNameAddTextBox.Name = "AchievementNameAddTextBox";
            this.AchievementNameAddTextBox.Size = new System.Drawing.Size(438, 23);
            this.AchievementNameAddTextBox.TabIndex = 0;
            // 
            // AchievementPlaceAddTextBox
            // 
            this.AchievementPlaceAddTextBox.Location = new System.Drawing.Point(12, 225);
            this.AchievementPlaceAddTextBox.Name = "AchievementPlaceAddTextBox";
            this.AchievementPlaceAddTextBox.Size = new System.Drawing.Size(438, 23);
            this.AchievementPlaceAddTextBox.TabIndex = 2;
            // 
            // AchievementLvlAddTextBox
            // 
            this.AchievementLvlAddTextBox.Location = new System.Drawing.Point(12, 130);
            this.AchievementLvlAddTextBox.Name = "AchievementLvlAddTextBox";
            this.AchievementLvlAddTextBox.Size = new System.Drawing.Size(438, 23);
            this.AchievementLvlAddTextBox.TabIndex = 3;
            // 
            // AchievementName
            // 
            this.AchievementName.AutoSize = true;
            this.AchievementName.Location = new System.Drawing.Point(12, 9);
            this.AchievementName.Name = "AchievementName";
            this.AchievementName.Size = new System.Drawing.Size(109, 15);
            this.AchievementName.TabIndex = 4;
            this.AchievementName.Text = "Название события";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Уровень события";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Место";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата события";
            // 
            // AchievementReceiveDateAdd
            // 
            this.AchievementReceiveDateAdd.Location = new System.Drawing.Point(12, 322);
            this.AchievementReceiveDateAdd.Name = "AchievementReceiveDateAdd";
            this.AchievementReceiveDateAdd.Size = new System.Drawing.Size(438, 23);
            this.AchievementReceiveDateAdd.TabIndex = 8;
            // 
            // AchievementAddBut
            // 
            this.AchievementAddBut.Location = new System.Drawing.Point(12, 383);
            this.AchievementAddBut.Name = "AchievementAddBut";
            this.AchievementAddBut.Size = new System.Drawing.Size(157, 23);
            this.AchievementAddBut.TabIndex = 9;
            this.AchievementAddBut.Text = "Добавить достижение";
            this.AchievementAddBut.UseVisualStyleBackColor = true;
            this.AchievementAddBut.Click += new System.EventHandler(this.AchievementAddBut_Click);
            // 
            // AchivementAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AchievementAddBut);
            this.Controls.Add(this.AchievementReceiveDateAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AchievementName);
            this.Controls.Add(this.AchievementLvlAddTextBox);
            this.Controls.Add(this.AchievementPlaceAddTextBox);
            this.Controls.Add(this.AchievementNameAddTextBox);
            this.Name = "AchivementAddForm";
            this.Text = "AchivementAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AchievementNameAddTextBox;
        private System.Windows.Forms.TextBox AchievementPlaceAddTextBox;
        private System.Windows.Forms.TextBox AchievementLvlAddTextBox;
        private System.Windows.Forms.Label AchievementName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker AchievementReceiveDateAdd;
        private System.Windows.Forms.Button AchievementAddBut;
    }
}