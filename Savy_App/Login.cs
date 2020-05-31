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
    public partial class Login : Form
    {
        SQL Record;
        public Login()
        {
            InitializeComponent();
            Record = new SQL();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string query = ("SELECT * from Users WHERE userName = '" + tbUser.Text + "' and userPassword = '" + tbPass.Text + "'");
            DataTable dt = new DataTable();
            dt = Record.SELECT_STATEMENT(query);

            if (dt.Rows.Count > 0)
            {
                string username = dt.Rows[0]["userName"].ToString();
                string password = dt.Rows[0]["userPassword"].ToString();

                //MessageBox.Show("Welcome! ", "POS Application System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MDI mainForm = new MDI();
                mainForm.ts_txtUserId.Text = dt.Rows[0]["userId"].ToString();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password.", "Incorrect Login Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
