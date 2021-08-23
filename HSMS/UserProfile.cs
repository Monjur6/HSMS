using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSMS
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MONJUR;Initial Catalog=OOP2DB;Integrated Security=True");
            conn.Open();
            string query = "select UserName,Name,WorkType,Workinghours,Salary from Workers";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            DataTable dt = ds.Tables[0];
            GridWorkersList.AutoGenerateColumns = false;
            GridWorkersList.DataSource = dt;
            GridWorkersList.Refresh();
        }

        private void GridWorkersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string username = GridWorkersList.Rows[e.RowIndex].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection("Data Source=MONJUR;Initial Catalog=OOP2DB;Integrated Security=True");
                conn.Open();
                string query = "select * from Workers where UserName='" + username+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter ok = new SqlDataAdapter(cmd);
                DataSet dp = new DataSet();
                ok.Fill(dp);
                DataTable dt = dp.Tables[0];
                txtWorkersUsername.Text = dt.Rows[0]["UserName"].ToString();
                txtWorkersName.Text = dt.Rows[0]["Name"].ToString();
                txtWorkersWorkType.Text = dt.Rows[0]["WorkType"].ToString();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected");
        }
    }
}
