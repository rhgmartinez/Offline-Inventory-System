namespace Savy_App
{
    partial class Product_Detail
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
            this.label8 = new System.Windows.Forms.Label();
            this.rb_inactive = new System.Windows.Forms.RadioButton();
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_brand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cStock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_sku = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 310;
            this.label8.Text = "Description :";
            // 
            // rb_inactive
            // 
            this.rb_inactive.AutoSize = true;
            this.rb_inactive.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactive.ForeColor = System.Drawing.Color.Black;
            this.rb_inactive.Location = new System.Drawing.Point(86, 6);
            this.rb_inactive.Name = "rb_inactive";
            this.rb_inactive.Size = new System.Drawing.Size(36, 16);
            this.rb_inactive.TabIndex = 9;
            this.rb_inactive.Text = "No";
            this.rb_inactive.UseVisualStyleBackColor = true;
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.Checked = true;
            this.rb_active.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_active.ForeColor = System.Drawing.Color.Black;
            this.rb_active.Location = new System.Drawing.Point(11, 7);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(40, 16);
            this.rb_active.TabIndex = 8;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "Yes";
            this.rb_active.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(62, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 311;
            this.label9.Text = "Price* :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rb_inactive);
            this.panel4.Controls.Add(this.rb_active);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(120, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 30);
            this.panel4.TabIndex = 309;
            this.panel4.TabStop = true;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(556, 5);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.Location = new System.Drawing.Point(120, 138);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(381, 23);
            this.txt_description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 296;
            this.label3.Text = "SKU :";
            // 
            // cmb_brand
            // 
            this.cmb_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_brand.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_brand.ForeColor = System.Drawing.Color.Black;
            this.cmb_brand.Location = new System.Drawing.Point(120, 163);
            this.cmb_brand.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_brand.Name = "cmb_brand";
            this.cmb_brand.Size = new System.Drawing.Size(381, 24);
            this.cmb_brand.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 291;
            this.label1.Text = "Product Name* :";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "MMMM dd, yyyy";
            this.dtp_date.Enabled = false;
            this.dtp_date.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(120, 14);
            this.dtp_date.MaxDate = new System.DateTime(2025, 3, 19, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(168, 23);
            this.dtp_date.TabIndex = 0;
            this.dtp_date.Value = new System.DateTime(2019, 3, 10, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_cStock);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmb_supplier);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.txt_sku);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_description);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_brand);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_date);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(38, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 281);
            this.groupBox2.TabIndex = 425;
            this.groupBox2.TabStop = false;
            // 
            // txt_cStock
            // 
            this.txt_cStock.Enabled = false;
            this.txt_cStock.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cStock.ForeColor = System.Drawing.Color.Black;
            this.txt_cStock.Location = new System.Drawing.Point(120, 113);
            this.txt_cStock.Multiline = true;
            this.txt_cStock.Name = "txt_cStock";
            this.txt_cStock.Size = new System.Drawing.Size(381, 23);
            this.txt_cStock.TabIndex = 317;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 318;
            this.label10.Text = "Current Stock :";
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_supplier.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_supplier.ForeColor = System.Drawing.Color.Black;
            this.cmb_supplier.Location = new System.Drawing.Point(120, 189);
            this.cmb_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(381, 24);
            this.cmb_supplier.TabIndex = 7;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.Black;
            this.txt_price.Location = new System.Drawing.Point(120, 88);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(381, 23);
            this.txt_price.TabIndex = 3;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_sku
            // 
            this.txt_sku.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sku.ForeColor = System.Drawing.Color.Black;
            this.txt_sku.Location = new System.Drawing.Point(120, 63);
            this.txt_sku.Multiline = true;
            this.txt_sku.Name = "txt_sku";
            this.txt_sku.Size = new System.Drawing.Size(381, 23);
            this.txt_sku.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(120, 38);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(381, 23);
            this.txt_name.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 316;
            this.label7.Text = "Availability :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(48, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 315;
            this.label6.Text = "Supplier :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 314;
            this.label4.Text = "Brand* :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 287;
            this.label5.Text = "Create Date :";
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
            this.btn_save.Location = new System.Drawing.Point(38, 330);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(526, 40);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_id.Location = new System.Drawing.Point(562, 9);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(0, 14);
            this.lbl_product_id.TabIndex = 426;
            this.lbl_product_id.Visible = false;
            // 
            // Product_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._600x380;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Detail";
            this.Load += new System.EventHandler(this.Product_Detail_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.RadioButton rb_inactive;
        public System.Windows.Forms.RadioButton rb_active;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_brand;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtp_date;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox txt_price;
        public System.Windows.Forms.TextBox txt_sku;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_supplier;
        public System.Windows.Forms.Label lbl_product_id;
        public System.Windows.Forms.TextBox txt_cStock;
        public System.Windows.Forms.Label label10;
    }
}