﻿namespace MainApplication.Forms
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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.nemuSettings = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.panelAchivementsSubmenu = new System.Windows.Forms.Panel();
            this.submenuAchivementsAdd = new System.Windows.Forms.Button();
            this.submenuAchivementsView = new System.Windows.Forms.Button();
            this.menuExit = new System.Windows.Forms.Button();
            this.menuAchivements = new System.Windows.Forms.Button();
            this.menuProfile = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            this.panelAchivementsSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panelMainMenu.Controls.Add(this.nemuSettings);
            this.panelMainMenu.Controls.Add(this.Search);
            this.panelMainMenu.Controls.Add(this.panelAchivementsSubmenu);
            this.panelMainMenu.Controls.Add(this.menuExit);
            this.panelMainMenu.Controls.Add(this.menuAchivements);
            this.panelMainMenu.Controls.Add(this.menuProfile);
            this.panelMainMenu.Controls.Add(this.panelHeader);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(300, 900);
            this.panelMainMenu.TabIndex = 1;
            // 
            // nemuSettings
            // 
            this.nemuSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.nemuSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.nemuSettings.FlatAppearance.BorderSize = 0;
            this.nemuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nemuSettings.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nemuSettings.Location = new System.Drawing.Point(0, 384);
            this.nemuSettings.Name = "nemuSettings";
            this.nemuSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.nemuSettings.Size = new System.Drawing.Size(300, 50);
            this.nemuSettings.TabIndex = 8;
            this.nemuSettings.Text = "Настройки";
            this.nemuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nemuSettings.UseVisualStyleBackColor = true;
            this.nemuSettings.Click += new System.EventHandler(this.nemuSettings_Click);
            // 
            // Search
            // 
            this.Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(0, 334);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Search.Size = new System.Drawing.Size(300, 50);
            this.Search.TabIndex = 7;
            this.Search.Text = "Поиск по спортсменам";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panelAchivementsSubmenu
            // 
            this.panelAchivementsSubmenu.Controls.Add(this.submenuAchivementsAdd);
            this.panelAchivementsSubmenu.Controls.Add(this.submenuAchivementsView);
            this.panelAchivementsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAchivementsSubmenu.Location = new System.Drawing.Point(0, 225);
            this.panelAchivementsSubmenu.Name = "panelAchivementsSubmenu";
            this.panelAchivementsSubmenu.Size = new System.Drawing.Size(300, 109);
            this.panelAchivementsSubmenu.TabIndex = 6;
            // 
            // submenuAchivementsAdd
            // 
            this.submenuAchivementsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuAchivementsAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.submenuAchivementsAdd.FlatAppearance.BorderSize = 0;
            this.submenuAchivementsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submenuAchivementsAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submenuAchivementsAdd.Location = new System.Drawing.Point(0, 50);
            this.submenuAchivementsAdd.Name = "submenuAchivementsAdd";
            this.submenuAchivementsAdd.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.submenuAchivementsAdd.Size = new System.Drawing.Size(300, 50);
            this.submenuAchivementsAdd.TabIndex = 10;
            this.submenuAchivementsAdd.Text = "Добавить";
            this.submenuAchivementsAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenuAchivementsAdd.UseVisualStyleBackColor = true;
            this.submenuAchivementsAdd.Click += new System.EventHandler(this.submenuAchivementsAdd_Click);
            // 
            // submenuAchivementsView
            // 
            this.submenuAchivementsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuAchivementsView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.submenuAchivementsView.FlatAppearance.BorderSize = 0;
            this.submenuAchivementsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submenuAchivementsView.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submenuAchivementsView.Location = new System.Drawing.Point(0, 0);
            this.submenuAchivementsView.Name = "submenuAchivementsView";
            this.submenuAchivementsView.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.submenuAchivementsView.Size = new System.Drawing.Size(300, 50);
            this.submenuAchivementsView.TabIndex = 9;
            this.submenuAchivementsView.Text = "Просмотр";
            this.submenuAchivementsView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenuAchivementsView.UseVisualStyleBackColor = true;
            this.submenuAchivementsView.Click += new System.EventHandler(this.submenuAchivementsView_Click);
            // 
            // menuExit
            // 
            this.menuExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.menuExit.FlatAppearance.BorderSize = 0;
            this.menuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuExit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuExit.Location = new System.Drawing.Point(0, 850);
            this.menuExit.Name = "menuExit";
            this.menuExit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.menuExit.Size = new System.Drawing.Size(300, 50);
            this.menuExit.TabIndex = 5;
            this.menuExit.Text = "Выход";
            this.menuExit.UseVisualStyleBackColor = true;
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuAchivements
            // 
            this.menuAchivements.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuAchivements.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.menuAchivements.FlatAppearance.BorderSize = 0;
            this.menuAchivements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuAchivements.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuAchivements.Location = new System.Drawing.Point(0, 175);
            this.menuAchivements.Name = "menuAchivements";
            this.menuAchivements.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.menuAchivements.Size = new System.Drawing.Size(300, 50);
            this.menuAchivements.TabIndex = 2;
            this.menuAchivements.Text = "Достижения";
            this.menuAchivements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAchivements.UseVisualStyleBackColor = true;
            this.menuAchivements.Click += new System.EventHandler(this.menuAchivements_Click);
            // 
            // menuProfile
            // 
            this.menuProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.menuProfile.FlatAppearance.BorderSize = 0;
            this.menuProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuProfile.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuProfile.Location = new System.Drawing.Point(0, 125);
            this.menuProfile.Name = "menuProfile";
            this.menuProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.menuProfile.Size = new System.Drawing.Size(300, 50);
            this.menuProfile.TabIndex = 1;
            this.menuProfile.Text = "Профиль";
            this.menuProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuProfile.UseVisualStyleBackColor = true;
            this.menuProfile.Click += new System.EventHandler(this.menuProfile_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(300, 125);
            this.panelHeader.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(300, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1200, 900);
            this.panelChildForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMainMenu);
            this.MinimumSize = new System.Drawing.Size(1518, 947);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panelMainMenu.ResumeLayout(false);
            this.panelAchivementsSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button menuExit;
        private System.Windows.Forms.Button menuAchivements;
        private System.Windows.Forms.Button menuProfile;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button nemuSettings;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panelAchivementsSubmenu;
        private System.Windows.Forms.Button submenuAchivementsAdd;
        private System.Windows.Forms.Button submenuAchivementsView;
        private System.Windows.Forms.Panel panelChildForm;
    }
}