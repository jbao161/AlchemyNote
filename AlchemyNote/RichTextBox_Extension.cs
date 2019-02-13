using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlchemyNote
{
    // Cut Copy Paste Select All for Rich Text Box
    // https://stackoverflow.com/questions/18966407/enable-copy-cut-past-window-in-a-rich-text-box
    public static class RichTextBox_Extension
    {
        public static void AddContextMenu(this RichTextBox rtb)
        {
            if (rtb.ContextMenuStrip == null)
            {
                ContextMenuStrip cms = new ContextMenuStrip { ShowImageMargin = false };
                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Cut");
                tsmiCut.Click += (sender, e) => rtb.Cut();
                tsmiCut.ShortcutKeys = Keys.X | Keys.Control;
                cms.Items.Add(tsmiCut);
                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
                tsmiCopy.Click += (sender, e) => rtb.Copy();
                tsmiCopy.ShortcutKeys = Keys.C | Keys.Control;
                cms.Items.Add(tsmiCopy);
                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Paste");
                tsmiPaste.Click += (sender, e) => rtb.Paste();
                tsmiPaste.ShortcutKeys = Keys.V | Keys.Control;
                cms.Items.Add(tsmiPaste);
                ToolStripMenuItem tsmiSelectAll = new ToolStripMenuItem("Select All");
                tsmiSelectAll.Click += (sender, e) => rtb.SelectAll();
                tsmiSelectAll.ShortcutKeys = Keys.A | Keys.Control;
                cms.Items.Add(tsmiSelectAll);

                rtb.ContextMenuStrip = cms;
            }
        }
    }
}
