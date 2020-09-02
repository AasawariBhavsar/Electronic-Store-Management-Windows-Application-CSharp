namespace electronicstore
{
    partial class print_bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print_bill));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.electronicstoreDataSetViewBill = new electronicstore.electronicstoreDataSetViewBill();
            this.electronicstoreDataSetViewBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWBILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetViewBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWBILLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sKUDataGridViewTextBoxColumn,
            this.pRODUCTDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.billidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vIEWBILLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 179);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(819, 431);
            this.dataGridView1.TabIndex = 2;
            // 
            // electronicstoreDataSetViewBill
            // 
            this.electronicstoreDataSetViewBill.DataSetName = "furnitureshopDataSetViewBill";
            this.electronicstoreDataSetViewBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // electronicstoreDataSetViewBillBindingSource
            // 
            this.electronicstoreDataSetViewBillBindingSource.DataSource = this.electronicstoreDataSetViewBill;
            this.electronicstoreDataSetViewBillBindingSource.Position = 0;
            // 
            // vIEWBILLBindingSource
            // 
            this.vIEWBILLBindingSource.DataMember = "VIEW_BILL";
            this.vIEWBILLBindingSource.DataSource = this.electronicstoreDataSetViewBillBindingSource;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTDataGridViewTextBoxColumn
            // 
            this.pRODUCTDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT";
            this.pRODUCTDataGridViewTextBoxColumn.HeaderText = "PRODUCT";
            this.pRODUCTDataGridViewTextBoxColumn.Name = "pRODUCTDataGridViewTextBoxColumn";
            this.pRODUCTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            this.qUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billidDataGridViewTextBoxColumn
            // 
            this.billidDataGridViewTextBoxColumn.DataPropertyName = "billid";
            this.billidDataGridViewTextBoxColumn.HeaderText = "billid";
            this.billidDataGridViewTextBoxColumn.Name = "billidDataGridViewTextBoxColumn";
            this.billidDataGridViewTextBoxColumn.ReadOnly = true;
            this.billidDataGridViewTextBoxColumn.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // print_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "print_bill";
            this.Text = "print_bill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetViewBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWBILLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource electronicstoreDataSetViewBillBindingSource;
        private electronicstoreDataSetViewBill electronicstoreDataSetViewBill;
        private System.Windows.Forms.BindingSource vIEWBILLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
    }
}