namespace BuildingMapper
{
    partial class RoomEditorForm
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
            tagsTableLayoutPanel = new TableLayoutPanel();
            controlButtonPanel = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
            tagsGroupBox = new GroupBox();
            tagsListCheckbox = new CheckedListBox();
            propertiesGroupBox = new GroupBox();
            propertiesTableLayoutPanel = new TableLayoutPanel();
            roomNameLabel = new Label();
            roomTypeLabel = new Label();
            roomNameTextBox = new TextBox();
            roomTypeComboBox = new ComboBox();
            connectionsGroupBox = new GroupBox();
            connectionsTableLayoutPanel = new TableLayoutPanel();
            connectionsButtonsPanel = new Panel();
            editButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            connectionsCheckedListBox = new CheckedListBox();
            mainTableLayoutPanel.SuspendLayout();
            tagsTableLayoutPanel.SuspendLayout();
            controlButtonPanel.SuspendLayout();
            tagsGroupBox.SuspendLayout();
            propertiesGroupBox.SuspendLayout();
            propertiesTableLayoutPanel.SuspendLayout();
            connectionsGroupBox.SuspendLayout();
            connectionsTableLayoutPanel.SuspendLayout();
            connectionsButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(tagsTableLayoutPanel, 0, 2);
            mainTableLayoutPanel.Controls.Add(propertiesGroupBox, 0, 0);
            mainTableLayoutPanel.Controls.Add(connectionsGroupBox, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 3;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            mainTableLayoutPanel.Size = new Size(478, 644);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // tagsTableLayoutPanel
            // 
            tagsTableLayoutPanel.ColumnCount = 1;
            tagsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tagsTableLayoutPanel.Controls.Add(controlButtonPanel, 0, 1);
            tagsTableLayoutPanel.Controls.Add(tagsGroupBox, 0, 0);
            tagsTableLayoutPanel.Dock = DockStyle.Fill;
            tagsTableLayoutPanel.Location = new Point(4, 390);
            tagsTableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tagsTableLayoutPanel.Name = "tagsTableLayoutPanel";
            tagsTableLayoutPanel.RowCount = 2;
            tagsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tagsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tagsTableLayoutPanel.Size = new Size(470, 249);
            tagsTableLayoutPanel.TabIndex = 2;
            // 
            // controlButtonPanel
            // 
            controlButtonPanel.Controls.Add(cancelButton);
            controlButtonPanel.Controls.Add(saveButton);
            controlButtonPanel.Dock = DockStyle.Fill;
            controlButtonPanel.Location = new Point(0, 199);
            controlButtonPanel.Margin = new Padding(0);
            controlButtonPanel.Name = "controlButtonPanel";
            controlButtonPanel.Size = new Size(470, 50);
            controlButtonPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Location = new Point(363, 0);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(107, 50);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Left;
            saveButton.Enabled = false;
            saveButton.Location = new Point(0, 0);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(107, 50);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // tagsGroupBox
            // 
            tagsGroupBox.Controls.Add(tagsListCheckbox);
            tagsGroupBox.Dock = DockStyle.Fill;
            tagsGroupBox.Location = new Point(4, 5);
            tagsGroupBox.Margin = new Padding(4, 5, 4, 5);
            tagsGroupBox.Name = "tagsGroupBox";
            tagsGroupBox.Padding = new Padding(4, 5, 4, 5);
            tagsGroupBox.Size = new Size(462, 189);
            tagsGroupBox.TabIndex = 1;
            tagsGroupBox.TabStop = false;
            tagsGroupBox.Text = "Tags";
            // 
            // tagsListCheckbox
            // 
            tagsListCheckbox.Dock = DockStyle.Fill;
            tagsListCheckbox.FormattingEnabled = true;
            tagsListCheckbox.Location = new Point(4, 29);
            tagsListCheckbox.Margin = new Padding(4, 5, 4, 5);
            tagsListCheckbox.Name = "tagsListCheckbox";
            tagsListCheckbox.Size = new Size(454, 155);
            tagsListCheckbox.TabIndex = 0;
            // 
            // propertiesGroupBox
            // 
            propertiesGroupBox.Controls.Add(propertiesTableLayoutPanel);
            propertiesGroupBox.Dock = DockStyle.Fill;
            propertiesGroupBox.Location = new Point(4, 5);
            propertiesGroupBox.Margin = new Padding(4, 5, 4, 5);
            propertiesGroupBox.Name = "propertiesGroupBox";
            propertiesGroupBox.Padding = new Padding(4, 5, 4, 5);
            propertiesGroupBox.Size = new Size(470, 118);
            propertiesGroupBox.TabIndex = 1;
            propertiesGroupBox.TabStop = false;
            propertiesGroupBox.Text = "Properties";
            // 
            // propertiesTableLayoutPanel
            // 
            propertiesTableLayoutPanel.ColumnCount = 2;
            propertiesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            propertiesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            propertiesTableLayoutPanel.Controls.Add(roomNameLabel, 0, 0);
            propertiesTableLayoutPanel.Controls.Add(roomTypeLabel, 0, 1);
            propertiesTableLayoutPanel.Controls.Add(roomNameTextBox, 1, 0);
            propertiesTableLayoutPanel.Controls.Add(roomTypeComboBox, 1, 1);
            propertiesTableLayoutPanel.Dock = DockStyle.Fill;
            propertiesTableLayoutPanel.Location = new Point(4, 29);
            propertiesTableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            propertiesTableLayoutPanel.Name = "propertiesTableLayoutPanel";
            propertiesTableLayoutPanel.RowCount = 5;
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            propertiesTableLayoutPanel.Size = new Size(462, 84);
            propertiesTableLayoutPanel.TabIndex = 0;
            // 
            // roomNameLabel
            // 
            roomNameLabel.Dock = DockStyle.Fill;
            roomNameLabel.Location = new Point(4, 0);
            roomNameLabel.Margin = new Padding(4, 0, 4, 0);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new Size(223, 42);
            roomNameLabel.TabIndex = 0;
            roomNameLabel.Text = "Room Name";
            roomNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.Dock = DockStyle.Fill;
            roomTypeLabel.Location = new Point(4, 42);
            roomTypeLabel.Margin = new Padding(4, 0, 4, 0);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(223, 42);
            roomTypeLabel.TabIndex = 1;
            roomTypeLabel.Text = "Room Type";
            roomTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.Dock = DockStyle.Fill;
            roomNameTextBox.Location = new Point(235, 5);
            roomNameTextBox.Margin = new Padding(4, 5, 4, 5);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Size = new Size(223, 31);
            roomNameTextBox.TabIndex = 2;
            roomNameTextBox.TextChanged += roomNameTextBox_TextChanged;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.DisplayMember = "(none)";
            roomTypeComboBox.Dock = DockStyle.Fill;
            roomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.Location = new Point(235, 47);
            roomTypeComboBox.Margin = new Padding(4, 5, 4, 5);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(223, 33);
            roomTypeComboBox.TabIndex = 3;
            roomTypeComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // connectionsGroupBox
            // 
            connectionsGroupBox.Controls.Add(connectionsTableLayoutPanel);
            connectionsGroupBox.Dock = DockStyle.Fill;
            connectionsGroupBox.Location = new Point(3, 131);
            connectionsGroupBox.Name = "connectionsGroupBox";
            connectionsGroupBox.Size = new Size(472, 251);
            connectionsGroupBox.TabIndex = 3;
            connectionsGroupBox.TabStop = false;
            connectionsGroupBox.Text = "Connections";
            // 
            // connectionsTableLayoutPanel
            // 
            connectionsTableLayoutPanel.ColumnCount = 1;
            connectionsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            connectionsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            connectionsTableLayoutPanel.Controls.Add(connectionsButtonsPanel, 0, 1);
            connectionsTableLayoutPanel.Controls.Add(connectionsCheckedListBox, 0, 0);
            connectionsTableLayoutPanel.Dock = DockStyle.Fill;
            connectionsTableLayoutPanel.Location = new Point(3, 27);
            connectionsTableLayoutPanel.Name = "connectionsTableLayoutPanel";
            connectionsTableLayoutPanel.RowCount = 2;
            connectionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            connectionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            connectionsTableLayoutPanel.Size = new Size(466, 221);
            connectionsTableLayoutPanel.TabIndex = 0;
            // 
            // connectionsButtonsPanel
            // 
            connectionsButtonsPanel.Controls.Add(editButton);
            connectionsButtonsPanel.Controls.Add(removeButton);
            connectionsButtonsPanel.Controls.Add(addButton);
            connectionsButtonsPanel.Dock = DockStyle.Fill;
            connectionsButtonsPanel.Location = new Point(0, 171);
            connectionsButtonsPanel.Margin = new Padding(0);
            connectionsButtonsPanel.Name = "connectionsButtonsPanel";
            connectionsButtonsPanel.Size = new Size(466, 50);
            connectionsButtonsPanel.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Fill;
            editButton.Enabled = false;
            editButton.Location = new Point(112, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(242, 50);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // removeButton
            // 
            removeButton.Dock = DockStyle.Right;
            removeButton.Location = new Point(354, 0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 50);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Left;
            addButton.Location = new Point(0, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 50);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // connectionsCheckedListBox
            // 
            connectionsCheckedListBox.Dock = DockStyle.Fill;
            connectionsCheckedListBox.FormattingEnabled = true;
            connectionsCheckedListBox.Location = new Point(3, 3);
            connectionsCheckedListBox.Name = "connectionsCheckedListBox";
            connectionsCheckedListBox.Size = new Size(460, 165);
            connectionsCheckedListBox.TabIndex = 1;
            connectionsCheckedListBox.SelectedIndexChanged += connectionsCheckedListBox_SelectedIndexChanged;
            // 
            // RoomEditorForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(478, 644);
            Controls.Add(mainTableLayoutPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RoomEditorForm";
            Text = "RoomEditor";
            mainTableLayoutPanel.ResumeLayout(false);
            tagsTableLayoutPanel.ResumeLayout(false);
            controlButtonPanel.ResumeLayout(false);
            tagsGroupBox.ResumeLayout(false);
            propertiesGroupBox.ResumeLayout(false);
            propertiesTableLayoutPanel.ResumeLayout(false);
            propertiesTableLayoutPanel.PerformLayout();
            connectionsGroupBox.ResumeLayout(false);
            connectionsTableLayoutPanel.ResumeLayout(false);
            connectionsButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private GroupBox propertiesGroupBox;
        private TableLayoutPanel propertiesTableLayoutPanel;
        private Label roomNameLabel;
        private Label roomTypeLabel;
        private TextBox roomNameTextBox;
        private ComboBox roomTypeComboBox;
        private TableLayoutPanel tagsTableLayoutPanel;
        private Panel controlButtonPanel;
        private Button cancelButton;
        private Button saveButton;
        private GroupBox tagsGroupBox;
        private CheckedListBox tagsListCheckbox;
        private GroupBox connectionsGroupBox;
        private TableLayoutPanel connectionsTableLayoutPanel;
        private Panel connectionsButtonsPanel;
        private Button editButton;
        private Button removeButton;
        private Button addButton;
        private CheckedListBox connectionsCheckedListBox;
    }
}