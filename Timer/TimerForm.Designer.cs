namespace MaverickLabs.PC_Off
{
    partial class TimerForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.labelLastSecond = new System.Windows.Forms.Label();
            this.progressBarTimePassed = new System.Windows.Forms.ProgressBar();
            this.buttonStopTimer = new System.Windows.Forms.Button();
            this.listBoxOption = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.watermarkTextBoxS = new MaverickLabs.Other.WatermarkTextBox();
            this.watermarkTextBoxM = new MaverickLabs.Other.WatermarkTextBox();
            this.watermarkTextBoxH = new MaverickLabs.Other.WatermarkTextBox();
            this.watermarkSeconds = new MaverickLabs.Other.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStartTimer
            // 
            this.buttonStartTimer.Location = new System.Drawing.Point(137, 98);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonStartTimer.TabIndex = 0;
            this.buttonStartTimer.Text = "Start";
            this.buttonStartTimer.UseVisualStyleBackColor = true;
            this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // labelLastSecond
            // 
            this.labelLastSecond.AutoSize = true;
            this.labelLastSecond.Location = new System.Drawing.Point(73, 182);
            this.labelLastSecond.Name = "labelLastSecond";
            this.labelLastSecond.Size = new System.Drawing.Size(85, 13);
            this.labelLastSecond.TabIndex = 2;
            this.labelLastSecond.Text = "Timer stopped";
            // 
            // progressBarTimePassed
            // 
            this.progressBarTimePassed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarTimePassed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarTimePassed.Location = new System.Drawing.Point(11, 156);
            this.progressBarTimePassed.Name = "progressBarTimePassed";
            this.progressBarTimePassed.Size = new System.Drawing.Size(201, 23);
            this.progressBarTimePassed.TabIndex = 3;
            // 
            // buttonStopTimer
            // 
            this.buttonStopTimer.Location = new System.Drawing.Point(137, 127);
            this.buttonStopTimer.Name = "buttonStopTimer";
            this.buttonStopTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonStopTimer.TabIndex = 4;
            this.buttonStopTimer.Text = "Stop";
            this.buttonStopTimer.UseVisualStyleBackColor = true;
            this.buttonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
            // 
            // listBoxOption
            // 
            this.listBoxOption.DisplayMember = "1";
            this.listBoxOption.FormattingEnabled = true;
            this.listBoxOption.Items.AddRange(new object[] {
            "Shutdown",
            "Suspend(Sleep)",
            "Alarm"});
            this.listBoxOption.Location = new System.Drawing.Point(12, 29);
            this.listBoxOption.Name = "listBoxOption";
            this.listBoxOption.Size = new System.Drawing.Size(120, 95);
            this.listBoxOption.TabIndex = 5;
            this.listBoxOption.TabStop = false;
            this.listBoxOption.ValueMember = "1";
            this.listBoxOption.SelectedIndexChanged += new System.EventHandler(this.listBoxOption_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Write second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "H    M    S";
            // 
            // watermarkTextBoxS
            // 
            this.watermarkTextBoxS.ForeColor = System.Drawing.Color.Gray;
            this.watermarkTextBoxS.Location = new System.Drawing.Point(193, 73);
            this.watermarkTextBoxS.MaxLength = 2;
            this.watermarkTextBoxS.Name = "watermarkTextBoxS";
            this.watermarkTextBoxS.PlaceholderText = "00";
            this.watermarkTextBoxS.Size = new System.Drawing.Size(20, 20);
            this.watermarkTextBoxS.TabIndex = 15;
            this.watermarkTextBoxS.Text = "00";
            // 
            // watermarkTextBoxM
            // 
            this.watermarkTextBoxM.ForeColor = System.Drawing.Color.Gray;
            this.watermarkTextBoxM.Location = new System.Drawing.Point(166, 73);
            this.watermarkTextBoxM.MaxLength = 2;
            this.watermarkTextBoxM.Name = "watermarkTextBoxM";
            this.watermarkTextBoxM.PlaceholderText = "00";
            this.watermarkTextBoxM.Size = new System.Drawing.Size(20, 20);
            this.watermarkTextBoxM.TabIndex = 14;
            this.watermarkTextBoxM.Text = "00";
            // 
            // watermarkTextBoxH
            // 
            this.watermarkTextBoxH.ForeColor = System.Drawing.Color.Gray;
            this.watermarkTextBoxH.Location = new System.Drawing.Point(138, 73);
            this.watermarkTextBoxH.MaxLength = 2;
            this.watermarkTextBoxH.Name = "watermarkTextBoxH";
            this.watermarkTextBoxH.PlaceholderText = "00";
            this.watermarkTextBoxH.Size = new System.Drawing.Size(20, 20);
            this.watermarkTextBoxH.TabIndex = 13;
            this.watermarkTextBoxH.Text = "00";
            // 
            // watermarkSeconds
            // 
            this.watermarkSeconds.ForeColor = System.Drawing.Color.Gray;
            this.watermarkSeconds.Location = new System.Drawing.Point(139, 29);
            this.watermarkSeconds.MaxLength = 4;
            this.watermarkSeconds.Name = "watermarkSeconds";
            this.watermarkSeconds.PlaceholderText = "000";
            this.watermarkSeconds.Size = new System.Drawing.Size(74, 20);
            this.watermarkSeconds.TabIndex = 16;
            this.watermarkSeconds.Text = "000";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 246);
            this.Controls.Add(this.watermarkSeconds);
            this.Controls.Add(this.watermarkTextBoxS);
            this.Controls.Add(this.watermarkTextBoxM);
            this.Controls.Add(this.watermarkTextBoxH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOption);
            this.Controls.Add(this.buttonStopTimer);
            this.Controls.Add(this.progressBarTimePassed);
            this.Controls.Add(this.labelLastSecond);
            this.Controls.Add(this.buttonStartTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerForm";
            this.ShowInTaskbar = false;
            this.Text = "Timer | Maverick Lab\'s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Label labelLastSecond;
        private System.Windows.Forms.ProgressBar progressBarTimePassed;
        private System.Windows.Forms.Button buttonStopTimer;
        private System.Windows.Forms.ListBox listBoxOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Other.WatermarkTextBox watermarkTextBoxH;
        private Other.WatermarkTextBox watermarkTextBoxM;
        private Other.WatermarkTextBox watermarkTextBoxS;
        private Other.WatermarkTextBox watermarkSeconds;
    }
}