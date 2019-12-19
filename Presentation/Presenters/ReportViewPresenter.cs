using Infrastructure;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class ReportViewPresenter : IReportViewPresenter
    {
        public ReportView GetReportView()
        {
            return new ReportView();
        }
    }
}
