using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Web;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Savy_App
{
    public partial class Payment : Form
    {
        SQL Record;
        DataTable dt;
        int paid = 0;
        SQL Record2;
        DataTable dt1, dt2, dt3;
        string lbl_product_id = "", lbl_cart_id = "";
        int count = 0;
        int rowIndex = -1;
        int discount_type = 0;
        float total_amount = 0;
        public Payment()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text != "" && paid == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel your transaction?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Record = new SQL();

                    String update_trans_statement = "UPDATE Transactions SET isDeleted=1, LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE transactionId=" + Convert.ToInt32(txt_Id.Text) + "";
                    Record.CUD_STATEMENT(update_trans_statement);

                    MessageBox.Show("Transaction is cancelled!");
                    Record.close();
                    this.Close();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //Do nothing
                    //this.Close();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this window?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Do nothing
                    //this.Close();
                }
            }
            
        }
        public void loadRecords()
        {
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT p.ProductName, tp.* FROM TransactionProducts tp LEFT JOIN Transactions t ON t.transactionId = tp.transactionId LEFT JOIN Products p ON p.productId = tp.productId WHERE t.isDeleted = 0 AND t.transactionId="+ Convert.ToInt32(txt_Id.Text) +"");
            dtg_products.DataSource = dt;
            txt_change.Text = "0.00";

            dtg_products.Columns[0].HeaderText = "Product Name";
            dtg_products.Columns[1].Visible = false;
            dtg_products.Columns[2].Visible = false;
            dtg_products.Columns[3].Visible = false;
            dtg_products.Columns[4].Visible = false;
            dtg_products.Columns[5].HeaderText = "Original Price";
            dtg_products.Columns[6].HeaderText = "Discounted Price";
            dtg_products.Columns[7].HeaderText = "Quantity";
            dtg_products.Columns[8].Visible = false;
            dtg_products.Columns[9].HeaderText = "Returned Item";
            dtg_products.Columns[10].Visible = false;
            dtg_products.Columns[11].Visible = false;

            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT * FROM Transactions where isPaid = 0 AND transactionId = " + Convert.ToInt32(txt_Id.Text));
            txt_transnum.Text = dt.Rows[0]["transactionId"].ToString();
            txt_totalamount.Text = dt.Rows[0]["totalAmount"].ToString();
            panel3.Enabled = false;
            panel4.Enabled = false;

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            clearFields();
            loadRecords2();
        }

        public void loadRecords2()
        {
            Record2 = new SQL();
            dt1 = new DataTable();
            dt1 = Record2.SELECT_STATEMENT("SELECT * FROM Products WHERE productQty > 0 ORDER BY CREATE_DATE ASC");

            dtg_products.DataSource = dt1;

            dtg_products.Columns[0].Visible = false;
            dtg_products.Columns[1].HeaderText = "Product Name";
            dtg_products.Columns[2].Visible = false;
            dtg_products.Columns[3].Visible = false;
            dtg_products.Columns[4].Visible = false;
            dtg_products.Columns[5].HeaderText = "Price";
            dtg_products.Columns[6].Visible = false;
            dtg_products.Columns[7].Visible = false;
            dtg_products.Columns[8].Visible = false;
            dtg_products.Columns[9].Visible = false;
            dtg_products.Columns[10].Visible = false;
            dtg_products.Columns[11].Visible = false;
            dtg_products.Columns[12].Visible = false;

            dt3 = new DataTable();
            dt3.Columns.Add("Product");
            dt3.Columns.Add("Price");
            dt3.Columns.Add("Stock");
            dt3.Columns.Add("Qty");
            dt3.Columns.Add("Discount Type");
            dt3.Columns.Add("Discount");
            dt3.Columns.Add("Id");
            dt3.Columns.Add("discount_type");
            dtg_cart.DataSource = dt3;
            dtg_cart.Columns[2].Visible = false;
            dtg_cart.Columns[6].Visible = false;
            dtg_cart.Columns[7].Visible = false;

            if (dt1.Rows.Count > 0)
            {
                textBox1.Text = dt1.Rows[0]["productId"].ToString();
                txt_product.Text = dt1.Rows[0]["productName"].ToString();
                txt_stock.Text = dt1.Rows[0]["productQty"].ToString();
                txt_price.Text = dt1.Rows[0]["productPrice"].ToString();
            }
        }
        private void btn_savetransaction_Click(object sender, EventArgs e)
        {
            if (txt_payment.Text != "" && float.Parse(txt_payment.Text) >= float.Parse(txt_totalamount.Text))
            {
                Record = new SQL();
                String insert_statement =
                    "INSERT INTO Payment(transactionId, totalAmount, amountPaid, change, CREATE_DATE, LAST_UPDATE_DATE)"
                    + "VALUES("
                    + txt_Id.Text + ","
                    + txt_totalamount.Text + ","
                    + txt_payment.Text + ","
                    + txt_change.Text + ",'"
                    + DateTime.Now.ToShortDateString() + "','"
                    + DateTime.Now.ToShortDateString() + "')";

                Record.CUD_STATEMENT(insert_statement);

                String update_trans_statement = "UPDATE Transactions SET isPaid=1, LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE transactionId=" + Convert.ToInt32(txt_Id.Text) + "";
                Record.CUD_STATEMENT(update_trans_statement);

                int temp = (dtg_products.RowCount);
                for (int i = 0; i < temp; i++)
                {
                    string productId = dtg_products[2, i].Value.ToString();
                    string productQty = dtg_products[7, i].Value.ToString();

                    String update_prod_statement = "UPDATE Products SET productQty = (productQty -" + Convert.ToInt32(productQty) + "),LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE productId=" + Convert.ToInt32(productId) + "";
                    Record.CUD_STATEMENT(update_prod_statement);
                }

                MessageBox.Show("Payment saved successfully, Stocks for the following products in this transaction are also updated!");
                Record.close();
                paid = 1;
                txt_payment.Enabled = false;
                btn_clear.Enabled = false;
                btn_savetransaction.Enabled = false;
                dtg_products.Enabled = false;
                showReport();
            }
            else
            {
                MessageBox.Show("Payment is less than Total Amount for this transaction!");
            }
            
        }

        private void txt_payment_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_payment.Text, "  ^ [0-9]"))
            {
                txt_payment.Text = "";
                txt_change.Text = "0.00";
            }
            else
            {
                if (txt_totalamount.Text != "" && txt_payment.Text!= "")
                {
                    float diff = float.Parse(txt_payment.Text) - float.Parse(txt_totalamount.Text);
                    if (diff < 0)
                    {
                        txt_change.Text = "0.00";
                    }
                    else
                    {
                        txt_change.Text = diff.ToString();
                    }
                }
            }
        }
        //public void showReport2()
        //{
        //    ReportDocument cryRpt = new ReportDocument();
        //    TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
        //    TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
        //    ConnectionInfo crConnectionInfo = new ConnectionInfo();
        //    Tables CrTables ;

        //    cryRpt.Load("D:" + "\\" + "OfflineInventory-system-repo" + "\\" + "Savy_App" + "\\" + "Invoice.rpt");

        //    crConnectionInfo.ServerName = "DESKTOP-EFOV730";
        //    crConnectionInfo.DatabaseName = "SavyPOS_DB";
        //    crConnectionInfo.UserID = "sa";
        //    crConnectionInfo.Password = "admin1234";
        //    //crConnectionInfo.IntegratedSecurity = true;
        //    //cryRpt.SetParameterValue("transId", txt_Id.Text);

        //    CrTables = cryRpt.Database.Tables ;
        //    foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
        //    {
        //        crtableLogoninfo = CrTable.LogOnInfo;
        //        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
        //        CrTable.ApplyLogOnInfo(crtableLogoninfo);
        //    }


        //    //ParameterFieldDefinitions crParameterFieldDefinitions;
        //    //ParameterFieldDefinition crParameterFieldDefinition;
        //    //ParameterValues crParameterValues = new ParameterValues();
        //    //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

        //    //crParameterDiscreteValue.Value = txt_Id.Text;
        //    //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
        //    //crParameterFieldDefinition = crParameterFieldDefinitions["transId"];
        //    //crParameterValues = crParameterFieldDefinition.CurrentValues;

        //    //crParameterValues.Clear();
        //    //crParameterValues.Add(crParameterDiscreteValue);
        //    //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
        //    //cryRpt.SetDataSource(CrTables);
  
        //    crv_1.ReportSource = cryRpt;
        //    crv_1.Refresh(); 
        //}

        public void showReport()
        {
            PaymentReceipt r = new PaymentReceipt();
            Record.con.ConnectionString = ConfigurationManager.ConnectionStrings["Savy_App.Properties.Settings.SavyPOS_DBConnectionString"].ToString();
            string select_statement = "SELECT " +
                                    "[productName]," +
                                    "CASE WHEN isPercent = 1 THEN CONVERT(VARCHAR,[discount])+'%' " +
	                                "     WHEN isPercent = 0 THEN N'₱ ' + CONVERT(VARCHAR,[discount]) " +
	                                "     WHEN isPercent = -1 THEN '' " +
	                                "     END AS discount, " +
                                    "N'₱ '+ CONVERT(VARCHAR,[originalPrice]) AS originalPrice, " +
                                    "N'₱ '+ CONVERT(VARCHAR,[discountedPrice]) AS discountedPrice, " +
                                    "[quantity], " +
                                    "N'₱ '+ CONVERT(VARCHAR,[totalAmount]) AS totalAmount, " +
                                    "[isPaid], " +
                                    "N'₱ '+ CONVERT(VARCHAR,[amountPaid]) AS amountPaid, " +
                                    "N'₱ '+ CONVERT(VARCHAR,[change]) AS change, " +
                                    "[CREATE_DATE], " +
                                    "[paymentId], " +
                                    "[transactionId] " +
                                    "FROM [SavyPOS_DB].[dbo].[Invoice] " +
                                    "WHERE transactionId = " + Convert.ToInt32(txt_Id.Text); 

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con );

            adp.Fill(ds, "PaymentReceipt");
            DataTable dt = ds.Tables["PaymentReceipt"];

            r.SetDataSource(ds.Tables["PaymentReceipt"]);
            crv_1.ReportSource = r;
            crv_1.Refresh();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel your transaction?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Record = new SQL();

                    String update_trans_statement = "UPDATE Transactions SET isDeleted=1, LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE transactionId=" + Convert.ToInt32(txt_Id.Text) + "";
                    Record.CUD_STATEMENT(update_trans_statement);

                    MessageBox.Show("Transaction is cancelled!");
                    Record.close();

                    Payment t = new Payment();
                    t.MdiParent = MdiParent;
                    t.Show();

                    this.Close();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //Do nothing
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("Empty transaction!");
            }
        }

        private void dtg_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dtg_products.Rows[i];

                //txt_Id.Text = row.Cells[0].Value.ToString();
                txt_Id.Text = dt.Rows[0]["transactionId"].ToString();

                if (txt_Id.Text != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    dt = Record.SELECT_STATEMENT("SELECT * FROM Transactions where isPaid = 0 AND transactionId = " + Convert.ToInt32(txt_Id.Text));
                    txt_transnum.Text = dt.Rows[0]["transactionId"].ToString();
                    txt_totalamount.Text = dt.Rows[0]["totalAmount"].ToString();
                    btn_savetransaction.Enabled = true;
                    btn_clear.Enabled = true;
                }
                else
                {
                    clearFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }
        public void clearFields()
        {
            txt_transnum.Text = "";
            txt_Id.Text = "";
            txt_totalamount.Text = "";
            txt_payment.Text = "";
            txt_change.Text = "";
        }

        private void txt_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string discount_type_word = "None";
            if (discount_type == 0)
            {
                discount_type_word = "₱";
            }
            else if (discount_type == 1)
            {
                discount_type_word = "%";
            }

            if (textBox1.Text != "" && txt_qty.Text != "")
            {
                if (count <= 100)
                {
                    if (radioButton1.Checked == false && txt_discount.Text != "")
                    {
                        count = count + 1;
                        btn_savetransaction.Enabled = true;
                        btn_clear.Enabled = true;
                        //dtg_cart.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_discount.Text, txt_qty.Text, textBox1.Text);
                        foreach (DataGridViewRow row in this.dtg_cart.Rows)
                        {
                            if (row.Cells[6].Value.ToString().Equals(textBox1.Text))
                            {
                                rowIndex = row.Index;
                                //this.dt.Rows.RemoveAt(rowIndex);
                            }
                        }
                        dt3.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_qty.Text, discount_type_word, txt_discount.Text, textBox1.Text, discount_type);
                        if (discount_type == 0)
                        {
                            discount_type_word = "₱";
                            total_amount += ((float.Parse(txt_price.Text) * Convert.ToInt32(txt_qty.Text)) - float.Parse(txt_discount.Text));
                        }
                        else if (discount_type == 1)
                        {
                            discount_type_word = "%";
                            total_amount += (float.Parse(txt_price.Text) * Convert.ToInt32(txt_qty.Text)) - ((float.Parse(txt_discount.Text)/100)*float.Parse(txt_price.Text));
                        }

                        //if (rowIndex == -1)
                        //{
                        //    dt3.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_qty.Text, discount_type_word, txt_discount.Text, textBox1.Text, discount_type);
                        //    total_amount += (float.Parse(txt_price.Text) * Convert.ToInt32(txt_qty.Text));
                        //}
                        //else
                        //{
                        //    rowIndex = -1;
                        //    MessageBox.Show("Product already exists in your cart.");
                        //}
                        clearFields();
                    }
                    else if (radioButton1.Checked == true)
                    {
                        count = count + 1;
                        btn_savetransaction.Enabled = true;
                        btn_clear.Enabled = true;
                        //dtg_cart.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_discount.Text, txt_qty.Text, textBox1.Text);
                        foreach (DataGridViewRow row in this.dtg_cart.Rows)
                        {
                            if (row.Cells[6].Value.ToString().Equals(textBox1.Text))
                            {
                                rowIndex = row.Index;
                                //this.dt.Rows.RemoveAt(rowIndex);
                            }
                        }
                        dt3.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_qty.Text, discount_type_word, 0, textBox1.Text, discount_type);
                        total_amount += (float.Parse(txt_price.Text) * Convert.ToInt32(txt_qty.Text));
                        //if (rowIndex == -1)
                        //{
                        //    dt3.Rows.Add(txt_product.Text, txt_price.Text, txt_stock.Text, txt_qty.Text, discount_type_word, 0, textBox1.Text, discount_type);
                        //    total_amount += (float.Parse(txt_price.Text) * Convert.ToInt32(txt_qty.Text));
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Product already exists in your cart.");
                        //}
                        clearFields();

                    }
                    lbl_totalamount.Text = total_amount.ToString();
                }
                else
                {
                    MessageBox.Show("Cart is full! Cart is limited to 100 products only.");
                }


            }
            else
            {
                MessageBox.Show("Incomplete Information.");
            }
        }

        private void rb_peso_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_peso.Checked == true)
            {
                rb_percent.Checked = false;
                radioButton1.Checked = false;
                txt_discount.Enabled = true;
                discount_type = 0;
            }
        }

        private void rb_percent_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_percent.Checked == true)
            {
                radioButton1.Checked = false;
                rb_peso.Checked = false;
                txt_discount.Enabled = true;
                discount_type = 1;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                rb_percent.Checked = false;
                rb_peso.Checked = false;
                txt_discount.Enabled = false;
                discount_type = -1;
                txt_discount.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("You cart is empty!");
            }
            else
            {
                Record2 = new SQL();
                dt1 = new DataTable();

                String insert_statement =
                    "INSERT INTO Transactions(transactionDate, isDeleted, totalAmount, isPaid, CREATE_DATE, LAST_UPDATE_DATE)"
                    + "VALUES('"
                    + DateTime.Now.ToShortDateString() + "', 0, 0, 0,'"
                    + DateTime.Now.ToShortDateString() + "','"
                    + DateTime.Now.ToShortDateString() + "')";

                Record2.CUD_STATEMENT(insert_statement);
                MessageBox.Show("Transaction created successfully!");

                string test = "SELECT TOP 1 * from Transactions WHERE isPaid = 0 and isDeleted = 0 ORDER BY CONVERT(DATETIME,CREATE_DATE,20) DESC";
                dt2 = Record2.SELECT_STATEMENT(test);

                string transactionId = dt2.Rows[0]["transactionId"].ToString();
                int tran_id = Convert.ToInt32(transactionId);
                float totalAmount = 0;

                int temp = (dtg_cart.RowCount);
                for (int i = 0; i < temp; i++)
                {
                    string productName = (string)dtg_cart[0, i].Value;
                    string productPrice = (string)dtg_cart[1, i].Value;
                    string productStock = (string)dtg_cart[2, i].Value;
                    string productQty = (string)dtg_cart[3, i].Value;
                    string productDiscountType = (string)dtg_cart[7, i].Value;
                    string productDiscount = (string)dtg_cart[5, i].Value;
                    string productId = (string)dtg_cart[6, i].Value;
                    float discountedPrice = 0;
                    if (productDiscountType != "-1")
                    {
                        if (productDiscountType == "0")
                        {
                            discountedPrice = (float.Parse(productQty) * (float.Parse(productPrice)) - float.Parse(productDiscount));

                        }
                        else if (productDiscountType == "1")
                        {
                            discountedPrice = float.Parse(productQty) * (float.Parse(productPrice) * ((100 - float.Parse(productDiscount)) / 100));
                        }
                    }
                    else
                    {
                        discountedPrice = 0;
                    }

                    totalAmount = totalAmount + discountedPrice;

                    String insert_prod_transaction =
                        "INSERT INTO TransactionProducts(productId, discount, isPercent, originalPrice, discountedPrice, quantity, transactionId, CREATE_DATE, LAST_UPDATE_DATE)"
                        + "VALUES("
                        + Convert.ToInt32(productId) + ", "
                        + float.Parse(productDiscount) + ","
                        + Convert.ToInt32(productDiscountType) + ","
                        + float.Parse(productPrice) + ","
                        + discountedPrice + ","
                        + Convert.ToInt32(productQty) + ","
                        + tran_id + ",'"
                        + DateTime.Now.ToShortDateString() + "','"
                        + DateTime.Now.ToShortDateString() + "')";

                    Record.CUD_STATEMENT(insert_prod_transaction);
                }

                String update_trans_statement = "UPDATE Transactions SET totalAmount=" + totalAmount + ",LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE transactionId=" + tran_id + "";
                Record.CUD_STATEMENT(update_trans_statement);

                panel1.Enabled = true;
                txt_Id.Text = tran_id.ToString();

                //totalAmount = 0;
                //count = 0;
                //clearCart();
                loadRecords();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear you cart?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    count = 0;
                    btn_savetransaction.Enabled = false;
                    btn_clear.Enabled = false;
                    lbl_totalamount.Text = "0";
                    clearCart();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //Do nothing
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("You cart is empty!");
            }
        }

        public void clearCart()
        {
            lbl_totalamount.Text = "0";
            total_amount = 0;
            loadRecords2();

            //dtg_cart.Columns[0].HeaderText = "Product Name";
            //dtg_cart.Columns[1].HeaderText = "Price";
            //dtg_cart.Columns[2].HeaderText = "Stock";
            //dtg_cart.Columns[3].HeaderText = "Qty";
            //dtg_cart.Columns[4].HeaderText = "Discount Type";
            //dtg_cart.Columns[5].HeaderText = "Discount";
            //dtg_cart.Columns[2].Visible = false;
            //dtg_cart.Columns[6].Visible = false;
            //dtg_cart.Columns[7].Visible = false;
        }

        private void dtg_cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dtg_cart.Rows[i];

                lbl_cart_id = row.Cells[0].Value.ToString();

                if (lbl_cart_id != "")
                {
                    Record = new SQL();
                    dt1 = new DataTable();
                    //dt = Record.SELECT_STATEMENT("SELECT * FROM Products where productId = " + Convert.ToInt32(lbl_product_id));
                    //txt_product.Text = dt.Rows[0]["productName"].ToString();
                    //txt_stock.Text = dt.Rows[0]["productQty"].ToString();
                    //txt_price.Text = dt.Rows[0]["productPrice"].ToString();
                }
                else
                {
                    clearFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }

        private void dtg_products_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dtg_products.Rows[i];

                lbl_product_id = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[0].Value.ToString();

                if (lbl_product_id != "")
                {
                    Record = new SQL();
                    dt1 = new DataTable();
                    dt1 = Record.SELECT_STATEMENT("SELECT * FROM Products where productStatus = 1 AND productId = " + Convert.ToInt32(lbl_product_id));
                    txt_product.Text = dt1.Rows[0]["productName"].ToString();
                    txt_stock.Text = dt1.Rows[0]["productQty"].ToString();
                    txt_price.Text = dt1.Rows[0]["productPrice"].ToString();
                }
                else
                {
                    clearFields();
                }

            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                DataView dv = new DataView(dt1);
                dv.RowFilter = string.Format("productName LIKE '%{0}%' OR productSKU LIKE '%{0}%'", txt_search.Text);
                dtg_products.DataSource = dv;
            }
            else
            {
                Record2 = new SQL();
                dt1 = new DataTable();
                dt1 = Record2.SELECT_STATEMENT("SELECT * FROM Products WHERE productQty > 0");

                dtg_products.DataSource = dt1;

                dtg_products.Columns[0].Visible = false;
                dtg_products.Columns[1].HeaderText = "Product Name";
                dtg_products.Columns[2].Visible = false;
                dtg_products.Columns[3].Visible = false;
                dtg_products.Columns[4].Visible = false;
                dtg_products.Columns[5].HeaderText = "Price";
                dtg_products.Columns[6].Visible = false;
                dtg_products.Columns[7].Visible = false;
                dtg_products.Columns[8].Visible = false;
                dtg_products.Columns[9].Visible = false;
                dtg_products.Columns[10].HeaderText = "Delivery Date";
                dtg_products.Columns[11].Visible = false;
                dtg_products.Columns[12].Visible = false;

                if (dt1.Rows.Count > 0)
                {
                    textBox1.Text = dt1.Rows[0]["productId"].ToString();
                    txt_product.Text = dt1.Rows[0]["productName"].ToString();
                    txt_stock.Text = dt1.Rows[0]["productQty"].ToString();
                    txt_price.Text = dt1.Rows[0]["productPrice"].ToString();
                }
            }
        }
    }
}
