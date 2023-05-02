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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(140,button1.BackColor);
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.FromArgb(140, button2.BackColor);
            button3.UseVisualStyleBackColor = false;
            button3.BackColor = Color.FromArgb(140, button3.BackColor);
            Exit_app_btn.UseVisualStyleBackColor = false;
            Exit_app_btn.BackColor = Color.FromArgb(210, Exit_app_btn.BackColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            form1.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            form1.Show();
            Close();
        }

        private void Exit_app_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
