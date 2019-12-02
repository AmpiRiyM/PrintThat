using Microsoft.Win32;

namespace PrintThat
{
    public static class AutoStart
    {
        public static bool isAutostarts { get { return _isStartupItem(); } }
        public static string HideWord { get { return "-hide"; } }

        const string RegistryAppPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        const string AppName = "Pechatka";
        public static bool SetAutostart(bool AutostartValue, string AppStartPath)
        {
            RegistryKey app = Registry.CurrentUser.OpenSubKey(RegistryAppPath, true);

            if (AutostartValue)
            {
                if (!_isStartupItem())
                {
                    try { app.SetValue(AppName, "\"" + AppStartPath + "\" " + HideWord); return true; }
                    catch { }
                }
            }
            else
            {
                if (_isStartupItem())
                {
                    try { app.DeleteSubKey(AppName, false); return true; }
                    catch { }
                }
            }

            return false;
        }

        static bool _isStartupItem()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryAppPath, true);

            return key.GetValue(AppName) == null ? false : true;
        }
    }
}
