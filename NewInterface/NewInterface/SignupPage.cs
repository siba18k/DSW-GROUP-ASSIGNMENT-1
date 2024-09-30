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

                // Save username and password to the file
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
    }
}
