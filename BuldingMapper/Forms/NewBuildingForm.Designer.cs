namespace BuildingMapper
{
    partial class NewBuildingForm
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
            mainTableLayoutPanel = new TableLayoutPanel();
            controlButtonPanel = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
            propertiesGroupBox = new GroupBox();
            propertiesTableLayoutPanel = new TableLayoutPanel();
            buildingNameLabel = new Label();
            floorPlanLabel = new Label();
            chooseFileButton = new Button();
            selectedFileLabel = new Label();
            buildingNameTextbox = new TextBox();
            noteLabel = new Label();
            floorNameLabel = new Label();
            label1 = new Label();
            floorNameTextbox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            mainTableLayoutPanel.SuspendLayout();
            controlButtonPanel.SuspendLayout();
            propertiesGroupBox.SuspendLayout();
            propertiesTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Controls.Add(controlButtonPanel, 0, 1);
            mainTableLayoutPanel.Controls.Add(propertiesGroupBox, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainTableLayoutPanel.Size = new Size(478, 344);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // controlButtonPanel
            // 
            controlButtonPanel.Controls.Add(cancelButton);
            controlButtonPanel.Controls.Add(saveButton);
            controlButtonPanel.Dock = DockStyle.Fill;
            controlButtonPanel.Location = new Point(3, 297);
            controlButtonPanel.Name = "controlButtonPanel";
            controlButtonPanel.Size = new Size(472, 44);
            controlButtonPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Location = new Point(360, 0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 44);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Left;
            saveButton.Enabled = false;
            saveButton.Location = new Point(0, 0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 44);
            saveButton.TabIndex = 0;
            saveButton.Text = "Done";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // propertiesGroupBox
            // 
            propertiesGroupBox.Controls.Add(propertiesTableLayoutPanel);
            propertiesGroupBox.Dock = DockStyle.Fill;
            propertiesGroupBox.Location = new Point(3, 3);
            propertiesGroupBox.Name = "propertiesGroupBox";
            propertiesGroupBox.Size = new Size(472, 288);
            propertiesGroupBox.TabIndex = 1;
            propertiesGroupBox.TabStop = false;
            propertiesGroupBox.Text = "Properties";
            // 
            // propertiesTableLayoutPanel
            // 
            propertiesTableLayoutPanel.ColumnCount = 2;
            propertiesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            propertiesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            propertiesTableLayoutPanel.Controls.Add(buildingNameLabel, 0, 0);
            propertiesTableLayoutPanel.Controls.Add(floorPlanLabel, 0, 1);
            propertiesTableLayoutPanel.Controls.Add(chooseFileButton, 0, 2);
            propertiesTableLayoutPanel.Controls.Add(selectedFileLabel, 1, 1);
            propertiesTableLayoutPanel.Controls.Add(buildingNameTextbox, 1, 0);
            propertiesTableLayoutPanel.Controls.Add(noteLabel, 0, 4);
            propertiesTableLayoutPanel.Controls.Add(floorNameLabel, 0, 3);
            propertiesTableLayoutPanel.Controls.Add(label1, 1, 2);
            propertiesTableLayoutPanel.Controls.Add(floorNameTextbox, 1, 3);
            propertiesTableLayoutPanel.Dock = DockStyle.Fill;
            propertiesTableLayoutPanel.Location = new Point(3, 27);
            propertiesTableLayoutPanel.Name = "propertiesTableLayoutPanel";
            propertiesTableLayoutPanel.RowCount = 3;
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            propertiesTableLayoutPanel.Size = new Size(466, 258);
            propertiesTableLayoutPanel.TabIndex = 0;
            // 
            // buildingNameLabel
            // 
            buildingNameLabel.Dock = DockStyle.Fill;
            buildingNameLabel.Location = new Point(3, 0);
            buildingNameLabel.Name = "buildingNameLabel";
            buildingNameLabel.Size = new Size(227, 42);
            buildingNameLabel.TabIndex = 0;
            buildingNameLabel.Text = "Building Name";
            buildingNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // floorPlanLabel
            // 
            floorPlanLabel.Dock = DockStyle.Fill;
            floorPlanLabel.Location = new Point(3, 42);
            floorPlanLabel.Name = "floorPlanLabel";
            floorPlanLabel.Size = new Size(227, 42);
            floorPlanLabel.TabIndex = 2;
            floorPlanLabel.Text = "Floor Plan Image";
            floorPlanLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chooseFileButton
            // 
            chooseFileButton.Dock = DockStyle.Fill;
            chooseFileButton.Location = new Point(3, 87);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(227, 36);
            chooseFileButton.TabIndex = 3;
            chooseFileButton.Text = "Choose File...";
            chooseFileButton.UseVisualStyleBackColor = true;
            chooseFileButton.Click += chooseFileButton_Click;
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.AutoEllipsis = true;
            selectedFileLabel.Dock = DockStyle.Fill;
            selectedFileLabel.Location = new Point(236, 42);
            selectedFileLabel.Name = "selectedFileLabel";
            selectedFileLabel.Size = new Size(227, 42);
            selectedFileLabel.TabIndex = 4;
            selectedFileLabel.Text = "(No file chosen)";
            selectedFileLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buildingNameTextbox
            // 
            buildingNameTextbox.Dock = DockStyle.Fill;
            buildingNameTextbox.Location = new Point(237, 5);
            buildingNameTextbox.Margin = new Padding(4, 5, 4, 5);
            buildingNameTextbox.Name = "buildingNameTextbox";
            buildingNameTextbox.Size = new Size(225, 31);
            buildingNameTextbox.TabIndex = 5;
            buildingNameTextbox.TextChanged += buildingNameTextbox_TextChanged;
            // 
            // noteLabel
            // 
            propertiesTableLayoutPanel.SetColumnSpan(noteLabel, 2);
            noteLabel.Dock = DockStyle.Fill;
            noteLabel.Location = new Point(5, 173);
            noteLabel.Margin = new Padding(5);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(456, 80);
            noteLabel.TabIndex = 6;
            noteLabel.Text = "Note: You must select a floor plan image. The selected image will be added as an initial floor. More floors can be added later.";
            // 
            // floorNameLabel
            // 
            floorNameLabel.Dock = DockStyle.Fill;
            floorNameLabel.Location = new Point(3, 126);
            floorNameLabel.Name = "floorNameLabel";
            floorNameLabel.Size = new Size(227, 42);
            floorNameLabel.TabIndex = 7;
            floorNameLabel.Text = "Floor Name";
            floorNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 84);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // floorNameTextbox
            // 
            floorNameTextbox.Dock = DockStyle.Fill;
            floorNameTextbox.Location = new Point(237, 131);
            floorNameTextbox.Margin = new Padding(4, 5, 4, 5);
            floorNameTextbox.Name = "floorNameTextbox";
            floorNameTextbox.Size = new Size(225, 31);
            floorNameTextbox.TabIndex = 2;
            floorNameTextbox.TextChanged += floorNameTextbox_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"PNG files|*.png|All files|*.*\"";
            // 
            // NewBuildingForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(478, 344);
            Controls.Add(mainTableLayoutPanel);
            Name = "NewBuildingForm";
            Text = "New Building";
            mainTableLayoutPanel.ResumeLayout(false);
            controlButtonPanel.ResumeLayout(false);
            propertiesGroupBox.ResumeLayout(false);
            propertiesTableLayoutPanel.ResumeLayout(false);
            propertiesTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Panel controlButtonPanel;
        private Button cancelButton;
        private Button saveButton;
        private GroupBox propertiesGroupBox;
        private TableLayoutPanel propertiesTableLayoutPanel;
        private Label buildingNameLabel;
        private Label floorPlanLabel;
        private Button chooseFileButton;
        private Label selectedFileLabel;
        private TextBox buildingNameTextbox;
        private Label label1;
        private Label noteLabel;
        private OpenFileDialog openFileDialog1;
        private Label floorNameLabel;
        private TextBox floorNameTextbox;
    }
}