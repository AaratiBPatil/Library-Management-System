using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bookLibrary
{
    public partial class frmBorrow : Form
    {
        bool book = false, borrower = false;
        data _data = new data();
        
        public frmBorrow()
        {
            InitializeComponent();
        }

        private void txtAccesionNumBorrow_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String query = $"SELECT bookTitle, bookAuthor, bookDatePublish, bookPublisher, bookTypes FROM tbBook " +
                    $"WHERE bookAccNo LIKE '{txtAccesionNumBorrow.Text}%'";
                SqlConnection con = new SqlConnection(data._server);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (txtAccesionNumBorrow.Text != String.Empty)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            alertBook.Hide();
                            book = true;
                            txtTitle.Text = reader[0].ToString();
                            txtAuthor.Text = reader[1].ToString();
                            txtDatePublish.Text = reader[2].ToString();
                            txtpublisher.Text = reader[3].ToString();
                            txtbooktype.Text = reader[4].ToString();
                        }
                    }
                    else noBook(true);
                }else noBook(false);
                con.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error - Search Book"); }
        }
        // no bbok available
        private void noBook(bool s)
        {
            if (s)
            {
                alertBook.Show();book = false;
                txtTitle.Text = null; txtDatePublish.Text = null;
                txtpublisher.Text = null; txtbooktype.Text = null; txtAuthor.Text = null;
            }
            else if (!s) {
                alertBook.Hide(); book = false;
                txtTitle.Text = null; txtDatePublish.Text = null;
                txtpublisher.Text = null; txtbooktype.Text = null; txtAuthor.Text = null;
            }
        }
        private void frmBorrow_Load(object sender, EventArgs e)
        {
            clr(); dateTimePicker.Enabled = false;
        }

        private void clr()
        {
            alertBook.Hide(); alertName.Hide(); book = false ; borrower = false ;
            txtAccesionNumBorrow.Text = null; txtTitle.Text = null; txtDatePublish.Text = null;
            txtpublisher.Text = null; txtbooktype.Text = null;
            txtBorrowerId.Text = null; txtName.Text = null; txtAuthor.Text = null; 
            txtCourse.Text = null; cboPurpose.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccesionNumBorrow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { autoComplete(); txtBorrowerId.Focus(); }
        }

        private void txtAccesionNumBorrow_Leave(object sender, EventArgs e)
        {
            autoComplete();
        }
        // get accesion number just like autop complete
        private void autoComplete()
        {
            try
            {
                SqlConnection conn = new SqlConnection(data._server);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT bookAccNo FROM tbBook WHERE bookTitle = '{txtTitle.Text}'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAccesionNumBorrow.Text = reader[0].ToString();
                    }
                }
                else txtAccesionNumBorrow.Text = null ;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error - Auto Complete"); }
        }

        private void txtBorrowerId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String query = $"SELECT borrowerName, borrowerCourse FROM tbBorrower " +
                    $"WHERE borrowerId LIKE '{txtBorrowerId.Text}%'";
                SqlConnection con = new SqlConnection(data._server);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (txtBorrowerId.Text != String.Empty)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            alertName.Hide(); borrower = true;
                            txtName.Text = reader[0].ToString();
                            txtCourse.Text = reader[1].ToString();
                        }
                    }
                    else noBorrower(true);
                }
                else noBorrower(false);
                con.Close();

            }catch(Exception ex) { MessageBox.Show(ex.Message, " - Error - toGetBorrowerDetails - "); }
        }

        private void btn_Bsave_Click(object sender, EventArgs e)
        {
            if (book)
            {
                if (borrower)
                {
                    String borrowDate = $"{dateTimePicker.Value.Year}/{dateTimePicker.Value.Month}/{dateTimePicker.Value.Day}";
                    String query = $"INSERT INTO tbBorrow(borrowDate, bookAccNo, borrowerId, return_) " +
                        $"VALUES('{borrowDate}', '{txtAccesionNumBorrow.Text}', {int.Parse(txtBorrowerId.Text)}, 'false')";
                    if (_data.cmd("INSERT", query, "BORROW", true))
                    {
                        if (DialogResult.Yes == MessageBox.Show("Do you have receipt ?", "", MessageBoxButtons.YesNo))
                            printReceipt();
                        clr();
                    }
                }
                else { MessageBox.Show("Please Select Borrower Name or Enter Id ...."); }
            }
            else { MessageBox.Show("Please Select Book Name or Enter Accession No...."); }
        }
        // print receipt
        private void printReceipt()
        {
            frmPrintBorrowBookReceipt frmPrintReturnBookReceipt = new frmPrintBorrowBookReceipt(
                $"Date/Time {dateTimePicker.Value}",
                "printBorrowBookReceipt",
                txtAccesionNumBorrow.Text,
                txtTitle.Text,
                txtAuthor.Text,
                txtpublisher.Text,
                txtbooktype.Text,
                txtBorrowerId.Text,
                txtName.Text,
                txtCourse.Text,
                cboPurpose.Text
                );
            frmPrintReturnBookReceipt.ShowDialog();
        }
        // no borrower available
        private void noBorrower(bool s)
        {
            if (s)
            {
                alertName.Show(); borrower = false;
                txtName.Text = null; txtCourse.Text = null;
            }
            else if (!s)
            {
                borrower = true;
                alertName.Hide(); txtName.Text = null; txtCourse.Text = null;

            }
        }
    }
}
