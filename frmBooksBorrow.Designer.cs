namespace bookLibrary
{
    partial class frmBooksBorrow
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
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dtg_BlistOfBooks = new System.Windows.Forms.DataGridView();
            this.borrowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAccNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewUnReturnBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetViewUnReturn = new bookLibrary.DataSetViewUnReturn();
            this.viewUnReturnBookTableAdapter = new bookLibrary.DataSetViewUnReturnTableAdapters.viewUnReturnBookTableAdapter();
            this.btnReport = new System.Windows.Forms.Button();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BlistOfBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUnReturnBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetViewUnReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.btnReport);
            this.GroupBox6.Controls.Add(this.Label2);
            this.GroupBox6.Controls.Add(this.txt_Search);
            this.GroupBox6.Controls.Add(this.dtg_BlistOfBooks);
            this.GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(32, 73);
            this.GroupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox6.Size = new System.Drawing.Size(1092, 482);
            this.GroupBox6.TabIndex = 17;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "List Of Borrowed Books";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(11, 32);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 30);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Search :";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(116, 28);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(407, 36);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // dtg_BlistOfBooks
            // 
            this.dtg_BlistOfBooks.AllowUserToAddRows = false;
            this.dtg_BlistOfBooks.AllowUserToDeleteRows = false;
            this.dtg_BlistOfBooks.AllowUserToResizeColumns = false;
            this.dtg_BlistOfBooks.AllowUserToResizeRows = false;
            this.dtg_BlistOfBooks.AutoGenerateColumns = false;
            this.dtg_BlistOfBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_BlistOfBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_BlistOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BlistOfBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowIdDataGridViewTextBoxColumn,
            this.borrowDateDataGridViewTextBoxColumn,
            this.bookAccNoDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.borrowerIdDataGridViewTextBoxColumn,
            this.borrowerNameDataGridViewTextBoxColumn});
            this.dtg_BlistOfBooks.DataSource = this.viewUnReturnBookBindingSource;
            this.dtg_BlistOfBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_BlistOfBooks.Location = new System.Drawing.Point(8, 75);
            this.dtg_BlistOfBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_BlistOfBooks.Name = "dtg_BlistOfBooks";
            this.dtg_BlistOfBooks.ReadOnly = true;
            this.dtg_BlistOfBooks.RowHeadersVisible = false;
            this.dtg_BlistOfBooks.RowHeadersWidth = 51;
            this.dtg_BlistOfBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BlistOfBooks.Size = new System.Drawing.Size(1076, 400);
            this.dtg_BlistOfBooks.TabIndex = 0;
            // 
            // borrowIdDataGridViewTextBoxColumn
            // 
            this.borrowIdDataGridViewTextBoxColumn.DataPropertyName = "borrowId";
            this.borrowIdDataGridViewTextBoxColumn.HeaderText = "borrowId";
            this.borrowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowIdDataGridViewTextBoxColumn.Name = "borrowIdDataGridViewTextBoxColumn";
            this.borrowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowIdDataGridViewTextBoxColumn.Width = 108;
            // 
            // borrowDateDataGridViewTextBoxColumn
            // 
            this.borrowDateDataGridViewTextBoxColumn.DataPropertyName = "borrowDate";
            this.borrowDateDataGridViewTextBoxColumn.HeaderText = "borrowDate";
            this.borrowDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowDateDataGridViewTextBoxColumn.Name = "borrowDateDataGridViewTextBoxColumn";
            this.borrowDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowDateDataGridViewTextBoxColumn.Width = 129;
            // 
            // bookAccNoDataGridViewTextBoxColumn
            // 
            this.bookAccNoDataGridViewTextBoxColumn.DataPropertyName = "bookAccNo";
            this.bookAccNoDataGridViewTextBoxColumn.HeaderText = "bookAccNo";
            this.bookAccNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookAccNoDataGridViewTextBoxColumn.Name = "bookAccNoDataGridViewTextBoxColumn";
            this.bookAccNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookAccNoDataGridViewTextBoxColumn.Width = 127;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "bookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "bookTitle";
            this.bookTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowerIdDataGridViewTextBoxColumn
            // 
            this.borrowerIdDataGridViewTextBoxColumn.DataPropertyName = "borrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.HeaderText = "borrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerIdDataGridViewTextBoxColumn.Name = "borrowerIdDataGridViewTextBoxColumn";
            this.borrowerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowerIdDataGridViewTextBoxColumn.Width = 123;
            // 
            // borrowerNameDataGridViewTextBoxColumn
            // 
            this.borrowerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.borrowerNameDataGridViewTextBoxColumn.DataPropertyName = "borrowerName";
            this.borrowerNameDataGridViewTextBoxColumn.HeaderText = "borrowerName";
            this.borrowerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerNameDataGridViewTextBoxColumn.Name = "borrowerNameDataGridViewTextBoxColumn";
            this.borrowerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewUnReturnBookBindingSource
            // 
            this.viewUnReturnBookBindingSource.DataMember = "viewUnReturnBook";
            this.viewUnReturnBookBindingSource.DataSource = this.dataSetViewUnReturn;
            // 
            // dataSetViewUnReturn
            // 
            this.dataSetViewUnReturn.DataSetName = "DataSetViewUnReturn";
            this.dataSetViewUnReturn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUnReturnBookTableAdapter
            // 
            this.viewUnReturnBookTableAdapter.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(918, 26);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(157, 46);
            this.btnReport.TabIndex = 33;
            this.btnReport.Text = "Generate";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmBooksBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 628);
            this.Controls.Add(this.GroupBox6);
            this.Name = "frmBooksBorrow";
            this.Load += new System.EventHandler(this.frmBooksBorrow_Load);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BlistOfBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUnReturnBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetViewUnReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_Search;
        internal System.Windows.Forms.DataGridView dtg_BlistOfBooks;
        private DataSetViewUnReturn dataSetViewUnReturn;
        private System.Windows.Forms.BindingSource viewUnReturnBookBindingSource;
        private DataSetViewUnReturnTableAdapters.viewUnReturnBookTableAdapter viewUnReturnBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAccNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerNameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnReport;
    }
}