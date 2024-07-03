using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bookLibrary
{
    public partial class frmReport : Form
    {
        String _repName, _repParaDateTime; DataTable _dt;
        public frmReport(String repName, DataTable dt, String repParaDateTime)
        {
            InitializeComponent();
            _repName = repName;
            _dt = dt;
            _repParaDateTime = repParaDateTime;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            
            ReportDataSource rds = new ReportDataSource("DataSet", _dt);
            this.reportViewer.LocalReport.ReportPath = data._report + _repName + ".rdlc";
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.LocalReport.SetParameters(
                new ReportParameter("repParaDateTime", 
                $"Report Generate Time : {_repParaDateTime}")
                );
            this.reportViewer.RefreshReport();
        }
    }
}
