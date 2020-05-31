using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Savy_App
{
    public partial class Supplier_Detail : Form
    {
        SQL Record;
        DataTable dt;
        int supplierStatus, supplierId, supplierType;

        public Supplier_Detail()
        {
            InitializeComponent();
            dtp_date.Value = DateTime.Now;
            txt_name.MaxLength = 30;
            txt_address.MaxLength = 30;
            txt_description.MaxLength = 30;
            txt_phone.MaxLength = 15;
            txt_contact_person.MaxLength = 30;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Empty required field/s");
            }
            else
            {
                //if (ValidateChildren(ValidationConstraints.Enabled) && lbl_supplier_id.Text == "")
                if (lbl_supplier_id.Text == "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    int status = rb_active.Checked == true ? 1 : 0;
                    int type = rb_store.Checked == true ? 1 : 0;

                    String insert_statement =
                        "INSERT INTO Suppliers(supplierName, supplierDescription, supplierStatus, supplierAddress, supplierType, supplierPhone, supplierContactPerson, CREATE_DATE, LAST_UPDATE_DATE)"
                        + "VALUES('"
                        + txt_name.Text + "','"
                        + txt_description.Text + "',"
                        + status + ",'"
                        + txt_address.Text + "',"
                        + type + ",'"
                        + txt_phone.Text + "','"
                        + txt_contact_person.Text + "','"
                        + DateTime.Now.ToShortDateString() + "','"
                        + DateTime.Now.ToShortDateString() + "')";

                    Record.CUD_STATEMENT(insert_statement);
                    MessageBox.Show("Supplier Detail saved successfully!");
                    Record.close();
                    clearSupplierFields();
                }
                //else if (ValidateChildren(ValidationConstraints.Enabled) && lbl_supplier_id.Text != "")
                else if (lbl_supplier_id.Text != "")
                {
                    Record = new SQL();
                    dt = new DataTable();
                    int status = rb_active.Checked == true ? 1 : 0;
                    int type = rb_store.Checked == true ? 1 : 0;
                    String update_statement = "UPDATE Suppliers set supplierName = '" + txt_name.Text
                        + "', supplierDescription = '" + txt_description.Text
                        + "', supplierAddress = '" + txt_address.Text
                        + "', supplierPhone = '" + txt_phone.Text
                        + "', supplierContactPerson = '" + txt_contact_person.Text
                        + "', supplierStatus = " + status
                        + ", supplierType = " + type
                        + ", LAST_UPDATE_DATE = '" + DateTime.Now.ToShortDateString()
                        + "' where supplierId = " + Convert.ToInt32(lbl_supplier_id.Text)
                        + "";

                    Record.CUD_STATEMENT(update_statement);
                    MessageBox.Show("Supplier Detail updated successfully!");
                    Record.close();
                    clearSupplierFields();
                }
            }
           
        }

        public void clearSupplierFields()
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_description.Text = "";
            txt_phone.Text = "";
            txt_contact_person.Text = "";
            rb_active.Checked = true;
            rb_inactive.Checked = false;
            rb_store.Checked = true;
            rb_person.Checked = false;
            dtp_date.Value = DateTime.Now;
            lbl_supplier_id.Text = "";
        }

        private void nameValidator(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_name.Text))
            //{
            //    e.Cancel = true;
            //    txt_name.Focus();
            //    nameError.SetError(txt_name, "Please Enter Supplier Name");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    nameError.SetError(txt_name, null);
            //}
        }

        private void addressValidator(object sender, CancelEventArgs e)
        {
            //if(string.IsNullOrEmpty(txt_address.Text))
            //{
            //    e.Cancel = true;
            //    addressError.SetError(txt_address, "Please Enter Address Name");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    addressError.SetError(txt_address, null);
            //}
        }

        private void Supplier_Detail_Load(object sender, EventArgs e)
        {
            if (lbl_supplier_id.Text == "")
            {
                clearSupplierFields();
            }
            else
            {
                Record = new SQL();
                dt = new DataTable();
                supplierId = Convert.ToInt32(lbl_supplier_id.Text);
                dt = Record.SELECT_STATEMENT("SELECT * FROM Suppliers where supplierId=" + supplierId);
                txt_name.Text = dt.Rows[0]["supplierName"].ToString();
                txt_address.Text = dt.Rows[0]["supplierAddress"].ToString();
                txt_description.Text = dt.Rows[0]["supplierDescription"].ToString();
                supplierStatus = Convert.ToInt32(dt.Rows[0]["supplierStatus"].ToString());
                supplierType = Convert.ToInt32(dt.Rows[0]["supplierType"].ToString());
                txt_phone.Text = dt.Rows[0]["supplierPhone"].ToString();
                txt_contact_person.Text = dt.Rows[0]["supplierContactPerson"].ToString();

                if (supplierStatus == 1)
                {
                    rb_active.Checked = true;
                    rb_inactive.Checked = false;
                }
                else
                {
                    rb_active.Checked = false;
                    rb_inactive.Checked = true;
                }

                if (supplierType == 1)
                {
                    rb_store.Checked = true;
                    rb_person.Checked = false;
                }
                else
                {
                    rb_store.Checked = false;
                    rb_person.Checked = true;
                }
            }
        }


        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_phone.Text, "  ^ [0-9]"))
            {
                txt_phone.Text = "";
            }
        }
    }
}
