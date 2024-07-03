namespace bookLibrary
{
    partial class frmBorrower
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtg_ABorrowLists = new System.Windows.Forms.DataGridView();
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBorrowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBorrower = new bookLibrary.DataSetBorrower();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbBorrowerTableAdapter = new bookLibrary.DataSetBorrowerTableAdapters.tbBorrowerTableAdapter();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBorrowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBorrower)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1043, 260);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 32);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(953, 260);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(91, 32);
            this.btn_Clear.TabIndex = 88;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(863, 260);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 32);
            this.btn_delete.TabIndex = 87;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(775, 260);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 32);
            this.btn_save.TabIndex = 85;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(159, 281);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(475, 29);
            this.txtContact.TabIndex = 82;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(31, 288);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(116, 23);
            this.Label7.TabIndex = 83;
            this.Label7.Text = "Contact No. : ";
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(799, 201);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(287, 29);
            this.txtCourse.TabIndex = 81;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(675, 205);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(111, 23);
            this.Label6.TabIndex = 84;
            this.Label6.Text = "Course/Year :";
            // 
            // dtg_ABorrowLists
            // 
            this.dtg_ABorrowLists.AllowUserToAddRows = false;
            this.dtg_ABorrowLists.AllowUserToDeleteRows = false;
            this.dtg_ABorrowLists.AllowUserToResizeColumns = false;
            this.dtg_ABorrowLists.AllowUserToResizeRows = false;
            this.dtg_ABorrowLists.AutoGenerateColumns = false;
            this.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ABorrowLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowerIdDataGridViewTextBoxColumn,
            this.borrowerNameDataGridViewTextBoxColumn,
            this.borrowerAddressDataGridViewTextBoxColumn,
            this.borrowerSexDataGridViewTextBoxColumn,
            this.borrowerContactDataGridViewTextBoxColumn,
            this.borrowerCourseDataGridViewTextBoxColumn});
            this.dtg_ABorrowLists.DataSource = this.tbBorrowerBindingSource;
            this.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_ABorrowLists.Location = new System.Drawing.Point(13, 350);
            this.dtg_ABorrowLists.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_ABorrowLists.Name = "dtg_ABorrowLists";
            this.dtg_ABorrowLists.RowHeadersVisible = false;
            this.dtg_ABorrowLists.RowHeadersWidth = 51;
            this.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ABorrowLists.Size = new System.Drawing.Size(1120, 272);
            this.dtg_ABorrowLists.TabIndex = 80;
            this.dtg_ABorrowLists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtg_ABorrowLists_MouseClick);
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
            // borrowerAddressDataGridViewTextBoxColumn
            // 
            this.borrowerAddressDataGridViewTextBoxColumn.DataPropertyName = "borrowerAddress";
            this.borrowerAddressDataGridViewTextBoxColumn.HeaderText = "borrowerAddress";
            this.borrowerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerAddressDataGridViewTextBoxColumn.Name = "borrowerAddressDataGridViewTextBoxColumn";
            this.borrowerAddressDataGridViewTextBoxColumn.Width = 140;
            // 
            // borrowerSexDataGridViewTextBoxColumn
            // 
            this.borrowerSexDataGridViewTextBoxColumn.DataPropertyName = "borrowerSex";
            this.borrowerSexDataGridViewTextBoxColumn.HeaderText = "borrowerSex";
            this.borrowerSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerSexDataGridViewTextBoxColumn.Name = "borrowerSexDataGridViewTextBoxColumn";
            this.borrowerSexDataGridViewTextBoxColumn.Width = 112;
            // 
            // borrowerContactDataGridViewTextBoxColumn
            // 
            this.borrowerContactDataGridViewTextBoxColumn.DataPropertyName = "borrowerContact";
            this.borrowerContactDataGridViewTextBoxColumn.HeaderText = "borrowerContact";
            this.borrowerContactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerContactDataGridViewTextBoxColumn.Name = "borrowerContactDataGridViewTextBoxColumn";
            this.borrowerContactDataGridViewTextBoxColumn.Width = 134;
            // 
            // borrowerCourseDataGridViewTextBoxColumn
            // 
            this.borrowerCourseDataGridViewTextBoxColumn.DataPropertyName = "borrowerCourse";
            this.borrowerCourseDataGridViewTextBoxColumn.HeaderText = "borrowerCourse";
            this.borrowerCourseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowerCourseDataGridViewTextBoxColumn.Name = "borrowerCourseDataGridViewTextBoxColumn";
            this.borrowerCourseDataGridViewTextBoxColumn.Width = 132;
            // 
            // tbBorrowerBindingSource
            // 
            this.tbBorrowerBindingSource.DataMember = "tbBorrower";
            this.tbBorrowerBindingSource.DataSource = this.dataSetBorrower;
            // 
            // dataSetBorrower
            // 
            this.dataSetBorrower.DataSetName = "DataSetBorrower";
            this.dataSetBorrower.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_bid
            // 
            this.txt_bid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bid.Location = new System.Drawing.Point(159, 25);
            this.txt_bid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.Size = new System.Drawing.Size(475, 29);
            this.txt_bid.TabIndex = 66;
            this.txt_bid.Text = "1401";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(159, 65);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(475, 29);
            this.txt_name.TabIndex = 67;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(82, 71);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 23);
            this.Label2.TabIndex = 75;
            this.Label2.Text = "Name :";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(159, 171);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(475, 70);
            this.txt_address.TabIndex = 74;
            this.txt_address.Text = "";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(61, 175);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(79, 23);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "Address :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(95, 254);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(45, 23);
            this.Label9.TabIndex = 70;
            this.Label9.Text = "Sex :";
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(773, 260);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(85, 32);
            this.btn_edit.TabIndex = 86;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(863, 261);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(91, 32);
            this.btnDisable.TabIndex = 95;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(159, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 29);
            this.comboBox1.TabIndex = 96;
            // 
            // tbBorrowerTableAdapter
            // 
            this.tbBorrowerTableAdapter.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(775, 300);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(359, 32);
            this.btnReport.TabIndex = 97;
            this.btnReport.Text = "Export / Report / Print";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 661);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtg_ABorrowLists);
            this.Controls.Add(this.txt_bid);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btnDisable);
            this.Name = "frmBorrower";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmBorrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBorrowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBorrower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btn_Clear;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCourse;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView dtg_ABorrowLists;
        internal System.Windows.Forms.TextBox txt_bid;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RichTextBox txt_address;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btn_edit;
        internal System.Windows.Forms.Button btnDisable;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSetBorrower dataSetBorrower;
        private System.Windows.Forms.BindingSource tbBorrowerBindingSource;
        private DataSetBorrowerTableAdapters.tbBorrowerTableAdapter tbBorrowerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerCourseDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnReport;
    }
}