namespace Savy_App
{
    partial class MDI
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_past_trans = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTHERREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_orders = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_products = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_brands = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_txtUserId = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 786);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1419, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel.Text = "Savy Outfitters | 2019";
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.Navy;
            this.menuStrip.BackgroundImage = global::Savy_App.Properties.Resources.Header2;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_logout,
            this.toolStripMenuItem1,
            this.ts_past_trans,
            this.menu_orders,
            this.menu_products,
            this.menu_suppliers,
            this.menu_brands,
            this.ts_txtUserId});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 8, 0, 8);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(1419, 81);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_logout
            // 
            this.menu_logout.BackColor = System.Drawing.Color.Navy;
            this.menu_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_logout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_logout.ForeColor = System.Drawing.Color.Black;
            this.menu_logout.Margin = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Size = new System.Drawing.Size(47, 65);
            this.menu_logout.Text = "Exit";
            this.menu_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Navy;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 65);
            this.toolStripMenuItem1.Text = "Hide";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ts_past_trans
            // 
            this.ts_past_trans.BackColor = System.Drawing.Color.Navy;
            this.ts_past_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_past_trans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSREPORTSToolStripMenuItem,
            this.oTHERREPORTSToolStripMenuItem});
            this.ts_past_trans.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_past_trans.ForeColor = System.Drawing.Color.Black;
            this.ts_past_trans.Name = "ts_past_trans";
            this.ts_past_trans.Size = new System.Drawing.Size(78, 65);
            this.ts_past_trans.Text = "Records";
            this.ts_past_trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ts_past_trans.Click += new System.EventHandler(this.ts_past_trans_Click);
            // 
            // pOSREPORTSToolStripMenuItem
            // 
            this.pOSREPORTSToolStripMenuItem.Name = "pOSREPORTSToolStripMenuItem";
            this.pOSREPORTSToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.pOSREPORTSToolStripMenuItem.Text = "POS REPORTS";
            this.pOSREPORTSToolStripMenuItem.Click += new System.EventHandler(this.pOSREPORTSToolStripMenuItem_Click);
            // 
            // oTHERREPORTSToolStripMenuItem
            // 
            this.oTHERREPORTSToolStripMenuItem.Name = "oTHERREPORTSToolStripMenuItem";
            this.oTHERREPORTSToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.oTHERREPORTSToolStripMenuItem.Text = "OTHER REPORTS";
            this.oTHERREPORTSToolStripMenuItem.Click += new System.EventHandler(this.oTHERREPORTSToolStripMenuItem_Click);
            // 
            // menu_orders
            // 
            this.menu_orders.BackColor = System.Drawing.Color.Navy;
            this.menu_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_orders.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_orders.ForeColor = System.Drawing.Color.Black;
            this.menu_orders.Name = "menu_orders";
            this.menu_orders.Size = new System.Drawing.Size(170, 65);
            this.menu_orders.Text = "Transaction/Payment";
            this.menu_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_orders.Click += new System.EventHandler(this.menu_orders_Click_1);
            // 
            // menu_products
            // 
            this.menu_products.BackColor = System.Drawing.Color.Navy;
            this.menu_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_products.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_products.ForeColor = System.Drawing.Color.Black;
            this.menu_products.Name = "menu_products";
            this.menu_products.Size = new System.Drawing.Size(83, 65);
            this.menu_products.Text = "Products";
            this.menu_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_products.Click += new System.EventHandler(this.menu_products_Click);
            // 
            // menu_suppliers
            // 
            this.menu_suppliers.BackColor = System.Drawing.Color.Navy;
            this.menu_suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_suppliers.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_suppliers.ForeColor = System.Drawing.Color.Black;
            this.menu_suppliers.Name = "menu_suppliers";
            this.menu_suppliers.Size = new System.Drawing.Size(86, 65);
            this.menu_suppliers.Text = "Suppliers";
            this.menu_suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_suppliers.Click += new System.EventHandler(this.menu_suppliers_Click);
            // 
            // menu_brands
            // 
            this.menu_brands.BackColor = System.Drawing.Color.Navy;
            this.menu_brands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_brands.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_brands.ForeColor = System.Drawing.Color.Black;
            this.menu_brands.Name = "menu_brands";
            this.menu_brands.Size = new System.Drawing.Size(71, 65);
            this.menu_brands.Text = "Brands";
            this.menu_brands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_brands.Click += new System.EventHandler(this.menu_brands_Click);
            // 
            // ts_txtUserId
            // 
            this.ts_txtUserId.Name = "ts_txtUserId";
            this.ts_txtUserId.Size = new System.Drawing.Size(100, 65);
            this.ts_txtUserId.Visible = false;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Savy_App.Properties.Resources.ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1419, 808);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savy Inventory System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem menu_brands;
        private System.Windows.Forms.ToolStripMenuItem menu_products;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menu_logout;
        private System.Windows.Forms.ToolStripMenuItem menu_suppliers;
        private System.Windows.Forms.ToolStripMenuItem menu_orders;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ts_past_trans;
        private System.Windows.Forms.ToolStripMenuItem pOSREPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTHERREPORTSToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox ts_txtUserId;
    }
}



