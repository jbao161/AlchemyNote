namespace AlchemyNote
{
    partial class form_mainwindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My first note");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("My Notebook", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_mainwindow));
            this.menubar_main = new System.Windows.Forms.MenuStrip();
            this.menubar_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_close = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_revert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitem_newbook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_openbook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_closebook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_saveall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitwindow_main = new System.Windows.Forms.SplitContainer();
            this.treeview_main = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menubar_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitwindow_main)).BeginInit();
            this.splitwindow_main.Panel1.SuspendLayout();
            this.splitwindow_main.Panel2.SuspendLayout();
            this.splitwindow_main.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar_main
            // 
            this.menubar_main.Dock = System.Windows.Forms.DockStyle.None;
            this.menubar_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubar_file});
            this.menubar_main.Location = new System.Drawing.Point(0, 0);
            this.menubar_main.Name = "menubar_main";
            this.menubar_main.Size = new System.Drawing.Size(800, 28);
            this.menubar_main.TabIndex = 0;
            this.menubar_main.Text = "menuStrip1";
            // 
            // menubar_file
            // 
            this.menubar_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_new,
            this.menuitem_open,
            this.menuitem_close,
            this.menuitem_revert,
            this.toolStripMenuItem1,
            this.menuitem_newbook,
            this.menuitem_openbook,
            this.menuitem_closebook,
            this.toolStripMenuItem4,
            this.deleteNoteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.menuitem_save,
            this.menuitem_saveall,
            this.menuitem_saveas,
            this.toolStripMenuItem3,
            this.menuitem_exit});
            this.menubar_file.Name = "menubar_file";
            this.menubar_file.Size = new System.Drawing.Size(44, 24);
            this.menubar_file.Text = "File";
            // 
            // menuitem_new
            // 
            this.menuitem_new.Name = "menuitem_new";
            this.menuitem_new.Size = new System.Drawing.Size(216, 26);
            this.menuitem_new.Text = "New";
            // 
            // menuitem_open
            // 
            this.menuitem_open.Name = "menuitem_open";
            this.menuitem_open.Size = new System.Drawing.Size(216, 26);
            this.menuitem_open.Text = "Open";
            this.menuitem_open.Click += new System.EventHandler(this.menuitem_open_Click);
            // 
            // menuitem_close
            // 
            this.menuitem_close.Name = "menuitem_close";
            this.menuitem_close.Size = new System.Drawing.Size(216, 26);
            this.menuitem_close.Text = "Close";
            // 
            // menuitem_revert
            // 
            this.menuitem_revert.Name = "menuitem_revert";
            this.menuitem_revert.Size = new System.Drawing.Size(216, 26);
            this.menuitem_revert.Text = "Revert";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // menuitem_newbook
            // 
            this.menuitem_newbook.Name = "menuitem_newbook";
            this.menuitem_newbook.Size = new System.Drawing.Size(216, 26);
            this.menuitem_newbook.Text = "New Notebook";
            this.menuitem_newbook.Click += new System.EventHandler(this.menuitem_newbook_Click);
            // 
            // menuitem_openbook
            // 
            this.menuitem_openbook.Name = "menuitem_openbook";
            this.menuitem_openbook.Size = new System.Drawing.Size(216, 26);
            this.menuitem_openbook.Text = "Open Notebook";
            // 
            // menuitem_closebook
            // 
            this.menuitem_closebook.Name = "menuitem_closebook";
            this.menuitem_closebook.Size = new System.Drawing.Size(216, 26);
            this.menuitem_closebook.Text = "Close Notebook";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 6);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "Delete Notebook";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // menuitem_save
            // 
            this.menuitem_save.Name = "menuitem_save";
            this.menuitem_save.Size = new System.Drawing.Size(216, 26);
            this.menuitem_save.Text = "Save Note";
            // 
            // menuitem_saveall
            // 
            this.menuitem_saveall.Name = "menuitem_saveall";
            this.menuitem_saveall.Size = new System.Drawing.Size(216, 26);
            this.menuitem_saveall.Text = "Save All Notes";
            // 
            // menuitem_saveas
            // 
            this.menuitem_saveas.Name = "menuitem_saveas";
            this.menuitem_saveas.Size = new System.Drawing.Size(216, 26);
            this.menuitem_saveas.Text = "Save Note As";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 6);
            // 
            // menuitem_exit
            // 
            this.menuitem_exit.Name = "menuitem_exit";
            this.menuitem_exit.Size = new System.Drawing.Size(216, 26);
            this.menuitem_exit.Text = "Exit";
            // 
            // splitwindow_main
            // 
            this.splitwindow_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitwindow_main.Location = new System.Drawing.Point(0, 0);
            this.splitwindow_main.Name = "splitwindow_main";
            // 
            // splitwindow_main.Panel1
            // 
            this.splitwindow_main.Panel1.Controls.Add(this.treeview_main);
            // 
            // splitwindow_main.Panel2
            // 
            this.splitwindow_main.Panel2.Controls.Add(this.tabControl1);
            this.splitwindow_main.Size = new System.Drawing.Size(800, 373);
            this.splitwindow_main.SplitterDistance = 257;
            this.splitwindow_main.TabIndex = 1;
            // 
            // treeview_main
            // 
            this.treeview_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeview_main.ImageIndex = 0;
            this.treeview_main.ImageList = this.imageList1;
            this.treeview_main.Location = new System.Drawing.Point(0, 0);
            this.treeview_main.Name = "treeview_main";
            treeNode1.Name = "note.001.0001";
            treeNode1.Text = "My first note";
            treeNode2.Name = "notebook_default";
            treeNode2.Text = "My Notebook";
            this.treeview_main.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeview_main.SelectedImageIndex = 0;
            this.treeview_main.Size = new System.Drawing.Size(257, 373);
            this.treeview_main.TabIndex = 0;
            this.treeview_main.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_main_AfterSelect);
            this.treeview_main.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeview_main_NodeMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitwindow_main);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 373);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menubar_main);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(207, 27);
            this.toolStrip1.TabIndex = 1;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TextTemplate.ico");
            // 
            // form_mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menubar_main;
            this.Name = "form_mainwindow";
            this.Text = "AlchemyNote";
            this.menubar_main.ResumeLayout(false);
            this.menubar_main.PerformLayout();
            this.splitwindow_main.Panel1.ResumeLayout(false);
            this.splitwindow_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitwindow_main)).EndInit();
            this.splitwindow_main.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menubar_main;
        private System.Windows.Forms.ToolStripMenuItem menubar_file;
        private System.Windows.Forms.ToolStripMenuItem menuitem_new;
        private System.Windows.Forms.ToolStripMenuItem menuitem_open;
        private System.Windows.Forms.ToolStripMenuItem menuitem_newbook;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuitem_close;
        private System.Windows.Forms.ToolStripMenuItem menuitem_revert;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuitem_save;
        private System.Windows.Forms.ToolStripMenuItem menuitem_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuitem_exit;
        private System.Windows.Forms.ToolStripMenuItem menuitem_openbook;
        private System.Windows.Forms.ToolStripMenuItem menuitem_closebook;
        private System.Windows.Forms.ToolStripMenuItem menuitem_saveall;
        private System.Windows.Forms.SplitContainer splitwindow_main;
        private System.Windows.Forms.TreeView treeview_main;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

