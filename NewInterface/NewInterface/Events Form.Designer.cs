namespace NewInterface
{
    partial class EventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Addeventtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eventsavebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(30, 50);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(418, 37);
            this.dateTimePicker.TabIndex = 10;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(727, 50);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 9;
            // 
            // Addeventtxt
            // 
            this.Addeventtxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addeventtxt.Location = new System.Drawing.Point(195, 152);
            this.Addeventtxt.Name = "Addeventtxt";
            this.Addeventtxt.Size = new System.Drawing.Size(253, 37);
            this.Addeventtxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Event";
            // 
            // Eventsavebtn
            // 
            this.Eventsavebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eventsavebtn.Location = new System.Drawing.Point(410, 364);
            this.Eventsavebtn.Name = "Eventsavebtn";
            this.Eventsavebtn.Size = new System.Drawing.Size(190, 46);
            this.Eventsavebtn.TabIndex = 6;
            this.Eventsavebtn.Text = "Save Event";
            this.Eventsavebtn.UseVisualStyleBackColor = true;
            this.Eventsavebtn.Click += new System.EventHandler(this.Eventsavebtn_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.Addeventtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eventsavebtn);
            this.Name = "EventForm";
            this.Text = "Events Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox Addeventtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eventsavebtn;
    }
}