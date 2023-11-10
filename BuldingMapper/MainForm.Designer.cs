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
            mainTableLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
            roomEditorTablePanel = new TableLayoutPanel();
            roomEditor = new RoomEditorPanel();
            toolGroupBox = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            startZoomButton = new Button();
            resetZoomButton = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            roomListBox = new ListBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            mainTableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            roomEditorTablePanel.SuspendLayout();
            toolGroupBox.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            toolStripTableLayoutPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            mainTableLayoutPanel.Controls.Add(panel1, 0, 0);
            mainTableLayoutPanel.Controls.Add(groupBox1, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(3, 33);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(1253, 627);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(roomEditorTablePanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 621);
            panel1.TabIndex = 0;
            // 
            // roomEditorTablePanel
            // 
            roomEditorTablePanel.ColumnCount = 1;
            roomEditorTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roomEditorTablePanel.Controls.Add(roomEditor, 0, 0);
            roomEditorTablePanel.Controls.Add(toolGroupBox, 0, 1);
            roomEditorTablePanel.Dock = DockStyle.Fill;
            roomEditorTablePanel.Location = new Point(0, 0);
            roomEditorTablePanel.Name = "roomEditorTablePanel";
            roomEditorTablePanel.RowCount = 2;
            roomEditorTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            roomEditorTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            roomEditorTablePanel.Size = new Size(808, 621);
            roomEditorTablePanel.TabIndex = 0;
            // 
            // roomEditor
            // 
            roomEditor.Dock = DockStyle.Fill;
            roomEditor.Image = Properties.Resources.Darrin_10;
            roomEditor.Location = new Point(3, 3);
            roomEditor.Name = "roomEditor";
            roomEditor.Size = new Size(802, 540);
            roomEditor.TabIndex = 0;
            // 
            // toolGroupBox
            // 
            toolGroupBox.Controls.Add(flowLayoutPanel1);
            toolGroupBox.Dock = DockStyle.Fill;
            toolGroupBox.Location = new Point(3, 549);
            toolGroupBox.Name = "toolGroupBox";
            toolGroupBox.Size = new Size(802, 69);
            toolGroupBox.TabIndex = 1;
            toolGroupBox.TabStop = false;
            toolGroupBox.Text = "Tools";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(startZoomButton);
            flowLayoutPanel1.Controls.Add(resetZoomButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 27);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(796, 39);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // startZoomButton
            // 
            startZoomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startZoomButton.AutoSize = true;
            startZoomButton.Location = new Point(3, 3);
            startZoomButton.Name = "startZoomButton";
            startZoomButton.Size = new Size(126, 35);
            startZoomButton.TabIndex = 0;
            startZoomButton.Text = "Start Zoom";
            startZoomButton.UseVisualStyleBackColor = true;
            // 
            // resetZoomButton
            // 
            resetZoomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            resetZoomButton.AutoSize = true;
            resetZoomButton.Location = new Point(135, 3);
            resetZoomButton.Name = "resetZoomButton";
            resetZoomButton.Size = new Size(117, 35);
            resetZoomButton.TabIndex = 1;
            resetZoomButton.Text = "Reset Zoom";
            resetZoomButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(818, 5);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(431, 617);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rooms";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Controls.Add(roomListBox, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 29);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(423, 583);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // roomListBox
            // 
            roomListBox.Dock = DockStyle.Fill;
            roomListBox.FormattingEnabled = true;
            roomListBox.ItemHeight = 25;
            roomListBox.Location = new Point(4, 5);
            roomListBox.Margin = new Padding(4, 5, 4, 5);
            roomListBox.Name = "roomListBox";
            roomListBox.Size = new Size(415, 514);
            roomListBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 529);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 49);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(107, 0);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(201, 49);
            button3.TabIndex = 2;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(308, 0);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 49);
            button2.TabIndex = 1;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // toolStripTableLayoutPanel
            // 
            toolStripTableLayoutPanel.ColumnCount = 1;
            toolStripTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            toolStripTableLayoutPanel.Controls.Add(toolStrip1, 0, 0);
            toolStripTableLayoutPanel.Controls.Add(mainTableLayoutPanel, 0, 1);
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
            newToolStripMenuItem.Size = new Size(270, 34);
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
            openToolStripMenuItem.Size = new Size(270, 34);
            openToolStripMenuItem.Text = "Open";
            // 
            // openFloorToolStripMenuItem
            // 
            openFloorToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openFloorToolStripMenuItem.Name = "openFloorToolStripMenuItem";
            openFloorToolStripMenuItem.Size = new Size(270, 34);
            openFloorToolStripMenuItem.Text = "Open Floor";
            // 
            // openBuildingToolStripMenuItem
            // 
            openBuildingToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openBuildingToolStripMenuItem.Name = "openBuildingToolStripMenuItem";
            openBuildingToolStripMenuItem.Size = new Size(270, 34);
            openBuildingToolStripMenuItem.Text = "Open Building";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveBuildingToolStripMenuItem, saveFloorToolStripMenuItem, saveBuildingAsToolStripMenuItem, saveFloorAsToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(270, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveBuildingToolStripMenuItem
            // 
            saveBuildingToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveBuildingToolStripMenuItem.Name = "saveBuildingToolStripMenuItem";
            saveBuildingToolStripMenuItem.Size = new Size(270, 34);
            saveBuildingToolStripMenuItem.Text = "Save Building";
            saveBuildingToolStripMenuItem.Click += saveBuildingToolStripMenuItem_Click;
            // 
            // saveFloorToolStripMenuItem
            // 
            saveFloorToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveFloorToolStripMenuItem.Name = "saveFloorToolStripMenuItem";
            saveFloorToolStripMenuItem.Size = new Size(270, 34);
            saveFloorToolStripMenuItem.Text = "Save Floor";
            // 
            // saveBuildingAsToolStripMenuItem
            // 
            saveBuildingAsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveBuildingAsToolStripMenuItem.Name = "saveBuildingAsToolStripMenuItem";
            saveBuildingAsToolStripMenuItem.Size = new Size(270, 34);
            saveBuildingAsToolStripMenuItem.Text = "Save Building As...";
            // 
            // saveFloorAsToolStripMenuItem
            // 
            saveFloorAsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveFloorAsToolStripMenuItem.Name = "saveFloorAsToolStripMenuItem";
            saveFloorAsToolStripMenuItem.Size = new Size(270, 34);
            saveFloorAsToolStripMenuItem.Text = "Save Floor As...";
            saveFloorAsToolStripMenuItem.Click += saveFloorAsToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(270, 34);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 663);
            Controls.Add(toolStripTableLayoutPanel);
            Name = "MainForm";
            Text = "Room Editor";
            mainTableLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            roomEditorTablePanel.ResumeLayout(false);
            toolGroupBox.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            toolStripTableLayoutPanel.ResumeLayout(false);
            toolStripTableLayoutPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Panel panel1;
        private GroupBox groupBox1;
        private ListBox roomListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel roomEditorTablePanel;
        private RoomEditorPanel roomEditor;
        private GroupBox toolGroupBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button startZoomButton;
        private Button resetZoomButton;
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
    }
}