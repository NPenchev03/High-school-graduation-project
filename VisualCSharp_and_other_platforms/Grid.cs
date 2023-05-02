using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace VisualCSharp_and_other_platforms
{
    public partial class Grid : Form
    {
        int counterColumn;
        string file = "";
        Excel._Worksheet worksheet;
        Excel.Workbook workbook;
        Excel.Application app;
        Excel.Range range;
        string filePath;
        public Grid()
        {
            InitializeComponent();
        }

        private void ExcelGrid_Load(object sender, EventArgs e)
        {
            Exit_app_btn.UseVisualStyleBackColor = false;
            Exit_app_btn.BackColor = Color.FromArgb(140, Exit_app_btn.BackColor);
            Main_menu_btn.UseVisualStyleBackColor = false;
            Main_menu_btn.BackColor = Color.FromArgb(140, Main_menu_btn.BackColor);
            file_dialog_btn.UseVisualStyleBackColor = false;
            file_dialog_btn.BackColor = Color.FromArgb(140, file_dialog_btn.BackColor);
            create_file_btn.UseVisualStyleBackColor = false;
            create_file_btn.BackColor = Color.FromArgb(140, create_file_btn.BackColor);
            Reset_grid_btn.UseVisualStyleBackColor = false;
            Reset_grid_btn.BackColor = Color.FromArgb(140, Reset_grid_btn.BackColor);
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(140, button1.BackColor);
            save_changes_btn.UseVisualStyleBackColor = false;
            save_changes_btn.BackColor = Color.FromArgb(140, save_changes_btn.BackColor);
        }
        DataTable dt = new DataTable();

        private void SaveChanges() 
        {

        }
        private void save_changes_btn_Click_1(object sender, EventArgs e)
        {
            app = new Excel.Application();
            workbook = app.Workbooks.Add();
            SaveExcelChanges(file, dataGridView1, app, workbook);
            if (workbook != null)
            {
                workbook.Close(false);
            }
            if (app != null)
            {
                app.Quit();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void SaveExcelChanges(string fileName, DataGridView dataGridView, Excel.Application xlApp, Excel.Workbook workbook)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = "NewCustomExcelFile",
                Filter = "Excel File|*.xlsx",
                Title = "Create an Excel File",
                InitialDirectory = @"C:\",
                DefaultExt = "xlsx",
                CheckPathExists = true,
                FilterIndex = 1,
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                if (dataGridView.Rows.Count > 0)
                {
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            try
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }
                            catch (NullReferenceException)
                            {

                                continue;
                            }
                        }
                    }
                }
                workbook.SaveAs(saveFileDialog1.FileName);
                ResetGrid();
            }

            Marshal.ReleaseComObject(worksheet);
        }

        private void CreateFile()
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
                worksheet = app.Sheets[1];
                worksheet.Cells[1, 1].Value2 = "";
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
            else
            {
                return;
            }
        }
        private void create_file_btn_Click_1(object sender, EventArgs e)
        {
            CreateFile();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void OpenFile()
        {
            var filePath = string.Empty;
            var fileContent = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.RestoreDirectory = true;

            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            DataRow row;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                file = openFileDialog.FileName;
                filePath = file;

                app = new Excel.Application();

                workbook = app.Workbooks.Open(file);

                worksheet = workbook.Sheets[1];

                range = worksheet.UsedRange;
                try
                {
                    int rowCount = range.Rows.Count;

                    int colCount = range.Columns.Count;

                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            {
                                dt.Columns.Add(range.Cells[i, j].Value2.ToString());
                            }
                            else
                            {
                                try
                                {
                                    dt.Columns.Add("", typeof(String));
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                        }
                        break;
                    }
                    int rowCounter;
                    for (int i = 2; i <= rowCount; i++)
                    {
                        row = dt.NewRow();
                        rowCounter = 0;
                        for (int j = 1; j <= colCount; j++)
                        {

                            if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            {
                                try
                                {
                                    row[rowCounter] = range.Cells[i, j].Value2.ToString();
                                }
                                catch (TargetInvocationException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                try
                                {
                                    row[i] = "";
                                }
                                catch (TargetInvocationException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                catch (Exception ex)
                                {

                                }
                            }

                            rowCounter++;
                        }
                        dt.Rows.Add(row);
                    }

                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    counterColumn = dataGridView1.Columns.Count;
                    file_dialog_btn.Enabled = false;
                    add_column_btn.Enabled = true;
                    save_changes_btn.Enabled = true;
                    button1.Enabled = true;
                    Reset_grid_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Cannot perform runtime binding on a null reference")
                    {
                        MessageBox.Show("Please use a excel file with data present - Моля използвайте excel файл, в който се съдържат данни");
                    }
                    else
                    {
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
                    }
                }
            }
        }
        private void file_dialog_btn_Click_1(object sender, EventArgs e)
        {
            OpenFile();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count != 0)
            {
                dataGridView1.Columns.RemoveAt(counterColumn - 1);
                counterColumn--;
            }
        }

        private void add_column_btn_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add($"Column{counterColumn + 1}", $"Column{counterColumn + 1}");
            counterColumn++;
        }

        private void Exit_app_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Reset_grid_btn_Click(object sender, EventArgs e)
        {
            ResetGrid();
        }

        public void ResetGrid()
        {
            dt.Reset();
            dt = new DataTable();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            Reset_grid_btn.Enabled = false;
            add_column_btn.Enabled = false;
            save_changes_btn.Enabled = false;
            button1.Enabled = false;
            file_dialog_btn.Enabled = true;
        }
        private void Main_menu_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
