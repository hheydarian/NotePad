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
    }
}
