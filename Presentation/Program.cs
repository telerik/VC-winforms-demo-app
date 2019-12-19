using Infrastructure;
using Infrastructure.Interfaces;
using Presentation.Presenters;
using Presentation.Views;
using Service;
using Service.Common;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace Presentation
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var unityContainer = new UnityContainer();

            unityContainer
                .RegisterType<IMainView, MainView>(new ContainerControlledLifetimeManager())
                .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IErrorMessageView, ErrorMessageView>()
                .RegisterType<IAddStudent, AddStudent>()
                .RegisterType<IStudentService, StudentService>(new ContainerControlledLifetimeManager())
                .RegisterType<ITeacherService, TeacherService>(new ContainerControlledLifetimeManager())
                .RegisterType<IAppointmentService, AppointmentService>(new ContainerControlledLifetimeManager())
                .RegisterType<IAddStudentPresenter, AddStudentPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IStudentsGridViewPresenter, StudentsGridViewPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IStudentsListViewPresenter, StudentsListViewPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IChartViewPresenter, ChartViewPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<ISchedulerViewPresenter, SchedulerViewPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IReportViewPresenter, ReportViewPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IUnitOfWork, UnitOfWork>(new ContainerControlledLifetimeManager())
                .RegisterType<IModelDataAnnotationCheck, ModelDataAnnotationCheck>(new ContainerControlledLifetimeManager())
                .RegisterType<IUniversityLocalContext, UniversityLocalContext>(new ContainerControlledLifetimeManager())
                .RegisterType<IStudentDbContext, StudentDbContext>(new ContainerControlledLifetimeManager());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainPresenter mainPresenter = unityContainer.Resolve<MainPresenter>();

            IMainView mainView = mainPresenter.GetMainView();

            Application.Run((MainView)mainView);
        }
    }
}
