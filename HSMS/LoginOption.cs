using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSMS
{
    public partial class LoginOption : Form
    {
        public LoginOption()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin kl = new UserLogin();
            kl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Workerslogin jk = new Workerslogin();
            jk.Show();
            this.Hide();
        }
    }
}
