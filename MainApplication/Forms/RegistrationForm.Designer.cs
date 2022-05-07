namespace AthletesRating.Forms
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserSurname = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.conPassTB = new System.Windows.Forms.TextBox();
            this.EmailVerificationBut = new System.Windows.Forms.Button();
            this.RegBut = new System.Windows.Forms.Button();
            this.EmailError = new System.Windows.Forms.Label();
            this.conPassError = new System.Windows.Forms.Label();
            this.EVerLabel = new System.Windows.Forms.Label();
            this.EmailVerificationTB = new System.Windows.Forms.TextBox();
            this.timerInfoLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.passError = new System.Windows.Forms.Label();
            this.UserPatronymic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BirthDateTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.passConView = new System.Windows.Forms.Button();
            this.passView = new System.Windows.Forms.Button();
            this.UserInfoPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UserName.Location = new System.Drawing.Point(15, 114);
            this.UserName.Margin = new System.Windows.Forms.Padding(2);
            this.UserName.MaxLength = 10;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(527, 38);
            this.UserName.TabIndex = 2;
            // 
            // UserSurname
            // 
            this.UserSurname.BackColor = System.Drawing.Color.White;
            this.UserSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSurname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSurname.ForeColor = System.Drawing.Color.Black;
            this.UserSurname.Location = new System.Drawing.Point(15, 43);
            this.UserSurname.Margin = new System.Windows.Forms.Padding(2);
            this.UserSurname.MaxLength = 50;
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.Size = new System.Drawing.Size(527, 31);
            this.UserSurname.TabIndex = 3;
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailTB.Location = new System.Drawing.Point(27, 346);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTB.MaxLength = 50;
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(527, 38);
            this.EmailTB.TabIndex = 4;
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Подтвердите пароль";
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginTB.Location = new System.Drawing.Point(27, 426);
            this.loginTB.Margin = new System.Windows.Forms.Padding(2);
            this.loginTB.MaxLength = 50;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(527, 38);
            this.loginTB.TabIndex = 9;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTB.Location = new System.Drawing.Point(15, 31);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTB.MaxLength = 10;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(482, 38);
            this.passwordTB.TabIndex = 10;
            this.passwordTB.UseSystemPasswordChar = true;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // conPassTB
            // 
            this.conPassTB.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.conPassTB.Location = new System.Drawing.Point(15, 122);
            this.conPassTB.Margin = new System.Windows.Forms.Padding(2);
            this.conPassTB.MaxLength = 10;
            this.conPassTB.Name = "conPassTB";
            this.conPassTB.Size = new System.Drawing.Size(482, 38);
            this.conPassTB.TabIndex = 11;
            this.conPassTB.UseSystemPasswordChar = true;
            this.conPassTB.TextChanged += new System.EventHandler(this.conPassTB_TextChanged);
            // 
            // EmailVerificationBut
            // 
            this.EmailVerificationBut.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailVerificationBut.Location = new System.Drawing.Point(24, 764);
            this.EmailVerificationBut.Margin = new System.Windows.Forms.Padding(2);
            this.EmailVerificationBut.Name = "EmailVerificationBut";
            this.EmailVerificationBut.Size = new System.Drawing.Size(341, 42);
            this.EmailVerificationBut.TabIndex = 12;
            this.EmailVerificationBut.Text = "Подтвердить почту";
            this.EmailVerificationBut.UseVisualStyleBackColor = true;
            this.EmailVerificationBut.Click += new System.EventHandler(this.EmailVerification_Click);
            // 
            // RegBut
            // 
            this.RegBut.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegBut.Location = new System.Drawing.Point(369, 764);
            this.RegBut.Margin = new System.Windows.Forms.Padding(2);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(183, 42);
            this.RegBut.TabIndex = 13;
            this.RegBut.Text = "Регистрация";
            this.RegBut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegBut.UseVisualStyleBackColor = true;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // EmailError
            // 
            this.EmailError.AutoSize = true;
            this.EmailError.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmailError.ForeColor = System.Drawing.Color.Red;
            this.EmailError.Location = new System.Drawing.Point(27, 386);
            this.EmailError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailError.Name = "EmailError";
            this.EmailError.Size = new System.Drawing.Size(0, 16);
            this.EmailError.TabIndex = 14;
            // 
            // conPassError
            // 
            this.conPassError.AutoSize = true;
            this.conPassError.ForeColor = System.Drawing.Color.Red;
            this.conPassError.Location = new System.Drawing.Point(15, 162);
            this.conPassError.Name = "conPassError";
            this.conPassError.Size = new System.Drawing.Size(0, 20);
            this.conPassError.TabIndex = 15;
            // 
            // EVerLabel
            // 
            this.EVerLabel.AutoSize = true;
            this.EVerLabel.Location = new System.Drawing.Point(27, 673);
            this.EVerLabel.Name = "EVerLabel";
            this.EVerLabel.Size = new System.Drawing.Size(497, 20);
            this.EVerLabel.TabIndex = 16;
            this.EVerLabel.Text = "На указанную вами почту придет письмо с кодом, введите его в поле ниже:";
            this.EVerLabel.Visible = false;
            // 
            // EmailVerificationTB
            // 
            this.EmailVerificationTB.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailVerificationTB.Location = new System.Drawing.Point(27, 696);
            this.EmailVerificationTB.Name = "EmailVerificationTB";
            this.EmailVerificationTB.Size = new System.Drawing.Size(527, 38);
            this.EmailVerificationTB.TabIndex = 17;
            this.EmailVerificationTB.Visible = false;
            // 
            // timerInfoLabel
            // 
            this.timerInfoLabel.AutoSize = true;
            this.timerInfoLabel.Location = new System.Drawing.Point(27, 737);
            this.timerInfoLabel.Name = "timerInfoLabel";
            this.timerInfoLabel.Size = new System.Drawing.Size(292, 20);
            this.timerInfoLabel.TabIndex = 18;
            this.timerInfoLabel.Text = "Повторная отправка кода доступна через: ";
            this.timerInfoLabel.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(322, 737);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 20);
            this.timerLabel.TabIndex = 19;
            // 
            // passError
            // 
            this.passError.AutoSize = true;
            this.passError.ForeColor = System.Drawing.Color.Red;
            this.passError.Location = new System.Drawing.Point(15, 71);
            this.passError.Name = "passError";
            this.passError.Size = new System.Drawing.Size(0, 20);
            this.passError.TabIndex = 20;
            // 
            // UserPatronymic
            // 
            this.UserPatronymic.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UserPatronymic.Location = new System.Drawing.Point(15, 188);
            this.UserPatronymic.Margin = new System.Windows.Forms.Padding(2);
            this.UserPatronymic.MaxLength = 10;
            this.UserPatronymic.Name = "UserPatronymic";
            this.UserPatronymic.Size = new System.Drawing.Size(527, 38);
            this.UserPatronymic.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Отчество";
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.Controls.Add(this.label9);
            this.UserInfoPanel.Controls.Add(this.BirthDateTP);
            this.UserInfoPanel.Controls.Add(this.UserPatronymic);
            this.UserInfoPanel.Controls.Add(this.label8);
            this.UserInfoPanel.Controls.Add(this.label1);
            this.UserInfoPanel.Controls.Add(this.GenderCB);
            this.UserInfoPanel.Controls.Add(this.label7);
            this.UserInfoPanel.Controls.Add(this.label2);
            this.UserInfoPanel.Controls.Add(this.UserName);
            this.UserInfoPanel.Controls.Add(this.UserSurname);
            this.UserInfoPanel.Location = new System.Drawing.Point(12, 7);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(562, 307);
            this.UserInfoPanel.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(232, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Дата рождения";
            // 
            // BirthDateTP
            // 
            this.BirthDateTP.Font = new System.Drawing.Font("Arial Narrow", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BirthDateTP.Location = new System.Drawing.Point(232, 265);
            this.BirthDateTP.Name = "BirthDateTP";
            this.BirthDateTP.Size = new System.Drawing.Size(310, 29);
            this.BirthDateTP.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "Пол";
            // 
            // GenderCB
            // 
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GenderCB.Location = new System.Drawing.Point(15, 266);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(179, 28);
            this.GenderCB.TabIndex = 24;
            this.GenderCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.passConView);
            this.PasswordPanel.Controls.Add(this.passView);
            this.PasswordPanel.Controls.Add(this.conPassTB);
            this.PasswordPanel.Controls.Add(this.label5);
            this.PasswordPanel.Controls.Add(this.passError);
            this.PasswordPanel.Controls.Add(this.label6);
            this.PasswordPanel.Controls.Add(this.passwordTB);
            this.PasswordPanel.Controls.Add(this.conPassError);
            this.PasswordPanel.Location = new System.Drawing.Point(12, 478);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(562, 192);
            this.PasswordPanel.TabIndex = 26;
            // 
            // passConView
            // 
            this.passConView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passConView.BackgroundImage")));
            this.passConView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passConView.FlatAppearance.BorderSize = 0;
            this.passConView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passConView.Location = new System.Drawing.Point(502, 122);
            this.passConView.Name = "passConView";
            this.passConView.Size = new System.Drawing.Size(38, 38);
            this.passConView.TabIndex = 22;
            this.passConView.UseVisualStyleBackColor = true;
            this.passConView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passConView_MouseDown);
            this.passConView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passConView_MouseUp);
            // 
            // passView
            // 
            this.passView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passView.BackgroundImage")));
            this.passView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passView.FlatAppearance.BorderSize = 0;
            this.passView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passView.Location = new System.Drawing.Point(502, 31);
            this.passView.Name = "passView";
            this.passView.Size = new System.Drawing.Size(38, 38);
            this.passView.TabIndex = 21;
            this.passView.UseVisualStyleBackColor = true;
            this.passView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passView_MouseDown);
            this.passView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passView_MouseUp);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(216)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(591, 817);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.UserInfoPanel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerInfoLabel);
            this.Controls.Add(this.EmailVerificationTB);
            this.Controls.Add(this.EVerLabel);
            this.Controls.Add(this.EmailError);
            this.Controls.Add(this.RegBut);
            this.Controls.Add(this.EmailVerificationBut);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailTB);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(609, 864);
            this.MinimumSize = new System.Drawing.Size(609, 864);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserSurname;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox conPassTB;
        private System.Windows.Forms.Button EmailVerificationBut;
        private System.Windows.Forms.Button RegBut;
        private System.Windows.Forms.Label EmailError;
        private System.Windows.Forms.Label conPassError;
        private System.Windows.Forms.Label EVerLabel;
        private System.Windows.Forms.TextBox EmailVerificationTB;
        private System.Windows.Forms.Label timerInfoLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label passError;
        private System.Windows.Forms.TextBox UserPatronymic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker BirthDateTP;
        private System.Windows.Forms.Button passConView;
        private System.Windows.Forms.Button passView;
    }
}