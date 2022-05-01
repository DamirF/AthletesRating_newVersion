namespace MainApplication.TestElement
{
    partial class Form2
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
            this.EventCard = new System.Windows.Forms.Panel();
            this.InfPanel = new System.Windows.Forms.Panel();
            this.EventDate = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.Label();
            this.EvenInfo = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.Label();
            this.EventCard.SuspendLayout();
            this.InfPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventCard
            // 
            this.EventCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EventCard.Controls.Add(this.InfPanel);
            this.EventCard.Controls.Add(this.EvenInfo);
            this.EventCard.Controls.Add(this.EventName);
            this.EventCard.Location = new System.Drawing.Point(59, 36);
            this.EventCard.Name = "EventCard";
            this.EventCard.Size = new System.Drawing.Size(670, 100);
            this.EventCard.TabIndex = 0;
            // 
            // InfPanel
            // 
            this.InfPanel.Controls.Add(this.EventDate);
            this.InfPanel.Controls.Add(this.Place);
            this.InfPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfPanel.Location = new System.Drawing.Point(536, 0);
            this.InfPanel.Name = "InfPanel";
            this.InfPanel.Size = new System.Drawing.Size(130, 96);
            this.InfPanel.TabIndex = 2;
            // 
            // EventDate
            // 
            this.EventDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EventDate.Location = new System.Drawing.Point(11, 62);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(108, 25);
            this.EventDate.TabIndex = 1;
            this.EventDate.Text = "12.12.2012";
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Place.Location = new System.Drawing.Point(60, 0);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(66, 47);
            this.Place.TabIndex = 0;
            this.Place.Text = "12";
            // 
            // EvenInfo
            // 
            this.EvenInfo.AutoSize = true;
            this.EvenInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EvenInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EvenInfo.Location = new System.Drawing.Point(12, 57);
            this.EvenInfo.Name = "EvenInfo";
            this.EvenInfo.Size = new System.Drawing.Size(95, 30);
            this.EvenInfo.TabIndex = 1;
            this.EvenInfo.Text = "Меж/нар";
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EventName.Location = new System.Drawing.Point(12, 9);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(465, 37);
            this.EventName.TabIndex = 0;
            this.EventName.Text = "PGL Major Antwerp 2022: European";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventCard);
            this.Name = "Form2";
            this.Text = "Form2";
            this.EventCard.ResumeLayout(false);
            this.EventCard.PerformLayout();
            this.InfPanel.ResumeLayout(false);
            this.InfPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EventCard;
        private System.Windows.Forms.Panel InfPanel;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.Label EvenInfo;
        private System.Windows.Forms.Label EventName;
        private System.Windows.Forms.Label EventDate;
    }
}