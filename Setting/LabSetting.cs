using Newtonsoft.Json;
using System.IO;

namespace MaverickLabs.Setting
{
    public static class LabSetting
    {
        private static string settingsFilePath = "Settings.json";
        private static AppSettings _settings;

        static LabSetting()
        {
            LoadSettings();
        }

        public static AppSettings Settings => _settings;

        private static void LoadSettings()
        {
            if (File.Exists(settingsFilePath))
            {
                string json = File.ReadAllText(settingsFilePath);
                _settings = JsonConvert.DeserializeObject<AppSettings>(json);
            }
            else
            {
                _settings = new AppSettings();
            }
        }

        public static void SaveSettings()
        {
            string json = JsonConvert.SerializeObject(_settings, Formatting.Indented);
            File.WriteAllText(settingsFilePath, json);
        }
    }
}
