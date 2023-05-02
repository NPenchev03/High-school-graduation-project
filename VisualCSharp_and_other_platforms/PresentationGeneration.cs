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
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace VisualCSharp_and_other_platforms
{
    public partial class Presentation_Generation : Form
    {
        PowerPoint.Application app;
        PowerPoint.Presentation presentation;
        PowerPoint.Presentations presentations;
        PowerPoint.Slide slide;
        PowerPoint.Slides slides;
        PowerPoint.SlideRange slideRange;

        string themePath;
        string backgroundImagePath;
        object missValue = System.Reflection.Missing.Value;
        List<int> slidesNum = new List<int>();

        public Presentation_Generation()
        {
            InitializeComponent();
        }

        private void PowerPointGenerate_Load(object sender, EventArgs e)
        {
            Select_backgroundImg_btn.UseVisualStyleBackColor = false;
            Select_backgroundImg_btn.BackColor = Color.FromArgb(140, Select_backgroundImg_btn.BackColor);
            Clear_img_Selection_btn.UseVisualStyleBackColor = false;
            Clear_img_Selection_btn.BackColor = Color.FromArgb(140, Clear_img_Selection_btn.BackColor);
            Select_theme_btn.UseVisualStyleBackColor = false;
            Select_theme_btn.BackColor = Color.FromArgb(140, Select_theme_btn.BackColor);
            Clear_theme_btn.UseVisualStyleBackColor = false;
            Clear_theme_btn.BackColor = Color.FromArgb(140, Clear_theme_btn.BackColor);
            Generate_btn.UseVisualStyleBackColor = false;
            Generate_btn.BackColor = Color.FromArgb(140, Generate_btn.BackColor);
        }

        private void GenerateFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "NewCustomPowerPointFile",
                Filter = "PowerPoint Presentations (*.pptx)|*.pptx",
                Title = "Create a PowerPoint Presentation",
                InitialDirectory = @"C:\",
                DefaultExt = "pptx",
                CheckPathExists = true,
                FilterIndex = 1,
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    app = new PowerPoint.Application();
                    presentations = app.Presentations;
                    presentation = presentations.Add(Microsoft.Office.Core.MsoTriState.msoFalse);

                    for (int i = 1; i <= numericUpDown1.Value; i++)
                    {
                        slidesNum.Add(i);
                    }
                    for (int i = 1; i <= slidesNum.Count; i++)
                    {
                        if (i == 1)
                        {
                            slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutTitle);
                            if (slidesNum.Count == 1)
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (checkBox3.Checked == true)
                            {
                                if (i == slidesNum.Last())
                                {
                                    slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutTitle);
                                    break;
                                }
                            }
                            if (checkBox4.Checked == true)
                            {
                                if (i == slidesNum.Last() - 1)
                                {
                                    slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutText);
                                    continue;
                                }
                            }
                            if (checkBox2.Checked == true)
                            {
                                if (i == 2)
                                {
                                    slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutObject);
                                    slide.Comments.Add2(0f, 0f, "", "", "You can use this slide for a table of contents - Може да използвате този слайд като съдържание", "AD", "AD");
                                }
                                else if (i % 2 != 0)
                                {
                                    slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutObjectAndText);
                                }
                                else
                                {
                                    slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutTextAndObject);
                                }
                            }
                            else if (i % 2 != 0)
                            {
                                slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutObjectAndText);
                            }
                            else
                            {
                                slide = presentation.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutTextAndObject);
                            }
                        }
                    }
                    if (checkBox1.Checked == true)
                    {
                        if (backgroundImagePath != null)
                        {
                            slideRange = presentation.Slides.Range(slidesNum.ToArray());
                            slideRange.FollowMasterBackground = Microsoft.Office.Core.MsoTriState.msoFalse;
                            for (int i = 1; i <= slidesNum.Count; i++)
                            {
                                presentation.Slides[i].Background.Fill.UserPicture(backgroundImagePath);
                            }
                        }
                        else
                        {
                            throw new Exception("Please chose an image file! - Моля изберете снимка!");
                        }
                    }
                    if (checkBox5.Checked == true)
                    {
                        if (themePath != null)
                        {
                            presentation.ApplyTheme(themePath);
                        }
                        else
                        {
                            throw new Exception("Please chose a theme file! - Моля изберете тема!");
                        }
                    }
                    presentation.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Your presentation is ready! - Вашата презентация е готова!");
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Please chose an image file! - Моля изберете снимка!")
                    {
                        MessageBox.Show("Please chose an image file! - Моля изберете снимка!");
                    }

                    if (ex.Message == "Please chose a theme file! - Моля изберете тема!")
                    {
                        MessageBox.Show("Please chose a theme file! - Моля изберете тема!");
                    }
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
                    slidesNum.Clear();
                }
            }
        }
        private void Generate_btn_Click(object sender, EventArgs e)
        {
            GenerateFile();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void Select_backgroundImg_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = backgroundImagePath;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 1)
            {
                if (numericUpDown1.Value == 2)
                {
                    checkBox3.Enabled = true;
                    checkBox2.Enabled = false;
                    checkBox2.Checked = false;
                    checkBox4.Enabled = false;
                    checkBox4.Checked = false;
                }
                if (numericUpDown1.Value == 3)
                {
                    checkBox2.Enabled = true;
                    checkBox4.Enabled = false;
                    checkBox4.Checked = false;
                }
                if (numericUpDown1.Value == 4)
                {
                    checkBox4.Enabled = true;
                }
            }
            else
            {
                checkBox3.Checked = false;
                checkBox3.Enabled = false;
                checkBox2.Checked = false;
                checkBox2.Enabled = false;
                checkBox4.Checked = false;
                checkBox4.Enabled = false;
            }
        }

        private void Clear_img_Selection_btn_Click(object sender, EventArgs e)
        {
            backgroundImagePath = null;
            pictureBox1.ImageLocation = null;
        }

        private void Clear_theme_btn_Click(object sender, EventArgs e)
        {
            themePath = null;
            textBox1.Text = null;
        }

        private void Select_theme_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "PowerPoint Presentation Template (*.potx)|*.potx|" +
                "PowerPoint 2007 Theme/Template file (*.thmx)|*.thmx";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                themePath = openFileDialog.FileName;
                textBox1.Text = openFileDialog.FileName;
            }
        }
    }
}
