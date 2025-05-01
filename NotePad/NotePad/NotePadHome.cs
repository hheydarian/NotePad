using System;
using System.Windows.Forms;

namespace NotePad
{
    public partial class NotePadHome : Form
    {
        public NotePadHome()
        {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Textpad_txt.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Do you want save this note?", "NotePad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog file = new SaveFileDialog();
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        //file.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";
                        Textpad_txt.SaveFile(file.FileName);
                    }

                }
            }

            Textpad_txt.Text = string.Empty;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                Textpad_txt.LoadFile(file.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Textpad_txt.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Do you want save this note?", "NotePad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog file = new SaveFileDialog();
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        //file.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";
                        Textpad_txt.SaveFile(file.FileName);
                    }

                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textpad_txt.Undo();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textpad_txt.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textpad_txt.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textpad_txt.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textpad_txt.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                Textpad_txt.Font = font.Font;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Textpad_txt.BackColor = color.Color;
            }
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Textpad_txt.ForeColor = color.Color;
            }
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Textpad_txt.SelectionColor = color.Color;
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }
    }
}
