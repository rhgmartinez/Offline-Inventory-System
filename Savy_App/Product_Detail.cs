using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savy_App
{
    public partial class Product_Detail : Form
    {
        SQL Record, Record2;
        DataTable dt, dt2;
        int product_status, brand_id, supplier_id;
        public Product_Detail()
        {
            InitializeComponent();
            dtp_date.Value = DateTime.Now;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            txt_name.MaxLength = 30;
            txt_description.MaxLength = 30;
            txt_sku.MaxLength = 20;
            txt_price.MaxLength = 12;
        }

        private void Product_Detail_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            //Populate brand
            dt = getBrands("All"); //ALL

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Brands!");
                this.Close();
            }
            else
            {
                for (int counter = 0; counter < dt.Rows.Count; counter++)
                {
                    string brandName = dt.Rows[counter]["brandName"].ToString();
                    this.cmb_brand.Items.Add(brandName);
                }
            }


            dt = getSuppliers("All"); //ALL
            if (dt.Rows.Count == 0)
            {
                this.cmb_supplier.Enabled = false;
            }
            else
            {
                for (int counter = 0; counter < dt.Rows.Count; counter++)
                {
                    string supplierName = dt.Rows[counter]["supplierName"].ToString();
                    this.cmb_supplier.Items.Add(supplierName);
                }
            }

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
                txt_description.Text = dt.Rows[0]["productDescription"].ToString();
                product_status = Convert.ToInt32(dt.Rows[0]["productStatus"].ToString());
                brand_id = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());
                supplier_id = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
                txt_price.Text = dt.Rows[0]["productPrice"].ToString();
                txt_sku.Text = dt.Rows[0]["productSKU"].ToString();
                txt_cStock.Text = dt.Rows[0]["productQty"].ToString();
                dtp_date.Text = dt.Rows[0]["CREATE_DATE"].ToString();
                cmb_supplier.Text = getSpecificSupplier(supplier_id);
                cmb_brand.Text = getSpecificBrand(brand_id);
                if (product_status == 1)
                {
                    rb_active.Checked = true;
                    rb_inactive.Checked = false;
                }
                else
                {
                    rb_active.Checked = false;
                    rb_inactive.Checked = true;
                }
                txt_cStock.Enabled = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (
                txt_name.Text == "" ||
                txt_price.Text == "" ||
                cmb_brand.Text == ""
                )
            {
                MessageBox.Show("Required fields are not completed.");
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();
                int status = rb_active.Checked == true ? 1 : 0;
                int supplierId = 0;
                if (cmb_supplier.Text != "")
                {
                    dt = getSuppliers(cmb_supplier.Text);
                    supplierId = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
                }
                else
                {
                    dt = getSuppliers(cmb_supplier.Text);
                    supplierId = 0;
                }

                dt = getBrands(cmb_brand.Text);
                int brandId = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());

                //CHECK FOR DUPLICATE PRODUCTS WITH SAME NAME, PRICE AND BRAND
                Record2 = new SQL();
                dt2 = new DataTable();
                dt2 = Record2.SELECT_STATEMENT("SELECT * FROM Products where productName='" + txt_name.Text + "' AND productPrice='" + txt_price.Text + "' AND brandId =" + brandId);
                string dup_id = dt2.Rows.Count > 0 ? "Yes": "No";

                if (dup_id == "No")
                {
                    String statement = "";
                
                    if (lbl_product_id.Text == "")
                    {
                        statement =
                        "INSERT INTO Products(productName, productDescription, productStatus, productSKU, productPrice, productQty, brandId, supplierId, CREATE_DATE, LAST_UPDATE_DATE)"
                        + " VALUES('"
                        + txt_name.Text + "','"
                        + txt_description.Text + "',"
                        + status + ",'"
                        + txt_sku.Text + "','"
                        + txt_price.Text + "',"
                        + Convert.ToInt32(txt_cStock.Text) + ","
                            //+ ImageToBase64(product_image.Image,System.Drawing.Imaging.ImageFormat.Png) + ","
                        + brandId + ","
                        + supplierId + ",'"
                        + DateTime.Now.ToShortDateString() + "','"
                        + DateTime.Now.ToShortDateString() + "')";
                    }
                    else
                    {
                        statement = "UPDATE Products set productName = '" + txt_name.Text
                            + "', productDescription = '" + txt_description.Text
                            + "', productStatus = " + status
                            + ", productSKU = '" + txt_sku.Text
                            + "', productPrice = '" + txt_price.Text
                            + "', brandId = " + brandId
                            + ", supplierId = " + supplierId
                            + ", LAST_UPDATE_DATE = '" + DateTime.Now.ToShortDateString()
                            + "' where productId = " + Convert.ToInt32(lbl_product_id.Text)
                            + "";
                    }

                    Record.CUD_STATEMENT(statement);
                    MessageBox.Show("Product Detail saved successfully!");
                    Record.close();
                    clearProductFields();

                    Product_List p = new Product_List();
                    p.MdiParent = MdiParent;
                    p.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Duplicate Product! Product with the same Name, Brand and Price already exists!");
                }
                
            }

        }
        public void clearProductFields()
        {
            lbl_product_id.Text = "";
            txt_name.Text = "";
            txt_description.Text = "";
            txt_sku.Text = "";
            txt_price.Text = "";
            rb_active.Checked = true;
            rb_inactive.Checked = false;
            dtp_date.Value = DateTime.Now;
            cmb_brand.Text = "";
            cmb_supplier.Text = "";
            txt_cStock.Text = "0";
        }

        public dynamic getSuppliers(string text)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            //Populate brands
            conn_string = text == "All" ? "SELECT * FROM Suppliers" + " WHERE supplierStatus = 1" : "SELECT * FROM Suppliers" + " WHERE supplierStatus = 1 AND supplierName = '" + text + "'";
            dt = Record.SELECT_STATEMENT(conn_string);
            return dt;
        }
        public dynamic getSpecificSupplier(int id)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";
            if (id == 0)
            {
                return "";
            }
            else
            {
                conn_string = "SELECT * FROM Suppliers" + " WHERE supplierStatus = 1 AND supplierId = " + id + "";
                dt = Record.SELECT_STATEMENT(conn_string);

                dt = Record.SELECT_STATEMENT(conn_string);
                string supplierName = dt.Rows[0]["supplierName"].ToString();
                return supplierName;
            }

        }

        public dynamic getBrands(string text)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            //Populate supplier
            conn_string = text == "All" ? "SELECT * FROM Brands" + " WHERE brandStatus = 1" : "SELECT * FROM Brands" + " WHERE brandStatus = 1 AND brandName = '" + text + "'";
            dt = Record.SELECT_STATEMENT(conn_string);
            return dt;
        }

        public dynamic getSpecificBrand(int id)
        {
            Record = new SQL();
            dt = new DataTable();
            string conn_string = "";

            conn_string = "SELECT * FROM Brands" + " WHERE brandStatus = 1 AND brandId = " + id + "";
            dt = Record.SELECT_STATEMENT(conn_string);

            dt = Record.SELECT_STATEMENT(conn_string);
            string brandName = dt.Rows[0]["brandName"].ToString();
            return brandName;
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_price.Text, "  ^ [0-9]"))
            {
                txt_price.Text = "";
            }
        }
    }
}
