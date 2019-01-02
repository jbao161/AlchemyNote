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
using System.Diagnostics;

namespace AlchemyNote
{
    public partial class form_mainwindow : Form
    {
        private /*static*/ bool doDebugOnlyCode = true;
        //[Conditional("DEBUG")]
        void Debug_console(string log_message)
        {
            if (doDebugOnlyCode) Console.Out.WriteLine(
                "Debug (" + DateTime.Now.ToString("yyyy_MM_dd_HHmmssfff") + "): " + log_message);
        }

        static public string current_directory, current_user, current_notebook, current_note;
        static public string savenote_ext;
        static public string directory_from, directory_to;
        TreeNode root_node;

        public form_mainwindow()
        {
            InitializeComponent();
            AlchemyNote_Setup();
            PopulateTreeView();
        }
        private void AlchemyNote_Setup()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.user_name))
            {
                Properties.Settings.Default.user_name = System.Environment.UserName;
            }
            if (String.IsNullOrEmpty(Properties.Settings.Default.save_directory))
            {
                Properties.Settings.Default.save_directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + "\\AlchemyNote";
            }

            current_directory = Properties.Settings.Default.save_directory;
            current_user = Properties.Settings.Default.user_name;
            savenote_ext = ".rtf";
            Directory.CreateDirectory(current_directory + "\\" + current_user); // creates save directory only if it doesn't exist
            Debug_console(current_directory);
            Debug_console(current_user);
        }
        private void Menuitem_open_Click(object sender, EventArgs e)
        {

        }

        private void Treeview_main_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null)
            { // this is the user level folder. do nothing. don't create notes in it, only notebooks
            }
            // if a notebook is selected, remember to create new notes in it
            else if (e.Node.Parent == root_node)
            {
                current_notebook = e.Node.Text;
                Debug_console("Notebook: \"" + current_notebook + "\" was selected.");
            }
            // if a note is selected, remember the notebook it is in
            else if (e.Node.Parent.GetType() == typeof(TreeNode))
            {
                current_notebook = e.Node.Parent.Text;
                Debug_console("Note: \"" + e.Node.Text + "\" was selected in notebook: \"" + current_notebook + "\"");
            }
        }
        private void Reload_treeview()
        {
            // reload all the nodes. this seems like a poor implementation to update changes to the system.
            // i'm deleting all the nodes, then creating them anew. will creating directoryinfo and treenodes each time cause memory leak?
            Treeview_main.Nodes.Clear();
            PopulateTreeView();
        }
        private void Menuitem_newbook_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(current_directory + "\\" + current_user + "\\" + "New notebook");
            Reload_treeview();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info; //  = new DirectoryInfo(@"../..");
            info = new DirectoryInfo(current_directory + "\\" + current_user);

            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                Treeview_main.Nodes.Add(rootNode);
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
        private void Treeview_main_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                // this is the user folder.
                if (e.Node.Parent == null)
                { 
                    directory_from = current_directory + "\\" + e.Node.Text;
                    directory_to = current_directory + "\\" + e.Label + "_tmp"; 
                    // change to a temporary name before new name to avoid case sensitive problems
                    System.IO.Directory.Move(@directory_from, @directory_to); 
                    directory_from = current_directory + "\\" + e.Label + "_tmp";
                    directory_to = current_directory + "\\" + e.Label;
                    System.IO.Directory.Move(@directory_from, @directory_to);
                    // store the changed settings
                    current_user = e.Label;
                    Properties.Settings.Default.user_name = current_user;
                    Properties.Settings.Default.Save();
                    Debug_console("User: \"" + e.Node.Text + "\" was renamed to \"" + current_user + "\"");
                }
                // this is a notebook
                else if (e.Node.Parent == root_node)
                {
                    directory_from = current_directory + "\\" + current_user + "\\" + e.Node.Text;
                    directory_to = current_directory + "\\" + current_user + "\\" + e.Label + "_tmp";
                    System.IO.Directory.Move(@directory_from, @directory_to);
                    directory_from = current_directory + "\\" + current_user + "\\" + e.Label + "_tmp";
                    directory_to = current_directory + "\\" + current_user + "\\" + e.Label;
                    System.IO.Directory.Move(@directory_from, @directory_to);
                    current_notebook = e.Label;
                    Debug_console("Notebook: \"" + e.Node.Text + "\" was renamed to \"" + current_notebook + "\"");
                }
                // this is a note
                else if (e.Node.Parent.GetType() == typeof(TreeNode))
                {
                    directory_from = current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + e.Node.Text;
                    directory_to = current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + e.Label + "_tmp";
                    System.IO.File.Move(@directory_from, @directory_to);
                    directory_from = current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + e.Label + "_tmp";
                    directory_to = current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + e.Label;
                    System.IO.File.Move(@directory_from, @directory_to);
                    current_note = e.Label;
                    Debug_console("Note: \"" + e.Node.Text + "\" in notebook: \"" + current_notebook
                        + "\" was renamed to \"" + current_note + "\"" + "\" in notebook: \"" + current_notebook + "\"");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error (\"" + error.Source + "\"): Failed to change \"" + e.Node.Text + "\" to \"" + e.Label + "\"");
                e.CancelEdit = true;

                Debug_console(error.Source);
                //Changing directory name failed
                Console.Out.WriteLine(e.Node.Text + " old name");
                Console.Out.WriteLine(e.Label + " new name");
            }
        }


        private void Treeview_main_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void Menuitem_new_Click(object sender, EventArgs e)
        {
            string fileLoc = current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + "new note" + savenote_ext;
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.SaveFile(@fileLoc, RichTextBoxStreamType.RichText);
            richTextBox1.Dispose();
            Reload_treeview();
        }
    }
}
