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
    public partial class EventDisplayForm : Form
    {
        private Dictionary<DateTime, List<string>> events;

        public EventDisplayForm()
        {
            InitializeComponent();
            events = new Dictionary<DateTime, List<string>>();
            btnLoadEvents.Click += new EventHandler(btnLoadEvents_Click);
            btnExitList.Click += new EventHandler(btnExitList_Click);


            listViewEvents.View = View.Details; 
            listViewEvents.Columns.Add("Date", 100); 
            listViewEvents.Columns.Add("Event", 200); 
            listViewEvents.GridLines = true; 
            listViewEvents.FullRowSelect = true;
        }

        private void btnLoadEvents_Click(object sender, EventArgs e)
        {
            LoadEvents();
            DisplayEvents();
        }

        public void LoadEvents()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "events.txt");
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { " - " }, StringSplitOptions.None);
                    if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        string description = parts[1];

                        if (!events.ContainsKey(date))
                        {
                            events[date] = new List<string>();
                        }

                        if (!events[date].Contains(description))
                        {
                            events[date].Add(description); 
                        }
                    }
                }
            }
        }

        private void DisplayEvents()
        {
            listViewEvents.Items.Clear(); 

            foreach (var eventEntry in events)
            {
                string eventDate = eventEntry.Key.ToShortDateString(); 
                foreach (var eventDetail in eventEntry.Value)
                {
                    ListViewItem item = new ListViewItem(eventDate);
                    item.SubItems.Add(eventDetail);
                    listViewEvents.Items.Add(item); 

                    
                    SendCustomNotification(eventDate, eventDetail);
                }
            }

            if (listViewEvents.Items.Count == 0)
            {
                MessageBox.Show("No events available.", "Events");
            }
        }
        private void SendCustomNotification(string eventDate, string eventDetail)
        {
            
            Form notificationForm = new Form();
            notificationForm.FormBorderStyle = FormBorderStyle.None;
            notificationForm.StartPosition = FormStartPosition.Manual;
            notificationForm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 300, 50); 
            notificationForm.Size = new Size(250, 100); 
            notificationForm.BackColor = Color.LightYellow; 

            
            Label label = new Label
            {
                Text = $"Event Reminder: {eventDate}\n{eventDetail}",
                Dock = DockStyle.Fill, 
                TextAlign = ContentAlignment.MiddleCenter 
            };

            notificationForm.Controls.Add(label); 

            
            notificationForm.Show();
            Task.Delay(3000).ContinueWith(t =>
            {
                notificationForm.Invoke((MethodInvoker)(() => notificationForm.Close())); 
            });
        }


        private void listViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EventDisplayForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExitList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
