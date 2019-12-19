using Infrastructure;
using Presentation.Views;
using Service;

namespace Presentation.Presenters
{
    public class StudentsGridViewPresenter : IStudentsGridViewPresenter
    {
        private IUniversityLocalContext universityLocalContext;
        private IStudentService studentService;

        public StudentsGridViewPresenter(IUniversityLocalContext universityLocalContext, IStudentService studentService)
        {
            this.universityLocalContext = universityLocalContext;
            this.studentService = studentService;
        }

        public StudentsGridView GetStudentsGridView()
        {
            return new StudentsGridView(universityLocalContext, studentService);
        }
    }
}
