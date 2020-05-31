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
    public partial class ReturnProducts : Form
    {
        SQL Record;
        DataTable dt;
        int prodq = 0;
        public ReturnProducts()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to return product: " + txt_product.Text + "?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Record = new SQL();

                    String update_trans_statement = "UPDATE TransactionProducts SET isReturned=1," + "qtyReturned = "+ Convert.ToInt32(textBox1.Text)+","+" LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE transProdId=" + Convert.ToInt32(label2.Text) + "";
                    Record.CUD_STATEMENT(update_trans_statement);

                    String update_prod_statement = "UPDATE Products SET productQty = productQty + " + Convert.ToInt32(textBox1.Text) + "," + " LAST_UPDATE_DATE='" + DateTime.Now.ToShortDateString() + "' WHERE productId=" + Convert.ToInt32(label4.Text) + "";
                    Record.CUD_STATEMENT(update_prod_statement);

                    MessageBox.Show("Product Selected returned successfully!");
                    Record.close();
                    label2.Text = "";
                    txt_product.Text = "";
                    loadRecords();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //Do nothing
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("No product selected!");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadRecords()
        {
            Record = new SQL();
            dt = new DataTable();
            dt = Record.SELECT_STATEMENT("SELECT p.productName,tp.* FROM TransactionProducts tp LEFT JOIN Products p ON tp.productId = p.productId WHERE (tp.isReturned=0 OR tp.isReturned IS NULL) AND tp.transactionId = " + Convert.ToInt32(label1.Text));

            dataGridView2.DataSource = dt;

            dataGridView2.Columns[0].HeaderText = "Product Name";
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].HeaderText = "Original Price";
            dataGridView2.Columns[6].HeaderText = "Discounted Price";
            dataGridView2.Columns[7].HeaderText = "Quantity";
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].HeaderText = "Returned Item";
            dataGridView2.Columns[10].Visible = false;
            dataGridView2.Columns[11].Visible = false;
        }

        private void ReturnProducts_Load(object sender, EventArgs e)
        {
            loadRecords();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                int i = e.RowIndex;//get the Row Index             
                DataGridViewRow row = dataGridView2.Rows[i];

                txt_product.Text = dt.Rows[0]["productName"].ToString();
                //textBox1.Text = dt.Rows[0]["quantity"].ToString();
                prodq = Convert.ToInt32(dt.Rows[0]["quantity"].ToString());
                label2.Text = dt.Rows[0]["transProdId"].ToString();
                label4.Text = dt.Rows[0]["productId"].ToString();
            }
            else
            {
                //Do Nothing if somebody clicked the header (just to catch the error of this part)
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                if (prodq < Convert.ToInt32(textBox1.Text) || Convert.ToInt32(textBox1.Text) < 1)
                {
                    textBox1.Text = "";
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
