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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void PowerPointForm1_Load(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(140, button1.BackColor);
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.FromArgb(140, button2.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation_Generation form = new Presentation_Generation();
            form.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presentation_Export form = new Presentation_Export();
            form.Show();
            Close();
        }
    }
}
