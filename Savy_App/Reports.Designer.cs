namespace Savy_App
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.crv_1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_close = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb_brand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_sdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_edate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_1
            // 
            this.crv_1.ActiveViewIndex = -1;
            this.crv_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_1.DisplayStatusBar = false;
            this.crv_1.Location = new System.Drawing.Point(12, 108);
            this.crv_1.Name = "crv_1";
            this.crv_1.ShowCloseButton = false;
            this.crv_1.ShowCopyButton = false;
            this.crv_1.ShowExportButton = false;
            this.crv_1.ShowGotoPageButton = false;
            this.crv_1.ShowGroupTreeButton = false;
            this.crv_1.ShowLogo = false;
            this.crv_1.ShowPageNavigateButtons = false;
            this.crv_1.ShowParameterPanelButton = false;
            this.crv_1.ShowTextSearchButton = false;
            this.crv_1.ShowZoomButton = false;
            this.crv_1.Size = new System.Drawing.Size(876, 515);
            this.crv_1.TabIndex = 463;
            this.crv_1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_close.BackgroundImage = global::Savy_App.Properties.Resources._200x40_red;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(859, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 465;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(613, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 52);
            this.button3.TabIndex = 466;
            this.button3.Text = "Show Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmb_brand
            // 
            this.cmb_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_brand.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_brand.ForeColor = System.Drawing.Color.Black;
            this.cmb_brand.Items.AddRange(new object[] {
            "Inventory",
            "Invoice",
            "Delivery",
            "Sales"});
            this.cmb_brand.Location = new System.Drawing.Point(133, 50);
            this.cmb_brand.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_brand.Name = "cmb_brand";
            this.cmb_brand.Size = new System.Drawing.Size(475, 24);
            this.cmb_brand.TabIndex = 467;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 468;
            this.label4.Text = "Type of Report:";
            // 
            // dtp_sdate
            // 
            this.dtp_sdate.CustomFormat = "MMMM dd, yyyy";
            this.dtp_sdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_sdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_sdate.Location = new System.Drawing.Point(133, 79);
            this.dtp_sdate.MaxDate = new System.DateTime(2025, 3, 19, 0, 0, 0, 0);
            this.dtp_sdate.Name = "dtp_sdate";
            this.dtp_sdate.Size = new System.Drawing.Size(168, 23);
            this.dtp_sdate.TabIndex = 469;
            this.dtp_sdate.Value = new System.DateTime(2019, 3, 10, 0, 0, 0, 0);
            // 
            // dtp_edate
            // 
            this.dtp_edate.CustomFormat = "MMMM dd, yyyy";
            this.dtp_edate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_edate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_edate.Location = new System.Drawing.Point(440, 79);
            this.dtp_edate.MaxDate = new System.DateTime(2025, 3, 19, 0, 0, 0, 0);
            this.dtp_edate.Name = "dtp_edate";
            this.dtp_edate.Size = new System.Drawing.Size(168, 23);
            this.dtp_edate.TabIndex = 470;
            this.dtp_edate.Value = new System.DateTime(2019, 3, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 471;
            this.label1.Text = "Date From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(368, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 472;
            this.label2.Text = "Date To:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._900x635;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_edate);
            this.Controls.Add(this.dtp_sdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_brand);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.crv_1);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_1;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_brand;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtp_sdate;
        public System.Windows.Forms.DateTimePicker dtp_edate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}