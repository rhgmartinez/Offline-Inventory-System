namespace Savy_App
{
    partial class Brand_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Name_ = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_chart = new System.Windows.Forms.DataGridView();
            this.Transaction = new System.Windows.Forms.Label();
            this.lbl_b_description = new System.Windows.Forms.Label();
            this.lbl_brand_description = new System.Windows.Forms.Label();
            this.lbl_brand_name = new System.Windows.Forms.Label();
            this.lbl_brand_status = new System.Windows.Forms.Label();
            this.lbl_b_status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_brand_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_num_items = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.BackColor = System.Drawing.Color.Transparent;
            this.Name_.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_.Location = new System.Drawing.Point(70, 66);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(0, 19);
            this.Name_.TabIndex = 399;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::Savy_App.Properties.Resources._200x40_red;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(855, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 413;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = global::Savy_App.Properties.Resources._200x40_red;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(598, 584);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(290, 40);
            this.btn_delete.TabIndex = 426;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = global::Savy_App.Properties.Resources._200x40_yellow;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(304, 584);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(290, 40);
            this.btn_edit.TabIndex = 424;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_add.BackgroundImage = global::Savy_App.Properties.Resources._200x40_green;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(10, 584);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(290, 40);
            this.btn_add.TabIndex = 425;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_chart
            // 
            this.dgv_chart.AllowUserToAddRows = false;
            this.dgv_chart.AllowUserToDeleteRows = false;
            this.dgv_chart.AllowUserToOrderColumns = true;
            this.dgv_chart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chart.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_chart.Location = new System.Drawing.Point(13, 95);
            this.dgv_chart.Name = "dgv_chart";
            this.dgv_chart.ReadOnly = true;
            this.dgv_chart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_chart.Size = new System.Drawing.Size(578, 446);
            this.dgv_chart.TabIndex = 457;
            this.dgv_chart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chart_CellClick);
            // 
            // Transaction
            // 
            this.Transaction.AutoSize = true;
            this.Transaction.BackColor = System.Drawing.Color.Transparent;
            this.Transaction.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.ForeColor = System.Drawing.Color.White;
            this.Transaction.Location = new System.Drawing.Point(13, 9);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(143, 22);
            this.Transaction.TabIndex = 358;
            this.Transaction.Text = "Manage Brands";
            // 
            // lbl_b_description
            // 
            this.lbl_b_description.AutoSize = true;
            this.lbl_b_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_b_description.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b_description.Location = new System.Drawing.Point(104, 56);
            this.lbl_b_description.Name = "lbl_b_description";
            this.lbl_b_description.Size = new System.Drawing.Size(54, 17);
            this.lbl_b_description.TabIndex = 374;
            this.lbl_b_description.Text = "Section";
            // 
            // lbl_brand_description
            // 
            this.lbl_brand_description.AutoSize = true;
            this.lbl_brand_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brand_description.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_description.Location = new System.Drawing.Point(13, 56);
            this.lbl_brand_description.Name = "lbl_brand_description";
            this.lbl_brand_description.Size = new System.Drawing.Size(85, 17);
            this.lbl_brand_description.TabIndex = 370;
            this.lbl_brand_description.Text = "Description:";
            // 
            // lbl_brand_name
            // 
            this.lbl_brand_name.AutoSize = true;
            this.lbl_brand_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brand_name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_name.ForeColor = System.Drawing.Color.White;
            this.lbl_brand_name.Location = new System.Drawing.Point(16, 9);
            this.lbl_brand_name.Name = "lbl_brand_name";
            this.lbl_brand_name.Size = new System.Drawing.Size(117, 22);
            this.lbl_brand_name.TabIndex = 348;
            this.lbl_brand_name.Text = "Brand Name";
            // 
            // lbl_brand_status
            // 
            this.lbl_brand_status.AutoSize = true;
            this.lbl_brand_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brand_status.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_status.Location = new System.Drawing.Point(13, 79);
            this.lbl_brand_status.Name = "lbl_brand_status";
            this.lbl_brand_status.Size = new System.Drawing.Size(50, 17);
            this.lbl_brand_status.TabIndex = 369;
            this.lbl_brand_status.Text = "Status:";
            // 
            // lbl_b_status
            // 
            this.lbl_b_status.AutoSize = true;
            this.lbl_b_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_b_status.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b_status.Location = new System.Drawing.Point(104, 79);
            this.lbl_b_status.Name = "lbl_b_status";
            this.lbl_b_status.Size = new System.Drawing.Size(54, 17);
            this.lbl_b_status.TabIndex = 373;
            this.lbl_b_status.Text = "Section";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_brand_id);
            this.panel1.Controls.Add(this.lbl_brand_name);
            this.panel1.Controls.Add(this.lbl_b_status);
            this.panel1.Controls.Add(this.lbl_b_description);
            this.panel1.Controls.Add(this.lbl_brand_status);
            this.panel1.Controls.Add(this.lbl_brand_description);
            this.panel1.Location = new System.Drawing.Point(598, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 530);
            this.panel1.TabIndex = 458;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_num_items);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Transaction);
            this.panel2.Location = new System.Drawing.Point(10, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 529);
            this.panel2.TabIndex = 459;
            // 
            // lbl_brand_id
            // 
            this.lbl_brand_id.AutoSize = true;
            this.lbl_brand_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_brand_id.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand_id.Location = new System.Drawing.Point(264, 503);
            this.lbl_brand_id.Name = "lbl_brand_id";
            this.lbl_brand_id.Size = new System.Drawing.Size(23, 17);
            this.lbl_brand_id.TabIndex = 375;
            this.lbl_brand_id.Text = "ID";
            this.lbl_brand_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 376;
            this.label1.Text = "Total Brands:";
            // 
            // lbl_num_items
            // 
            this.lbl_num_items.AutoSize = true;
            this.lbl_num_items.BackColor = System.Drawing.Color.Transparent;
            this.lbl_num_items.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_items.Location = new System.Drawing.Point(111, 503);
            this.lbl_num_items.Name = "lbl_num_items";
            this.lbl_num_items.Size = new System.Drawing.Size(112, 17);
            this.lbl_num_items.TabIndex = 376;
            this.lbl_num_items.Text = "Number of items";
            // 
            // Brand_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._900x635;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_chart);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.Name_);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Brand_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.Brand_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Name_;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_chart;
        public System.Windows.Forms.Label Transaction;
        public System.Windows.Forms.Label lbl_b_description;
        public System.Windows.Forms.Label lbl_brand_description;
        public System.Windows.Forms.Label lbl_brand_name;
        public System.Windows.Forms.Label lbl_brand_status;
        public System.Windows.Forms.Label lbl_b_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_brand_id;
        public System.Windows.Forms.Label lbl_num_items;
        public System.Windows.Forms.Label label1;

    }
}