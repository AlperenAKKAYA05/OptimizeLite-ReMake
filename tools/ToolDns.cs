using System;
using System.Diagnostics;

namespace Tool
{
    public class ToolDns
    {
        public static void Run()
        {
            // "ipconfig /flushdns" komutunu çalıştır
            Command.run("/c ipconfig /flushdns");

            // Kullanıcıya biraz beklemesini söyle
            Console.WriteLine("Lütfen Biraz Bekleyin...");
        }
    }
}
