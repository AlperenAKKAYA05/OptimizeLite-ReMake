using System.Diagnostics;

namespace Tool
{
    public class Command
    {
        // Command sınıfı, dışarıdan verilen bir komutu çalıştırmak için kullanılır.
        public static void run(string command)
        {
            // ProcessStartInfo nesnesi, yeni bir işlem başlatmak için gerekli ayarları içerir.
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c {command}")
            {
                CreateNoWindow = false,     // Yeni bir pencere oluşturulmasını engeller (false ise oluşturur).
                UseShellExecute = true      // Komutun işletim sistemine göre çalıştırılmasını sağlar.
            };

            // Belirtilen komutu içeren bir işlem başlatılır ve işlemin tamamlanmasını bekler.
            Process.Start(psi)?.WaitForExit();
        }
    }
}
