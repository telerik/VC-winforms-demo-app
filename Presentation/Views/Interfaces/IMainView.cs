using System;
using Telerik.WinControls.UI;

namespace Presentation
{
    public interface IMainView
    {
        RadPanel MainPanel { get; }
        
        event EventHandler AddStudentBtnClickEventRaised;

        event EventHandler ChartViewBtnClickEventRaised;

        event EventHandler StudentsGridViewBtnClickEventRaised;

        event EventHandler StudentsListViewBtnClickEventRaised;
        
        event EventHandler SchedulerViewClickEventRaised;

        event EventHandler ReportViewBtnClickEventRaised;

        void ShowMainView();
    }
}