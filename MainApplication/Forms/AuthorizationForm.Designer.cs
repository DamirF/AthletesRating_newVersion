namespace SportsmansRating
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RecoveryPanel = new System.Windows.Forms.Panel();
            this.passRecConView = new System.Windows.Forms.Panel();
            this.passRecView = new System.Windows.Forms.Panel();
            this.CancelBut = new System.Windows.Forms.Button();
            this.ConPassError = new System.Windows.Forms.Label();
            this.PassError = new System.Windows.Forms.Label();
            this.EmailErrorLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.verInfo = new System.Windows.Forms.Label();
            this.EmailVerTB = new System.Windows.Forms.TextBox();
            this.ConEmailBut = new System.Windows.Forms.Button();
            this.SendCodeBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.newPassConTB = new System.Windows.Forms.TextBox();
            this.newPassTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordRecovery = new System.Windows.Forms.LinkLabel();
            this.registrationLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.RecoveryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.RecoveryPanel);
            this.MainPanel.Controls.Add(this.linkLabel1);
            this.MainPanel.Controls.Add(this.yt_Button1);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.passwordRecovery);
            this.MainPanel.Controls.Add(this.registrationLink);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.passwordTB);
            this.MainPanel.Controls.Add(this.loginTB);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(569, 495);
            this.MainPanel.TabIndex = 0;
            // 
            // RecoveryPanel
            // 
            this.RecoveryPanel.BackColor = System.Drawing.Color.Black;
            this.RecoveryPanel.Controls.Add(this.passRecConView);
            this.RecoveryPanel.Controls.Add(this.passRecView);
            this.RecoveryPanel.Controls.Add(this.CancelBut);
            this.RecoveryPanel.Controls.Add(this.ConPassError);
            this.RecoveryPanel.Controls.Add(this.PassError);
            this.RecoveryPanel.Controls.Add(this.EmailErrorLabel);
            this.RecoveryPanel.Controls.Add(this.timerLabel);
            this.RecoveryPanel.Controls.Add(this.verInfo);
            this.RecoveryPanel.Controls.Add(this.EmailVerTB);
            this.RecoveryPanel.Controls.Add(this.ConEmailBut);
            this.RecoveryPanel.Controls.Add(this.SendCodeBut);
            this.RecoveryPanel.Controls.Add(this.SaveBut);
            this.RecoveryPanel.Controls.Add(this.newPassConTB);
            this.RecoveryPanel.Controls.Add(this.newPassTB);
            this.RecoveryPanel.Controls.Add(this.EmailTB);
            this.RecoveryPanel.Controls.Add(this.label6);
            this.RecoveryPanel.Controls.Add(this.label5);
            this.RecoveryPanel.Controls.Add(this.label4);
            this.RecoveryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecoveryPanel.ForeColor = System.Drawing.Color.White;
            this.RecoveryPanel.Location = new System.Drawing.Point(0, 0);
            this.RecoveryPanel.Name = "RecoveryPanel";
            this.RecoveryPanel.Size = new System.Drawing.Size(569, 495);
            this.RecoveryPanel.TabIndex = 24;
            // 
            // passRecConView
            // 
            this.passRecConView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passRecConView.BackgroundImage")));
            this.passRecConView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passRecConView.Location = new System.Drawing.Point(448, 368);
            this.passRecConView.Name = "passRecConView";
            this.passRecConView.Size = new System.Drawing.Size(34, 34);
            this.passRecConView.TabIndex = 17;
            this.passRecConView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passRecView_MouseDown);
            this.passRecConView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passRecConView_MouseUp);
            // 
            // passRecView
            // 
            this.passRecView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passRecView.BackgroundImage")));
            this.passRecView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passRecView.Location = new System.Drawing.Point(448, 275);
            this.passRecView.Name = "passRecView";
            this.passRecView.Size = new System.Drawing.Size(34, 34);
            this.passRecView.TabIndex = 16;
            this.passRecView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passRecView_MouseDown);
            this.passRecView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passRecView_MouseUp);
            // 
            // CancelBut
            // 
            this.CancelBut.BackColor = System.Drawing.Color.Black;
            this.CancelBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelBut.ForeColor = System.Drawing.Color.White;
            this.CancelBut.Location = new System.Drawing.Point(299, 436);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(143, 47);
            this.CancelBut.TabIndex = 15;
            this.CancelBut.Text = "Отмена";
            this.CancelBut.UseVisualStyleBackColor = false;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // ConPassError
            // 
            this.ConPassError.AutoSize = true;
            this.ConPassError.ForeColor = System.Drawing.Color.Red;
            this.ConPassError.Location = new System.Drawing.Point(120, 405);
            this.ConPassError.Name = "ConPassError";
            this.ConPassError.Size = new System.Drawing.Size(0, 20);
            this.ConPassError.TabIndex = 14;
            // 
            // PassError
            // 
            this.PassError.AutoSize = true;
            this.PassError.ForeColor = System.Drawing.Color.Red;
            this.PassError.Location = new System.Drawing.Point(120, 312);
            this.PassError.Name = "PassError";
            this.PassError.Size = new System.Drawing.Size(0, 20);
            this.PassError.TabIndex = 13;
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.AutoSize = true;
            this.EmailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLabel.Location = new System.Drawing.Point(227, 18);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.EmailErrorLabel.TabIndex = 12;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(392, 142);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 20);
            this.timerLabel.TabIndex = 11;
            // 
            // verInfo
            // 
            this.verInfo.AutoSize = true;
            this.verInfo.Location = new System.Drawing.Point(120, 142);
            this.verInfo.Name = "verInfo";
            this.verInfo.Size = new System.Drawing.Size(268, 20);
            this.verInfo.TabIndex = 10;
            this.verInfo.Text = "Повторная отправка доступна через:";
            // 
            // EmailVerTB
            // 
            this.EmailVerTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailVerTB.Location = new System.Drawing.Point(120, 165);
            this.EmailVerTB.Name = "EmailVerTB";
            this.EmailVerTB.Size = new System.Drawing.Size(322, 34);
            this.EmailVerTB.TabIndex = 9;
            // 
            // ConEmailBut
            // 
            this.ConEmailBut.BackColor = System.Drawing.Color.Black;
            this.ConEmailBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConEmailBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConEmailBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConEmailBut.ForeColor = System.Drawing.Color.White;
            this.ConEmailBut.Location = new System.Drawing.Point(120, 205);
            this.ConEmailBut.Name = "ConEmailBut";
            this.ConEmailBut.Size = new System.Drawing.Size(322, 36);
            this.ConEmailBut.TabIndex = 8;
            this.ConEmailBut.Text = "Проверить";
            this.ConEmailBut.UseVisualStyleBackColor = false;
            this.ConEmailBut.Click += new System.EventHandler(this.ConEmailBut_Click);
            // 
            // SendCodeBut
            // 
            this.SendCodeBut.BackColor = System.Drawing.Color.Black;
            this.SendCodeBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendCodeBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SendCodeBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendCodeBut.ForeColor = System.Drawing.Color.White;
            this.SendCodeBut.Location = new System.Drawing.Point(120, 82);
            this.SendCodeBut.Name = "SendCodeBut";
            this.SendCodeBut.Size = new System.Drawing.Size(322, 34);
            this.SendCodeBut.TabIndex = 7;
            this.SendCodeBut.Text = "Выслать код";
            this.SendCodeBut.UseVisualStyleBackColor = false;
            this.SendCodeBut.Click += new System.EventHandler(this.SendCodeBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.BackColor = System.Drawing.Color.Black;
            this.SaveBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBut.ForeColor = System.Drawing.Color.White;
            this.SaveBut.Location = new System.Drawing.Point(120, 436);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(171, 47);
            this.SaveBut.TabIndex = 6;
            this.SaveBut.Text = "Сохранить";
            this.SaveBut.UseVisualStyleBackColor = false;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // newPassConTB
            // 
            this.newPassConTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassConTB.Location = new System.Drawing.Point(120, 368);
            this.newPassConTB.Name = "newPassConTB";
            this.newPassConTB.Size = new System.Drawing.Size(322, 34);
            this.newPassConTB.TabIndex = 5;
            this.newPassConTB.UseSystemPasswordChar = true;
            this.newPassConTB.TextChanged += new System.EventHandler(this.newPassConTB_TextChanged);
            // 
            // newPassTB
            // 
            this.newPassTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassTB.Location = new System.Drawing.Point(120, 275);
            this.newPassTB.Name = "newPassTB";
            this.newPassTB.Size = new System.Drawing.Size(322, 34);
            this.newPassTB.TabIndex = 4;
            this.newPassTB.UseSystemPasswordChar = true;
            this.newPassTB.TextChanged += new System.EventHandler(this.newPassTB_TextChanged);
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTB.Location = new System.Drawing.Point(120, 42);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(322, 34);
            this.EmailTB.TabIndex = 3;
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(120, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Подтвердите новый пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(120, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Новый пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(120, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-mail";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(155, 443);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(250, 28);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Продолжить без аккаунта";
            this.linkLabel1.Click += new System.EventHandler(this.withoutAccBut_Click);
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.Red;
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.Gray;
            this.yt_Button1.BackColorGradientEnabled = false;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.yt_Button1.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorEnabled = false;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorOnHoverEnabled = false;
            this.yt_Button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(182, 315);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.Rounding = 50;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(206, 38);
            this.yt_Button1.TabIndex = 22;
            this.yt_Button1.Text = "Войти";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.signINbut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(135, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 54);
            this.label7.TabIndex = 21;
            this.label7.Text = "Авторизация";
            // 
            // passwordRecovery
            // 
            this.passwordRecovery.AutoSize = true;
            this.passwordRecovery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordRecovery.LinkColor = System.Drawing.Color.White;
            this.passwordRecovery.Location = new System.Drawing.Point(299, 388);
            this.passwordRecovery.Name = "passwordRecovery";
            this.passwordRecovery.Size = new System.Drawing.Size(163, 28);
            this.passwordRecovery.TabIndex = 16;
            this.passwordRecovery.TabStop = true;
            this.passwordRecovery.Text = "Забыли пароль?";
            this.passwordRecovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passwordRecovery_LinkClicked);
            // 
            // registrationLink
            // 
            this.registrationLink.AutoSize = true;
            this.registrationLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrationLink.LinkColor = System.Drawing.Color.White;
            this.registrationLink.Location = new System.Drawing.Point(107, 388);
            this.registrationLink.Name = "registrationLink";
            this.registrationLink.Size = new System.Drawing.Size(126, 28);
            this.registrationLink.TabIndex = 15;
            this.registrationLink.TabStop = true;
            this.registrationLink.Text = "Регистрация";
            this.registrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(107, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(215, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин";
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTB.Location = new System.Drawing.Point(107, 240);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(355, 43);
            this.passwordTB.TabIndex = 10;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginTB.Location = new System.Drawing.Point(107, 151);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(355, 43);
            this.loginTB.TabIndex = 9;
            this.loginTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(569, 495);
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(587, 542);
            this.MinimumSize = new System.Drawing.Size(587, 542);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthorizationForm_FormClosed);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.RecoveryPanel.ResumeLayout(false);
            this.RecoveryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.LinkLabel passwordRecovery;
        private System.Windows.Forms.LinkLabel registrationLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private yt_DesignUI.yt_Button yt_Button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel RecoveryPanel;
        private System.Windows.Forms.Panel passRecConView;
        private System.Windows.Forms.Panel passRecView;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Label ConPassError;
        private System.Windows.Forms.Label PassError;
        private System.Windows.Forms.Label EmailErrorLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label verInfo;
        private System.Windows.Forms.TextBox EmailVerTB;
        private System.Windows.Forms.Button ConEmailBut;
        private System.Windows.Forms.Button SendCodeBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.TextBox newPassConTB;
        private System.Windows.Forms.TextBox newPassTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
