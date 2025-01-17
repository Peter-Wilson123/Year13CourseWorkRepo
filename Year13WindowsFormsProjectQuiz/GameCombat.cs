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
    public partial class GameCombat : Form
    {
        static bool loopquestions = true;
        static bool NewQuestions = true;
        static int questionNum = 0;
        static int Modifier = 40;
        static int successfulAttacks = 0;

        static string[,] GermanyQuestions = new string[,] {
    { "Which river forms part of the border between Germany and Austria?", "Rhine", "Danube", "Inn", "Isar", "Inn" },
    { "The Romantic Road is a famous tourist route in southern Germany. Where does it start?", "Würzburg", "Füssen", "Augsburg", "Rothenburg ob der Tauber", "Würzburg" },
    { "Which southern German lake is sometimes called the 'Swabian Sea'?", "Lake Constance", "Lake Chiemsee", "Lake Ammersee", "Lake Tegernsee", "Lake Constance" },
    { "What is the largest city in Baden-Württemberg?", "Freiburg", "Stuttgart", "Karlsruhe", "Heidelberg", "Stuttgart" },
    { "The Danube River flows through which major city in Bavaria?", "Munich", "Regensburg", "Passau", "Ingolstadt", "Regensburg" },
    { "What is the name of the volcanic region in Baden-Württemberg known for its hilly landscape?", "Swabian Jura", "Franconian Forest", "Allgäu Alps", "Black Forest", "Swabian Jura" },
    { "Which major river flows through the city of Stuttgart?", "Danube", "Neckar", "Rhine", "Isar", "Neckar" },
    { "The Berchtesgaden National Park is located in which mountain range?", "Harz Mountains", "Bavarian Alps", "Swabian Jura", "Black Forest", "Bavarian Alps" },
    { "What is the name of the scenic gorge in the Black Forest famous for its waterfalls?", "Ravennaschlucht", "Partnach Gorge", "Höllental", "Wutach Gorge", "Wutach Gorge" },
    { "The Allgäu region is located primarily in which German state?", "Baden-Württemberg", "Bavaria", "Hesse", "Saxony", "Bavaria" },
    { "Which southern German city is closest to the border with Liechtenstein?", "Kempten", "Friedrichshafen", "Lindau", "Memmingen", "Lindau" },
    { "The city of Passau is famously located at the confluence of how many rivers?", "Two", "Three", "Four", "Five", "Three" },
    { "The Swabian Alb is a mountain range located primarily in which state?", "Bavaria", "Baden-Württemberg", "Hesse", "Thuringia", "Baden-Württemberg" },
    { "Which southern German state is home to the Franconian Lake District?", "Bavaria", "Baden-Württemberg", "Saarland", "Rhineland-Palatinate", "Bavaria" },
    { "Which mountain peak is known for its cable car and panoramic views near Garmisch-Partenkirchen?", "Watzmann", "Zugspitze", "Nebelhorn", "Kampenwand", "Zugspitze" },
    { "The Rhine Falls, Europe's largest waterfall, is located near which southern German city?", "Konstanz", "Friedrichshafen", "Basel", "Schaffhausen", "Konstanz" },
    { "Which Bavarian city is often called the 'City of Three Rivers'?", "Regensburg", "Passau", "Augsburg", "Landshut", "Passau" },
    { "What is the name of the scenic road that runs through the Black Forest?", "Schwarzwaldhochstraße", "Bodenseestraße", "Romantische Straße", "Königsstraße", "Schwarzwaldhochstraße" },
    { "The German Wine Route runs through which region of southern Germany?", "Bavarian Alps", "Palatinate", "Allgäu", "Black Forest", "Palatinate" },
    { "Which lake lies entirely within Bavaria and is often called the 'Bavarian Sea'?", "Lake Ammersee", "Lake Chiemsee", "Lake Tegernsee", "Lake Starnberg", "Lake Chiemsee" },
    { "The Kaiserstuhl region in southern Germany is famous for what geographic feature?", "Volcanic hills", "Alpine glaciers", "Sand dunes", "Salt mines", "Volcanic hills" },
    { "The city of Lindau is located on an island in which body of water?", "Lake Ammersee", "Lake Starnberg", "Lake Constance", "Lake Tegernsee", "Lake Constance" },
    { "What is the name of the forested mountain range in southwestern Germany?", "Black Forest", "Bavarian Alps", "Taunus", "Ore Mountains", "Black Forest" },
    { "The city of Konstanz is located on the shores of which part of Lake Constance?", "Upper Lake", "Lower Lake", "Main Basin", "Rhine Delta", "Lower Lake" },
    { "Which southern German city is closest to the Zugspitze?", "Garmisch-Partenkirchen", "Innsbruck", "Füssen", "Mittenwald", "Garmisch-Partenkirchen" },
    { "The Franconian Switzerland region is known for its distinctive landscape of what?", "Caves and cliffs", "Volcanoes", "Sandstone formations", "Lakes and wetlands", "Caves and cliffs" },
    { "The Bavarian Forest is part of which larger European mountain range?", "Bohemian Massif", "Carpathians", "Harz", "Alps", "Bohemian Massif" },
    { "The Danube flows out of southern Germany into which country?", "France", "Austria", "Switzerland", "Italy", "Austria" }
};

        Random rnd = new Random();
        public GameCombat()
        {
            InitializeComponent();
            ModifierDisplay.Text = "Chance of Success: " + Modifier.ToString() + "%";


            DisplayQuestions();


        }

        private void DisplayQuestions()
        {
            if (NewQuestions)
            {
                questionNum = rnd.Next(GermanyQuestions.GetLength(0));
                Question.Text = GermanyQuestions[questionNum, 0];
                Question1.Text = GermanyQuestions[questionNum, 1];
                Question2.Text = GermanyQuestions[questionNum, 2];
                Question3.Text = GermanyQuestions[questionNum, 3];
                Question4.Text = GermanyQuestions[questionNum, 4];
                NewQuestions = false;
            }
            else
            {
            }
        }


        private void CalculateModifier()
        {
            Modifier = Modifier + rnd.Next(5, 10);
            ModifierDisplay.Text = "Chance of Success: " + Modifier.ToString() + "%";
        }
        private void CalculateincorrectModifier()
        {
            Modifier = Modifier - rnd.Next(2, 5);
            ModifierDisplay.Text = "Chance of Success: " + Modifier.ToString() + "%";
        }
        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Question1_Click(object sender, EventArgs e)
        {
            if (Question1.Text == GermanyQuestions[questionNum, 5])
            {
                Question.Text = "CORRECT!";
                CalculateModifier();
            }
            else
            {
                Question.Text = "INCORRECT!";
                CalculateincorrectModifier();

            }
            NewQuestions = true;
            DisplayQuestions();
        }

        private void Question2_Click(object sender, EventArgs e)
        {
            if (Question2.Text == GermanyQuestions[questionNum, 5])
            {
                Question.Text = "CORRECT!";
                CalculateModifier();

            }
            else
            {
                Question.Text = "INCORRECT!";
                CalculateincorrectModifier();


            }
            NewQuestions = true;
            DisplayQuestions();

        }

        private void Question3_Click(object sender, EventArgs e)
        {
            if (Question3.Text == GermanyQuestions[questionNum, 5])
            {
                Question.Text = "CORRECT!";
                CalculateModifier();

            }
            else
            {
                Question.Text = "INCORRECT!";
                CalculateincorrectModifier();


            }
            NewQuestions = true;
            DisplayQuestions();

        }

        private void Question4_Click(object sender, EventArgs e)
        {
            if (Question4.Text == GermanyQuestions[questionNum, 5])
            {
                Question.Text = "CORRECT!";
                CalculateModifier();

            }
            else
            {
                Question.Text = "INCORRECT!";
                CalculateincorrectModifier();


            }
            NewQuestions = true;
            DisplayQuestions();

        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            if (rnd.Next(1, 100) <= Modifier)
            {
                successfulAttacks += 1;
                AttacksDisplay.Text = "Attacks " + successfulAttacks + "/3";
                Modifier = 40;
                ModifierDisplay.Text = "Chance of Success: " + Modifier.ToString() + "%";

            }
            else if(successfulAttacks >= 1)
            {
                successfulAttacks--;
                AttacksDisplay.Text = "Attacks " + successfulAttacks + "/3";
                Modifier = 40;
                ModifierDisplay.Text = "Chance of Success: " + Modifier.ToString() + "%";

            }
            else
            {
                this.Hide();
            }
        }

        private void RetreatButton_Click(object sender, EventArgs e)
        {
            if (successfulAttacks >= 1)
            {
            successfulAttacks -= 1;
                Modifier = 60;
                AttacksDisplay.Text = "Attacks " + successfulAttacks + "/3";
                ModifierDisplay.Text = "Chance of Success: " + Modifier.ToString() + "%";



            }
            else
            {
                this.Hide();
            }

        }
    }
}
