using System.Windows.Forms;
using Telerik.Reporting;

namespace Presentation.Views
{
    public partial class ReportView : UserControl
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, System.EventArgs e)
        {
            var reportSource = new UriReportSource();
            reportSource.Uri = "Reports/ListOfStudentsReport.trdp";
            this.reportViewer1.ReportSource = reportSource;
            this.reportViewer1.RefreshReport();
        }

        private void ReportView_VisibleChanged(object sender, System.EventArgs e)
        {
            if (this.Visible)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
