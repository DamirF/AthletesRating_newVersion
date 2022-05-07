namespace MainApplication.ChildForms.Search
{
    partial class AthletesSearchForm
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
            this.Header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nationalityCB = new System.Windows.Forms.ComboBox();
            this.sportTypeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtn = new yt_DesignUI.yt_Button();
            this.Content = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoScroll = true;
            this.Header.BackColor = System.Drawing.Color.Black;
            this.Header.Controls.Add(this.panel2);
            this.Header.Controls.Add(this.panel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Header.Location = new System.Drawing.Point(0, 726);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1500, 120);
            this.Header.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nationalityCB);
            this.panel2.Controls.Add(this.sportTypeCB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fullNameTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 120);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(867, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Гражданство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(474, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вид спорта";
            // 
            // nationalityCB
            // 
            this.nationalityCB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationalityCB.FormattingEnabled = true;
            this.nationalityCB.Location = new System.Drawing.Point(867, 49);
            this.nationalityCB.Name = "nationalityCB";
            this.nationalityCB.Size = new System.Drawing.Size(498, 43);
            this.nationalityCB.TabIndex = 12;
            this.nationalityCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nationalityCB_KeyPress);
            // 
            // sportTypeCB
            // 
            this.sportTypeCB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sportTypeCB.FormattingEnabled = true;
            this.sportTypeCB.Location = new System.Drawing.Point(474, 49);
            this.sportTypeCB.Name = "sportTypeCB";
            this.sportTypeCB.Size = new System.Drawing.Size(350, 43);
            this.sportTypeCB.TabIndex = 11;
            this.sportTypeCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sportTypeCB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "ФИО";
            // 
            // fullNameTB
            // 
            this.fullNameTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameTB.Location = new System.Drawing.Point(29, 49);
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(400, 41);
            this.fullNameTB.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1350, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 120);
            this.panel1.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Red;
            this.SearchBtn.BackColorAdditional = System.Drawing.Color.Gray;
            this.SearchBtn.BackColorGradientEnabled = false;
            this.SearchBtn.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SearchBtn.BorderColor = System.Drawing.Color.Black;
            this.SearchBtn.BorderColorEnabled = false;
            this.SearchBtn.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SearchBtn.BorderColorOnHoverEnabled = false;
            this.SearchBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(13, 41);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.RippleColor = System.Drawing.Color.Black;
            this.SearchBtn.RoundingEnable = true;
            this.SearchBtn.Size = new System.Drawing.Size(125, 38);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.TextHover = null;
            this.SearchBtn.UseDownPressEffectOnClick = false;
            this.SearchBtn.UseRippleEffect = true;
            this.SearchBtn.UseZoomEffectOnHover = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Content
            // 
            this.Content.AutoScroll = true;
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(216)))), ((int)(((byte)(130)))));
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.ForeColor = System.Drawing.Color.Black;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1500, 726);
            this.Content.TabIndex = 2;
            // 
            // AthletesSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1500, 846);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AthletesSearchForm";
            this.Text = "AthletesSearchForm";
            this.Header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nationalityCB;
        private System.Windows.Forms.ComboBox sportTypeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Content;
        private yt_DesignUI.yt_Button SearchBtn;
    }
}