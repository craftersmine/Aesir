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
    public partial class ExtractionProgressDialog : Form
    {
        private bool suppressCancellationDialog = false;

        public ExtractionProgressDialog()
        {
            InitializeComponent();
            if (StaticData.OpenedArchive is null)
            {
                MessageBox.Show("Unable to extract archive! No opened archive!");
                this.Close();
            }

            StaticData.OpenedArchive!.OnExtractionProgressChanged += OpenedArchive_OnExtractionProgressChanged;
            StaticData.OpenedArchive!.OnExtractionCompleted += OpenedArchive_OnExtractionCompleted;
        }

        private void OpenedArchive_OnExtractionCompleted(object? sender, ExtractionStatusChangedEventArgs e)
        {
            suppressCancellationDialog = true;
            this.Close();
        }

        private void OpenedArchive_OnExtractionProgressChanged(object? sender, Asar.Net.AsarUnpackingStatusChangedEventArgs e)
        {
            SuspendLayout();

            currentFileLabel.Text = string.Format("Current file: {0}", e.OutputFilePath);
            outputDirLabel.Text = string.Format("Output directory: {0}", Path.GetDirectoryName(e.OutputFilePath));
            fileIndexLabel.Text = string.Format("File: {0}/{1}", e.CurrentFile, e.TotalFiles);

            int progressVal = Math.Min((int) (((float) e.CurrentFile / (float) e.TotalFiles) * 100f), 100);
            progressBar.Value = progressVal;

            ResumeLayout();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExtractionProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (suppressCancellationDialog || CancelOperation())
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                return;
            }

            if (StaticData.OpenedArchive is not null)
                StaticData.OpenedArchive.CancelCurrentOperation();
        }

        private bool CancelOperation()
        {
            switch (MessageBox.Show("Are you sure you want to cancel extraction?", "Cancel extraction?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.Yes: return true;
                case DialogResult.No: return false;
            }

            return false;
        }
    }
}
