using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu_Updater
{
    public partial class Form1 : Form
    {
        private Thread thrDownload;
        // The stream of data retrieved from the web server
        private Stream strResponse;
        // The stream of data that we write to the harddrive
        private Stream strLocal;
        // The request to the web server for file information
        private HttpWebRequest webRequest;
        // The response from the web server containing information about the file
        private HttpWebResponse webResponse;
        // The progress of the download in percentage
        private static int PercentProgress;
        // The delegate which we will call from the thread to update the form
        private delegate void UpdateProgessCallback(Int64 BytesRead, Int64 TotalBytes);

        public Form1()
        {
            InitializeComponent();
        }
       public string programsürümü;
         string adres = "http://programkontrol.blogspot.com/p/azutka-kelime-bulucu-kontrol.html";
        string indirmelink;
        string programismi;
    
        private void btnDownload_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblYukluSurum.Text += programsürümü;
            string kampanyakontrol;
            WebRequest istek = HttpWebRequest.Create(adres); //2
            WebResponse cevap; //3
            cevap = istek.GetResponse(); //4
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); //5
            string gelen = donenBilgiler.ReadToEnd(); //6
            int KKIndexBaslangici = gelen.IndexOf("ProgramSürümüS/&lt;") + 19;
            int KKIndexBitisi = gelen.Substring(KKIndexBaslangici).IndexOf("&gt;/ProgramSürümüS"); //8
            kampanyakontrol = gelen.Substring(KKIndexBaslangici, KKIndexBitisi);
            if (kampanyakontrol != programsürümü)
            {
                lblSürüm.Text = "Programın Yeni Sürümü(" + kampanyakontrol + ") Mevcut!";
                int KMIndexBaslangici = gelen.IndexOf("ProgramSürümüLink/&lt;") + 22;
                int KMIndexBitisi = gelen.Substring(KMIndexBaslangici).IndexOf("&gt;/ProgramSürümüLink"); //8
                indirmelink = gelen.Substring(KMIndexBaslangici, KMIndexBitisi);
                lblYeniSurum.Text += kampanyakontrol;

                int KZIndexBaslangici = gelen.IndexOf("Programİsmi/&lt;") + 16;
                int KZIndexBitisi = gelen.Substring(KZIndexBaslangici).IndexOf("&gt;/Programİsmi"); //8
                programismi = gelen.Substring(KZIndexBaslangici, KZIndexBitisi);
            }

            else
            {
                lblYeniSurum.Visible = false;
                lblSürüm.Text = "Güncelleme Gerekli Değil & Program Güncel";
               
            }
        }

        private void UpdateProgress(Int64 BytesRead, Int64 TotalBytes)
        {
            // Calculate the download progress in percentages
            PercentProgress = Convert.ToInt32((BytesRead * 100) / TotalBytes);
            // Make progress on the progress bar
            prgDownload.Value = PercentProgress;
            // Display the current progress on the form
            lblProgress.Text = "Güncelleme Durumu :  " + BytesRead / 1024 + " kB / " + TotalBytes / 1024 + " kB" + " (" + PercentProgress + "%)";
            //BytesRead İndirilen ,  TotalBytes toplam , percent Progress %kaç
        }
        string uygulamaismi;
      public string fullpath;
      public string filename;
        public string argstüm;
        public string lisanskeyarg;
        public string isimarg;
        public string lisansdeneme;
        private void Download()
        {
            using (WebClient wcDownload = new WebClient())
            {
                try
                {
                    // Create a request to the file we are downloading
                    webRequest = (HttpWebRequest)WebRequest.Create(indirmelink);
                    // Set default authentication for retrieving the file
                    webRequest.Credentials = CredentialCache.DefaultCredentials;
                    // Retrieve the response from the server
                    webResponse = (HttpWebResponse)webRequest.GetResponse();
                    // Ask the server for the file size and store it
                    Int64 fileSize = webResponse.ContentLength;

                    // Open the URL for download 
                    strResponse = wcDownload.OpenRead(indirmelink);

                    //Çalışan Uygulamanın İsmini Buluyoruz.
                    uygulamaismi = Path.GetFileName(Application.ExecutablePath);

                    // Create a new file stream where we will be saving the data (local drive)
                    strLocal = new FileStream(programismi, FileMode.Create, FileAccess.Write, FileShare.None);

                    // It will store the current number of bytes we retrieved from the server
                    int bytesSize = 0;
                    // A buffer for storing and writing the data retrieved from the server
                    byte[] downBuffer = new byte[2048];

                    // Loop through the buffer until the buffer is empty
                    while ((bytesSize = strResponse.Read(downBuffer, 0, downBuffer.Length)) > 0)
                    {

                        strLocal.Write(downBuffer, 0, bytesSize);

                        this.Invoke(new UpdateProgessCallback(this.UpdateProgress), new object[] { strLocal.Length, fileSize });
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                 
                }

                finally
                {
                    //Programın bulunduğu dizini buluyoruz.
                    //string appPath = Path.GetDirectoryName(Application.ExecutablePath);

                   
                    ////Programın bulunduğu klasörün hangi klasörde olduğunu buluyoruz
                    //FileInfo fi = new FileInfo(appPath);
                    //string appklasor = fi.DirectoryName;
                    //Programın Bulunduğu Klasörün ismini değiştiriyoruz
                    //   Directory.Move(appPath, appklasor + "\\" + programismi);

                    //İşlemleri Kapatıyoruz.


                   





                    strResponse.Close();
                    strLocal.Close();
                    //FileInfo f = new FileInfo(programismi);
                    //f.MoveTo(uygulamaismi);

                    //FileInfo fz = new FileInfo(uygulamaismi);
                    //f.MoveTo(programismi);
                    Process[] p;
                    p = Process.GetProcessesByName(filename);
                    if (p.Length > 0)
                    {
                        foreach (Process process in p)
                        {
                            process.Kill();
                        }
                    }


                  Update(Environment.SpecialFolder.DesktopDirectory,fullpath.Remove(fullpath.IndexOf(filename))+programismi,programismi.Replace(".EXE",""), true);
                    ProcessStartInfo yeniprogram = new ProcessStartInfo();
                    yeniprogram.Arguments = "AzutkaUpdaterAUK98 " + lisanskeyarg + " " + isimarg;
                    yeniprogram.FileName = programismi;
                    Process.Start(yeniprogram);


                    
                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C choice /C Y /N /D Y /T 5 & del \"" + fullpath + "\"";
                    Info.CreateNoWindow = true;
                    Info.FileName = "cmd.exe";
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    //   Info.Verb = "runas";
                    Process.Start(Info);

                    Application.Exit();


                }
            }
        }
        public static void Update(Environment.SpecialFolder folder, string TargetPathName, string LinkPathName, bool install)
        {
            Update(Environment.GetFolderPath(folder), TargetPathName, LinkPathName, install);
        }

        public static void Update(string DirectoryPath, string TargetPathName, string LinkPathName, bool Create)
        {

            DirectoryInfo SpecialDir = new DirectoryInfo(DirectoryPath);

            FileInfo OriginalFile = new FileInfo(LinkPathName);
            string NewFileName = SpecialDir.FullName + "\\" + OriginalFile.Name + ".lnk";
            FileInfo LinkFile = new FileInfo(NewFileName);

            if (Create)
            {
                if (LinkFile.Exists) return;

                try
                {
                    WshShell shell = new WshShell();
                    IWshShortcut link = (IWshShortcut)shell.CreateShortcut(LinkFile.FullName);
                    link.TargetPath = TargetPathName;
                    link.Save();
                }
                catch
                {
                    MessageBox.Show("Masaüstünde Kısayol Oluşturulamadı! " + NewFileName,
                        "Kısayol Oluşturulamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            btnDownload.BackgroundImage = Azutka_Kelime_Bulucu_Updater.Properties.Resources.____Güncelle_over;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            btnDownload.BackgroundImage = Azutka_Kelime_Bulucu_Updater.Properties.Resources.____Güncelle;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lblSürüm.Text != "Güncelleme Gerekli Değil & Program Güncel")
            {
                
            
            if (btnDownload.Tag == "Güncelle")
            {
                lblProgress.Text = "Güncelleme Başlıyor";

                thrDownload = new Thread(Download);

                thrDownload.Start();
            }

            if (btnDownload.Tag == "Durdur")
            {
                webResponse.Close();
                strResponse.Close();
                strLocal.Close();
                thrDownload.Abort();
                prgDownload.Value = 0;
                lblProgress.Text = "Güncelleme İşlemi Durdu!";
            }

            }

            else
            {
                MessageBox.Show("Programınız Zaten Güncel!");
            }
        }
    }
}
