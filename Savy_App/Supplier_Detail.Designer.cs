namespace Savy_App
{
    partial class Supplier_Detail
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
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_status = new System.Windows.Forms.Panel();
            this.rb_inactive = new System.Windows.Forms.RadioButton();
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_type = new System.Windows.Forms.Panel();
            this.rb_person = new System.Windows.Forms.RadioButton();
            this.rb_store = new System.Windows.Forms.RadioButton();
            this.txt_contact_person = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_supplier_id = new System.Windows.Forms.Label();
            this.panel_status.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressError)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.Location = new System.Drawing.Point(127, 159);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(381, 23);
            this.txt_phone.TabIndex = 5;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(127, 70);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(381, 23);
            this.txt_address.TabIndex = 3;
            this.txt_address.Validating += new System.ComponentModel.CancelEventHandler(this.addressValidator);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(127, 44);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(381, 23);
            this.txt_name.TabIndex = 2;
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.nameValidator);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(70, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 316;
            this.label7.Text = "Status :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(58, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 311;
            this.label9.Text = "Phone # :";
            // 
            // panel_status
            // 
            this.panel_status.Controls.Add(this.rb_inactive);
            this.panel_status.Controls.Add(this.rb_active);
            this.panel_status.ForeColor = System.Drawing.Color.Black;
            this.panel_status.Location = new System.Drawing.Point(127, 210);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(162, 30);
            this.panel_status.TabIndex = 309;
            this.panel_status.TabStop = true;
            // 
            // rb_inactive
            // 
            this.rb_inactive.AutoSize = true;
            this.rb_inactive.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactive.ForeColor = System.Drawing.Color.Black;
            this.rb_inactive.Location = new System.Drawing.Point(78, 6);
            this.rb_inactive.Name = "rb_inactive";
            this.rb_inactive.Size = new System.Drawing.Size(64, 16);
            this.rb_inactive.TabIndex = 8;
            this.rb_inactive.Text = "Inactive";
            this.rb_inactive.UseVisualStyleBackColor = true;
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.Checked = true;
            this.rb_active.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_active.ForeColor = System.Drawing.Color.Black;
            this.rb_active.Location = new System.Drawing.Point(10, 7);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(54, 16);
            this.rb_active.TabIndex = 7;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "Active";
            this.rb_active.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 296;
            this.label3.Text = "Address* :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 291;
            this.label1.Text = "Supplier Name* :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 287;
            this.label5.Text = "Date :";
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
            this.btn_close.Location = new System.Drawing.Point(559, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_description);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.panel_type);
            this.groupBox2.Controls.Add(this.txt_contact_person);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.panel_status);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_date);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(36, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 279);
            this.groupBox2.TabIndex = 429;
            this.groupBox2.TabStop = false;
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.Location = new System.Drawing.Point(127, 99);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(381, 54);
            this.txt_description.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 324;
            this.label6.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 323;
            this.label4.Text = "Supplier Type :";
            // 
            // panel_type
            // 
            this.panel_type.Controls.Add(this.rb_person);
            this.panel_type.Controls.Add(this.rb_store);
            this.panel_type.ForeColor = System.Drawing.Color.Black;
            this.panel_type.Location = new System.Drawing.Point(127, 244);
            this.panel_type.Name = "panel_type";
            this.panel_type.Size = new System.Drawing.Size(162, 30);
            this.panel_type.TabIndex = 322;
            this.panel_type.TabStop = true;
            // 
            // rb_person
            // 
            this.rb_person.AutoSize = true;
            this.rb_person.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_person.ForeColor = System.Drawing.Color.Black;
            this.rb_person.Location = new System.Drawing.Point(78, 6);
            this.rb_person.Name = "rb_person";
            this.rb_person.Size = new System.Drawing.Size(59, 16);
            this.rb_person.TabIndex = 10;
            this.rb_person.Text = "Person";
            this.rb_person.UseVisualStyleBackColor = true;
            // 
            // rb_store
            // 
            this.rb_store.AutoSize = true;
            this.rb_store.Checked = true;
            this.rb_store.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_store.ForeColor = System.Drawing.Color.Black;
            this.rb_store.Location = new System.Drawing.Point(10, 7);
            this.rb_store.Name = "rb_store";
            this.rb_store.Size = new System.Drawing.Size(50, 16);
            this.rb_store.TabIndex = 9;
            this.rb_store.TabStop = true;
            this.rb_store.Text = "Store";
            this.rb_store.UseVisualStyleBackColor = true;
            // 
            // txt_contact_person
            // 
            this.txt_contact_person.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact_person.ForeColor = System.Drawing.Color.Black;
            this.txt_contact_person.Location = new System.Drawing.Point(127, 184);
            this.txt_contact_person.Multiline = true;
            this.txt_contact_person.Name = "txt_contact_person";
            this.txt_contact_person.Size = new System.Drawing.Size(381, 23);
            this.txt_contact_person.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 320;
            this.label2.Text = "Contact Person :";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "MMMM dd, yyyy";
            this.dtp_date.Enabled = false;
            this.dtp_date.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(127, 18);
            this.dtp_date.MaxDate = new System.DateTime(2025, 3, 10, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(162, 23);
            this.dtp_date.TabIndex = 1;
            this.dtp_date.Value = new System.DateTime(2019, 3, 10, 0, 0, 0, 0);
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
            this.btn_save.Location = new System.Drawing.Point(36, 331);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(526, 39);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // addressError
            // 
            this.addressError.ContainerControl = this;
            // 
            // lbl_supplier_id
            // 
            this.lbl_supplier_id.AutoSize = true;
            this.lbl_supplier_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_supplier_id.Location = new System.Drawing.Point(560, 9);
            this.lbl_supplier_id.Name = "lbl_supplier_id";
            this.lbl_supplier_id.Size = new System.Drawing.Size(0, 14);
            this.lbl_supplier_id.TabIndex = 430;
            this.lbl_supplier_id.Visible = false;
            // 
            // Supplier_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._600x380;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.lbl_supplier_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Supplier_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Detail";
            this.Load += new System.EventHandler(this.Supplier_Detail_Load);
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_type.ResumeLayout(false);
            this.panel_type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_phone;
        public System.Windows.Forms.TextBox txt_address;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel_status;
        public System.Windows.Forms.RadioButton rb_inactive;
        public System.Windows.Forms.RadioButton rb_active;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker dtp_date;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox txt_contact_person;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel_type;
        public System.Windows.Forms.RadioButton rb_person;
        public System.Windows.Forms.RadioButton rb_store;
        public System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider addressError;
        public System.Windows.Forms.Label lbl_supplier_id;
    }
}