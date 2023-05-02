using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace VisualCSharp_and_other_platforms
{
    public partial class Text_Editor : Form
    {
        Word.Application app;
        Word.Document doc;
        Word.Range contentRange;
        string text;
        object miss = System.Reflection.Missing.Value;
        public Text_Editor()
        {
            InitializeComponent();
        }

        private void Open_word_file_Click(object sender, EventArgs e)
        {
            OpenFile();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Word Documents (*.doc;*.docx)|*.doc;*.docx";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    app = new Word.Application();
                    doc = app.Documents.Add(openFileDialog.FileName);
                    contentRange = doc.Content;
                    text = contentRange.Text;
                    richTextBox1.Text = text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (doc != null)
                    {
                        doc.Close(false);
                    }
                    if (app != null)
                    {
                        app.Quit(false);
                    }
                }
            }
        }
        private void SaveFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = "NewCustomWordFile",
                Filter = "Word Documents (*.doc;*.docx)|*.doc;*.docx",
                Title = "Create a Word Document",
                InitialDirectory = @"C:\",
                DefaultExt = "docx",
                CheckPathExists = true,
                FilterIndex = 1,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    app = new Word.Application();
                    doc = app.Documents.Add();
                    doc.Content.Text = richTextBox1.Text;
                    doc.SaveAs2(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (doc != null)
                    {
                        doc.Close(false);
                    }
                    if (app != null)
                    {
                        app.Quit(false);
                    }
                }
            }
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            SaveFile();
            Reset();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Reset()
        {
            richTextBox1.Text = "";
        }

        private void Text_Editor_Load(object sender, EventArgs e)
        {
            Open_word_file.UseVisualStyleBackColor = false;
            Open_word_file.BackColor = Color.FromArgb(140, Open_word_file.BackColor);
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.BackColor = Color.FromArgb(140, Save_btn.BackColor);
        }
    }
}
