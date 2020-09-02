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

    public partial class PrintBill : Form
    {
        // printing form https://www.youtube.com/watch?v=cFvo48Ix_Xc
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
        int nXDest, int nYDest, int nWidth, int nHeight,
        IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        Bitmap bmp;
        string billid;
        db d = new db();
        public PrintBill()
        {
            InitializeComponent();
        }
        public PrintBill(string billid)
        {
            InitializeComponent();
            this.billid = billid;
        }

        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height,
            mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(
            memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
            this.ClientRectangle.Height, dc1, 0, 0,
            13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furnitureshopDataSetViewBill.VIEW_BILL' table. You can move, or remove it, as needed.
            this.vIEW_BILLTableAdapter.Fill(this.furnitureshopDataSetViewBill.VIEW_BILL,Convert.ToInt32(billid));
            string[] data = d.getSingleRow("select * from tbl_bill where billid = " + billid).Split(':');
            label4.Text = billid;
            //label5.Text =  Convert.ToDateTime(data[2].ToString()).ToShortDateString();
            label5.Text = data[2].ToString();
            label7.Text = data[1];
            label9.Text = d.getSingleRow("select sum(total) from tbl_bill_items where billid = " + billid).Split(':')[0];
        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawImage(bmp, 0, 0);
        //}

        

        //private void printPreviewDialog1_Load(object sender, EventArgs e)
        //{

        //}

        private void PrintBill_Shown(object sender, EventArgs e)
        {


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
            this.Close();
            
        }
    }
}
