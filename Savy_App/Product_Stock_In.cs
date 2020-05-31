using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Savy_App
{
    public partial class Product_Stock_In : Form
    {
        SQL Record;
        DataTable dt;
        string curstock;
        public Product_Stock_In()
        {
            InitializeComponent();
            dtp_date.Value = DateTime.Now;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_Stock_In_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            if (lbl_product_id.Text == "")
            {
                clearProductFields();
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();
                dt = Record.SELECT_STATEMENT("SELECT * FROM Products where productId=" + Convert.ToInt32(lbl_product_id.Text));
                txt_name.Text = dt.Rows[0]["productName"].ToString();
                txt_cStock.Text = dt.Rows[0]["productQty"].ToString();
                curstock = txt_cStock.Text;
                txt_qty.Enabled = true;
                txt_cStock.Enabled = false;
            }
        }
        public void clearProductFields()
        {
            lbl_product_id.Text = "";
            txt_name.Text = "";
            txt_qty.Text = "0";
            dtp_date.Value = DateTime.Now;
            txt_cStock.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_qty.Text == "")
            {
                MessageBox.Show("Required field is not completed.");
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();
               
                String statement = "";
                statement =
                   "INSERT INTO ProductStocks(productId, quantity, CREATE_DATE, LAST_UPDATE_DATE)"
                   + " VALUES("
                   + lbl_product_id.Text + ","
                   + Convert.ToInt32(txt_qty.Text) + ",'"
                   + DateTime.Now.ToShortDateString() + "','"
                   + DateTime.Now.ToShortDateString() + "')";

                Record.CUD_STATEMENT(statement);
                MessageBox.Show("Stock for this Product saved successfully!");

                statement = "UPDATE Products set productQty = productQty + " + txt_qty.Text
                        + ", LAST_UPDATE_DATE = '" + DateTime.Now.ToShortDateString()
                        + "' where productId = " + Convert.ToInt32(lbl_product_id.Text)
                        + "";

                Record.CUD_STATEMENT(statement);
                Record.close();
                clearProductFields();

                Product_List p = new Product_List();
                p.MdiParent = MdiParent;
                p.Show();

                this.Close();

            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_qty.Text, "  ^ [0-9]"))
            {
                txt_qty.Text = "0";
                txt_cStock.Text = curstock;
            }
            else
            {
                if (txt_qty.Text != "")
                {
                    txt_cStock.Text = (Convert.ToInt32(curstock) + Convert.ToInt32(txt_qty.Text)).ToString();
                }
            }
            
        }
    }
}
