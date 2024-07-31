using MaverickLabs.Setting;
using Microsoft.Win32;
using System.Windows.Forms;

namespace MaverickLabs
{
    public partial class SettingLabsForm : Form
    {
        private static AppSettings settings;
        public bool StartInTray
        {
            get; private set;
        }
        public SettingLabsForm()
        {
            InitializeComponent();

            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (regKey.GetValue("Maverick Lab's") != null) checkBoxAutoStart.Checked = true;
            StartInTray = checkBoxStartInTray.Checked;

            settings = LabSetting.Settings;
            checkBoxDebugMode.Checked = settings.DebugMode;
            checkBoxStartInTray.Checked = settings.StartInTray;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            LabSetting.SaveSettings();
        }
        public static void SetAutoStart(bool enable, string appName, string executablePath)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (enable)
            {
                regKey.SetValue(appName, executablePath);
            }
            else
            {
                regKey.DeleteValue(appName, false);
            }
        }
        
        private void checkBoxAutoStart_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxAutoStart.Checked) SetAutoStart(true,"Maverick Lab's", Application.ExecutablePath);
            else SetAutoStart(false, "Maverick Lab's", Application.ExecutablePath);

        }

        private void checkBoxDebugMode_CheckedChanged(object sender, System.EventArgs e)
        {
            settings.DebugMode = checkBoxDebugMode.Checked;

        }

        private void checkBoxStartInTray_CheckedChanged(object sender, System.EventArgs e)
        {
            settings.StartInTray = checkBoxStartInTray.Checked;
        }
    }
}
