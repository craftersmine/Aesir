namespace craftersmine.Aesir.Forms
{
    partial class FilePropertiesDialog
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
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileTypeTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.unpacked = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fileCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(12, 17);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(32, 32);
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name:";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextbox.Location = new System.Drawing.Point(50, 30);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.ReadOnly = true;
            this.fileNameTextbox.Size = new System.Drawing.Size(367, 23);
            this.fileNameTextbox.TabIndex = 2;
            // 
            // pathTextbox
            // 
            this.pathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextbox.Location = new System.Drawing.Point(50, 74);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.ReadOnly = true;
            this.pathTextbox.Size = new System.Drawing.Size(367, 23);
            this.pathTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path:";
            // 
            // fileTypeTextbox
            // 
            this.fileTypeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTypeTextbox.Location = new System.Drawing.Point(50, 118);
            this.fileTypeTextbox.Name = "fileTypeTextbox";
            this.fileTypeTextbox.ReadOnly = true;
            this.fileTypeTextbox.Size = new System.Drawing.Size(367, 23);
            this.fileTypeTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "File type:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(50, 153);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(77, 15);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "Size: {fileSize}";
            // 
            // unpacked
            // 
            this.unpacked.AutoSize = true;
            this.unpacked.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.unpacked.Location = new System.Drawing.Point(50, 209);
            this.unpacked.Name = "unpacked";
            this.unpacked.Size = new System.Drawing.Size(85, 20);
            this.unpacked.TabIndex = 8;
            this.unpacked.Text = "Unpacked";
            this.unpacked.UseVisualStyleBackColor = true;
            this.unpacked.CheckedChanged += new System.EventHandler(this.unpacked_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(342, 257);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "OK";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fileCountLabel
            // 
            this.fileCountLabel.AutoSize = true;
            this.fileCountLabel.Location = new System.Drawing.Point(50, 179);
            this.fileCountLabel.Name = "fileCountLabel";
            this.fileCountLabel.Size = new System.Drawing.Size(122, 15);
            this.fileCountLabel.TabIndex = 10;
            this.fileCountLabel.Text = "File count: {fileCount}";
            // 
            // FilePropertiesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 294);
            this.Controls.Add(this.fileCountLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.unpacked);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.fileTypeTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 285);
            this.Name = "FilePropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{fileName} - Properties";
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox iconBox;
        private Label label1;
        private TextBox fileNameTextbox;
        private TextBox pathTextbox;
        private Label label2;
        private TextBox fileTypeTextbox;
        private Label label3;
        private Label sizeLabel;
        private CheckBox unpacked;
        private Button cancelButton;
        private Label fileCountLabel;
    }
}