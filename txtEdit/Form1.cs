using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TextEditing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void BtnOtvori_Click(object sender, EventArgs e)
        {
            TxtBox.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf| Plain Text File (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;

            RichTextBoxStreamType stream_type;
            stream_type = RichTextBoxStreamType.RichText;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    return;
                }
                if (openFileDialog.FilterIndex == 2)
                {
                    stream_type = RichTextBoxStreamType.PlainText;
                }
                TxtBox.LoadFile(openFileDialog.FileName, stream_type);
            }
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf| Plain Text File (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, String.Empty);
                filename = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            RichTextBoxStreamType stream_type;
            if (saveFileDialog.FilterIndex == 2)
            {
                stream_type = RichTextBoxStreamType.PlainText;
            }
            else
            {
                stream_type = RichTextBoxStreamType.RichText;
            }

            TxtBox.SaveFile(filename, stream_type);
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = TxtBox.SelectionFont;
            if (SelectedText_Font != null)
            {
                TxtBox.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
            }
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = TxtBox.SelectionFont;
            if (SelectedText_Font != null)
            {
                TxtBox.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
            }
        }

        private void BtnUnder_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = TxtBox.SelectionFont;
            if (SelectedText_Font != null)
            {
                TxtBox.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                BtnBold.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.I)
            {
                BtnItalic.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.U)
            {
                BtnUnder.PerformClick();
            }
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
