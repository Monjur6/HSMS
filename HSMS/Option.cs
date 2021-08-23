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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkersRegistration wr = new WorkersRegistration();
            wr.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistration ur = new UserRegistration();
            ur.Show();
            this.Hide();
        }
    }
}
