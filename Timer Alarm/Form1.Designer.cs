namespace Timer_Alarm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Timers.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtboxCountdown = new System.Windows.Forms.TextBox();
            this.TimeProgress = new System.Windows.Forms.ProgressBar();
            this.updownSeconds = new System.Windows.Forms.NumericUpDown();
            this.updownMinutes = new System.Windows.Forms.NumericUpDown();
            this.updownHours = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.AlarmTimer = new System.ComponentModel.BackgroundWorker();
            this.EventMessageButton = new System.Windows.Forms.Button();
            this.win_taskbar = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
            
            
            
            
            this.SuspendLayout();
            // 
            // timer1
            // 
            
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Ticked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alarm Timer";
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Location = new System.Drawing.Point(68, 159);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Timer";
            this.StartButton.Click += new System.EventHandler(this.Start_Clicked);
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetButton.Location = new System.Drawing.Point(148, 159);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset Timer";
            this.ResetButton.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Alarm Timer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // txtboxCountdown
            // 
            this.txtboxCountdown.Location = new System.Drawing.Point(150, 122);
            this.txtboxCountdown.Name = "txtboxCountdown";
            this.txtboxCountdown.Size = new System.Drawing.Size(100, 20);
            this.txtboxCountdown.TabIndex = 4;
            this.txtboxCountdown.TextChanged += new System.EventHandler(this.txtboxCountdown_TextChanged);
            this.txtboxCountdown.Hide();
            // 
            // TimeProgress
            // 
            this.TimeProgress.Location = new System.Drawing.Point(81, 198);
            this.TimeProgress.Name = "TimeProgress";
            this.TimeProgress.Size = new System.Drawing.Size(125, 23);
            this.TimeProgress.TabIndex = 5;
            // 
            // updownSeconds
            // 
            this.updownSeconds.Location = new System.Drawing.Point(174, 96);
            this.updownSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updownSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownSeconds.Name = "updownSeconds";
            this.updownSeconds.Size = new System.Drawing.Size(32, 20);
            this.updownSeconds.TabIndex = 6;
            this.updownSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updownMinutes
            // 
            this.updownMinutes.Location = new System.Drawing.Point(125, 96);
            this.updownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updownMinutes.Name = "updownMinutes";
            this.updownMinutes.Size = new System.Drawing.Size(32, 20);
            this.updownMinutes.TabIndex = 7;
            // 
            // updownHours
            // 
            this.updownHours.Location = new System.Drawing.Point(82, 96);
            this.updownHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.updownHours.Name = "updownHours";
            this.updownHours.Size = new System.Drawing.Size(32, 20);
            this.updownHours.TabIndex = 8;
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(78, 80);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(35, 13);
            this.Hours.TabIndex = 9;
            this.Hours.Text = "Hours";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(119, 80);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(44, 13);
            this.Minutes.TabIndex = 10;
            this.Minutes.Text = "Minutes";
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Location = new System.Drawing.Point(167, 80);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(49, 13);
            this.Seconds.TabIndex = 11;
            this.Seconds.Text = "Seconds";
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AlarmTimer_DoWork);
            // 
            // EventMessageButton
            // 
            this.EventMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EventMessageButton.Location = new System.Drawing.Point(15, 121);
            this.EventMessageButton.Name = "EventMessageButton";
            this.EventMessageButton.TabIndex = 12;
            this.EventMessageButton.Size = new System.Drawing.Size(100, 25);
            this.EventMessageButton.Text = "Event Message";
            this.EventMessageButton.Click += new System.EventHandler(this.EventMessage_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.updownHours);
            this.Controls.Add(this.updownMinutes);
            this.Controls.Add(this.updownSeconds);
            this.Controls.Add(this.TimeProgress);
            this.Controls.Add(this.txtboxCountdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.EventMessageButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alarm_Timer";
            this.SizeChanged += new System.EventHandler(this.Form_Resized);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Timers.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton, ResetButton, EventMessageButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtboxCountdown;
        private System.Windows.Forms.ProgressBar TimeProgress;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.NumericUpDown updownHours;
        private System.Windows.Forms.NumericUpDown updownMinutes;
        private System.Windows.Forms.NumericUpDown updownSeconds;
        delegate void SetTimerLabel();
        private System.ComponentModel.BackgroundWorker AlarmTimer;
        delegate void SetTimerProgress(int Interval);
        private Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager win_taskbar;
        
       
        
    }
}

