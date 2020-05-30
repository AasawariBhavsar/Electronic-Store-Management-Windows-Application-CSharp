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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            
        }

        private void stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electronicstockDataSet.tbl_stock' table. You can move, or remove it, as needed.
            this.tbl_stockTableAdapter1.Fill(this.electronicstockDataSet.tbl_stock);
            // TODO: This line of code loads data into the 'furnitureshopDataSet.tbl_stock' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'electronicproductDataSet.VIEW_PRODUCTS' table. You can move, or remove it, as needed.
            this.vIEW_PRODUCTSTableAdapter.Fill(this.electronicproductDataSet.VIEW_PRODUCTS);

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbl_stockTableAdapter1.FillByID(this.electronicstockDataSet.tbl_stock,Convert.ToInt32(comboBox1.SelectedValue));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
