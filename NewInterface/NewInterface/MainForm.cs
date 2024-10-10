using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInterface
{
    public partial class MainForm : Form
    {
        bool sidebarExpand;
        bool homeCollapse;
        public MainForm()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapse)
            {
                homeContainer.Height += 10;
                if (homeContainer.Height == homeContainer.MaximumSize.Height)
                {
                    homeCollapse = false;
                    homeTimer.Stop();
                }
            }
            else
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    homeCollapse = true;
                    homeTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            using (var optionsForm = new ScheduleOptionsForm())
            {
                DialogResult result = optionsForm.ShowDialog(this);

                // Check the result to determine the user's choice
                if (result == DialogResult.Yes)
                {
                    // Code for "Add to Schedule" action
                }
                else if (result == DialogResult.No)
                {
                    // Code for "View Schedule" action
                }
            }
        }


        private void btnCalender_Click(object sender, EventArgs e)
        {

        }

        private void calender1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            SignupPage signupPage = new SignupPage();

            
            signupPage.Show();

            
            this.Hide();
        }

        

    }
}
