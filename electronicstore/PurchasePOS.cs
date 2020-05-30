using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Windows.Forms;

namespace electronicstore
{
    public partial class PurchasePOS : Form
    {
        db d = new db();
        int stockid;
        int qty;
        public PurchasePOS()
        {
            InitializeComponent();
            
            
        }

        private void PurchasePOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electshopfillbycategoryPurDataSet.tbl_category' table. You can move, or remove it, as needed.
            this.tbl_categoryTableAdapter.Fill(this.electshopfillbycategoryPurDataSet.tbl_category);
            // TODO: This line of code loads data into the 'electronicshopcategoryDataSet.tbl_category' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'electronicsearchcatDataSet.tbl_category' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'electronicproductDataSet.VIEW_PRODUCTS' table. You can move, or remove it, as needed.
            this.vIEW_PRODUCTSTableAdapter1.Fill(this.electronicproductDataSet.VIEW_PRODUCTS);
            // TODO: This line of code loads data into the 'furnitureshopDataSetFillProductsPos.VIEW_PRODUCTS' table. You can move, or remove it, as needed.
            this.vIEW_PRODUCTSTableAdapter.Fill(this.furnitureshopDataSetFillProductsPos.VIEW_PRODUCTS);
            label5.Text = totalBill().ToString();
            label4.Text = totalItems().ToString();


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 6)
            {
                Image image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images\\" + e.Value.ToString());
                e.Value = image;
            }
        }

      

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            qty = Convert.ToInt32( Microsoft.VisualBasic.Interaction.InputBox("ENTER QUANTITY", "NUMBER OF PRODUCTS WANT TO PURCHASE", "1"));
            int pid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            stockid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            string productname = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int tot = price * qty;
            if (checkProductInBill(pid.ToString()))
            {
                MessageBox.Show("Product already in list");
            }
            else
            {
                dataGridView2.Rows.Add(pid, productname, price, qty, tot);
                label5.Text = totalBill().ToString();
                label4.Text = totalItems().ToString();
            }
        }
        public bool checkProductInBill(string pid)
        {
            bool flag = false;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString().Equals(pid))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public int totalBill()
        {
            int x = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                x += Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }
            return x;
        }
        public int totalItems()
        {
            int x = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                x += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value.ToString());
            }
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            label5.Text = totalBill().ToString();
            label4.Text = totalItems().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isNameValid = Regex.IsMatch(textBox2.Text, "^[a-zA-Z ]");
            if (dataGridView2.Rows.Count == 0 || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("FILL MANDATORY FIELDS");
            }
                else if(textBox4.Text.Length!=10)
            {
                MessageBox.Show("PLEASE ENTER 10 DIGIT PHONE NUM");
                }
            else if (!isNameValid)
            {
                MessageBox.Show("Invalid Name");
            }
            else
            {
                
                string billid = d.latestId("tbl_bill", "billid");
                string custdetails = textBox2.Text+" ,";
                custdetails += textBox3.Text+" ,";
                custdetails += textBox4.Text;
                d.insertData("insert into tbl_bill values("+ billid +",'"+ custdetails +"',GETDATE())");
                string updateqry = "update tbl_stock set Quantity=Quantity-"+qty+" where stock_id="+stockid+"";
                d.updateData(updateqry);
                
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    string lineitemid = d.latestId("tbl_bill_items", "id");
                    string pid = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    string quantity = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    string tot = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    d.insertData("insert into tbl_bill_items values(" + lineitemid + "," + billid + "," + pid + "," + quantity + "," + tot + ")");
                }

                dataGridView2.Rows.Clear();
                label5.Text = totalBill().ToString();
                label4.Text = totalItems().ToString();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("BILL GENERATED WITH BILL ID " + billid);
               
                this.Close();
                (new PrintBill(billid)).Show();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vIEW_PRODUCTSTableAdapter1.FillByName(this.electronicproductDataSet.VIEW_PRODUCTS,comboBox2.Text);
        }


    }
}
