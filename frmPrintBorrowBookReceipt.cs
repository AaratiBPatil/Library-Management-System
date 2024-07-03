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
    public partial class frmPrintBorrowBookReceipt : Form
    {
        String _repParaDateTime, _repName,_repParaAccNo,_repParaBookTitle,_repParaAuthor,
            _repParaPublisher, _repParaTyOfBooks,_repParaBorrowerId,_repParaName, _repParaYearSection, _repParaPurpose;
        public frmPrintBorrowBookReceipt(
            String repParaDateTime,
            String repName,
            String repParaAccNo,
            String repParaBookTitle,
            String repParaAuthor,
            String repParaPublisher,
            String repParaTyOfBooks,
            String repParaBorrowerId,
            String repParaName,
            String repParaYearSection,
            String repParaPurpose
            )
        {
            InitializeComponent();
            _repParaDateTime = repParaDateTime;
            _repName = repName;
            _repParaAccNo = repParaAccNo;
            _repParaBookTitle = repParaBookTitle;
            _repParaAuthor = repParaAuthor;
            _repParaPublisher = repParaPublisher;
            _repParaTyOfBooks = repParaTyOfBooks;
            _repParaBorrowerId = repParaBorrowerId;
            _repParaName = repParaName;
            _repParaYearSection = repParaYearSection;
            _repParaPurpose = repParaPurpose;

        }

        private void frmPrintBorrowBookReceipt_Load(object sender, EventArgs e)
        {
            this.reportViewer.LocalReport.ReportPath = data._report + _repName + ".rdlc";
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaDateTime", _repParaDateTime));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaAccNo", _repParaAccNo));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaBookTitle", _repParaBookTitle));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaAuthor", _repParaAuthor));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaPublisher", _repParaPublisher));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaTyOfBooks", _repParaTyOfBooks));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaBorrowerId", _repParaBorrowerId));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaName", _repParaName));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaYearSection", _repParaYearSection));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("repParaPurpose", _repParaPurpose));
            this.reportViewer.RefreshReport();
        }
    }
}
