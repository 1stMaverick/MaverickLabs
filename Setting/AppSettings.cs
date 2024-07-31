

namespace MaverickLabs.Setting
{
    public class AppSettings
    {
        public bool DebugMode {  get; set; }
        public bool StartInTray { get; set; }

        public AppSettings() 
        {
            DebugMode = false;
            StartInTray = false;
        }
    }
}
