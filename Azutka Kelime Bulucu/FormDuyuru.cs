using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu
{
    public partial class FormDuyuru : Form
    {
        public Form1 frm1;
        public FormDuyuru2 frm3;
        public Intro frmIntro;
        public FormDuyuru()
        {
            InitializeComponent();
          
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string programsürümü = "2.1";
        public string gelen;
        string adres = "http://programkontrol.blogspot.com/p/azutka-kelime-bulucu-kontrol.html";
        string serial;
        string islemciSerialNumber;
        class hardDisk
        {
            private object model = null;
            private object tip = null;
            private object seriNo = null;
            public object Model
            {
                get
                {
                    return model;
                }
                set
                {
                    model = value;
                }
            }

            public object Tip
            {
                get
                {
                    return tip;
                }
                set
                {
                    tip = value;
                }
            }

            public object SeriNo
            {
                get
                {
                    return seriNo;
                }
                set
                {
                    seriNo = value;
                }
            }
        }

        public static void DisplayHDDInfo()
        {
            ManagementObjectSearcher searchera = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject disk in searchera.Get())
            {
                MessageBox.Show("Model: " + disk["Model"] + disk["InterfaceType:"]);

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try {
                //if (Properties.Settings.Default.GirişDurumu == 0)
                //{
                //    MessageBox.Show("Programınız Kullanıma Kapanmıştır! Niye kapandığını öğrenmek için azutkakelimebulucu@hotmail.com", "Programınız Kilitlendi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    Application.Exit();
                //}
                if (IsConnectedToInternet() == true)
                {
                    
                if (Properties.Settings.Default.ProgramKodu == null)
                {
                    ManagementClass islemci;
                    islemci = new ManagementClass("Win32_processor");
                    foreach (ManagementObject cpu in islemci.GetInstances())
                    {
                        islemciSerialNumber = Convert.ToString(cpu["ProcessorID"]);
                    }


                    ArrayList hddCollection = new ArrayList();
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                    foreach (ManagementObject disk in searcher.Get())
                    {
                        hardDisk hdd = new hardDisk();
                        hdd.Model = disk["Model"];
                        hdd.Tip = disk["InterfaceType"];
                        hddCollection.Add(hdd);
                    }
                    int index = 0;
                    index = 1;

                    foreach (hardDisk hdd in hddCollection)
                    {
                        serial = "AzizUtku" + hdd.Model + islemciSerialNumber ;


                        ++index;
                    }
                    Console.ReadLine();
                    Properties.Settings.Default.ProgramKodu = serial;
                    Properties.Settings.Default.Save();
                }

                serial = Properties.Settings.Default.ProgramKodu;

             
              
            
          
            WebRequest istek = HttpWebRequest.Create(adres); //2
            WebResponse cevap; //3
            cevap = istek.GetResponse(); //4
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); //5
            gelen = donenBilgiler.ReadToEnd(); //6

           
               

            int KKIndexBaslangici = gelen.IndexOf("YöneticiMesaj/&lt;") + 18;
            int KKIndexBitisi = gelen.Substring(KKIndexBaslangici).IndexOf("&gt;/YöneticiMesaj"); //8
          string  kampanyakontrol = gelen.Substring(KKIndexBaslangici, KKIndexBitisi);
            if (kampanyakontrol != null)
            {
                StringDüzenleme(kampanyakontrol);
                lblİcerik.Text = lblİcerik.Text + metinbölümü + "\n\n";
                metinbölümü = "";
            }
          
            int KRIndexBaslangici = gelen.IndexOf("ProgramSürümüS/&lt;") + 19;
            int KRIndexBitisi = gelen.Substring(KKIndexBaslangici).IndexOf("&gt;/ProgramSürümüS"); //8
            string kampanyakontrol2 = gelen.Substring(KRIndexBaslangici,3);
            if (kampanyakontrol2 != programsürümü)
            {
                int KMIndexBaslangici = gelen.IndexOf("ProgramSürümüLink/&lt;") + 22;
                int KMIndexBitisi = gelen.Substring(KMIndexBaslangici).IndexOf("&gt;/ProgramSürümüLink"); //8
                lblİcerik.Text = lblİcerik.Text + "Programın Yeni Sürümü(" + kampanyakontrol2 + ") Mevcut! Hemen İndirmek İçin: " + gelen.Substring(KMIndexBaslangici, KMIndexBitisi) + "\n\n";
                this.Size = new Size(417,382);
               
            }

            else
            {
                lblİcerik.Text += "\n\nProgramınızın Sürümü Güncel !";
            }

            int ProgramKilitIndexi = gelen.IndexOf("ProgramKilit(" + Properties.Settings.Default.ProgramKodu + ");");

            if (ProgramKilitIndexi != -1)
            {
                Properties.Settings.Default.GirişDurumu = 0;
                Properties.Settings.Default.Save();
                MessageBox.Show("Programınız Kullanıma Kapanmıştır! Niye kapandığını öğrenmek için azutkakelimebulucu@hotmail.com", "Programınız Kilitlendi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

            else
            {
                Properties.Settings.Default.GirişDurumu=1;
                Properties.Settings.Default.Save();

            }

                }

                else
                {
                    lblİcerik.Text = "İnternet Bağlantısı Mevcut Değil! Mesajlar alınamıyor";
                }

            }
            catch (Exception ex)
            {
            

            }



        }
        string metinbölümü = "";
        public void StringDüzenleme(string yazı)
        {

            metinbölümü = yazı.Replace("\\n", "\n");
         
        
          
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.az2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.az;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.az3;
        }
        public string link1;
        public string link2;
        public string link3;
        public string link4;
        public string link5;
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (IsConnectedToInternet()==true)
                {
                    
               
                int KKIndexBaslangici = gelen.IndexOf("Haber1Link/&lt;") + 15;
                int KKIndexBitisi = gelen.Substring(KKIndexBaslangici).IndexOf("&gt;/Haber1Link"); //8

                int KEIndexBaslangici = gelen.IndexOf("Haber2Link/&lt;") + 15;
                int KEIndexBitisi = gelen.Substring(KEIndexBaslangici).IndexOf("&gt;/Haber2Link"); //8

                int KRIndexBaslangici = gelen.IndexOf("Haber3Link/&lt;") + 15;
                int KRIndexBitisi = gelen.Substring(KRIndexBaslangici).IndexOf("&gt;/Haber3Link"); //8

                int KTIndexBaslangici = gelen.IndexOf("Haber4Link/&lt;") + 15;
                int KTIndexBitisi = gelen.Substring(KTIndexBaslangici).IndexOf("&gt;/Haber4Link"); //8

                int KYIndexBaslangici = gelen.IndexOf("Haber5Link/&lt;") + 15;
                int KYIndexBitisi = gelen.Substring(KYIndexBaslangici).IndexOf("&gt;/Haber5Link"); //8

                if (gelen.Substring(KKIndexBaslangici, KKIndexBitisi) != null)
                {
                    link1 = gelen.Substring(KKIndexBaslangici, KKIndexBitisi);
                    link2 = gelen.Substring(KEIndexBaslangici, KEIndexBitisi);
                    link3 = gelen.Substring(KRIndexBaslangici, KRIndexBitisi);
                    link4 = gelen.Substring(KTIndexBaslangici, KTIndexBitisi);
                    link5 = gelen.Substring(KYIndexBaslangici, KYIndexBitisi);

                    frm3 = new FormDuyuru2();
                    frm3.frm2 = this;
                    frm3.ShowDialog();
                    this.Close();

                }
                }

            }
            catch (Exception ex)
            {
              
             
            }
         

            
        
        }

        private void lblİcerik_Click(object sender, EventArgs e)
        {

        }
       
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string fullappPath = Path.GetFullPath(Application.ExecutablePath);
                string filename = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
                string lisansarg = Properties.Settings.Default.LisansKey;
                string isimarg = Properties.Settings.Default.Kullaniciİsmi;

                if (isimarg == "")
                {
                    isimarg = "a";
                }
                if (lisansarg == "")
                {
                    lisansarg = "a";
                }
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                //startInfo2.Verb = "runas";
                //startInfo2.CreateNoWindow = false;
                //startInfo2.UseShellExecute = false;
                startInfo2.FileName = "Azutka Kelime Bulucu Updater.exe";
                //startInfo2.WindowStyle = ProcessWindowStyle.Normal;
                startInfo2.Arguments = "AzutkaKelimeBulucuAUK98" + " " + fullappPath.Replace(" ", "$") + " " +
                programsürümü.Replace(" ", "$") + " " + filename.Replace(" ", "$") + " "
                + isimarg.Replace(" ", "$") + " " + lisansarg;



                Process.Start(startInfo2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("\"Azutka Kelime Bulucu Updater.exe\" Bulunamadı ! azutkakelimebulucu.blogspot.com adresinden manuel olarak indirebilirsiniz. \n Azutka Kelime Bulucu ' yu yönetici olarak çalıştırmayı deneyin");
                MessageBox.Show(ex.ToString());
            }
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Güncelle_over;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Güncelle;
        }
    }
}
