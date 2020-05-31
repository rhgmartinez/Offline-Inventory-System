namespace Savy_App
{
    partial class Dashboard
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
            this.dtp_today = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_today
            // 
            this.dtp_today.CustomFormat = "MMMM dd, yyyy";
            this.dtp_today.Enabled = false;
            this.dtp_today.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_today.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_today.Location = new System.Drawing.Point(15, 55);
            this.dtp_today.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_today.MinDate = new System.DateTime(2017, 7, 16, 0, 0, 0, 0);
            this.dtp_today.Name = "dtp_today";
            this.dtp_today.Size = new System.Drawing.Size(254, 24);
            this.dtp_today.TabIndex = 420;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 41);
            this.label9.TabIndex = 421;
            this.label9.Text = "DASHBOARD";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.dtp_today);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(8, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 611);
            this.panel3.TabIndex = 422;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 526);
            this.panel1.TabIndex = 423;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Savy_App.Properties.Resources.ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_today;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel1;
    }
}

