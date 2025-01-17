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
    //
    //
    //
    //
    //
    //remember to delete poo method when handing this in :)
    //
    //
    //
    //
    //
    public partial class MainMenu : Form
    {
        public static string filename = "file.csv";
        public MainMenu()
        {
            InitializeComponent();
            customdesizing();
            //UserLogin userLogin = new UserLogin();

        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Hide();

            // MenuBar.MouseHover += new EventHandler(Panel_MouseHover);
            // MenuBar.MouseLeave += new EventHandler(Panel_MouseLeave);

        }

        private void customdesizing()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;

        }


        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (UserLogin.haslogged)
            {
                LoginCheck.Text = "Logged In: yes";
            }
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
        void Panel_MouseHover(object sender, EventArgs e)
        {
            //MenuBar.Width = 150;
            //GoToRegister.Width = 140;
        }

        void Panel_MouseLeave(object sender, EventArgs e)
        {
            //MenuBar.Width = 100;
            //GoToRegister.Width = 90;

        }



        private void GoToRegister_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;

            }
            else
            {
                panel1.Visible = true;

            }
        }

        private void MenuBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountSettings());
            HideSubMenu();
        }

        private void HideSubMenu()
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            if (panel7.Visible)
            {
                panel7.Visible = false;
            }
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            if (panel3.Visible)
            {
                panel3.Visible = false;
            }
            if (panel4.Visible)
            {
                panel4.Visible = false;
            }
        }
        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UserLogin());
            HideSubMenu();

        }

        private void Games_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;

            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
            {
                panel3.Visible = false;

            }
            else
            {
                panel3.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel4.Visible)
            {
                panel4.Visible = false;

            }
            else
            {
                panel4.Visible = true;

            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (panel7.Visible)
            {
                panel7.Visible = false;

            }
            else
            {
                panel7.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserRegister());
            HideSubMenu();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }





        private void SettingsAppearance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubMenus());
            HideSubMenu();
        }


        private void GameMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GameMenu());
            HideSubMenu();
        }
        static bool poo()
        {
            return true;
        }

        private void LoginCheck_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}



