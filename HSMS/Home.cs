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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option op = new Option();
            op.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginOption lg = new LoginOption();
            lg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Whatweoffer wwo = new Whatweoffer();
            wwo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WhyUs wu = new WhyUs();
            wu.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContactUS cu = new ContactUS();
            cu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application Exit!", "Are you sure want to exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
