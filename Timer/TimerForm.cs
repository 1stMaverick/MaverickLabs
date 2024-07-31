using MaverickLabs.Other;
using MaverickLabs.Setting;
using System;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MaverickLabs.PC_Off
{
    public partial class TimerForm : Form
    {
        [DllImport("powrprof.dll", SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        private int timeLeft = 0;
        string selectedCountry;
        private bool timerStarted = false;
        public TimerForm()
        {
            InitializeComponent();
            listBoxOption.SetSelected(0, true);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                progressBarTimePassed.Value = timeLeft;
                labelLastSecond.Text = $"{timeLeft} seconds left";
            }
            else
            {
                timer1.Stop();
                labelLastSecond.Text = "Time's up!";
                timerStarted = false;

                switch (selectedCountry)
                {
                    case "Shutdown":

                        if (LabSetting.Settings.DebugMode == true) break; 
                        var psi = new ProcessStartInfo("shutdown", "/s /t 5");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);
                        break;

                    case "Suspend(Sleep)":

                        if (LabSetting.Settings.DebugMode == true) break;
                        SetSuspendState(false, true, true);
                        
                        break;

                    case "Alarm":

                        SystemSounds.Hand.Play();

                        break;

                    default:
                        MessageBox.Show("None function");
                        break;
                }
            }
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            if (timerStarted == true) return;

            if (int.TryParse(watermarkSeconds.Text, out timeLeft) && timeLeft > 0)
            {
                progressBarTimePassed.Maximum = timeLeft;
                progressBarTimePassed.Value = timeLeft;
                timer1.Interval = 1000;
                timer1.Start();
                timerStarted = true;
            }
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBarTimePassed.Value = 0;
            labelLastSecond.Text = "Timer stopped";
            timerStarted = false;
        }

        private void listBoxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCountry = listBoxOption.SelectedItem.ToString();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
