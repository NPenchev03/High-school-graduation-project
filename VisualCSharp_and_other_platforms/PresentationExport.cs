using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace VisualCSharp_and_other_platforms
{
    public partial class Presentation_Export : Form
    {
        PowerPoint.Application app;
        PowerPoint.Presentation presentation;
        string filePath;
        public Presentation_Export()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "PowerPoint files (*.pptx)|*.pptx";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBox1.Text = filePath;
                Clear_selection_btn.Enabled = true;
                Export_PDF_btn.Enabled = true;
                Export_XPS_btn.Enabled = true;
            }
        }

        private void Clear_selection_btn_Click(object sender, EventArgs e)
        {
            filePath = null;
            textBox1.Text = null;
            Clear_selection_btn.Enabled = false;
        }

        private void ExportToXPS()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "",
                Filter = "XPS Files (*.xps)|*.xps",
                Title = "Export as XPS",
                InitialDirectory = @"C:\",
                DefaultExt = "xps",
                CheckPathExists = true,
                FilterIndex = 1,
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    app = new PowerPoint.Application();
                    presentation = app.Presentations.Open(filePath, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse);

                    presentation.ExportAsFixedFormat2(saveFileDialog.FileName, PowerPoint.PpFixedFormatType.ppFixedFormatTypeXPS);
                    MessageBox.Show("You chosen file was exported successfully! - Избраният файл беше експортиран успешно");
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    if (presentation != null)
                    {
                        presentation.Close();
                    }
                    if (app != null)
                    {
                        app.Quit();
                    }
                    Export_PDF_btn.Enabled = false;
                    Export_XPS_btn.Enabled = false;
                    filePath = null;
                    textBox1.Text = "";
                    Clear_selection_btn.Enabled = false;
                }

            }

        }
        private void ExportToPDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "",
                Filter = "PDF Documents (*.pdf)|*.pdf",
                Title = "Export as PDF",
                InitialDirectory = @"C:\",
                DefaultExt = "pdf",
                CheckPathExists = true,
                FilterIndex = 1,
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    app = new PowerPoint.Application();
                    presentation = app.Presentations.Open(filePath, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse);

                    presentation.ExportAsFixedFormat2(saveFileDialog.FileName, PowerPoint.PpFixedFormatType.ppFixedFormatTypePDF);
                    MessageBox.Show("Your chosen file was exported successfully! - Избраният файл беше експортиран успешно");
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally 
                {
                    if (presentation != null)
                    {
                        presentation.Close();
                    }
                    if (app != null)
                    {
                        app.Quit();
                    }
                    Export_PDF_btn.Enabled = false;
                    Export_XPS_btn.Enabled = false;
                    filePath = null;
                    textBox1.Text = "";
                    Clear_selection_btn.Enabled = false;
                }
                
            }
        }
        private void Export_PDF_btn_Click(object sender, EventArgs e)
        {
            ExportToPDF();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Export_XPS_btn_Click(object sender, EventArgs e)
        {
            ExportToXPS();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PowerPointExport_Load(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(140, button1.BackColor);
            Clear_selection_btn.UseVisualStyleBackColor = false;
            Clear_selection_btn.BackColor = Color.FromArgb(140, Clear_selection_btn.BackColor);
            Export_PDF_btn.UseVisualStyleBackColor = false;
            Export_PDF_btn.BackColor = Color.FromArgb(140, Export_PDF_btn.BackColor);
            Export_XPS_btn.UseVisualStyleBackColor = false;
            Export_XPS_btn.BackColor = Color.FromArgb(140, Export_XPS_btn.BackColor);
        }
    }
}
