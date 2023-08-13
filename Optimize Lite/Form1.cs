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
                string gameId = textBox1.Text; // Counter-Strike: Global Offensive i�in �rnek App ID
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
            Telif Hakk� � 2023 Alperen AKKAYA Kaynak ve ikili bi�imlerdeki da��t�m ve kullan�m, de�i�tirilmi� olsun veya olmas�n, a�a��daki ko�ullar�n yerine getirilmesi kayd�yla izin verilir:

            1. Kaynak kodunun yeniden da��t�m�, yukar�daki telif hakk� bildirimi, bu ko�ullar listesi ve a�a��daki feragatnameyi i�ermelidir.
            2. �kili bi�imde yeniden da��t�m, yukar�daki telif hakk� bildirimi, bu ko�ullar listesi ve a�a��daki feragatnameyi, da��t�lan belge ve/veya di�er materyallerle birlikte �o�altmal�d�r.
            3. Telif hakk� sahibinin ad� veya katk�da bulunanlar�n adlar�, bu yaz�l�mdan t�retilen �r�nleri desteklemek veya tan�tmak i�in �nceden yaz�l� izin al�nmadan kullan�lamaz.

            BU YAZILIM, TEL�F HAKKI SAH�PLER� VE KATKIDA BULUNANLAR TARAFINDAN �OLDU�U G�Bݔ SA�LANMI�TIR VE HERHANG� B�R A�IK VEYA ZIMN� GARANT� VERMEZ. TEL�F HAKKI SAH�PLER� VE KATKIDA BULUNANLAR, BU YAZILIMIN KULLANIMINDAN DO�AN HERHANG� B�R DO�RUDAN, DOLAYLI, TESAD�F�, �ZEL, �RNEK VEYA SONU� OLARAK ORTAYA �IKAN ZARARLARDAN (BUNLARA SINIRLI OLMAKSIZIN YER�NE GET�RME MAL VEYA H�ZMETLER�N TEM�N ED�LMES�; KULLANIM, VER� VEYA K�R KAYBI; VEYA ��LETME KES�NT�S�) SORUMLU DE��LD�R. BU YAZILIMIN KULLANIMIYLA �LG�L� OLASI B�YLE B�R ZARARIN VARLI�I KONUSUNDA B�LG�LEND�R�LMELER�NE RA�MEN S�ZLE�MEYE DAYALI, SIKI SORUMLULUK VEYA HAKSIZ F��L (VEYA BA�KA B�R �EK�LDE) TEOR�S�NE DAYALI HERHANG� B�R SORUMLULUK TEOR�S�NE G�RE SORUMLU DE��LD�R.";

            // Kullan�c�n�n Windows dilini al
            string userLanguage = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

            // Uygun lisans metnini se�
            string licenseText = (userLanguage == "tr") ? licenseText_tr : licenseText_en;

            // Popup penceresi olu�tur
            MessageBox.Show(licenseText, "BSD 3-Clause License", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
