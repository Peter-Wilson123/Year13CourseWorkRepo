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


    public partial class WorldMap : Form
    {
        AllNations nations = new AllNations();

        public WorldMap()
        {

            InitializeComponent();
            AllNations nations = new AllNations();
            CountryDropDownMenu.Visible = false;
            OpenChildForm(new WorldMapChildForm());

            DisplayCountryStats();
            //Nation France = new Nation("easy", "France");



        }

        private void DisplayCountryStats()
        {
            StatsResults.Text = Convert.ToString(nations.France.Money) + "," + Convert.ToString(nations.France.Research) + "," + Convert.ToString(nations.France.Millitary);
        }
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {

            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Countrys_Click(object sender, EventArgs e)
        {
            if (CountryDropDownMenu.Visible == false)
            {
                CountryDropDownMenu.Visible = true;
            }
            else
            {
                CountryDropDownMenu.Visible = false;

            }

        }

        private void GoToGermany_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Germany());

        }

        private void GoToWorldMap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorldMapChildForm());

        }

        private void GoToFrance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new YourCountry());

        }
    }
    //On game start it creates countrys which contain a list of land objects

    public class AllNations
    {

        //Idea for class is to create all the objects here making it the only thing you need to call in the other form
        //It needs to be able to 
        public Nation France = new Nation("easy", "France");
        public Nation England = new Nation("hard", "England");
        public Nation Spain = new Nation("medium", "Spain");
        public Nation Germany = new Nation("medium", "Germany");
        public Nation Italy = new Nation("easy", "Italy");

        private void CountrySetup()
        {
            Land nf = new Land(2, 2, 2);
            Land sf = new Land(2, 2, 2);
            Land cf = new Land(2, 2, 2);


            France.NationLands.Add(nf);
            France.NationLands.Add(sf);
            France.NationLands.Add(cf);
            France.Calculate();


            Land ne = new Land(2, 2, 2);
            Land se = new Land(2, 2, 2);
            Land ce = new Land(2, 2, 2);

            England.NationLands.Add(ne);
            England.NationLands.Add(se);
            England.NationLands.Add(ce);
            England.Calculate();

            Land wg = new Land(2, 2, 2);
            Land sg = new Land(2, 2, 2);
            Land cg = new Land(2, 2, 2);

            Germany.NationLands.Add(wg);
            Germany.NationLands.Add(sg);
            Germany.NationLands.Add(cg);
            Germany.Calculate();

        }
        public AllNations()
        {
            try
            {
                if (England.NationLands.Count == 0)
                {
                    CountrySetup();
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("This is being run");

                CountrySetup();

                throw;
            }
        }
    }

    public class Nation
    {
        //Important
        private string difficulty;
        private string name;
        private double money;
        private double research;
        private double millitary;

        public List<Land> NationLands = new List<Land>();


        public double Money
        {
            get {  return money; } 
            set { money = value; }
        }
        public double Research
        {
            get { return research; }
            set { research = value; }
        }
        public double Millitary
        {
            get { return millitary; }
            set { millitary = value; }
        }
        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Nation(string difficulty, string name)
        {
            Difficulty = difficulty;
            Name = name;
        }
        public void Calculate()
        {
            foreach (var land in NationLands)
            {
                Money += land.Initialmoney;
                Research += land.Initialresearch;
                Millitary += land.Initialmillitary;
            }
        }
        
    }

    public class Land
    {
        private double initialmoney;
        private double initialresearch;
        private double initialmillitary;

        public double Initialmoney
        {
            get { return initialmoney; }
            set {  initialmoney = value; }
        }
        public double Initialresearch
        {
            get { return initialresearch; }
            set { initialresearch = value; }
        }
        public double Initialmillitary
        {
            get { return initialmillitary; }
            set { initialmillitary = value; }
        }

        public Land(double initialmoney, double initialresearch, double initialmillitary)
        {
            Initialmoney = initialmoney;
            Initialresearch = initialresearch;
            Initialmillitary = initialmillitary;

        }

    }
}
