namespace BasicTimerWinForms
{
    partial class FormMain
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
            this.groupBoxStartTimers = new System.Windows.Forms.GroupBox();
            this.button60Min = new System.Windows.Forms.Button();
            this.button45Min = new System.Windows.Forms.Button();
            this.button30Min = new System.Windows.Forms.Button();
            this.button25Min = new System.Windows.Forms.Button();
            this.button15Min = new System.Windows.Forms.Button();
            this.button5Min = new System.Windows.Forms.Button();
            this.button3Min = new System.Windows.Forms.Button();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonStopTimer = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonAbout = new System.Windows.Forms.Button();
            this.groupBoxStartTimers.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStartTimers
            // 
            this.groupBoxStartTimers.Controls.Add(this.button60Min);
            this.groupBoxStartTimers.Controls.Add(this.button45Min);
            this.groupBoxStartTimers.Controls.Add(this.button30Min);
            this.groupBoxStartTimers.Controls.Add(this.button25Min);
            this.groupBoxStartTimers.Controls.Add(this.button15Min);
            this.groupBoxStartTimers.Controls.Add(this.button5Min);
            this.groupBoxStartTimers.Controls.Add(this.button3Min);
            this.groupBoxStartTimers.Location = new System.Drawing.Point(12, 162);
            this.groupBoxStartTimers.Name = "groupBoxStartTimers";
            this.groupBoxStartTimers.Size = new System.Drawing.Size(575, 46);
            this.groupBoxStartTimers.TabIndex = 0;
            this.groupBoxStartTimers.TabStop = false;
            this.groupBoxStartTimers.Text = "Start Timers";
            // 
            // button60Min
            // 
            this.button60Min.Location = new System.Drawing.Point(492, 17);
            this.button60Min.Name = "button60Min";
            this.button60Min.Size = new System.Drawing.Size(75, 23);
            this.button60Min.TabIndex = 6;
            this.button60Min.Tag = "60";
            this.button60Min.Text = "60 Mins";
            this.button60Min.UseVisualStyleBackColor = true;
            this.button60Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // button45Min
            // 
            this.button45Min.Location = new System.Drawing.Point(411, 17);
            this.button45Min.Name = "button45Min";
            this.button45Min.Size = new System.Drawing.Size(75, 23);
            this.button45Min.TabIndex = 5;
            this.button45Min.Tag = "45";
            this.button45Min.Text = "45 Mins";
            this.button45Min.UseVisualStyleBackColor = true;
            this.button45Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // button30Min
            // 
            this.button30Min.Location = new System.Drawing.Point(330, 17);
            this.button30Min.Name = "button30Min";
            this.button30Min.Size = new System.Drawing.Size(75, 23);
            this.button30Min.TabIndex = 4;
            this.button30Min.Tag = "30";
            this.button30Min.Text = "30 Mins";
            this.button30Min.UseVisualStyleBackColor = true;
            this.button30Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // button25Min
            // 
            this.button25Min.Location = new System.Drawing.Point(249, 17);
            this.button25Min.Name = "button25Min";
            this.button25Min.Size = new System.Drawing.Size(75, 23);
            this.button25Min.TabIndex = 3;
            this.button25Min.Tag = "25";
            this.button25Min.Text = "25 Mins";
            this.button25Min.UseVisualStyleBackColor = true;
            this.button25Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // button15Min
            // 
            this.button15Min.Location = new System.Drawing.Point(168, 17);
            this.button15Min.Name = "button15Min";
            this.button15Min.Size = new System.Drawing.Size(75, 23);
            this.button15Min.TabIndex = 2;
            this.button15Min.Tag = "15";
            this.button15Min.Text = "15 Mins";
            this.button15Min.UseVisualStyleBackColor = true;
            this.button15Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5Min
            // 
            this.button5Min.Location = new System.Drawing.Point(87, 17);
            this.button5Min.Name = "button5Min";
            this.button5Min.Size = new System.Drawing.Size(75, 23);
            this.button5Min.TabIndex = 1;
            this.button5Min.Tag = "5";
            this.button5Min.Text = "5 Mins";
            this.button5Min.UseVisualStyleBackColor = true;
            this.button5Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3Min
            // 
            this.button3Min.Location = new System.Drawing.Point(6, 17);
            this.button3Min.Name = "button3Min";
            this.button3Min.Size = new System.Drawing.Size(75, 23);
            this.button3Min.TabIndex = 0;
            this.button3Min.Tag = "3";
            this.button3Min.Text = "3 Mins";
            this.button3Min.UseVisualStyleBackColor = true;
            this.button3Min.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.labelTimer);
            this.groupBoxTimer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(575, 144);
            this.groupBoxTimer.TabIndex = 1;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Timer";
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTimer.Location = new System.Drawing.Point(3, 16);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(569, 125);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonAbout);
            this.groupBoxControls.Controls.Add(this.buttonStopTimer);
            this.groupBoxControls.Location = new System.Drawing.Point(12, 214);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(575, 46);
            this.groupBoxControls.TabIndex = 7;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // buttonStopTimer
            // 
            this.buttonStopTimer.Location = new System.Drawing.Point(249, 17);
            this.buttonStopTimer.Name = "buttonStopTimer";
            this.buttonStopTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonStopTimer.TabIndex = 1;
            this.buttonStopTimer.Text = "Stop Timer";
            this.buttonStopTimer.UseVisualStyleBackColor = true;
            this.buttonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(492, 17);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 267);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxTimer);
            this.Controls.Add(this.groupBoxStartTimers);
            this.Name = "FormMain";
            this.Text = "BasicTimer";
            this.groupBoxStartTimers.ResumeLayout(false);
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStartTimers;
        private System.Windows.Forms.Button button60Min;
        private System.Windows.Forms.Button button45Min;
        private System.Windows.Forms.Button button30Min;
        private System.Windows.Forms.Button button25Min;
        private System.Windows.Forms.Button button15Min;
        private System.Windows.Forms.Button button5Min;
        private System.Windows.Forms.Button button3Min;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonStopTimer;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonAbout;
    }
}

