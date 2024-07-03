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
    public partial class frmBook : Form
    {
        data _data = new data();
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCategories.tbCategories' table. You can move, or remove it, as needed.
            // this.tbCategoriesTableAdapter.Fill(this.dataSetCategories.tbCategories);

            /*try { pictureBox.Image = new Bitmap(@"source\images\logo.png"); } catch { }*/
            Label1.Hide(); txtId.Hide(); clr();
            Label9.Hide(); cboType.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String bookTitle = txtTitle.Text, 
                bookDes = txtDesc.Text, 
                bookAuthor = txtAuthor.Text, 
                bookDatePublish = $"{dtpDatePublish.Value.Year}/{dtpDatePublish.Value.Month}/{dtpDatePublish.Value.Day}", 
                bookPublisher = txtPublisher.Text, 
                bookTypes = cboType.Text,
                catId = "", bookAccNo = txtAccesionNumBorrow.Text;
            bool tr = false;
            if (cboCategory.Text != String.Empty && txtAccesionNumBorrow.Text != String.Empty)
            {
                catId = catIdGen();
                tr = true;
            }
            else
                MessageBox.Show("Please Select Category...\n Or \nPlease Enter Accesion Number...");
            if (tr)
            {
                if (txtId.Text == "")
                {
                    String quey = $"INSERT INTO tbBook (bookTitle, bookDes, bookAuthor, bookDatePublish, bookPublisher, catId, bookTypes, bookAccNo) " +
                        $"VALUES('{bookTitle}', '{bookDes}', '{bookAuthor}', '{bookDatePublish}', '{bookPublisher}', {int.Parse(catId)}, '{bookTypes}', '{bookAccNo}')";
                    if (_data.cmd("INSERT", quey, "BOOK", true))
                        clr();
                }
                else if(txtId.Text != String.Empty)
                {
                    String quey = $"UPDATE tbBook SET bookTitle = '{bookTitle}', bookDes = '{bookDes}', bookAuthor = '{bookAuthor}', " +
                        $"bookDatePublish = '{bookDatePublish}', bookPublisher ='{bookPublisher}', catId = {int.Parse(catId)}, bookTypes = '{bookTypes}', bookAccNo = '{bookAccNo}' " +
                        $"WHERE bookId = {int.Parse(txtId.Text)}";
                    if (_data.cmd("UPDATE", quey, "BOOK", true))
                        clr();
                }
            }
        }
        // get cat id
        private string catIdGen()
        {
            string res = "";
            try
            {
                SqlConnection conn = new SqlConnection(data._server);
                conn.Open();
                SqlCommand cmd = new SqlCommand( $"SELECT catId FROM tbCategories WHERE catName = '{cboCategory.Text}'",conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res = reader[0].ToString();
                }
                conn.Close();
            }catch(Exception ex) { MessageBox.Show(ex.Message, "error - getCatId"); }
            return res;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clr();
        }
        // clear function
        private void clr()
        {
            txtId.Text = null; txtTitle.Text = null; txtDesc.Text = null; txtAuthor.Text = null;
            dtpDatePublish.Value = DateTime.Now;
            txtPublisher.Text = null; /*cboCategory.SelectedIndex = 0;*/
            cboType.SelectedIndex = 0; txtSearch.Text = null;
            btnUpdate.Enabled = false; btnDelete.Enabled = false; txtAccesionNumBorrow.Text = null;
            refresh();
            _data.addItemsCombobox(this.cboCategory, "tbCategories", "catName");
        }
        // REFRESH DATA GRID
        private void refresh()
        {
            String refresh_query = "SELECT tbBook.bookId, tbBook.bookTitle, tbBook.bookDes, tbBook.bookAuthor, tbBook.bookDatePublish, tbBook.bookPublisher, tbBook.catId, tbCategories.catName, tbBook.bookTypes, tbBook.bookAccNo " +
                "FROM(tbBook INNER JOIN tbCategories ON tbBook.catId = tbCategories.catId)";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbBook, tbCategories");
            dtgList.DataSource = DS.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void dtgList_MouseClick(object sender, MouseEventArgs e)
        {
            string date = "";
            try
            {
                btnUpdate.Enabled = true; btnDelete.Enabled = true;
                txtId.Text = dtgList.SelectedRows[0].Cells[0].Value.ToString();
                txtTitle.Text = dtgList.SelectedRows[0].Cells[1].Value.ToString();
                txtDesc.Text = dtgList.SelectedRows[0].Cells[2].Value.ToString();
                txtAuthor.Text = dtgList.SelectedRows[0].Cells[3].Value.ToString();
                date = dtgList.SelectedRows[0].Cells[4].Value.ToString();
                ; txtPublisher.Text = dtgList.SelectedRows[0].Cells[5].Value.ToString();
                cboCategory.Text = dtgList.SelectedRows[0].Cells[7].Value.ToString();
                cboType.Text = dtgList.SelectedRows[0].Cells[8].Value.ToString();
                String DD = date[0].ToString() + date[1].ToString(),
                       MM = date[3].ToString() + date[4].ToString(),
                       YYYY = date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString();
                dtpDatePublish.Value = new DateTime(int.Parse(YYYY), int.Parse(MM), int.Parse(DD));
                txtAccesionNumBorrow.Text = dtgList.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String bookTitle = txtTitle.Text,
                bookDes = txtDesc.Text,
                bookAuthor = txtAuthor.Text,
                bookDatePublish = $"{dtpDatePublish.Value.Year}/{dtpDatePublish.Value.Month}/{dtpDatePublish.Value.Day}",
                bookPublisher = txtPublisher.Text,
                bookTypes = cboType.Text,
                catId = "";
            bool tr = false;
            if (cboCategory.Text != String.Empty)
            {
                catId = catIdGen();
                tr = true;
            }
            else
                MessageBox.Show("Please Select Category...");
            if (tr)
            {
                if (txtId.Text == "")
                {
                    String quey = $"INSERT INTO tbBook (bookTitle, bookDes, bookAuthor, bookDatePublish, bookPublisher, catId, bookTypes) " +
                        $"VALUES('{bookTitle}', '{bookDes}', '{bookAuthor}', '{bookDatePublish}', '{bookPublisher}', {int.Parse(catId)}, '{bookTypes}')";
                    if (_data.cmd("INSERT", quey, "BOOK", true))
                        clr();
                }
                else if (txtId.Text != String.Empty)
                {
                    String quey = $"UPDATE tbBook SET bookTitle = '{bookTitle}', bookDes = '{bookDes}', bookAuthor = '{bookAuthor}', " +
                        $"bookDatePublish = '{bookDatePublish}', bookPublisher ='{bookPublisher}', catId = {int.Parse(catId)}, bookTypes = '{bookTypes}' " +
                        $"WHERE bookId = {int.Parse(txtId.Text)}";
                    if (_data.cmd("UPDATE", quey, "BOOK", true))
                        clr();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String quey = $"DELETE FROM tbBook " +
                        $"WHERE bookId = {int.Parse(txtId.Text)}";
            if (_data.cmd("DELETE", quey, "BOOK", true))
                clr();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String refresh_query = "SELECT tbBook.bookId, tbBook.bookTitle, tbBook.bookDes, tbBook.bookAuthor, tbBook.bookDatePublish, tbBook.bookPublisher, tbBook.catId, tbCategories.catName, tbBook.bookTypes, tbBook.bookAccNo " +
                "FROM(tbBook INNER JOIN tbCategories ON tbBook.catId = tbCategories.catId) " +
                $"WHERE bookTitle LIKE '{txtSearch.Text}%'";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbBook, tbCategories");
            dtgList.DataSource = DS.Tables[0];
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            String query = $"SELECT tbBook.bookId, tbBook.bookAccNo, tbBook.bookTitle, tbBook.bookAuthor, tbBook.bookDatePublish, tbBook.bookPublisher, tbCategories.catName, tbBook.bookTypes, tbBook.bookDes " +
                $"FROM(tbBook INNER JOIN tbCategories ON tbBook.catId = tbCategories.catId)";
            String repParaDateTime = $"{DateTime.Now}";
            frmReport report = new frmReport("reportBook", data.GetDataTable(query), repParaDateTime);
            report.Show();
        }
    }
}
