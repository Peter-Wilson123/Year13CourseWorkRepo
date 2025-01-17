using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Year13WindowsFormsProjectQuiz
{
    public partial class UserRegister : Form
    {
        static string gender = "";
        //What I need to do
        //Be able to save account info into a file
        //Retrieve that info
        //Do that by converting object into string and then back into an objects

        static public List<Account> raccounts = new List<Account>();

        public void LoadAccountsFromFile()
        {
            string filePath = "Accounts.csv";

            // Clear the existing list before loading new data
            

            // Check if the file exists
            if (File.Exists(filePath))
            {
                raccounts.Clear();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Skip the header line if it exists
                    line = reader.ReadLine();

                    // Read each line and parse the data
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');

                        // Ensure the line has the correct number of fields
                        if (fields.Length == 5)
                        {
                            // Create a new Account object and add it to the list
                            Account account = new Account(fields[0], fields[1], fields[2], fields[3], fields[4]);
                           

                            raccounts.Add(account);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The file 'Accounts.csv' does not exist.");
            }
        }


        //any account object must be turned into a string
        public void SaveAccountIntoFile()
        {
            string filePath = "Accounts.csv";

            // Using StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the header line (optional)
                writer.WriteLine("Forename,Surname,Username,Password,Gender");

                // Write each account's details as a CSV row
                foreach (var account in raccounts)
                {
                    string line = $"{account.Forename},{account.Surname},{account.Username},{account.Password},{account.Gender}";
                    writer.WriteLine(line);
                }
            }
        }


        public UserRegister()
        {
            InitializeComponent();
            LoadAccountsFromFile();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Male.Checked)
            {
                gender = "Male";
            }
            else if (Female.Checked)
            {
                gender = "Female";
            }
            Account account = new Account(FirstNameBox.Text, SurnameBox.Text, UsernameBox.Text, PasswordBox.Text, gender);
            MessageBox.Show($"{account.Forename}");

            raccounts.Add(account);
            MessageBox.Show($"{raccounts.Count}");
            SaveAccountIntoFile();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (Female.Checked && Male.Checked)
            {
                Male.Checked = false;
                MessageBox.Show("Please only check one");
            }
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            if (Female.Checked && Male.Checked)
            {
                Female.Checked = false;
                MessageBox.Show("Please only check one");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
            FirstNameBox.Text = string.Empty;
            SurnameBox.Text = string.Empty;
            Male.Checked = false;
            Female.Checked = false;
        }
    }

    public class Account
    {
        //public List<Account> accounts = new List<Account>();

        private string forename;
        private string surname;
        private string username;
        private string password;
        private string gender;
         
        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Gender
        {

            get { return gender; }


            set { gender = value; }

        }
        public Account(string name, string lastname, string username, string password, string gender)
        {
            Forename = name;
            Surname = lastname;
            Username = username;
            Password = password;
            Gender = gender;

        }

        public Account()
        {


        }

    }
}
