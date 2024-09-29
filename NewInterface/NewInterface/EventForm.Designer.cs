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
            this.textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Picker = new System.Windows.Forms.DateTimePicker();
            this.Savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(329, 25);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(200, 20);
            this.textbox.TabIndex = 1;
            this.textbox.Text = " ";
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(326, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // Picker
            // 
            this.Picker.Location = new System.Drawing.Point(41, 25);
            this.Picker.Name = "Picker";
            this.Picker.Size = new System.Drawing.Size(200, 20);
            this.Picker.TabIndex = 4;
            this.Picker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Savebtn.Location = new System.Drawing.Point(250, 75);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(620, 129);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Picker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Picker;
        private System.Windows.Forms.Button Savebtn;
    }
}