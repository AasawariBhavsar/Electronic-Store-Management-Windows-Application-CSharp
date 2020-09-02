namespace electronicstore
{
    partial class PurchasePOS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dETAILSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stockidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWPRODUCTSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.electronicproductDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronicproductDataSet = new electronicstore.electronicproductDataSet();
            this.vIEWPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureshopDataSetFillProductsPos = new electronicstore.electronicstoreDataSetFillProductsPos();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEW_PRODUCTSTableAdapter = new electronicstore.furnitureshopDataSetFillProductsPosTableAdapters.VIEW_PRODUCTSTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vIEWPRODUCTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_PRODUCTSTableAdapter1 = new electronicstore.electronicproductDataSetTableAdapters.VIEW_PRODUCTSTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.tblcategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronicstoreDataSet = new electronicstore.electronicstoreDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tblcategoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.electshopfillbycategoryPurDataSet = new electronicstore.electshopfillbycategoryPurDataSet();
            this.tbl_categoryTableAdapter = new electronicstore.electshopfillbycategoryPurDataSetTableAdapters.tbl_categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureshopDataSetFillProductsPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electshopfillbycategoryPurDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODEDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.dETAILSDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dISCOUNTDataGridViewTextBoxColumn,
            this.iMAGEDataGridViewTextBoxColumn,
            this.stockidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vIEWPRODUCTSBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(874, 597);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // cODEDataGridViewTextBoxColumn
            // 
            this.cODEDataGridViewTextBoxColumn.DataPropertyName = "CODE";
            this.cODEDataGridViewTextBoxColumn.HeaderText = "CODE";
            this.cODEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cODEDataGridViewTextBoxColumn.Name = "cODEDataGridViewTextBoxColumn";
            this.cODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            this.cATEGORYDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTNAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCTNAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // dETAILSDataGridViewTextBoxColumn
            // 
            this.dETAILSDataGridViewTextBoxColumn.DataPropertyName = "DETAILS";
            this.dETAILSDataGridViewTextBoxColumn.HeaderText = "DETAILS";
            this.dETAILSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dETAILSDataGridViewTextBoxColumn.Name = "dETAILSDataGridViewTextBoxColumn";
            this.dETAILSDataGridViewTextBoxColumn.ReadOnly = true;
            this.dETAILSDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRICEDataGridViewTextBoxColumn.Width = 150;
            // 
            // dISCOUNTDataGridViewTextBoxColumn
            // 
            this.dISCOUNTDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT";
            this.dISCOUNTDataGridViewTextBoxColumn.HeaderText = "DISCOUNT";
            this.dISCOUNTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dISCOUNTDataGridViewTextBoxColumn.Name = "dISCOUNTDataGridViewTextBoxColumn";
            this.dISCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.dISCOUNTDataGridViewTextBoxColumn.Width = 150;
            // 
            // iMAGEDataGridViewTextBoxColumn
            // 
            this.iMAGEDataGridViewTextBoxColumn.DataPropertyName = "IMAGE";
            this.iMAGEDataGridViewTextBoxColumn.HeaderText = "IMAGE";
            this.iMAGEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iMAGEDataGridViewTextBoxColumn.Name = "iMAGEDataGridViewTextBoxColumn";
            this.iMAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iMAGEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iMAGEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iMAGEDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockidDataGridViewTextBoxColumn
            // 
            this.stockidDataGridViewTextBoxColumn.DataPropertyName = "stock_id";
            this.stockidDataGridViewTextBoxColumn.HeaderText = "STOCK ID";
            this.stockidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockidDataGridViewTextBoxColumn.Name = "stockidDataGridViewTextBoxColumn";
            this.stockidDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockidDataGridViewTextBoxColumn.Width = 150;
            // 
            // vIEWPRODUCTSBindingSource2
            // 
            this.vIEWPRODUCTSBindingSource2.DataMember = "VIEW_PRODUCTS";
            this.vIEWPRODUCTSBindingSource2.DataSource = this.electronicproductDataSetBindingSource;
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
            // vIEWPRODUCTSBindingSource
            // 
            this.vIEWPRODUCTSBindingSource.DataMember = "VIEW_PRODUCTS";
            this.vIEWPRODUCTSBindingSource.DataSource = this.furnitureshopDataSetFillProductsPos;
            // 
            // furnitureshopDataSetFillProductsPos
            // 
            this.furnitureshopDataSetFillProductsPos.DataSetName = "furnitureshopDataSetFillProductsPos";
            this.furnitureshopDataSetFillProductsPos.Namespace = "http://tempuri.org/furnitureshopDataSetFillProductsPos.xsd";
            this.furnitureshopDataSetFillProductsPos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.PRODUCTNAME,
            this.PRICE,
            this.QUANTITY,
            this.TOTAL});
            this.dataGridView2.Location = new System.Drawing.Point(1050, 59);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(845, 409);
            this.dataGridView2.TabIndex = 3;
            // 
            // CODE
            // 
            this.CODE.HeaderText = "CODE";
            this.CODE.MinimumWidth = 8;
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            this.CODE.Width = 150;
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.HeaderText = "PRODUCTNAME";
            this.PRODUCTNAME.MinimumWidth = 8;
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            this.PRODUCTNAME.ReadOnly = true;
            this.PRODUCTNAME.Width = 150;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 8;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 150;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.MinimumWidth = 8;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.Width = 150;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 8;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 150;
            // 
            // vIEW_PRODUCTSTableAdapter
            // 
            this.vIEW_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1045, 702);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMBER OF ITEMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1522, 702);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1340, 702);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1810, 702);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1568, 769);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "RESET BILL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1050, 759);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 80);
            this.button2.TabIndex = 9;
            this.button2.Text = "PAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1617, 494);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 35);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1617, 552);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 56);
            this.textBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1045, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "CUSTOMER NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1045, 552);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "SHIPPING ADDRESS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1617, 629);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 35);
            this.textBox4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1054, 617);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "PHONE NUMBER";
            // 
            // vIEWPRODUCTSBindingSource1
            // 
            this.vIEWPRODUCTSBindingSource1.DataMember = "VIEW_PRODUCTS";
            this.vIEWPRODUCTSBindingSource1.DataSource = this.electronicproductDataSet;
            // 
            // vIEW_PRODUCTSTableAdapter1
            // 
            this.vIEW_PRODUCTSTableAdapter1.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(860, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 46);
            this.label9.TabIndex = 16;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tblcategoryBindingSource1
            // 
            this.tblcategoryBindingSource1.DataMember = "tbl_category";
            // 
            // tblcategoryBindingSource
            // 
            this.tblcategoryBindingSource.DataMember = "tbl_category";
            this.tblcategoryBindingSource.DataSource = this.electronicstoreDataSet;
            // 
            // electronicstoreDataSet
            // 
            this.electronicstoreDataSet.DataSetName = "furnitureshopDataSet";
            this.electronicstoreDataSet.Namespace = "http://tempuri.org/furnitureshopDataSet.xsd";
            this.electronicstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "SELECT CATEGORY";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblcategoryBindingSource2;
            this.comboBox2.DisplayMember = "categoryname";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(334, 18);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(488, 33);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "categoryname";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tblcategoryBindingSource2
            // 
            this.tblcategoryBindingSource2.DataMember = "tbl_category";
            this.tblcategoryBindingSource2.DataSource = this.electshopfillbycategoryPurDataSet;
            // 
            // electshopfillbycategoryPurDataSet
            // 
            this.electshopfillbycategoryPurDataSet.DataSetName = "electshopfillbycategoryPurDataSet";
            this.electshopfillbycategoryPurDataSet.Namespace = "http://tempuri.org/electshopfillbycategoryPurDataSet.xsd";
            this.electshopfillbycategoryPurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_categoryTableAdapter
            // 
            this.tbl_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // PurchasePOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1395, 728);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PurchasePOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasePOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchasePOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicproductDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureshopDataSetFillProductsPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPRODUCTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcategoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electshopfillbycategoryPurDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private electronicstoreDataSetFillProductsPos furnitureshopDataSetFillProductsPos;
        private System.Windows.Forms.BindingSource vIEWPRODUCTSBindingSource;
        private furnitureshopDataSetFillProductsPosTableAdapters.VIEW_PRODUCTSTableAdapter vIEW_PRODUCTSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private electronicproductDataSet electronicproductDataSet;
        private System.Windows.Forms.BindingSource vIEWPRODUCTSBindingSource1;
        private electronicproductDataSetTableAdapters.VIEW_PRODUCTSTableAdapter vIEW_PRODUCTSTableAdapter1;
        private System.Windows.Forms.BindingSource vIEWPRODUCTSBindingSource2;
        private System.Windows.Forms.BindingSource electronicproductDataSetBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dETAILSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iMAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblcategoryBindingSource;
        private electronicstoreDataSet electronicstoreDataSet;
        
        private System.Windows.Forms.BindingSource tblcategoryBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private electshopfillbycategoryPurDataSet electshopfillbycategoryPurDataSet;
        private System.Windows.Forms.BindingSource tblcategoryBindingSource2;
        private electshopfillbycategoryPurDataSetTableAdapters.tbl_categoryTableAdapter tbl_categoryTableAdapter;
        
       
    }
}