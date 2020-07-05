namespace Savy_App
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crv_1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.txt_totalamount = new System.Windows.Forms.TextBox();
            this.txt_transnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_savetransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Receipt1 = new Savy_App.Receipt();
            this.Name_ = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_supplier_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Transaction = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_status = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_peso = new System.Windows.Forms.RadioButton();
            this.rb_percent = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.dtg_products = new System.Windows.Forms.DataGridView();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_totalamount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dtg_cart = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // crv_1
            // 
            this.crv_1.ActiveViewIndex = -1;
            this.crv_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_1.DisplayStatusBar = false;
            this.crv_1.Location = new System.Drawing.Point(3, 29);
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
            this.crv_1.Size = new System.Drawing.Size(332, 289);
            this.crv_1.TabIndex = 463;
            this.crv_1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 461;
            this.label2.Text = "Change (Php):";
            // 
            // txt_change
            // 
            this.txt_change.Enabled = false;
            this.txt_change.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_change.ForeColor = System.Drawing.Color.Black;
            this.txt_change.Location = new System.Drawing.Point(156, 122);
            this.txt_change.Multiline = true;
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(177, 23);
            this.txt_change.TabIndex = 460;
            // 
            // txt_totalamount
            // 
            this.txt_totalamount.Enabled = false;
            this.txt_totalamount.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalamount.ForeColor = System.Drawing.Color.Black;
            this.txt_totalamount.Location = new System.Drawing.Point(156, 58);
            this.txt_totalamount.Multiline = true;
            this.txt_totalamount.Name = "txt_totalamount";
            this.txt_totalamount.Size = new System.Drawing.Size(177, 23);
            this.txt_totalamount.TabIndex = 455;
            // 
            // txt_transnum
            // 
            this.txt_transnum.Enabled = false;
            this.txt_transnum.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transnum.ForeColor = System.Drawing.Color.Black;
            this.txt_transnum.Location = new System.Drawing.Point(156, 32);
            this.txt_transnum.Multiline = true;
            this.txt_transnum.Name = "txt_transnum";
            this.txt_transnum.Size = new System.Drawing.Size(177, 23);
            this.txt_transnum.TabIndex = 454;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 459;
            this.label9.Text = "Total Amount (Php):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 453;
            this.label3.Text = "Payment (Php):";
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.ForeColor = System.Drawing.Color.Black;
            this.txt_payment.Location = new System.Drawing.Point(156, 84);
            this.txt_payment.Multiline = true;
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(177, 23);
            this.txt_payment.TabIndex = 452;
            this.txt_payment.TextChanged += new System.EventHandler(this.txt_payment_TextChanged);
            this.txt_payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_payment_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 457;
            this.label5.Text = "Transaction No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 358;
            this.label1.Text = "Cart";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Maroon;
            this.btn_clear.BackgroundImage = global::Savy_App.Properties.Resources._200x40_red;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(156, 151);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(177, 40);
            this.btn_clear.TabIndex = 450;
            this.btn_clear.Text = "Cancel Transaction";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_savetransaction
            // 
            this.btn_savetransaction.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_savetransaction.BackgroundImage = global::Savy_App.Properties.Resources._200x40_green;
            this.btn_savetransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_savetransaction.FlatAppearance.BorderSize = 0;
            this.btn_savetransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_savetransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_savetransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savetransaction.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savetransaction.ForeColor = System.Drawing.Color.White;
            this.btn_savetransaction.Location = new System.Drawing.Point(156, 197);
            this.btn_savetransaction.Name = "btn_savetransaction";
            this.btn_savetransaction.Size = new System.Drawing.Size(177, 40);
            this.btn_savetransaction.TabIndex = 434;
            this.btn_savetransaction.Text = "Save and View Receipt";
            this.btn_savetransaction.UseVisualStyleBackColor = false;
            this.btn_savetransaction.Click += new System.EventHandler(this.btn_savetransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(153, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 462;
            this.label4.Text = "___________________________________";
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.BackColor = System.Drawing.Color.Transparent;
            this.Name_.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_.Location = new System.Drawing.Point(72, 59);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(0, 19);
            this.Name_.TabIndex = 453;
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
            this.btn_close.Location = new System.Drawing.Point(860, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 454;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.Black;
            this.txt_Id.Location = new System.Drawing.Point(12, 10);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(88, 23);
            this.txt_Id.TabIndex = 456;
            this.txt_Id.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_supplier_name);
            this.panel2.Controls.Add(this.crv_1);
            this.panel2.Location = new System.Drawing.Point(555, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 321);
            this.panel2.TabIndex = 460;
            // 
            // lbl_supplier_name
            // 
            this.lbl_supplier_name.AutoSize = true;
            this.lbl_supplier_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_supplier_name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier_name.ForeColor = System.Drawing.Color.White;
            this.lbl_supplier_name.Location = new System.Drawing.Point(12, 1);
            this.lbl_supplier_name.Name = "lbl_supplier_name";
            this.lbl_supplier_name.Size = new System.Drawing.Size(76, 22);
            this.lbl_supplier_name.TabIndex = 348;
            this.lbl_supplier_name.Text = "Receipt";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_savetransaction);
            this.panel1.Controls.Add(this.txt_change);
            this.panel1.Controls.Add(this.Transaction);
            this.panel1.Controls.Add(this.txt_totalamount);
            this.panel1.Controls.Add(this.txt_transnum);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_payment);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(555, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 248);
            this.panel1.TabIndex = 461;
            // 
            // Transaction
            // 
            this.Transaction.AutoSize = true;
            this.Transaction.BackColor = System.Drawing.Color.Transparent;
            this.Transaction.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.ForeColor = System.Drawing.Color.White;
            this.Transaction.Location = new System.Drawing.Point(13, 0);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(164, 22);
            this.Transaction.TabIndex = 358;
            this.Transaction.Text = "Manage Suppliers";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(106, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 23);
            this.textBox1.TabIndex = 462;
            this.textBox1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel_status);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_search);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.txt_discount);
            this.panel3.Controls.Add(this.dtg_products);
            this.panel3.Controls.Add(this.txt_stock);
            this.panel3.Controls.Add(this.txt_product);
            this.panel3.Controls.Add(this.txt_price);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_qty);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(12, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 310);
            this.panel3.TabIndex = 463;
            // 
            // panel_status
            // 
            this.panel_status.Controls.Add(this.radioButton1);
            this.panel_status.Controls.Add(this.rb_peso);
            this.panel_status.Controls.Add(this.rb_percent);
            this.panel_status.ForeColor = System.Drawing.Color.Black;
            this.panel_status.Location = new System.Drawing.Point(124, 204);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(213, 30);
            this.panel_status.TabIndex = 454;
            this.panel_status.TabStop = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(149, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_peso
            // 
            this.rb_peso.AutoSize = true;
            this.rb_peso.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_peso.ForeColor = System.Drawing.Color.Black;
            this.rb_peso.Location = new System.Drawing.Point(81, 7);
            this.rb_peso.Name = "rb_peso";
            this.rb_peso.Size = new System.Drawing.Size(30, 16);
            this.rb_peso.TabIndex = 5;
            this.rb_peso.Text = "₱";
            this.rb_peso.UseVisualStyleBackColor = true;
            this.rb_peso.CheckedChanged += new System.EventHandler(this.rb_peso_CheckedChanged);
            // 
            // rb_percent
            // 
            this.rb_percent.AutoSize = true;
            this.rb_percent.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_percent.ForeColor = System.Drawing.Color.Black;
            this.rb_percent.Location = new System.Drawing.Point(8, 7);
            this.rb_percent.Name = "rb_percent";
            this.rb_percent.Size = new System.Drawing.Size(34, 16);
            this.rb_percent.TabIndex = 4;
            this.rb_percent.Text = "%";
            this.rb_percent.UseVisualStyleBackColor = true;
            this.rb_percent.CheckedChanged += new System.EventHandler(this.rb_percent_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 455;
            this.label8.Text = "Discount Type :";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Location = new System.Drawing.Point(124, 31);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(410, 23);
            this.txt_search.TabIndex = 452;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 453;
            this.label7.Text = "Search Product :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 358;
            this.label6.Text = "List of Products";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 451;
            this.label10.Text = "Discount :";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(124, 264);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(410, 40);
            this.btn_add.TabIndex = 441;
            this.btn_add.Text = "Add Product";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_discount
            // 
            this.txt_discount.Enabled = false;
            this.txt_discount.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.ForeColor = System.Drawing.Color.Black;
            this.txt_discount.Location = new System.Drawing.Point(124, 237);
            this.txt_discount.Multiline = true;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(213, 23);
            this.txt_discount.TabIndex = 450;
            // 
            // dtg_products
            // 
            this.dtg_products.AllowUserToAddRows = false;
            this.dtg_products.AllowUserToDeleteRows = false;
            this.dtg_products.AllowUserToOrderColumns = true;
            this.dtg_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_products.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_products.Location = new System.Drawing.Point(124, 58);
            this.dtg_products.Name = "dtg_products";
            this.dtg_products.ReadOnly = true;
            this.dtg_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtg_products.Size = new System.Drawing.Size(410, 117);
            this.dtg_products.TabIndex = 451;
            this.dtg_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_products_CellClick_1);
            // 
            // txt_stock
            // 
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.Color.Black;
            this.txt_stock.Location = new System.Drawing.Point(418, 207);
            this.txt_stock.Multiline = true;
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(116, 23);
            this.txt_stock.TabIndex = 446;
            // 
            // txt_product
            // 
            this.txt_product.Enabled = false;
            this.txt_product.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product.ForeColor = System.Drawing.Color.Black;
            this.txt_product.Location = new System.Drawing.Point(124, 178);
            this.txt_product.Multiline = true;
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(213, 23);
            this.txt_product.TabIndex = 444;
            // 
            // txt_price
            // 
            this.txt_price.Enabled = false;
            this.txt_price.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.Black;
            this.txt_price.Location = new System.Drawing.Point(418, 178);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(116, 23);
            this.txt_price.TabIndex = 445;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 447;
            this.label11.Text = "Product Name :";
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.ForeColor = System.Drawing.Color.Black;
            this.txt_qty.Location = new System.Drawing.Point(418, 237);
            this.txt_qty.Multiline = true;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(116, 23);
            this.txt_qty.TabIndex = 442;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(347, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 449;
            this.label12.Text = "Price :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(347, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 448;
            this.label13.Text = "Stocks :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(347, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 443;
            this.label14.Text = "Quantity :";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Savy_App.Properties.Resources._290x530_detail;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbl_totalamount);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.dtg_cart);
            this.panel4.Location = new System.Drawing.Point(12, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 259);
            this.panel4.TabIndex = 464;
            // 
            // lbl_totalamount
            // 
            this.lbl_totalamount.AutoSize = true;
            this.lbl_totalamount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalamount.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalamount.Location = new System.Drawing.Point(148, 187);
            this.lbl_totalamount.Name = "lbl_totalamount";
            this.lbl_totalamount.Size = new System.Drawing.Size(16, 17);
            this.lbl_totalamount.TabIndex = 463;
            this.lbl_totalamount.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 17);
            this.label15.TabIndex = 464;
            this.label15.Text = "Total Amount (₱):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.BackgroundImage = global::Savy_App.Properties.Resources._200x40_red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 40);
            this.button1.TabIndex = 455;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(273, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 40);
            this.button2.TabIndex = 454;
            this.button2.Text = "Proceed to Payment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(20, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 22);
            this.label16.TabIndex = 358;
            this.label16.Text = "My Cart";
            // 
            // dtg_cart
            // 
            this.dtg_cart.AllowUserToAddRows = false;
            this.dtg_cart.AllowUserToDeleteRows = false;
            this.dtg_cart.AllowUserToOrderColumns = true;
            this.dtg_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_cart.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_cart.Location = new System.Drawing.Point(3, 25);
            this.dtg_cart.Name = "dtg_cart";
            this.dtg_cart.ReadOnly = true;
            this.dtg_cart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtg_cart.Size = new System.Drawing.Size(531, 159);
            this.dtg_cart.TabIndex = 378;
            this.dtg_cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_cart_CellClick);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._900x635;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.Name_);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_products)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_savetransaction;
        public System.Windows.Forms.Label Name_;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_change;
        public System.Windows.Forms.TextBox txt_totalamount;
        public System.Windows.Forms.TextBox txt_transnum;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_payment;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Id;
        public System.Windows.Forms.Label label4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_1;
        private Receipt Receipt1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_supplier_name;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Transaction;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel_status;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton rb_peso;
        public System.Windows.Forms.RadioButton rb_percent;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.DataGridView dtg_products;
        public System.Windows.Forms.TextBox txt_stock;
        public System.Windows.Forms.TextBox txt_product;
        public System.Windows.Forms.TextBox txt_price;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_qty;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lbl_totalamount;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dtg_cart;
    }
}