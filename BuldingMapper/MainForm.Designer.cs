namespace BuldingMapper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripTableLayoutPanel = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            newToolStripMenuItem = new ToolStripMenuItem();
            newBuildingToolStripMenuItem = new ToolStripMenuItem();
            newFloorFromImageToolStripMenuItem = new ToolStripMenuItem();
            newFloorFromExistingFloorPlanToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openFloorToolStripMenuItem = new ToolStripMenuItem();
            openBuildingToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveBuildingToolStripMenuItem = new ToolStripMenuItem();
            saveFloorToolStripMenuItem = new ToolStripMenuItem();
            saveBuildingAsToolStripMenuItem = new ToolStripMenuItem();
            saveFloorAsToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            floorEditor1 = new FloorEditor();
            floorEditor2 = new FloorEditor();
            toolStripTableLayoutPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripTableLayoutPanel
            // 
            toolStripTableLayoutPanel.ColumnCount = 1;
            toolStripTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            toolStripTableLayoutPanel.Controls.Add(toolStrip1, 0, 0);
            toolStripTableLayoutPanel.Controls.Add(tabControl1, 0, 1);
            toolStripTableLayoutPanel.Dock = DockStyle.Fill;
            toolStripTableLayoutPanel.Location = new Point(0, 0);
            toolStripTableLayoutPanel.Margin = new Padding(0);
            toolStripTableLayoutPanel.Name = "toolStripTableLayoutPanel";
            toolStripTableLayoutPanel.RowCount = 2;
            toolStripTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            toolStripTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolStripTableLayoutPanel.Size = new Size(1259, 663);
            toolStripTableLayoutPanel.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(1259, 30);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, quitToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(56, 25);
            toolStripDropDownButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            newToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newBuildingToolStripMenuItem, newFloorFromImageToolStripMenuItem, newFloorFromExistingFloorPlanToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(158, 34);
            newToolStripMenuItem.Text = "New";
            // 
            // newBuildingToolStripMenuItem
            // 
            newBuildingToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newBuildingToolStripMenuItem.Name = "newBuildingToolStripMenuItem";
            newBuildingToolStripMenuItem.Size = new Size(391, 34);
            newBuildingToolStripMenuItem.Text = "New Building";
            // 
            // newFloorFromImageToolStripMenuItem
            // 
            newFloorFromImageToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newFloorFromImageToolStripMenuItem.Name = "newFloorFromImageToolStripMenuItem";
            newFloorFromImageToolStripMenuItem.Size = new Size(391, 34);
            newFloorFromImageToolStripMenuItem.Text = "New Floor From Image";
            // 
            // newFloorFromExistingFloorPlanToolStripMenuItem
            // 
            newFloorFromExistingFloorPlanToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newFloorFromExistingFloorPlanToolStripMenuItem.Name = "newFloorFromExistingFloorPlanToolStripMenuItem";
            newFloorFromExistingFloorPlanToolStripMenuItem.Size = new Size(391, 34);
            newFloorFromExistingFloorPlanToolStripMenuItem.Text = "New Floor From Existing Floor Plan";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFloorToolStripMenuItem, openBuildingToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(158, 34);
            openToolStripMenuItem.Text = "Open";
            // 
            // openFloorToolStripMenuItem
            // 
            openFloorToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openFloorToolStripMenuItem.Name = "openFloorToolStripMenuItem";
            openFloorToolStripMenuItem.Size = new Size(227, 34);
            openFloorToolStripMenuItem.Text = "Open Floor";
            // 
            // openBuildingToolStripMenuItem
            // 
            openBuildingToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openBuildingToolStripMenuItem.Name = "openBuildingToolStripMenuItem";
            openBuildingToolStripMenuItem.Size = new Size(227, 34);
            openBuildingToolStripMenuItem.Text = "Open Building";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveBuildingToolStripMenuItem, saveFloorToolStripMenuItem, saveBuildingAsToolStripMenuItem, saveFloorAsToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(158, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveBuildingToolStripMenuItem
            // 
            saveBuildingToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveBuildingToolStripMenuItem.Name = "saveBuildingToolStripMenuItem";
            saveBuildingToolStripMenuItem.Size = new Size(257, 34);
            saveBuildingToolStripMenuItem.Text = "Save Building";
            saveBuildingToolStripMenuItem.Click += saveBuildingToolStripMenuItem_Click;
            // 
            // saveFloorToolStripMenuItem
            // 
            saveFloorToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveFloorToolStripMenuItem.Name = "saveFloorToolStripMenuItem";
            saveFloorToolStripMenuItem.Size = new Size(257, 34);
            saveFloorToolStripMenuItem.Text = "Save Floor";
            // 
            // saveBuildingAsToolStripMenuItem
            // 
            saveBuildingAsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveBuildingAsToolStripMenuItem.Name = "saveBuildingAsToolStripMenuItem";
            saveBuildingAsToolStripMenuItem.Size = new Size(257, 34);
            saveBuildingAsToolStripMenuItem.Text = "Save Building As...";
            // 
            // saveFloorAsToolStripMenuItem
            // 
            saveFloorAsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveFloorAsToolStripMenuItem.Name = "saveFloorAsToolStripMenuItem";
            saveFloorAsToolStripMenuItem.Size = new Size(257, 34);
            saveFloorAsToolStripMenuItem.Text = "Save Floor As...";
            saveFloorAsToolStripMenuItem.Click += saveFloorAsToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(158, 34);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1253, 627);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(floorEditor1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1245, 589);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(floorEditor2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1245, 589);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // floorEditor1
            // 
            floorEditor1.Dock = DockStyle.Fill;
            floorEditor1.Location = new Point(3, 3);
            floorEditor1.Name = "floorEditor1";
            floorEditor1.Size = new Size(1239, 583);
            floorEditor1.TabIndex = 0;
            // 
            // floorEditor2
            // 
            floorEditor2.Dock = DockStyle.Fill;
            floorEditor2.Location = new Point(3, 3);
            floorEditor2.Name = "floorEditor2";
            floorEditor2.Size = new Size(1239, 583);
            floorEditor2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 663);
            Controls.Add(toolStripTableLayoutPanel);
            Name = "MainForm";
            Text = "Room Editor";
            toolStripTableLayoutPanel.ResumeLayout(false);
            toolStripTableLayoutPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel toolStripTableLayoutPanel;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openFloorToolStripMenuItem;
        private ToolStripMenuItem openBuildingToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveBuildingToolStripMenuItem;
        private ToolStripMenuItem saveFloorToolStripMenuItem;
        private ToolStripMenuItem saveBuildingAsToolStripMenuItem;
        private ToolStripMenuItem saveFloorAsToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newBuildingToolStripMenuItem;
        private ToolStripMenuItem newFloorFromImageToolStripMenuItem;
        private ToolStripMenuItem newFloorFromExistingFloorPlanToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FloorEditor floorEditor1;
        private TabPage tabPage2;
        private FloorEditor floorEditor2;
    }
}