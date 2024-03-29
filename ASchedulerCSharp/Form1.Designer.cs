﻿namespace ASchedulerCSharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.schedule_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.schedule_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.schedule_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copy and paste schedule into textbox below:";
            // 
            // schedule_textbox
            // 
            this.schedule_textbox.Location = new System.Drawing.Point(16, 30);
            this.schedule_textbox.Name = "schedule_textbox";
            this.schedule_textbox.Size = new System.Drawing.Size(634, 20);
            this.schedule_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Example: |42|42|R |R | 45| | |";
            // 
            // schedule_date
            // 
            this.schedule_date.Location = new System.Drawing.Point(194, 93);
            this.schedule_date.Name = "schedule_date";
            this.schedule_date.Size = new System.Drawing.Size(200, 20);
            this.schedule_date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the first date on the schedule";
            // 
            // schedule_button
            // 
            this.schedule_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_button.Location = new System.Drawing.Point(457, 86);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(193, 39);
            this.schedule_button.TabIndex = 5;
            this.schedule_button.Text = "Generate Schedule";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.schedule_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Open Google Calendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open Documents";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 141);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.schedule_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.schedule_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.schedule_textbox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Schedule Generator - Stephen Marcok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox schedule_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker schedule_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

