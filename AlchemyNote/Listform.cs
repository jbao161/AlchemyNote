using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AlchemyNote
{
    public partial class Listform : Form
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


        public Listform()
        {
            InitializeComponent();
            AlchemyNote_Setup();
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
            timer_autosave.Interval = Properties.Settings.Default.autosave_delay_sec * 1000; // time in milliseconds to autosave
        }

        private void listView_notebooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_notebooks.SelectedItems.Count > 0)
            {
                Debug_console(listView_notebooks.SelectedItems[0].Text);
                current_notebook = listView_notebooks.SelectedItems[0].Text;
                Notes_populate(current_directory + "\\" + current_user + "\\" + current_notebook);
            }
        }

        private void listView_notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_notes.SelectedItems.Count > 0)
            {
                Debug_console(listView_notes.SelectedItems[0].Text);
                current_note = listView_notes.SelectedItems[0].Text;
                richTextBox_editor.LoadFile(current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + current_note + savenote_ext);
            }
        }

        private void richTextBox_editor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void richTextBox_editor_Leave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.autosave) Save_note();
        }
     
        private void richTextBox_editor_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.autosave) timer_autosave.Start();
        }
        private void timer_autosave_Tick(object sender, EventArgs e)
        {
            Save_note();
            Debug_console("Autosave: note \"" + current_note + "\" in notebook \"" + current_notebook + "\"");
            timer_autosave.Stop();
        }

        private void Save_note()
        {
            richTextBox_editor.SaveFile(@current_directory + "\\" + current_user + "\\" + current_notebook + "\\" + current_note + savenote_ext);
        }

        private void Listform_Load(object sender, EventArgs e)
        {
            Listview_setup();
            Notebooks_populate(current_directory + "\\" + current_user);
        }

        private void Listview_setup()
        {
            listView_notebooks.Columns.Add("Notebooks", -2, HorizontalAlignment.Left);
            //listView_notebooks.HeaderStyle = ColumnHeaderStyle.None;
            listView_notes.Columns.Add("Notes", -2, HorizontalAlignment.Left);
            //listView_notes.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void Notebooks_populate(string user_folder)
        {
            listView_notebooks.Items.Clear();

            string[] folders = Directory.GetDirectories(user_folder);
            foreach (string folder in folders)
            {
                string folderName = Path.GetFileName(folder);
                ListViewItem item = new ListViewItem(folderName);
                item.Tag = folder;

                listView_notebooks.Items.Add(item);
            }
        }
        private void Notes_populate(string notebook_folder)
        {
            listView_notes.Items.Clear();

            string[] files = Directory.GetFiles(notebook_folder);
            foreach (string file in files)
            {
                if (file.EndsWith(savenote_ext))
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = file;

                    listView_notes.Items.Add(item);
                }
            }
        }
    }
}

