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
    public partial class login2 : Form
    {
        public login2()
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
    }
}
