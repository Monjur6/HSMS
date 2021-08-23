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
    public partial class WorkersRegistration : Form
    {
        public WorkersRegistration()
        {
            InitializeComponent();
        }

        private void comboHours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option op = new Option();
            op.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, name, email, gender = " ", password, worktype=" ", workinghours=" ", salary, address, question = " ", answer;
            DateTime dob = Convert.ToDateTime(dateTimePicker1.Text);
            long nid, phone;
            username = textBox1.Text;
            name = textBox2.Text;
            nid = Convert.ToInt64(textBox3.Text);
            email = textBox4.Text;
            phone = Convert.ToInt64(textBox5.Text);
            password = textBox6.Text;
            worktype = comboWorkType.SelectedItem.ToString();
            workinghours = comboHours.SelectedItem.ToString();
            salary = textBox7.Text;
            address = richTextBox1.Text;
            question = comboQuestion.SelectedItem.ToString();
            answer = textBox7.Text;
            if (radioBtnMale.Checked)
            {
                gender = "Male";
            }
            else if (radioBtnFemale.Checked)
            {
                gender = "Female";
            }
            else if (radioBtnOthers.Checked)
            {
                gender = "Others";
            }
            else
            {
                gender = "Gender is not selected";
            }
            SqlConnection conn = new SqlConnection(@"Data Source=MONJUR;Initial Catalog=OOP2DB;Integrated Security=True");
            conn.Open();
            string query = "insert into Workers (UserName,Name,DateOfBirth,NID,Email,Gender,Phone,Password,WorkType,Workinghours,Salary,Address,Question,Answer) VALUES ('" + username + "','" + name + "','" + dob + "','" + nid + "','" + email + "','" + gender + "','" + phone + "','" + password + "','" + worktype + "','" + workinghours + "','" + salary + "','" + address + "','" + question + "','" + answer + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Succesfully registered");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Workerslogin lg = new Workerslogin();
            lg.Show();
            this.Hide();
        }

        private void WorkersRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
