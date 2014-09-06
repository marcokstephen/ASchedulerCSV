using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASchedulerCSharp
{
    public partial class Form1 : Form
    {
        DateTimePicker scheduleDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            TextBox scheduleBox = schedule_textbox;
            String scheduleString;
            scheduleDate = schedule_date;

            DateTime dt = this.scheduleDate.Value.Date;

            scheduleString = scheduleBox.Text;
            if (scheduleString.Length < 2)
            {
                MessageBox.Show("Error!\n\nYou did not copy and paste your schedule.");
            }
            else
            {

                if (scheduleString[0] == ('|'))
                {
                    scheduleString = scheduleString.Substring(1);
                }
                scheduleString = scheduleString.Replace(" ", "");
                String[] shifts = scheduleString.Split('|');
                MessageBox.Show("Generation complete!\n\nOutput has been saved to your \"Documents\" folder!");

                using (StreamWriter outfile = new StreamWriter(mydocpath + @"\GeneratedSchedule.csv"))
                {
                    outfile.Write("Subject,Start Date,Start Time,End Time,End Date,Description\n");
                    for (int i = 0; i < shifts.Length; i++)
                    {
                        if (shifts[i].Equals("40") || shifts[i].Equals("42") || shifts[i].Equals("45") || shifts[i].Equals("46") || shifts[i].Equals("48") || shifts[i].Equals("54") || shifts[i].Equals("56") || shifts[i].Equals("57") || shifts[i].Equals("58"))
                        {
                            outfile.Write("Work Shift,");
                            DateTime dateOnly = dt.Date;
                            // Display date using short date string.
                            outfile.Write(dateOnly.ToString("MM'/'dd'/'yyyy") + ",");
                            if (shifts[i].Equals("40"))
                            {
                                outfile.Write("10:00,"); //start time
                                outfile.Write("18:00,"); //end time
                            }
                            else if (shifts[i].Equals("42"))
                            {
                                outfile.Write("12:00,"); //start time
                                outfile.Write("20:00,"); //end time					
                            }
                            else if (shifts[i].Equals("45"))
                            {
                                outfile.Write("15:00,"); //start time
                                outfile.Write("23:00,"); //end time				
                            }
                            else if (shifts[i].Equals("46"))
                            {
                                outfile.Write("16:00,"); //start time
                                outfile.Write("23:59,"); //end time				
                            }
                            else if (shifts[i].Equals("48"))
                            {
                                outfile.Write("18:00,"); //start time
                                outfile.Write("02:00,"); //end time					
                            }
                            else if (shifts[i].Equals("54"))
                            {
                                outfile.Write("14:00,"); //start time
                                outfile.Write("22:00,"); //end time				
                            }
                            else if (shifts[i].Equals("56"))
                            {
                                outfile.Write("06:00,"); //start time
                                outfile.Write("14:00,"); //end time				
                            }
                            else if (shifts[i].Equals("57"))
                            {
                                outfile.Write("07:00,"); //start time
                                outfile.Write("15:00,"); //end time				
                            }
                            else if (shifts[i].Equals("58"))
                            {
                                outfile.Write("08:00,"); //start time
                                outfile.Write("16:00,"); //end time					
                            }
                            else
                            {
                                //indicate an error has occurred!!!
                                outfile.Write("00:01,"); //start time
                                outfile.Write("23:59,"); //end time
                            }

                            if (shifts[i].Equals("48"))
                            {
                                dt = dt.AddDays(1);
                                dateOnly = dt.Date;
                                outfile.Write(dateOnly.ToString("MM'/'dd'/'yyyy") + ",");
                                dt = dt.AddDays(-1);
                            }
                            else
                            {
                                dateOnly = dt.Date;
                                outfile.Write(dateOnly.ToString("MM'/'dd'/'yyyy") + ",");
                            }
                            outfile.Write("Shift number " + shifts[i]);//description
                            outfile.Write("\n");
                        }
                        //must be the last thing!!
                        dt = dt.AddDays(1);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/calendar/render");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.Diagnostics.Process.Start(mydocpath);
        }
    }
}
