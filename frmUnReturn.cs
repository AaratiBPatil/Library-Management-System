using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bookLibrary
{
    public partial class frmUnReturn : Form
    {
        data _data = new data();
        public frmUnReturn()
        {
            InitializeComponent();
        }

        private void frmUnReturn_Load(object sender, EventArgs e)
        {
            Label27.Hide(); txtSearchPborrower.Hide();bookAccNo.Hide(); borrowerId.Hide();
            dateTimePicker.Enabled = false;
            clr();
        }
        // loadDataGrid()
        private void loadDataGrid()
        {
            dtg_RlistReturn.Columns[0].Visible = false;
            dtg_RlistReturn.Columns[2].Visible = false;
            dtg_RlistReturn.Columns[4].Visible = false;
            String refresh_query = "SELECT tbBorrow.borrowId, tbBorrow.borrowDate, tbBorrow.bookAccNo, tbBook.bookTitle, tbBorrow.borrowerId, tbBorrower.borrowerName " +
                "FROM((tbBorrower INNER JOIN " +
                "tbBorrow ON tbBorrower.borrowerId = tbBorrow.borrowerId) INNER JOIN " +
                "tbBook ON tbBorrow.bookAccNo = tbBook.bookAccNo) WHERE tbBorrow.return_ = 'false' " +
                "ORDER BY tbBorrow.borrowDate DESC";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbBorrow, tbBook, tbBorrower");
            dtg_RlistReturn.DataSource = DS.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchPborrower_TextChanged(object sender, EventArgs e)
        {
            dtg_RlistReturn.Columns[0].Visible = false;
            dtg_RlistReturn.Columns[2].Visible = false;
            dtg_RlistReturn.Columns[4].Visible = false;
            String refresh_query = "SELECT tbBorrow.borrowId, tbBorrow.borrowDate, tbBorrow.bookAccNo, tbBook.bookTitle, tbBorrow.borrowerId, tbBorrower.borrowerName " +
                "FROM((tbBorrower INNER JOIN " +
                "tbBorrow ON tbBorrower.borrowerId = tbBorrow.borrowerId) INNER JOIN " +
                $"tbBook ON tbBorrow.bookAccNo = tbBook.bookAccNo) WHERE tbBorrow.return_ = 'false'";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbBorrow, tbBook, tbBorrower");
            dtg_RlistReturn.DataSource = DS.Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clr();
        }
        // clear form
        private void clr()
        {
            bookAccNo.Text = null; borrowerId.Text = null;
            txtRname.Text = null; txtRbookTitle.Text = null;
            txtRdescription.Text = null; txtRauthor.Text = null;
            txtSearchPborrower.Text = null;
            loadDataGrid();
        }

        private void dtg_RlistReturn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                borrowerId.Text = dtg_RlistReturn.SelectedRows[0].Cells[4].Value.ToString();
                txtRname.Text = dtg_RlistReturn.SelectedRows[0].Cells[5].Value.ToString();

                bookAccNo.Text = dtg_RlistReturn.SelectedRows[0].Cells[2].Value.ToString();
                txtRbookTitle.Text = dtg_RlistReturn.SelectedRows[0].Cells[3].Value.ToString();

                try
                {
                    String query = $"SELECT bookAuthor, bookDes FROM tbBook " +
                        $"WHERE bookAccNo = '{bookAccNo.Text}'";
                    SqlConnection conn = new SqlConnection(data._server);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtRauthor.Text = reader[0].ToString();
                        txtRdescription.Text = reader[1].ToString();
                    }
                    conn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, " - Error - toGetBookDetails"); }
            }
            catch (Exception ex) { MessageBox.Show("No Data Found..."); }
        }

        private void btn_Rsave_Click(object sender, EventArgs e)
        {
            if(txtRbookTitle.Text != String.Empty && txtRname.Text != String.Empty &&
                borrowerId.Text != String.Empty && bookAccNo.Text != String.Empty)
            {
                String returnDate = $"{dateTimePicker.Value.Year} / {dateTimePicker.Value.Month} / {dateTimePicker.Value.Day}";
                String query = $"INSERT INTO tbReturn (returnDate, bookAccNo, borrowerId) " +
                    $"VALUES('{returnDate}', '{bookAccNo.Text}', {int.Parse(borrowerId.Text)})";
                String query_ = $"UPDATE tbBorrow SET return_ = 'true' " +
                    $"WHERE bookAccNo = '{bookAccNo.Text}' AND borrowerId = {int.Parse(borrowerId.Text)}";
                if (_data.cmd("INSERT", query, "RETURN", false))
                    if (_data.cmd("UPDATE", query_, "RETURN", true))
                    {
                        if (DialogResult.Yes == MessageBox.Show("Do You Have print...", "", MessageBoxButtons.YesNo))
                            printReceipt();
                        clr();
                    }
            }
            else { MessageBox.Show("Please Select Entery Which One Return..."); }
        }
        // gen return book receipt
        private void printReceipt()
        {
            frmPrintReturnBookReceipt frmPrintReturnBookReceipt = new frmPrintReturnBookReceipt(
                $"Date/Time {dateTimePicker.Value}",
                txtRname.Text, txtRbookTitle.Text, txtRauthor.Text
                );
            frmPrintReturnBookReceipt.ShowDialog();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            String query = "SELECT tbBorrow.borrowId, tbBorrow.borrowDate, tbBorrow.bookAccNo, tbBook.bookTitle, tbBorrow.borrowerId, tbBorrower.borrowerName " +
                "FROM((tbBorrower INNER JOIN " +
                "tbBorrow ON tbBorrower.borrowerId = tbBorrow.borrowerId) INNER JOIN " +
                $"tbBook ON tbBorrow.bookAccNo = tbBook.bookAccNo) WHERE tbBorrow.return_ = 'false'";
            String repParaDateTime = $"{DateTime.Now}";
            frmReport report = new frmReport("reportUnReturn", data.GetDataTable(query), repParaDateTime);
            report.Show();
        }
    }
}
