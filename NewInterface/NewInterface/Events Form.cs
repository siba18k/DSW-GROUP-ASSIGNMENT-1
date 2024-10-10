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


namespace NewInterface
{
    public partial class EventForm : Form
    {
        private Dictionary<DateTime, List<string>> events;

        public EventForm()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void LoadEvents()
        {
            events = new Dictionary<DateTime, List<string>>();

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "events.txt");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { " - " }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        // Declare description here
                        string description = parts[1];

                        // Use TryParse to validate the date
                        if (DateTime.TryParse(parts[0], out DateTime date))
                        {
                            if (!events.ContainsKey(date))
                            {
                                events[date] = new List<string>();
                            }
                            events[date].Add(description);
                        }
                        else
                        {
                            // Inform the user about the incorrect date format
                            MessageBox.Show($"Invalid date format in events file: {parts[0]}", "Error");
                        }
                    }
                }
            }

            monthCalendar.DateSelected += MonthCalendar1_DateSelected;
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            if (events.ContainsKey(selectedDate))
            {
                string eventDetails = string.Join(Environment.NewLine, events[selectedDate]);
                MessageBox.Show(eventDetails, "Events on " + selectedDate.ToShortDateString());
            }
            else
            {
                MessageBox.Show("No events on this day.", "Events on " + selectedDate.ToShortDateString());
            }
        }

        private void Eventsavebtn_Click(object sender, EventArgs e)
        {
            string eventDescription = Addeventtxt.Text;
            DateTime eventDate = dateTimePicker.Value;
            string eventDetails = $"{eventDate.ToShortDateString()} - {eventDescription}";

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "events.txt");
            File.AppendAllText(filePath, eventDetails + Environment.NewLine);

            // Update events dictionary
            if (!events.ContainsKey(eventDate))
            {
                events[eventDate] = new List<string>();
            }
            events[eventDate].Add(eventDescription);

            MessageBox.Show("Event saved successfully!");
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // You can implement any actions needed when the month calendar changes here
        }

        private void Addeventtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
