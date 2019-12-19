using Infrastructure;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class ChartViewPresenter : IChartViewPresenter
    {
        public IUniversityLocalContext universityLocalContext;

        public ChartViewPresenter(IUniversityLocalContext universityLocalContext)
        {
            this.universityLocalContext = universityLocalContext;
        }
        
        public ChartView GetChartView()
        {
            return new ChartView(universityLocalContext);
        }
    }
} 
