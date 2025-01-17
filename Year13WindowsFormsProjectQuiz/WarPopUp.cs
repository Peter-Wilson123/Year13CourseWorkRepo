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
    public partial class WarPopUp : Form
    {
        public WarPopUp()
        {
            InitializeComponent();
        }

        private void WarPopUp_Load(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            GameCombat battle = new GameCombat();
            this.Hide();
            battle.Show();
        }
    }
}
