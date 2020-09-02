namespace electronicstore
{
    partial class stock
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vIEWPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronicproductDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronicproductDataSet = new electronicstore.electronicproductDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.electronicstoreDataSetFillProductsPos = new electronicstore.electronicstoreDataSetFillProductsPos();
            this.electronicstoreDataSetFillProductsPosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_PRODUCTSTableAdapter = new electronicstore.electronicproductDataSetTableAdapters.VIEW_PRODUCTSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblstockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.electronicstockDataSet = new electronicstore.electronicstockDataSet();
            this.tbl_stockTableAdapter1 = new electronicstore.electronicstockDataSetTableAdapters.tbl_stockTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetFillProductsPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetFillProductsPosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vIEWPRODUCTSBindingSource;
            this.comboBox1.DisplayMember = "PRODUCTNAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(439, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "CODE";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vIEWPRODUCTSBindingSource
            // 
            this.vIEWPRODUCTSBindingSource.DataMember = "VIEW_PRODUCTS";
            this.vIEWPRODUCTSBindingSource.DataSource = this.electronicproductDataSetBindingSource;
            // 
            // electronicproductDataSetBindingSource
            // 
            this.electronicproductDataSetBindingSource.DataSource = this.electronicproductDataSet;
            this.electronicproductDataSetBindingSource.Position = 0;
            // 
            // electronicproductDataSet
            // 
            this.electronicproductDataSet.DataSetName = "electronicproductDataSet";
            this.electronicproductDataSet.Namespace = "http://tempuri.org/electronicproductDataSet.xsd";
            this.electronicproductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEARCH PRODUCT";
            // 
            // electronicstoreDataSetFillProductsPos
            // 
            this.electronicstoreDataSetFillProductsPos.DataSetName = "furnitureshopDataSetFillProductsPos";
            this.electronicstoreDataSetFillProductsPos.Namespace = "http://tempuri.org/furnitureshopDataSetFillProductsPos.xsd";
            this.electronicstoreDataSetFillProductsPos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // electronicstoreDataSetFillProductsPosBindingSource
            // 
            this.electronicstoreDataSetFillProductsPosBindingSource.DataSource = this.electronicstoreDataSetFillProductsPos;
            this.electronicstoreDataSetFillProductsPosBindingSource.Position = 0;
            // 
            // vIEW_PRODUCTSTableAdapter
            // 
            this.vIEW_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockidDataGridViewTextBoxColumn,
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblstockBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(54, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(882, 403);
            this.dataGridView1.TabIndex = 2;
            // 
            // stockidDataGridViewTextBoxColumn
            // 
            this.stockidDataGridViewTextBoxColumn.DataPropertyName = "stock_id";
            this.stockidDataGridViewTextBoxColumn.HeaderText = "STOCK ID";
            this.stockidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockidDataGridViewTextBoxColumn.Name = "stockidDataGridViewTextBoxColumn";
            this.stockidDataGridViewTextBoxColumn.Width = 150;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "PRODUCT ID";
            this.prodidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.Width = 150;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "PRODUCT NAME";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblstockBindingSource1
            // 
            this.tblstockBindingSource1.DataMember = "tbl_stock";
            this.tblstockBindingSource1.DataSource = this.electronicstockDataSet;
            // 
            // electronicstockDataSet
            // 
            this.electronicstockDataSet.DataSetName = "electronicstockDataSet";
            this.electronicstockDataSet.Namespace = "http://tempuri.org/electronicstockDataSet.xsd";
            this.electronicstockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_stockTableAdapter1
            // 
            this.tbl_stockTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(874, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetFillProductsPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSetFillProductsPosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstockDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource electronicproductDataSetBindingSource;
        private electronicproductDataSet electronicproductDataSet;
        private electronicstoreDataSetFillProductsPos electronicstoreDataSetFillProductsPos;
        private System.Windows.Forms.BindingSource electronicstoreDataSetFillProductsPosBindingSource;
        private System.Windows.Forms.BindingSource vIEWPRODUCTSBindingSource;
        private electronicproductDataSetTableAdapters.VIEW_PRODUCTSTableAdapter vIEW_PRODUCTSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        
       
        private electronicstockDataSet electronicstockDataSet;
        private System.Windows.Forms.BindingSource tblstockBindingSource1;
        private electronicstockDataSetTableAdapters.tbl_stockTableAdapter tbl_stockTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}