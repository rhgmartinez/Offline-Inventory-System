using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savy_App
{
    public partial class Product_List : Form
    {
        SQL Record;
        DataTable dt, dt2;
        int brandId = 0, supplierId = 0;
        public Product_List()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product_Detail h = new Product_Detail();
            h.MdiParent = MdiParent;
            h.Show();

            this.Close();
        }

        private void Product_List_Load(object sender, EventArgs e)
        {
            clearProductFields();
            loadRecords();
        }

        public void clearProductFields()
        {
            lbl_product_id.Text = "";
            lbl_product_name.Text = "Select a Product";
            lbl_p_description.Text = "";
            lbl_p_price.Text = "";
            lbl_p_quantity.Text = "";
            lbl_p_SKU.Text = "";
            lbl_p_availability.Text = "";
            lbl_deliveredDate.Text = "";
            lbl_date_Stocks.Text = "";
            lbl_latest_stock_added.Text = "";
            lbl_p_supplier.Text = "";
            lbl_p_brand.Text = "";

        }
        public void loadRecords()
        {
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT prod.*, stock.quantity, stock.CREATE_DATE AS stock_as_of FROM Products prod "+
            "LEFT JOIN ( "+
	        "SELECT ps.productId, SUM (ps.quantity) AS quantity, ps.CREATE_DATE FROM ProductStocks ps " +
	        "WHERE ps.CREATE_DATE = (SELECT TOP 1 CREATE_DATE FROM ProductStocks WHERE productId = ps.productId  ORDER BY CREATE_DATE ASC) "+
	        "GROUP BY ps.productId, ps.CREATE_DATE "+
            ") stock ON prod.productId = stock.productId "+
            "ORDER BY prod.CREATE_DATE ASC");

            dgv_chart.DataSource = dt;

            dgv_chart.Columns[0].Visible = false;
            dgv_chart.Columns[1].HeaderText = "Product Name";
            dgv_chart.Columns[2].HeaderText = "Description";
            dgv_chart.Columns[3].Visible = false;
            dgv_chart.Columns[4].Visible = false;
            dgv_chart.Columns[5].HeaderText = "Price";
            dgv_chart.Columns[6].HeaderText = "Stock";
            dgv_chart.Columns[7].Visible = false;
            dgv_chart.Columns[8].Visible = false;
            dgv_chart.Columns[9].Visible = false;
            dgv_chart.Columns[10].Visible = false;
            dgv_chart.Columns[11].Visible = false;
            dgv_chart.Columns[12].Visible = false;
            dgv_chart.Columns[13].Visible = false;
            dgv_chart.Columns[14].Visible = false;

            lbl_num_items.Text = dt.Rows.Count.ToString();

            if (dt.Rows.Count > 0)
            {
                lbl_product_id.Text = dt.Rows[0]["productId"].ToString();
                lbl_product_name.Text = dt.Rows[0]["productName"].ToString();
                lbl_p_description.Text = dt.Rows[0]["productDescription"].ToString();
                lbl_p_price.Text = dt.Rows[0]["productPrice"].ToString();
                lbl_p_quantity.Text = dt.Rows[0]["productQty"].ToString();
                lbl_p_SKU.Text = dt.Rows[0]["productSKU"].ToString();
                lbl_p_availability.Text = dt.Rows[0]["productStatus"].ToString() == "1" ? "True" : "False";
                brandId = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());
                supplierId = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
                lbl_deliveredDate.Text = Convert.ToDateTime(dt.Rows[0]["CREATE_DATE"].ToString()).ToShortDateString();
                lbl_date_Stocks.Text = dt.Rows[0]["stock_as_of"].ToString();
                lbl_latest_stock_added.Text = dt.Rows[0]["quantity"].ToString();
                if (supplierId != 0)
                {
                    Record = new SQL();
                    dt2 = new DataTable();
                    dt2 = Record.SELECT_STATEMENT("SELECT * FROM Suppliers where supplierId = " + supplierId);
                    lbl_p_supplier.Text = dt2.Rows[0]["supplierName"].ToString();
                }
                if (brandId != 0)
                {
                    Record = new SQL();
                    dt2 = new DataTable();
                    dt2 = Record.SELECT_STATEMENT("SELECT * FROM Brands where brandId = " + brandId);
                    lbl_p_brand.Text = dt2.Rows[0]["brandName"].ToString();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_product_id.Text == "")
            {
                MessageBox.Show("No product selected!");
            }
            else
            {
                Action_Security h = new Action_Security();
                h.lbl_product_id.Text = lbl_product_id.Text;
                h.lbl_product_name.Text = lbl_product_name.Text;
                h.lbl_confirmation_action.Text = "DELETE Confirmation of logged in user for:";
                h.MdiParent = MdiParent;
                h.Show();

                //Product_Detail h = new Product_Detail();
                //h.lbl_product_id.Text = lbl_product_id.Text;
                //h.MdiParent = MdiParent;
                //h.Show();

                this.Close();

                //DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Warning!", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    Record = new SQL();

                //    string delete_record = "DELETE FROM Products WHERE productId = " + Convert.ToInt32(lbl_product_id.Text);
                //    Record.CUD_STATEMENT(delete_record);
                //    loadRecords();
                //    MessageBox.Show("Product successfully deleted!");
                //    clearProductFields();

                //}
                //else if (dialogResult == DialogResult.No)
                //{
                //    //Do nothing
                //    //this.Close();
                //}
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lbl_product_id.Text == "")
            {
                MessageBox.Show("No product selected!");
            }
            else
            {
                Action_Security h = new Action_Security();
                h.lbl_product_id.Text = lbl_product_id.Text;
                h.lbl_product_name.Text = lbl_product_name.Text;
                h.lbl_confirmation_action.Text = "UPDATE Confirmation of logged in user for:";
                h.MdiParent = MdiParent;
                h.Show();

                //Product_Detail h = new Product_Detail();
                //h.lbl_product_id.Text = lbl_product_id.Text;
                //h.MdiParent = MdiParent;
                //h.Show();

                this.Close();
            }
        }

        private void dgv_chart_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dgv_chart.Rows[i];

                lbl_product_id.Text = row.Cells[0].Value.ToString();

                if (lbl_product_id.Text != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    dt = Record.SELECT_STATEMENT("SELECT prod.*, stock.quantity, stock.CREATE_DATE AS stock_as_of FROM Products prod " +
                    "LEFT JOIN ( " +
                    "SELECT ps.productId, SUM (ps.quantity) AS quantity, ps.CREATE_DATE FROM ProductStocks ps " +
                    "WHERE ps.CREATE_DATE = (SELECT TOP 1 CREATE_DATE FROM ProductStocks WHERE productId = ps.productId  ORDER BY CREATE_DATE ASC) " +
                    "GROUP BY ps.productId, ps.CREATE_DATE " +
                    ") stock ON prod.productId = stock.productId " +
                    "where prod.productId = " + Convert.ToInt32(lbl_product_id.Text) + " " +
                    "ORDER BY prod.CREATE_DATE ASC");

                    lbl_product_name.Text = dt.Rows[0]["productName"].ToString();
                    lbl_p_description.Text = dt.Rows[0]["productDescription"].ToString();
                    lbl_p_price.Text = dt.Rows[0]["productPrice"].ToString();
                    lbl_p_quantity.Text = dt.Rows[0]["productQty"].ToString();
                    lbl_p_SKU.Text = dt.Rows[0]["productSKU"].ToString();
                    lbl_p_availability.Text = dt.Rows[0]["productStatus"].ToString() == "1" ? "True" : "False";
                    brandId = Convert.ToInt32(dt.Rows[0]["brandId"].ToString());
                    supplierId = Convert.ToInt32(dt.Rows[0]["supplierId"].ToString());
                    lbl_deliveredDate.Text = Convert.ToDateTime(dt.Rows[0]["CREATE_DATE"].ToString()).ToShortDateString();
                    lbl_date_Stocks.Text = dt.Rows[0]["stock_as_of"].ToString();
                    lbl_latest_stock_added.Text = dt.Rows[0]["quantity"].ToString();
                    if (supplierId != 0)
                    {
                        Record = new SQL();
                        dt2 = new DataTable();
                        dt2 = Record.SELECT_STATEMENT("SELECT * FROM Suppliers where supplierId = " + supplierId);
                        lbl_p_supplier.Text = dt2.Rows[0]["supplierName"].ToString();
                    }
                    else
                    {
                        lbl_p_supplier.Text = "";
                    }
                    if (brandId != 0)
                    {
                        Record = new SQL();
                        dt2 = new DataTable();
                        dt2 = Record.SELECT_STATEMENT("SELECT * FROM Brands where brandId = " + brandId);
                        lbl_p_brand.Text = dt2.Rows[0]["brandName"].ToString();
                    }
                    else
                    {
                        lbl_p_brand.Text = "";
                    }
                }
                else
                {
                    clearProductFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("productName LIKE '%{0}%' OR productSKU LIKE '%{0}%'", txt_search.Text);
            dgv_chart.DataSource = dv;
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
            if (lbl_product_id.Text == "")
            {
                MessageBox.Show("No product selected!");
            }
            else
            {
                Product_Stock_In h = new Product_Stock_In();
                h.lbl_product_id.Text = lbl_product_id.Text;
                h.MdiParent = MdiParent;
                h.Show();

                this.Close();
            }
        }

        
    }
}
