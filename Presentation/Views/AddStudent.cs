using Presentation.Common;
using System;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class AddStudent : UserControl, IAddStudent
    {
        public event EventHandler AddStudentBtnClicked;
        public event EventHandler AddTeacherBtnClicked;

        #region Properties
        public AddStudent()
        {
            InitializeComponent();
        }

        public string StudentName
        {
            get
            {
                return nameTb.Text;
            }
        }

        public string StudentEmail
        {
            get
            {
                return emailTb.Text;
            }
        }

        public string StudentSpecialty
        {
            get
            {
                return specialtyDdl.Text;
            }
        }

        public string StudentCourse
        {
            get
            {
                return courseDdl.Text;
            }
        }

        public string TeacherName
        {
            get
            {
                return teacherNameTb.Text;
            }
        }

        public string TeacherEmail
        {
            get
            {
                return teacherEmailTb.Text;
            }
        }

        public string TeacherRank
        {
            get
            {
                return teacherRankDdl.Text; 
            }
        }
        #endregion

        public void ShowAddStudentView()
        {
            this.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EventHelper.RaiseEvent(this, AddStudentBtnClicked, e);

            nameTb.Clear();
            emailTb.Clear();
            specialtyDdl.ResetText();
            courseDdl.ResetText();
        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            EventHelper.RaiseEvent(this, AddTeacherBtnClicked, e);

            teacherEmailTb.Clear();
            teacherNameTb.Clear();
            teacherRankDdl.ResetText();
            disciplineDdl.ResetText();
            contractorCb.Checked = false;
            groupLoadSpin.Value = 1;
            dateOfStartingCalendar.ResetText();
        }
    }
}
