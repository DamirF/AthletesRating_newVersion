namespace MainApplication.ChildForms.Settings
{
    partial class AccountSettingsForm
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
            this.patronymicChangeTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nameChangeConfirmTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nameChangeBut = new System.Windows.Forms.Button();
            this.firstNameChangeTB = new System.Windows.Forms.TextBox();
            this.lastNameChangeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WeightChangeTB = new System.Windows.Forms.TextBox();
            this.HeightChangeTB = new System.Windows.Forms.TextBox();
            this.ConfirmParametersChange = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ConfirmNewBirthDate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteAccountPassTB = new System.Windows.Forms.TextBox();
            this.deleteAccountBut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newPassConError = new System.Windows.Forms.Label();
            this.newPassError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPassTB = new System.Windows.Forms.TextBox();
            this.passChangeBut = new System.Windows.Forms.Button();
            this.newPassTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPassConfirmTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BirthDateChange = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 40);
            this.panel1.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(260, 35);
            this.Header.TabIndex = 2;
            this.Header.Text = "Настройки аккаунта";
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.Close.Location = new System.Drawing.Point(1139, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.TabIndex = 0;
            this.Close.Text = "<-";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.patronymicChangeTB);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.nameChangeConfirmTB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nameChangeBut);
            this.panel2.Controls.Add(this.firstNameChangeTB);
            this.panel2.Controls.Add(this.lastNameChangeTB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(300, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 422);
            this.panel2.TabIndex = 33;
            // 
            // patronymicChangeTB
            // 
            this.patronymicChangeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patronymicChangeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.patronymicChangeTB.Location = new System.Drawing.Point(13, 207);
            this.patronymicChangeTB.Name = "patronymicChangeTB";
            this.patronymicChangeTB.Size = new System.Drawing.Size(440, 36);
            this.patronymicChangeTB.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(13, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 26);
            this.label16.TabIndex = 15;
            this.label16.Text = "Отчество";
            // 
            // nameChangeConfirmTB
            // 
            this.nameChangeConfirmTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameChangeConfirmTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.nameChangeConfirmTB.Location = new System.Drawing.Point(13, 290);
            this.nameChangeConfirmTB.MaxLength = 10;
            this.nameChangeConfirmTB.Name = "nameChangeConfirmTB";
            this.nameChangeConfirmTB.PasswordChar = '*';
            this.nameChangeConfirmTB.Size = new System.Drawing.Size(440, 36);
            this.nameChangeConfirmTB.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Пароль (для подтверждения)";
            // 
            // nameChangeBut
            // 
            this.nameChangeBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameChangeBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.nameChangeBut.FlatAppearance.BorderSize = 4;
            this.nameChangeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameChangeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameChangeBut.Location = new System.Drawing.Point(13, 360);
            this.nameChangeBut.Name = "nameChangeBut";
            this.nameChangeBut.Size = new System.Drawing.Size(440, 41);
            this.nameChangeBut.TabIndex = 11;
            this.nameChangeBut.Text = "Применить";
            this.nameChangeBut.UseVisualStyleBackColor = true;
            this.nameChangeBut.Click += new System.EventHandler(this.nameChangeBut_Click);
            // 
            // firstNameChangeTB
            // 
            this.firstNameChangeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameChangeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.firstNameChangeTB.Location = new System.Drawing.Point(13, 123);
            this.firstNameChangeTB.Name = "firstNameChangeTB";
            this.firstNameChangeTB.Size = new System.Drawing.Size(440, 36);
            this.firstNameChangeTB.TabIndex = 0;
            // 
            // lastNameChangeTB
            // 
            this.lastNameChangeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameChangeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.lastNameChangeTB.Location = new System.Drawing.Point(13, 46);
            this.lastNameChangeTB.Name = "lastNameChangeTB";
            this.lastNameChangeTB.Size = new System.Drawing.Size(440, 36);
            this.lastNameChangeTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.WeightChangeTB);
            this.panel4.Controls.Add(this.HeightChangeTB);
            this.panel4.Controls.Add(this.ConfirmParametersChange);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Location = new System.Drawing.Point(300, 1089);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 272);
            this.panel4.TabIndex = 39;
            // 
            // WeightChangeTB
            // 
            this.WeightChangeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightChangeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.WeightChangeTB.Location = new System.Drawing.Point(13, 139);
            this.WeightChangeTB.Name = "WeightChangeTB";
            this.WeightChangeTB.Size = new System.Drawing.Size(461, 36);
            this.WeightChangeTB.TabIndex = 4;
            this.WeightChangeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightChangeTB_KeyPress);
            // 
            // HeightChangeTB
            // 
            this.HeightChangeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightChangeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.HeightChangeTB.Location = new System.Drawing.Point(13, 57);
            this.HeightChangeTB.Name = "HeightChangeTB";
            this.HeightChangeTB.Size = new System.Drawing.Size(461, 36);
            this.HeightChangeTB.TabIndex = 3;
            this.HeightChangeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightChangeTB_KeyPress);
            // 
            // ConfirmParametersChange
            // 
            this.ConfirmParametersChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmParametersChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.ConfirmParametersChange.FlatAppearance.BorderSize = 4;
            this.ConfirmParametersChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmParametersChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmParametersChange.Location = new System.Drawing.Point(13, 208);
            this.ConfirmParametersChange.Name = "ConfirmParametersChange";
            this.ConfirmParametersChange.Size = new System.Drawing.Size(461, 41);
            this.ConfirmParametersChange.TabIndex = 2;
            this.ConfirmParametersChange.Text = "Применить";
            this.ConfirmParametersChange.UseVisualStyleBackColor = true;
            this.ConfirmParametersChange.Click += new System.EventHandler(this.ConfirmParametersChange_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 30);
            this.label23.TabIndex = 1;
            this.label23.Text = "Вес";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 30);
            this.label22.TabIndex = 0;
            this.label22.Text = "Рост";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.ConfirmNewBirthDate);
            this.panel5.Location = new System.Drawing.Point(300, 13415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 131);
            this.panel5.TabIndex = 41;
            // 
            // ConfirmNewBirthDate
            // 
            this.ConfirmNewBirthDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.ConfirmNewBirthDate.FlatAppearance.BorderSize = 4;
            this.ConfirmNewBirthDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmNewBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmNewBirthDate.Location = new System.Drawing.Point(13, 69);
            this.ConfirmNewBirthDate.Name = "ConfirmNewBirthDate";
            this.ConfirmNewBirthDate.Size = new System.Drawing.Size(545, 41);
            this.ConfirmNewBirthDate.TabIndex = 1;
            this.ConfirmNewBirthDate.Text = "Применить";
            this.ConfirmNewBirthDate.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.deleteAccountPassTB);
            this.panel6.Controls.Add(this.deleteAccountBut);
            this.panel6.Location = new System.Drawing.Point(300, 1702);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(495, 198);
            this.panel6.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(13, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 26);
            this.label14.TabIndex = 3;
            this.label14.Text = "Введите пароль:";
            // 
            // deleteAccountPassTB
            // 
            this.deleteAccountPassTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountPassTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.deleteAccountPassTB.Location = new System.Drawing.Point(13, 66);
            this.deleteAccountPassTB.MaxLength = 10;
            this.deleteAccountPassTB.Name = "deleteAccountPassTB";
            this.deleteAccountPassTB.PasswordChar = '*';
            this.deleteAccountPassTB.Size = new System.Drawing.Size(461, 36);
            this.deleteAccountPassTB.TabIndex = 2;
            // 
            // deleteAccountBut
            // 
            this.deleteAccountBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.deleteAccountBut.FlatAppearance.BorderSize = 4;
            this.deleteAccountBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountBut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAccountBut.Location = new System.Drawing.Point(13, 132);
            this.deleteAccountBut.Name = "deleteAccountBut";
            this.deleteAccountBut.Size = new System.Drawing.Size(461, 41);
            this.deleteAccountBut.TabIndex = 1;
            this.deleteAccountBut.Text = "Удалить";
            this.deleteAccountBut.UseVisualStyleBackColor = true;
            this.deleteAccountBut.Click += new System.EventHandler(this.deleteAccountBut_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.newPassConError);
            this.panel3.Controls.Add(this.newPassError);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.oldPassTB);
            this.panel3.Controls.Add(this.passChangeBut);
            this.panel3.Controls.Add(this.newPassTB);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.newPassConfirmTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(300, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 352);
            this.panel3.TabIndex = 45;
            // 
            // newPassConError
            // 
            this.newPassConError.AutoSize = true;
            this.newPassConError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassConError.ForeColor = System.Drawing.Color.Red;
            this.newPassConError.Location = new System.Drawing.Point(13, 260);
            this.newPassConError.Name = "newPassConError";
            this.newPassConError.Size = new System.Drawing.Size(54, 17);
            this.newPassConError.TabIndex = 14;
            this.newPassConError.Text = "label26";
            // 
            // newPassError
            // 
            this.newPassError.AutoSize = true;
            this.newPassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassError.ForeColor = System.Drawing.Color.Red;
            this.newPassError.Location = new System.Drawing.Point(13, 166);
            this.newPassError.Name = "newPassError";
            this.newPassError.Size = new System.Drawing.Size(54, 17);
            this.newPassError.TabIndex = 13;
            this.newPassError.Text = "label25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Старый пароль";
            // 
            // oldPassTB
            // 
            this.oldPassTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPassTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.oldPassTB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPassTB.Location = new System.Drawing.Point(13, 53);
            this.oldPassTB.MaxLength = 10;
            this.oldPassTB.Name = "oldPassTB";
            this.oldPassTB.PasswordChar = '*';
            this.oldPassTB.Size = new System.Drawing.Size(461, 36);
            this.oldPassTB.TabIndex = 3;
            // 
            // passChangeBut
            // 
            this.passChangeBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passChangeBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.passChangeBut.FlatAppearance.BorderSize = 4;
            this.passChangeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passChangeBut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passChangeBut.Location = new System.Drawing.Point(13, 287);
            this.passChangeBut.Name = "passChangeBut";
            this.passChangeBut.Size = new System.Drawing.Size(461, 41);
            this.passChangeBut.TabIndex = 12;
            this.passChangeBut.Text = "Сохранить";
            this.passChangeBut.UseVisualStyleBackColor = true;
            this.passChangeBut.Click += new System.EventHandler(this.passChangeBut_Click);
            // 
            // newPassTB
            // 
            this.newPassTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPassTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.newPassTB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassTB.Location = new System.Drawing.Point(13, 127);
            this.newPassTB.MaxLength = 10;
            this.newPassTB.Name = "newPassTB";
            this.newPassTB.PasswordChar = '*';
            this.newPassTB.Size = new System.Drawing.Size(461, 36);
            this.newPassTB.TabIndex = 4;
            this.newPassTB.TextChanged += new System.EventHandler(this.newPassTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Подтвердите новый пароль";
            // 
            // newPassConfirmTB
            // 
            this.newPassConfirmTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPassConfirmTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.newPassConfirmTB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassConfirmTB.Location = new System.Drawing.Point(13, 221);
            this.newPassConfirmTB.MaxLength = 10;
            this.newPassConfirmTB.Name = "newPassConfirmTB";
            this.newPassConfirmTB.PasswordChar = '*';
            this.newPassConfirmTB.Size = new System.Drawing.Size(461, 36);
            this.newPassConfirmTB.TabIndex = 5;
            this.newPassConfirmTB.TextChanged += new System.EventHandler(this.newPassConfirmTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Новый пароль";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.BirthDateChange);
            this.panel7.Location = new System.Drawing.Point(300, 1470);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(495, 126);
            this.panel7.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(206)))), ((int)(((byte)(228)))));
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(461, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BirthDateChange
            // 
            this.BirthDateChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BirthDateChange.Location = new System.Drawing.Point(13, 22);
            this.BirthDateChange.Name = "BirthDateChange";
            this.BirthDateChange.Size = new System.Drawing.Size(461, 32);
            this.BirthDateChange.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(300, 1631);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(495, 65);
            this.panel8.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(495, 65);
            this.label15.TabIndex = 45;
            this.label15.Text = "Удаление учетной записи";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(300, 47);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(476, 65);
            this.panel9.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(476, 65);
            this.label7.TabIndex = 35;
            this.label7.Text = "Смена имени";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(301, 560);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(494, 65);
            this.panel10.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(494, 65);
            this.label8.TabIndex = 47;
            this.label8.Text = "Смена пароля";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.label21);
            this.panel11.Location = new System.Drawing.Point(300, 1018);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(495, 65);
            this.panel11.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(495, 65);
            this.label21.TabIndex = 41;
            this.label21.Text = "Изменить характеристики";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.label24);
            this.panel12.Location = new System.Drawing.Point(300, 1399);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(495, 65);
            this.panel12.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(495, 65);
            this.label24.TabIndex = 43;
            this.label24.Text = "Изменить дату рождения";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 1055);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountSettingsForm";
            this.Text = "AccountSettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox patronymicChangeTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nameChangeConfirmTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button nameChangeBut;
        private System.Windows.Forms.TextBox firstNameChangeTB;
        private System.Windows.Forms.TextBox lastNameChangeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox WeightChangeTB;
        private System.Windows.Forms.TextBox HeightChangeTB;
        private System.Windows.Forms.Button ConfirmParametersChange;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ConfirmNewBirthDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox deleteAccountPassTB;
        private System.Windows.Forms.Button deleteAccountBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label newPassConError;
        private System.Windows.Forms.Label newPassError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPassTB;
        private System.Windows.Forms.Button passChangeBut;
        private System.Windows.Forms.TextBox newPassTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPassConfirmTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker BirthDateChange;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label24;
    }
}