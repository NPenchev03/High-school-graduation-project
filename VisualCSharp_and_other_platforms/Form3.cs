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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Generate_form_btn.UseVisualStyleBackColor = false;
            Generate_form_btn.BackColor = Color.FromArgb(140, Generate_form_btn.BackColor);
            Text_form_btn.UseVisualStyleBackColor = false;
            Text_form_btn.BackColor = Color.FromArgb(140, Text_form_btn.BackColor);
        }

        private void Text_form_btn_Click(object sender, EventArgs e)
        {
            Text_Editor word = new Text_Editor();
            word.Show();
            Close();
        }

        private void Generate_form_btn_Click(object sender, EventArgs e)
        {
            Document_Generation word = new Document_Generation();
            word.Show();
            Close();
        }
    }
}
