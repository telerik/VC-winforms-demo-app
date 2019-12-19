using Presentation.Common;
using System;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class SchedulerView : UserControl
    {
        public event EventHandler AddAppointmentEventRaised;
        public event EventHandler DeleteAppointmentEventRaised;
        public event EventHandler ChangeAppointmentEventRaised;

        public SchedulerView()
        {
            InitializeComponent();
        }

        private void SchedulerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulerDataSet.Exams' table. You can move, or remove it, as needed.
            this.examsTableAdapter.Fill(this.schedulerDataSet.Exams);

        }

        private void radScheduler1_AppointmentAdded(object sender, Telerik.WinControls.UI.AppointmentAddedEventArgs e)
        {
            EventHelper.RaiseEvent(this, AddAppointmentEventRaised, e);
        }

        private void radScheduler1_AppointmentDeleted(object sender, Telerik.WinControls.UI.SchedulerAppointmentEventArgs e)
        {
            EventHelper.RaiseEvent(this, DeleteAppointmentEventRaised, e);
        }

        private void radScheduler1_AppointmentChanged(object sender, Telerik.WinControls.UI.AppointmentChangedEventArgs e)
        {
            EventHelper.RaiseEvent(this, ChangeAppointmentEventRaised, e);
        }
    }
}
