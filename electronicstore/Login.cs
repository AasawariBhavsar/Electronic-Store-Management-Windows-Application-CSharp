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
    public partial class Login : Form
    {
        db d = new db();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dt = d.getSingleRow("select * from tbl_user where username='"+ textBox1.Text +"' and pass='"+ textBox2.Text +"'");
            if (dt.Length > 0)
            {
                string[] dtar = dt.Split(':');
                if (dtar[1] == textBox1.Text && dtar[2] == textBox2.Text)
                {
                    label3.Text = "";
                    this.Hide();
                    new MDImain().Show();

                }
                else
                {
                    label3.Text = "Invalid usrername or password";
                }
            }
            else
            {
                label3.Text = "Invalid usrername or password";
            }
        }
    }
}
