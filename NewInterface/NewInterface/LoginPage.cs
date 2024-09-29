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
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                // Specify the file path where you want to save the data
                string filePath = @"C:\Users\MPHO\Desktop\DSW-GROUP-ASSIGNMENT-1-main\NewInterface\UserAccount.txt";

                // Save username and password to the file
                using (StreamWriter writer = new StreamWriter(filePath, true)) // 'true' to append data
                {
                    writer.WriteLine("Username: " + username);
                    writer.WriteLine("Password: " + password);
                    writer.WriteLine(); // Add a blank line for readability
                }

                // Hide the login page and show the main form
                LoginPage loginPage = new LoginPage();
                MainForm mainForm = new MainForm();
                loginPage.Hide();
                mainForm.Show();

                
            }
            
            catch (Exception ex)
            {
               
            }
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
    }
}
