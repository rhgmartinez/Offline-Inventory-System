using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
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
    public partial class Reports : Form
    {
        SQL Record, Record2;
        DataTable dt, dt2;
        public Reports()
        {
            InitializeComponent();
            dtp_sdate.Value = DateTime.Now;
            dtp_edate.Value = DateTime.Now;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Record = new SQL();
            string sDate = dtp_sdate.Value.ToShortDateString();
            string eDate = dtp_edate.Value.ToShortDateString();
            if(cmb_brand.Text == ""){

            }
            else
            {
                if (cmb_brand.Text == "Invoice")
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
                                            "[paymentId], " +
                                            "[transactionId] " +
                                            "FROM [SavyPOS_DB].[dbo].[Invoice] " +
                                            " WHERE CREATE_DATE >= '" + sDate + "'" +
                                            " AND CREATE_DATE <= '" + eDate + "' ORDER BY [CREATE_DATE] DESC, [productName] ASC";
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con);

                    adp.Fill(ds, "Invoice");
                    DataTable dt = ds.Tables["Invoice"];

                    r.SetDataSource(ds.Tables["Invoice"]);
                    crv_1.ReportSource = r;
                    crv_1.Refresh();
                }
                else if (cmb_brand.Text == "Inventory")
                {
                    Inventory r = new Inventory();
                    Record.con.ConnectionString = ConfigurationManager.ConnectionStrings["Savy_App.Properties.Settings.SavyPOS_DBConnectionString"].ToString();
                    string select_statement = "SELECT " +
                                               " productId," +
                                               " productName," +
                                               " productDescription," +
                                               " productStatus," +
                                               " productSKU," +
                                               " productPrice," +
                                               " productQty," +
                                               " brandName," +
                                               " brandId," +
                                               " Convert(VARCHAR, LAST_UPDATE_DATE,  101) AS LAST_UPDATE_DATE," +
                                               " Convert(VARCHAR, CREATE_DATE,  101) AS CREATE_DATE" +
                                               " FROM Inventory" +
                                               " WHERE CREATE_DATE >= '" + sDate +"'" +
                                               " AND CREATE_DATE <= '" + eDate + "' ORDER BY CREATE_DATE DESC, brandName ASC, productName ASC";

                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con);

                    adp.Fill(ds, "Inventory");
                    DataTable dt = ds.Tables["Inventory"];

                    r.SetDataSource(ds.Tables["Inventory"]);
                    crv_1.ReportSource = r;
                    crv_1.Refresh();
                }
                else if (cmb_brand.Text == "Delivery")
                {
                    Deliveries r = new Deliveries();
                    Record.con.ConnectionString = ConfigurationManager.ConnectionStrings["Savy_App.Properties.Settings.SavyPOS_DBConnectionString"].ToString();
                    string select_statement = "SELECT " +
                                               " productId," +
                                               " productName," +
                                               " productDescription," +
                                               " productStatus," +
                                               " productSKU," +
                                               " productPrice," +
                                               " productQty," +
                                               " deliveredQty," +
                                               " brandName," +
                                               " brandId," +
                                               " deliveredQty," +
                                               " Convert(VARCHAR, LAST_UPDATE_DATE,  101) AS LAST_UPDATE_DATE," +
                                               " Convert(VARCHAR, CREATE_DATE,  101) AS CREATE_DATE" +
                                               " FROM Deliveries" +
                                               " WHERE CREATE_DATE >= '" + sDate + "'" +
                                               " AND CREATE_DATE <= '" + eDate + "' ORDER BY CREATE_DATE DESC, brandName ASC, productName ASC";

                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con);

                    adp.Fill(ds, "Deliveries");
                    DataTable dt = ds.Tables["Deliveries"];

                    r.SetDataSource(ds.Tables["Deliveries"]);
                    crv_1.ReportSource = r;
                    crv_1.Refresh();
                }
                else if (cmb_brand.Text == "Sales")
                {
                    Sales r = new Sales();
                    Record.con.ConnectionString = ConfigurationManager.ConnectionStrings["Savy_App.Properties.Settings.SavyPOS_DBConnectionString"].ToString();
                    string select_statement = "SELECT [brandName]," +
                                                "       [paymentId]," +
                                                "       [productName]," +
                                                "       [deliveredQty]," +
                                                "       [discountedPrice]," +
                                                "       [quantity]," +
                                                "       [isReturned]," +
                                                "       [qtyReturned]," +
                                                "       [CREATE_DATE]," +
                                                "       [totalAmount]" +
                                                "  FROM [SavyPOS_DB].[dbo].[Sales]" +
                                               " WHERE [CREATE_DATE] >= '" + sDate + "'" +
                                               " AND [CREATE_DATE] <= '" + eDate + "' ORDER BY [CREATE_DATE] DESC, [brandName] ASC, [productName] ASC";

                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(select_statement, Record.con);

                    adp.Fill(ds, "Sales");
                    DataTable dt = ds.Tables["Sales"];

                    r.SetDataSource(ds.Tables["Sales"]);
                    crv_1.ReportSource = r;
                    crv_1.Refresh();
                }
            }
        }
    }
}
