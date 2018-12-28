using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlchemyNote
{
    public partial class form_mainwindow : Form
    {
        string current_directory, current_user, current_notebook, current_note;
        string savenote_ext;
        TreeNode root_node;

        public form_mainwindow()
        {
            InitializeComponent();
            AlchemyNote_Setup();
            PopulateTreeView();
        }
        private void AlchemyNote_Setup()
        {
            Properties.Settings.Default.user_name = System.Environment.UserName;
            Properties.Settings.Default.save_directory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + "\\AlchemyNote";
            current_directory = Properties.Settings.Default.save_directory;
            current_user = Properties.Settings.Default.user_name;
            savenote_ext = ".rtf";
        }
        private void menuitem_open_Click(object sender, EventArgs e)
        {

        }

        private void treeview_main_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Parent == null)
            { // this is the user level folder. do nothing. don't create notes in it, only notebooks
            }
            // if a notebook is selected, remember to create new notes in it
            else if (e.Node.Parent == root_node) { 
                current_notebook = e.Node.Text;
                MessageBox.Show(current_notebook);
            }
            // if a note is selected, remember the notebook it is in
            else if (e.Node.Parent.GetType() == typeof(TreeNode))
            {
                current_notebook = e.Node.Parent.Text;
                MessageBox.Show(current_notebook);
            }
        }
        private void Reload_treeview()
        {
            // reload all the nodes. this seems like a poor implementation to update changes to the system.
            // i'm deleting all the nodes, then creating them anew. will creating directoryinfo and treenodes each time cause memory leak?
            treeview_main.Nodes.Clear();
            PopulateTreeView();
        }
        private void menuitem_newbook_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(Properties.Settings.Default.save_directory + "\\"+ current_user + "\\"+"New notebook");
            Reload_treeview();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info; //  = new DirectoryInfo(@"../..");
            info = new DirectoryInfo(Properties.Settings.Default.save_directory + "\\" + current_user);
       
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeview_main.Nodes.Add(rootNode);
                root_node = rootNode;
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
                GetFiles(subDir, aNode);
            }
        }
        void GetFiles(DirectoryInfo d, TreeNode node)

        {

            FileInfo[] subfileInfo = d.GetFiles("*.*");

            if (subfileInfo.Length > 0)

            {

                for (int j = 0; j < subfileInfo.Length; j++)

                {

                    node.Nodes.Add(subfileInfo[j].Name);

                }

            }

        }
        private void treeview_main_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void menuitem_new_Click(object sender, EventArgs e)
        {
            string fileLoc = current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + "new note" + savenote_ext;
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.SaveFile(@fileLoc, RichTextBoxStreamType.RichText);
            richTextBox1.Dispose();
            Reload_treeview();
        }
    }
}
