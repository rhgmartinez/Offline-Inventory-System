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
    public partial class Action_Security : Form
    {
        SQL Record;
        DataTable dt;
        string pWord = "";
        public Action_Security()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Product_List h = new Product_List();
            h.MdiParent = MdiParent;
            h.Show();
            this.Close();
        }

        private void Action_Security_Load(object sender, EventArgs e)
        {

            string mdiUserId = ((MDI)Application.OpenForms["MDI"]).ts_txtUserId.Text;//this.ParentForm.Controls["ts_txtUserId"].Text;
            Record = new SQL();
            dt = new DataTable();
            lbl_user_id.Text = mdiUserId;
            
            string query = ("SELECT * from Users WHERE userId=" + Convert.ToInt32(lbl_user_id.Text));
            dt = Record.SELECT_STATEMENT(query);

            tbUser.Text = dt.Rows[0]["userName"].ToString();
            pWord = dt.Rows[0]["userPassword"].ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == pWord)
            {
                if (lbl_confirmation_action.Text == "DELETE Confirmation of logged in user for:")
                {
                    DialogResult dialogResult = MessageBox.Show("Verified User! Are you sure you want to delete this product?", "Warning!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Record = new SQL();

                        string delete_record = "DELETE FROM Products WHERE productId = " + Convert.ToInt32(lbl_product_id.Text);
                        Record.CUD_STATEMENT(delete_record);
                        MessageBox.Show("Product successfully deleted!");
                        Product_List h = new Product_List();
                        h.MdiParent = MdiParent;
                        h.Show();
                        this.Close();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Note: Returning to Product List!");
                        Product_List h = new Product_List();
                        h.MdiParent = MdiParent;
                        h.Show();
                        this.Close();
                    }
                }
                else
                {
                    Product_Detail d = new Product_Detail();
                    d.lbl_product_id.Text = lbl_product_id.Text;
                    d.MdiParent = MdiParent;
                    d.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }
    }
}
