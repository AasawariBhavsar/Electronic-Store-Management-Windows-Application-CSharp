using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace electronicstore
{
    public partial class LoginForm : Form
    {
        db d = new db();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dt = d.getSingleRow("select * from tbl_user where username='" + textBox1.Text + "' and pass='" + textBox2.Text + "'");
            if (dt.Length > 0)
            {


                this.Hide();
                new Flash_form().Show();
            }

            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("ALL FIELDS ARE MANDATORY");
            }
            else
            {
                MessageBox.Show("Invalid usrername or password");
            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
