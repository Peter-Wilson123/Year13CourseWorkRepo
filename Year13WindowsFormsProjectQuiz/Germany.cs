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
    public partial class Germany : Form
    {
        public Germany()
        {
            InitializeComponent();

AllNations world = new AllNations();
            world.Germany.Millitary = 0;

            MessageBox.Show(world.Germany.Millitary.ToString());
            world.Germany.Millitary = 2;
        }

        private void Germany_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

            WarPopUp alert = new WarPopUp();
            alert.ShowDialog();
            //Todo for combat
            //create user control for invading a piece of land with cool ui and a yes or no button as well as difficulty
            //If yes it brings you to a pixel art battlefield
            //There will likely be three parts
        }
    }
}
