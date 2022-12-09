namespace craftersmine.Aesir.Forms
{
    partial class CreateArchiveDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.archiveName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.archivePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new ASAR Archive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter an ASAR archive name:";
            // 
            // archiveName
            // 
            this.archiveName.Location = new System.Drawing.Point(12, 52);
            this.archiveName.Name = "archiveName";
            this.archiveName.Size = new System.Drawing.Size(548, 23);
            this.archiveName.TabIndex = 2;
            this.archiveName.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter an output directory for ASAR archive:";
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(12, 106);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(444, 23);
            this.outputDirectoryTextBox.TabIndex = 4;
            this.outputDirectoryTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(462, 105);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(98, 23);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(462, 174);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(98, 23);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(381, 174);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your archive will be located here:";
            // 
            // archivePathLabel
            // 
            this.archivePathLabel.AutoSize = true;
            this.archivePathLabel.Location = new System.Drawing.Point(12, 156);
            this.archivePathLabel.Name = "archivePathLabel";
            this.archivePathLabel.Size = new System.Drawing.Size(82, 15);
            this.archivePathLabel.TabIndex = 9;
            this.archivePathLabel.Text = "{archive-path}";
            // 
            // CreateArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 209);
            this.Controls.Add(this.archivePathLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.outputDirectoryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.archiveName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateArchiveDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create a new ASAR Archive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox archiveName;
        private Label label3;
        private TextBox outputDirectoryTextBox;
        private Button browseButton;
        private Button createButton;
        private Button cancelButton;
        private Label label4;
        private Label archivePathLabel;
    }
}