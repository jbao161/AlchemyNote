namespace AlchemyNote
{
    partial class Listform
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView_notebooks = new System.Windows.Forms.ListView();
            this.listView_notes = new System.Windows.Forms.ListView();
            this.richTextBox_editor = new System.Windows.Forms.RichTextBox();
            this.timer_autosave = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_editor);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView_notebooks);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView_notes);
            this.splitContainer2.Size = new System.Drawing.Size(266, 425);
            this.splitContainer2.SplitterDistance = 88;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView_notebooks
            // 
            this.listView_notebooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_notebooks.FullRowSelect = true;
            this.listView_notebooks.HideSelection = false;
            this.listView_notebooks.LabelEdit = true;
            this.listView_notebooks.Location = new System.Drawing.Point(0, 0);
            this.listView_notebooks.MultiSelect = false;
            this.listView_notebooks.Name = "listView_notebooks";
            this.listView_notebooks.Size = new System.Drawing.Size(88, 425);
            this.listView_notebooks.TabIndex = 0;
            this.listView_notebooks.UseCompatibleStateImageBehavior = false;
            this.listView_notebooks.View = System.Windows.Forms.View.Details;
            this.listView_notebooks.SelectedIndexChanged += new System.EventHandler(this.listView_notebooks_SelectedIndexChanged);
            // 
            // listView_notes
            // 
            this.listView_notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_notes.FullRowSelect = true;
            this.listView_notes.HideSelection = false;
            this.listView_notes.Location = new System.Drawing.Point(0, 0);
            this.listView_notes.MultiSelect = false;
            this.listView_notes.Name = "listView_notes";
            this.listView_notes.Size = new System.Drawing.Size(174, 425);
            this.listView_notes.TabIndex = 0;
            this.listView_notes.UseCompatibleStateImageBehavior = false;
            this.listView_notes.View = System.Windows.Forms.View.Details;
            this.listView_notes.SelectedIndexChanged += new System.EventHandler(this.listView_notes_SelectedIndexChanged);
            // 
            // richTextBox_editor
            // 
            this.richTextBox_editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_editor.HideSelection = false;
            this.richTextBox_editor.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_editor.Name = "richTextBox_editor";
            this.richTextBox_editor.Size = new System.Drawing.Size(530, 425);
            this.richTextBox_editor.TabIndex = 0;
            this.richTextBox_editor.Text = "";
            this.richTextBox_editor.TextChanged += new System.EventHandler(this.richTextBox_editor_TextChanged);
            this.richTextBox_editor.Leave += new System.EventHandler(this.richTextBox_editor_Leave);
            // 
            // timer_autosave
            // 
            this.timer_autosave.Interval = 5000;
            this.timer_autosave.Tick += new System.EventHandler(this.timer_autosave_Tick);
            // 
            // Listform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Listform";
            this.Text = "Listform";
            this.Load += new System.EventHandler(this.Listform_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView_notebooks;
        private System.Windows.Forms.ListView listView_notes;
        private System.Windows.Forms.RichTextBox richTextBox_editor;
        private System.Windows.Forms.Timer timer_autosave;
    }
}