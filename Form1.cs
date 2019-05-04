using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRTFwriter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Без имени";
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                String file_name = saveFD.FileName;
                toolStripStatusLabel1.Text = file_name;
                rtbText.SaveFile(file_name);
            }
        }
        private void bFileOpen_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                String file_name = openFD.FileName;
                toolStripStatusLabel1.Text = file_name;
                rtbText.LoadFile(file_name);
            }
        }

        private void bFileSave_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == "Без имени")
                сохранитьКакToolStripMenuItem_Click(sender, e);
            else
                rtbText.SaveFile(toolStripStatusLabel1.Text);
        }

        private void bFileNew_Click(object sender, EventArgs e)
        {
            if (rtbText.TextLength > 0)
                if (MessageBox.Show("Сохранить содержимое окна редактирования?", "Запрос сохранения файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bFileSave_Click(sender, e);

            rtbText.Clear();
            toolStripStatusLabel1.Text = "Без имени";
        }

        private void bFileClose_Click(object sender, EventArgs e)
        {
            if (rtbText.TextLength > 0 && toolStripStatusLabel1.Text == "Без имени")
                if (MessageBox.Show("Сохранить содержимое окна редактирования?", "Запрос сохранения файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bFileSave_Click(sender, e);
            else
            {
                rtbText.SaveFile(toolStripStatusLabel1.Text);
                rtbText.Clear();
                toolStripStatusLabel1.Text = "Без имени";
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            bFileNew_Click(sender, e);
            Close();
        }

        private void bCut_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            Form2 form_about = new Form2();
            form_about.ShowDialog();
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            панельИнструментовToolStripMenuItem.Checked = !панельИнструментовToolStripMenuItem.Checked;
            ToolBar.Visible = панельИнструментовToolStripMenuItem.Checked;
        }

        private void bUndo_Click(object sender, EventArgs e)
        {
            rtbText.Undo();
        }

        private void bRedo_Click(object sender, EventArgs e)
        {
            rtbText.Redo();
        }
    }
}
