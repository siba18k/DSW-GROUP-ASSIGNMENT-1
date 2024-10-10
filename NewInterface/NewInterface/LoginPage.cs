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

namespace NewInterface
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            // Set the login button to be triggered when the Enter key is pressed
            this.AcceptButton = button1;
        }

        private void pnlLine1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            try
            {
                // Get the path to the user's Desktop where the file is saved
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderName = "DSW-GROUP-ASSIGNMENT-1-main";
                string fileName = "UserAccount.txt";

                // Combine the folder path with the file name
                string filePath = Path.Combine(desktopPath, folderName, fileName);

                // Read the file and check if the entered username and password match
                if (File.Exists(filePath))
                {
                    // Read all lines from the file
                    string[] lines = File.ReadAllLines(filePath);

                    string savedUsername = null;
                    string savedPassword = null;
                    bool credentialsMatch = false;

                    // Loop through the lines to find matching username and password
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("Username:"))
                        {
                            savedUsername = lines[i].Split(':')[1].Trim(); // Get the username
                        }
                        else if (lines[i].StartsWith("Password:"))
                        {
                            savedPassword = lines[i].Split(':')[1].Trim(); // Get the password

                            // Now that we have both username and password, we can check if they match
                            if (enteredUsername == savedUsername && enteredPassword == savedPassword)
                            {
                                credentialsMatch = true;
                                break; // Stop searching once we find a match
                            }
                        }
                    }

                    if (credentialsMatch)
                    {
                        // Open MainForm if the login is successful
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide(); // Hide the LoginPage
                    }
                    else
                    {
                        // Show error if the credentials don't match
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                else
                {
                    MessageBox.Show("User account file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            try
            {
                // Get the path to the user's Desktop where the file is saved
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderName = "DSW-GROUP-ASSIGNMENT-1-main";
                string fileName = "UserAccount.txt";

                // Combine the folder path with the file name
                string filePath = Path.Combine(desktopPath, folderName, fileName);

                // Read the file and check if the entered username and password match
                if (File.Exists(filePath))
                {
                    // Read all lines from the file
                    string[] lines = File.ReadAllLines(filePath);

                    string savedUsername = null;
                    string savedPassword = null;
                    bool credentialsMatch = false;
                    List<string> updatedLines = new List<string>(); // To store updated lines

                    // Loop through the lines to find matching username and password
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("Username:"))
                        {
                            savedUsername = lines[i].Split(':')[1].Trim(); // Get the username
                        }
                        else if (lines[i].StartsWith("Password:"))
                        {
                            savedPassword = lines[i].Split(':')[1].Trim(); // Get the password

                            // Check if entered username and password match the saved ones
                            if (enteredUsername == savedUsername && enteredPassword == savedPassword)
                            {
                                credentialsMatch = true;
                                // Skip adding these lines (username and password) to updatedLines, effectively deleting them
                            }
                            else
                            {
                                // Add the username and password to updatedLines if they don't match the entered credentials
                                updatedLines.Add("Username: " + savedUsername);
                                updatedLines.Add("Password: " + savedPassword);
                            }
                        }
                    }

                    if (credentialsMatch)
                    {
                        // Write the updated lines back to the file (deleting the matched credentials)
                        File.WriteAllLines(filePath, updatedLines);

                        MessageBox.Show("Username and password deleted successfully.");
                    }
                    else
                    {
                        // Show error if the credentials don't match
                        MessageBox.Show("Invalid username or password. Deletion failed.");
                    }
                }
                else
                {
                    MessageBox.Show("User account file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear the username and password text boxes
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
