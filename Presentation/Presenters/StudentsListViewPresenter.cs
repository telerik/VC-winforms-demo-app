using Infrastructure;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class StudentsListViewPresenter : IStudentsListViewPresenter
    {
        private readonly IUniversityLocalContext universityLocalContext;

        public StudentsListViewPresenter(IUniversityLocalContext universityLocalContext)
        {
            this.universityLocalContext = universityLocalContext;
        }

        public StudentsListView GetStudentsListView()
        {
            return new StudentsListView(universityLocalContext);
        }
    }
}
