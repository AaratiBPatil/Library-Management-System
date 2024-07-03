using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookLibrary
{
    public partial class frmPrintReturnBookReceipt : Form
    {
        String _repParaDateTime, _repParaBorroerName, _repParaBookTitle, _repParaBookAuthor;
        public frmPrintReturnBookReceipt(
            String repParaDateTime,
            String repParaBorroerName,
            String repParaBookTitle,
            String repParaBookAuthor)
        {
            InitializeComponent();
            _repParaDateTime = repParaDateTime;
            _repParaBorroerName = repParaBorroerName;
            _repParaBookTitle = repParaBookTitle;
                _repParaBookAuthor = repParaBookAuthor;
        }

        private void printReturnBookReceipt_Load(object sender, EventArgs e)
        {
            this.reportViewer.LocalReport.ReportPath = data._report + "printReturnBookReceipt.rdlc";
            this.reportViewer.LocalReport.SetParameters(
                new ReportParameter("repParaDateTime", _repParaDateTime)
                );
            this.reportViewer.LocalReport.SetParameters(
                new ReportParameter("repParaBorroerName", _repParaBorroerName)
                );
            this.reportViewer.LocalReport.SetParameters(
                            new ReportParameter("repParaBookTitle", _repParaBookTitle)
                            );
            this.reportViewer.LocalReport.SetParameters(
                            new ReportParameter("repParaBookAuthor", _repParaBookAuthor)
                            );

            this.reportViewer.RefreshReport();
        }
    }
}
