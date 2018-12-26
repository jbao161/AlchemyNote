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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My first note");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("My Notebook", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.menubar_main = new System.Windows.Forms.MenuStrip();
            this.menubar_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_close = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_revert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_newbook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_openbook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_closebook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_saveall = new System.Windows.Forms.ToolStripMenuItem();
            this.splitwindow_main = new System.Windows.Forms.SplitContainer();
            this.treeview_main = new System.Windows.Forms.TreeView();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menubar_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitwindow_main)).BeginInit();
            this.splitwindow_main.Panel1.SuspendLayout();
            this.splitwindow_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar_main
            // 
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
            // menuitem_save
            // 
            this.menuitem_save.Name = "menuitem_save";
            this.menuitem_save.Size = new System.Drawing.Size(216, 26);
            this.menuitem_save.Text = "Save Note";
            // 
            // menuitem_saveas
            // 
            this.menuitem_saveas.Name = "menuitem_saveas";
            this.menuitem_saveas.Size = new System.Drawing.Size(216, 26);
            this.menuitem_saveas.Text = "Save Note As";
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
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
            // menuitem_newbook
            // 
            this.menuitem_newbook.Name = "menuitem_newbook";
            this.menuitem_newbook.Size = new System.Drawing.Size(216, 26);
            this.menuitem_newbook.Text = "New Notebook";
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
            // menuitem_saveall
            // 
            this.menuitem_saveall.Name = "menuitem_saveall";
            this.menuitem_saveall.Size = new System.Drawing.Size(216, 26);
            this.menuitem_saveall.Text = "Save All Notes";
            // 
            // splitwindow_main
            // 
            this.splitwindow_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitwindow_main.Location = new System.Drawing.Point(0, 28);
            this.splitwindow_main.Name = "splitwindow_main";
            // 
            // splitwindow_main.Panel1
            // 
            this.splitwindow_main.Panel1.Controls.Add(this.treeview_main);
            this.splitwindow_main.Size = new System.Drawing.Size(800, 422);
            this.splitwindow_main.SplitterDistance = 266;
            this.splitwindow_main.TabIndex = 1;
            // 
            // treeview_main
            // 
            this.treeview_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeview_main.Location = new System.Drawing.Point(0, 0);
            this.treeview_main.Name = "treeview_main";
            treeNode1.Name = "note.001.0001";
            treeNode1.Text = "My first note";
            treeNode2.Name = "notebook_default";
            treeNode2.Text = "My Notebook";
            this.treeview_main.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeview_main.Size = new System.Drawing.Size(266, 422);
            this.treeview_main.TabIndex = 0;
            this.treeview_main.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_main_AfterSelect);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "Delete Notebook";
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
            // form_mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitwindow_main);
            this.Controls.Add(this.menubar_main);
            this.MainMenuStrip = this.menubar_main;
            this.Name = "form_mainwindow";
            this.Text = "AlchemyNote";
            this.menubar_main.ResumeLayout(false);
            this.menubar_main.PerformLayout();
            this.splitwindow_main.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitwindow_main)).EndInit();
            this.splitwindow_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

