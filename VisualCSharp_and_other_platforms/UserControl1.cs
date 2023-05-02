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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.BackColor = Color.FromArgb(140, Exit_btn.BackColor);
            Main_menu_btn.UseVisualStyleBackColor = false;
            Main_menu_btn.BackColor = Color.FromArgb(140, Main_menu_btn.BackColor);
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_menu_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
