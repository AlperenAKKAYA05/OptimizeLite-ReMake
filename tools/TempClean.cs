using System;
using System.IO;

namespace Tool
{
    public class TempClean
    {
        public static void Run()
        {
            try
            {
                // Geçici klasör yolunu al
                string tempPath = Path.GetTempPath();

                // Geçici klasördeki tüm dosyaları ve alt dizinlerdeki dosyaları al
                string[] files = Directory.GetFiles(tempPath, "*.*", SearchOption.AllDirectories);

                foreach (string filePath in files)
                {
                    try
                    {
                        // Dosyayı sil
                        File.Delete(filePath);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Silinemedi: " + filePath);
                    }
                }

                // Geçici klasörü ve alt dizinleri sil (recursive: true)
                Directory.Delete(tempPath, recursive: true);

                // Temizleme işlemi başarılı mesajını göster
                Console.WriteLine("Geçici Konum Temizleme Başarılı. Programımızı kullandığınız için teşekkür ederiz! :D");
            }
            catch (Exception ex)
            {
                // Hata durumunda hatayı göster
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
