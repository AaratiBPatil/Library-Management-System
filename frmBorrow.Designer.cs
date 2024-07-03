namespace bookLibrary
{
    partial class frmBorrow
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.alertBook = new System.Windows.Forms.Label();
            this.txtAccesionNumBorrow = new System.Windows.Forms.TextBox();
            this.lblAccessionNumBorrow = new System.Windows.Forms.Label();
            this.txtbooktype = new System.Windows.Forms.TextBox();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.txtDatePublish = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.grp_Bgroup = new System.Windows.Forms.GroupBox();
            this.alertName = new System.Windows.Forms.Label();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.cboPurpose = new System.Windows.Forms.ComboBox();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn_Bsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GroupBox1.SuspendLayout();
            this.grp_Bgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.alertBook);
            this.GroupBox1.Controls.Add(this.txtAccesionNumBorrow);
            this.GroupBox1.Controls.Add(this.lblAccessionNumBorrow);
            this.GroupBox1.Controls.Add(this.txtbooktype);
            this.GroupBox1.Controls.Add(this.txtpublisher);
            this.GroupBox1.Controls.Add(this.txtDatePublish);
            this.GroupBox1.Controls.Add(this.txtTitle);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtAuthor);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(22, 26);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(521, 358);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Book\'s Details";
            // 
            // alertBook
            // 
            this.alertBook.AutoSize = true;
            this.alertBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertBook.ForeColor = System.Drawing.Color.Red;
            this.alertBook.Location = new System.Drawing.Point(226, 67);
            this.alertBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alertBook.Name = "alertBook";
            this.alertBook.Size = new System.Drawing.Size(161, 23);
            this.alertBook.TabIndex = 18;
            this.alertBook.Text = "No Book Available...";
            // 
            // txtAccesionNumBorrow
            // 
            this.txtAccesionNumBorrow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccesionNumBorrow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAccesionNumBorrow.Location = new System.Drawing.Point(151, 26);
            this.txtAccesionNumBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccesionNumBorrow.Name = "txtAccesionNumBorrow";
            this.txtAccesionNumBorrow.Size = new System.Drawing.Size(332, 29);
            this.txtAccesionNumBorrow.TabIndex = 17;
            this.txtAccesionNumBorrow.TextChanged += new System.EventHandler(this.txtAccesionNumBorrow_TextChanged);
            this.txtAccesionNumBorrow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccesionNumBorrow_KeyDown);
            this.txtAccesionNumBorrow.Leave += new System.EventHandler(this.txtAccesionNumBorrow_Leave);
            // 
            // lblAccessionNumBorrow
            // 
            this.lblAccessionNumBorrow.AutoSize = true;
            this.lblAccessionNumBorrow.Location = new System.Drawing.Point(14, 28);
            this.lblAccessionNumBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessionNumBorrow.Name = "lblAccessionNumBorrow";
            this.lblAccessionNumBorrow.Size = new System.Drawing.Size(125, 23);
            this.lblAccessionNumBorrow.TabIndex = 16;
            this.lblAccessionNumBorrow.Text = "Accession No. :";
            // 
            // txtbooktype
            // 
            this.txtbooktype.Enabled = false;
            this.txtbooktype.Location = new System.Drawing.Point(151, 222);
            this.txtbooktype.Margin = new System.Windows.Forms.Padding(4);
            this.txtbooktype.Name = "txtbooktype";
            this.txtbooktype.ReadOnly = true;
            this.txtbooktype.Size = new System.Drawing.Size(332, 29);
            this.txtbooktype.TabIndex = 14;
            // 
            // txtpublisher
            // 
            this.txtpublisher.Enabled = false;
            this.txtpublisher.Location = new System.Drawing.Point(151, 184);
            this.txtpublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.ReadOnly = true;
            this.txtpublisher.Size = new System.Drawing.Size(332, 29);
            this.txtpublisher.TabIndex = 14;
            // 
            // txtDatePublish
            // 
            this.txtDatePublish.Enabled = false;
            this.txtDatePublish.Location = new System.Drawing.Point(151, 146);
            this.txtDatePublish.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatePublish.Name = "txtDatePublish";
            this.txtDatePublish.ReadOnly = true;
            this.txtDatePublish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDatePublish.Size = new System.Drawing.Size(332, 29);
            this.txtDatePublish.TabIndex = 14;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(151, 67);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(332, 29);
            this.txtTitle.TabIndex = 13;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(13, 226);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(124, 23);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Type of Books :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(151, 108);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(332, 29);
            this.txtAuthor.TabIndex = 13;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(53, 188);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 23);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Publisher :";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(27, 150);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(115, 23);
            this.Label12.TabIndex = 11;
            this.Label12.Text = "Date Publish :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(91, 67);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Title :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(71, 112);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 23);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Author :";
            // 
            // grp_Bgroup
            // 
            this.grp_Bgroup.Controls.Add(this.alertName);
            this.grp_Bgroup.Controls.Add(this.txtBorrowerId);
            this.grp_Bgroup.Controls.Add(this.cboPurpose);
            this.grp_Bgroup.Controls.Add(this.txtdue);
            this.grp_Bgroup.Controls.Add(this.txtCourse);
            this.grp_Bgroup.Controls.Add(this.txtName);
            this.grp_Bgroup.Controls.Add(this.Label15);
            this.grp_Bgroup.Controls.Add(this.Label13);
            this.grp_Bgroup.Controls.Add(this.Label7);
            this.grp_Bgroup.Controls.Add(this.Label17);
            this.grp_Bgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Bgroup.Location = new System.Drawing.Point(551, 70);
            this.grp_Bgroup.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Bgroup.Name = "grp_Bgroup";
            this.grp_Bgroup.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Bgroup.Size = new System.Drawing.Size(507, 281);
            this.grp_Bgroup.TabIndex = 18;
            this.grp_Bgroup.TabStop = false;
            this.grp_Bgroup.Text = "Borrower\'s";
            // 
            // alertName
            // 
            this.alertName.AutoSize = true;
            this.alertName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertName.ForeColor = System.Drawing.Color.Red;
            this.alertName.Location = new System.Drawing.Point(218, 79);
            this.alertName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alertName.Name = "alertName";
            this.alertName.Size = new System.Drawing.Size(192, 23);
            this.alertName.TabIndex = 19;
            this.alertName.Text = "No Borrower Available...";
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBorrowerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBorrowerId.Location = new System.Drawing.Point(143, 38);
            this.txtBorrowerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.Size = new System.Drawing.Size(327, 29);
            this.txtBorrowerId.TabIndex = 24;
            this.txtBorrowerId.TextChanged += new System.EventHandler(this.txtBorrowerId_TextChanged);
            // 
            // cboPurpose
            // 
            this.cboPurpose.FormattingEnabled = true;
            this.cboPurpose.Items.AddRange(new object[] {
            "Overnight",
            "Research",
            "Photocopy"});
            this.cboPurpose.Location = new System.Drawing.Point(143, 152);
            this.cboPurpose.Margin = new System.Windows.Forms.Padding(4);
            this.cboPurpose.Name = "cboPurpose";
            this.cboPurpose.Size = new System.Drawing.Size(327, 29);
            this.cboPurpose.TabIndex = 22;
            this.cboPurpose.Text = "Select";
            // 
            // txtdue
            // 
            this.txtdue.Location = new System.Drawing.Point(385, 152);
            this.txtdue.Margin = new System.Windows.Forms.Padding(4);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(52, 29);
            this.txtdue.TabIndex = 18;
            // 
            // txtCourse
            // 
            this.txtCourse.Enabled = false;
            this.txtCourse.Location = new System.Drawing.Point(143, 114);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(327, 29);
            this.txtCourse.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(143, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(327, 29);
            this.txtName.TabIndex = 20;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(51, 156);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(81, 23);
            this.Label15.TabIndex = 18;
            this.Label15.Text = "Purpose :";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(18, 118);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(114, 23);
            this.Label13.TabIndex = 16;
            this.Label13.Text = "Year/Section :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(23, 42);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(108, 23);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Borrower Id :";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(69, 80);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(65, 23);
            this.Label17.TabIndex = 14;
            this.Label17.Text = "Name :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(903, 376);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 48);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(740, 376);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 48);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_Bsave
            // 
            this.btn_Bsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bsave.Location = new System.Drawing.Point(579, 376);
            this.btn_Bsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bsave.Name = "btn_Bsave";
            this.btn_Bsave.Size = new System.Drawing.Size(155, 48);
            this.btn_Bsave.TabIndex = 21;
            this.btn_Bsave.Text = "Borrow";
            this.btn_Bsave.UseVisualStyleBackColor = true;
            this.btn_Bsave.Click += new System.EventHandler(this.btn_Bsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePicker.Location = new System.Drawing.Point(821, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 26;
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 454);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btn_Bsave);
            this.Controls.Add(this.grp_Bgroup);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmBorrow";
            this.Text = "frmBorrow";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grp_Bgroup.ResumeLayout(false);
            this.grp_Bgroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtAccesionNumBorrow;
        internal System.Windows.Forms.Label lblAccessionNumBorrow;
        internal System.Windows.Forms.TextBox txtbooktype;
        internal System.Windows.Forms.TextBox txtpublisher;
        internal System.Windows.Forms.TextBox txtDatePublish;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtAuthor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox grp_Bgroup;
        internal System.Windows.Forms.TextBox txtBorrowerId;
        internal System.Windows.Forms.ComboBox cboPurpose;
        internal System.Windows.Forms.TextBox txtdue;
        internal System.Windows.Forms.TextBox txtCourse;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btn_Bsave;
        internal System.Windows.Forms.Label alertBook;
        internal System.Windows.Forms.Label alertName;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}