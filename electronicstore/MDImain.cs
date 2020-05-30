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
    public partial class MDImain : Form
    {
        private int childFormNumber = 0;

        public MDImain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.MdiParent = this;
            ac.StartPosition = FormStartPosition.Manual;
            ac.Location = new Point(Location.X + (Width - ac.Width) / 2, Location.Y + (Height - ac.Height) / 2);
            ac.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            AddProduct ac = new AddProduct();
            ac.MdiParent = this;
            ac.WindowState = FormWindowState.Maximized;
            //ac.StartPosition = FormStartPosition.CenterParent;
            //ac.StartPosition = FormStartPosition.Manual;
            //ac.Location = new Point(Location.X + (Width - ac.Width) / 2, Location.Y + (Height - ac.Height) / 2);
            ac.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasePOS ac = new PurchasePOS();
            ac.MdiParent = this;
            ac.WindowState = FormWindowState.Maximized;
            ac.Show();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string billid = Microsoft.VisualBasic.Interaction.InputBox("ENTER BILL ID", "BILL MAKER", "1");
            (new PrintBill(billid)).Show();
           
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }
    }
}
