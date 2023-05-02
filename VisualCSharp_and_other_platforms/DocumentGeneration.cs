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
    public partial class Document_Generation : Form
    {
        Word.Application app;
        Word.Document doc;
        object obMissing = System.Reflection.Missing.Value;
        object obFalse = false;
        object obTrue = false;
        string logoPath;
        public Document_Generation()
        {
            InitializeComponent();
        }
        private void WordGenerate_Load(object sender, EventArgs e)
        {
            Generate_doc_btn.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            Select_logo_btn.Enabled = false;
            Clear_logo_btn.Enabled = false;
            Clear_logo_btn.UseVisualStyleBackColor = false;
            Clear_logo_btn.BackColor = Color.FromArgb(140, Clear_logo_btn.BackColor);
            Select_logo_btn.UseVisualStyleBackColor = false;
            Select_logo_btn.BackColor = Color.FromArgb(140, Select_logo_btn.BackColor);
            Generate_doc_btn.UseVisualStyleBackColor = false;
            Generate_doc_btn.BackColor = Color.FromArgb(140, Generate_doc_btn.BackColor);
        }
        private void GenerateDoc()
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

                    if (checkBox1.Checked == true)
                    {
                        if (logoPath != null)
                        {
                            app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekCurrentPageHeader;
                            Word.Shape logoCust = null;
                            logoCust = app.Selection.HeaderFooter.Shapes.AddPicture(logoPath);
                            logoCust.Select(ref obMissing);
                            logoCust.Name = "CustLogo";
                            logoCust.Left = (float)Word.WdShapePosition.wdShapeLeft;
                            app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekMainDocument;
                        }
                        else
                        {
                            throw new Exception("Please chose an image file! - Моля изберете снимка!");
                        }
                    }

                    if (checkBox2.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekCurrentPageHeader;
                            Word.Shape logoWatermark;
                            logoWatermark = app.Selection.HeaderFooter.Shapes.AddTextEffect(
                                Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect1, textBox1.Text,
                                "Times New Roman", (float)60, Microsoft.Office.Core.MsoTriState.msoTrue,
                                Microsoft.Office.Core.MsoTriState.msoFalse, 0, 0, ref obMissing);
                            logoWatermark.Select(ref obMissing);
                            logoWatermark.Fill.Visible = Microsoft.Office.Core.MsoTriState.msoTrue;
                            logoWatermark.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;
                            logoWatermark.Fill.Solid();
                            logoWatermark.Fill.ForeColor.RGB = (Int32)Word.WdColor.wdColorGray30;
                            logoWatermark.RelativeHorizontalPosition = Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionMargin;
                            logoWatermark.RelativeVerticalPosition = Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionMargin;
                            logoWatermark.Left = (float)Word.WdShapePosition.wdShapeCenter;
                            logoWatermark.Top = (float)Word.WdShapePosition.wdShapeCenter;
                            logoWatermark.Height = app.InchesToPoints(2.4f);
                            logoWatermark.Width = app.InchesToPoints(6f);
                            app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekMainDocument;
                        }
                        else
                        {
                            throw new Exception("Please enter a watermark! - Моля въведете воден знак!");
                        }
                    }

                    if (checkBox3.Checked == true)
                    {
                        app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekCurrentPageFooter;
                        app.Selection.TypeParagraph();
                        app.Selection.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        app.ActiveWindow.Selection.Font.Name = "Times New Roman";
                        app.ActiveWindow.Selection.Font.Size = 8;
                        app.ActiveWindow.Selection.TypeText("София, 2022г.");
                        app.ActiveWindow.Selection.TypeText("\t");
                        app.ActiveWindow.Selection.TypeText("");
                        app.ActiveWindow.Selection.TypeText("\t");
                        app.ActiveWindow.Selection.TypeText("Страница ");
                        Object CurrentPage = Word.WdFieldType.wdFieldPage;
                        app.ActiveWindow.Selection.Fields.Add(app.Selection.Range, ref CurrentPage, ref obMissing, ref obMissing);
                        app.ActiveWindow.Selection.TypeText(" от ");
                        Object TotalPages = Word.WdFieldType.wdFieldNumPages;
                        app.ActiveWindow.Selection.Fields.Add(app.Selection.Range, ref TotalPages, ref obMissing, ref obMissing);
                        app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekMainDocument;
                    }
                    if (checkBox4.Checked == true)
                    {
                        if (textBox2.Text != "")
                        {
                            app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekCurrentPageFooter;
                            Word.Shape rightText;
                            rightText = app.Selection.HeaderFooter.Shapes.AddTextEffect(
                                Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect1,
                                textBox2.Text, "Times New Roman", (float)10,
                                Microsoft.Office.Core.MsoTriState.msoTrue,
                                Microsoft.Office.Core.MsoTriState.msoFalse,
                                0, 0, ref obMissing);

                            rightText.Select(ref obMissing);
                            rightText.Name = "right text";
                            rightText.Fill.Visible = Microsoft.Office.Core.MsoTriState.msoTrue;
                            rightText.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;
                            rightText.Fill.Solid();
                            rightText.Fill.ForeColor.RGB = (int)Word.WdColor.wdColorGray375;

                            rightText.Rotation = (float)90;
                            rightText.RelativeHorizontalPosition =
                                Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionMargin;
                            rightText.RelativeVerticalPosition =
                                Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionMargin;
                            rightText.Top = (float)Word.WdShapePosition.wdShapeCenter;
                            rightText.Left = 480;
                            app.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekMainDocument;
                        }
                        else
                        {
                            throw new Exception("Please enter some text! - Моля въведете текст!");
                        }
                    }
                    doc.SaveAs2(saveFileDialog1.FileName);
                    MessageBox.Show("Your document is ready! - Вашият документ е готов!");
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Please chose an image file! - Моля изберете снимка!")
                    {
                        MessageBox.Show(ex.Message);
                    }
                    else if (ex.Message == "Please enter a watermark! - Моля въведете воден знак!")
                    {
                        MessageBox.Show(ex.Message);
                    }
                    else if (ex.Message == "Please enter some text! - Моля въведете текст!")
                    {
                        MessageBox.Show(ex.Message);
                    }
                    else
                    {
                        MessageBox.Show("Please make sure that the document that's going to be overwritten is closed before proceeding. - Моля, уверете се, че документът, който ще бъде заместен е затворен.");
                    }
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
        private void Generate_doc_btn_Click(object sender, EventArgs e)
        {
            GenerateDoc();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void CheckCheckBoxes()
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true
             || checkBox4.Checked == true)
            {
                Generate_doc_btn.Enabled = true;
                if (checkBox1.Checked == true)
                {
                    Select_logo_btn.Enabled = true;
                    Clear_logo_btn.Enabled = true;
                }
                else
                {
                    ClearLogo();
                    Select_logo_btn.Enabled = false;
                    Clear_logo_btn.Enabled = false;
                }
                if (checkBox2.Checked == true)
                {
                    textBox1.Enabled = true;
                }
                else
                {
                    textBox1.Enabled = false;
                    textBox1.Text = "";
                }
                if (checkBox4.Checked == true)
                {
                    textBox2.Enabled = true;
                }
                else
                {
                    textBox2.Enabled = false;
                    textBox2.Text = "";
                }
            }
            else
            {
                Generate_doc_btn.Enabled = false;
                textBox1.Enabled = false;
                textBox1.Text = "";
                textBox2.Enabled = false;
                textBox2.Text = "";
                Clear_logo_btn.Enabled = false;
                Select_logo_btn.Enabled = false;
                ClearLogo();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBoxes();
        }

        private void Select_logo_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                logoPath = openFileDialog.FileName;
                pictureBox1.ImageLocation = logoPath;
            }
        }

        private void Clear_logo_btn_Click(object sender, EventArgs e)
        {
            ClearLogo();
        }
        private void ClearLogo()
        {
            logoPath = null;
            pictureBox1.ImageLocation = null;
        }
    }
}
