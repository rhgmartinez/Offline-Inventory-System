namespace Savy_App
{
    partial class Brand_Details
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
            this.components = new System.ComponentModel.Container();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_status = new System.Windows.Forms.Panel();
            this.rb_inactive = new System.Windows.Forms.RadioButton();
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_brand_id = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.BackgroundImage = global::Savy_App.Properties.Resources._200x40_red;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(560, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_description);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.panel_status);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtp_date);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(39, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 274);
            this.groupBox2.TabIndex = 420;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.Location = new System.Drawing.Point(116, 76);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(381, 154);
            this.txt_description.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(116, 49);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(381, 23);
            this.txt_name.TabIndex = 2;
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.brands_validation);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 311;
            this.label9.Text = "Brand Name* :";
            // 
            // panel_status
            // 
            this.panel_status.Controls.Add(this.rb_inactive);
            this.panel_status.Controls.Add(this.rb_active);
            this.panel_status.ForeColor = System.Drawing.Color.Black;
            this.panel_status.Location = new System.Drawing.Point(115, 236);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(163, 30);
            this.panel_status.TabIndex = 309;
            this.panel_status.TabStop = true;
            // 
            // rb_inactive
            // 
            this.rb_inactive.AutoSize = true;
            this.rb_inactive.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactive.ForeColor = System.Drawing.Color.Black;
            this.rb_inactive.Location = new System.Drawing.Point(72, 7);
            this.rb_inactive.Name = "rb_inactive";
            this.rb_inactive.Size = new System.Drawing.Size(64, 16);
            this.rb_inactive.TabIndex = 5;
            this.rb_inactive.Text = "Inactive";
            this.rb_inactive.UseVisualStyleBackColor = true;
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.Checked = true;
            this.rb_active.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_active.ForeColor = System.Drawing.Color.Black;
            this.rb_active.Location = new System.Drawing.Point(8, 7);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(54, 16);
            this.rb_active.TabIndex = 4;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "Active";
            this.rb_active.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 308;
            this.label2.Text = "Description :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(58, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 310;
            this.label8.Text = "Status :";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "MMMM dd, yyyy";
            this.dtp_date.Enabled = false;
            this.dtp_date.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(116, 20);
            this.dtp_date.MaxDate = new System.DateTime(2025, 3, 10, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(163, 23);
            this.dtp_date.TabIndex = 1;
            this.dtp_date.Value = new System.DateTime(2019, 3, 10, 12, 41, 42, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(68, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 287;
            this.label5.Text = "Date :";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.BackgroundImage = global::Savy_App.Properties.Resources._200x40_green;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(39, 329);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(526, 39);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_brand_id
            // 
            this.lbl_brand_id.AutoSize = true;
            this.lbl_brand_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_brand_id.Location = new System.Drawing.Point(562, 9);
            this.lbl_brand_id.Name = "lbl_brand_id";
            this.lbl_brand_id.Size = new System.Drawing.Size(0, 14);
            this.lbl_brand_id.TabIndex = 421;
            this.lbl_brand_id.Visible = false;
            // 
            // Brand_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._600x380;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.lbl_brand_id);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Brand_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brand_Details";
            this.Load += new System.EventHandler(this.Brand_Details_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker dtp_date;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel_status;
        public System.Windows.Forms.RadioButton rb_inactive;
        public System.Windows.Forms.RadioButton rb_active;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label lbl_brand_id;
    }
}