using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewInterface
{
    public partial class SignupPage : Form
    {

        public SignupPage()
        {
            InitializeComponent();

            // Set the login button to be triggered when the Enter key is pressed
            this.AcceptButton = button1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void pbUsername_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if either username or password is empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter Username and Password.");
                return; // Stop execution if validation fails
            }

            try
            {
                // Get the path to the user's Desktop
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderName = "DSW-GROUP-ASSIGNMENT-1-main";
                string fileName = "UserAccount.txt";

                // Create a folder on the desktop (if it doesn't exist already)
                string folderPath = Path.Combine(desktopPath, folderName);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Combine the folder path with the file name
                string filePath = Path.Combine(folderPath, fileName);

                // Check if the username already exists
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    string savedUsername = null;
                    string savedPassword = null;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("Username:"))
                        {
                            savedUsername = lines[i].Split(':')[1].Trim();
                        }
                        else if (lines[i].StartsWith("Password:"))
                        {
                            savedPassword = lines[i].Split(':')[1].Trim();

                            // Check if the username already exists with any password
                            if (username == savedUsername)
                            {
                                if (password != savedPassword)
                                {
                                    MessageBox.Show("Username taken.");
                                }
                                else
                                {
                                    MessageBox.Show("Username taken.");
                                }
                                return; // Stop the process, don't save the new username and password
                            }
                        }
                    }
                }

                // If no conflicts are found, save the username and password to the file
                using (StreamWriter writer = new StreamWriter(filePath, true)) // 'true' to append data
                {
                    writer.WriteLine("Username: " + username);
                    writer.WriteLine("Password: " + password);
                    writer.WriteLine(); // Add a blank line for readability
                }

                // Open LoginPage form instead of MainForm
                LoginPage loginPage = new LoginPage();
                loginPage.Show();

                // Hide the current form (instead of closing it)
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open LoginPage form
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            // Optionally hide the current form (if applicable)
            this.Hide();  // 'this' refers to the current form (e.g., SignupPage)
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Clear the username and password text boxes
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void pnlLine1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
