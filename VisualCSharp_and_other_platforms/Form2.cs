using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCSharp_and_other_platforms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(140, button1.BackColor);
            excel_grid_btn.UseVisualStyleBackColor = false;
            excel_grid_btn.BackColor = Color.FromArgb(140, excel_grid_btn.BackColor);
            Excel_draw_btn.UseVisualStyleBackColor = false;
            Excel_draw_btn.BackColor = Color.FromArgb(140, Excel_draw_btn.BackColor);
        }

        private void ExcelForm1_Load(object sender, EventArgs e)
        {
            UserControl1 userControl = new UserControl1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.FormBorderStyle = FormBorderStyle.FixedSingle;
            calculator.MinimizeBox = false;
            calculator.MaximizeBox = false;
            calculator.Show();
            Close();
        }

        private void excel_grid_btn_Click(object sender, EventArgs e)
        {
            Grid grid = new Grid();
            grid.FormBorderStyle = FormBorderStyle.FixedSingle;
            grid.MinimizeBox = false;
            grid.MaximizeBox = false;
            grid.Show();
            Close();
        }

        private void Excel_draw_btn_Click(object sender, EventArgs e)
        {
            Charts draw = new Charts();
            draw.FormBorderStyle = FormBorderStyle.FixedSingle;
            draw.MaximizeBox = false;
            draw.MinimizeBox = false;
            draw.Show();
            Close();
        }
    }
}
