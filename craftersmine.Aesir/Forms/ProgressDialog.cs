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
    public partial class ProgressDialog : Form
    {
        private bool suppressCancellationDialog = false;
        
        public ArchiveOperation Operation { get; private set; }

        public ProgressDialog(ArchiveOperation operation)
        {
            Operation = operation;
            InitializeComponent();
            if (StaticData.OpenedArchive is null)
            {
                MessageBox.Show("Unable to extract archive! No opened archive!");
                this.Close();
            }

            Operation.OperationProgressChanged += Operation_OperationProgressChanged;
            Operation.OperationCompleted += Operation_OperationCompleted;
        }

        private void Operation_OperationCompleted(object? sender, EventArgs e)
        {
            suppressCancellationDialog = true;
            this.Close();
        }

        private void Operation_OperationProgressChanged(object? sender, OperationProgressChangedEventArgs e)
        {
            SuspendLayout();

            currentFileLabel.Text = string.Format("Current file: {0}", e.SourceFilePath);
            outputDirLabel.Text = string.Format("Output file: {0}", Path.GetDirectoryName(e.DestinationFilePath));
            fileIndexLabel.Text = string.Format("File: {0}/{1}", e.CurrentFile, e.TotalFiles);

            int progressVal = Math.Min((int) (((float) e.CurrentFile / (float) e.TotalFiles) * 100f), 100);
            progressBar.Value = progressVal;

            ResumeLayout();
        }

        private void ExtractionProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!suppressCancellationDialog)
            {
                Operation.Pause();
                e.Cancel = true;
                if (CancelOperation())
                {
                    e.Cancel = false;
                    Operation.Cancel();
                }
            }

            //this.Close();
        }

        private bool CancelOperation()
        {
            switch (MessageBox.Show("Are you sure you want to cancel extraction?", "Cancel extraction?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.Yes: 
                    return true;
                case DialogResult.No: 
                    Operation.Resume();
                    return false;
            }

            return false;
        }

        private void ProgressDialog_Shown(object sender, EventArgs e)
        {
            Operation.Start();
        }
    }
}
