namespace Presentation
{
    partial class MainView
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            this.radTreeViewNavigation = new Telerik.WinControls.UI.RadTreeView();
            this.mainRadPanel = new Telerik.WinControls.UI.RadPanel();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRadPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeViewNavigation
            // 
            this.radTreeViewNavigation.BackColor = System.Drawing.SystemColors.Control;
            this.radTreeViewNavigation.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeViewNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeViewNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radTreeViewNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radTreeViewNavigation.ItemHeight = 35;
            this.radTreeViewNavigation.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.radTreeViewNavigation.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            this.radTreeViewNavigation.Location = new System.Drawing.Point(0, 0);
            this.radTreeViewNavigation.Name = "radTreeViewNavigation";
            radTreeNode1.Name = "Node7";
            radTreeNode1.Text = "Inputs";
            radTreeNode2.Name = "Node8";
            radTreeNode2.Text = "Chart";
            radTreeNode3.Name = "Node9";
            radTreeNode3.Text = "Grid";
            radTreeNode4.Name = "Node10";
            radTreeNode4.Text = "Spreadsheet";
            radTreeNode5.Name = "Node11";
            radTreeNode5.Text = "Scheduler";
            radTreeNode6.Name = "Node12";
            radTreeNode6.Text = "Report";
            this.radTreeViewNavigation.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode2,
            radTreeNode3,
            radTreeNode4,
            radTreeNode5,
            radTreeNode6});
            this.radTreeViewNavigation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radTreeViewNavigation.RootElement.ApplyShapeToControl = true;
            this.radTreeViewNavigation.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.radTreeViewNavigation.RootElement.BorderHighlightThickness = 4;
            this.radTreeViewNavigation.Size = new System.Drawing.Size(202, 587);
            this.radTreeViewNavigation.SpacingBetweenNodes = -1;
            this.radTreeViewNavigation.TabIndex = 5;
            this.radTreeViewNavigation.ThemeName = "MaterialBlueGrey";
            this.radTreeViewNavigation.NodeMouseClick += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.radTreeViewNavigation_NodeMouseClick);
            // 
            // mainRadPanel
            // 
            this.mainRadPanel.AutoSize = true;
            this.mainRadPanel.BackColor = System.Drawing.Color.White;
            this.mainRadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRadPanel.Location = new System.Drawing.Point(202, 0);
            this.mainRadPanel.Name = "mainRadPanel";
            this.mainRadPanel.Size = new System.Drawing.Size(974, 587);
            this.mainRadPanel.TabIndex = 6;
            this.mainRadPanel.ThemeName = "Material";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(1176, 587);
            this.Controls.Add(this.mainRadPanel);
            this.Controls.Add(this.radTreeViewNavigation);
            this.Name = "MainView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Demo";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewNavigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRadPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTreeView radTreeViewNavigation;
        private Telerik.WinControls.UI.RadPanel mainRadPanel;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
    }
}

