using Presentation.Common;
using System;
using Telerik.WinControls.UI;

namespace Presentation
{
    public partial class MainView : RadForm, IMainView
    {
        public event EventHandler AddStudentBtnClickEventRaised;
        public event EventHandler ChartViewBtnClickEventRaised;
        public event EventHandler StudentsGridViewBtnClickEventRaised;
        public event EventHandler StudentsListViewBtnClickEventRaised;
        public event EventHandler SchedulerViewClickEventRaised;
        public event EventHandler ReportViewBtnClickEventRaised;

        public MainView()
        {
            InitializeComponent();
            //ThemeResolutionService.ApplicationThemeName = "Material";
        }

        public void ShowMainView()
        {
            this.Show();
        }

        public RadPanel MainPanel
        {
            get
            {
                return this.mainRadPanel;
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
        }

        private void radTreeViewNavigation_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            var clickedNavButton = e.Node.Text;
            if (clickedNavButton == "Inputs")
            {
                EventHelper.RaiseEvent(this, AddStudentBtnClickEventRaised, e);
            }
            else if (clickedNavButton == "Chart")
            {
                EventHelper.RaiseEvent(this, ChartViewBtnClickEventRaised, e);
            }
            else if (clickedNavButton == "Grid")
            {
                EventHelper.RaiseEvent(this, StudentsGridViewBtnClickEventRaised, e);
            }
            else if (clickedNavButton == "Spreadsheet")
            {
                EventHelper.RaiseEvent(this, StudentsListViewBtnClickEventRaised, e);
            }
            else if (clickedNavButton == "Scheduler")
            {
                EventHelper.RaiseEvent(this, SchedulerViewClickEventRaised, e);
            }
            else if (clickedNavButton == "Report")
            {
                EventHelper.RaiseEvent(this, ReportViewBtnClickEventRaised, e);
            }
        }
    }
}
