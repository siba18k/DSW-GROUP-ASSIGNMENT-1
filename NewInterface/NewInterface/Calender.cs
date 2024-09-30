using System;
using System.Globalization;
using System.Windows.Forms;

namespace NewInterface
{
    public partial class Calender : UserControl
    {
        private int month, year;

        public Calender()
        {
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DisplayCalendar(month, year); // Display the current month
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            month--; // Move to the previous month
            if (month < 1) // If month is less than January
            {
                month = 12; // Reset to December
                year--;     // Move to the previous year
            }
            DisplayCalendar(month, year); // Display the updated month
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            month++; // Move to the next month
            if (month > 12) // If month is greater than December
            {
                month = 1;   // Reset to January
                year++;      // Move to the next year
            }
            DisplayCalendar(month, year); // Display the updated month
        }

        private void DisplayCalendar(int month, int year)
        {
            dayContainer.Controls.Clear(); // Clear previous controls
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year; // Display month and year

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)startOfTheMonth.DayOfWeek; // Get the day of the week (0 = Sunday, 6 = Saturday)

            // Fill in the blanks for days before the first of the month
            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            // Add the actual days of the month
            for (int day = 1; day <= daysInMonth; day++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(day); // Assuming the days() method sets the day on the UserControl
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint logic if necessary
        }
    }
}