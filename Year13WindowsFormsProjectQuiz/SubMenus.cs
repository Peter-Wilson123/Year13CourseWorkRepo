using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year13WindowsFormsProjectQuiz
{
    public partial class SubMenus : Form
    {
        public SubMenus()
        {
            InitializeComponent();
        }

        private void SubMenus_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar1.Value, hScrollBar1.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            double val;

            val = Convert.ToDouble((100.0 - hScrollBar2.Value) / 100.0);
            // MessageBox.Show($"{val}");

            this.Opacity = val;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
