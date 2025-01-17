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
    public partial class UserLogin : Form
    {


        public UserLogin()
        {
            InitializeComponent();
            UserRegister reg = new UserRegister();
            reg.LoadAccountsFromFile();
        }
        static public bool haslogged = false;

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Username or Passoword is Incorrect or the account does not exist");
            int count = 0;
            MessageBox.Show($"{UserRegister.raccounts.Count}");

            //Register.raccounts
            foreach (var account in UserRegister.raccounts)
            {
                if (textBox1.Text == account.Username && textBox2.Text == account.Password)
                {
                    MessageBox.Show("You have logged in");
                    haslogged = true;


                }
                else
                {

                }

            }
            if (haslogged == false)
            {
                MessageBox.Show("Username or Passoword is Incorrect or the account does not exist");

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
