using Microsoft.Win32;
using SteamLauncher;
using System.Diagnostics;
using System.Globalization;
using Tool;

namespace OptimizeLite
{
    public partial class Form1 : Form
    {
        private string currentProcessName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentProcessName = Process.GetCurrentProcess().ProcessName;
        }

        private void buttonCloseAll_Click(object sender, EventArgs e)
        {
            string[] exceptions = { "spotify", "steam", "steamwebhelper", "SteamService", "steam" };
            ProcessManager processManager = new ProcessManager();
            processManager.CloseNonWindowsProcesses(exceptions);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempClean.Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebSetting.Run();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToolDns.Run();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string gameId = textBox1.Text; // Counter-Strike: Global Offensive için örnek App ID
                SteamLauncherHelper.LaunchSteamAndGame(gameId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lisans metni
            string licenseText_en = @"
            Copyright (c) 2023 Alperen AKKAYA.

            Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

            1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

            2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
           
            3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
            
            THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS ""AS IS"" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.";

            string licenseText_tr = @"
            Telif Hakký © 2023 Alperen AKKAYA Kaynak ve ikili biçimlerdeki daðýtým ve kullaným, deðiþtirilmiþ olsun veya olmasýn, aþaðýdaki koþullarýn yerine getirilmesi kaydýyla izin verilir:

            1. Kaynak kodunun yeniden daðýtýmý, yukarýdaki telif hakký bildirimi, bu koþullar listesi ve aþaðýdaki feragatnameyi içermelidir.
            2. Ýkili biçimde yeniden daðýtým, yukarýdaki telif hakký bildirimi, bu koþullar listesi ve aþaðýdaki feragatnameyi, daðýtýlan belge ve/veya diðer materyallerle birlikte çoðaltmalýdýr.
            3. Telif hakký sahibinin adý veya katkýda bulunanlarýn adlarý, bu yazýlýmdan türetilen ürünleri desteklemek veya tanýtmak için önceden yazýlý izin alýnmadan kullanýlamaz.

            BU YAZILIM, TELÝF HAKKI SAHÝPLERÝ VE KATKIDA BULUNANLAR TARAFINDAN “OLDUÐU GÝBÝ” SAÐLANMIÞTIR VE HERHANGÝ BÝR AÇIK VEYA ZIMNÝ GARANTÝ VERMEZ. TELÝF HAKKI SAHÝPLERÝ VE KATKIDA BULUNANLAR, BU YAZILIMIN KULLANIMINDAN DOÐAN HERHANGÝ BÝR DOÐRUDAN, DOLAYLI, TESADÜFÝ, ÖZEL, ÖRNEK VEYA SONUÇ OLARAK ORTAYA ÇIKAN ZARARLARDAN (BUNLARA SINIRLI OLMAKSIZIN YERÝNE GETÝRME MAL VEYA HÝZMETLERÝN TEMÝN EDÝLMESÝ; KULLANIM, VERÝ VEYA KÂR KAYBI; VEYA ÝÞLETME KESÝNTÝSÝ) SORUMLU DEÐÝLDÝR. BU YAZILIMIN KULLANIMIYLA ÝLGÝLÝ OLASI BÖYLE BÝR ZARARIN VARLIÐI KONUSUNDA BÝLGÝLENDÝRÝLMELERÝNE RAÐMEN SÖZLEÞMEYE DAYALI, SIKI SORUMLULUK VEYA HAKSIZ FÝÝL (VEYA BAÞKA BÝR ÞEKÝLDE) TEORÝSÝNE DAYALI HERHANGÝ BÝR SORUMLULUK TEORÝSÝNE GÖRE SORUMLU DEÐÝLDÝR.";

            // Kullanýcýnýn Windows dilini al
            string userLanguage = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

            // Uygun lisans metnini seç
            string licenseText = (userLanguage == "tr") ? licenseText_tr : licenseText_en;

            // Popup penceresi oluþtur
            MessageBox.Show(licenseText, "BSD 3-Clause License", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
