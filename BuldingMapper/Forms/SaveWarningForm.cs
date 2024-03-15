using BuildingMapper.FormResults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingMapper.Forms
{
    public partial class SaveWarningForm : Form
    {
        public SaveWarningForm()
        {
            InitializeComponent();
        }

        public SaveWarningFormResult ShowDialog(string buildingName)
        {
            warningTextLabel.Text = "You have unsaved changes to \"" + buildingName
                + "\". Are you sure you want to continue? "
                + "\n Any unsaved changes will be lost.";

            DialogResult dialogResult = ShowDialog();

            SaveWarningFormResult result = new SaveWarningFormResult() { DialogResult = dialogResult };

            return result;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
