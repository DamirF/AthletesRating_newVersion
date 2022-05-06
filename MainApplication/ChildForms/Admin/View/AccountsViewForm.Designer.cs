namespace MainApplication.ChildForms.Admin.View
{
    partial class AccountsViewForm
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
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.dataGridAccounts = new System.Windows.Forms.DataGridView();
            this.panelAthletes = new System.Windows.Forms.Panel();
            this.dataGridAthletes = new System.Windows.Forms.DataGridView();
            this.panelAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).BeginInit();
            this.panelAthletes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAthletes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccounts
            // 
            this.panelAccounts.Controls.Add(this.dataGridAccounts);
            this.panelAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccounts.Location = new System.Drawing.Point(0, 0);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Size = new System.Drawing.Size(600, 846);
            this.panelAccounts.TabIndex = 0;
            // 
            // dataGridAccounts
            // 
            this.dataGridAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(240)))), ((int)(((byte)(168)))));
            this.dataGridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccounts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridAccounts.Location = new System.Drawing.Point(0, 0);
            this.dataGridAccounts.Name = "dataGridAccounts";
            this.dataGridAccounts.RowHeadersWidth = 51;
            this.dataGridAccounts.RowTemplate.Height = 29;
            this.dataGridAccounts.Size = new System.Drawing.Size(600, 846);
            this.dataGridAccounts.TabIndex = 0;
            // 
            // panelAthletes
            // 
            this.panelAthletes.Controls.Add(this.dataGridAthletes);
            this.panelAthletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAthletes.Location = new System.Drawing.Point(600, 0);
            this.panelAthletes.Name = "panelAthletes";
            this.panelAthletes.Size = new System.Drawing.Size(900, 846);
            this.panelAthletes.TabIndex = 1;
            // 
            // dataGridAthletes
            // 
            this.dataGridAthletes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(240)))), ((int)(((byte)(168)))));
            this.dataGridAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAthletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAthletes.Location = new System.Drawing.Point(0, 0);
            this.dataGridAthletes.Name = "dataGridAthletes";
            this.dataGridAthletes.RowHeadersWidth = 51;
            this.dataGridAthletes.RowTemplate.Height = 29;
            this.dataGridAthletes.Size = new System.Drawing.Size(900, 846);
            this.dataGridAthletes.TabIndex = 0;
            // 
            // AccountsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(240)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1500, 846);
            this.Controls.Add(this.panelAthletes);
            this.Controls.Add(this.panelAccounts);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsViewForm";
            this.Text = "AccountsViewForm";
            this.panelAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).EndInit();
            this.panelAthletes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAthletes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccounts;
        private System.Windows.Forms.Panel panelAthletes;
        private System.Windows.Forms.DataGridView dataGridAccounts;
        private System.Windows.Forms.DataGridView dataGridAthletes;
    }
}