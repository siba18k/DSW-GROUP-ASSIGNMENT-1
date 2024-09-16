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
    public partial class Calender : System.Windows.Forms.UserControl
    {
        int month, year;
        public Calender()
        {
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year;
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 0;i < dayoftheweek;i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 0; i < days;i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

        
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year;

        
            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 0; i < days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();


            month--;
            if (month == 0)
            {
                month = 12;
                year++;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year;


            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 0; i < days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void displayDays()
         {

          } 
    }
}
