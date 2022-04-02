namespace MainApplication.ChildForms.Profile
{
    partial class ProfileForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.profileTextSurname = new System.Windows.Forms.Label();
            this.profileTextName = new System.Windows.Forms.Label();
            this.profileTextPatronymic = new System.Windows.Forms.Label();
            this.profileTextBirthDate = new System.Windows.Forms.Label();
            this.profileTextGender = new System.Windows.Forms.Label();
            this.profileTextEmail = new System.Windows.Forms.Label();
            this.profileTextHeight = new System.Windows.Forms.Label();
            this.profileTextWeight = new System.Windows.Forms.Label();
            this.profileInfoSurname = new System.Windows.Forms.Label();
            this.profileInfoName = new System.Windows.Forms.Label();
            this.profileInfoPatronymic = new System.Windows.Forms.Label();
            this.profileInfoBirthDate = new System.Windows.Forms.Label();
            this.profileInfoGender = new System.Windows.Forms.Label();
            this.profileInfoEmail = new System.Windows.Forms.Label();
            this.profileInfoHeight = new System.Windows.Forms.Label();
            this.profileInfoWeight = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(192, 35);
            this.Header.TabIndex = 2;
            this.Header.Text = "Мой Профиль";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.profileTextSurname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.profileTextName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.profileTextPatronymic, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.profileTextBirthDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.profileTextGender, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.profileTextEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.profileTextHeight, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.profileTextWeight, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoSurname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoPatronymic, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoBirthDate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoGender, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoEmail, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoHeight, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.profileInfoWeight, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 860);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // profileTextSurname
            // 
            this.profileTextSurname.AutoSize = true;
            this.profileTextSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextSurname.Location = new System.Drawing.Point(153, 40);
            this.profileTextSurname.Name = "profileTextSurname";
            this.profileTextSurname.Size = new System.Drawing.Size(354, 97);
            this.profileTextSurname.TabIndex = 0;
            this.profileTextSurname.Text = "Фамилия:";
            this.profileTextSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextName
            // 
            this.profileTextName.AutoSize = true;
            this.profileTextName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextName.Location = new System.Drawing.Point(153, 137);
            this.profileTextName.Name = "profileTextName";
            this.profileTextName.Size = new System.Drawing.Size(354, 97);
            this.profileTextName.TabIndex = 1;
            this.profileTextName.Text = "Имя:";
            this.profileTextName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextPatronymic
            // 
            this.profileTextPatronymic.AutoSize = true;
            this.profileTextPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextPatronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextPatronymic.Location = new System.Drawing.Point(153, 234);
            this.profileTextPatronymic.Name = "profileTextPatronymic";
            this.profileTextPatronymic.Size = new System.Drawing.Size(354, 97);
            this.profileTextPatronymic.TabIndex = 2;
            this.profileTextPatronymic.Text = "Отчество:";
            this.profileTextPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextBirthDate
            // 
            this.profileTextBirthDate.AutoSize = true;
            this.profileTextBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextBirthDate.Location = new System.Drawing.Point(153, 331);
            this.profileTextBirthDate.Name = "profileTextBirthDate";
            this.profileTextBirthDate.Size = new System.Drawing.Size(354, 97);
            this.profileTextBirthDate.TabIndex = 3;
            this.profileTextBirthDate.Text = "Дата рождения:";
            this.profileTextBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextGender
            // 
            this.profileTextGender.AutoSize = true;
            this.profileTextGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextGender.Location = new System.Drawing.Point(153, 428);
            this.profileTextGender.Name = "profileTextGender";
            this.profileTextGender.Size = new System.Drawing.Size(354, 97);
            this.profileTextGender.TabIndex = 4;
            this.profileTextGender.Text = "Пол:";
            this.profileTextGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextEmail
            // 
            this.profileTextEmail.AutoSize = true;
            this.profileTextEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextEmail.Location = new System.Drawing.Point(153, 525);
            this.profileTextEmail.Name = "profileTextEmail";
            this.profileTextEmail.Size = new System.Drawing.Size(354, 97);
            this.profileTextEmail.TabIndex = 5;
            this.profileTextEmail.Text = "E-mail:";
            this.profileTextEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextHeight
            // 
            this.profileTextHeight.AutoSize = true;
            this.profileTextHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextHeight.Location = new System.Drawing.Point(153, 622);
            this.profileTextHeight.Name = "profileTextHeight";
            this.profileTextHeight.Size = new System.Drawing.Size(354, 97);
            this.profileTextHeight.TabIndex = 6;
            this.profileTextHeight.Text = "Рост:";
            this.profileTextHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTextWeight
            // 
            this.profileTextWeight.AutoSize = true;
            this.profileTextWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileTextWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTextWeight.Location = new System.Drawing.Point(153, 719);
            this.profileTextWeight.Name = "profileTextWeight";
            this.profileTextWeight.Size = new System.Drawing.Size(354, 97);
            this.profileTextWeight.TabIndex = 7;
            this.profileTextWeight.Text = "Вес:";
            this.profileTextWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoSurname
            // 
            this.profileInfoSurname.AutoSize = true;
            this.profileInfoSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoSurname.Location = new System.Drawing.Point(513, 40);
            this.profileInfoSurname.Name = "profileInfoSurname";
            this.profileInfoSurname.Size = new System.Drawing.Size(534, 97);
            this.profileInfoSurname.TabIndex = 8;
            this.profileInfoSurname.Text = "label9";
            this.profileInfoSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoName
            // 
            this.profileInfoName.AutoSize = true;
            this.profileInfoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoName.Location = new System.Drawing.Point(513, 137);
            this.profileInfoName.Name = "profileInfoName";
            this.profileInfoName.Size = new System.Drawing.Size(534, 97);
            this.profileInfoName.TabIndex = 9;
            this.profileInfoName.Text = "label10";
            this.profileInfoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoPatronymic
            // 
            this.profileInfoPatronymic.AutoSize = true;
            this.profileInfoPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoPatronymic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoPatronymic.Location = new System.Drawing.Point(513, 234);
            this.profileInfoPatronymic.Name = "profileInfoPatronymic";
            this.profileInfoPatronymic.Size = new System.Drawing.Size(534, 97);
            this.profileInfoPatronymic.TabIndex = 10;
            this.profileInfoPatronymic.Text = "label11";
            this.profileInfoPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoBirthDate
            // 
            this.profileInfoBirthDate.AutoSize = true;
            this.profileInfoBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoBirthDate.Location = new System.Drawing.Point(513, 331);
            this.profileInfoBirthDate.Name = "profileInfoBirthDate";
            this.profileInfoBirthDate.Size = new System.Drawing.Size(534, 97);
            this.profileInfoBirthDate.TabIndex = 11;
            this.profileInfoBirthDate.Text = "label12";
            this.profileInfoBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoGender
            // 
            this.profileInfoGender.AutoSize = true;
            this.profileInfoGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoGender.Location = new System.Drawing.Point(513, 428);
            this.profileInfoGender.Name = "profileInfoGender";
            this.profileInfoGender.Size = new System.Drawing.Size(534, 97);
            this.profileInfoGender.TabIndex = 12;
            this.profileInfoGender.Text = "label13";
            this.profileInfoGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoEmail
            // 
            this.profileInfoEmail.AutoSize = true;
            this.profileInfoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoEmail.Location = new System.Drawing.Point(513, 525);
            this.profileInfoEmail.Name = "profileInfoEmail";
            this.profileInfoEmail.Size = new System.Drawing.Size(534, 97);
            this.profileInfoEmail.TabIndex = 13;
            this.profileInfoEmail.Text = "label14";
            this.profileInfoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoHeight
            // 
            this.profileInfoHeight.AutoSize = true;
            this.profileInfoHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoHeight.Location = new System.Drawing.Point(513, 622);
            this.profileInfoHeight.Name = "profileInfoHeight";
            this.profileInfoHeight.Size = new System.Drawing.Size(534, 97);
            this.profileInfoHeight.TabIndex = 14;
            this.profileInfoHeight.Text = "label15";
            this.profileInfoHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileInfoWeight
            // 
            this.profileInfoWeight.AutoSize = true;
            this.profileInfoWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileInfoWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileInfoWeight.Location = new System.Drawing.Point(513, 719);
            this.profileInfoWeight.Name = "profileInfoWeight";
            this.profileInfoWeight.Size = new System.Drawing.Size(534, 97);
            this.profileInfoWeight.TabIndex = 15;
            this.profileInfoWeight.Text = "label16";
            this.profileInfoWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label profileTextSurname;
        private System.Windows.Forms.Label profileTextName;
        private System.Windows.Forms.Label profileTextPatronymic;
        private System.Windows.Forms.Label profileTextBirthDate;
        private System.Windows.Forms.Label profileTextGender;
        private System.Windows.Forms.Label profileTextEmail;
        private System.Windows.Forms.Label profileTextHeight;
        private System.Windows.Forms.Label profileTextWeight;
        private System.Windows.Forms.Label profileInfoSurname;
        private System.Windows.Forms.Label profileInfoName;
        private System.Windows.Forms.Label profileInfoPatronymic;
        private System.Windows.Forms.Label profileInfoBirthDate;
        private System.Windows.Forms.Label profileInfoGender;
        private System.Windows.Forms.Label profileInfoEmail;
        private System.Windows.Forms.Label profileInfoHeight;
        private System.Windows.Forms.Label profileInfoWeight;
    }
}