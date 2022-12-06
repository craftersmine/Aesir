using craftersmine.Aesir.Extensions;
using craftersmine.Aesir.Res;
using craftersmine.Asar.Net;

namespace craftersmine.Aesir
{
    public partial class MainForm : Form
    {
        public const string ArchiveRootImageIndex = "Archive";
        public const string ArchiveDirectoryClosedImageIndex = "Directory";
        public const string ArchiveDirectoryOpenedImageIndex = "Directory";

        public MainForm()
        {
            InitializeComponent();
            treeIcons.Images.Clear();
            treeIcons.Images.Add("Directory", FileIcons.Directory);
            treeIcons.Images.Add("DirectoryOpen", FileIcons.Directory);
            treeIcons.Images.Add("Archive", FileIcons.Archive);
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            if (StaticData.OpenedArchive is not null)
                Text = Path.GetFileName(StaticData.OpenedArchive.FilePath) + " - Aesir";
            else Text = "No archive opened - Aesir";
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
                        TreeNode root = new TreeNode(Path.GetFileName(StaticData.OpenedArchive.AsarArchive.FilePath));
                        root.ImageKey = ArchiveRootImageIndex;
                        PopulateTreeNodes(root, StaticData.OpenedArchive.AsarArchive.Files);
                        archiveTree.Nodes.Add(root);
                        UpdateTitle();
                        break;
                }
            }
        }

        private void PopulateTreeNodes(TreeNode root, AsarArchiveFile asarArchiveFile)
        {
            archiveTree.BeginUpdate();

            if (asarArchiveFile.Files is not null && asarArchiveFile.Files.Any())
            {
                foreach (AsarArchiveFile file in asarArchiveFile.Files.Values)
                {
                    if (file.Files is not null && file.Files.Any())
                    {
                        TreeNode dirNode = new TreeNode(file.Name);
                        dirNode.Name = file.Name;
                        dirNode.ImageKey = ArchiveDirectoryClosedImageIndex;
                        PopulateTreeNodes(dirNode, file);
                        root.Nodes.Add(dirNode);
                    }
                }
            }

            archiveTree.EndUpdate();
        }

        private void archiveTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is null) return;

            archiveTree.SelectedNode.Expand();
            string path = e.Node.FullPath;
            SetStatus(path);
            OpenDir(path);
        }

        private void SetStatus(string status)
        {
            statusLabel.Text = status;
        }

        private void OpenDir(string path)
        {
            if (path.StartsWith(Path.GetFileName(StaticData.OpenedArchive.AsarArchive.FilePath)))
                path = path.Substring(Path.GetFileName(StaticData.OpenedArchive.AsarArchive.FilePath).Length);
            ShowFiles(path);
        }

        private void ShowFiles(string path)
        {
            archiveFileList.BeginUpdate();

            ClearImageLists();

            archiveFileList.Items.Clear();
            AsarArchiveFile file;
            file = string.IsNullOrWhiteSpace(path) ? StaticData.OpenedArchive.AsarArchive.Files : StaticData.OpenedArchive.AsarArchive.FindFile(path);

            List<ListViewItem> fileItems = new List<ListViewItem>();

            if (file.Files is not null && file.Files.Any())
            {

                foreach (AsarArchiveFile f in file.Files.Values)
                {
                    ListViewItem fileItem = new ListViewItem(f.Name);
                    fileItem.Tag = f;
                    fileItem.Name = f.Name;

                    if (f.CheckIfDirectory())
                    {
                        fileItem.ImageKey = "Directory";
                        fileItem.SubItems.Add("<DIR>");
                        fileItem.SubItems.Add(f.IsUnpacked ? "Yes" : "No");
                        fileItem.SubItems.Add(""); // if it is directory, don't show size, maybe directory sizes will be implemented later as a feature
                    }
                    else
                    {
                        string ext = Path.GetExtension(f.Name);
                        AddIconToImageList(ext, OSHelpers.GetIconForFileExtension(ext, true), OSHelpers.GetIconForFileExtension(ext, false));
                        fileItem.ImageKey = ext;
                        fileItem.SubItems.Add(OSHelpers.GetFileTypeDescription(ext));
                        fileItem.SubItems.Add(f.IsUnpacked ? "Yes" : "No");
                        fileItem.SubItems.Add(CalculateSizeString(f.Size));
                    }

                    if (f.Integrity is not null)
                        fileItem.SubItems.Add(f.Integrity.Hash);
                    else fileItem.SubItems.Add("-");
                    fileItems.Add(fileItem);
                }
            }
            
            archiveFileList.Items.AddRange(fileItems.OrderByDescending(i => (i.Tag as AsarArchiveFile)?.CheckIfDirectory()).ToArray());

            if (!file.IsRoot)
            {
                ListViewItem upItem = new ListViewItem("..");
                upItem.Name = "upItem";
                upItem.ImageKey = "Directory";
                archiveFileList.Items.Insert(0, upItem);
            }

            archiveFileList.EndUpdate();
        }

        private void ClearImageLists()
        {
            largeViewIcons.Images.Clear();
            smallViewIcons.Images.Clear();
            largeViewIcons.Images.Add("Directory", FileIcons.Directory);
            smallViewIcons.Images.Add("Directory", FileIcons.Directory);
        }

        private void AddIconToImageList(string ext, Icon smallIcon, Icon largeIcon)
        { 
            largeViewIcons.Images.Add(ext, largeIcon); 
            smallViewIcons.Images.Add(ext, smallIcon);
        }

        private void UpdateView(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem viewMenuItem)
            {
                viewDetailsMenu.CheckState = CheckState.Unchecked;
                viewListMenu.CheckState = CheckState.Unchecked;
                viewLargeIconsMenu.CheckState = CheckState.Unchecked;
                viewSmallIconsMenu.CheckState = CheckState.Unchecked;

                switch (viewMenuItem.Tag)
                {
                    case "viewLargeIcons":
                        viewLargeIconsMenu.CheckState = CheckState.Indeterminate;
                        archiveFileList.View = View.LargeIcon;
                        break;
                    case "viewSmallIcons":
                        viewSmallIconsMenu.CheckState = CheckState.Indeterminate;
                        archiveFileList.View = View.SmallIcon;
                        break;
                    case "viewDetails":
                        viewDetailsMenu.CheckState = CheckState.Indeterminate;
                        archiveFileList.View = View.Details;
                        break;
                    case "viewList":
                        viewListMenu.CheckState = CheckState.Indeterminate;
                        archiveFileList.View = View.List;
                        break;
                }
            }
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

        private void archiveFileList_DoubleClick(object sender, EventArgs e)
        {
            if (archiveFileList.SelectedItems.Count == 1)
            {
                if (archiveFileList.SelectedItems[0].ImageKey == ArchiveDirectoryOpenedImageIndex || archiveFileList.SelectedItems[0].ImageKey == ArchiveDirectoryClosedImageIndex)
                {
                    string dirName = archiveFileList.SelectedItems[0].Text;
                    string path = string.Empty;
                    if (dirName == "..")
                    {
                        path = archiveTree.SelectedNode.Parent.FullPath;
                        TreeNode selectedNode = archiveTree.SelectedNode.Parent;
                        selectedNode.EnsureVisible();
                        archiveTree.SelectedNode = selectedNode;
                    }
                    else
                    {
                        path = Path.Combine(archiveTree.SelectedNode.FullPath, dirName);
                        TreeNode selectedNode = archiveTree.SelectedNode.Nodes[dirName];
                        selectedNode.EnsureVisible();
                        archiveTree.SelectedNode = selectedNode;
                    }

                    OpenDir(path);
                }
            }
        }
    }
}