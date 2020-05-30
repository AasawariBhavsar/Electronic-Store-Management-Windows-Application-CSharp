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
    public partial class Flash_form : Form
    {
        public Flash_form()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
                label1.Text = "Loading..";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form1 mf = new Form1();
                mf.Show();
            }
        }
    }
}
