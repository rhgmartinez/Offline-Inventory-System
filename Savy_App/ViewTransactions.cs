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
    public partial class ViewTransactions : Form
    {
        SQL Record, Record2;
        DataTable dt, dt2;
        public ViewTransactions()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadRecords()
        {
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT REPLICATE('0',6-LEN(RTRIM(p.paymentId))) + RTRIM(p.paymentId) AS paymentId, t.transactionId, t.transactionDate, t.isDeleted, t.totalAmount, t.isPaid, p.CREATE_DATE, p.LAST_UPDATE_DATE FROM Transactions t JOIN Payment p ON t.transactionId = p.transactionId WHERE t.isDeleted <> 1");

            dataGridView2.DataSource = dt;

            dataGridView2.Columns[0].HeaderText = "Receipt Number";
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].HeaderText = "Date";
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].HeaderText = "Total Amount";
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;

            if(dt.Rows.Count > 0){
                label1.Text = dt.Rows[0]["transactionId"].ToString();
            }
            
        }

        public void clearFields()
        {
            label1.Text = "";
        }
        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            clearFields();
            loadRecords();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dataGridView2.Rows[i];

                label1.Text = row.Cells[0].Value.ToString(); //dt.Rows[i]["transactionId"].ToString();

                Record2 = new SQL();
                dt2 = new DataTable();
                dt2 = Record2.SELECT_STATEMENT("SELECT tp.* FROM TransactionProducts tp JOIN Payment p ON tp.transactionId = p.transactionId WHERE (tp.qtyReturned IS NULL OR (tp.qtyReturned IS NOT NULL AND tp.qtyReturned < tp.quantity)) AND paymentId = " + Convert.ToInt32(label1.Text));
                if (dt2.Rows.Count > 0)
                {
                    button2.Visible = true;
                }
                else
                {
                    button2.Visible = false;
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
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("paymentId = {0}", Convert.ToInt32(txt_search.Text));
                dataGridView2.DataSource = dv;
            }
            else
            {
                dataGridView2.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                
                showReport();
            }
        }
        //public void showReport2()
        //{
        //    ReportDocument cryRpt = new ReportDocument();
        //    TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
        //    TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
        //    ConnectionInfo crConnectionInfo = new ConnectionInfo();
        //    Tables CrTables;

        //    cryRpt.Load("~" + "\\" + "Savy_App" + "\\" + "Invoice.rpt");

        //    crConnectionInfo.ServerName = "DESKTOP-EFOV730";
        //    crConnectionInfo.DatabaseName = "SavyPOS_DB";
        //    crConnectionInfo.UserID = "sa";
        //    crConnectionInfo.Password = "admin1234";
        //    //cryRpt.SetParameterValue("transId", label1.Text);

        //    CrTables = cryRpt.Database.Tables;
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

        //    //crParameterDiscreteValue.Value = label1.Text;
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
                                    "REPLICATE('0',6-LEN(RTRIM([paymentId]))) + RTRIM([paymentId]) AS paymentId, " +
                                    "[transactionId] " +
                                    "FROM [SavyPOS_DB].[dbo].[Invoice] " +
                                    "WHERE paymentId = " + Convert.ToInt32(label1.Text);

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con);

            adp.Fill(ds, "PaymentReceipt");
            DataTable dt = ds.Tables["PaymentReceipt"];

            r.SetDataSource(ds.Tables["PaymentReceipt"]);
            crv_1.ReportSource = r;
            crv_1.Refresh();
        }

        public void showReport3()
        {
            Invoice2 r = new Invoice2();
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
                                    "REPLICATE('0',6-LEN(RTRIM([paymentId]))) + RTRIM([paymentId]) AS paymentId, " +
                                    "[transactionId] " +
                                    "FROM [SavyPOS_DB].[dbo].[Invoice] " +
                                    "WHERE transactionId = " + Convert.ToInt32(label1.Text);

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con);

            adp.Fill(ds, "Invoice");
            DataTable dt = ds.Tables["Invoice"];

            r.SetDataSource(ds.Tables["Invoice"]);
            crv_1.ReportSource = r;
            crv_1.Refresh();
        }

        public void showReport4()
        {
            Invoice r = new Invoice();
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
                                    "REPLICATE('0',6-LEN(RTRIM([paymentId]))) + RTRIM([paymentId]) AS paymentId, " +
                                    "[transactionId] " +
                                    "FROM [SavyPOS_DB].[dbo].[Invoice] ";

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con);

            adp.Fill(ds, "Invoice");
            DataTable dt = ds.Tables["Invoice"];

            r.SetDataSource(ds.Tables["Invoice"]);
            crv_1.ReportSource = r;
            crv_1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("No Receipt Number is selected!");
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();


                ReturnProducts h = new ReturnProducts();
                h.label1.Text = label1.Text;
                h.MdiParent = MdiParent;

                h.Show();
                this.Close();

            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                showReport3();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                showReport4();
            }
        }

        
    }
}
