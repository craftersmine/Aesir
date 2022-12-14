using craftersmine.Aesir.Extensions;
using craftersmine.Aesir.Forms;
using craftersmine.Aesir.Res;
using craftersmine.Asar.Net;

namespace craftersmine.Aesir
{
    public partial class MainWindow : Form
    {
        private const string ArchiveRootImageIndex = "Archive";
        private const string ArchiveDirectoryClosedImageIndex = "Directory";
        private const string ArchiveDirectoryOpenedImageIndex = "Directory";

        public MainWindow()
        {
            InitializeComponent();
            treeIcons.Images.Clear();
            treeIcons.Images.Add("Directory", FileIcons.Directory);
            treeIcons.Images.Add("DirectoryOpen", FileIcons.Directory);
            treeIcons.Images.Add("Archive", FileIcons.Archive);

            ShowArchiveData();

            UpdateView();

            UpdateTitle();

            SetStatus("Ready");

            DisableOrEnableUi();
        }

        private void ExtractArchiveClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select an output directory for archive to be extracted in";
                dlg.ShowNewFolderButton = true;
                dlg.UseDescriptionForTitle = true;
                switch (dlg.ShowDialog())
                {
                    case DialogResult.OK:
                        if (StaticData.OpenedArchive is null)
                        {
                            MessageBox.Show(
                                "Unable to extract archive into selected directory! Archive is not opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                        
                        AsarArchiveUnpacker unpacker =
                            new AsarArchiveUnpacker(StaticData.OpenedArchive.AsarArchive);

                        ArchiveOperation extractionOperation = new ArchiveOperation(ArchiveOperationType.Extraction,
                            async operation =>
                            {
                                unpacker.StatusChanged += (o, e) =>
                                {
                                    operation.Update(new OperationProgressChangedEventArgs(e.CurrentFile, e.TotalFiles,
                                        e.CurrentFileData.GetPathInArchive(), e.OutputFilePath));
                                };
                                unpacker.AsarArchiveUnpacked += (o, e) =>
                                {
                                    operation.Complete();
                                };
                                try
                                {
                                    await unpacker.UnpackAsync(dlg.SelectedPath, cancellationTokenSource.Token);
                                }
                                catch (Exception ex)
                                {
                                    if (ex is TaskCanceledException)
                                    {
                                        MessageBox.Show("Archive unpacking was cancelled by user!", "Cancelled by user",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("An error was occurred while unpacking archive! " + ex.Message,
                                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            },
                            () =>
                            {
                                cancellationTokenSource.Cancel();
                            },
                            () =>
                            {
                                unpacker.Pause();
                            },
                            () =>
                            {
                                unpacker.Resume();
                            }
                        );

                        ProgressDialog progressDialog = new ProgressDialog(extractionOperation);
                        progressDialog.ShowDialog();
                        break;
                }
            }
        }

        private void CreateNewArchiveClick(object sender, EventArgs e)
        {
            using (CreateArchiveDialog createArchiveForm = new CreateArchiveDialog())
            {
                switch (createArchiveForm.ShowDialog())
                {
                    case DialogResult.OK:
                        ShowArchiveData();
                        DisableOrEnableUi();
                        break;
                }
            }
        }

        private void DisableOrEnableUi()
        {
            bool isEnabled = StaticData.OpenedArchive is not null;

            saveArchiveTool.Enabled = isEnabled;
            extractArchiveTool.Enabled = isEnabled;
            copyToTool.Enabled = isEnabled;
            moveToTool.Enabled = isEnabled;
            renameTool.Enabled = isEnabled;
            deleteTool.Enabled = isEnabled;
            propertiesTool.Enabled = isEnabled;
            validateTool.Enabled = isEnabled;
            openFileMenu.Enabled = isEnabled;
            editFileMenu.Enabled = isEnabled;
            viewFileMenu.Enabled = isEnabled;
            saveArchiveMenu.Enabled = isEnabled;
            extractArchiveToMenu.Enabled = isEnabled;
            copyFileToMenu.Enabled = isEnabled;
            moveFileToMenu.Enabled = isEnabled;
            renameFileMenu.Enabled = isEnabled;
            deleteFileMenu.Enabled = isEnabled;
            filePropertiesMenu.Enabled = isEnabled;
            validateMenu.Enabled = isEnabled;

            if (StaticData.OpenedArchive is not null && StaticData.OpenedArchive.IsModified)
            {
                saveArchiveMenu.Enabled = StaticData.OpenedArchive.IsModified;
            }
        }

        private void UpdateTitle()
        {
            if (StaticData.OpenedArchive is not null)
                Text = Path.GetFileName(StaticData.OpenedArchive.FilePath) + " - Aesir";
            else Text = "No archive opened - Aesir";
        }

        private void OpenArchiveClick(object sender, EventArgs e)
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
                        StaticData.OpenedArchive = Archive.OpenArchive(openFileDialog.FileName);
                        ShowArchiveData();
                        break;
                }
            }
            DisableOrEnableUi();
        }

        private void ShowArchiveData()
        {
            if (StaticData.OpenedArchive is null)
                return;

            SubscribeToEvents();

            archiveTree.Nodes.Clear();
            archiveFileList.Items.Clear();
            TreeNode root = new TreeNode(Path.GetFileName(StaticData.OpenedArchive.AsarArchive.FilePath));
            root.ImageKey = ArchiveRootImageIndex;
            root.SelectedImageKey = ArchiveRootImageIndex;
            PopulateTreeNodes(root, StaticData.OpenedArchive.AsarArchive.Files);
            archiveTree.Nodes.Add(root);
            OpenDir("");
            archiveTree.SelectedNode = root;
            UpdateTitle();
            SetStatus("Opened archive: " + StaticData.OpenedArchive.FilePath);
        }

        private void SubscribeToEvents()
        {
            if (StaticData.OpenedArchive is null)
                return;
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
            
            if (string.IsNullOrWhiteSpace(path))
                addressBar.Text = "/";
            else
                addressBar.Text = path.Replace("\\", "/");
            List<string> parentPaths = new List<string>();
            string? lastPath = path;
            do
            {
                if (string.IsNullOrWhiteSpace(lastPath) || lastPath == "/")
                    break;
                lastPath = Path.GetDirectoryName(lastPath);
                lastPath = lastPath.Replace("\\", "/");
                parentPaths.Add(lastPath);
            } while (lastPath != "/");

            addressBar.Items.Clear();
            addressBar.Items.AddRange(parentPaths.ToArray());

            ShowFiles(path);
        }

        private void ShowFiles(string path)
        {
            archiveFileList.BeginUpdate();

            ClearImageLists();

            archiveFileList.Items.Clear();

            if (StaticData.OpenedArchive is null)
                MessageBox.Show("ASAR archive is not opened!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            AsarArchiveFile? file;
            file = string.IsNullOrWhiteSpace(path) || path == "/" ? StaticData.OpenedArchive?.AsarArchive.Files : StaticData.OpenedArchive?.AsarArchive.FindFile(path);

            List<ListViewItem> fileItems = new List<ListViewItem>();

            if (file.Files is not null && file.Files.Any())
            {

                foreach (AsarArchiveFile f in file.Files.Values)
                {
                    ListViewItem fileItem = new ListViewItem(f.Name);
                    fileItem.Tag = f;
                    fileItem.Name = f.Name;
                    string isUnpacked = f.IsUnpacked ? "Yes" : "No";
                    if (f.CheckIfDirectory())
                    {
                        fileItem.ImageKey = "Directory";
                        fileItem.SubItems.Add("<DIR>");
                        fileItem.SubItems.Add(isUnpacked);
                        fileItem.SubItems.Add(""); // if it is directory, don't show size, maybe directory sizes will be implemented later as a feature
                        fileItem.ToolTipText = string.Format("Name: {0}\r\nFile type: {1}\r\nUnpacked: {2}", f.Name, "Directory", isUnpacked);
                    }
                    else
                    {
                        string size = CalculateSizeString(f.Size);
                        string ext = Path.GetExtension(f.Name);
                        string fileType = OSHelpers.GetFileTypeDescription(ext);
                        AddIconToImageList(ext, OSHelpers.GetIconForFileExtension(ext, true), OSHelpers.GetIconForFileExtension(ext, false));
                        fileItem.ImageKey = ext;
                        fileItem.SubItems.Add(fileType);
                        fileItem.SubItems.Add(isUnpacked);
                        fileItem.SubItems.Add(size);
                        fileItem.ToolTipText = string.Format("Name: {0}\r\nFile type: {2}\r\nSize: {1}\r\nUnpacked: {3}", f.Name, size, fileType, isUnpacked);
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
                upItem.ToolTipText = "Go to parent directory";
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

        private void UpdateViewClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem viewMenuItem)
            {
                switch (viewMenuItem.Tag)
                {
                    case "viewLargeIcons":
                        archiveFileList.View = View.LargeIcon;
                        break;
                    case "viewSmallIcons":
                        archiveFileList.View = View.SmallIcon;
                        break;
                    case "viewDetails":
                        archiveFileList.View = View.Details;
                        break;
                    case "viewList":
                        archiveFileList.View = View.List;
                        break;
                }
            }

            UpdateView();
        }

        private void UpdateView()
        {
            viewDetailsMenu.CheckState = CheckState.Unchecked;
            viewDetailsMenu.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            viewListMenu.CheckState = CheckState.Unchecked;
            viewListMenu.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            viewLargeIconsMenu.CheckState = CheckState.Unchecked;
            viewLargeIconsMenu.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            viewSmallIconsMenu.CheckState = CheckState.Unchecked;
            viewSmallIconsMenu.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

            switch (archiveFileList.View)
            {
                case View.LargeIcon:
                    viewLargeIconsMenu.CheckState = CheckState.Indeterminate;
                    viewLargeIconsMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    archiveFileList.View = View.LargeIcon;
                    break;
                case View.SmallIcon:
                    viewSmallIconsMenu.CheckState = CheckState.Indeterminate;
                    viewSmallIconsMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    archiveFileList.View = View.SmallIcon;
                    break;
                case View.Details:
                    viewDetailsMenu.CheckState = CheckState.Indeterminate;
                    viewDetailsMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    archiveFileList.View = View.Details;
                    break;
                case View.List:
                    viewListMenu.CheckState = CheckState.Indeterminate;
                    viewListMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    archiveFileList.View = View.List;
                    break;
            }
        }

        private void PropertiesClick(object sender, EventArgs e)
        {
            AsarArchiveFile file = null;
            if (archiveTree.SelectedNode is not null)
                file = archiveTree.SelectedNode.Tag as AsarArchiveFile;
            if (archiveFileList.SelectedItems.Count > 0 && archiveFileList.SelectedItems[0] is not null)
                file = archiveFileList.SelectedItems[0].Tag as AsarArchiveFile;
            if (file is null)
                file = StaticData.OpenedArchive.AsarArchive.Files;

            using (FilePropertiesDialog dlg = new FilePropertiesDialog(file))
            {
                dlg.ShowDialog();
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

            return size + " Bytes";
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

        private void archiveFileList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is null)
                return;

            DataObject dataObject = new DataObject(DataFormats.FileDrop, (AsarArchiveFile) ((ListViewItem) e.Item).Tag);

            archiveFileList.DoDragDrop(dataObject, DragDropEffects.Copy);
        }

        private void archiveFileList_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void archiveFileList_DragOver(object sender, DragEventArgs e)
        {
        }

        private void archiveFileList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void addressBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenDir(addressBar.SelectedItem.ToString());
        }
    }
}