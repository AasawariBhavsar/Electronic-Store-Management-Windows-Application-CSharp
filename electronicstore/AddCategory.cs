using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions; 
namespace electronicstore
{
    
    public partial class AddCategory : Form
    {
        db d = new db();
        public AddCategory()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furnitureshopDataSet.tbl_category' table. You can move, or remove it, as needed.
            this.tbl_categoryTableAdapter.Fill(this.furnitureshopDataSet.tbl_category);

        }

        private void button1_Click(object sender, EventArgs e)
        { 
           bool isNameValid = Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]");
            if(textBox1.Text=="")
            {
                MessageBox.Show("Fields are Mandatory");
            }
            else if(d.checkAvailablity("tbl_category","categoryname", textBox1.Text))
            {
                MessageBox.Show("Category already exist ...");
            }
            else if (!isNameValid) 
            {
                MessageBox.Show("Invalid Category Name");
            }
            else
            {
                d.insertData("insert into tbl_category values(" + d.latestId("tbl_category", "cat_id") + ",'" + textBox1.Text + "')");
                AddCategory_Load(sender, e);
                MessageBox.Show("Category added successfully !!");
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.tbl_categoryTableAdapter.Update(this.furnitureshopDataSet.tbl_category);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.tbl_categoryTableAdapter.Update(this.furnitureshopDataSet.tbl_category);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbl_categoryTableAdapter.Update(this.furnitureshopDataSet.tbl_category);
        }

       
    }
}
