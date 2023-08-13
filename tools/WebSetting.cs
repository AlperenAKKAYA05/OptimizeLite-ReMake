using System;
using System.Diagnostics;

namespace Tool
{
    public class WebSetting
    {
        public static void Run()
        {
            // Ağ yapılandırmalarını sıfırlamak için bir dizi komut çalıştırılır
            Command.run("ipconfig /release");                   // IP adresini serbest bırak
            Command.run("ipconfig /flushdns");                 // DNS önbelleğini temizle
            Command.run("netsh int ip reset a.txt");           // IP yapılandırmasını sıfırla (a.txt dosyasına kaydet)
            Command.run("netsh winsock reset");                // Winsock ayarlarını sıfırla
            Command.run("netsh winhttp reset proxy");          // WinHTTP proxy ayarlarını sıfırla
            Command.run("netsh advfirewall reset");            // Gelişmiş güvenlik duvarı ayarlarını sıfırla
            Command.run("ipconfig /renew");                    // IP adresi yenile

            // Kullanıcıya biraz beklemesini söyle
            Console.WriteLine("Lütfen Biraz Bekleyin");

            // Ethernet bağlantısının IP adresini DHCP'ye döndür
            Command.run("netsh interface ip set address \"Local Area Connection\" dhcp");
        }
    }
}
