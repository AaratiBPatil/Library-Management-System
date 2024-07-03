namespace bookLibrary
{
    partial class returnedBooks
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
            this.dtgListreturned = new System.Windows.Forms.DataGridView();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtrbooksSearch = new System.Windows.Forms.TextBox();
            this.dataSetViewUnReturn = new bookLibrary.DataSetViewUnReturn();
            this.viewUnReturnBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewUnReturnBookTableAdapter = new bookLibrary.DataSetViewUnReturnTableAdapters.viewUnReturnBookTableAdapter();
            this.borrowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAccNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetViewUnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUnReturnBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListreturned
            // 
            this.dtgListreturned.AllowUserToAddRows = false;
            this.dtgListreturned.AllowUserToDeleteRows = false;
            this.dtgListreturned.AllowUserToResizeColumns = false;
            this.dtgListreturned.AllowUserToResizeRows = false;
            this.dtgListreturned.AutoGenerateColumns = false;
            this.dtgListreturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgListreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListreturned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowIdDataGridViewTextBoxColumn,
            this.borrowDateDataGridViewTextBoxColumn,
            this.bookAccNoDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.borrowerIdDataGridViewTextBoxColumn,
            this.borrowerNameDataGridViewTextBoxColumn});
            this.dtgListreturned.DataSource = this.viewUnReturnBookBindingSource;
            this.dtgListreturned.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgListreturned.Location = new System.Drawing.Point(13, 83);
            this.dtgListreturned.Margin = new System.Windows.Forms.Padding(4);
            this.dtgListreturned.Name = "dtgListreturned";
            this.dtgListreturned.RowHeadersVisible = false;
            this.dtgListreturned.RowHeadersWidth = 51;
            this.dtgListreturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListreturned.Size = new System.Drawing.Size(1059, 501);
            this.dtgListreturned.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(27, 29);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(107, 29);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Search :";
            // 
            // txtrbooksSearch
            // 
            this.txtrbooksSearch.BackColor = System.Drawing.Color.White;
            this.txtrbooksSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrbooksSearch.Location = new System.Drawing.Point(149, 23);
            this.txtrbooksSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtrbooksSearch.Name = "txtrbooksSearch";
            this.txtrbooksSearch.Size = new System.Drawing.Size(392, 36);
            this.txtrbooksSearch.TabIndex = 3;
            // 
            // dataSetViewUnReturn
            // 
            this.dataSetViewUnReturn.DataSetName = "DataSetViewUnReturn";
            this.dataSetViewUnReturn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUnReturnBookBindingSource
            // 
            this.viewUnReturnBookBindingSource.DataMember = "viewUnReturnBook";
            this.viewUnReturnBookBindingSource.DataSource = this.dataSetViewUnReturn;
            // 
            // viewUnReturnBookTableAdapter
            // 
            this.viewUnReturnBookTableAdapter.ClearBeforeFill = true;
            // 
            // borrowIdDataGridViewTextBoxColumn
            // 
            this.borrowIdDataGridViewTextBoxColumn.DataPropertyName = "borrowId";
            this.borrowIdDataGridViewTextBoxColumn.HeaderText = "borrowId";
            this.borrowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowIdDataGridViewTextBoxColumn.Name = "borrowIdDataGridViewTextBoxColumn";
            this.borrowIdDataGridViewTextBoxColumn.Width = 88;
            // 
            // borrowDateDataGridViewTextBoxColumn
            // 
            this.borrowDateDataGridViewTextBoxColumn.DataPropertyName = "borrowDate";
            this.borrowDateDataGridViewTextBoxColumn.HeaderText = "borrowDate";
            this.borrowDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowDateDataGridViewTextBoxColumn.Name = "borrowDateDataGridViewTextBoxColumn";
            this.borrowDateDataGridViewTextBoxColumn.Width = 106;
            // 
            // bookAccNoDataGridViewTextBoxColumn
            // 
            this.bookAccNoDataGridViewTextBoxColumn.DataPropertyName = "bookAccNo";
            this.bookAccNoDataGridViewTextBoxColumn.HeaderText = "bookAccNo";
            this.bookAccNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookAccNoDataGridViewTextBoxColumn.Name = "bookAccNoDataGridViewTextBoxColumn";
            this.bookAccNoDataGridViewTextBoxColumn.Width = 108;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "bookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "bookTitle";
            this.bookTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            // 
            // borrowerIdDataGridViewTextBoxColumn
            // 
            this.borrowerIdDataGridViewTextBoxColumn.DataPropertyName = "borrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.HeaderText = "borrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerIdDataGridViewTextBoxColumn.Name = "borrowerIdDataGridViewTextBoxColumn";
            // 
            // borrowerNameDataGridViewTextBoxColumn
            // 
            this.borrowerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.borrowerNameDataGridViewTextBoxColumn.DataPropertyName = "borrowerName";
            this.borrowerNameDataGridViewTextBoxColumn.HeaderText = "borrowerName";
            this.borrowerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerNameDataGridViewTextBoxColumn.Name = "borrowerNameDataGridViewTextBoxColumn";
            // 
            // returnedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 603);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtrbooksSearch);
            this.Controls.Add(this.dtgListreturned);
            this.Name = "returnedBooks";
            this.Text = "returnedBooks";
            this.Load += new System.EventHandler(this.returnedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetViewUnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUnReturnBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgListreturned;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtrbooksSearch;
        private DataSetViewUnReturn dataSetViewUnReturn;
        private System.Windows.Forms.BindingSource viewUnReturnBookBindingSource;
        private DataSetViewUnReturnTableAdapters.viewUnReturnBookTableAdapter viewUnReturnBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAccNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerNameDataGridViewTextBoxColumn;
    }
}