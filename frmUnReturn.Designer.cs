namespace bookLibrary
{
    partial class frmUnReturn
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
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchPborrower = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.dtg_RlistReturn = new System.Windows.Forms.DataGridView();
            this.borrowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAccNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewUnReturnBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetViewUnReturn = new bookLibrary.DataSetViewUnReturn();
            this.grp_Rgroup = new System.Windows.Forms.GroupBox();
            this.bookAccNo = new System.Windows.Forms.TextBox();
            this.borrowerId = new System.Windows.Forms.TextBox();
            this.txtRname = new System.Windows.Forms.TextBox();
            this.cboRborrowerId = new System.Windows.Forms.TextBox();
            this.txtRbookTitle = new System.Windows.Forms.TextBox();
            this.txtRauthor = new System.Windows.Forms.TextBox();
            this.txtRdescription = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_accessionNo = new System.Windows.Forms.Label();
            this.lbl_transid = new System.Windows.Forms.Label();
            this.lbl_borrowerId = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_Rduedate = new System.Windows.Forms.Label();
            this.lbl_rpayments = new System.Windows.Forms.Label();
            this.lbl_Rchange = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txt_RtenAmount = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.txtRCopyBorrowed = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtRRqty = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn_Rsave = new System.Windows.Forms.Button();
            this.viewUnReturnBookTableAdapter = new bookLibrary.DataSetViewUnReturnTableAdapters.viewUnReturnBookTableAdapter();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RlistReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUnReturnBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetViewUnReturn)).BeginInit();
            this.grp_Rgroup.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnReport);
            this.GroupBox3.Controls.Add(this.txtSearchPborrower);
            this.GroupBox3.Controls.Add(this.Label27);
            this.GroupBox3.Controls.Add(this.dtg_RlistReturn);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(13, 13);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(615, 545);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "View Details of Unreturn Books";
            // 
            // txtSearchPborrower
            // 
            this.txtSearchPborrower.Location = new System.Drawing.Point(156, 30);
            this.txtSearchPborrower.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPborrower.Name = "txtSearchPborrower";
            this.txtSearchPborrower.Size = new System.Drawing.Size(83, 29);
            this.txtSearchPborrower.TabIndex = 25;
            this.txtSearchPborrower.TextChanged += new System.EventHandler(this.txtSearchPborrower_TextChanged);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(8, 33);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(139, 23);
            this.Label27.TabIndex = 24;
            this.Label27.Text = "Borrower Name :";
            // 
            // dtg_RlistReturn
            // 
            this.dtg_RlistReturn.AllowUserToAddRows = false;
            this.dtg_RlistReturn.AllowUserToDeleteRows = false;
            this.dtg_RlistReturn.AllowUserToResizeColumns = false;
            this.dtg_RlistReturn.AllowUserToResizeRows = false;
            this.dtg_RlistReturn.AutoGenerateColumns = false;
            this.dtg_RlistReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_RlistReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_RlistReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowIdDataGridViewTextBoxColumn,
            this.borrowDateDataGridViewTextBoxColumn,
            this.bookAccNoDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.borrowerIdDataGridViewTextBoxColumn,
            this.borrowerNameDataGridViewTextBoxColumn});
            this.dtg_RlistReturn.DataSource = this.viewUnReturnBookBindingSource;
            this.dtg_RlistReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_RlistReturn.Location = new System.Drawing.Point(8, 68);
            this.dtg_RlistReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_RlistReturn.MultiSelect = false;
            this.dtg_RlistReturn.Name = "dtg_RlistReturn";
            this.dtg_RlistReturn.ReadOnly = true;
            this.dtg_RlistReturn.RowHeadersVisible = false;
            this.dtg_RlistReturn.RowHeadersWidth = 51;
            this.dtg_RlistReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_RlistReturn.Size = new System.Drawing.Size(599, 470);
            this.dtg_RlistReturn.TabIndex = 0;
            this.dtg_RlistReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtg_RlistReturn_MouseClick);
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
            this.bookAccNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookAccNoDataGridViewTextBoxColumn.DataPropertyName = "bookAccNo";
            this.bookAccNoDataGridViewTextBoxColumn.HeaderText = "bookAccNo";
            this.bookAccNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookAccNoDataGridViewTextBoxColumn.Name = "bookAccNoDataGridViewTextBoxColumn";
            this.bookAccNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // grp_Rgroup
            // 
            this.grp_Rgroup.Controls.Add(this.bookAccNo);
            this.grp_Rgroup.Controls.Add(this.borrowerId);
            this.grp_Rgroup.Controls.Add(this.txtRname);
            this.grp_Rgroup.Controls.Add(this.cboRborrowerId);
            this.grp_Rgroup.Controls.Add(this.txtRbookTitle);
            this.grp_Rgroup.Controls.Add(this.txtRauthor);
            this.grp_Rgroup.Controls.Add(this.txtRdescription);
            this.grp_Rgroup.Controls.Add(this.GroupBox2);
            this.grp_Rgroup.Controls.Add(this.Label18);
            this.grp_Rgroup.Controls.Add(this.Label9);
            this.grp_Rgroup.Controls.Add(this.Label3);
            this.grp_Rgroup.Controls.Add(this.Label8);
            this.grp_Rgroup.Controls.Add(this.GroupBox5);
            this.grp_Rgroup.Controls.Add(this.Label25);
            this.grp_Rgroup.Controls.Add(this.txtRCopyBorrowed);
            this.grp_Rgroup.Controls.Add(this.Label14);
            this.grp_Rgroup.Controls.Add(this.Label11);
            this.grp_Rgroup.Controls.Add(this.txtRRqty);
            this.grp_Rgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Rgroup.Location = new System.Drawing.Point(636, 81);
            this.grp_Rgroup.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Rgroup.Name = "grp_Rgroup";
            this.grp_Rgroup.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Rgroup.Size = new System.Drawing.Size(517, 423);
            this.grp_Rgroup.TabIndex = 26;
            this.grp_Rgroup.TabStop = false;
            this.grp_Rgroup.Text = "Return";
            // 
            // bookAccNo
            // 
            this.bookAccNo.Enabled = false;
            this.bookAccNo.Location = new System.Drawing.Point(158, 108);
            this.bookAccNo.Margin = new System.Windows.Forms.Padding(4);
            this.bookAccNo.Name = "bookAccNo";
            this.bookAccNo.ReadOnly = true;
            this.bookAccNo.Size = new System.Drawing.Size(147, 29);
            this.bookAccNo.TabIndex = 32;
            this.bookAccNo.TabStop = false;
            // 
            // borrowerId
            // 
            this.borrowerId.Enabled = false;
            this.borrowerId.Location = new System.Drawing.Point(181, 46);
            this.borrowerId.Margin = new System.Windows.Forms.Padding(4);
            this.borrowerId.Name = "borrowerId";
            this.borrowerId.ReadOnly = true;
            this.borrowerId.Size = new System.Drawing.Size(147, 29);
            this.borrowerId.TabIndex = 31;
            this.borrowerId.TabStop = false;
            // 
            // txtRname
            // 
            this.txtRname.Enabled = false;
            this.txtRname.Location = new System.Drawing.Point(35, 79);
            this.txtRname.Margin = new System.Windows.Forms.Padding(4);
            this.txtRname.Name = "txtRname";
            this.txtRname.Size = new System.Drawing.Size(440, 29);
            this.txtRname.TabIndex = 27;
            // 
            // cboRborrowerId
            // 
            this.cboRborrowerId.Enabled = false;
            this.cboRborrowerId.Location = new System.Drawing.Point(47, 79);
            this.cboRborrowerId.Margin = new System.Windows.Forms.Padding(4);
            this.cboRborrowerId.Name = "cboRborrowerId";
            this.cboRborrowerId.Size = new System.Drawing.Size(85, 29);
            this.cboRborrowerId.TabIndex = 30;
            // 
            // txtRbookTitle
            // 
            this.txtRbookTitle.Enabled = false;
            this.txtRbookTitle.Location = new System.Drawing.Point(35, 138);
            this.txtRbookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtRbookTitle.Name = "txtRbookTitle";
            this.txtRbookTitle.Size = new System.Drawing.Size(440, 29);
            this.txtRbookTitle.TabIndex = 29;
            // 
            // txtRauthor
            // 
            this.txtRauthor.Enabled = false;
            this.txtRauthor.Location = new System.Drawing.Point(35, 197);
            this.txtRauthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtRauthor.Name = "txtRauthor";
            this.txtRauthor.Size = new System.Drawing.Size(440, 29);
            this.txtRauthor.TabIndex = 27;
            // 
            // txtRdescription
            // 
            this.txtRdescription.Enabled = false;
            this.txtRdescription.Location = new System.Drawing.Point(33, 256);
            this.txtRdescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtRdescription.Multiline = true;
            this.txtRdescription.Name = "txtRdescription";
            this.txtRdescription.Size = new System.Drawing.Size(440, 150);
            this.txtRdescription.TabIndex = 27;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lbl_accessionNo);
            this.GroupBox2.Controls.Add(this.lbl_transid);
            this.GroupBox2.Controls.Add(this.lbl_borrowerId);
            this.GroupBox2.Location = new System.Drawing.Point(687, 143);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(33, 12);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ID\'s Secret";
            // 
            // lbl_accessionNo
            // 
            this.lbl_accessionNo.AutoSize = true;
            this.lbl_accessionNo.Location = new System.Drawing.Point(75, 52);
            this.lbl_accessionNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accessionNo.Name = "lbl_accessionNo";
            this.lbl_accessionNo.Size = new System.Drawing.Size(113, 23);
            this.lbl_accessionNo.TabIndex = 5;
            this.lbl_accessionNo.Text = "Accession #  :";
            // 
            // lbl_transid
            // 
            this.lbl_transid.AutoSize = true;
            this.lbl_transid.Location = new System.Drawing.Point(79, 73);
            this.lbl_transid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_transid.Name = "lbl_transid";
            this.lbl_transid.Size = new System.Drawing.Size(62, 23);
            this.lbl_transid.TabIndex = 24;
            this.lbl_transid.Text = "transid";
            // 
            // lbl_borrowerId
            // 
            this.lbl_borrowerId.AutoSize = true;
            this.lbl_borrowerId.Location = new System.Drawing.Point(75, 31);
            this.lbl_borrowerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_borrowerId.Name = "lbl_borrowerId";
            this.lbl_borrowerId.Size = new System.Drawing.Size(98, 23);
            this.lbl_borrowerId.TabIndex = 21;
            this.lbl_borrowerId.Text = "borrower id";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(29, 54);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(139, 23);
            this.Label18.TabIndex = 19;
            this.Label18.Text = "Borrower Name :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(31, 231);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(105, 23);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Description :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 172);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 23);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Author :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(31, 113);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(94, 23);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Book Title :";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.lbl_Rduedate);
            this.GroupBox5.Controls.Add(this.lbl_rpayments);
            this.GroupBox5.Controls.Add(this.lbl_Rchange);
            this.GroupBox5.Controls.Add(this.Label24);
            this.GroupBox5.Controls.Add(this.Label23);
            this.GroupBox5.Controls.Add(this.txt_RtenAmount);
            this.GroupBox5.Controls.Add(this.Label22);
            this.GroupBox5.Controls.Add(this.Label21);
            this.GroupBox5.Location = new System.Drawing.Point(675, 177);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Size = new System.Drawing.Size(60, 31);
            this.GroupBox5.TabIndex = 4;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "do not touch.Time and Days for the future used. ";
            // 
            // lbl_Rduedate
            // 
            this.lbl_Rduedate.AutoSize = true;
            this.lbl_Rduedate.Location = new System.Drawing.Point(95, 32);
            this.lbl_Rduedate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rduedate.Name = "lbl_Rduedate";
            this.lbl_Rduedate.Size = new System.Drawing.Size(68, 23);
            this.lbl_Rduedate.TabIndex = 7;
            this.lbl_Rduedate.Text = "Label25";
            // 
            // lbl_rpayments
            // 
            this.lbl_rpayments.AutoSize = true;
            this.lbl_rpayments.Location = new System.Drawing.Point(95, 64);
            this.lbl_rpayments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rpayments.Name = "lbl_rpayments";
            this.lbl_rpayments.Size = new System.Drawing.Size(68, 23);
            this.lbl_rpayments.TabIndex = 4;
            this.lbl_rpayments.Text = "Label25";
            // 
            // lbl_Rchange
            // 
            this.lbl_Rchange.AutoSize = true;
            this.lbl_Rchange.Location = new System.Drawing.Point(100, 150);
            this.lbl_Rchange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rchange.Name = "lbl_Rchange";
            this.lbl_Rchange.Size = new System.Drawing.Size(68, 23);
            this.lbl_Rchange.TabIndex = 6;
            this.lbl_Rchange.Text = "Label26";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(20, 150);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(78, 23);
            this.Label24.TabIndex = 5;
            this.Label24.Text = "Change :";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(8, 107);
            this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(156, 23);
            this.Label23.TabIndex = 3;
            this.Label23.Text = "Tendered Amount :";
            // 
            // txt_RtenAmount
            // 
            this.txt_RtenAmount.Location = new System.Drawing.Point(176, 103);
            this.txt_RtenAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RtenAmount.Name = "txt_RtenAmount";
            this.txt_RtenAmount.Size = new System.Drawing.Size(235, 29);
            this.txt_RtenAmount.TabIndex = 2;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(8, 64);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(92, 23);
            this.Label22.TabIndex = 1;
            this.Label22.Text = "Payments :";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(8, 32);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(91, 23);
            this.Label21.TabIndex = 0;
            this.Label21.Text = "Over Due :";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(36, 82);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(108, 23);
            this.Label25.TabIndex = 22;
            this.Label25.Text = "Borrower Id :";
            this.Label25.Visible = false;
            // 
            // txtRCopyBorrowed
            // 
            this.txtRCopyBorrowed.Enabled = false;
            this.txtRCopyBorrowed.Location = new System.Drawing.Point(35, 313);
            this.txtRCopyBorrowed.Margin = new System.Windows.Forms.Padding(4);
            this.txtRCopyBorrowed.Name = "txtRCopyBorrowed";
            this.txtRCopyBorrowed.Size = new System.Drawing.Size(195, 29);
            this.txtRCopyBorrowed.TabIndex = 27;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(252, 260);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(102, 23);
            this.Label14.TabIndex = 11;
            this.Label14.Text = "Return Qty :";
            this.Label14.Visible = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(29, 292);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(200, 23);
            this.Label11.TabIndex = 10;
            this.Label11.Text = "No. of Copies Borrowed :";
            // 
            // txtRRqty
            // 
            this.txtRRqty.Location = new System.Drawing.Point(256, 284);
            this.txtRRqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtRRqty.Name = "txtRRqty";
            this.txtRRqty.Size = new System.Drawing.Size(149, 29);
            this.txtRRqty.TabIndex = 8;
            this.txtRRqty.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(989, 514);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 46);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(817, 514);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(164, 46);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_Rsave
            // 
            this.btn_Rsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rsave.Location = new System.Drawing.Point(652, 514);
            this.btn_Rsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Rsave.Name = "btn_Rsave";
            this.btn_Rsave.Size = new System.Drawing.Size(157, 46);
            this.btn_Rsave.TabIndex = 29;
            this.btn_Rsave.Text = "Return";
            this.btn_Rsave.UseVisualStyleBackColor = true;
            this.btn_Rsave.Click += new System.EventHandler(this.btn_Rsave_Click);
            // 
            // viewUnReturnBookTableAdapter
            // 
            this.viewUnReturnBookTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePicker.Location = new System.Drawing.Point(953, 22);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(450, 20);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(157, 46);
            this.btnReport.TabIndex = 32;
            this.btnReport.Text = "Generate";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmUnReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 573);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btn_Rsave);
            this.Controls.Add(this.grp_Rgroup);
            this.Controls.Add(this.GroupBox3);
            this.Name = "frmUnReturn";
            this.Text = "frmReturn";
            this.Load += new System.EventHandler(this.frmUnReturn_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RlistReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUnReturnBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetViewUnReturn)).EndInit();
            this.grp_Rgroup.ResumeLayout(false);
            this.grp_Rgroup.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtSearchPborrower;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.DataGridView dtg_RlistReturn;
        internal System.Windows.Forms.GroupBox grp_Rgroup;
        internal System.Windows.Forms.TextBox txtRname;
        internal System.Windows.Forms.TextBox cboRborrowerId;
        internal System.Windows.Forms.TextBox txtRbookTitle;
        internal System.Windows.Forms.TextBox txtRauthor;
        internal System.Windows.Forms.TextBox txtRdescription;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lbl_accessionNo;
        internal System.Windows.Forms.Label lbl_transid;
        internal System.Windows.Forms.Label lbl_borrowerId;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label lbl_Rduedate;
        internal System.Windows.Forms.Label lbl_rpayments;
        internal System.Windows.Forms.Label lbl_Rchange;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txt_RtenAmount;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.TextBox txtRCopyBorrowed;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtRRqty;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btn_Rsave;
        private DataSetViewUnReturn dataSetViewUnReturn;
        private System.Windows.Forms.BindingSource viewUnReturnBookBindingSource;
        private DataSetViewUnReturnTableAdapters.viewUnReturnBookTableAdapter viewUnReturnBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAccNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerNameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.TextBox bookAccNo;
        internal System.Windows.Forms.TextBox borrowerId;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnReport;
    }
}