using MaverickLabs.PC_Off;
using MaverickLabs.Setting;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace MaverickLabs
{
    public partial class Form1 : Form
    {
        private ContextMenuSaveLoad saveLoad = new ContextMenuSaveLoad();
        public static bool FastContextActive = false;

        //FORMS
        private SettingLabsForm settingLabsForm;
        private FastContextForm FastContext;
        private TimerForm pcoffTimerForm;

        public Form1()
        {
            InitializeComponent();


            notifyIcon1.BalloonTipTitle = "Maverick Lab's";
            notifyIcon1.BalloonTipText = "Maverick Lab's in tray";
            notifyIcon1.Text = "Maverick Lab's";


            FastContext = new FastContextForm(contextMenu);
            settingLabsForm = new SettingLabsForm();
            pcoffTimerForm = new TimerForm();

            if (LabSetting.Settings.DebugMode == true) this.Text += " | DebugMode";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            checkBoxStatusProgram_CheckedChanged(null,null);

            if (LabSetting.Settings.StartInTray == true)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
           
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
           
        }
        private void checkBoxStatusProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatusProgram.Checked == true)
            {
                checkBoxStatusProgram.Text = "Active";
                checkBoxStatusProgram.BackColor = Color.Green;
                FastContextActive = true;
            }
            else
            {
                checkBoxStatusProgram.Text = "Deactive";
                checkBoxStatusProgram.BackColor = Color.Red;
                FastContextActive = false;
            }
        }
        #region Tray
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }
        #endregion
        #region OpenForms
        private void button1_Click(object sender, EventArgs e)
        {
            if (!FastContext.Visible) FastContext.Show();
            else FastContext.Activate();
        }
        private void buttonSettingLabs_Click(object sender, EventArgs e)
        {
            if (!settingLabsForm.Visible) settingLabsForm.Show();
            else settingLabsForm.Activate();
        }

        private void buttonPCOffForm_Click(object sender, EventArgs e)
        {
            if (!pcoffTimerForm.Visible) pcoffTimerForm.Show();
            else pcoffTimerForm.Activate();
        }
        #endregion
    }
}
