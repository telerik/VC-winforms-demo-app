using Presentation.Views;
using Service;
using System;

namespace Presentation.Presenters
{
    public class SchedulerViewPresenter : ISchedulerViewPresenter
    {
        private SchedulerView _schedulerView;
        private readonly IAppointmentService _appointmentService;
        private readonly IErrorMessageView _errorMessageView;

        public SchedulerViewPresenter(IAppointmentService appointmentService, IErrorMessageView errorMessageView)
        {
            _appointmentService = appointmentService;
            _errorMessageView = errorMessageView;
        }

        public SchedulerView GetSchedulerView()
        {
            _schedulerView = new SchedulerView();
            _schedulerView.AddAppointmentEventRaised += new EventHandler(OnAddApointmentEventRaised);
            _schedulerView.DeleteAppointmentEventRaised += new EventHandler(OnDeleteAppointmentEventRaised);
            _schedulerView.ChangeAppointmentEventRaised += new EventHandler(OnChangeAppointmentEventRaised);
            return _schedulerView;
        }

        private void OnAddApointmentEventRaised(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.AppointmentAddedEventArgs args = (Telerik.WinControls.UI.AppointmentAddedEventArgs)e;

            try
            {
                _appointmentService.AddAppointment(args.Appointment.Summary,
                                               args.Appointment.Start,
                                               args.Appointment.End,
                                               args.Appointment.Location);
            }
            catch (ArgumentNullException)
            {
                _errorMessageView.ShowErrorMessageView("Error", "Discipline name doesn't exist. Please write discipline name as first word in appointment summary.");
            }
        }

        private void OnDeleteAppointmentEventRaised(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.SchedulerAppointmentEventArgs args = (Telerik.WinControls.UI.SchedulerAppointmentEventArgs)e;

            try
            {
                _appointmentService.RemoveAppointment(args.Appointment.Summary);
            }
            catch
            {
                _errorMessageView.ShowErrorMessageView("Error", "Cannot remove appointment.");
            }
        }

        private void OnChangeAppointmentEventRaised(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.AppointmentChangedEventArgs args = (Telerik.WinControls.UI.AppointmentChangedEventArgs)e;

            try
            {
                _appointmentService.ChangeAppointment(args.Appointment.Summary,
                                                      args.Appointment.Start,
                                                      args.Appointment.End,
                                                      args.Appointment.Location,
                                                      args.PropertyName);
            }
            catch
            {
                _errorMessageView.ShowErrorMessageView("Error", "Cannot change appointment. Make sure to specify location.");
            }
        }
    }
}
