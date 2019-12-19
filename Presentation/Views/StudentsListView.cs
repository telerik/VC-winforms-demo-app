using Infrastructure;
using System;
using System.IO;
using System.Windows.Forms;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;

namespace Presentation.Views
{
    public partial class StudentsListView : UserControl
    {
        private readonly IUniversityLocalContext _universityLocalContext;
        private readonly XlsxFormatProvider _formatProvider;

        public StudentsListView(IUniversityLocalContext universityLocalContext)
        {
            InitializeComponent();
            _universityLocalContext = universityLocalContext;
            _formatProvider = new XlsxFormatProvider();
        }

        private void StudentsListView_Load(object sender, EventArgs e)
        {
            try
            {
                using (Stream input = new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Spreadsheets/students-grades.xlsx"), FileMode.Open))
                {
                    this.radSpreadsheet1.Workbook = _formatProvider.Import(input);
                }
            }
            catch
            {
                ImportFile();
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            ImportFile();
        }

        private void ImportFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.ValidateNames = true;
            openFileDialog.DereferenceLinks = false;
            openFileDialog.Filter = "Excel |*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream input = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    this.radSpreadsheet1.Workbook = _formatProvider.Import(input);
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.ValidateNames = true;
            saveFileDialog.DereferenceLinks = false;
            saveFileDialog.Filter = "Excel |*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream output = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    _formatProvider.Export(this.radSpreadsheet1.Workbook, output);
                }
            }
        }
    }
}
