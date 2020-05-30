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
    
    public partial class AddProduct : Form
    {
        db d = new db();
        public AddProduct()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            AutoScroll = true;
           
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elecshopfillbycatproductDataSet.tbl_category' table. You can move, or remove it, as needed.
            this.tbl_categoryTableAdapter2.Fill(this.elecshopfillbycatproductDataSet.tbl_category);
            // TODO: This line of code loads data into the 'electronicshopproductfillbycatDataSet.tbl_category' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'electronicshopfillbycategoryDataSet.tbl_category' table. You can move, or remove it, as needed.
            this.tbl_categoryTableAdapter1.Fill(this.electronicshopfillbycategoryDataSet.tbl_category);
            // TODO: This line of code loads data into the 'electronicproductDataSet.VIEW_PRODUCTS' table. You can move, or remove it, as needed.
            this.vIEW_PRODUCTSTableAdapter1.Fill(this.electronicproductDataSet.VIEW_PRODUCTS);
            // TODO: This line of code loads data into the 'furnitureshopDataSet.VIEW_PRODUCTS' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'furnitureshopDataSetViewProducts.VIEW_PRODUCTS' table. You can move, or remove it, as needed.
            this.vIEW_PRODUCTSTableAdapter.Fill(this.furnitureshopDataSetViewProducts.VIEW_PRODUCTS);
            
            // TODO: This line of code loads data into the 'furnitureshopDataSetDropFill.tbl_category' table. You can move, or remove it, as needed.
            

            ///////////////////////////////////////////////////
            //this.dataGridView1.RowTemplate.Height = 60;
            //this.imgurlDataGridViewTextBoxColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            ///////////////////////////////////////////////////
            // add it in design file


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap OriginalImage;
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Images";
            openFileDialog1.Filter = "JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName.ToString();
                OriginalImage = new Bitmap(openFileDialog1.FileName.ToString());
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pid = d.latestId("tbl_products", "pid");
             bool isPriceValid = Regex.IsMatch(textBox3.Text, "^[0-9]");
             bool isDiscountValid = Regex.IsMatch(textBox4.Text, "^[0-9]");
             bool isQuantityValid = Regex.IsMatch(textBox5.Text, "^[0-9]");
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || pictureBox1.Image==null)
            {
                MessageBox.Show("All Field are Mandatory");
            }
            else if (!isPriceValid || !isDiscountValid || !isQuantityValid) 
            {
                MessageBox.Show("Invalid Data");
            }
            else
            {
                pictureBox1.Image.Save(AppDomain.CurrentDomain.BaseDirectory + "images\\" + pid + ".jpg");
                string insqry = "insert into tbl_products values(" + pid + "," + comboBox1.SelectedValue + ",'" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ",'" + pid + ".jpg'," + textBox5.Text + ")";
                d.insertData(insqry);
                string stockquery = "insert into tbl_stock values(" + d.latestId("tbl_stock", "stock_id") + "," + pid + ",'" + textBox1.Text + "'," + textBox5.Text + ")";
                d.insertData(stockquery);
                MessageBox.Show("Product added successfully !!");
                AddProduct_Load(sender, e);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == 6)
            {
                //MessageBox.Show(e.DesiredType.ToString());
                Image image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images\\" + e.Value.ToString());
                //DataGridViewColumn column = dataGridView1.Columns[6];
                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //DataGridViewImageCell cc = new DataGridViewImageCell();
                //cc.ImageLayout = DataGridViewImageCellLayout.Zoom;
                //cc.Value = image;
                // ((Image)e) = image;
                e.Value = image;
                //AddProduct_Load(sender, e);
                //MessageBox.Show(e.Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vIEW_PRODUCTSTableAdapter1.FillByName(this.electronicproductDataSet.VIEW_PRODUCTS,comboBox2.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vIEWPRODUCTSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
