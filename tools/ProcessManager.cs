using System;
using System.Diagnostics;
using System.IO;

namespace Tool
{
    public class ProcessManager
    {
        private string currentProcessName; // Mevcut sürecin adını saklamak için kullanılan özel alan.

        public ProcessManager()
        {
            currentProcessName = Process.GetCurrentProcess().ProcessName; // Mevcut sürecin adını alarak başlatıcı metot.
        }

        // Çalışan süreçlerin bilgilerini döndüren metot.
        public string GetProcessListInfo()
        {
            // Tüm işlemleri al.
            Process[] processes = Process.GetProcesses();
            string processInfo = "Process List:\n";

            // Her bir işlem için ad, kimlik numarası ve başlık bilgilerini alarak dizeye ekle.
            foreach (Process process in processes)
            {
                processInfo += $"{process.ProcessName} - {process.Id} - {process.MainWindowTitle}\n";
            }

            return processInfo;
        }

        // Windows Gezgini sürecini yeniden başlatan metot.
        public void RestartExplorer()
        {
            try
            {
                // Mevcut explorer.exe süreçlerini al.
                Process[] explorerProcesses = Process.GetProcessesByName("explorer");

                // Her bir explorer.exe sürecini sonlandır.
                foreach (Process explorerProcess in explorerProcesses)
                {
                    explorerProcess.Kill();
                }

                // Yeni bir Gezgini süreci başlat.
                ProcessStartInfo exp_open = new ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = "/select, \"%UserProfile%\"",
                    UseShellExecute = true
                };

                Process.Start(exp_open);
            }
            catch (Exception)
            {
                // Gerekirse istisnaları yönet
            }
        }

        // Windows olmayan işlemleri istisnaları atlayarak sonlandıran ve Gezgini yeniden başlatan metot.
        public void CloseNonWindowsProcesses(string[] exceptions)
        {
            // Tüm işlemleri al.
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    // Eğer işlem Windows işlemi değilse ve mevcut sürecin adı değilse işlemi sonlandır.
                    if (!IsWindowsProcess(process) && process.ProcessName != currentProcessName)
                    {
                        // İstisna listesinde olmayan işlemleri sonlandır.
                        if (!IsInExceptions(process.ProcessName, exceptions))
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception)
                {
                    // Gerekirse istisnaları yönet
                }
            }

            RestartExplorer(); // Gezgini yeniden başlat.
        }

        // Verilen işlem adının istisna listesinde olup olmadığını kontrol eden metot.
        private bool IsInExceptions(string processName, string[] exceptions)
        {
            foreach (string exception in exceptions)
            {
                if (processName.Equals(exception, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        // Bir işlemin Windows işlemi olup olmadığını belirlemek için kullanılan metot.
        private bool IsWindowsProcess(Process process)
        {
            // Windows dizin yolunu al.
            string windowsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

            // İşlemin ana modül yolunu al.
            string processPath = process.MainModule?.FileName;

            if (!string.IsNullOrEmpty(processPath))
            {
                // İşlemin çalıştığı dizini al.
                string processDirectory = Path.GetDirectoryName(processPath);

                // İşlem dizini Windows dizin yoluna başlıyorsa bu bir Windows işlemidir.
                return processDirectory?.StartsWith(windowsDirectory, StringComparison.OrdinalIgnoreCase) ?? false;
            }

            return false;
        }
    }
}
