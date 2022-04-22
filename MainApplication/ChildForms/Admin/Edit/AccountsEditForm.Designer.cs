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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MakeAdminBut = new System.Windows.Forms.Button();
            this.DelAdminBut = new System.Windows.Forms.Button();
            this.DeleteUserBut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AthletesComboBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.profileTextSurname = new System.Windows.Forms.Label();
            this.profileTextName = new System.Windows.Forms.Label();
            this.profileTextPatronymic = new System.Windows.Forms.Label();
            this.profileTextBirthDate = new System.Windows.Forms.Label();
            this.profileTextGender = new System.Windows.Forms.Label();
            this.profileTextEmail = new System.Windows.Forms.Label();
            this.profileTextDateReg = new System.Windows.Forms.Label();
            this.profileTextDateOnlain = new System.Windows.Forms.Label();
            this.profileInfoSurname = new System.Windows.Forms.Label();
            this.profileInfoName = new System.Windows.Forms.Label();
            this.profileInfoPatronymic = new System.Windows.Forms.Label();
            this.profileInfoBirthDate = new System.Windows.Forms.Label();
            this.profileInfoGender = new System.Windows.Forms.Label();
            this.profileInfoEmail = new System.Windows.Forms.Label();
            this.profileInfoDateReg = new System.Windows.Forms.Label();
            this.profileInfoDateOnlain = new System.Windows.Forms.Label();
            this.profileTextIsAdmin = new System.Windows.Forms.Label();
            this.profileInfoIsAdmin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 40);
            this.panel1.TabIndex = 3;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(609, 35);
            this.Header.TabIndex = 2;
            this.Header.Text = "Редактирование зарегистрированных аккаунтов";
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(1160, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.TabIndex = 0;
            this.Close.Text = "<-";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.MakeAdminBut);
            this.panel2.Controls.Add(this.DelAdminBut);
            this.panel2.Controls.Add(this.DeleteUserBut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 790);
            this.panel3.TabIndex = 5;
            // 
            // AthletesComboBox
            // 
            this.AthletesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
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
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(450, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 790);
            this.panel4.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.profileTextSurname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.profileTextName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.profileTextPatronymic, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.profileTextBirthDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.profileTextGender, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.profileTextEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.profileTextDateReg, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.profileTextDateOnlain, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoSurname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoPatronymic, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoBirthDate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoGender, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoEmail, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoDateReg, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoDateOnlain, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.profileTextIsAdmin, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoIsAdmin, 2, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 790);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // profileTextSurname
            // 
            this.profileTextSurname.AutoSize = true;
            this.profileTextSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextSurname.Location = new System.Drawing.Point(18, 40);
            this.profileTextSurname.Name = "profileTextSurname";
            this.profileTextSurname.Size = new System.Drawing.Size(282, 78);
            this.profileTextSurname.TabIndex = 0;
            this.profileTextSurname.Text = "Фамилия:";
            this.profileTextSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextName
            // 
            this.profileTextName.AutoSize = true;
            this.profileTextName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextName.Location = new System.Drawing.Point(18, 118);
            this.profileTextName.Name = "profileTextName";
            this.profileTextName.Size = new System.Drawing.Size(282, 78);
            this.profileTextName.TabIndex = 1;
            this.profileTextName.Text = "Имя:";
            this.profileTextName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextPatronymic
            // 
            this.profileTextPatronymic.AutoSize = true;
            this.profileTextPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextPatronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextPatronymic.Location = new System.Drawing.Point(18, 196);
            this.profileTextPatronymic.Name = "profileTextPatronymic";
            this.profileTextPatronymic.Size = new System.Drawing.Size(282, 78);
            this.profileTextPatronymic.TabIndex = 2;
            this.profileTextPatronymic.Text = "Отчество:";
            this.profileTextPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextBirthDate
            // 
            this.profileTextBirthDate.AutoSize = true;
            this.profileTextBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextBirthDate.Location = new System.Drawing.Point(18, 274);
            this.profileTextBirthDate.Name = "profileTextBirthDate";
            this.profileTextBirthDate.Size = new System.Drawing.Size(282, 78);
            this.profileTextBirthDate.TabIndex = 3;
            this.profileTextBirthDate.Text = "Дата рождения:";
            this.profileTextBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextGender
            // 
            this.profileTextGender.AutoSize = true;
            this.profileTextGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextGender.Location = new System.Drawing.Point(18, 352);
            this.profileTextGender.Name = "profileTextGender";
            this.profileTextGender.Size = new System.Drawing.Size(282, 78);
            this.profileTextGender.TabIndex = 4;
            this.profileTextGender.Text = "Пол:";
            this.profileTextGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextEmail
            // 
            this.profileTextEmail.AutoSize = true;
            this.profileTextEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextEmail.Location = new System.Drawing.Point(18, 430);
            this.profileTextEmail.Name = "profileTextEmail";
            this.profileTextEmail.Size = new System.Drawing.Size(282, 78);
            this.profileTextEmail.TabIndex = 5;
            this.profileTextEmail.Text = "E-mail:";
            this.profileTextEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextDateReg
            // 
            this.profileTextDateReg.AutoSize = true;
            this.profileTextDateReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextDateReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextDateReg.Location = new System.Drawing.Point(18, 508);
            this.profileTextDateReg.Name = "profileTextDateReg";
            this.profileTextDateReg.Size = new System.Drawing.Size(282, 78);
            this.profileTextDateReg.TabIndex = 6;
            this.profileTextDateReg.Text = "Дата регистрации";
            this.profileTextDateReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextDateOnlain
            // 
            this.profileTextDateOnlain.AutoSize = true;
            this.profileTextDateOnlain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextDateOnlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextDateOnlain.Location = new System.Drawing.Point(18, 586);
            this.profileTextDateOnlain.Name = "profileTextDateOnlain";
            this.profileTextDateOnlain.Size = new System.Drawing.Size(282, 78);
            this.profileTextDateOnlain.TabIndex = 7;
            this.profileTextDateOnlain.Text = "Последний вход";
            this.profileTextDateOnlain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoSurname
            // 
            this.profileInfoSurname.AutoSize = true;
            this.profileInfoSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoSurname.Location = new System.Drawing.Point(306, 40);
            this.profileInfoSurname.Name = "profileInfoSurname";
            this.profileInfoSurname.Size = new System.Drawing.Size(426, 78);
            this.profileInfoSurname.TabIndex = 8;
            this.profileInfoSurname.Text = ".";
            this.profileInfoSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoName
            // 
            this.profileInfoName.AutoSize = true;
            this.profileInfoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoName.Location = new System.Drawing.Point(306, 118);
            this.profileInfoName.Name = "profileInfoName";
            this.profileInfoName.Size = new System.Drawing.Size(426, 78);
            this.profileInfoName.TabIndex = 9;
            this.profileInfoName.Text = ".";
            this.profileInfoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoPatronymic
            // 
            this.profileInfoPatronymic.AutoSize = true;
            this.profileInfoPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoPatronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoPatronymic.Location = new System.Drawing.Point(306, 196);
            this.profileInfoPatronymic.Name = "profileInfoPatronymic";
            this.profileInfoPatronymic.Size = new System.Drawing.Size(426, 78);
            this.profileInfoPatronymic.TabIndex = 10;
            this.profileInfoPatronymic.Text = ".";
            this.profileInfoPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoBirthDate
            // 
            this.profileInfoBirthDate.AutoSize = true;
            this.profileInfoBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoBirthDate.Location = new System.Drawing.Point(306, 274);
            this.profileInfoBirthDate.Name = "profileInfoBirthDate";
            this.profileInfoBirthDate.Size = new System.Drawing.Size(426, 78);
            this.profileInfoBirthDate.TabIndex = 11;
            this.profileInfoBirthDate.Text = ".";
            this.profileInfoBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoGender
            // 
            this.profileInfoGender.AutoSize = true;
            this.profileInfoGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoGender.Location = new System.Drawing.Point(306, 352);
            this.profileInfoGender.Name = "profileInfoGender";
            this.profileInfoGender.Size = new System.Drawing.Size(426, 78);
            this.profileInfoGender.TabIndex = 12;
            this.profileInfoGender.Text = ".";
            this.profileInfoGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoEmail
            // 
            this.profileInfoEmail.AutoSize = true;
            this.profileInfoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoEmail.Location = new System.Drawing.Point(306, 430);
            this.profileInfoEmail.Name = "profileInfoEmail";
            this.profileInfoEmail.Size = new System.Drawing.Size(426, 78);
            this.profileInfoEmail.TabIndex = 13;
            this.profileInfoEmail.Text = ".";
            this.profileInfoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoDateReg
            // 
            this.profileInfoDateReg.AutoSize = true;
            this.profileInfoDateReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoDateReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoDateReg.Location = new System.Drawing.Point(306, 508);
            this.profileInfoDateReg.Name = "profileInfoDateReg";
            this.profileInfoDateReg.Size = new System.Drawing.Size(426, 78);
            this.profileInfoDateReg.TabIndex = 14;
            this.profileInfoDateReg.Text = ".";
            this.profileInfoDateReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoDateOnlain
            // 
            this.profileInfoDateOnlain.AutoSize = true;
            this.profileInfoDateOnlain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoDateOnlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoDateOnlain.Location = new System.Drawing.Point(306, 586);
            this.profileInfoDateOnlain.Name = "profileInfoDateOnlain";
            this.profileInfoDateOnlain.Size = new System.Drawing.Size(426, 78);
            this.profileInfoDateOnlain.TabIndex = 15;
            this.profileInfoDateOnlain.Text = ".";
            this.profileInfoDateOnlain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextIsAdmin
            // 
            this.profileTextIsAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextIsAdmin.Location = new System.Drawing.Point(18, 664);
            this.profileTextIsAdmin.Name = "profileTextIsAdmin";
            this.profileTextIsAdmin.Size = new System.Drawing.Size(282, 78);
            this.profileTextIsAdmin.TabIndex = 16;
            this.profileTextIsAdmin.Text = "Админ";
            this.profileTextIsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoIsAdmin
            // 
            this.profileInfoIsAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoIsAdmin.Location = new System.Drawing.Point(306, 664);
            this.profileInfoIsAdmin.Name = "profileInfoIsAdmin";
            this.profileInfoIsAdmin.Size = new System.Drawing.Size(426, 78);
            this.profileInfoIsAdmin.TabIndex = 17;
            this.profileInfoIsAdmin.Text = ".";
            this.profileInfoIsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsEditForm";
            this.Text = "AccountsEditForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MakeAdminBut;
        private System.Windows.Forms.Button DelAdminBut;
        private System.Windows.Forms.Button DeleteUserBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox AthletesComboBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label profileTextSurname;
        private System.Windows.Forms.Label profileTextName;
        private System.Windows.Forms.Label profileTextPatronymic;
        private System.Windows.Forms.Label profileTextBirthDate;
        private System.Windows.Forms.Label profileTextGender;
        private System.Windows.Forms.Label profileTextEmail;
        private System.Windows.Forms.Label profileTextDateReg;
        private System.Windows.Forms.Label profileTextDateOnlain;
        private System.Windows.Forms.Label profileInfoSurname;
        private System.Windows.Forms.Label profileInfoName;
        private System.Windows.Forms.Label profileInfoPatronymic;
        private System.Windows.Forms.Label profileInfoBirthDate;
        private System.Windows.Forms.Label profileInfoGender;
        private System.Windows.Forms.Label profileInfoEmail;
        private System.Windows.Forms.Label profileInfoDateReg;
        private System.Windows.Forms.Label profileInfoDateOnlain;
        private System.Windows.Forms.Label profileTextIsAdmin;
        private System.Windows.Forms.Label profileInfoIsAdmin;
    }
}