using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using Microsoft.Win32.TaskScheduler;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace tastscheduler
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // user input
            string event_execute = toexecute.Text;
            DateTime date = dateinput.Value;

            int hour = Convert.ToInt32(txthour.Text);
            int minute = Convert.ToInt32(txtmin.Text);
            short reapeat_day = Convert.ToInt16(repeatdate.Text);
            int reapeat_hours = Convert.ToInt32(repeathours.Text);

            // Create a new task scheduler
            using (TaskService ts = new TaskService())
            {

                // Retrieve the existing "\Rapidigital_events" folder, or create it if it doesn't exist
                TaskFolder Folder = ts.RootFolder.SubFolders.FirstOrDefault(f => f.Name == "Rapidigital_events");
                if (Folder == null)
                {
                    Folder = ts.RootFolder.CreateFolder("Rapidigital_events");
                }

                // Create a new task
                TaskDefinition td = ts.NewTask();

                // Set the task properties
                td.RegistrationInfo.Description = "custome_task demo10";
                td.RegistrationInfo.Author = "Rapidigital_admin";

                // choose repeatation 
                if (firstrepeat.Text == "Daily")
                {
                    // Create a new daily trigger
                    DailyTrigger dailyTrigger = new DailyTrigger();

                    // Set the start boundary to the same time each day as per user input
                    dailyTrigger.StartBoundary = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0);

                    // Add the trigger to the task definition
                    td.Triggers.Add(dailyTrigger);

                    // days interval every 1 day
                    dailyTrigger.DaysInterval = 1;


                    // Set the repetition interval to repeat every 3 hours
                    dailyTrigger.Repetition.Interval = TimeSpan.FromHours(reapeat_hours);
                    // repeat only 1 trigger/24 hours
                    dailyTrigger.Repetition.Duration = TimeSpan.FromDays(1);
                }
                else if (firstrepeat.Text == "Weekly")
                {
                    // Add a weekly trigger
                    WeeklyTrigger weeklyTrigger = new WeeklyTrigger();

                    // Get the days of the week from the checkboxes
                    if (checkBox1.Checked)
                    {
                        weeklyTrigger.DaysOfWeek |= DaysOfTheWeek.Monday;
                    }
                    if (checkBox2.Checked)
                    {
                        weeklyTrigger.DaysOfWeek |= DaysOfTheWeek.Tuesday;
                    }
                    if (checkBox3.Checked)
                    {
                        weeklyTrigger.DaysOfWeek |= DaysOfTheWeek.Wednesday;
                    }
                    if (checkBox4.Checked)
                    {
                        weeklyTrigger.DaysOfWeek |= DaysOfTheWeek.Thursday;
                    }
                    if (checkBox5.Checked)
                    {
                        weeklyTrigger.DaysOfWeek |= DaysOfTheWeek.Friday;
                    }
                    if (checkBox6.Checked)
                    {
                        weeklyTrigger.DaysOfWeek |= DaysOfTheWeek.Saturday;
                    }
                    if (checkBox7.Checked)
                    {
                        weeklyTrigger.DaysOfWeek |= DaysOfTheWeek.Sunday;
                    }

                    // Repeat every week
                    weeklyTrigger.WeeksInterval = 1;

                    // Set the start time to the current time
                    //weeklyTrigger.StartBoundary = DateTime.Now;
                    weeklyTrigger.StartBoundary = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0); // date hour min sec

                    // Add the trigger to the task
                    td.Triggers.Add(weeklyTrigger);
                }
                else if (firstrepeat.Text == "Monthly")
                {
                    // Add a monthly trigger 
                    MonthlyTrigger monthlyTrigger = new MonthlyTrigger();

                    monthlyTrigger.StartBoundary = new DateTime(date.Year, date.Month, reapeat_day, hour, minute, 0); // date hour min sec
                    td.Triggers.Add(monthlyTrigger);

                }



                // Create an email action that sends an email                            servername             from                        to                           subject                 body                            
                EmailAction emailAction = (EmailAction)td.Actions.Add(new EmailAction("smtp.live.com", "amanwaghmare311@gmail.com", "waghmareaman299@gmail.com", "testing of emails", "this is my first email with coading"));

                // Create a new SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.live.com");

                // Set the port for the SMTP client
                smtpClient.Port = 25;


                // Add the email action to the task
                td.Actions.Add(emailAction);



                // Register the task_name in the "\Rapidigital_events" folder of the task scheduler
                Folder.RegisterTaskDefinition("Auto_Emails", td);

            }

            MessageBox.Show("SCHEDULED SUCCESSFULY !!");

        }

        private void firstrepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstrepeat.Text == "Daily")
            {
                label7.Visible = false;
                repeatdate.Visible = false;

                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;

                repeathours.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label10.Visible = false;
            }
            else if (firstrepeat.Text == "Monthly")
            {

                label7.Visible = true;
                repeatdate.Visible = true;

                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;

                label10.Visible = true;
            }
            else if (firstrepeat.Text == "Weekly")
            {
                label7.Visible = true;
                repeatdate.Visible = false;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;

                label10.Visible = false;
            }
            else
            {
                MessageBox.Show("enter valid input in ");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            repeatdate.Visible = false;

            repeathours.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label10.Visible = false;

            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string event_execute = toexecute.Text;

            using (TaskService ts = new TaskService())
            {
                string exePath = "C:\\Users\\anujb\\source\\repos\\Myemailsender\\Myemailsender\\bin\\Debug\\net6.0\\Myemailsender.exe";
                Process.Start(exePath);
                MessageBox.Show("backup now is working great..");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = "C:\\Windows\\System32\\Tasks\\Rapidigital_events\\deletefiles_demo";
            /*
              //  DELETE FILES WITH FILE CREATION DATE
              DateTime thresholdDate = DateTime.Now.AddDays(-30); // Set the threshold date to 30 days ago

              foreach (string filePath in Directory.GetFiles(folderPath))
              {
                  FileInfo fileInfo = new FileInfo(filePath);
                  if (fileInfo.LastWriteTime < thresholdDate)   // if file is older than 30 days delete it
                  {
                      File.Delete(filePath);
                  }
              }
            */

            //  DELETE FILES WITH FILE COUNTS 
            // In the above code, the files are going to be deleted based on the file creation time.
            // The files with the oldest creation time will be deleted first .

            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = directoryInfo.GetFiles();
            int fileCount = files.Length;

            if (fileCount > 10)  // if file count is greater than 10
            {
                Array.Sort(files, (x, y) => DateTime.Compare(x.LastWriteTime, y.LastWriteTime));

                for (int i = 0; i < 5; i++)   // then delete 5 files from it
                {
                    files[i].Delete();
                }
            }
            MessageBox.Show("files deleted ");

        }


    }
}
