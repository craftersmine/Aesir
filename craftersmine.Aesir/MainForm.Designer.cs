namespace craftersmine.Aesir
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newArchiveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openArchiveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveArchiveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.extractArchiveToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.renameFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFileToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.moveFileToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.filePropertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.validateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLargeIconsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSmallIconsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.viewSortNameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSortTypeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSortSizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSortUnpackedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.requestAFeatureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newArchiveTool = new System.Windows.Forms.ToolStripButton();
            this.openArchiveTool = new System.Windows.Forms.ToolStripButton();
            this.saveArchiveTool = new System.Windows.Forms.ToolStripButton();
            this.extractArchiveTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToTool = new System.Windows.Forms.ToolStripButton();
            this.moveToTool = new System.Windows.Forms.ToolStripButton();
            this.renameTool = new System.Windows.Forms.ToolStripButton();
            this.deleteTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesMenu = new System.Windows.Forms.ToolStripButton();
            this.validateTool = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.archiveTree = new System.Windows.Forms.TreeView();
            this.treeIcons = new System.Windows.Forms.ImageList(this.components);
            this.archiveFileList = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.typeColumn = new System.Windows.Forms.ColumnHeader();
            this.unpackedColumn = new System.Windows.Forms.ColumnHeader();
            this.sizeColumn = new System.Windows.Forms.ColumnHeader();
            this.integrityColumn = new System.Windows.Forms.ColumnHeader();
            this.largeViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.smallViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.detailsViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 644);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1090, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1075, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.Text = "{status}";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.serviceMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenu,
            this.editFileMenu,
            this.viewFileMenu,
            this.toolStripMenuItem1,
            this.newArchiveMenu,
            this.openArchiveMenu,
            this.saveArchiveMenu,
            this.extractArchiveToMenu,
            this.toolStripMenuItem2,
            this.renameFileMenu,
            this.copyFileToMenu,
            this.moveFileToMenu,
            this.deleteFileMenu,
            this.toolStripMenuItem3,
            this.filePropertiesMenu,
            this.validateMenu,
            this.toolStripMenuItem4,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(176, 22);
            this.openFileMenu.Text = "Open";
            // 
            // editFileMenu
            // 
            this.editFileMenu.Name = "editFileMenu";
            this.editFileMenu.Size = new System.Drawing.Size(176, 22);
            this.editFileMenu.Text = "Edit";
            // 
            // viewFileMenu
            // 
            this.viewFileMenu.Name = "viewFileMenu";
            this.viewFileMenu.Size = new System.Drawing.Size(176, 22);
            this.viewFileMenu.Text = "View";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // newArchiveMenu
            // 
            this.newArchiveMenu.Name = "newArchiveMenu";
            this.newArchiveMenu.Size = new System.Drawing.Size(176, 22);
            this.newArchiveMenu.Text = "New Archive...";
            // 
            // openArchiveMenu
            // 
            this.openArchiveMenu.Name = "openArchiveMenu";
            this.openArchiveMenu.Size = new System.Drawing.Size(176, 22);
            this.openArchiveMenu.Text = "Open Archive...";
            this.openArchiveMenu.Click += new System.EventHandler(this.OpenArchiveClick);
            // 
            // saveArchiveMenu
            // 
            this.saveArchiveMenu.Name = "saveArchiveMenu";
            this.saveArchiveMenu.Size = new System.Drawing.Size(176, 22);
            this.saveArchiveMenu.Text = "Save Archive...";
            // 
            // extractArchiveToMenu
            // 
            this.extractArchiveToMenu.Name = "extractArchiveToMenu";
            this.extractArchiveToMenu.Size = new System.Drawing.Size(176, 22);
            this.extractArchiveToMenu.Text = "Extract Archive to...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // renameFileMenu
            // 
            this.renameFileMenu.Name = "renameFileMenu";
            this.renameFileMenu.Size = new System.Drawing.Size(176, 22);
            this.renameFileMenu.Text = "Rename";
            // 
            // copyFileToMenu
            // 
            this.copyFileToMenu.Name = "copyFileToMenu";
            this.copyFileToMenu.Size = new System.Drawing.Size(176, 22);
            this.copyFileToMenu.Text = "Copy To...";
            // 
            // moveFileToMenu
            // 
            this.moveFileToMenu.Name = "moveFileToMenu";
            this.moveFileToMenu.Size = new System.Drawing.Size(176, 22);
            this.moveFileToMenu.Text = "Move To...";
            // 
            // deleteFileMenu
            // 
            this.deleteFileMenu.Name = "deleteFileMenu";
            this.deleteFileMenu.Size = new System.Drawing.Size(176, 22);
            this.deleteFileMenu.Text = "Delete";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(173, 6);
            // 
            // filePropertiesMenu
            // 
            this.filePropertiesMenu.Name = "filePropertiesMenu";
            this.filePropertiesMenu.Size = new System.Drawing.Size(176, 22);
            this.filePropertiesMenu.Text = "Properties";
            // 
            // validateMenu
            // 
            this.validateMenu.Name = "validateMenu";
            this.validateMenu.Size = new System.Drawing.Size(176, 22);
            this.validateMenu.Text = "Validate";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(173, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(176, 22);
            this.exitMenu.Text = "Exit";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllMenu,
            this.deselectAllMenu,
            this.invertSelectionMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // selectAllMenu
            // 
            this.selectAllMenu.Name = "selectAllMenu";
            this.selectAllMenu.Size = new System.Drawing.Size(155, 22);
            this.selectAllMenu.Text = "Select All";
            // 
            // deselectAllMenu
            // 
            this.deselectAllMenu.Name = "deselectAllMenu";
            this.deselectAllMenu.Size = new System.Drawing.Size(155, 22);
            this.deselectAllMenu.Text = "Deselect All";
            // 
            // invertSelectionMenu
            // 
            this.invertSelectionMenu.Name = "invertSelectionMenu";
            this.invertSelectionMenu.Size = new System.Drawing.Size(155, 22);
            this.invertSelectionMenu.Text = "Invert Selection";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLargeIconsMenu,
            this.viewSmallIconsMenu,
            this.viewListMenu,
            this.viewDetailsMenu,
            this.toolStripMenuItem5,
            this.viewSortNameMenu,
            this.viewSortTypeMenu,
            this.viewSortSizeMenu,
            this.viewSortUnpackedMenu});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "View";
            // 
            // viewLargeIconsMenu
            // 
            this.viewLargeIconsMenu.Name = "viewLargeIconsMenu";
            this.viewLargeIconsMenu.Size = new System.Drawing.Size(134, 22);
            this.viewLargeIconsMenu.Text = "Large Icons";
            // 
            // viewSmallIconsMenu
            // 
            this.viewSmallIconsMenu.Name = "viewSmallIconsMenu";
            this.viewSmallIconsMenu.Size = new System.Drawing.Size(134, 22);
            this.viewSmallIconsMenu.Text = "Small Icons";
            // 
            // viewListMenu
            // 
            this.viewListMenu.Name = "viewListMenu";
            this.viewListMenu.Size = new System.Drawing.Size(134, 22);
            this.viewListMenu.Text = "List";
            // 
            // viewDetailsMenu
            // 
            this.viewDetailsMenu.Name = "viewDetailsMenu";
            this.viewDetailsMenu.Size = new System.Drawing.Size(134, 22);
            this.viewDetailsMenu.Text = "Details";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(131, 6);
            // 
            // viewSortNameMenu
            // 
            this.viewSortNameMenu.Name = "viewSortNameMenu";
            this.viewSortNameMenu.Size = new System.Drawing.Size(134, 22);
            this.viewSortNameMenu.Text = "Name";
            // 
            // viewSortTypeMenu
            // 
            this.viewSortTypeMenu.Name = "viewSortTypeMenu";
            this.viewSortTypeMenu.Size = new System.Drawing.Size(134, 22);
            this.viewSortTypeMenu.Text = "Type";
            // 
            // viewSortSizeMenu
            // 
            this.viewSortSizeMenu.Name = "viewSortSizeMenu";
            this.viewSortSizeMenu.Size = new System.Drawing.Size(134, 22);
            this.viewSortSizeMenu.Text = "Size";
            // 
            // viewSortUnpackedMenu
            // 
            this.viewSortUnpackedMenu.Name = "viewSortUnpackedMenu";
            this.viewSortUnpackedMenu.Size = new System.Drawing.Size(134, 22);
            this.viewSortUnpackedMenu.Text = "Unpacked";
            // 
            // serviceMenu
            // 
            this.serviceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenu});
            this.serviceMenu.Name = "serviceMenu";
            this.serviceMenu.Size = new System.Drawing.Size(56, 20);
            this.serviceMenu.Text = "Service";
            // 
            // settingsMenu
            // 
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(125, 22);
            this.settingsMenu.Text = "Settings...";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportABugMenu,
            this.requestAFeatureMenu,
            this.toolStripMenuItem6,
            this.aboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // reportABugMenu
            // 
            this.reportABugMenu.Name = "reportABugMenu";
            this.reportABugMenu.Size = new System.Drawing.Size(174, 22);
            this.reportABugMenu.Text = "Report a bug...";
            // 
            // requestAFeatureMenu
            // 
            this.requestAFeatureMenu.Name = "requestAFeatureMenu";
            this.requestAFeatureMenu.Size = new System.Drawing.Size(174, 22);
            this.requestAFeatureMenu.Text = "Request a feature...";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(171, 6);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(174, 22);
            this.aboutMenu.Text = "About...";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newArchiveTool,
            this.openArchiveTool,
            this.saveArchiveTool,
            this.extractArchiveTool,
            this.toolStripSeparator1,
            this.copyToTool,
            this.moveToTool,
            this.renameTool,
            this.deleteTool,
            this.toolStripSeparator2,
            this.propertiesMenu,
            this.validateTool});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1090, 25);
            this.toolStrip.TabIndex = 2;
            // 
            // newArchiveTool
            // 
            this.newArchiveTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newArchiveTool.Image = ((System.Drawing.Image)(resources.GetObject("newArchiveTool.Image")));
            this.newArchiveTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newArchiveTool.Name = "newArchiveTool";
            this.newArchiveTool.Size = new System.Drawing.Size(23, 22);
            this.newArchiveTool.Text = "New Archive...";
            // 
            // openArchiveTool
            // 
            this.openArchiveTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openArchiveTool.Image = ((System.Drawing.Image)(resources.GetObject("openArchiveTool.Image")));
            this.openArchiveTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openArchiveTool.Name = "openArchiveTool";
            this.openArchiveTool.Size = new System.Drawing.Size(23, 22);
            this.openArchiveTool.Text = "Open Archive...";
            this.openArchiveTool.Click += new System.EventHandler(this.OpenArchiveClick);
            // 
            // saveArchiveTool
            // 
            this.saveArchiveTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveArchiveTool.Image = ((System.Drawing.Image)(resources.GetObject("saveArchiveTool.Image")));
            this.saveArchiveTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveArchiveTool.Name = "saveArchiveTool";
            this.saveArchiveTool.Size = new System.Drawing.Size(23, 22);
            this.saveArchiveTool.Text = "Save Archive...";
            // 
            // extractArchiveTool
            // 
            this.extractArchiveTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.extractArchiveTool.Image = ((System.Drawing.Image)(resources.GetObject("extractArchiveTool.Image")));
            this.extractArchiveTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.extractArchiveTool.Name = "extractArchiveTool";
            this.extractArchiveTool.Size = new System.Drawing.Size(23, 22);
            this.extractArchiveTool.Text = "Extract Archive to...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToTool
            // 
            this.copyToTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToTool.Image = ((System.Drawing.Image)(resources.GetObject("copyToTool.Image")));
            this.copyToTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToTool.Name = "copyToTool";
            this.copyToTool.Size = new System.Drawing.Size(23, 22);
            this.copyToTool.Text = "Copy To...";
            // 
            // moveToTool
            // 
            this.moveToTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveToTool.Image = ((System.Drawing.Image)(resources.GetObject("moveToTool.Image")));
            this.moveToTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveToTool.Name = "moveToTool";
            this.moveToTool.Size = new System.Drawing.Size(23, 22);
            this.moveToTool.Text = "Move To...";
            // 
            // renameTool
            // 
            this.renameTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.renameTool.Image = ((System.Drawing.Image)(resources.GetObject("renameTool.Image")));
            this.renameTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.renameTool.Name = "renameTool";
            this.renameTool.Size = new System.Drawing.Size(23, 22);
            this.renameTool.Text = "Rename";
            // 
            // deleteTool
            // 
            this.deleteTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteTool.Image")));
            this.deleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTool.Name = "deleteTool";
            this.deleteTool.Size = new System.Drawing.Size(23, 22);
            this.deleteTool.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // propertiesMenu
            // 
            this.propertiesMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.propertiesMenu.Image = ((System.Drawing.Image)(resources.GetObject("propertiesMenu.Image")));
            this.propertiesMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.propertiesMenu.Name = "propertiesMenu";
            this.propertiesMenu.Size = new System.Drawing.Size(23, 22);
            this.propertiesMenu.Text = "Properties";
            // 
            // validateTool
            // 
            this.validateTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.validateTool.Image = ((System.Drawing.Image)(resources.GetObject("validateTool.Image")));
            this.validateTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.validateTool.Name = "validateTool";
            this.validateTool.Size = new System.Drawing.Size(23, 22);
            this.validateTool.Text = "Validate";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.archiveTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.archiveFileList);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 595);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 3;
            // 
            // archiveTree
            // 
            this.archiveTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archiveTree.ImageIndex = 0;
            this.archiveTree.ImageList = this.treeIcons;
            this.archiveTree.Location = new System.Drawing.Point(0, 0);
            this.archiveTree.Name = "archiveTree";
            this.archiveTree.SelectedImageIndex = 0;
            this.archiveTree.Size = new System.Drawing.Size(277, 595);
            this.archiveTree.TabIndex = 0;
            this.archiveTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.archiveTree_AfterSelect);
            // 
            // treeIcons
            // 
            this.treeIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.treeIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.treeIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // archiveFileList
            // 
            this.archiveFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.typeColumn,
            this.unpackedColumn,
            this.sizeColumn,
            this.integrityColumn});
            this.archiveFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archiveFileList.LargeImageList = this.largeViewIcons;
            this.archiveFileList.Location = new System.Drawing.Point(0, 0);
            this.archiveFileList.Name = "archiveFileList";
            this.archiveFileList.Size = new System.Drawing.Size(809, 595);
            this.archiveFileList.SmallImageList = this.smallViewIcons;
            this.archiveFileList.TabIndex = 0;
            this.archiveFileList.UseCompatibleStateImageBehavior = false;
            this.archiveFileList.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 300;
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            // 
            // unpackedColumn
            // 
            this.unpackedColumn.Text = "Unpacked";
            this.unpackedColumn.Width = 65;
            // 
            // sizeColumn
            // 
            this.sizeColumn.Text = "Size";
            this.sizeColumn.Width = 100;
            // 
            // integrityColumn
            // 
            this.integrityColumn.Text = "SHA256";
            this.integrityColumn.Width = 250;
            // 
            // largeViewIcons
            // 
            this.largeViewIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.largeViewIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.largeViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallViewIcons
            // 
            this.smallViewIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.smallViewIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.smallViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // detailsViewIcons
            // 
            this.detailsViewIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.detailsViewIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.detailsViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 666);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "{archiveName} - Aesir";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip;
        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private SplitContainer splitContainer1;
        private TreeView archiveTree;
        private ListView archiveFileList;
        private ToolStripStatusLabel statusLabel;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem openFileMenu;
        private ToolStripMenuItem editFileMenu;
        private ToolStripMenuItem viewFileMenu;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem openArchiveMenu;
        private ToolStripMenuItem newArchiveMenu;
        private ToolStripMenuItem saveArchiveMenu;
        private ToolStripMenuItem extractArchiveToMenu;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem renameFileMenu;
        private ToolStripMenuItem copyFileToMenu;
        private ToolStripMenuItem moveFileToMenu;
        private ToolStripMenuItem deleteFileMenu;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem filePropertiesMenu;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem selectAllMenu;
        private ToolStripMenuItem deselectAllMenu;
        private ToolStripMenuItem invertSelectionMenu;
        private ToolStripMenuItem viewMenu;
        private ToolStripMenuItem viewLargeIconsMenu;
        private ToolStripMenuItem viewSmallIconsMenu;
        private ToolStripMenuItem viewListMenu;
        private ToolStripMenuItem viewDetailsMenu;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem viewSortNameMenu;
        private ToolStripMenuItem viewSortTypeMenu;
        private ToolStripMenuItem viewSortSizeMenu;
        private ToolStripMenuItem viewSortUnpackedMenu;
        private ToolStripMenuItem serviceMenu;
        private ToolStripMenuItem settingsMenu;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem reportABugMenu;
        private ToolStripMenuItem requestAFeatureMenu;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem aboutMenu;
        private ToolStripButton newArchiveTool;
        private ToolStripButton openArchiveTool;
        private ToolStripButton saveArchiveTool;
        private ToolStripButton extractArchiveTool;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton validateTool;
        private ToolStripButton copyToTool;
        private ToolStripButton renameTool;
        private ToolStripMenuItem validateMenu;
        private ToolStripButton moveToTool;
        private ToolStripButton deleteTool;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton propertiesMenu;
        private ImageList treeIcons;
        private ColumnHeader nameColumn;
        private ColumnHeader typeColumn;
        private ColumnHeader unpackedColumn;
        private ColumnHeader sizeColumn;
        private ColumnHeader integrityColumn;
        private ImageList largeViewIcons;
        private ImageList smallViewIcons;
        private ImageList detailsViewIcons;
    }
}