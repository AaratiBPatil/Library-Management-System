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
    public partial class returnedBooks : Form
    {
        public returnedBooks()
        {
            InitializeComponent();
        }

        private void returnedBooks_Load(object sender, EventArgs e)
        {
            Label4.Hide(); txtrbooksSearch.Hide();
            dtgListreturned.Columns[0].Visible = false;
            String refresh_query = "SELECT tbBorrow.borrowId, tbBorrow.borrowDate, tbBorrow.bookAccNo, tbBook.bookTitle, tbBorrow.borrowerId, tbBorrower.borrowerName " +
                "FROM((tbBorrower INNER JOIN " +
                "tbBorrow ON tbBorrower.borrowerId = tbBorrow.borrowerId) INNER JOIN " +
                "tbBook ON tbBorrow.bookAccNo = tbBook.bookAccNo) WHERE tbBorrow.return = 'true' " +
                "ORDER BY tbBorrow.borrowDate DESC";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbBorrow, tbBook, tbBorrower");
            dtgListreturned.DataSource = DS.Tables[0];

        }
    }
}
