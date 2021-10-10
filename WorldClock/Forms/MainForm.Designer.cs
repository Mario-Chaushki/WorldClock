using System.Drawing;

namespace WorldClock.Forms
{

    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timeBox = new System.Windows.Forms.TextBox();
            this.chronometerButton = new System.Windows.Forms.Button();
            this.timerButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox.Enabled = false;
            this.timeBox.Font = new System.Drawing.Font("Times New Roman", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.timeBox.Location = new System.Drawing.Point(13, 116);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(237, 50);
            this.timeBox.TabIndex = 0;
            this.timeBox.Text = "CurrentTime";
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chronometerButton
            // 
            this.chronometerButton.Location = new System.Drawing.Point(93, 12);
            this.chronometerButton.Name = "chronometerButton";
            this.chronometerButton.Size = new System.Drawing.Size(75, 23);
            this.chronometerButton.TabIndex = 1;
            this.chronometerButton.Text = "Chronometer";
            this.chronometerButton.UseVisualStyleBackColor = true;
            // 
            // timerButton
            // 
            this.timerButton.Location = new System.Drawing.Point(174, 12);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(75, 23);
            this.timerButton.TabIndex = 2;
            this.timerButton.Text = "Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            // 
            // calendarButton
            // 
            this.calendarButton.Location = new System.Drawing.Point(12, 12);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(75, 23);
            this.calendarButton.TabIndex = 3;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 260);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.chronometerButton);
            this.Controls.Add(this.timeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "World Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Button chronometerButton;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button calendarButton;
    }
}

