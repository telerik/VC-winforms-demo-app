using Presentation.Views;
using System;
using System.Windows.Forms;

namespace Presentation.Presenters
{
    public class MainPresenter : BasePresenter, IMainPresenter
    {
        private readonly IMainView _mainView;
        private readonly IAddStudentPresenter _addStudentPresenter;
        private readonly IStudentsGridViewPresenter _studentsGridViewPresenter;
        private readonly IStudentsListViewPresenter _studentsListViewPresenter;
        private readonly IChartViewPresenter _chartViewPreseneter;
        private readonly ISchedulerViewPresenter _schedulerViewPresenter;
        private readonly IReportViewPresenter _reportViewPresenter;

        public MainPresenter(IMainView mainView, 
                             IErrorMessageView errorMessageView, 
                             IAddStudentPresenter addStudentPresenter, 
                             IStudentsGridViewPresenter studentsGridViewPresenter,
                             IStudentsListViewPresenter studentsListViewPresenter,
                             IChartViewPresenter chartViewPresenter,
                             ISchedulerViewPresenter schedulerViewPresenter,
                             IReportViewPresenter reportViewPresenter) : base(errorMessageView)
        {
            _mainView = mainView;

            _addStudentPresenter = addStudentPresenter;
            _chartViewPreseneter = chartViewPresenter;
            _studentsGridViewPresenter = studentsGridViewPresenter;
            _studentsListViewPresenter = studentsListViewPresenter;
            _studentsGridViewPresenter = studentsGridViewPresenter;
            _schedulerViewPresenter = schedulerViewPresenter;
            _reportViewPresenter = reportViewPresenter;
            
            _mainView.AddStudentBtnClickEventRaised += new EventHandler(OnAddStudentBtnClickEventRaised);
            _mainView.ChartViewBtnClickEventRaised += new EventHandler(OnChartViewBtnClickEventRaised);
            _mainView.StudentsGridViewBtnClickEventRaised += new EventHandler(OnStudentGridViewBtnClickEventRaised);
            _mainView.StudentsListViewBtnClickEventRaised += new EventHandler(OnStudentListViewBtnClickEventRaised);
            _mainView.SchedulerViewClickEventRaised += new EventHandler(OnSchedulerViewBtnClickEventRaised);
            _mainView.ReportViewBtnClickEventRaised += new EventHandler(OnReportViewBtnClickEventRaised);
        }
        
        private void OnAddStudentBtnClickEventRaised(object sender, EventArgs e)
        {
            this.Navigator(_addStudentPresenter.GetAddStudentView());
        }

        private void OnChartViewBtnClickEventRaised(object sender, EventArgs e)
        {
            this.Navigator(_chartViewPreseneter.GetChartView());
        }

        private void OnStudentGridViewBtnClickEventRaised(object sender, EventArgs e)
        {
            this.Navigator(_studentsGridViewPresenter.GetStudentsGridView());
        }

        private void OnStudentListViewBtnClickEventRaised(object sender, EventArgs e)
        {
            this.Navigator(_studentsListViewPresenter.GetStudentsListView());
        }

        private void OnSchedulerViewBtnClickEventRaised(object sender, EventArgs e)
        {
            this.Navigator(_schedulerViewPresenter.GetSchedulerView());
        }

        private void OnReportViewBtnClickEventRaised(object sender, EventArgs e)
        {
            this.Navigator(_reportViewPresenter.GetReportView());
        }

        public void Navigator(Control childControl)
        {
            foreach(Control control in _mainView.MainPanel.Controls)
            {
                control.Visible = false;
            }

            childControl.Dock = DockStyle.Fill;

            _mainView.MainPanel.Controls.Clear();
            _mainView.MainPanel.Controls.Add(childControl);
            
            childControl.Visible = true;
        }
        
        public IMainView GetMainView() { return _mainView; }
    }
}
