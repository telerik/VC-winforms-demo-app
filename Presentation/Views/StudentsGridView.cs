using Infrastructure;
using Service;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Presentation.Views
{
    public partial class StudentsGridView : UserControl
    {
        private IUniversityLocalContext _universityLocalContext;
        private IStudentService _studentService;

        public StudentsGridView(IUniversityLocalContext universityLocalContext, 
                                IStudentService studentService)
        {
            InitializeComponent();
            this._universityLocalContext = universityLocalContext;
            this._studentService = studentService;
        }

        private void StudentsGridView_Load(object sender, EventArgs e)
        {
            radGridView1.DataSource = _universityLocalContext.Students;
            radGridView1.TableElement.RowHeight = 30;
            radGridView1.TableElement.TableHeaderHeight = 30;
        }

        public void radGridView1_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            _studentService.AddStudent(e.Rows[0].Cells["Name"].Value.ToString(), 
                                      e.Rows[0].Cells["Email"].Value.ToString(), 
                                      e.Rows[0].Cells["Specialty"].Value.ToString(), 
                                      e.Rows[0].Cells["Course"].Value.ToString());
        }

        private void radGridView1_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            _studentService.DeleteStudentFromLocalRepository((int)e.Rows[0].Cells["Id"].Value);
        }
    }
}
