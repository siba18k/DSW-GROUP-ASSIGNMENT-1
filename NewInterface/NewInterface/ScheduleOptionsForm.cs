using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInterface
{
    public partial class ScheduleOptionsForm : Form
    {
        public ScheduleOptionsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent; // Center the popup
        }

        private void ScheduleOptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            // Indicate that the user wants to add to schedule
            this.DialogResult = DialogResult.Yes;

            // Close the ScheduleOptionsForm
            this.Close();

            // Create an instance of the EventForm and display it
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {

            this.Close();
            EventDisplayForm eventDisplayForm = new EventDisplayForm();
            eventDisplayForm.LoadEvents();
            eventDisplayForm.ShowDialog(); 

        }
        private void btnScheduleOptions_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
