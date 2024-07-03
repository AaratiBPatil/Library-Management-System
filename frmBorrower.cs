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
    public partial class frmBorrower : Form
    {
        data _data = new data();
        public frmBorrower()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // refresh
        private void refresh()
        {
            String refresh_query = "SELECT * FROM tbBorrower";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbUser");
            dtg_ABorrowLists.DataSource = DS.Tables[0];
        }
        // clear function
        private void clr()
        {
            txt_bid.Text = null; txt_name.Text = null; txt_address.Text = null;
            comboBox1.SelectedIndex = 0;
            txtContact.Text = null; txtCourse.Text = null;
            btn_delete.Enabled = false; refresh(); btn_delete.Enabled = false;
        }

        private void frmBorrower_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBorrower.tbBorrower' table. You can move, or remove it, as needed.
            this.tbBorrowerTableAdapter.Fill(this.dataSetBorrower.tbBorrower);
            txt_bid.Hide();
            clr();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != String.Empty)
            {
                if (txt_bid.Text == String.Empty)
                {
                    String borrowerName = txt_name.Text,
                        borrowerAddress = txt_address.Text, 
                        borrowerSex = comboBox1.Text, 
                        borrowerContact = txtContact.Text, 
                        borrowerCourse = txtCourse.Text;
                    String query = $"INSERT INTO tbBorrower (borrowerName, borrowerAddress, borrowerSex, borrowerContact, borrowerCourse) " +
                        $"VALUES('{borrowerName}', '{borrowerAddress}', '{borrowerSex}', '{borrowerContact}', '{borrowerCourse}')";
                    if(_data.cmd("INSERT", query, "BORROWER", true))
                        clr();
                }
                else if(txt_bid.Text != String.Empty)
                {
                    String borrowerName = txt_name.Text,
                       borrowerAddress = txt_address.Text,
                       borrowerSex = comboBox1.Text,
                       borrowerContact = txtContact.Text,
                       borrowerCourse = txtCourse.Text;

                    String query = $"UPDATE tbBorrower SET borrowerName = '{borrowerName}',borrowerAddress = '{borrowerAddress}', borrowerSex = '{borrowerSex}', borrowerContact = '{borrowerContact}', borrowerCourse = '{borrowerCourse}' " +
                        $"WHERE borrowerId = {int.Parse(txt_bid.Text)}";
                    if (_data.cmd("UPDATE", query, "BORROWER", true))
                        clr();
                }
            }
            else { MessageBox.Show("Please Select Sex..."); }
        }

        private void dtg_ABorrowLists_MouseClick(object sender, MouseEventArgs e)
        {
            txt_bid.Text = dtg_ABorrowLists.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = dtg_ABorrowLists.SelectedRows[0].Cells[1].Value.ToString();
            txt_address.Text = dtg_ABorrowLists.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dtg_ABorrowLists.SelectedRows[0].Cells[3].Value.ToString();
            txtContact.Text = dtg_ABorrowLists.SelectedRows[0].Cells[4].Value.ToString();
            txtCourse.Text = dtg_ABorrowLists.SelectedRows[0].Cells[5].Value.ToString();
            btn_delete.Enabled = true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String query = $"DELETE FROM tbBorrower WHERE borrowerId = {int.Parse(txt_bid.Text)}";
            if(_data.cmd("DELETE", query, "BORROWER", true))
                clr();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            String query = $"SELECT * FROM tbBorrower";
            String repParaDateTime = $"{DateTime.Now}";
            frmReport frmReport = new frmReport("reportBorrower", data.GetDataTable(query), repParaDateTime);
            frmReport.Show();
        }
    }
}
