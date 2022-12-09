namespace craftersmine.Aesir.Forms
{
    partial class ExtractionProgressDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.outputDirLabel = new System.Windows.Forms.Label();
            this.fileIndexLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extracting...";
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.Location = new System.Drawing.Point(12, 35);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(633, 15);
            this.currentFileLabel.TabIndex = 1;
            this.currentFileLabel.Text = "Current file: {currentFile}";
            // 
            // outputDirLabel
            // 
            this.outputDirLabel.Location = new System.Drawing.Point(12, 50);
            this.outputDirLabel.Name = "outputDirLabel";
            this.outputDirLabel.Size = new System.Drawing.Size(633, 15);
            this.outputDirLabel.TabIndex = 2;
            this.outputDirLabel.Text = "Output directory: {outputDir}";
            // 
            // fileIndexLabel
            // 
            this.fileIndexLabel.AutoSize = true;
            this.fileIndexLabel.Location = new System.Drawing.Point(12, 79);
            this.fileIndexLabel.Name = "fileIndexLabel";
            this.fileIndexLabel.Size = new System.Drawing.Size(139, 15);
            this.fileIndexLabel.TabIndex = 3;
            this.fileIndexLabel.Text = "File: {fileIndex}/{totalFile}";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 108);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(633, 23);
            this.progressBar.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(481, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(164, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ExtractionProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(657, 182);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.fileIndexLabel);
            this.Controls.Add(this.outputDirLabel);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtractionProgressDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extracting - Aesir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtractionProgressDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label currentFileLabel;
        private Label outputDirLabel;
        private Label fileIndexLabel;
        private ProgressBar progressBar;
        private Button cancelButton;
    }
}