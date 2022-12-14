using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using craftersmine.Aesir.Res;
using craftersmine.Asar.Net;

namespace craftersmine.Aesir.Forms
{
    public partial class FilePropertiesDialog : Form
    {
        private bool isUnpacked = false;

        public FilePropertiesDialog(AsarArchiveFile file)
        {
            isUnpacked = file.IsUnpacked;
            InitializeComponent();
            if (!file.IsRoot)
            {
                pathTextbox.Text = "/" + file.GetPathInArchive();
                fileNameTextbox.Text = file.Name;
                Text = file.Name + " - Properties";
                sizeLabel.Text = "Size: " + CalculateSizeString(file.Size);
                if (file.Files is not null && file.Size == 0)
                {
                    fileTypeTextbox.Text = "Directory";
                    iconBox.Image = FileIcons.Directory.ToBitmap();
                    fileCountLabel.Visible = true;
                    fileCountLabel.Text = "File count: " + file.GetFileCount();
                }
                else
                {
                    fileTypeTextbox.Text = OSHelpers.GetFileTypeDescription(Path.GetExtension(file.Name));
                    iconBox.Image = OSHelpers.GetIconForFileExtension(Path.GetExtension(file.Name), false).ToBitmap();
                    fileCountLabel.Visible = false;
                }
            }
            else
            {
                pathTextbox.Text = StaticData.OpenedArchive.FilePath;
                fileNameTextbox.Text = Path.GetFileName(StaticData.OpenedArchive.FilePath);
                Text = Path.GetFileName(StaticData.OpenedArchive.FilePath) + " - Properties";
                iconBox.Image = FileIcons.Archive.ToBitmap();
                fileTypeTextbox.Text = "Asar Archive";
                fileCountLabel.Visible = true;
                fileCountLabel.Text = "File count: " + file.GetFileCount();
                sizeLabel.Text = "Size: " + CalculateSizeString(new FileInfo(StaticData.OpenedArchive.FilePath).Length);
            }

            unpacked.Checked = isUnpacked;
        }

        private void unpacked_CheckedChanged(object sender, EventArgs e)
        {
            unpacked.Checked = isUnpacked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string CalculateSizeString(float size)
        {
            string strFormat = "{0:F2} {1}";
            if (size >= 1024f)
            {
                size /= 1024f;
                if (size >= 1024f)
                {
                    size /= 1024f;
                    if (size >= 1024f)
                    {
                        size /= 1024f;
                        return string.Format(strFormat, size, "GB");
                    }
                    return string.Format(strFormat, size, "MB");
                }
                return string.Format(strFormat, size, "KB");
            }

            return size + " Bytes";
        }
    }
}
