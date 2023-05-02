using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace VisualCSharp_and_other_platforms
{
    public partial class Charts : Form
    {
        Excel.Application app;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;
        Excel.Range chartRange;
        Excel.Workbooks workbooks;
        Excel.Worksheets worksheets;
        object missingValue = System.Reflection.Missing.Value;
        Random num = new Random();
        int counter = 0;
        List<string> list = new List<string>();

        public Charts()
        {
            InitializeComponent();
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Start_btn_Click(object sender, EventArgs e)
        {

        }
        
        private void Continue_btn_Click(object sender, EventArgs e)
        {
            counter++;
        }
        int fileNameCounter = 1;
        
        private void Form_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Exit_app_btn.UseVisualStyleBackColor = false;
            Exit_app_btn.BackColor = Color.FromArgb(140, Exit_app_btn.BackColor);
            Main_menu_btn.UseVisualStyleBackColor = false;
            Main_menu_btn.BackColor = Color.FromArgb(140, Main_menu_btn.BackColor);
        }
        private void ExcelDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.RestoreDirectory = true;

            Excel.ChartObjects xlCharts;
            Excel.ChartObject myChart;
            Excel.Chart chartPage;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    app = new Excel.Application();
                    app.Visible = false;

                    workbook = app.Workbooks.Open(openFileDialog.FileName);
                    worksheet = workbook.Worksheets.get_Item(1);
                    if (worksheet.ChartObjects().Count > 0)
                    {
                        throw new Exception("Please choose a file without any charts already in it - Моля изберете файл, в който няма вече създадени графики.");
                    }
                    xlCharts = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
                    myChart = xlCharts.Add(10, 80, 300, 250);
                    chartPage = myChart.Chart;
                    chartRange = worksheet.UsedRange;
                    chartPage.SetSourceData(chartRange, missingValue);
                    chartPage.ChartStyle = 309;
                    if (radioButton1.Checked == true)
                    {
                        chartPage.ChartType = Excel.XlChartType.xlPie;
                        try
                        {
                            chartPage.ChartTitle.Text = "Generated Pie Chart - Генерирана кръгова диаграма";
                        }
                        catch (Exception)
                        {

                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        chartPage.ChartType = Excel.XlChartType.xlDoughnut;
                    }
                    if (radioButton3.Checked == true)
                    {
                        chartPage.ChartType = Excel.XlChartType.xlLine;
                    }
                    var selectedOption = MessageBox.Show("Would you like to export the chart in a new folder(or the already existing - Excel charts folder) on your desktop? - Бихте ли искали да експортирана графиката в нова папка(или във вече съществуващата Excel charts folder) на Вашият десктоп?", "Save the chart - Запазване на диаграма", MessageBoxButtons.YesNo);
                    if (selectedOption == DialogResult.Yes)
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        var folder = Path.Combine(path, "Excel charts folder");
                        if (Directory.Exists(folder) == false)
                        {
                            Directory.CreateDirectory(folder);
                        }
                        while (File.Exists($@"{folder}\excel_chart_export{fileNameCounter}.bmp") == true)
                        {
                            fileNameCounter++;
                        }
                        chartPage.Export($@"{folder}\excel_chart_export{fileNameCounter}.bmp", "BMP", missingValue);
                        pictureBox1.Image = new Bitmap($@"{folder}\excel_chart_export{fileNameCounter}.bmp");
                        if (checkBox1.Checked == true)
                        {
                            string dir = Path.GetDirectoryName(openFileDialog.FileName);
                            dir = dir + "\\";
                            string name = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                            string ext = Path.GetExtension(openFileDialog.FileName);
                            fileNameCounter = 1;
                            while (File.Exists($"{dir}{name}{fileNameCounter}{ext}") == true)
                            {
                                fileNameCounter++;
                            }
                            openFileDialog.FileName = $"{dir}{name}{fileNameCounter}{ext}";
                            workbook.SaveAs($"{openFileDialog.FileName}", AccessMode: Excel.XlSaveAsAccessMode.xlShared);
                        }
                    }
                    else
                    {
                        if (checkBox1.Checked == true)
                        {
                            string dir = Path.GetDirectoryName(openFileDialog.FileName);
                            dir = dir + "\\";
                            string name = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                            string ext = Path.GetExtension(openFileDialog.FileName);
                            fileNameCounter = 1;
                            while (File.Exists($"{dir}{name}{fileNameCounter}{ext}") == true)
                            {
                                fileNameCounter++;
                            }
                            openFileDialog.FileName = $"{dir}{name}{fileNameCounter}{ext}";
                            workbook.SaveAs($"{openFileDialog.FileName}", AccessMode: Excel.XlSaveAsAccessMode.xlShared);
                            MessageBox.Show("The chart can't be displayed since it wasn't exported. - Диаграмата не може да бъде показана, защото не беше експортирана.");
                        }
                        MessageBox.Show("If you want the chart to be diplayed on the PictureBox control, please choose the yes option on the export message box. - Ако искате диаграмата да бъде показана в PictureBox контролата, моля изберете yes при запитване за експортиране на диаграмата.");

                    }
                    ClearObject(xlCharts);
                    ClearObject(chartPage);
                    ClearObject(myChart);
                    ClearObject(worksheet);
                    ClearObject(workbooks);
                    ClearObject(worksheets);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Please choose a file without any charts already in it - Моля изберете файл, в който няма вече създадени графики.")
                    {
                        MessageBox.Show("Please choose a file without any charts already in it - Моля изберете файл, в който няма вече създадени графики.");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
                finally
                {
                    
                    if (workbook != null)
                    {
                        workbook.Close(false);
                    }
                    if (app != null)
                    {
                        app.Quit();
                        ClearObject(app);
                    }
                    
                }
            }
        }

        private void ClearObject(object ob)
        {
            try
            {
                Marshal.FinalReleaseComObject(ob);
                GC.WaitForPendingFinalizers();
            }
            catch
            {

               
            }
            finally 
            {
                ob = null;
            } 
        }
        private void Exit_app_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFile();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButtons();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButtons();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButtons();
        }

        private void CheckRadioButtons() 
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked ==  true)
            {
                button1.Enabled = true;
            }
        }
        private void Main_menu_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
            ((Form)this.TopLevelControl).Close();
        }

        private void ExcelDraw_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void GenerateFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = "NewExcelFile",
                Filter = "Excel File|*.xlsx",
                Title = "Create an Excel File",
                InitialDirectory = @"C:\",
                DefaultExt = "xlsx",
                CheckPathExists = true,
                FilterIndex = 1,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                app = new Excel.Application();
                workbook = app.Workbooks.Add();
                if (worksheet == null)
                {
                    worksheet = workbook.Worksheets.get_Item(1);
                }
                list.Add("първи");
                list.Add("втори");
                list.Add("трети");
                list.Add("четвърти");
                worksheet = workbook.Worksheets.get_Item(1);
                for (int i = 1; i <= 4; i++)
                {
                    worksheet.Cells[1, i].Value = list[i - 1];
                    worksheet.Cells[2, i].Value = num.Next(1000);
                    worksheet.Cells[3, i].Value = num.Next(1000);
                    worksheet.Cells[4, i].Value = num.Next(1000);
                }
                workbook.SaveAs(saveFileDialog1.FileName);
                if (workbook != null)
                {
                    workbook.Close(false);
                }
                if (app != null)
                {
                    app.Quit();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GenerateFile();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
