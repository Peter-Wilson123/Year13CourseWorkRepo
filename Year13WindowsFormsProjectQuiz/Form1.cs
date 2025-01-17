namespace Year13WindowsFormsProjectQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void LoadingBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadingBar.Width += 50;
            if (LoadingBar.Width > 800)
            {
                LoadingBar.Width = 800;
                timer1.Stop();
                Form1 form = new Form1();
                this.Hide();

                MainMenu menu = new MainMenu();
                menu.Show();
            }
        }
    }
}
