namespace Savy_App
{
    partial class Product_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_p_price = new System.Windows.Forms.Label();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_product_price = new System.Windows.Forms.Label();
            this.lbl_p_SKU = new System.Windows.Forms.Label();
            this.lbl_product_sku = new System.Windows.Forms.Label();
            this.lbl_p_supplier = new System.Windows.Forms.Label();
            this.lbl_product_supplier = new System.Windows.Forms.Label();
            this.lbl_product_availability = new System.Windows.Forms.Label();
            this.lbl_p_availability = new System.Windows.Forms.Label();
            this.lbl_p_description = new System.Windows.Forms.Label();
            this.lbl_product_desc = new System.Windows.Forms.Label();
            this.lbl_product_brand = new System.Windows.Forms.Label();
            this.lbl_p_brand = new System.Windows.Forms.Label();
            this.lbl_p_quantity = new System.Windows.Forms.Label();
            this.lbl_product_qty = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_chart = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_deliveredDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_num_items = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_stock = new System.Windows.Forms.Button();
            this.lbl_latest_stock_added = new System.Windows.Forms.Label();
            this.lbl_date_Stocks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.btn_close.Location = new System.Drawing.Point(856, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 422;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_p_price
            // 
            this.lbl_p_price.AutoSize = true;
            this.lbl_p_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_price.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_price.Location = new System.Drawing.Point(126, 97);
            this.lbl_p_price.Name = "lbl_p_price";
            this.lbl_p_price.Size = new System.Drawing.Size(47, 15);
            this.lbl_p_price.TabIndex = 374;
            this.lbl_p_price.Text = "Section";
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.ForeColor = System.Drawing.Color.White;
            this.lbl_product_name.Location = new System.Drawing.Point(8, 11);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(134, 22);
            this.lbl_product_name.TabIndex = 348;
            this.lbl_product_name.Text = "Product Name";
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_id.Location = new System.Drawing.Point(25, 9);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(0, 14);
            this.lbl_product_id.TabIndex = 398;
            this.lbl_product_id.Visible = false;
            // 
            // lbl_product_price
            // 
            this.lbl_product_price.AutoSize = true;
            this.lbl_product_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_price.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_price.Location = new System.Drawing.Point(5, 98);
            this.lbl_product_price.Name = "lbl_product_price";
            this.lbl_product_price.Size = new System.Drawing.Size(41, 15);
            this.lbl_product_price.TabIndex = 370;
            this.lbl_product_price.Text = "Price :";
            // 
            // lbl_p_SKU
            // 
            this.lbl_p_SKU.AutoSize = true;
            this.lbl_p_SKU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_SKU.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_SKU.Location = new System.Drawing.Point(126, 73);
            this.lbl_p_SKU.Name = "lbl_p_SKU";
            this.lbl_p_SKU.Size = new System.Drawing.Size(47, 15);
            this.lbl_p_SKU.TabIndex = 373;
            this.lbl_p_SKU.Text = "Section";
            // 
            // lbl_product_sku
            // 
            this.lbl_product_sku.AutoSize = true;
            this.lbl_product_sku.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_sku.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_sku.Location = new System.Drawing.Point(5, 73);
            this.lbl_product_sku.Name = "lbl_product_sku";
            this.lbl_product_sku.Size = new System.Drawing.Size(41, 17);
            this.lbl_product_sku.TabIndex = 369;
            this.lbl_product_sku.Text = "SKU :";
            // 
            // lbl_p_supplier
            // 
            this.lbl_p_supplier.AutoSize = true;
            this.lbl_p_supplier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_supplier.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_supplier.Location = new System.Drawing.Point(126, 199);
            this.lbl_p_supplier.Name = "lbl_p_supplier";
            this.lbl_p_supplier.Size = new System.Drawing.Size(47, 15);
            this.lbl_p_supplier.TabIndex = 386;
            this.lbl_p_supplier.Text = "Section";
            // 
            // lbl_product_supplier
            // 
            this.lbl_product_supplier.AutoSize = true;
            this.lbl_product_supplier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_supplier.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_supplier.Location = new System.Drawing.Point(5, 200);
            this.lbl_product_supplier.Name = "lbl_product_supplier";
            this.lbl_product_supplier.Size = new System.Drawing.Size(59, 15);
            this.lbl_product_supplier.TabIndex = 384;
            this.lbl_product_supplier.Text = "Supplier :";
            // 
            // lbl_product_availability
            // 
            this.lbl_product_availability.AutoSize = true;
            this.lbl_product_availability.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_availability.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_availability.Location = new System.Drawing.Point(5, 226);
            this.lbl_product_availability.Name = "lbl_product_availability";
            this.lbl_product_availability.Size = new System.Drawing.Size(77, 15);
            this.lbl_product_availability.TabIndex = 385;
            this.lbl_product_availability.Text = "Availability :";
            // 
            // lbl_p_availability
            // 
            this.lbl_p_availability.AutoSize = true;
            this.lbl_p_availability.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_availability.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_availability.Location = new System.Drawing.Point(126, 225);
            this.lbl_p_availability.Name = "lbl_p_availability";
            this.lbl_p_availability.Size = new System.Drawing.Size(47, 15);
            this.lbl_p_availability.TabIndex = 387;
            this.lbl_p_availability.Text = "Section";
            // 
            // lbl_p_description
            // 
            this.lbl_p_description.AutoSize = true;
            this.lbl_p_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_description.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_description.Location = new System.Drawing.Point(126, 149);
            this.lbl_p_description.Name = "lbl_p_description";
            this.lbl_p_description.Size = new System.Drawing.Size(47, 15);
            this.lbl_p_description.TabIndex = 380;
            this.lbl_p_description.Text = "Section";
            // 
            // lbl_product_desc
            // 
            this.lbl_product_desc.AutoSize = true;
            this.lbl_product_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_desc.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_desc.Location = new System.Drawing.Point(5, 149);
            this.lbl_product_desc.Name = "lbl_product_desc";
            this.lbl_product_desc.Size = new System.Drawing.Size(78, 15);
            this.lbl_product_desc.TabIndex = 378;
            this.lbl_product_desc.Text = "Description :";
            // 
            // lbl_product_brand
            // 
            this.lbl_product_brand.AutoSize = true;
            this.lbl_product_brand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_brand.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_brand.Location = new System.Drawing.Point(5, 175);
            this.lbl_product_brand.Name = "lbl_product_brand";
            this.lbl_product_brand.Size = new System.Drawing.Size(46, 15);
            this.lbl_product_brand.TabIndex = 379;
            this.lbl_product_brand.Text = "Brand :";
            // 
            // lbl_p_brand
            // 
            this.lbl_p_brand.AutoSize = true;
            this.lbl_p_brand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_brand.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_brand.Location = new System.Drawing.Point(126, 174);
            this.lbl_p_brand.Name = "lbl_p_brand";
            this.lbl_p_brand.Size = new System.Drawing.Size(47, 15);
            this.lbl_p_brand.TabIndex = 381;
            this.lbl_p_brand.Text = "Section";
            // 
            // lbl_p_quantity
            // 
            this.lbl_p_quantity.AutoSize = true;
            this.lbl_p_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p_quantity.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_quantity.Location = new System.Drawing.Point(126, 123);
            this.lbl_p_quantity.Name = "lbl_p_quantity";
            this.lbl_p_quantity.Size = new System.Drawing.Size(47, 15);
            this.lbl_p_quantity.TabIndex = 377;
            this.lbl_p_quantity.Text = "Section";
            // 
            // lbl_product_qty
            // 
            this.lbl_product_qty.AutoSize = true;
            this.lbl_product_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_qty.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_qty.Location = new System.Drawing.Point(5, 123);
            this.lbl_product_qty.Name = "lbl_product_qty";
            this.lbl_product_qty.Size = new System.Drawing.Size(61, 15);
            this.lbl_product_qty.TabIndex = 375;
            this.lbl_product_qty.Text = "Quantity :";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete.BackgroundImage = global::Savy_App.Properties.Resources._200x40_red;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(673, 585);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(215, 40);
            this.btn_delete.TabIndex = 426;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Orange;
            this.btn_edit.BackgroundImage = global::Savy_App.Properties.Resources._200x40_yellow;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(452, 585);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(215, 40);
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
            this.btn_add.Size = new System.Drawing.Size(215, 40);
            this.btn_add.TabIndex = 425;
            this.btn_add.Text = "Add Product";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_chart.Location = new System.Drawing.Point(3, 73);
            this.dgv_chart.Name = "dgv_chart";
            this.dgv_chart.ReadOnly = true;
            this.dgv_chart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_chart.Size = new System.Drawing.Size(578, 427);
            this.dgv_chart.TabIndex = 429;
            this.dgv_chart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chart_CellClick_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_date_Stocks);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_latest_stock_added);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_deliveredDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_product_name);
            this.panel2.Controls.Add(this.lbl_p_supplier);
            this.panel2.Controls.Add(this.lbl_product_supplier);
            this.panel2.Controls.Add(this.lbl_product_availability);
            this.panel2.Controls.Add(this.lbl_p_SKU);
            this.panel2.Controls.Add(this.lbl_p_availability);
            this.panel2.Controls.Add(this.lbl_p_price);
            this.panel2.Controls.Add(this.lbl_p_description);
            this.panel2.Controls.Add(this.lbl_product_price);
            this.panel2.Controls.Add(this.lbl_product_desc);
            this.panel2.Controls.Add(this.lbl_product_sku);
            this.panel2.Controls.Add(this.lbl_product_brand);
            this.panel2.Controls.Add(this.lbl_product_qty);
            this.panel2.Controls.Add(this.lbl_p_brand);
            this.panel2.Controls.Add(this.lbl_p_quantity);
            this.panel2.Location = new System.Drawing.Point(601, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 530);
            this.panel2.TabIndex = 460;
            // 
            // lbl_deliveredDate
            // 
            this.lbl_deliveredDate.AutoSize = true;
            this.lbl_deliveredDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deliveredDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deliveredDate.Location = new System.Drawing.Point(126, 49);
            this.lbl_deliveredDate.Name = "lbl_deliveredDate";
            this.lbl_deliveredDate.Size = new System.Drawing.Size(47, 15);
            this.lbl_deliveredDate.TabIndex = 389;
            this.lbl_deliveredDate.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 388;
            this.label4.Text = "Delivered Date :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgv_chart);
            this.panel1.Controls.Add(this.lbl_num_items);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 529);
            this.panel1.TabIndex = 461;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Location = new System.Drawing.Point(123, 46);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(458, 23);
            this.txt_search.TabIndex = 454;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 455;
            this.label7.Text = "Search Product :";
            // 
            // lbl_num_items
            // 
            this.lbl_num_items.AutoSize = true;
            this.lbl_num_items.BackColor = System.Drawing.Color.Transparent;
            this.lbl_num_items.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_items.Location = new System.Drawing.Point(138, 503);
            this.lbl_num_items.Name = "lbl_num_items";
            this.lbl_num_items.Size = new System.Drawing.Size(112, 17);
            this.lbl_num_items.TabIndex = 376;
            this.lbl_num_items.Text = "Number of items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 358;
            this.label1.Text = "Manage Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 376;
            this.label2.Text = "Total Products:";
            // 
            // btn_add_stock
            // 
            this.btn_add_stock.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_add_stock.BackgroundImage = global::Savy_App.Properties.Resources._200x40_green;
            this.btn_add_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_stock.FlatAppearance.BorderSize = 0;
            this.btn_add_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_add_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_add_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_stock.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_stock.ForeColor = System.Drawing.Color.White;
            this.btn_add_stock.Location = new System.Drawing.Point(231, 584);
            this.btn_add_stock.Name = "btn_add_stock";
            this.btn_add_stock.Size = new System.Drawing.Size(215, 40);
            this.btn_add_stock.TabIndex = 426;
            this.btn_add_stock.Text = "Add Stock";
            this.btn_add_stock.UseVisualStyleBackColor = false;
            this.btn_add_stock.Click += new System.EventHandler(this.btn_add_stock_Click);
            // 
            // lbl_latest_stock_added
            // 
            this.lbl_latest_stock_added.AutoSize = true;
            this.lbl_latest_stock_added.BackColor = System.Drawing.Color.Transparent;
            this.lbl_latest_stock_added.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latest_stock_added.Location = new System.Drawing.Point(126, 503);
            this.lbl_latest_stock_added.Name = "lbl_latest_stock_added";
            this.lbl_latest_stock_added.Size = new System.Drawing.Size(47, 15);
            this.lbl_latest_stock_added.TabIndex = 393;
            this.lbl_latest_stock_added.Text = "Section";
            // 
            // lbl_date_Stocks
            // 
            this.lbl_date_Stocks.AutoSize = true;
            this.lbl_date_Stocks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_Stocks.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_Stocks.Location = new System.Drawing.Point(86, 478);
            this.lbl_date_Stocks.Name = "lbl_date_Stocks";
            this.lbl_date_Stocks.Size = new System.Drawing.Size(47, 15);
            this.lbl_date_Stocks.TabIndex = 395;
            this.lbl_date_Stocks.Text = "Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 394;
            this.label6.Text = "Latest date  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 392;
            this.label5.Text = "Newly added Stock :";
            // 
            // Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._900x635;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.btn_add_stock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_List";
            this.Load += new System.EventHandler(this.Product_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label lbl_p_price;
        public System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Label lbl_product_id;
        public System.Windows.Forms.Label lbl_product_price;
        public System.Windows.Forms.Label lbl_p_SKU;
        public System.Windows.Forms.Label lbl_product_sku;
        public System.Windows.Forms.Label lbl_p_quantity;
        public System.Windows.Forms.Label lbl_product_qty;
        public System.Windows.Forms.Label lbl_p_supplier;
        public System.Windows.Forms.Label lbl_product_supplier;
        public System.Windows.Forms.Label lbl_product_availability;
        public System.Windows.Forms.Label lbl_p_availability;
        public System.Windows.Forms.Label lbl_p_description;
        public System.Windows.Forms.Label lbl_product_desc;
        public System.Windows.Forms.Label lbl_product_brand;
        public System.Windows.Forms.Label lbl_p_brand;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_chart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_num_items;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_deliveredDate;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_add_stock;
        public System.Windows.Forms.Label lbl_date_Stocks;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl_latest_stock_added;
        public System.Windows.Forms.Label label5;
    }
}