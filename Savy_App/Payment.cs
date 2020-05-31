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

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            loadRecords();
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

                    Transaction t = new Transaction();
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

    }
}
