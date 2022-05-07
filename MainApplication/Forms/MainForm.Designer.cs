namespace MainApplication.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.HomePageBtn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            this.menuSettings = new System.Windows.Forms.Button();
            this.submenuAccountsAdministration = new System.Windows.Forms.Panel();
            this.AccountsAdministrationEdit = new System.Windows.Forms.Button();
            this.AccountsAdministrationView = new System.Windows.Forms.Button();
            this.menuAccountsAdministration = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.menuProfile = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.submenuAccountsAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Black;
            this.panelMainMenu.Controls.Add(this.HomePageBtn);
            this.panelMainMenu.Controls.Add(this.panel1);
            this.panelMainMenu.Controls.Add(this.menuSettings);
            this.panelMainMenu.Controls.Add(this.submenuAccountsAdministration);
            this.panelMainMenu.Controls.Add(this.menuAccountsAdministration);
            this.panelMainMenu.Controls.Add(this.Search);
            this.panelMainMenu.Controls.Add(this.menuProfile);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1500, 54);
            this.panelMainMenu.TabIndex = 1;
            // 
            // HomePageBtn
            // 
            this.HomePageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePageBtn.BackgroundImage")));
            this.HomePageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomePageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.HomePageBtn.Location = new System.Drawing.Point(1259, 0);
            this.HomePageBtn.Name = "HomePageBtn";
            this.HomePageBtn.Size = new System.Drawing.Size(54, 54);
            this.HomePageBtn.TabIndex = 13;
            this.HomePageBtn.Click += new System.EventHandler(this.HomePageBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yt_Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1313, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 54);
            this.panel1.TabIndex = 11;
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
            this.yt_Button1.Location = new System.Drawing.Point(9, 6);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(168, 42);
            this.yt_Button1.TabIndex = 12;
            this.yt_Button1.Text = "Выход";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuSettings.FlatAppearance.BorderSize = 0;
            this.menuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSettings.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuSettings.Location = new System.Drawing.Point(981, 0);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(175, 54);
            this.menuSettings.TabIndex = 10;
            this.menuSettings.Text = "Настройки";
            this.menuSettings.UseVisualStyleBackColor = true;
            this.menuSettings.Click += new System.EventHandler(this.nemuSettings_Click);
            this.menuSettings.MouseLeave += new System.EventHandler(this.menuProfile_MouseLeave);
            this.menuSettings.MouseHover += new System.EventHandler(this.menuProfile_MouseHover);
            // 
            // submenuAccountsAdministration
            // 
            this.submenuAccountsAdministration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.submenuAccountsAdministration.Controls.Add(this.AccountsAdministrationEdit);
            this.submenuAccountsAdministration.Controls.Add(this.AccountsAdministrationView);
            this.submenuAccountsAdministration.Dock = System.Windows.Forms.DockStyle.Left;
            this.submenuAccountsAdministration.Location = new System.Drawing.Point(632, 0);
            this.submenuAccountsAdministration.Name = "submenuAccountsAdministration";
            this.submenuAccountsAdministration.Size = new System.Drawing.Size(349, 54);
            this.submenuAccountsAdministration.TabIndex = 12;
            // 
            // AccountsAdministrationEdit
            // 
            this.AccountsAdministrationEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountsAdministrationEdit.FlatAppearance.BorderSize = 0;
            this.AccountsAdministrationEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountsAdministrationEdit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountsAdministrationEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountsAdministrationEdit.Location = new System.Drawing.Point(170, 0);
            this.AccountsAdministrationEdit.Name = "AccountsAdministrationEdit";
            this.AccountsAdministrationEdit.Size = new System.Drawing.Size(170, 52);
            this.AccountsAdministrationEdit.TabIndex = 1;
            this.AccountsAdministrationEdit.Text = "Управление";
            this.AccountsAdministrationEdit.UseVisualStyleBackColor = true;
            this.AccountsAdministrationEdit.Click += new System.EventHandler(this.AccountsAdministrationEdit_Click);
            this.AccountsAdministrationEdit.MouseLeave += new System.EventHandler(this.menuProfile_MouseLeave);
            this.AccountsAdministrationEdit.MouseHover += new System.EventHandler(this.menuProfile_MouseHover);
            // 
            // AccountsAdministrationView
            // 
            this.AccountsAdministrationView.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountsAdministrationView.FlatAppearance.BorderSize = 0;
            this.AccountsAdministrationView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountsAdministrationView.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountsAdministrationView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountsAdministrationView.Location = new System.Drawing.Point(0, 0);
            this.AccountsAdministrationView.Name = "AccountsAdministrationView";
            this.AccountsAdministrationView.Size = new System.Drawing.Size(170, 52);
            this.AccountsAdministrationView.TabIndex = 0;
            this.AccountsAdministrationView.Text = "Просмотр";
            this.AccountsAdministrationView.UseVisualStyleBackColor = true;
            this.AccountsAdministrationView.Click += new System.EventHandler(this.AccountsAdministrationView_Click);
            this.AccountsAdministrationView.MouseLeave += new System.EventHandler(this.menuProfile_MouseLeave);
            this.AccountsAdministrationView.MouseHover += new System.EventHandler(this.menuProfile_MouseHover);
            // 
            // menuAccountsAdministration
            // 
            this.menuAccountsAdministration.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuAccountsAdministration.FlatAppearance.BorderSize = 0;
            this.menuAccountsAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuAccountsAdministration.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuAccountsAdministration.Location = new System.Drawing.Point(462, 0);
            this.menuAccountsAdministration.Name = "menuAccountsAdministration";
            this.menuAccountsAdministration.Size = new System.Drawing.Size(170, 54);
            this.menuAccountsAdministration.TabIndex = 8;
            this.menuAccountsAdministration.Text = "Аккаунты";
            this.menuAccountsAdministration.UseVisualStyleBackColor = true;
            this.menuAccountsAdministration.Click += new System.EventHandler(this.menuAccountsAdministration_Click);
            this.menuAccountsAdministration.MouseLeave += new System.EventHandler(this.menuProfile_MouseLeave);
            this.menuAccountsAdministration.MouseHover += new System.EventHandler(this.menuProfile_MouseHover);
            // 
            // Search
            // 
            this.Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(170, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(292, 54);
            this.Search.TabIndex = 7;
            this.Search.Text = "Поиск по спортсменам";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.MouseLeave += new System.EventHandler(this.menuProfile_MouseLeave);
            this.Search.MouseHover += new System.EventHandler(this.menuProfile_MouseHover);
            // 
            // menuProfile
            // 
            this.menuProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.menuProfile.FlatAppearance.BorderSize = 0;
            this.menuProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuProfile.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuProfile.Location = new System.Drawing.Point(0, 0);
            this.menuProfile.Name = "menuProfile";
            this.menuProfile.Size = new System.Drawing.Size(170, 54);
            this.menuProfile.TabIndex = 1;
            this.menuProfile.Text = "Профиль";
            this.menuProfile.UseVisualStyleBackColor = true;
            this.menuProfile.Click += new System.EventHandler(this.menuProfile_Click);
            this.menuProfile.MouseLeave += new System.EventHandler(this.menuProfile_MouseLeave);
            this.menuProfile.MouseHover += new System.EventHandler(this.menuProfile_MouseHover);
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(216)))), ((int)(((byte)(130)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 54);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1500, 846);
            this.panelChildForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimumSize = new System.Drawing.Size(1518, 947);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.submenuAccountsAdministration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button menuProfile;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button menuSettings;
        private System.Windows.Forms.Button AccountsAdministrationEdit;
        private System.Windows.Forms.Button AccountsAdministrationView;
        private System.Windows.Forms.Button menuAccountsAdministration;
        private System.Windows.Forms.Panel panel1;
        private yt_DesignUI.yt_Button yt_Button1;
        private System.Windows.Forms.Panel submenuAccountsAdministration;
        private System.Windows.Forms.Panel HomePageBtn;
    }
}