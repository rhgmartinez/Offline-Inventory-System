using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace Savy_App
{
    class SQL
    {
        public SqlConnection con;
        private DataTable dataTable = new DataTable();
        public SQL()
        {
            con = new SqlConnection("server=DESKTOP-EFOV730;database=SavyPOS_DB;Integrated Security=True;user id=sa; password=admin1234");
        }
        //Close the connection to avoid timeout error which would result to system-paused since the connection is already open.
        public void close()
        {
            con.Close();
        }
        //Fetch
        public DataTable SELECT_STATEMENT(String query)
        {
            con.Open();
            SqlCommand cmnd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmnd);
            adp.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        //Create Update Delete
        public void CUD_STATEMENT(String query)
        {
            con.Open();
            SqlCommand cmnd = new SqlCommand(query, con);
            cmnd.ExecuteNonQuery();
            con.Close();
        }
    }
}
