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

namespace deneme
{
    public partial class Editor : Form
    {
        public string currentFile = null;
        public Editor()
        {
            InitializeComponent();
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            webBrowser1.DocumentText = fastColoredTextBox1.Text;
        }

        private void copyPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy(); 
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to delete current page ?", "New", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fastColoredTextBox1.Clear();
                currentFile = null;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to delete current page ?", "Open", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "HTML File|*.html|Any File|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(op.FileName);
                    currentFile = op.FileName;
                    fastColoredTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                StreamWriter sw = new StreamWriter(currentFile);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "HTML File|*.html|Any File|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(op.FileName);
                currentFile = op.FileName;
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to delete current page and exit ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }
    }
    }

