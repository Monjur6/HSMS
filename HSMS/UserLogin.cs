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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {
            UserRegistration op = new UserRegistration();
            op.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginOption hm = new LoginOption();
            hm.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("User Name or Password Missing.");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MONJUR;Initial Catalog=OOP2DB;Integrated Security=True");
                string query = "select UserName,Password from [User] where UserName ='" + textBox1.Text.Trim() + "' and Password ='" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    UserProfile wk = new UserProfile();
                    wk.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home j = new Home();
            j.Show();
            this.Hide();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
