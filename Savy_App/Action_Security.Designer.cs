namespace Savy_App
{
    partial class Action_Security
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Security));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_confirmation_action = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_user_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_product_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Developed by R. Martinez | June 2019";
            // 
            // lbl_confirmation_action
            // 
            this.lbl_confirmation_action.AutoSize = true;
            this.lbl_confirmation_action.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmation_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_confirmation_action.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation_action.ForeColor = System.Drawing.Color.White;
            this.lbl_confirmation_action.Location = new System.Drawing.Point(93, 189);
            this.lbl_confirmation_action.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_confirmation_action.Name = "lbl_confirmation_action";
            this.lbl_confirmation_action.Size = new System.Drawing.Size(181, 19);
            this.lbl_confirmation_action.TabIndex = 21;
            this.lbl_confirmation_action.Text = "Action Confirmation for :";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.White;
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic);
            this.tbPass.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbPass.Location = new System.Drawing.Point(97, 271);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(406, 29);
            this.tbPass.TabIndex = 18;
            this.tbPass.Text = "Enter Password ";
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(303, 304);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 40);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Proceed";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(97, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.Gainsboro;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Enabled = false;
            this.tbUser.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic);
            this.tbUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbUser.Location = new System.Drawing.Point(97, 238);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(406, 29);
            this.tbUser.TabIndex = 17;
            this.tbUser.Text = "Username ";
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_id.Location = new System.Drawing.Point(588, 9);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(0, 14);
            this.lbl_product_id.TabIndex = 427;
            this.lbl_product_id.Visible = false;
            // 
            // lbl_user_id
            // 
            this.lbl_user_id.AutoSize = true;
            this.lbl_user_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_user_id.Location = new System.Drawing.Point(561, 9);
            this.lbl_user_id.Name = "lbl_user_id";
            this.lbl_user_id.Size = new System.Drawing.Size(0, 14);
            this.lbl_user_id.TabIndex = 428;
            this.lbl_user_id.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Savy_App.Properties.Resources._162_1628700_pluspoint_point_of_sale_and_stock_control_software;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(210, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 163);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_name.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.ForeColor = System.Drawing.Color.White;
            this.lbl_product_name.Location = new System.Drawing.Point(93, 209);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(131, 22);
            this.lbl_product_name.TabIndex = 429;
            this.lbl_product_name.Text = "Product Name";
            // 
            // Action_Security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savy_App.Properties.Resources._600x380_login2;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.lbl_user_id);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_confirmation_action);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Action_Security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action_Security";
            this.Load += new System.EventHandler(this.Action_Security_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbUser;
        public System.Windows.Forms.Label lbl_product_id;
        public System.Windows.Forms.Label lbl_user_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_product_name;
        public System.Windows.Forms.Label lbl_confirmation_action;
    }
}