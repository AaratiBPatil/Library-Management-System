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
    public partial class frmCategories : Form
    {
        data _data= new data();

        public frmCategories()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //clear function
        private void clr()
        {
            txtCategory.Text = null; txtSearch.Text = null;
            btndelete.Enabled = false; textBoxId.Text = null; textBoxId.Hide();
            refresh(); btndelete.Enabled = false; txtCategory.Focus(); txtSearch.Text = null;
        }
        // refresh
        private void refresh()
        {
            String refresh_query = "SELECT * FROM tbCategories";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbCategories");
            dtglist.DataSource = DS.Tables[0];
        }
        private void frmCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCategories.tbCategories' table. You can move, or remove it, as needed.
            this.tbCategoriesTableAdapter.Fill(this.dataSetCategories.tbCategories);
            clr();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == String.Empty)
            {
                // new entry
                String query = $"INSERT INTO tbCategories(catName)" +
                    $"VALUES('{txtCategory.Text}')";
                if(_data.cmd("INSERT", query, "CATEGORIES", true))
                    clr();
            }
            else
            {
                // update old entry
                String query = $"UPDATE tbCategories SET catName = '{txtCategory.Text}' " +
                    $"WHERE catId = {int.Parse(textBoxId.Text)}";
                if (_data.cmd("UPDATE", query, "CATEGORIES", true))
                    clr();
            }
        }

        private void dtglist_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxId.Text = dtglist.SelectedRows[0].Cells[0].Value.ToString();
            txtCategory.Text = dtglist.SelectedRows[0].Cells[1].Value.ToString();
            btndelete.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // delete old entry
            String query = $"DELETE FROM tbCategories  " +
                $"WHERE catId = {int.Parse(textBoxId.Text)}";
            if (_data.cmd("DELETE", query, "CATEGORIES", true))
                clr();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String refresh_query = $"SELECT * FROM tbCategories WHERE catName LIKE '{txtSearch.Text}%'";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbCategories");
            dtglist.DataSource = DS.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            String query = $"SELECT * FROM tbCategories";
            String repParaDateTime = $"{DateTime.Now}";
            frmReport report = new frmReport("reportCategories", data.GetDataTable(query), repParaDateTime);
            report.Show();
        }
    }
}
