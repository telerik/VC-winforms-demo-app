using Infrastructure;
using Infrastructure.Interfaces;
using Presentation.Views;
using Service;
using Service.Common;
using System;
using System.Windows.Forms;

namespace Presentation.Presenters
{
    public class AddStudentPresenter : IAddStudentPresenter
    {
        private AddStudent addStudentView;
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;
        private readonly IErrorMessageView _errorMessageView;

        public AddStudentPresenter(IErrorMessageView errorMessageView,
                                   IUnitOfWork unitOfWork,
                                   IModelDataAnnotationCheck modelDataAnnotationCheck,
                                   IUniversityLocalContext universityLocalContext)
        {
            _studentService = new StudentService(modelDataAnnotationCheck, unitOfWork, universityLocalContext);
            _teacherService = new TeacherService(modelDataAnnotationCheck, universityLocalContext);
            _errorMessageView = errorMessageView;
        }

        private void OnAddTeacherClickEventRaised(object sender, EventArgs e)
        {
            try
            {
                _teacherService.AddTeacher(addStudentView.TeacherName,
                                           addStudentView.TeacherEmail,
                                           addStudentView.TeacherRank);

                MessageBox.Show("Teacher successfully added.");
            }
            catch (ArgumentException ae)
            {
                _errorMessageView.ShowErrorMessageView("Error", ae.Message);
            }
        }

        private void OnAddStudentClickEventRaised(object sender, EventArgs e)
        {
            try
            {
                _studentService.AddStudent(addStudentView.StudentName,
                                           addStudentView.StudentEmail,
                                           addStudentView.StudentSpecialty,
                                           addStudentView.StudentCourse);

                MessageBox.Show("Student successfully added.");
            }
            catch (ArgumentException ae)
            {
                var studentErroMessageView = new ErrorMessageView();
                studentErroMessageView.ShowErrorMessageView("Error", ae.Message);
            }
        }

        public AddStudent GetAddStudentView()
        {
            addStudentView = new AddStudent();

            addStudentView.AddStudentBtnClicked += new EventHandler(OnAddStudentClickEventRaised);
            addStudentView.AddTeacherBtnClicked += new EventHandler(OnAddTeacherClickEventRaised);

            return addStudentView;
        }
    }
}
