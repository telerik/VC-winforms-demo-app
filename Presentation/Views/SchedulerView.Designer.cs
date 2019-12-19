namespace Presentation.Views
{
    partial class SchedulerView
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo1 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo1 = new Telerik.WinControls.UI.ResourceMappingInfo();
            this.layoutControlItem1 = new Telerik.WinControls.UI.LayoutControlItem();
            this.radDataLayout1 = new Telerik.WinControls.UI.RadDataLayout();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulerDataSet = new Presentation.SchedulerDataSet();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.layoutControlItem2 = new Telerik.WinControls.UI.LayoutControlItem();
            this.layoutControlItem3 = new Telerik.WinControls.UI.LayoutControlItem();
            this.examsTableAdapter = new Presentation.SchedulerDataSetTableAdapters.ExamsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1.LayoutControl)).BeginInit();
            this.radDataLayout1.LayoutControl.SuspendLayout();
            this.radDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AssociatedControl = null;
            this.layoutControlItem1.Bounds = new System.Drawing.Rectangle(0, 0, 798, 448);
            this.layoutControlItem1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "";
            this.layoutControlItem1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.layoutControlItem1.UseCompatibleTextRendering = false;
            // 
            // radDataLayout1
            // 
            this.radDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // radDataLayout1.LayoutControl
            // 
            this.radDataLayout1.LayoutControl.Controls.Add(this.radScheduler1);
            this.radDataLayout1.LayoutControl.Controls.Add(this.radSchedulerNavigator1);
            this.radDataLayout1.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDataLayout1.LayoutControl.DrawBorder = false;
            this.radDataLayout1.LayoutControl.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.radDataLayout1.LayoutControl.Location = new System.Drawing.Point(0, 0);
            this.radDataLayout1.LayoutControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDataLayout1.LayoutControl.Name = "LayoutControl";
            this.radDataLayout1.LayoutControl.Size = new System.Drawing.Size(974, 587);
            this.radDataLayout1.LayoutControl.TabIndex = 0;
            this.radDataLayout1.LayoutControl.ThemeName = "Crystal";
            this.radDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.radDataLayout1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radDataLayout1.Name = "radDataLayout1";
            this.radDataLayout1.Size = new System.Drawing.Size(974, 587);
            this.radDataLayout1.TabIndex = 0;
            this.radDataLayout1.ThemeName = "Crystal";
            // 
            // radScheduler1
            // 
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.DataSource = this.schedulerBindingDataSource1;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.Location = new System.Drawing.Point(4, 88);
            this.radScheduler1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2019, 6, 23, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2019, 6, 18, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(966, 495);
            this.radScheduler1.TabIndex = 3;
            this.radScheduler1.AppointmentDeleted += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentDeleted);
            this.radScheduler1.AppointmentAdded += new System.EventHandler<Telerik.WinControls.UI.AppointmentAddedEventArgs>(this.radScheduler1_AppointmentAdded);
            this.radScheduler1.AppointmentChanged += new System.EventHandler<Telerik.WinControls.UI.AppointmentChangedEventArgs>(this.radScheduler1_AppointmentChanged);
            // 
            // schedulerBindingDataSource1
            // 
            // 
            // 
            // 
            this.schedulerBindingDataSource1.EventProvider.DataSource = this.examsBindingSource;
            appointmentMappingInfo1.End = "ExaminationTimeEnd";
            appointmentMappingInfo1.Location = "Hall";
            appointmentMappingInfo1.Start = "ExaminationTimeStart";
            appointmentMappingInfo1.Summary = "Description";
            appointmentMappingInfo1.UniqueId = "Id";
            this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo1;
            // 
            // 
            // 
            this.schedulerBindingDataSource1.ResourceProvider.DataSource = this.examsBindingSource;
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo1;
            // 
            // examsBindingSource
            // 
            this.examsBindingSource.DataMember = "Exams";
            this.examsBindingSource.DataSource = this.schedulerDataSet;
            // 
            // schedulerDataSet
            // 
            this.schedulerDataSet.DataSetName = "SchedulerDataSet";
            this.schedulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(4, 4);
            this.radSchedulerNavigator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(966, 77);
            this.radSchedulerNavigator1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AssociatedControl = this.radScheduler1;
            this.layoutControlItem2.Bounds = new System.Drawing.Rectangle(0, 84, 972, 501);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AssociatedControl = this.radSchedulerNavigator1;
            this.layoutControlItem3.Bounds = new System.Drawing.Rectangle(0, 0, 972, 84);
            this.layoutControlItem3.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "layoutControlItem3";
            // 
            // examsTableAdapter
            // 
            this.examsTableAdapter.ClearBeforeFill = true;
            // 
            // SchedulerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.radDataLayout1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SchedulerView";
            this.Size = new System.Drawing.Size(974, 587);
            this.Load += new System.EventHandler(this.SchedulerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1.LayoutControl)).EndInit();
            this.radDataLayout1.LayoutControl.ResumeLayout(false);
            this.radDataLayout1.LayoutControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1)).EndInit();
            this.radDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem1;
        private Telerik.WinControls.UI.RadDataLayout radDataLayout1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem2;
        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private SchedulerDataSet schedulerDataSet;
        private System.Windows.Forms.BindingSource examsBindingSource;
        private SchedulerDataSetTableAdapters.ExamsTableAdapter examsTableAdapter;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem3;
    }
}