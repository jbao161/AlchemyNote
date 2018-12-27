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
        public form_mainwindow()
        {
            InitializeComponent();
            

            Properties.Settings.Default.user_name = System.Environment.UserName;
            Properties.Settings.Default.save_directory = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + "\\AlchemyNote" + "\\" + Properties.Settings.Default.user_name;

            PopulateTreeView();
        }

        private void menuitem_open_Click(object sender, EventArgs e)
        {

        }

        private void treeview_main_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuitem_newbook_Click(object sender, EventArgs e)
        {
            
            System.IO.Directory.CreateDirectory(Properties.Settings.Default.save_directory + "\\"+"New notebook");
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info; //  = new DirectoryInfo(@"../..");
            info = new DirectoryInfo(Properties.Settings.Default.save_directory);
       
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeview_main.Nodes.Add(rootNode);
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
            }
        }

        private void treeview_main_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }
    }
}
