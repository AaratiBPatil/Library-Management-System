using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace bookLibrary
{
    public partial class frmUser : Form
    {
        data _data = new data();
        public frmUser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            clr();
        }
        private void clr() { txt_pass.Text = null; txt_username.Text = null; textBoxId.Text = null; cbo_type.Text = null; btn_update.Enabled = false; btn_delete.Enabled = false; refresh(); }
        private void btn_saveuser_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == String.Empty)
            {
                // new entry
                String query = $"INSERT INTO tbUser(userName, userPassword, userType)" +
                    $"VALUES('{txt_username.Text}', '{data.Encode(txt_pass.Text)}', '{cbo_type.Text}')";
                if (_data.cmd("INSERT", query, "USER", true))
                    clr();
                
            }
            else
            {
                // update old entry
                String query = $"UPDATE tbUser SET userName = '{txt_username.Text}', userPassword = '{data.Encode(txt_pass.Text)}', userType = '{cbo_type.Text}' " +
                    $"WHERE userId = {int.Parse(textBoxId.Text)}";
                if (_data.cmd("UPDATE", query, "USER", true))
                    clr();
            }
        }

       

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUser.tbUser' table. You can move, or remove it, as needed.
            this.tbUserTableAdapter.Fill(this.dataSetUser.tbUser);
            textBoxId.Hide(); clr(); refresh();
        }
        private void refresh()
        {

            String refresh_query = "SELECT * FROM tbUser";
            SqlDataAdapter ODDA = new SqlDataAdapter(refresh_query, data._server);
            DataSet DS = new DataSet();
            ODDA.Fill(DS, "tbUser");
            dtg_listUser.DataSource = DS.Tables[0];
        }

        private void dtg_listUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtg_listUser_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxId.Text = dtg_listUser.SelectedRows[0].Cells[0].Value.ToString();
            txt_username.Text = dtg_listUser.SelectedRows[0].Cells[1].Value.ToString();
            txt_pass.Text = data.Decode(dtg_listUser.SelectedRows[0].Cells[2].Value.ToString());
            if (dtg_listUser.SelectedRows[0].Cells[3].Value.ToString() == "Librarian")
                cbo_type.SelectedIndex = 0;
            else if (dtg_listUser.SelectedRows[0].Cells[3].Value.ToString() == "Assistant")
                cbo_type.SelectedIndex = 1;
            else
                cbo_type.Text = "";
            btn_update.Enabled = true; btn_delete.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == String.Empty)
            {
                // new entry
                String query = $"INSERT INTO tbUser(userName, userPassword, userType)" +
                    $"VALUES('{txt_username.Text}', '{data.Encode(txt_pass.Text)}', '{cbo_type.Text}')";
                if (_data.cmd("INSERT", query, "USER", true))
                    clr();
            }
            else
            {
                // update old entry
                String query = $"UPDATE tbUser SET userName = '{txt_username.Text}', userPassword = '{data.Encode(txt_pass.Text)}', userType = '{cbo_type.Text}' " +
                    $"WHERE userId = {int.Parse(textBoxId.Text)}";
                if (_data.cmd("UPDATE", query, "USER", true))
                    clr();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String query = $"DELETE FROM tbUser WHERE userId = {int.Parse(textBoxId.Text)}";
            if (_data.cmd("DELETE", query, "USER", true))
                clr();
        }
        //export pdf function
        public void exportgridtopdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //add datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dtg_listUser, "user-list");
        }
    }
}
