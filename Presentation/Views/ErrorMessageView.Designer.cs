namespace Presentation.Views
{
    partial class ErrorMessageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorMessageTb = new Telerik.WinControls.UI.RadTextBox();
            this.copyBtn = new Telerik.WinControls.UI.RadButton();
            this.closeBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessageTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // errorMessageTb
            // 
            this.errorMessageTb.Location = new System.Drawing.Point(12, 12);
            this.errorMessageTb.Multiline = true;
            this.errorMessageTb.Name = "errorMessageTb";
            // 
            // 
            // 
            this.errorMessageTb.RootElement.StretchVertically = true;
            this.errorMessageTb.Size = new System.Drawing.Size(352, 172);
            this.errorMessageTb.TabIndex = 0;
            this.errorMessageTb.ThemeName = "Crystal";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(99, 208);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(120, 36);
            this.copyBtn.TabIndex = 1;
            this.copyBtn.Text = "Copy";
            this.copyBtn.ThemeName = "Material";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(244, 208);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(120, 36);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.ThemeName = "Material";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ErrorMessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 256);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.errorMessageTb);
            this.Name = "ErrorMessageView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Error Message";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.errorMessageTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTextBox errorMessageTb;
        private Telerik.WinControls.UI.RadButton copyBtn;
        private Telerik.WinControls.UI.RadButton closeBtn;
    }
}
