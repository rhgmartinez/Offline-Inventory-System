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
    public partial class Brand_Details : Form
    {
        SQL Record;
        DataTable dt;
        int brand_status, brandId;
        public Brand_Details()
        {
            InitializeComponent();
            dtp_date.Value = DateTime.Now;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            txt_name.MaxLength = 20;
            txt_description.MaxLength = 30;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //if (ValidateChildren(ValidationConstraints.Enabled) && lbl_brand_id.Text == "")
            if (txt_name.Text == "")
            {
                MessageBox.Show("Brand Name is empty!");
            }
            else
            {
                if (lbl_brand_id.Text == "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    int status = rb_active.Checked == true ? 1 : 0;

                    String insert_statement =
                        "INSERT INTO Brands(brandName, brandDescription, brandStatus, CREATE_DATE, LAST_UPDATE_DATE)"
                        + "VALUES('"
                        + txt_name.Text + "','"
                        + txt_description.Text + "',"
                        + status + ",'"
                        + DateTime.Now.ToShortDateString() + "','"
                        + DateTime.Now.ToShortDateString() + "')";

                    Record.CUD_STATEMENT(insert_statement);
                    MessageBox.Show("Brand Detail saved successfully!");
                    Record.close();
                    clearBrandFields();
                }
                //else if (ValidateChildren(ValidationConstraints.Enabled) && lbl_brand_id.Text != "")
                else if (lbl_brand_id.Text != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    int status = rb_active.Checked == true ? 1 : 0;
                    String update_statement = "UPDATE Brands set brandName = '" + txt_name.Text
                        + "', brandDescription = '" + txt_description.Text
                        + "', brandStatus = " + status
                        + ", LAST_UPDATE_DATE = '" + DateTime.Now.ToShortDateString()
                        + "' where brandId = " + Convert.ToInt32(lbl_brand_id.Text)
                        + "";

                    Record.CUD_STATEMENT(update_statement);
                    MessageBox.Show("Brand Detail updated successfully!");
                    Record.close();
                    clearBrandFields();
                }
                Brand_List h = new Brand_List();
                h.MdiParent = MdiParent;
                h.Show();

                this.Close();
            }   
        }

        public void clearBrandFields()
        {
            txt_name.Text = "";
            txt_description.Text = "";
            rb_active.Checked = true;
            rb_inactive.Checked = false;
            dtp_date.Value = DateTime.Now;
            lbl_brand_id.Text = "";
        }

        private void brands_validation(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_name.Text))
            //{
            //    e.Cancel = true;
            //    txt_name.Focus();
            //    errorProvider1.SetError(txt_name, "Please Enter Brand Name");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txt_name, null);
            //}
        }

        private void Brand_Details_Load(object sender, EventArgs e)
        {
            if (lbl_brand_id.Text == "")
            {
                clearBrandFields();
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();
                brandId = Convert.ToInt32(lbl_brand_id.Text);
                dt = Record.SELECT_STATEMENT("SELECT * FROM Brands where brandId=" + brandId);
                txt_name.Text = dt.Rows[0]["brandName"].ToString();
                txt_description.Text = dt.Rows[0]["brandDescription"].ToString();
                brand_status = Convert.ToInt32(dt.Rows[0]["brandStatus"].ToString());
                if (brand_status == 1)
                {
                    rb_active.Checked = true;
                    rb_inactive.Checked = false;
                }
                else
                {
                    rb_active.Checked = false;
                    rb_inactive.Checked = true;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
