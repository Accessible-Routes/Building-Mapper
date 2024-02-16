namespace BuildingMapper.Forms
{
    partial class SaveWarningForm
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
            mainTablePanel = new TableLayoutPanel();
            buttonPanel = new Panel();
            cancelButton = new Button();
            continueButton = new Button();
            warningTextLabel = new Label();
            mainTablePanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTablePanel
            // 
            mainTablePanel.ColumnCount = 1;
            mainTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTablePanel.Controls.Add(buttonPanel, 0, 1);
            mainTablePanel.Controls.Add(warningTextLabel, 0, 0);
            mainTablePanel.Dock = DockStyle.Fill;
            mainTablePanel.Location = new Point(0, 0);
            mainTablePanel.Name = "mainTablePanel";
            mainTablePanel.RowCount = 2;
            mainTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainTablePanel.Size = new Size(328, 194);
            mainTablePanel.TabIndex = 0;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(cancelButton);
            buttonPanel.Controls.Add(continueButton);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(3, 147);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(322, 44);
            buttonPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Location = new Point(210, 0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 44);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Left;
            continueButton.Location = new Point(0, 0);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(112, 44);
            continueButton.TabIndex = 0;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // warningTextLabel
            // 
            warningTextLabel.Dock = DockStyle.Fill;
            warningTextLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            warningTextLabel.Location = new Point(3, 0);
            warningTextLabel.Name = "warningTextLabel";
            warningTextLabel.Padding = new Padding(5);
            warningTextLabel.Size = new Size(322, 144);
            warningTextLabel.TabIndex = 1;
            warningTextLabel.Text = "label1";
            // 
            // SaveWarningForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 194);
            Controls.Add(mainTablePanel);
            Name = "SaveWarningForm";
            Text = "Warning!";
            mainTablePanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTablePanel;
        private Panel buttonPanel;
        private Button cancelButton;
        private Button continueButton;
        private Label warningTextLabel;
    }
}