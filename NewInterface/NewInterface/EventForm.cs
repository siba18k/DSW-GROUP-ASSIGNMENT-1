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
    public partial class EventForm : Form
    {
        private string filePath = @"C:\Users\MPHO\Desktop\DSW-GROUP-ASSIGNMENT-1-main\NewInterface\eventData.txt";
        public EventForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        // Reading date and text from file
                        string savedDate = reader.ReadLine();
                        string savedText = reader.ReadLine();

                        // Display the data
                        if (DateTime.TryParse(savedDate, out DateTime parsedDate))
                        {
                            Picker.Value = parsedDate;
                        }
                        textbox.Text = savedText;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading data: " + ex.Message);
                    }
                }
            }

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Get the current date and text input
            string selectedDate = Picker.Value.ToString();
            string enteredText = textbox.Text;

            // Write the date and text to a file
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine(selectedDate);
                    writer.WriteLine(enteredText);
                }
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }



        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
