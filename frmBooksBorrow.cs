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
    public partial class frmBooksBorrow : Form
    {
        public frmBooksBorrow()
        {
            InitializeComponent();
        }

        private void frmBooksBorrow_Load(object sender, EventArgs e)
        {
            Label2.Hide(); txt_Search.Hide();
            dtg_BlistOfBooks.Columns[0].Visible = false;
            String refresh_query = "SELECT tbBorrow.borrowId, tbBorrow.borrowDate, tbBorrow.bookAccNo, tbBook.bookTitle, tbBorrow.borrowerId, tbBorrower.borrowerName " +
                "FROM((tbBorrower INNER JOIN " +
                "tbBorrow ON tbBorrower.borrowerId = tbBorrow.borrowerId) INNER JOIN " +
                "tbBook ON tbBorrow.bookAccNo = tbBook.bookAccNo) WHERE tbBorrow.return_ = 'false' " +
                "ORDER BY tbBorrow.borrowDate DESC";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbBorrow, tbBook, tbBorrower");
            dtg_BlistOfBooks.DataSource = DS.Tables[0];

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            
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
