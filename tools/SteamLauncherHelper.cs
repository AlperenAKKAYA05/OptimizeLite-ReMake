using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace SteamLauncher
{
    public static class SteamLauncherHelper
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(int hWnd, string text, string caption, uint type);

        public static void LaunchSteamAndGame(string desiredAppId)
        {
            if (!int.TryParse(desiredAppId, out int appId))
            {
                MessageBox(0, "Geçersiz App ID.", "Hata", 0x10);
                return;
            }

            string steamPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", null) as string;

            if (steamPath != null)
            {
                Process.Start(System.IO.Path.Combine(steamPath, "steam.exe"));
                string gameArguments = $"-applaunch {appId} -malloc=system -USEALLAVAILABLECORES -high";
                Process.Start(System.IO.Path.Combine(steamPath, "steam.exe"), gameArguments);
            }
            else
            {
                MessageBox(0, "Steam'in kurulu olduğu yer bulunamadı.", "Hata", 0x10);
            }
        }
    }
}
