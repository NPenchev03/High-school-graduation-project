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
using Excel = Microsoft.Office.Interop.Excel;

namespace VisualCSharp_and_other_platforms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void CollectGarbage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void ExcelCalculator_Load(object sender, EventArgs e)
        {
            equals_btn.UseVisualStyleBackColor = false;
            equals_btn.BackColor = Color.FromArgb(140, equals_btn.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            object input, result;
            input = textBox1.Text;
            result = app.Evaluate(input);
            textBox2.Text = result.ToString();
            if (result.ToString() == "-2146826259")
            {
                textBox2.Text = "Error. Please try again.";
            }
            app.Quit();
            CollectGarbage();
            Marshal.ReleaseComObject(app);
        }
    }
}
