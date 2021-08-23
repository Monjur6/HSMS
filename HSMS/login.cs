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
    public partial class login : Form
    {
        //private string uname = "monjur";
        //private string password = "123";
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //if (uname == textBox1.Text && password == textBox2.Text)
            //{
            //    MessageBox.Show("Successful Login");
            //    Home obj = new Home();
            //    obj.Show();
            //    this.Hide();
            //}
            //else
            //    MessageBox.Show("Invalid password or user name ....");
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("User Name or Password Missing.");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MONJUR;Initial Catalog=OOP2DB;Integrated Security=True");
                string query="select UserName,Password from Workers where UserName ='" + textBox1.Text.Trim() + "' and Password ='" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                    WorkerProfile wk = new WorkerProfile();
                    wk.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WorkersRegistration op = new WorkersRegistration();
            op.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Hide Password";
                textBox2.PasswordChar = '\0';
                //textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                checkBox1.Text = "Show Password";
                textBox2.PasswordChar = '*';
                //textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
