namespace BuldingMapper
{
    partial class FloorEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            roomGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            roomButtonPanel = new Panel();
            editButton = new Button();
            RemoveButton = new Button();
            addButton = new Button();
            roomListBox = new ListBox();
            roomImageTablePanel = new TableLayoutPanel();
            toolGroupBox = new GroupBox();
            toolFlowLayoutPanel = new FlowLayoutPanel();
            startZoomButton = new Button();
            resetZoomButton = new Button();
            roomEditorPanel1 = new RoomEditorPanel();
            tableLayoutPanel1.SuspendLayout();
            roomGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            roomButtonPanel.SuspendLayout();
            roomImageTablePanel.SuspendLayout();
            toolGroupBox.SuspendLayout();
            toolFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(roomGroupBox, 1, 0);
            tableLayoutPanel1.Controls.Add(roomImageTablePanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(929, 470);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // roomGroupBox
            // 
            roomGroupBox.Controls.Add(tableLayoutPanel2);
            roomGroupBox.Dock = DockStyle.Fill;
            roomGroupBox.Location = new Point(653, 3);
            roomGroupBox.Name = "roomGroupBox";
            roomGroupBox.Padding = new Padding(0);
            roomGroupBox.Size = new Size(273, 464);
            roomGroupBox.TabIndex = 0;
            roomGroupBox.TabStop = false;
            roomGroupBox.Text = "Rooms";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(roomButtonPanel, 0, 1);
            tableLayoutPanel2.Controls.Add(roomListBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 24);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(273, 440);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // roomButtonPanel
            // 
            roomButtonPanel.Controls.Add(editButton);
            roomButtonPanel.Controls.Add(RemoveButton);
            roomButtonPanel.Controls.Add(addButton);
            roomButtonPanel.Dock = DockStyle.Fill;
            roomButtonPanel.Location = new Point(0, 405);
            roomButtonPanel.Margin = new Padding(0);
            roomButtonPanel.Name = "roomButtonPanel";
            roomButtonPanel.Size = new Size(273, 35);
            roomButtonPanel.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Fill;
            editButton.Location = new Point(112, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(49, 35);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Right;
            RemoveButton.Location = new Point(161, 0);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(112, 35);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Left;
            addButton.Location = new Point(0, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 35);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // roomListBox
            // 
            roomListBox.Dock = DockStyle.Fill;
            roomListBox.FormattingEnabled = true;
            roomListBox.ItemHeight = 25;
            roomListBox.Location = new Point(3, 3);
            roomListBox.Name = "roomListBox";
            roomListBox.Size = new Size(267, 399);
            roomListBox.TabIndex = 1;
            // 
            // roomImageTablePanel
            // 
            roomImageTablePanel.ColumnCount = 1;
            roomImageTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roomImageTablePanel.Controls.Add(toolGroupBox, 0, 1);
            roomImageTablePanel.Controls.Add(roomEditorPanel1, 0, 0);
            roomImageTablePanel.Dock = DockStyle.Fill;
            roomImageTablePanel.Location = new Point(0, 0);
            roomImageTablePanel.Margin = new Padding(0);
            roomImageTablePanel.Name = "roomImageTablePanel";
            roomImageTablePanel.RowCount = 2;
            roomImageTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roomImageTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            roomImageTablePanel.Size = new Size(650, 470);
            roomImageTablePanel.TabIndex = 1;
            // 
            // toolGroupBox
            // 
            toolGroupBox.Controls.Add(toolFlowLayoutPanel);
            toolGroupBox.Dock = DockStyle.Fill;
            toolGroupBox.Location = new Point(3, 398);
            toolGroupBox.Name = "toolGroupBox";
            toolGroupBox.Padding = new Padding(0);
            toolGroupBox.Size = new Size(644, 69);
            toolGroupBox.TabIndex = 0;
            toolGroupBox.TabStop = false;
            toolGroupBox.Text = "Tools";
            // 
            // toolFlowLayoutPanel
            // 
            toolFlowLayoutPanel.Controls.Add(startZoomButton);
            toolFlowLayoutPanel.Controls.Add(resetZoomButton);
            toolFlowLayoutPanel.Dock = DockStyle.Fill;
            toolFlowLayoutPanel.Location = new Point(0, 24);
            toolFlowLayoutPanel.Name = "toolFlowLayoutPanel";
            toolFlowLayoutPanel.Size = new Size(644, 45);
            toolFlowLayoutPanel.TabIndex = 0;
            // 
            // startZoomButton
            // 
            startZoomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startZoomButton.AutoSize = true;
            startZoomButton.Location = new Point(3, 3);
            startZoomButton.Name = "startZoomButton";
            startZoomButton.Size = new Size(112, 35);
            startZoomButton.TabIndex = 0;
            startZoomButton.Text = "Start Zoom";
            startZoomButton.UseVisualStyleBackColor = true;
            // 
            // resetZoomButton
            // 
            resetZoomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            resetZoomButton.AutoSize = true;
            resetZoomButton.Location = new Point(121, 3);
            resetZoomButton.Name = "resetZoomButton";
            resetZoomButton.Size = new Size(117, 35);
            resetZoomButton.TabIndex = 1;
            resetZoomButton.Text = "Reset Zoom";
            resetZoomButton.UseVisualStyleBackColor = true;
            // 
            // roomEditorPanel1
            // 
            roomEditorPanel1.Dock = DockStyle.Fill;
            roomEditorPanel1.Image = Properties.Resources.Darrin_10;
            roomEditorPanel1.Location = new Point(3, 3);
            roomEditorPanel1.Name = "roomEditorPanel1";
            roomEditorPanel1.Size = new Size(644, 389);
            roomEditorPanel1.Initialize();
            roomEditorPanel1.TabIndex = 1;
            // 
            // FloorEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FloorEditor";
            Size = new Size(929, 470);
            tableLayoutPanel1.ResumeLayout(false);
            roomGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            roomButtonPanel.ResumeLayout(false);
            roomImageTablePanel.ResumeLayout(false);
            toolGroupBox.ResumeLayout(false);
            toolFlowLayoutPanel.ResumeLayout(false);
            toolFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox roomGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel roomButtonPanel;
        private Button editButton;
        private Button RemoveButton;
        private Button addButton;
        private ListBox roomListBox;
        private TableLayoutPanel roomImageTablePanel;
        private GroupBox toolGroupBox;
        private FlowLayoutPanel toolFlowLayoutPanel;
        private Button startZoomButton;
        private Button resetZoomButton;
        private RoomEditorPanel roomEditorPanel1;
    }
}
