namespace MainApplication.ChildForms.Admin.Edit
{
    partial class AccountsEditForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.MakeAdminBut = new System.Windows.Forms.Button();
            this.DelAdminBut = new System.Windows.Forms.Button();
            this.DeleteUserBut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AthletesComboBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoStature = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.InfoEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.InfoNationality = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InfoBirthDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InfoGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoPatronymic = new System.Windows.Forms.Label();
            this.InfoName = new System.Windows.Forms.Label();
            this.InfoSurname = new System.Windows.Forms.Label();
            this.InfoProfilePhoto = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.MakeAdminBut);
            this.panel2.Controls.Add(this.DelAdminBut);
            this.panel2.Controls.Add(this.DeleteUserBut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 830);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 70);
            this.panel2.TabIndex = 4;
            // 
            // MakeAdminBut
            // 
            this.MakeAdminBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeAdminBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.MakeAdminBut.FlatAppearance.BorderSize = 0;
            this.MakeAdminBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeAdminBut.Location = new System.Drawing.Point(600, 0);
            this.MakeAdminBut.Name = "MakeAdminBut";
            this.MakeAdminBut.Size = new System.Drawing.Size(200, 70);
            this.MakeAdminBut.TabIndex = 2;
            this.MakeAdminBut.Text = "Сделать админом";
            this.MakeAdminBut.UseVisualStyleBackColor = true;
            this.MakeAdminBut.Click += new System.EventHandler(this.MakeAdminBut_Click);
            // 
            // DelAdminBut
            // 
            this.DelAdminBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelAdminBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.DelAdminBut.FlatAppearance.BorderSize = 0;
            this.DelAdminBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelAdminBut.Location = new System.Drawing.Point(800, 0);
            this.DelAdminBut.Name = "DelAdminBut";
            this.DelAdminBut.Size = new System.Drawing.Size(200, 70);
            this.DelAdminBut.TabIndex = 1;
            this.DelAdminBut.Text = "Убрать админку";
            this.DelAdminBut.UseVisualStyleBackColor = true;
            this.DelAdminBut.Click += new System.EventHandler(this.DelAdminBut_Click);
            // 
            // DeleteUserBut
            // 
            this.DeleteUserBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUserBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteUserBut.FlatAppearance.BorderSize = 0;
            this.DeleteUserBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserBut.Location = new System.Drawing.Point(1000, 0);
            this.DeleteUserBut.Name = "DeleteUserBut";
            this.DeleteUserBut.Size = new System.Drawing.Size(200, 70);
            this.DeleteUserBut.TabIndex = 0;
            this.DeleteUserBut.Text = "Удалить";
            this.DeleteUserBut.UseVisualStyleBackColor = true;
            this.DeleteUserBut.Click += new System.EventHandler(this.DeleteUserBut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AthletesComboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 830);
            this.panel3.TabIndex = 5;
            // 
            // AthletesComboBox
            // 
            this.AthletesComboBox.BackColor = System.Drawing.Color.White;
            this.AthletesComboBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AthletesComboBox.FormattingEnabled = true;
            this.AthletesComboBox.Location = new System.Drawing.Point(12, 28);
            this.AthletesComboBox.Name = "AthletesComboBox";
            this.AthletesComboBox.Size = new System.Drawing.Size(432, 38);
            this.AthletesComboBox.TabIndex = 0;
            this.AthletesComboBox.SelectedIndexChanged += new System.EventHandler(this.AthletesComboBox_SelectedIndexChanged);
            this.AthletesComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AthletesComboBox_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.InfoPatronymic);
            this.panel4.Controls.Add(this.InfoName);
            this.panel4.Controls.Add(this.InfoSurname);
            this.panel4.Controls.Add(this.InfoProfilePhoto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(450, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 830);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InfoStature);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.InfoEmail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.InfoNationality);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.InfoBirthDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.InfoLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.InfoGender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 464);
            this.panel1.TabIndex = 4;
            // 
            // InfoStature
            // 
            this.InfoStature.AutoSize = true;
            this.InfoStature.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoStature.Location = new System.Drawing.Point(332, 390);
            this.InfoStature.Name = "InfoStature";
            this.InfoStature.Size = new System.Drawing.Size(35, 37);
            this.InfoStature.TabIndex = 11;
            this.InfoStature.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(57, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "Статус:";
            // 
            // InfoEmail
            // 
            this.InfoEmail.AutoSize = true;
            this.InfoEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoEmail.Location = new System.Drawing.Point(332, 232);
            this.InfoEmail.Name = "InfoEmail";
            this.InfoEmail.Size = new System.Drawing.Size(35, 37);
            this.InfoEmail.TabIndex = 9;
            this.InfoEmail.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(57, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "E-mail:";
            // 
            // InfoNationality
            // 
            this.InfoNationality.AutoSize = true;
            this.InfoNationality.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoNationality.Location = new System.Drawing.Point(332, 165);
            this.InfoNationality.Name = "InfoNationality";
            this.InfoNationality.Size = new System.Drawing.Size(35, 37);
            this.InfoNationality.TabIndex = 7;
            this.InfoNationality.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(57, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Гражданство:";
            // 
            // InfoBirthDate
            // 
            this.InfoBirthDate.AutoSize = true;
            this.InfoBirthDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoBirthDate.Location = new System.Drawing.Point(332, 93);
            this.InfoBirthDate.Name = "InfoBirthDate";
            this.InfoBirthDate.Size = new System.Drawing.Size(35, 37);
            this.InfoBirthDate.TabIndex = 5;
            this.InfoBirthDate.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения:";
            // 
            // InfoLogin
            // 
            this.InfoLogin.AutoSize = true;
            this.InfoLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLogin.Location = new System.Drawing.Point(332, 308);
            this.InfoLogin.Name = "InfoLogin";
            this.InfoLogin.Size = new System.Drawing.Size(35, 37);
            this.InfoLogin.TabIndex = 3;
            this.InfoLogin.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин:";
            // 
            // InfoGender
            // 
            this.InfoGender.AutoSize = true;
            this.InfoGender.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoGender.Location = new System.Drawing.Point(332, 26);
            this.InfoGender.Name = "InfoGender";
            this.InfoGender.Size = new System.Drawing.Size(35, 37);
            this.InfoGender.TabIndex = 1;
            this.InfoGender.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пол:";
            // 
            // InfoPatronymic
            // 
            this.InfoPatronymic.AutoSize = true;
            this.InfoPatronymic.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoPatronymic.Location = new System.Drawing.Point(296, 246);
            this.InfoPatronymic.Name = "InfoPatronymic";
            this.InfoPatronymic.Size = new System.Drawing.Size(56, 54);
            this.InfoPatronymic.TabIndex = 3;
            this.InfoPatronymic.Text = "...";
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoName.Location = new System.Drawing.Point(296, 159);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(56, 54);
            this.InfoName.TabIndex = 2;
            this.InfoName.Text = "...";
            // 
            // InfoSurname
            // 
            this.InfoSurname.AutoSize = true;
            this.InfoSurname.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoSurname.Location = new System.Drawing.Point(296, 65);
            this.InfoSurname.Name = "InfoSurname";
            this.InfoSurname.Size = new System.Drawing.Size(56, 54);
            this.InfoSurname.TabIndex = 1;
            this.InfoSurname.Text = "...";
            // 
            // InfoProfilePhoto
            // 
            this.InfoProfilePhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfoProfilePhoto.Location = new System.Drawing.Point(35, 26);
            this.InfoProfilePhoto.Name = "InfoProfilePhoto";
            this.InfoProfilePhoto.Size = new System.Drawing.Size(240, 320);
            this.InfoProfilePhoto.TabIndex = 0;
            this.InfoProfilePhoto.TabStop = false;
            // 
            // AccountsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(240)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsEditForm";
            this.Text = "AccountsEditForm";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoProfilePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MakeAdminBut;
        private System.Windows.Forms.Button DelAdminBut;
        private System.Windows.Forms.Button DeleteUserBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox AthletesComboBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InfoGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoPatronymic;
        private System.Windows.Forms.Label InfoName;
        private System.Windows.Forms.Label InfoSurname;
        private System.Windows.Forms.PictureBox InfoProfilePhoto;
        private System.Windows.Forms.Label InfoBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label InfoLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InfoStature;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label InfoEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label InfoNationality;
        private System.Windows.Forms.Label label7;
    }
}