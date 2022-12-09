using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craftersmine.Aesir.Forms
{
    public partial class CreateArchiveDialog : Form
    {
        public CreateArchiveDialog()
        {
            InitializeComponent();
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (archiveName.Text.Length == 0 || outputDirectoryTextBox.Text.Length == 0)
                createButton.Enabled = false;
            else createButton.Enabled = true;
            archivePathLabel.Text = Path.Combine(outputDirectoryTextBox.Text, archiveName.Text + ".asar");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(outputDirectoryTextBox.Text))
            {
                MessageBox.Show(
                    "Unable to locate output directory at specified path! Choose a different path and try again",
                    "Error while locating output directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //StaticData.OpenedArchive = Archive.CreateArchive(Path.Combine(outputDirectoryTextBox.Text, archiveName.Text + ".asar"));
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.UseDescriptionForTitle = true;
                dialog.Description = "Select an output directory for new ASAR archive";
                switch (dialog.ShowDialog())
                {
                    case DialogResult.OK:
                        outputDirectoryTextBox.Text = dialog.SelectedPath;
                        break;
                }
            }
        }
    }
}
