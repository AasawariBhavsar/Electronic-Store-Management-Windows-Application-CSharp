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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
          
            ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProduct ac = new AddProduct();
            ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchasePOS ac = new PurchasePOS();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string billid = Microsoft.VisualBasic.Interaction.InputBox("ENTER BILL ID", "BILL MAKER", "1");
            (new PrintBill(billid)).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stock ac = new stock();
            ac.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
