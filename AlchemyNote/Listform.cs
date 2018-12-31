using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AlchemyNote
{
    public partial class Listform : Form
    {
        public Listform()
        {
            InitializeComponent();
            AlchemyNote_Setup();
        }
        static public string current_directory, current_user, current_notebook, current_note;
        static public string savenote_ext;
        static public string directory_from, directory_to;
        TreeNode root_node;

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
        }
        private void Listform_Load(object sender, EventArgs e)
        {
                listView1.Items.Clear();

                string[] files = Directory.GetFiles(current_directory);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = file;

                    listView1.Items.Add(item);
                }
            }
        }
    }

