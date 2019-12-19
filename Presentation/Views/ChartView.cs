using Infrastructure;
using System;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace Presentation.Views
{
    public partial class ChartView : UserControl
    {
        IUniversityLocalContext universityLocalContext;

        public ChartView(IUniversityLocalContext universityLocalContext)
        {
            InitializeComponent();
            this.universityLocalContext = universityLocalContext;
        }

        private void ChartView_Load(object sender, EventArgs e)
        {
            this.radChartView.Series.Clear();
            this.radChartView.Series.Add(this.PopulateDonutSeries());
            this.radChartView1.ChartElement.LegendPosition = LegendPosition.Left;
        }

        private DonutSeries PopulateDonutSeries()
        {
            var students = universityLocalContext.Students;

            int networkingStudensCount = 0;
            int electronicsStudentsCount = 0;
            int computerScienceStudentsCount = 0;

            foreach (var student in students)
            {
                if (student.Specialty.Equals("Networking"))
                {
                    networkingStudensCount++;
                }
                else if (student.Specialty.Equals("Computer Science"))
                {
                    computerScienceStudentsCount++;
                }
                else if (student.Specialty.Equals("Electronics"))
                {
                    electronicsStudentsCount++;
                }
            }

            var pieSeries = new DonutSeries();
            pieSeries.ShowLabels = true;
            pieSeries.LabelFormat = "{0:P2}";
            pieSeries.RadiusFactor = 0.9f;
            pieSeries.Range = new AngleRange(270, 360);

            pieSeries.DataPoints.Add(new PieDataPoint(networkingStudensCount, "Networking"));
            pieSeries.DataPoints.Add(new PieDataPoint(computerScienceStudentsCount, "Computer Science"));
            pieSeries.DataPoints.Add(new PieDataPoint(electronicsStudentsCount, "Electronics"));

            return pieSeries;
        }
    }
}
