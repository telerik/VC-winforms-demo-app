using System;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class ErrorMessageView : Telerik.WinControls.UI.RadForm, IErrorMessageView
    {
        public ErrorMessageView()
        {
            InitializeComponent();
        }

        public void ShowErrorMessageView(string windowTitle, string errorMessage)
        {
            this.Text = windowTitle;
            this.errorMessageTb.Text = errorMessage;
            this.ShowDialog(this);
            this.Close();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (errorMessageTb.Text != "")
            {
                Clipboard.SetText(errorMessageTb.Text);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
