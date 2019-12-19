namespace Presentation.Views
{
    partial class ChartView
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.BarSeries barSeries1 = new Telerik.WinControls.UI.BarSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint1 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint2 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint3 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.WinControls.UI.BarSeries barSeries2 = new Telerik.WinControls.UI.BarSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint4 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint5 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint6 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.WinControls.UI.BarSeries barSeries3 = new Telerik.WinControls.UI.BarSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint7 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint8 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint9 = new Telerik.Charting.CategoricalDataPoint();
            this.radChartView = new Telerik.WinControls.UI.RadChartView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radRangeSelector1 = new Telerik.WinControls.UI.RadRangeSelector();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView)).BeginInit();
            this.radChartView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRangeSelector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.radChartView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radChartView
            // 
            this.radChartView.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.radChartView.Controls.Add(this.radLabel1);
            this.radChartView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView.Location = new System.Drawing.Point(0, 0);
            this.radChartView.Name = "radChartView";
            this.radChartView.ShowGrid = false;
            this.radChartView.ShowLegend = true;
            this.radChartView.ShowPanZoom = true;
            this.radChartView.ShowTitle = true;
            this.radChartView.ShowToolTip = true;
            this.radChartView.ShowTrackBall = true;
            this.radChartView.Size = new System.Drawing.Size(407, 588);
            this.radChartView.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Gray;
            this.radLabel1.Location = new System.Drawing.Point(23, 1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(338, 40);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Students by specialties";
            this.radLabel1.ThemeName = "Material";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(980, 588);
            this.radSplitContainer1.SplitterWidth = 8;
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "Material";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radChartView);
            this.splitPanel2.Location = new System.Drawing.Point(0, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(407, 588);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.08127573F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-79, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "Material";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radRangeSelector1);
            this.splitPanel1.Controls.Add(this.radChartView1);
            this.splitPanel1.Location = new System.Drawing.Point(415, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(565, 588);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.0812757F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(79, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "Material";
            // 
            // radRangeSelector1
            // 
            this.radRangeSelector1.AssociatedControl = this.radChartView1;
            this.radRangeSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radRangeSelector1.Location = new System.Drawing.Point(0, 438);
            this.radRangeSelector1.Name = "radRangeSelector1";
            this.radRangeSelector1.Size = new System.Drawing.Size(565, 150);
            this.radRangeSelector1.TabIndex = 2;
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.LabelRotationAngle = 300D;
            categoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.MajorStep = 10D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "";
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.radChartView1.Controls.Add(this.radLabel2);
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radChartView1.LegendTitle = "Specialties";
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            categoricalDataPoint1.Category = "Web Design";
            categoricalDataPoint1.Label = 78D;
            categoricalDataPoint1.Value = 78D;
            categoricalDataPoint2.Category = "Algebra";
            categoricalDataPoint2.Label = 57D;
            categoricalDataPoint2.Value = 57D;
            categoricalDataPoint3.Category = "Physics";
            categoricalDataPoint3.Label = 65D;
            categoricalDataPoint3.Value = 65D;
            barSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint1,
            categoricalDataPoint2,
            categoricalDataPoint3});
            barSeries1.HorizontalAxis = categoricalAxis1;
            barSeries1.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top;
            barSeries1.LegendTitle = "Networking";
            barSeries1.VerticalAxis = linearAxis1;
            categoricalDataPoint4.Category = "Web Design";
            categoricalDataPoint4.Label = 95D;
            categoricalDataPoint4.Value = 95D;
            categoricalDataPoint5.Category = "Algebra";
            categoricalDataPoint5.Label = 80D;
            categoricalDataPoint5.Value = 80D;
            categoricalDataPoint6.Category = "Physics";
            categoricalDataPoint6.Label = 47D;
            categoricalDataPoint6.Value = 47D;
            barSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint4,
            categoricalDataPoint5,
            categoricalDataPoint6});
            barSeries2.HorizontalAxis = categoricalAxis1;
            barSeries2.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top;
            barSeries2.LegendTitle = "Computer Science";
            barSeries2.VerticalAxis = linearAxis1;
            categoricalDataPoint7.Category = "Web Design";
            categoricalDataPoint7.Label = 56D;
            categoricalDataPoint7.Value = 56D;
            categoricalDataPoint8.Category = "Algebra";
            categoricalDataPoint8.Label = 98D;
            categoricalDataPoint8.Value = 98D;
            categoricalDataPoint9.Category = "Physics";
            categoricalDataPoint9.Label = 95D;
            categoricalDataPoint9.Value = 95D;
            barSeries3.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint7,
            categoricalDataPoint8,
            categoricalDataPoint9});
            barSeries3.HorizontalAxis = categoricalAxis1;
            barSeries3.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top;
            barSeries3.LegendTitle = "Electronics";
            barSeries3.VerticalAxis = linearAxis1;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            barSeries1,
            barSeries2,
            barSeries3});
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowLegend = true;
            this.radChartView1.ShowPanZoom = true;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.ShowTrackBall = true;
            this.radChartView1.Size = new System.Drawing.Size(565, 437);
            this.radChartView1.TabIndex = 1;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Gray;
            this.radLabel2.Location = new System.Drawing.Point(55, 2);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(430, 40);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Average grades by specialty";
            this.radLabel2.ThemeName = "Material";
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "ChartView";
            this.Size = new System.Drawing.Size(980, 588);
            this.Load += new System.EventHandler(this.ChartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView)).EndInit();
            this.radChartView.ResumeLayout(false);
            this.radChartView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRangeSelector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.radChartView1.ResumeLayout(false);
            this.radChartView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadChartView radChartView;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadRangeSelector radRangeSelector1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
    }
}
