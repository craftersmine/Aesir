using craftersmine.Aesir.Extensions;
using craftersmine.Asar.Net;

namespace craftersmine.Aesir
{
    public partial class MainForm : Form
    {
        public const int ArchiveRootImageIndex = 0;
        public const int ArchiveDirectoryClosedImageIndex = 1;
        public const int ArchiveDirectoryOpenedImageIndex = 2;

        public MainForm()
        {
            InitializeComponent();
        }

        public void OpenArchiveClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Electron ASAR archive (*.asar)|*.asar|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;
                openFileDialog.CheckFileExists = true;
                openFileDialog.Title = "Select Electron ASAR archive to open";
                switch (openFileDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        archiveTree.Nodes.Clear();
                        archiveFileList.Items.Clear();
                        StaticData.OpenedArchive = Archive.OpenArchive(openFileDialog.FileName);
                        // TODO: add tree images
                        TreeNode root = new TreeNode(Path.GetFileName(StaticData.OpenedArchive.AsarArchive.FilePath));
                        PopulateTreeNodes(root, StaticData.OpenedArchive.AsarArchive.Files);
                        archiveTree.Nodes.Add(root);
                        break;
                }
            }
        }

        private void PopulateTreeNodes(TreeNode root, AsarArchiveFile asarArchiveFile)
        {
            if (asarArchiveFile.Files is not null && asarArchiveFile.Files.Any())
            {
                foreach (AsarArchiveFile file in asarArchiveFile.Files.Values)
                {
                    if (file.Files is not null && file.Files.Any())
                    {
                        TreeNode dirNode = new TreeNode(file.Name);
                        // TODO: add tree images
                        PopulateTreeNodes(dirNode, file);
                        root.Nodes.Add(dirNode);
                    }
                }
            }
        }

        private void archiveTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is null) return;

            string path = e.Node.FullPath;
            if (path.StartsWith(Path.GetFileName(StaticData.OpenedArchive.AsarArchive.FilePath)))
                path = path.Substring(Path.GetFileName(StaticData.OpenedArchive.AsarArchive.FilePath).Length);
            ShowFiles(path);
        }

        private void ShowFiles(string path)
        {
            archiveFileList.Items.Clear();
            AsarArchiveFile file;
            file = string.IsNullOrWhiteSpace(path) ? StaticData.OpenedArchive.AsarArchive.Files : StaticData.OpenedArchive.AsarArchive.FindFile(path);

            List<ListViewItem> fileItems = new List<ListViewItem>();

            if (file.Files is not null && file.Files.Any())
            {
                foreach (AsarArchiveFile f in file.Files.Values)
                {
                    // TODO: implement checking if it is dir or file and apply corresponding icons
                    ListViewItem fileItem = new ListViewItem(f.Name);
                    fileItem.Tag = f;
                    
                    fileItem.SubItems.Add(f.CheckIfDirectory() ? "<DIR>" : Path.GetExtension(f.Name));
                    fileItem.SubItems.Add(f.IsUnpacked ? "Yes" : "No");
                    fileItem.SubItems.Add(f.CheckIfDirectory() ? "" : CalculateSizeString(f.Size));
                    if (f.Integrity is not null)
                        fileItem.SubItems.Add(f.Integrity.Hash);
                    fileItems.Add(fileItem);
                }
            }
            
            archiveFileList.Items.AddRange(fileItems.OrderByDescending(i => (i.Tag as AsarArchiveFile).CheckIfDirectory()).ToArray());
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
            return string.Format(strFormat, size, "Bytes");
        }
    }
}