

namespace NewInterface
{
    partial class EventDisplayForm
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
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.btnLoadEvents = new System.Windows.Forms.Button();
            this.btnExitList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEvents
            // 
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(57, 34);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(610, 327);
            this.listViewEvents.TabIndex = 0;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.List;
            this.listViewEvents.SelectedIndexChanged += new System.EventHandler(this.listViewEvents_SelectedIndexChanged);
            // 
            // btnLoadEvents
            // 
            this.btnLoadEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnLoadEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadEvents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoadEvents.Location = new System.Drawing.Point(57, 386);
            this.btnLoadEvents.Name = "btnLoadEvents";
            this.btnLoadEvents.Size = new System.Drawing.Size(277, 40);
            this.btnLoadEvents.TabIndex = 1;
            this.btnLoadEvents.Text = "Load Events";
            this.btnLoadEvents.UseVisualStyleBackColor = false;
            this.btnLoadEvents.Click += new System.EventHandler(this.btnLoadEvents_Click);
            // 
            // btnExitList
            // 
            this.btnExitList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnExitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitList.Location = new System.Drawing.Point(388, 386);
            this.btnExitList.Name = "btnExitList";
            this.btnExitList.Size = new System.Drawing.Size(279, 39);
            this.btnExitList.TabIndex = 2;
            this.btnExitList.Text = "Exit";
            this.btnExitList.UseVisualStyleBackColor = false;
            this.btnExitList.Click += new System.EventHandler(this.btnExitList_Click);
            // 
            // EventDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.btnExitList);
            this.Controls.Add(this.btnLoadEvents);
            this.Controls.Add(this.listViewEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventDisplayForm";
            this.Text = "EventDisplayForm";
            this.Load += new System.EventHandler(this.EventDisplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Button btnLoadEvents;
        private System.Windows.Forms.Button btnExitList;
    }
}