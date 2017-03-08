namespace DevApp
{
    partial class Form1
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
            this.search_by_Product_NameToolStrip = new System.Windows.Forms.ToolStrip();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.search1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.productNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDatabaseDataSet = new DevApp.ClassDatabaseDataSet();
            this.personTableAdapter = new DevApp.ClassDatabaseDataSetTableAdapters.PersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.search1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.purposeDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_by_Product_NameToolStrip
            // 
            this.search_by_Product_NameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.search_by_Product_NameToolStrip.Name = "search_by_Product_NameToolStrip";
            this.search_by_Product_NameToolStrip.Size = new System.Drawing.Size(757, 25);
            this.search_by_Product_NameToolStrip.TabIndex = 1;
            this.search_by_Product_NameToolStrip.Text = "search_by_Product_NameToolStrip";
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Location = new System.Drawing.Point(0, 25);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(757, 25);
            this.searchToolStrip.TabIndex = 2;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // search1ToolStrip
            // 
            this.search1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productNameToolStripLabel,
            this.productNameToolStripTextBox,
            this.search1ToolStripButton});
            this.search1ToolStrip.Location = new System.Drawing.Point(0, 50);
            this.search1ToolStrip.Name = "search1ToolStrip";
            this.search1ToolStrip.Size = new System.Drawing.Size(757, 25);
            this.search1ToolStrip.TabIndex = 3;
            this.search1ToolStrip.Text = "search1ToolStrip";
            // 
            // productNameToolStripLabel
            // 
            this.productNameToolStripLabel.Name = "productNameToolStripLabel";
            this.productNameToolStripLabel.Size = new System.Drawing.Size(84, 22);
            this.productNameToolStripLabel.Text = "ProductName:";
            // 
            // productNameToolStripTextBox
            // 
            this.productNameToolStripTextBox.Name = "productNameToolStripTextBox";
            this.productNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search1ToolStripButton
            // 
            this.search1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search1ToolStripButton.Name = "search1ToolStripButton";
            this.search1ToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.search1ToolStripButton.Text = "Search";
            this.search1ToolStripButton.Click += new System.EventHandler(this.search1ToolStripButton_Click);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Your Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // purposeDataGridViewTextBoxColumn
            // 
            this.purposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose";
            this.purposeDataGridViewTextBoxColumn.HeaderText = "Purpose";
            this.purposeDataGridViewTextBoxColumn.Name = "purposeDataGridViewTextBoxColumn";
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.classDatabaseDataSet;
            // 
            // classDatabaseDataSet
            // 
            this.classDatabaseDataSet.DataSetName = "ClassDatabaseDataSet";
            this.classDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 391);
            this.Controls.Add(this.search1ToolStrip);
            this.Controls.Add(this.searchToolStrip);
            this.Controls.Add(this.search_by_Product_NameToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.search1ToolStrip.ResumeLayout(false);
            this.search1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ClassDatabaseDataSet classDatabaseDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ClassDatabaseDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip search_by_Product_NameToolStrip;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStrip search1ToolStrip;
        private System.Windows.Forms.ToolStripLabel productNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search1ToolStripButton;
    }
}