using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notedpad
{
    public partial class NotepadApp : Form
    {
        public NotepadApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Title = "Open";
            opendialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (opendialog.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(opendialog.FileName, RichTextBoxStreamType.PlainText);
            this.Text = opendialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog opendialog = new SaveFileDialog();
            opendialog.Title = "Save";
            opendialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (opendialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(opendialog.FileName, RichTextBoxStreamType.PlainText);
            this.Text = opendialog.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogresult = printDialog1.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {

            }

        }



        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = String.Empty;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = System.DateTime.Now.ToString();
            //richTextBox1.SelectedText = DateTime.Now.ToString("M/dd /yyyy");
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectedText = DateTime.Now.ToString();
        }


        //Belongs with font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fnt.Font;
                richTextBox1.ForeColor = fnt.Color;
            }


        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = fnt.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new Form2();
            aboutForm.ShowDialog();
        }
    }
}
