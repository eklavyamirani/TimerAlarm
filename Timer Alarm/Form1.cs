using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.WindowsAPICodePack.Shell;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;



namespace Timer_Alarm
{  
             
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form_Resized(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        public int TimeSec, TimeMin, TimeHours;
        private System.Timers.Timer temp;
        public string EventMessage="Time Up!";
        
                

        private void InitialiseTime()
        {
            
            this.TimeSec = (int)this.updownSeconds.Value;
            this.TimeMin = (int)this.updownMinutes.Value;
            this.TimeHours = (int)this.updownHours.Value;
            
        }

        private void Start_Clicked(object sender, EventArgs e)
        {
            
            this.TimeProgress.Value = 0;
            AlarmTimer.RunWorkerAsync();
            
        }

        private void SetTimeProgressStep(int Interval)
        {
            if (this.TimeProgress.InvokeRequired)
            {
                SetTimerProgress stl = new SetTimerProgress(this.SetTimeProgressStep);
                this.Invoke(stl, new object[] { Interval});
            }
            else
            {
                this.TimeProgress.Step = 100 / (Interval);
                
            }
        }

        private void AlarmTimer_DoWork(object sender, DoWorkEventArgs dwe)
        {

            InitialiseTime();
            int Interval = (TimeSec + TimeMin * 60 + TimeHours * 3600);
            this.timer1.Interval = 1 + Interval * 1000;
            SetTimeProgressStep(Interval);
            this.timer1.Start();
            temp = new System.Timers.Timer();
            temp.Interval = 1000;
            temp.Elapsed += new System.Timers.ElapsedEventHandler(temp_Elapsed);
            temp.Start();
            temp.AutoReset = true;
        }

        
        private void Timer_Ticked(object sender, EventArgs e)
        {
            this.timer1.Stop();
            MessageBox.Show(this.EventMessage, "Alarm", MessageBoxButtons.OK, MessageBoxIcon.None);
            
            
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
        }

        private void temp_Elapsed(object sender, EventArgs e)
        {
           
            this.TimeSec--; 
            string time;
            time = this.TimeSec.ToString();
            StepTimeProgress();
            if (this.TimeSec == 0)
            {
                temp.AutoReset = false;
                
            }
            
            
                                     
        }

        private void StepTimeProgress()
        {
            try
            {
                
                if (this.TimeProgress.InvokeRequired)
                {
                    SetTimerLabel t = new SetTimerLabel(this.StepTimeProgress);
                    this.Invoke(t);
                }
                else
                {
                    this.TimeProgress.PerformStep();
                    this.win_taskbar.SetProgressValue(this.TimeProgress.Value, 100);
                    if (this.TimeSec == 0 && this.TimeHours == 0 && this.TimeMin == 0)
                    {
                        this.TimeProgress.Value = 100;
                        this.win_taskbar.SetProgressValue(100, 100);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Reset_Button_Click(object sender, EventArgs ea)
        {
            try
            {
                this.updownHours.Value = 0;
                this.updownMinutes.Value = 0;
                this.updownSeconds.Value = 1;
                this.TimeProgress.Value = 0;
                this.timer1.Stop();
                this.InitialiseTime();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void EventMessage_Click(object sender,EventArgs ea)
        {
            try
            {
                this.txtboxCountdown.Show();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
         }

        private void txtboxCountdown_TextChanged(Object sender, EventArgs ea)
        {

            this.EventMessage = this.txtboxCountdown.Text;
        }

                     


        

    }
}
