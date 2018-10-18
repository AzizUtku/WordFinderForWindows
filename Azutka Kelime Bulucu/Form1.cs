using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu
{
    public partial class Form1 : Form
    {
        public Intro baslangic;
        public LisansKontrol lisans;
        public Form2 frm2;
        public FormDuyuru formDuyuru;
        public Form3 frm3;
        public Form1()
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
        string programsürüm = "2.1";
        bool m_Drawing = false;
        int m_X1;
        int m_Y1;
        int m_X2;
        int m_Y2;
        Bitmap m_bmDesktop;
        Graphics m_grDesktop;
        List<string> Listekelimeler = new List<string>();
        string HarfJoker;
        int harficeriyormu1;
        int harfne;
        string Harfduzenle;
        string kelimeduzenle;
        string[] Jokerler = { };
        bool kelimeuzunluk3 = false;
        bool kelimeuzunluk4 = false;
        bool kelimeuzunluk5 = false;
        bool kelimeuzunluk6 = false;
        bool kelimeuzunluk7 = false;
        bool kelimeuzunluk8 = false;
        bool kelimeuzunluk9 = false;
        bool kelimeuzunluk10 = false;
        bool kelimeuzunluk11 = false;
        bool kelimeuzunluk12 = false;
        #region Metodlar
        #region "Desktop Capture Routines"

        [DllImport("user32.dll")]
        static extern int GetDesktopWindow();
        [DllImport("user32.dll")]
        static extern int GetDC(int Hwnd);
        [DllImport("gdi32.dll")]
        public static extern int StretchBlt(IntPtr hDc, int x, int y,
            int nWidth, int nHeight, int hSrcDC, int xSrc,
            int ySrc, int nSrcWidth, int nSrcHeight, int dwRop);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(int Hwnd, int hdc);

        private const Int32 SRCCOPY = 0xcc0020;

        private Bitmap DesktopImage()
        {
            int desktop_win = GetDesktopWindow();
            int desktop_dc = GetDC(desktop_win);
            Rectangle desktop_bounds = Screen.GetBounds(new Point(1, 1));
            int desktop_wid = desktop_bounds.Width;
            int desktop_hgt = desktop_bounds.Height;
            Bitmap bm = new Bitmap(desktop_wid, desktop_hgt);
            Graphics bm_gr = Graphics.FromImage(bm);
            IntPtr bm_hdc = bm_gr.GetHdc();
            StretchBlt(bm_hdc, 0, 0, desktop_wid, desktop_hgt, desktop_dc, 0, 0, desktop_wid, desktop_hgt, SRCCOPY);
            bm_gr.ReleaseHdc(bm_hdc);
            ReleaseDC(desktop_win, desktop_dc);
            return bm;
        }





        #endregion
        private void listBoxTemizle()
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            listBox11.Items.Clear();
            listBox12.Items.Clear();
        }
        private void listBoxTumKelimeler()
        {
         
            listBox1.Items.AddRange(listBox12.Items);
            listBox1.Items.AddRange(listBox11.Items);
            listBox1.Items.AddRange(listBox10.Items);
            listBox1.Items.AddRange(listBox9.Items);
            listBox1.Items.AddRange(listBox8.Items);
            listBox1.Items.AddRange(listBox7.Items);
            listBox1.Items.AddRange(listBox6.Items);
            listBox1.Items.AddRange(listBox5.Items);
            listBox1.Items.AddRange(listBox4.Items);
            listBox1.Items.AddRange(listBox3.Items);
        }
        Stopwatch swSure = new Stopwatch();
        private void KelimeBulLisanssız(string kelime, int txtharfsayisi, int kelimeuzunlugu)
        {
            try
            {

           
            textBox1.Text = textBox1.Text.ToLower();
            Harfduzenle = textBox1.Text;
            #region 3 Harfli Kelimeler




            if (kelimeuzunlugu == 3 && txtharfsayisi >= 3)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }


                }

                if (harficeriyormu1 >= 3)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(3)") != -1)
                    {
                        if (listBox3.Items.Count % 3 ==0)
                        {
                            kelime = "**" + kelime.Substring(2, 1);
                            listBox3.Items.Add(kelime);
                        }

                        else
                        {
                        
                          listBox3.Items.Add(kelime);
                        }
                       
                    }
                }
            }


            #endregion
            #region 4 Harfli Kelimeler



            else if (kelimeuzunlugu == 4 && txtharfsayisi >= 4)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 4)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(4)") != -1)
                    {
                        if (listBox4.Items.Count % 3 == 0)
                        {
                            kelime = "*" + kelime.Substring(1, 2) + "*";
                            listBox4.Items.Add(kelime);
                        }

                        else
                        {
                          
                            listBox4.Items.Add(kelime);
                        }

                      
                    }

                }
            }

            #endregion
            #region 5 Harfli Kelimeler
            else if (kelimeuzunlugu == 5 && txtharfsayisi >= 5)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 5)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(5)") != -1)
                    {
                        if (listBox5.Items.Count % 3 == 0)
                        {
                            kelime = "*" + kelime.Substring(1, 2) + "**";
                            listBox5.Items.Add(kelime);
                        }

                        else
                        {
                           
                            listBox5.Items.Add(kelime);
                        }
                    }

                }
            }
            #endregion
            else if (kelimeuzunlugu == 6 && txtharfsayisi >= 6)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 6)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(6)") != -1)
                    {
                        if (listBox6.Items.Count % 3 == 0)
                        {
                           
                            listBox6.Items.Add(kelime);
                        }

                        else
                        {
                            kelime = "**" + kelime.Substring(2, 2) + "**";
                            listBox6.Items.Add(kelime);
                        }
                    }
                }
            }


            else if (kelimeuzunlugu == 7 && txtharfsayisi >= 7)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 7)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(7)") != -1)
                    {
                        if (listBox7.Items.Count % 3 == 1)
                        {
                          
                            listBox7.Items.Add(kelime);
                        }

                        else
                        {
                            kelime = "**" + kelime.Substring(2, 3) + "**";
                            listBox7.Items.Add(kelime);
                        }
                    }
                }
            }

            else if (kelimeuzunlugu == 8 && txtharfsayisi >= 8)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 8)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(8)") != -1)
                    {
                        if (listBox8.Items.Count % 4 == 3)
                        {
                          
                            listBox8.Items.Add(kelime);
                        }

                        else
                        {
                            kelime = "**" + kelime.Substring(2, 3) + "***";
                            listBox8.Items.Add(kelime);
                        }
                    }
                }
            }

            else if (kelimeuzunlugu == 9 && txtharfsayisi >= 9)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 9)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(9)") != -1)
                    {
                        if (listBox9.Items.Count % 4 == 3)
                        {
                          
                            listBox9.Items.Add(kelime);
                        }

                        else
                        {
                            kelime = "***" + kelime.Substring(3, 3) + "***";
                            listBox9.Items.Add(kelime);
                        }
                    }
                }
            }

            else if (kelimeuzunlugu == 10 && txtharfsayisi >= 10)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 10)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(10)") != -1)
                    {
                        if (listBox10.Items.Count % 4 == 3)
                        {
                           
                            listBox10.Items.Add(kelime);
                        }

                        else
                        {
                            kelime = "***" + kelime.Substring(3, 3) + "****";
                            listBox10.Items.Add(kelime);
                        }
                    }
                }
            }

            else if (kelimeuzunlugu == 11 && txtharfsayisi >= 11)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 11)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(11)") != -1)
                    {
                        if (listBox11.Items.Count % 4 == 3)
                        {
                            
                            listBox11.Items.Add(kelime);
                        }

                        else
                        {
                            kelime = "****" + kelime.Substring(4, 3) + "****";
                            listBox11.Items.Add(kelime);
                        }
                    }
                }
            }

            else if (kelimeuzunlugu == 12 && txtharfsayisi >= 12)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }
                }

                if (harficeriyormu1 >= 12)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(12)") != -1)
                    {
                        if (listBox12.Items.Count % 5 == 4)
                        {
                         
                            listBox12.Items.Add(kelime);
                        }

                        else
                        {
                            kelime = "****" + kelime.Substring(4, 4) + "****";
                            listBox12.Items.Add(kelime);
                        }
                    }
                }
            }

            }
            catch (Exception)
            {


            }

        }
        private void KelimeBulJokerLisanssız(string kelime, int txtharfsayisi, int kelimeuzunlugu)
        {
            try {
            textBox1.Text = textBox1.Text.ToLower();
            Harfduzenle = textBox1.Text;
            HarfJoker = textBox1.Text;
            kelimeduzenle = kelime;
            string kelime2 = kelime;
            Joker();







            if (kelimeuzunlugu == 3 && txtharfsayisi >= 2)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }


                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(3)") != -1)
                {
                    if (harficeriyormu1 >= 2)
                    {

                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {
                            //aba --> ab[a]
                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {


                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                       


                                        if (listBox3.Items.Count % 3 == 0)
                                        {
                                            kelime = "**" + kelime.Substring(2, 1);
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox3.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                         
                                          
                                           
                                        }

                                        else
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox3.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                         
                                        }



                                    }


                                }

                            }

                            //   if (HarfJoker.IndexOf(kelime.Substring(i, 1)) == -1)






                        }


                    }

                    if (harficeriyormu1 >= 3)
                    {
                        listBox3.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 4 && txtharfsayisi >= 3)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(4)") != -1)
                {
                    if (harficeriyormu1 >= 3)
                    {

                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {

                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {

                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox4.Items.Count % 3 == 0)
                                        {
                                            kelime = "*" + kelime.Substring(1, 2) + "*";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox4.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                          

                                        }

                                        else
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox4.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                           
                                        }
                                    }


                                }


                            }
                        }

                    }

                    if (harficeriyormu1 >= 4)
                    {
                        listBox4.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 5 && txtharfsayisi >= 4)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);

                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(5)") != -1)
                {
                    if (harficeriyormu1 >= 4)
                    {

                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {


                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {
                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox5.Items.Count % 3 == 0)
                                        {
                                            kelime = "*" + kelime.Substring(1, 2) + "**";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox5.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                          
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox5.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }

                            }

                        }

                    }

                    if (harficeriyormu1 >= 5)
                    {
                        listBox5.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 6 && txtharfsayisi >= 5)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(6)") != -1)
                {
                    if (harficeriyormu1 >= 5)
                    {

                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {

                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {

                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox6.Items.Count % 3 == 0)
                                        {
                                            
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox6.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "**" + kelime.Substring(2, 2) + "**";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox6.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }


                            }
                        }

                    }

                    if (harficeriyormu1 >= 6)
                    {
                        listBox6.Items.Add(kelime2);
                    }
                }
            }



            else if (kelimeuzunlugu == 7 && txtharfsayisi >= 6)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(7)") != -1)
                {
                    if (harficeriyormu1 >= 6)
                    {

                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {
                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {

                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox7.Items.Count % 3 == 1)
                                        {
                                           
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox7.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "**" + kelime.Substring(2, 3) + "**";
                                            
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox7.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }


                            }
                        }

                    }
                    if (harficeriyormu1 >= 7)
                    {
                        listBox7.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 8 && txtharfsayisi >= 7)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(8)") != -1)
                {
                    if (harficeriyormu1 >= 7)
                    {
                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {


                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {
                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox8.Items.Count % 4 == 3)
                                        {
                                          
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox8.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "**" + kelime.Substring(2, 3) + "***";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox8.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }

                            }

                        }
                    }
                    if (harficeriyormu1 >= 8)
                    {
                        listBox8.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 9 && txtharfsayisi >= 8)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(9)") != -1)
                {
                    if (harficeriyormu1 >= 8)
                    {
                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {
                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {

                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox9.Items.Count % 4 == 3)
                                        {
                                         
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox9.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "***" + kelime.Substring(3, 3) + "***";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox9.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }

                            }

                        }
                    }
                    if (harficeriyormu1 >= 9)
                    {
                        listBox9.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 10 && txtharfsayisi >= 9)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(10)") != -1)
                {
                    if (harficeriyormu1 >= 9)
                    {
                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {

                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {

                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox10.Items.Count % 4 == 3)
                                        {
                                           
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox10.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "***" + kelime.Substring(3, 3) + "****";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox10.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }

                            }

                        }
                    }
                    if (harficeriyormu1 >= 10)
                    {
                        listBox10.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 11 && txtharfsayisi >= 10)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(11)") != -1)
                {
                    if (harficeriyormu1 >= 10)
                    {
                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {
                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {

                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox11.Items.Count % 4 == 3)
                                        {
                                         
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox11.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "****" + kelime.Substring(4, 3) + "****";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox11.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }

                            }

                        }
                    }
                    if (harficeriyormu1 >= 11)
                    {
                        listBox11.Items.Add(kelime2);
                    }
                }
            }

            else if (kelimeuzunlugu == 12 && txtharfsayisi >= 11)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }
                }
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(12)") != -1)
                {
                    if (harficeriyormu1 >= 11)
                    {
                        for (int i = 0; i < kelimeuzunlugu; i++)
                        {
                            if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                            {

                                for (int a = 0; a < Jokerler.Length; a++)
                                {
                                    if (kelime.Substring(i, 1) == Jokerler[a])
                                    {
                                        if (listBox12.Items.Count % 5 == 4)
                                        {
                                           
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox12.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "****" + kelime.Substring(4, 4) + "****";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox12.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }
                                    }


                                }

                            }

                        }

                    }
                    if (harficeriyormu1 >= 12)
                    {
                        listBox12.Items.Add(kelime2);
                    }
                }
            }

             }
            catch (Exception)
            {
                
               
            }

        }
        private void KelimeBul(string kelime, int txtharfsayisi, int kelimeuzunlugu)
        {
            try
            {

          
            textBox1.Text = textBox1.Text.ToLower();
            Harfduzenle = textBox1.Text;
            #region 3 Harfli Kelimeler
            
          
         
            
            if (kelimeuzunlugu == 3 && txtharfsayisi >= 3)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }


                }

                if (harficeriyormu1 >= 3)
                {
                    
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(3)") != -1)
                    {
                    listBox3.Items.Add(kelime);
                    }
                }
            }

            
            #endregion
            #region 4 Harfli Kelimeler
          

           
            else if (kelimeuzunlugu == 4 && txtharfsayisi >= 4)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 4)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(4)") != -1)
                    {
                        listBox4.Items.Add(kelime);
                    }
                 
                }
            }

            #endregion
            #region 5 Harfli Kelimeler
            else if (kelimeuzunlugu == 5 && txtharfsayisi >= 5)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 5)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(5)") != -1)
                    {
                        listBox5.Items.Add(kelime);
                    }
                   
                }
            }
            #endregion
            else if (kelimeuzunlugu == 6 && txtharfsayisi >= 6)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 6)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(6)") != -1)
                    {
                        listBox6.Items.Add(kelime);
                    }
                }
            }


            else if (kelimeuzunlugu == 7 && txtharfsayisi >= 7)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 7)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(7)") != -1)
                    {
                        listBox7.Items.Add(kelime);
                    }
                }
            }

            else if (kelimeuzunlugu == 8 && txtharfsayisi >= 8)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 8)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(8)") != -1)
                    {
                        listBox8.Items.Add(kelime);
                    }
                }
            }

            else if (kelimeuzunlugu == 9 && txtharfsayisi >= 9)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 9)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(9)") != -1)
                    {
                        listBox9.Items.Add(kelime);
                    }
                }
            }

            else if (kelimeuzunlugu == 10 && txtharfsayisi >= 10)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 10)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(10)") != -1)
                    {
                        listBox10.Items.Add(kelime);
                    }
                }
            }

            else if (kelimeuzunlugu == 11 && txtharfsayisi >= 11)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }

                }

                if (harficeriyormu1 >= 11)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(11)") != -1)
                    {
                        listBox11.Items.Add(kelime);
                    }
                }
            }

            else if (kelimeuzunlugu == 12 && txtharfsayisi >= 12)
            {
                harficeriyormu1 = 0;

                for (int i = 0; i < kelimeuzunlugu; i++)
                {
                    harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                    if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                    {
                        harficeriyormu1++;
                        Harfduzenle = Harfduzenle.Remove(harfne, 1);
                    }
                }

                if (harficeriyormu1 >= 12)
                {
                    if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(12)") != -1)
                    {
                        listBox12.Items.Add(kelime);
                    }
                }
            }
            }
            catch (Exception)
            {


            }


        }
        private void KelimeBulJoker(string kelime, int txtharfsayisi, int kelimeuzunlugu)
        {
            try
            {


                textBox1.Text = textBox1.Text.ToLower();
                Harfduzenle = textBox1.Text;
                HarfJoker = textBox1.Text;
                kelimeduzenle = kelime;
                string kelime2 = kelime;
                //  Joker();







                if (kelimeuzunlugu == 3 && txtharfsayisi >= 2)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }


                    }
                    if (kelimeuzunluk3)
                    {
                        if (harficeriyormu1 >= 2)
                        {

                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {
                                //aba --> ab[a]
                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {


                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {

                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox3.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }

                                }

                                //   if (HarfJoker.IndexOf(kelime.Substring(i, 1)) == -1)






                            }


                        }

                        if (harficeriyormu1 >= 3)
                        {
                            listBox3.Items.Add(kelime2);
                        }
                    }
                }
                ///---------------------------------------------
                else if (kelimeuzunlugu == 4 && txtharfsayisi >= 3)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }

                    }
                    if (kelimeuzunluk4)
                    {
                        if (harficeriyormu1 >= 3)
                        {

                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {

                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {

                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox4.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }


                                }
                            }

                        }

                        if (harficeriyormu1 >= 4)
                        {
                            listBox4.Items.Add(kelime2);
                        }
                    }
                }

                else if (kelimeuzunlugu == 5 && txtharfsayisi >= 4)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);

                        }

                    }
                    if (kelimeuzunluk5)
                    {
                        if (harficeriyormu1 >= 4)
                        {

                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {


                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {
                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox5.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }

                                }

                            }

                        }

                        if (harficeriyormu1 >= 5)
                        {
                            listBox5.Items.Add(kelime2);
                        }
                    }
                }

                else if (kelimeuzunlugu == 6 && txtharfsayisi >= 5)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }

                    }
                    if (kelimeuzunluk6)
                    {
                        if (harficeriyormu1 >= 5)
                        {

                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {

                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {

                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox6.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }


                                }
                            }

                        }

                        if (harficeriyormu1 >= 6)
                        {
                            listBox6.Items.Add(kelime2);
                        }
                    }
                }



                else if (kelimeuzunlugu == 7 && txtharfsayisi >= 6)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }

                    }
                    if (kelimeuzunluk7)
                    {
                        if (harficeriyormu1 >= 6)
                        {

                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {
                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {

                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox7.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }


                                }
                            }

                        }
                        if (harficeriyormu1 >= 7)
                        {
                            listBox7.Items.Add(kelime2);
                        }
                    }
                }

                else if (kelimeuzunlugu == 8 && txtharfsayisi >= 7)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }

                    }
                    if (kelimeuzunluk8)
                    {
                        if (harficeriyormu1 >= 7)
                        {
                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {


                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {
                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox8.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }

                                }

                            }
                        }
                        if (harficeriyormu1 >= 8)
                        {
                            listBox8.Items.Add(kelime2);
                        }
                    }
                }

                else if (kelimeuzunlugu == 9 && txtharfsayisi >= 8)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }

                    }
                    if (kelimeuzunluk9)
                    {
                        if (harficeriyormu1 >= 8)
                        {
                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {
                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {

                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox9.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }

                                }

                            }
                        }
                        if (harficeriyormu1 >= 9)
                        {
                            listBox9.Items.Add(kelime2);
                        }
                    }
                }

                else if (kelimeuzunlugu == 10 && txtharfsayisi >= 9)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }

                    }
                    if (kelimeuzunluk10)
                    {
                        if (harficeriyormu1 >= 9)
                        {
                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {

                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {

                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox10.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }

                                }

                            }
                        }
                        if (harficeriyormu1 >= 10)
                        {
                            listBox10.Items.Add(kelime2);
                        }
                    }
                }

                else if (kelimeuzunlugu == 11 && txtharfsayisi >= 10)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }

                    }
                    if (kelimeuzunluk11)
                    {
                        if (harficeriyormu1 >= 10)
                        {
                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {
                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {

                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox11.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }

                                }

                            }
                        }
                        if (harficeriyormu1 >= 11)
                        {
                            listBox11.Items.Add(kelime2);
                        }
                    }
                }

                else if (kelimeuzunlugu == 12 && txtharfsayisi >= 11)
                {
                    harficeriyormu1 = 0;

                    for (int i = 0; i < kelimeuzunlugu; i++)
                    {
                        harfne = Harfduzenle.IndexOf(kelime.Substring(i, 1));
                        if (Harfduzenle.IndexOf(kelime.Substring(i, 1)) != -1)
                        {
                            harficeriyormu1++;
                            Harfduzenle = Harfduzenle.Remove(harfne, 1);
                        }
                    }
                    if (kelimeuzunluk12)
                    {
                        if (harficeriyormu1 >= 11)
                        {
                            for (int i = 0; i < kelimeuzunlugu; i++)
                            {
                                if (HarfJoker.Substring(i).IndexOf(kelime.Substring(i, 1)) == -1)
                                {

                                    for (int a = 0; a < Jokerler.Length; a++)
                                    {
                                        if (kelime.Substring(i, 1) == Jokerler[a])
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            listBox12.Items.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }


                                    }

                                }

                            }

                        }
                        if (harficeriyormu1 >= 12)
                        {
                            listBox12.Items.Add(kelime2);
                        }
                    }
                }
            }
            catch (Exception)
            {


            }


        }
        private void KelimeBulBasliSonlu(string kelime, int txtharfsayisi, int kelimeuzunlugu,int checkboxkontrol)
        {
            try
            {
             

                string KelimeBası = txtKBAS.Text;
                string KelimeSonu = txtKSON.Text;
                string ayrikelime = "";
                textBox1.Text = textBox1.Text.ToLower();
               
                int ayrikelimeuzunlugu;
                string kelimekriteri = KelimeBası + KelimeSonu;
                if (checkboxkontrol == 1)
                {
                    Harfduzenle = kelimekutusubasson.ToLower();
                }
                else
                {
                    Harfduzenle = textBox1.Text;
                }

                #region 3 Harfli Kelimeler

                //Bası AZ  , Sonu UZ ,txtbox ads
                // 3 Harfli AZU
    //Şart 1           3  >= KelimeBası.Length+KelimeSonu.Length
                //Şart 2 


                if (kelimeuzunlugu == 3 && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(3)") != -1)
                {

                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);
                
                    if (ayrikelime=="")
                    {
                        listBox3.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }


                        }

                        if (harficeriyormu1 >=ayrikelime.Length)
                        {
                            
                                listBox3.Items.Add(kelime);
                          
                        }
                    }
                    

                   
                }


                #endregion
                #region 4 Harfli Kelimeler



                else if (kelimeuzunlugu == 4 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(4)") != -1)
                {


                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox4.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;


                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                         
                                listBox4.Items.Add(kelime);
                          

                        }
                    }
                }
                    //Araba  a-rab-a
                #endregion
                #region 5 Harfli Kelimeler
                else if (kelimeuzunlugu == 5 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(5)") != -1)
                {
                    
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox5.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                listBox5.Items.Add(kelime);
                          

                        }
                    }
                }
                #endregion
                else if (kelimeuzunlugu == 6 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(6)") != -1)
                {

                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox6.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                         
                                listBox6.Items.Add(kelime);
                           
                        }
                    }
                }

                else if (kelimeuzunlugu == 7 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(7)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox7.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                listBox7.Items.Add(kelime);
                          
                        }
                    }
                }

                else if (kelimeuzunlugu == 8 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(8)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox8.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                         
                                listBox8.Items.Add(kelime);
                           
                        }
                    }
                }

                else if (kelimeuzunlugu == 9 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(9)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox9.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                           
                                listBox9.Items.Add(kelime);
                           
                        }
                    }
                }

                else if (kelimeuzunlugu == 10 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(10)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox10.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                                listBox10.Items.Add(kelime);
                           
                        }
                    }
                }

                else if (kelimeuzunlugu == 11 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(11)") != -1)
                {

                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox11.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                listBox11.Items.Add(kelime);
                          
                        }
                    }
                }

                else if (kelimeuzunlugu == 12 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(12)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        listBox12.Items.Add(kelime);
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }
                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                listBox12.Items.Add(kelime);
                          
                        }
                    }
                }
            }
            catch (Exception)
            {


            }


        }
        private void KelimeBulBasliSonluLisanssız(string kelime, int txtharfsayisi, int kelimeuzunlugu, int checkboxkontrol)
        {
            try
            {


                string KelimeBası = txtKBAS.Text;
                string KelimeSonu = txtKSON.Text;
                string ayrikelime = "";
                textBox1.Text = textBox1.Text.ToLower();

                int ayrikelimeuzunlugu;
                string kelimekriteri = KelimeBası + KelimeSonu;
                if (checkboxkontrol == 1)
                {
                    Harfduzenle = kelimekutusubasson.ToLower();
                }
                else
                {
                    Harfduzenle = textBox1.Text;
                }

                #region 3 Harfli Kelimeler

                //Bası AZ  , Sonu UZ ,txtbox ads
                // 3 Harfli AZU
                //Şart 1           3  >= KelimeBası.Length+KelimeSonu.Length
                //Şart 2 


                if (kelimeuzunlugu == 3 && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(3)") != -1)
                {

                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox3.Items.Count % 3 == 0)
                        {
                            listBox3.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = "**" + kelime.Substring(2, 1);
                            listBox3.Items.Add(kelime);
                        }
                    
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }


                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                           
                                if (listBox3.Items.Count % 3 == 0)
                                {
                                    listBox3.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = "**" + kelime.Substring(2, 1);
                                    listBox3.Items.Add(kelime);
                                }
                            
                        }
                    }



                }


                #endregion
                #region 4 Harfli Kelimeler



                else if (kelimeuzunlugu == 4 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(4)") != -1)
                {


                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox4.Items.Count % 3 == 0)
                        {
                            listBox4.Items.Add(kelime);
                        }
                        else
                        {
                          
                            kelime = kelime.Substring(0, 1) + "**" + kelime.Substring(3,1);
                            listBox4.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;


                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                if (listBox4.Items.Count % 3 == 0)
                                {
                                    listBox4.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 1) + "**" + kelime.Substring(3, 1);
                                    listBox4.Items.Add(kelime);
                                }
                            

                        }
                    }
                }
                //Araba  a-rab-a
                #endregion
                #region 5 Harfli Kelimeler
                else if (kelimeuzunlugu == 5 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(5)") != -1)
                {

                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox5.Items.Count % 3 == 0)
                        {
                            listBox5.Items.Add(kelime);
                        }
                        else
                        {

                            kelime = kelime.Substring(0, 1) + "***" + kelime.Substring(4, 1);
                            listBox5.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                           
                                if (listBox5.Items.Count % 3 == 0)
                                {
                                    listBox5.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 1) + "***" + kelime.Substring(4, 1);
                                    listBox5.Items.Add(kelime);
                                }
                            

                        }
                    }
                }
                #endregion
                else if (kelimeuzunlugu == 6 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(6)") != -1)
                {

                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox6.Items.Count % 3 == 0)
                        {
                            listBox6.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = kelime.Substring(0, 2) + "***" + kelime.Substring(5, 1);
                            listBox6.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                if (listBox6.Items.Count % 3 == 0)
                                {
                                    listBox6.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 2) + "***" + kelime.Substring(5, 1);
                                    listBox6.Items.Add(kelime);
                                }
                            
                        }
                    }
                }

                else if (kelimeuzunlugu == 7 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(7)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox7.Items.Count % 3 == 1)
                        {
                            listBox7.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = kelime.Substring(0, 2) + "****" + kelime.Substring(6, 1);
                            listBox7.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                if (listBox7.Items.Count % 3 == 1)
                                {
                                    listBox7.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 2) + "****" + kelime.Substring(6, 1);
                                    listBox7.Items.Add(kelime);
                                }
                            
                        }
                    }
                }

                else if (kelimeuzunlugu == 8 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(8)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox8.Items.Count % 4 == 3)
                        {
                            listBox8.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = kelime.Substring(0, 2) + "****" + kelime.Substring(6, 2);
                            listBox8.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                           
                                if (listBox8.Items.Count % 4 == 3)
                                {
                                    listBox8.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 2) + "****" + kelime.Substring(6, 2);
                                    listBox8.Items.Add(kelime);
                                }
                            
                        }
                    }
                }

                else if (kelimeuzunlugu == 9 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(9)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox9.Items.Count % 4 == 3)
                        {
                            listBox9.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = kelime.Substring(0, 2) + "*****" + kelime.Substring(7, 2);
                            listBox9.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                            
                                if (listBox9.Items.Count % 4 == 3)
                                {
                                    listBox9.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 2) + "*****" + kelime.Substring(7, 2);
                                    listBox9.Items.Add(kelime);
                                }
                            
                        }
                    }
                }

                else if (kelimeuzunlugu == 10 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(10)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox10.Items.Count % 4 == 3)
                        {
                            listBox10.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = kelime.Substring(0, 2) + "*****" + kelime.Substring(7, 3);
                            listBox10.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                           
                                if (listBox10.Items.Count % 4 == 3)
                                {
                                    listBox10.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 2) + "*****" + kelime.Substring(7, 3);
                                    listBox10.Items.Add(kelime);
                                }
                            
                        }
                    }
                }

                else if (kelimeuzunlugu == 11 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(11)") != -1)
                {

                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox11.Items.Count % 4 == 3)
                        {
                            listBox11.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = kelime.Substring(0, 3) + "*****" + kelime.Substring(7, 3);
                            listBox11.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }

                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                           
                                if (listBox11.Items.Count % 4 == 3)
                                {
                                    listBox11.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 3) + "*****" + kelime.Substring(7, 3);
                                    listBox11.Items.Add(kelime);
                                }
                            
                        }
                    }
                }

                else if (kelimeuzunlugu == 12 && KelimeBası.Length + KelimeSonu.Length + txtharfsayisi >= kelimeuzunlugu && kelimeuzunlugu >= KelimeBası.Length + KelimeSonu.Length && kelime.Substring(0, KelimeBası.Length) == KelimeBası && kelime.Substring(kelime.Length - KelimeSonu.Length) == KelimeSonu && Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(12)") != -1)
                {
                    ayrikelime = kelime.Substring(KelimeBası.Length, kelime.Length - KelimeSonu.Length - KelimeBası.Length);

                    if (ayrikelime == "")
                    {
                        if (listBox12.Items.Count % 4 == 3)
                        {
                            listBox12.Items.Add(kelime);
                        }
                        else
                        {
                            kelime = kelime.Substring(0, 3) + "******" + kelime.Substring(7, 3);
                            listBox12.Items.Add(kelime);
                        }
                    }

                    else
                    {
                        ayrikelimeuzunlugu = ayrikelime.Length;
                        harficeriyormu1 = 0;

                        for (int i = 0; i < ayrikelimeuzunlugu; i++)
                        {
                            harfne = Harfduzenle.IndexOf(ayrikelime.Substring(i, 1));
                            if (Harfduzenle.IndexOf(ayrikelime.Substring(i, 1)) != -1)
                            {
                                harficeriyormu1++;
                                Harfduzenle = Harfduzenle.Remove(harfne, 1);
                            }
                        }

                        if (harficeriyormu1 >= ayrikelime.Length)
                        {
                          
                                if (listBox12.Items.Count % 4 == 3)
                                {
                                    listBox12.Items.Add(kelime);
                                }
                                else
                                {
                                    kelime = kelime.Substring(0, 3) + "******" + kelime.Substring(7, 3);
                                    listBox12.Items.Add(kelime);
                                }
                            
                        }
                    }
                }
            }
            catch (Exception)
            {


            }


        }
        private void Hangiuzunluk()
        {
            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(3)")!=-1)
            {
                kelimeuzunluk3 = true;
            }

            else
            {
                kelimeuzunluk3 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(4)") != -1)
            {
                kelimeuzunluk4 = true;
            }

            else
            {
                kelimeuzunluk4 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(5)") != -1)
            {
                kelimeuzunluk5 = true;
            }

            else
            {
                kelimeuzunluk5 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(6)") != -1)
            {
                kelimeuzunluk6 = true;
            }

            else
            {
                kelimeuzunluk6 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(7)") != -1)
            {
                kelimeuzunluk7 = true;
            }

            else
            {
                kelimeuzunluk7 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(8)") != -1)
            {
                kelimeuzunluk8 = true;
            }

            else
            {
                kelimeuzunluk8 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(9)") != -1)
            {
                kelimeuzunluk9 = true;
            }

            else
            {
                kelimeuzunluk9 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(10)") != -1)
            {
                kelimeuzunluk10 = true;
            }

            else
            {
                kelimeuzunluk10 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(11)") != -1)
            {
                kelimeuzunluk11 = true;
            }

            else
            {
                kelimeuzunluk11 = false;
            }

            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(12)") != -1)
            {
                kelimeuzunluk12 = true;
            }

            else
            {
                kelimeuzunluk12 = false;
            }

            
        }
       
        private void Joker()
        {
            try
            {

                int deger = 0;
                Jokerler = new string[29];
                if (Properties.Settings.Default.Jokerler.IndexOf("(A)")!=-1)
                {

                    Jokerler[deger] = "a";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(B)") != -1)
                {

                    Jokerler[deger] = "b";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(C)") != -1)
                {

                    Jokerler[deger] = "c";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ç)") != -1)
                {

                    Jokerler[deger] = "ç";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(D)") != -1)
                {

                    Jokerler[deger] = "d";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(E)") != -1)
                {

                    Jokerler[deger] = "e";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(F)") != -1)
                {

                    Jokerler[deger] = "f";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(G)") != -1)
                {

                    Jokerler[deger] = "g";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ğ)") != -1)
                {

                    Jokerler[deger] = "ğ";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(H)") != -1)
                {

                    Jokerler[deger] = "h";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(I)") != -1)
                {

                    Jokerler[deger] = "ı";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(İ)") != -1)
                {

                    Jokerler[deger] = "i";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(J)") != -1)
                {

                    Jokerler[deger] = "j";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(K)") != -1)
                {

                    Jokerler[deger] = "k";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(L)") != -1)
                {

                    Jokerler[deger] = "l";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(M)") != -1)
                {

                    Jokerler[deger] = "m";
                    deger++;
                }
                //
                if (Properties.Settings.Default.Jokerler.IndexOf("(N)")!=-1)
                {

                    Jokerler[deger] = "n";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(O)") != -1)
                {

                    Jokerler[deger] = "o";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ö)") != -1)
                {

                    Jokerler[deger] = "ö";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(P)") != -1)
                {

                    Jokerler[deger] = "p";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(R)") != -1)
                {

                    Jokerler[deger] = "r";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(S)") != -1)
                {

                    Jokerler[deger] = "s";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ş)") != -1)
                {

                    Jokerler[deger] = "ş";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(T)") != -1)
                {

                    Jokerler[deger] = "t";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(U)") != -1)
                {

                    Jokerler[deger] = "u";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ü)") != -1)
                {

                    Jokerler[deger] = "ü";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(V)") != -1)
                {

                    Jokerler[deger] = "v";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Y)") != -1)
                {

                    Jokerler[deger] = "y";
                    deger++;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Z)") != -1)
                {

                    Jokerler[deger] = "z";

                }


            }
            catch (Exception)
            {

            }
        }
        string kbsbasson;
        string kelimekutusubasson;
        bool kontrolbasson;
        private void BassonKontrol()
        {
            if (checkBasson.Checked == true && checkBasson.Enabled==true)
            {
                kontrolbasson = true;
                kbsbasson = txtKBAS.Text + txtKSON.Text;
                harficeriyormu1 = 0;
               kelimekutusubasson = textBox1.Text;
                for (int j = 0; j < kbsbasson.Length; j++)
                {

                    harfne = kelimekutusubasson.IndexOf(kbsbasson.Substring(j, 1));
                    if (kelimekutusubasson.IndexOf(kbsbasson.Substring(j, 1)) != -1)
                    {
                        harficeriyormu1++;
                        kelimekutusubasson = kelimekutusubasson.Remove(harfne, 1);
                    }
                }

                if (harficeriyormu1 >= kbsbasson.Length)
                {
                    bassoncheck = true;
                }


                else
                {
                    bassoncheck = false;
                    MessageBox.Show("Eğer \"Başını ve Sonunu Harf Kutusundan Kullan\" İşaretliyse , Kelime'nin Başı ve Sonu Harf Kutusunun İçinde Bulunmalı !","Harf Kutusunda Bulunamadı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                kontrolbasson = false;
                bassoncheck = true;
            }
        }
        #endregion
        bool bassoncheck;
        private void button1_Click(object sender, EventArgs e)
        {
            try{
                
            //*¨F$'nEtDTö"Y£54P[h2K~g^4s0Fp»KlZ2
            listBoxTemizle();
            string kelime;
           
        //    int kelimesayısı;
        
          // StreamReader oku = new StreamReader("C:\\Users\\AzizUtku\\Desktop\\Ensonbu.txt", Encoding.GetEncoding("windows-1254"));
            harficeriyormu1 = 0;
         //  kelime = oku.ReadLine();


            BassonKontrol();


            if (bassoncheck)
            {
                swSure.Reset();
                swSure.Start();


                #region Lisansliysa
                if (lisanslımı == 8)
                {
                    #region Kriterli Üretme Aciksa
                   
                    //Kriterli Üretme Aciksa
                    if (checkBox11.Checked == true && txtKBAS.Text != "" || txtKSON.Text != "")
                    {

                        if (kontrolbasson)
                        {
                            for (int i = 0; i < Listekelimeler.Count; i++)
                            {
                                kelime = Listekelimeler[i].ToString();
                                int kelimeuzunluguu = Listekelimeler[i].Length;
                                int txtuzunlugu = textBox1.Text.Length;
                                KelimeBulBasliSonlu(kelime, txtuzunlugu - kbsbasson.Length, kelimeuzunluguu, 1);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < Listekelimeler.Count; i++)
                            {
                                kelime = Listekelimeler[i].ToString();
                                int kelimeuzunluguu = Listekelimeler[i].Length;
                                int txtuzunlugu = textBox1.Text.Length;
                                KelimeBulBasliSonlu(kelime, txtuzunlugu, kelimeuzunluguu, 0);
                            }
                        }

                    }

                    #endregion

                    #region Açik Değilse
                    else
                    {
                        if (checkBoxJoker.Checked == true)
                        {
                            for (int i = 0; i < Listekelimeler.Count; i++)
                            {
                                kelime = Listekelimeler[i].ToString();
                                int kelimeuzunluguu = Listekelimeler[i].Length;
                                int txtuzunlugu = textBox1.Text.Length;
                                Joker();
                                Hangiuzunluk();
                                KelimeBulJoker(kelime, txtuzunlugu, kelimeuzunluguu);
                            }
                        }

                        else
                        {
                            for (int i = 0; i < Listekelimeler.Count; i++)
                            {
                                kelime = Listekelimeler[i].ToString();
                                int kelimeuzunluguu = Listekelimeler[i].Length;
                                int txtuzunlugu = textBox1.Text.Length;
                                KelimeBul(kelime, txtuzunlugu, kelimeuzunluguu);
                            }
                        }
                    }
                    #endregion
                }
                #endregion

                #region LisansliDegilse
                else
                {
                    #region Kriterli Üretme Aciksa
                    if (checkBox11.Checked == true)
                    {
                        if (txtKBAS.Text != "" || txtKSON.Text != "")
                        {
                            if (kontrolbasson)
                            {
                                for (int i = 0; i < Listekelimeler.Count; i++)
                                {
                                    kelime = Listekelimeler[i].ToString();
                                    int kelimeuzunluguu = Listekelimeler[i].Length;
                                    int txtuzunlugu = textBox1.Text.Length;
                                    KelimeBulBasliSonluLisanssız(kelime, txtuzunlugu - kbsbasson.Length, kelimeuzunluguu, 1);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < Listekelimeler.Count; i++)
                                {
                                    kelime = Listekelimeler[i].ToString();
                                    int kelimeuzunluguu = Listekelimeler[i].Length;
                                    int txtuzunlugu = textBox1.Text.Length;
                                    KelimeBulBasliSonluLisanssız(kelime, txtuzunlugu, kelimeuzunluguu, 0);
                                }
                            }

                        }
                    }
                    #endregion

                    #region Açik Degilse
                      else if (checkBoxJoker.Checked == true)
                    {
                        for (int i = 0; i < Listekelimeler.Count; i++)
                        {
                            kelime = Listekelimeler[i].ToString();
                            int kelimeuzunluguu = Listekelimeler[i].Length;
                            int txtuzunlugu = textBox1.Text.Length;
                            Joker();
                            KelimeBulJokerLisanssız(kelime, txtuzunlugu, kelimeuzunluguu);
                        }
                    }

                    else
                    {
                        for (int i = 0; i < Listekelimeler.Count; i++)
                        {
                            kelime = Listekelimeler[i].ToString();
                            int kelimeuzunluguu = Listekelimeler[i].Length;
                            int txtuzunlugu = textBox1.Text.Length;
                            KelimeBulLisanssız(kelime, txtuzunlugu, kelimeuzunluguu);
                        }
                    }
                    #endregion
                }
                #endregion


            swSure.Stop();

            lblSure.Text = (swSure.ElapsedMilliseconds / 1000).ToString() + " Saniye 'de Buldu!";
          
            if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(TK)") != -1)
            {
                listBoxTumKelimeler();
            }

            label1.Text = "Bulunan Kelime Sayısı : " + (listBox3.Items.Count + listBox4.Items.Count + listBox5.Items.Count + listBox6.Items.Count + listBox7.Items.Count + listBox8.Items.Count + listBox9.Items.Count + listBox10.Items.Count + listBox11.Items.Count + listBox12.Items.Count).ToString();
            lblSayiHepsi.Text = (listBox3.Items.Count + listBox4.Items.Count + listBox5.Items.Count + listBox6.Items.Count + listBox7.Items.Count + listBox8.Items.Count + listBox9.Items.Count + listBox10.Items.Count + listBox11.Items.Count + listBox12.Items.Count).ToString();
            lbl12Sayi.Text = (listBox12.Items.Count).ToString();
            lbl11Sayi.Text = (listBox11.Items.Count).ToString();
            lbl10Sayi.Text = (listBox10.Items.Count).ToString();
            lbl9Sayi.Text = (listBox9.Items.Count).ToString();
            lbl8Sayi.Text = (listBox8.Items.Count).ToString();
            lbl7Sayi.Text = (listBox7.Items.Count).ToString();
            lbl6Sayi.Text = (listBox6.Items.Count).ToString();
            lbl5Sayi.Text = (listBox5.Items.Count).ToString();
            lbl4Sayi.Text = (listBox4.Items.Count).ToString();
            lbl3Sayi.Text = (listBox3.Items.Count).ToString();
            }

            //while (kelime !=null)
            //{
            //    int kelimeuzunluguu = kelime.Length;
            //    int txtuzunlugu = textBox1.Text.Length;
            //    if (lisanslımı == 8)
            //    {

            //        if (checkBoxJoker.Checked == true)
            //        {
            //            KelimeBulJoker(kelime, txtuzunlugu, kelimeuzunluguu);
            //        }

            //        else
            //        {
            //            KelimeBul(kelime, txtuzunlugu, kelimeuzunluguu);
            //        }

            //    }

            //    else
            //    {
            //        if (checkBoxJoker.Checked == true)
            //        {
            //            KelimeBulJokerLisanssız(kelime, txtuzunlugu, kelimeuzunluguu);
            //        }

            //        else
            //        {
            //            KelimeBulLisanssız(kelime, txtuzunlugu, kelimeuzunluguu);
            //        }

            //    }


            //    kelime = oku.ReadLine();
            //}
            //oku.Close();
            //if (checkBox6.Checked == true)
            //{
            //    listBoxTumKelimeler();
            //}
           
            //label1.Text = "Bulunan Kelime Sayısı : " + (listBox3.Items.Count + listBox4.Items.Count +listBox5.Items.Count + listBox6.Items.Count +listBox7.Items.Count + listBox8.Items.Count +listBox9.Items.Count + listBox10.Items.Count + listBox11.Items.Count + listBox12.Items.Count).ToString();
            //lblSayiHepsi.Text = (listBox3.Items.Count + listBox4.Items.Count + listBox5.Items.Count + listBox6.Items.Count + listBox7.Items.Count + listBox8.Items.Count + listBox9.Items.Count + listBox10.Items.Count + listBox11.Items.Count + listBox12.Items.Count).ToString();
            //lbl12Sayi.Text = (listBox12.Items.Count).ToString();
            //lbl11Sayi.Text = (listBox11.Items.Count).ToString();
            //lbl10Sayi.Text = (listBox10.Items.Count).ToString();
            //lbl9Sayi.Text = (listBox9.Items.Count).ToString();
            //lbl8Sayi.Text = (listBox8.Items.Count).ToString();
            //lbl7Sayi.Text = (listBox7.Items.Count).ToString();
            //lbl6Sayi.Text = (listBox6.Items.Count).ToString();
            //lbl5Sayi.Text = (listBox5.Items.Count).ToString();
            //lbl4Sayi.Text = (listBox4.Items.Count).ToString();
            //lbl3Sayi.Text = (listBox3.Items.Count).ToString();
          

        //}
            }
            catch (Exception)
            {


            }
    }
        #region checkBox_Checked

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
           
        }

      

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        //private void checkBox37_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox37.Checked==true)
        //    {
        //        checkBoxA.Checked = true;
        //        checkBoxB.Checked = true;
        //        checkBoxC.Checked = true;
        //        checkBoxÇ.Checked = true;
        //        checkBoxD.Checked = true;
        //        checkBoxE.Checked = true;
        //        checkBoxF.Checked = true;
        //        checkBoxG.Checked = true;
        //        checkBoxĞ.Checked = true;
        //        checkBoxH.Checked = true;
        //        checkBoxI.Checked = true;
        //        checkBoxİ.Checked = true;
        //        checkBoxJ.Checked = true;
        //        checkBoxK.Checked = true;
        //        checkBoxL.Checked = true;
        //        checkBoxM.Checked = true;
        //        checkBoxN.Checked = true;
        //        checkBoxO.Checked = true;
        //        checkBoxÖ.Checked = true;
        //        checkBoxP.Checked = true;
        //        checkBoxR.Checked = true;
        //        checkBoxS.Checked = true;
        //        checkBoxŞ.Checked = true;
        //        checkBoxT.Checked = true;
        //        checkBoxU.Checked = true;
        //        checkBoxÜ.Checked = true;
        //        checkBoxV.Checked = true;
        //        checkBoxY.Checked = true;
        //        checkBoxZ.Checked = true;
      
        //    }

        //    else
        //    {
        //        checkBoxA.Checked = false;
        //        checkBoxB.Checked = false;
        //        checkBoxC.Checked = false;
        //        checkBoxÇ.Checked = false;
        //        checkBoxD.Checked = false;
        //        checkBoxE.Checked = false;
        //        checkBoxF.Checked = false;
        //        checkBoxG.Checked = false;
        //        checkBoxĞ.Checked = false;
        //        checkBoxH.Checked = false;
        //        checkBoxI.Checked = false;
        //        checkBoxİ.Checked = false;
        //        checkBoxJ.Checked = false;
        //        checkBoxK.Checked = false;
        //        checkBoxL.Checked = false;
        //        checkBoxM.Checked = false;
        //        checkBoxN.Checked = false;
        //        checkBoxO.Checked = false;
        //        checkBoxÖ.Checked = false;
        //        checkBoxP.Checked = false;
        //        checkBoxR.Checked = false;
        //        checkBoxS.Checked = false;
        //        checkBoxŞ.Checked = false;
        //        checkBoxT.Checked = false;
        //        checkBoxU.Checked = false;
        //        checkBoxÜ.Checked = false;
        //        checkBoxV.Checked = false;
        //        checkBoxY.Checked = false;
        //        checkBoxZ.Checked = false;
        //    }
        //}

       
        string lisansag;
        string sifreliserial;
        int uzunluk;
        int harfnumara;
        public void HarflerCozumleme(string harf)
        {
            #region Harfler

            if (harf == "h")
            {
                harfnumara = 0;
            }



            else if (harf == "Q")
            {
                harfnumara = 114;
            }

            else if (harf == "W")
            {
                harfnumara = 115;
            }

            else if (harf == "X")
            {
                harfnumara = 116;
            }

            else if (harf == "â")
            {
                harfnumara = 117;
            }

            else if (harf == "ë")
            {
                harfnumara = 118;
            }

            else if (harf == "¥")
            {
                harfnumara = 119;
            }

            else if (harf == "»")
            {
                harfnumara = 111;
            }

            else if (harf == "é")
            {
                harfnumara = 112;
            }

            else if (harf == "ä")
            {
                harfnumara = 113;
            }

            else if (harf == "¼")
            {
                harfnumara = 1;
            }

            else if (harf == "*")
            {
                harfnumara = 2;
            }

            else if (harf == "x")
            {
                harfnumara = 3;
            }

            else if (harf == "U")
            {
                harfnumara = 4;
            }

            else if (harf == "n")
            {
                harfnumara = 5;
            }

            else if (harf == "G")
            {
                harfnumara = 6;
            }

            else if (harf == "£")
            {
                harfnumara = 7;
            }

            else if (harf == "y")
            {
                harfnumara = 8;
            }

            else if (harf == "H")
            {
                harfnumara = 9;
            }

            else if (harf == "M")
            {
                harfnumara = 10;
            }

            else if (harf == "g")
            {
                harfnumara = 11;
            }

            else if (harf == "V")
            {
                harfnumara = 12;
            }

            else if (harf == "@")
            {
                harfnumara = 13;
            }

            else if (harf == "z")
            {
                harfnumara = 14;
            }

            else if (harf == "€")
            {
                harfnumara = 15;
            }

            else if (harf == "s")
            {
                harfnumara = 16;
            }

            else if (harf == "6")
            {
                harfnumara = 17;
            }

            else if (harf == "ß")
            {
                harfnumara = 18;
            }

            else if (harf == "v")
            {
                harfnumara = 19;
            }

            else if (harf == "O")
            {
                harfnumara = 20;
            }

            else if (harf == "a")
            {
                harfnumara = 21;
            }

            else if (harf == "S")
            {
                harfnumara = 22;
            }

            else if (harf == "t")
            {
                harfnumara = 23;
            }

            else if (harf == "Z")
            {
                harfnumara = 24;
            }

            else if (harf == "9")
            {
                harfnumara = 25;
            }

            else if (harf == "L")
            {
                harfnumara = 26;
            }

            else if (harf == "0")
            {
                harfnumara = 27;
            }

            else if (harf == "B")
            {
                harfnumara = 28;
            }

            else if (harf == "w")
            {
                harfnumara = 29;
            }

            else if (harf == "!")
            {
                harfnumara = 30;
            }

            else if (harf == "2")
            {
                harfnumara = 31;
            }

            else if (harf == "E")
            {
                harfnumara = 32;
            }

            else if (harf == "7")
            {
                harfnumara = 33;
            }

            else if (harf == "%")
            {
                harfnumara = 34;
            }

            else if (harf == "c")
            {
                harfnumara = 35;
            }

            else if (harf == "&")
            {
                harfnumara = 36;
            }

            else if (harf == "q")
            {
                harfnumara = 37;
            }

            else if (harf == "C")
            {
                harfnumara = 38;
            }

            else if (harf == "5")
            {
                harfnumara = 39;
            }

            else if (harf == "T")
            {
                harfnumara = 40;
            }

            else if (harf == "3")
            {
                harfnumara = 41;
            }

            else if (harf == "Y")
            {
                harfnumara = 42;
            }

            else if (harf == "r")
            {
                harfnumara = 43;
            }

            else if (harf == "K")
            {
                harfnumara = 44;
            }

            else if (harf == "8")
            {
                harfnumara = 45;
            }

            else if (harf == "?")
            {
                harfnumara = 46;
            }

            else if (harf == "e")
            {
                harfnumara = 47;
            }

            else if (harf == "$")
            {
                harfnumara = 48;
            }

            else if (harf == "ı")
            {
                harfnumara = 49;
            }

            else if (harf == "#")
            {
                harfnumara = 50;
            }

            else if (harf == "R")
            {
                harfnumara = 51;
            }

            else if (harf == "F")
            {
                harfnumara = 52;
            }

            else if (harf == "d")
            {
                harfnumara = 53;
            }

            else if (harf == "P")
            {
                harfnumara = 54;
            }

            else if (harf == "æ")
            {
                harfnumara = 55;
            }

            else if (harf == "N")
            {
                harfnumara = 56;
            }

            else if (harf == "f")
            {
                harfnumara = 57;
            }

            else if (harf == "I")
            {
                harfnumara = 58;
            }

            else if (harf == "b")
            {
                harfnumara = 59;
            }

            else if (harf == "J")
            {
                harfnumara = 60;
            }

            else if (harf == "o")
            {
                harfnumara = 61;
            }

            else if (harf == "D")
            {
                harfnumara = 62;
            }

            else if (harf == "k")
            {
                harfnumara = 63;
            }

            else if (harf == "A")
            {
                harfnumara = 64;
            }

            else if (harf == "j")
            {
                harfnumara = 65;
            }

            else if (harf == "1")
            {
                harfnumara = 66;
            }

            else if (harf == "l")
            {
                harfnumara = 67;
            }

            else if (harf == "p")
            {
                harfnumara = 68;
            }

            else if (harf == "4")
            {
                harfnumara = 69;
            }

            else if (harf == "¤")
            {
                harfnumara = 70;
            }

            else if (harf == "m")
            {
                harfnumara = 71;
            }

            else if (harf == "^")
            {
                harfnumara = 72;
            }

            else if (harf == "(")
            {
                harfnumara = 73;
            }

            else if (harf == "ş")
            {
                harfnumara = 74;
            }

            else if (harf == "-")
            {
                harfnumara = 75;
            }

            else if (harf == "½")
            {
                harfnumara = 76;
            }

            else if (harf == "Ç")
            {
                harfnumara = 77;
            }
            else if (harf == ".")
            {
                harfnumara = 78;
            }

            else if (harf == "[")
            {
                harfnumara = 79;
            }

            else if (harf == "'")
            {
                harfnumara = 80;
            }

            else if (harf == "/")
            {
                harfnumara = 81;
            }

            else if (harf == ")")
            {
                harfnumara = 82;
            }

            else if (harf == ";")
            {
                harfnumara = 83;
            }

            else if (harf == "ç")
            {
                harfnumara = 84;
            }

            else if (harf == "\"")
            {
                harfnumara = 85;
            }


            else if (harf == "ğ")
            {
                harfnumara = 86;
            }

            else if (harf == ":")
            {
                harfnumara = 87;
            }

            else if (harf == "Ş")
            {
                harfnumara = 88;
            }

            else if (harf == "}")
            {
                harfnumara = 89;
            }

            else if (harf == "\\")
            {
                harfnumara = 90;
            }

            else if (harf == "ö")
            {
                harfnumara = 91;
            }

            else if (harf == "ü")
            {
                harfnumara = 92;
            }

            else if (harf == ">")
            {
                harfnumara = 93;
            }

            else if (harf == "Ü")
            {
                harfnumara = 94;
            }

            else if (harf == "Ğ")
            {
                harfnumara = 95;
            }

            else if (harf == "=")
            {
                harfnumara = 96;
            }

            else if (harf == "i")
            {
                harfnumara = 97;
            }

            else if (harf == "<")
            {
                harfnumara = 98;
            }

            else if (harf == "|")
            {
                harfnumara = 99;
            }

            else if (harf == "Ö")
            {
                harfnumara = 100;
            }

            else if (harf == "+")
            {
                harfnumara = 101;
            }

            else if (harf == "İ")
            {
                harfnumara = 102;
            }

            else if (harf == "_")
            {
                harfnumara = 103;
            }

            else if (harf == "~")
            {
                harfnumara = 104;
            }

            else if (harf == "]")
            {
                harfnumara = 105;
            }

            else if (harf == "¨")
            {
                harfnumara = 106;
            }

            else if (harf == "{")
            {
                harfnumara = 107;
            }

            else if (harf == "`")
            {
                harfnumara = 108;
            }

            else if (harf == ",")
            {
                harfnumara = 109;
            }

            else if (harf == "´")
            {
                harfnumara = 110;
            }






            #endregion
        }
        public void HarflerSon(int harfnumarab)
        {
            #region Harfler

            if (harfnumarab == 0)
            {
                harf = "N";
            }

            else if (harfnumarab == 111)
            {
                harf = " ";
            }

            else if (harfnumarab == 112)
            {
                harf = "u";
            }

            else if (harfnumarab == 113)
            {
                harf = "’";
            }



            else if (harfnumarab == 1)
            {
                harf = "h";
            }

            else if (harfnumarab == 2)
            {
                harf = "A";
            }

            else if (harfnumarab == 3)
            {
                harf = "é";
            }

            else if (harfnumarab == 4)
            {
                harf = "O";
            }

            else if (harfnumarab == 5)
            {
                harf = "*";
            }

            else if (harfnumarab == 6)
            {
                harf = "x";
            }

            else if (harfnumarab == 7)
            {
                harf = "E";
            }

            else if (harfnumarab == 8)
            {
                harf = "-";
            }

            else if (harfnumarab == 9)
            {
                harf = "n";
            }

            else if (harfnumarab == 10)
            {
                harf = "R";
            }

            else if (harfnumarab == 11)
            {
                harf = "g";
            }

            else if (harfnumarab == 12)
            {
                harf = "¼";
            }

            else if (harfnumarab == 13)
            {
                harf = "y";
            }

            else if (harfnumarab == 14)
            {
                harf = "Q";
            }

            else if (harfnumarab == 15)
            {
                harf = "ü";
            }

            else if (harfnumarab == 16)
            {
                harf = ",";
            }

            else if (harfnumarab == 17)
            {
                harf = "}";
            }

            else if (harfnumarab == 18)
            {
                harf = "Ğ";
            }

            else if (harfnumarab == 19)
            {
                harf = "W";
            }

            else if (harfnumarab == 20)
            {
                harf = "@";
            }

            else if (harfnumarab == 21)
            {
                harf = "z";
            }

            else if (harfnumarab == 22)
            {
                harf = "V";
            }

            else if (harfnumarab == 23)
            {
                harf = "€";
            }

            else if (harfnumarab == 24)
            {
                harf = "X";
            }

            else if (harfnumarab == 25)
            {
                harf = "M";
            }

            else if (harfnumarab == 26)
            {
                harf = "6";
            }

            else if (harfnumarab == 27)
            {
                harf = "ß";
            }

            else if (harfnumarab == 28)
            {
                harf = "»";
            }

            else if (harfnumarab == 29)
            {
                harf = "v";
            }

            else if (harfnumarab == 30)
            {
                harf = "ä";
            }

            else if (harfnumarab == 31)
            {
                harf = "K";
            }

            else if (harfnumarab == 32)
            {
                harf = "a";
            }

            else if (harfnumarab == 33) //*
            {
                harf = ".";
            }

            else if (harfnumarab == 34)
            {
                harf = "Ş";
            }

            else if (harfnumarab == 35)
            {
                harf = "Ö";
            }

            else if (harfnumarab == 36)
            {
                harf = "t";
            }

            else if (harfnumarab == 37)
            {
                harf = "`";
            }

            else if (harfnumarab == 38)
            {
                harf = "P";
            }

            else if (harfnumarab == 39)
            {
                harf = "9";
            }

            else if (harfnumarab == 40)
            {
                harf = "D";
            }

            else if (harfnumarab == 41)
            {
                harf = "{";
            }

            else if (harfnumarab == 42)
            {
                harf = "0";
            }

            else if (harfnumarab == 43)
            {
                harf = "L";
            }

            else if (harfnumarab == 44)
            {
                harf = "¨";
            }

            else if (harfnumarab == 45)
            {
                harf = "w";
            }

            else if (harfnumarab == 46)
            {
                harf = "!";
            }

            else if (harfnumarab == 47)
            {
                harf = "B";
            }

            else if (harfnumarab == 48)
            {
                harf = "2";
            }

            else if (harfnumarab == 49)
            {
                harf = "'";
            }

            else if (harfnumarab == 50)
            {
                harf = "7";
            }

            else if (harfnumarab == 51)
            {
                harf = "İ";
            }

            else if (harfnumarab == 52)
            {
                harf = "%";
            }

            else if (harfnumarab == 53)
            {
                harf = "F";
            }

            else if (harfnumarab == 54)
            {
                harf = "c";
            }

            else if (harfnumarab == 55)  //*
            {
                harf = "H";
            }

            else if (harfnumarab == 56)
            {
                harf = "&";
            }

            else if (harfnumarab == 57)
            {
                harf = "q";
            }

            else if (harfnumarab == 58)
            {
                harf = "/";
            }

            else if (harfnumarab == 59)
            {
                harf = "5";
            }

            else if (harfnumarab == 60)
            {
                harf = "Ü";
            }

            else if (harfnumarab == 61)
            {
                harf = "^";
            }

            else if (harfnumarab == 62)
            {
                harf = "3";
            }

            else if (harfnumarab == 63)
            {
                harf = "G";
            }

            else if (harfnumarab == 64)
            {
                harf = "(";
            }

            else if (harfnumarab == 65)
            {
                harf = "r";
            }

            else if (harfnumarab == 66)
            {
                harf = "S";
            }

            else if (harfnumarab == 67)
            {
                harf = ">";
            }

            else if (harfnumarab == 68)
            {
                harf = "+";
            }

            else if (harfnumarab == 69)
            {
                harf = "8";
            }

            else if (harfnumarab == 70)
            {
                harf = "?";
            }

            else if (harfnumarab == 71)
            {
                harf = "e";
            }

            else if (harfnumarab == 72)
            {
                harf = "$";
            }

            else if (harfnumarab == 73)
            {
                harf = "T";
            }

            else if (harfnumarab == 74)
            {
                harf = "ı";
            }

            else if (harfnumarab == 75)
            {
                harf = "#";
            }

            else if (harfnumarab == 76)
            {
                harf = "ö";
            }

            else if (harfnumarab == 77)
            {
                harf = "\\";
            }
            else if (harfnumarab == 78)
            {
                harf = "I";
            }

            else if (harfnumarab == 79)
            {
                harf = "d";
            }

            else if (harfnumarab == 80)
            {
                harf = ")";
            }

            else if (harfnumarab == 81)
            {
                harf = "ğ";
            }

            else if (harfnumarab == 82)
            {
                harf = "U";
            }

            else if (harfnumarab == 83)
            {
                harf = "]";
            }

            else if (harfnumarab == 84)
            {
                harf = "ç";
            }

            else if (harfnumarab == 85)
            {
                harf = "½";
            }


            else if (harfnumarab == 86)
            {
                harf = "f";
            }

            else if (harfnumarab == 87)
            {
                harf = "b";
            }

            else if (harfnumarab == 88)
            {
                harf = "|";
            }

            else if (harfnumarab == 89)
            {
                harf = "Y";
            }

            else if (harfnumarab == 90)
            {
                harf = "o";
            }

            else if (harfnumarab == 91)
            {
                harf = "~";
            }

            else if (harfnumarab == 92)
            {
                harf = "k";
            }

            else if (harfnumarab == 93)
            {
                harf = "Ç";
            }

            else if (harfnumarab == 94)
            {
                harf = "j";
            }

            else if (harfnumarab == 95)
            {
                harf = "_";
            }

            else if (harfnumarab == 96)
            {
                harf = "J";
            }

            else if (harfnumarab == 97)
            {
                harf = "1";
            }

            else if (harfnumarab == 98)
            {
                harf = "´";
            }

            else if (harfnumarab == 99)
            {
                harf = "l";
            }

            else if (harfnumarab == 100)
            {
                harf = ":";
            }

            else if (harfnumarab == 101)
            {
                harf = "p";
            }

            else if (harfnumarab == 102)
            {
                harf = "\"";
            }

            else if (harfnumarab == 103)
            {
                harf = "4";
            }

            else if (harfnumarab == 104)
            {
                harf = "=";
            }

            else if (harfnumarab == 105)
            {
                harf = "Z";
            }

            else if (harfnumarab == 106)
            {
                harf = "ü";
            }

            else if (harfnumarab == 107)
            {
                harf = "<";
            }

            else if (harfnumarab == 108)
            {
                harf = "m";
            }

            else if (harfnumarab == 109)
            {
                harf = "æ";
            }

            else if (harfnumarab == 110)
            {
                harf = "i";
            }

            else if (harfnumarab == 114)
            {
                harf = "[";
            }

            else if (harfnumarab == 115)
            {
                harf = "£";
            }

            else if (harfnumarab == 116)
            {
                harf = "ş";
            }

            else if (harfnumarab == 117)
            {
                harf = ";";
            }

            else if (harfnumarab == 118)
            {
                harf = "C";
            }

            else if (harfnumarab == 119)
            {
                harf = "s";
            }





            #endregion
        }
        string serial;
       
        int a = 0;
     
        int kripton;
        string harf;
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
       public int lisanslımı;
        private void Form1_Load(object sender, EventArgs e)
        {
            try{
             
                timer2.Enabled = true;

                #region 55155

                Listekelimeler.Add("şıvgın");
                Listekelimeler.Add("şırıngalamak");
                Listekelimeler.Add("şırıngalama");
                Listekelimeler.Add("şırıngacılık");
                Listekelimeler.Add("şırıngacı");
                Listekelimeler.Add("şırınga");
                Listekelimeler.Add("şırıltı");
                Listekelimeler.Add("şırıldamak");
                Listekelimeler.Add("şırıldama");
                ///...
                Listekelimeler.Add("adana");
                Listekelimeler.Add("adalar");
                Listekelimeler.Add("adaklı");
                Listekelimeler.Add("acıpayam");
                Listekelimeler.Add("acıgöl");
                Listekelimeler.Add("acemleştirme");
                Listekelimeler.Add("acemleşmek");
                Listekelimeler.Add("acemleşme");
                Listekelimeler.Add("acemce");
                Listekelimeler.Add("acem");
                Listekelimeler.Add("acara");
                Listekelimeler.Add("acar");
                Listekelimeler.Add("aborjin");
                Listekelimeler.Add("abhazca");
                Listekelimeler.Add("abhaz");
                Listekelimeler.Add("abdal");
                Listekelimeler.Add("abbas");
                Listekelimeler.Add("abazaca");
                Listekelimeler.Add("abaza");
                Listekelimeler.Add("abana");
                //...
                //For security, wordlist is restricted
                #endregion

                Process[] Memory = Process.GetProcesses();
            comboBox1.DataSource = Memory.Where(eleman => (eleman.MainWindowTitle.Length > 0)).ToList();
            comboBox1.DisplayMember = "MainWindowTitle";
            comboBox1.ValueMember = "Id";
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
          

       //     StreamReader lisansskontrol = new StreamReader("LisansKey.txt");
           
         //   string yazi = lisansskontrol.ReadLine();
            string yazi = Properties.Settings.Default.LisansKey;
            //lisansskontrol.Close();
           
      //      string sifrelisansi = lisans.textBox1.Text;
           

            string sifreliserial = "";
            string sifreli;
           
            int uzunluk = yazi.Length;
            int cozum;

            for (int i = 0; i < uzunluk; i++)
            {
                sifreli = yazi.Substring(i, 1);
                HarflerCozumleme(sifreli);
                cozum = ((((((i + 1) * 997) % 120) + (uzunluk * 7323 + 23)) % 120) - harfnumara) * (-1);
                while (cozum >= 120)
                {
                    cozum = cozum - 120;
                }
                while (cozum < 0)
                {
                    cozum = cozum + 120;
                }
                // devamcozum = (-1) * cozum;22
                HarflerSon(cozum);
                sifreliserial = sifreliserial + harf;
            }
      
            if (serial == sifreliserial)
            {
              //  MessageBox.Show("Lisans Onaylandı , Tam Sürüm Olarak Kullanıyorsunuz", "Azutka Kelime Bulucu");
                label15.Text = "Programınız Lisanslı";
                this.Text = "Azutka Kelime Bulucu - Detaylı Arama (Lisanslı Sürüm)";

                lisanslımı = 8;
                //      frm1.label15.Text = "Programınız Lisanslı";
          
            }

            else
            {
               // MessageBox.Show("Lisans Numaranız Geçersiz , Deneme Sürümü Olarak Kullanıyorsunuz", "Azutka Kelime Bulucu");
                label15.Text = "Program Lisanslı Değil";
                this.Text = "Azutka Kelime Bulucu - Detaylı Arama (Lisanssız Sürüm)";
                lisanslımı = 12;
                //   frm1.label15.Text = "Program Lisanslı Değil";
                
            }
            //SettingsAyarlar();
           

            }
            catch (Exception)
            {


            }
           
            
        }
        //private void SettingsAyarlar()
        //{
        //    if (Properties.Settings.Default.KelimeGönderiktenSonraDur != null)
        //    {
        //        textBox2.Text = Properties.Settings.Default.KelimeGönderiktenSonraDur;
        //    }

        //    if (Properties.Settings.Default.HarfGönderdiktenSonraDur != null)
        //    {
        //        textBox4.Text = Properties.Settings.Default.HarfGönderdiktenSonraDur;
        //    }


        //    if (Properties.Settings.Default.CheckKelimeG == "Checked")
        //    {
        //        checkBox14.Checked = true;
        //    }

        //    if (Properties.Settings.Default.CheckHarfG == "Checked")
        //    {
        //        checkBox13.Checked = true;
        //    }

        //    if (Properties.Settings.Default.BasılacakTus == 1)
        //    {
        //        rdE.Checked = true;
        //    }

        //    else if (Properties.Settings.Default.BasılacakTus == 2)
        //    {
        //        rdEB.Checked = true;
        //    }

        //    else if (Properties.Settings.Default.BasılacakTus == 3)
        //    {
        //        rdES.Checked = true;
        //    }
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                timer2.Enabled = false;
            frm2 = new Form2();
            this.Hide();
            frm2.Show(); 
            }
            catch (Exception)
            {
                
                
            }
        }

        public int ilkacis=0;
        string islemciSerialNumber;

        
    
        

        private void button4_Click(object sender, EventArgs e)
        {
            try{
            timer1.Enabled = true;
            
            lisans = new LisansKontrol();
            lisans.Show();
            }
            catch (Exception)
            {


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label15.Text == "Program Lisanslı Değil" && lisans.label6.Text == "Programınız Lisanslı")
            {
                label15.Text = "Programınız Lisanslı";
                this.Text = "Azutka Kelime Bulucu - Detaylı Arama (Lisanslı Sürüm)";
                lisanslımı = 8;
                timer1.Enabled = false;
            }

            if (label15.Text == "Programınız Lisanslı" && lisans.label6.Text == "Program Lisanslı Değil")
            {
                label15.Text = "Program Lisanslı Değil";
                this.Text = "Azutka Kelime Bulucu - Detaylı Arama (Deneme Sürümü)";
                lisanslımı = 12;
                timer1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items[0].ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }
        #region BasılanTusuYakala
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Int32 deger);

        //Yukarıdaki apiyi kullanarak geriye string döndüren
        //bir method hazırlıyoruz.
        private string BasilanTus()
        {
          
            string tus = null;
            foreach (int item in Enum.GetValues(typeof(Keys)))
            {
                if (GetAsyncKeyState(item) == -32767)
                {
                    tus = Enum.GetName(typeof(Keys), item);
                   
                }
            }
            return tus;
        }
        #endregion
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

         
               if (checkKelimeG.Checked == true)
            {
            Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (i<2000)
                {
                    char[] karakterler = listBox1.Items[i].ToString().ToCharArray();
                    foreach (char karakter in karakterler)
                    {
                        SendKeys.Send(karakter.ToString());
                        if (Properties.Settings.Default.HGSDBool == true)
                        {
                            Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                        }
                    }
                    rdTus(karakterler);

                    if (Properties.Settings.Default.KGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.KelimeGönderiktenSonraDur));
                    }
                }
            
                else
                {
                    MessageBox.Show("Güvenlik Amaçlı En Fazla 2000 Kelime Gönderebilirsiniz.");
                }
               
            
            }
           
            this.Activate();
            }
              else
            {
                MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
            }
            }
            catch (Exception)
            {


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string k = BasilanTus();
            if (k == "F8")
            {


                try
                {
                    if (checkKelimeG.Checked == true)
                    {


                        for (int i = 0; i < 20; i++)
                        {
                            if (i < listBox1.Items.Count)
                            {
                                char[] karakterler = listBox1.Items[i].ToString().ToCharArray();
                                foreach (char karakter in karakterler)
                                {
                                    SendKeys.Send(karakter.ToString());

                                    if (Properties.Settings.Default.HGSDBool == true)
                                    {
                                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                                    }
                                }
                                rdTus(karakterler);
                                //  SendKeys.Send("DirilteİŞĞ");
                                if (Properties.Settings.Default.KGSDBool == true)
                                {
                                    Thread.Sleep(int.Parse(Properties.Settings.Default.KelimeGönderiktenSonraDur));
                                }
                                //Textbox1'deki veriyi gönderiyoruz

                            }
                        }
                        // SendKeys.Send(listBox1.Items[i].ToString());


                    }

                    else
                    {
                        MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
                    }
                }
                catch (Exception)
                {


                }
           
               
          

            }
            else if (k == "F6")
            {

                try
                {
                    if (checkKelimeG.Checked == true)
                    {
                        


                        // SendKeys.Send(listBox1.Items[i].ToString());
                        char[] karakterler = listBox1.Items[0].ToString().ToCharArray();
                        foreach (char karakter in karakterler)
                        {
                            SendKeys.Send(karakter.ToString());
                            if (Properties.Settings.Default.HGSDBool == true)
                            {
                                Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                            }
                        }
                        rdTus(karakterler);
                        //  SendKeys.Send("DirilteİŞĞ");

                        //Textbox1'deki veriyi gönderiyoruz
                       
                    }

                    else
                    {
                        MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
                    }
                }
                catch (Exception)
                {


                }
           
            }

            else if (k == "F7")
            {
                try
                {
                    if (checkKelimeG.Checked == true)
                    {


                        for (int i = 0; i < 10; i++)
                        {
                            if (i < listBox1.Items.Count)
                            {
                                char[] karakterler = listBox1.Items[i].ToString().ToCharArray();
                                foreach (char karakter in karakterler)
                                {
                                    SendKeys.Send(karakter.ToString());
                                    if (Properties.Settings.Default.HGSDBool == true)
                                    {
                                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                                    }
                                }
                                rdTus(karakterler);
                                //  SendKeys.Send("DirilteİŞĞ");
                                if (Properties.Settings.Default.KGSDBool == true)
                                {
                                    Thread.Sleep(int.Parse(Properties.Settings.Default.KelimeGönderiktenSonraDur));
                                }
                                //Textbox1'deki veriyi gönderiyoruz

                            }
                        }
                        // SendKeys.Send(listBox1.Items[i].ToString());


                    }

                    else
                    {
                        MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
                    }
                }
                catch (Exception)
                {


                }
            }

            else if (k == "F9")
            {
                try
                {


                    if (checkKelimeG.Checked == true)
                    {
                       

                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            if (i < 2000)
                            {
                                char[] karakterler = listBox1.Items[i].ToString().ToCharArray();
                                foreach (char karakter in karakterler)
                                {
                                    SendKeys.Send(karakter.ToString());
                                    if (Properties.Settings.Default.HGSDBool == true)
                                    {
                                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                                    }
                                }
                                rdTus(karakterler);
                                if (Properties.Settings.Default.KGSDBool == true)
                                {
                                    Thread.Sleep(int.Parse(Properties.Settings.Default.KelimeGönderiktenSonraDur));
                                }
                            }

                            else
                            {
                                MessageBox.Show("Güvenlik Amaçlı En Fazla 2000 Kelime Gönderebilirsiniz.");
                            }


                        }

                       
                    }
                    else
                    {
                        MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
                    }
                }
                catch (Exception)
                {


                }

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox1.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox12.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
                   }
            catch (Exception)
            {
                
                
            }
        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox11.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
        }
        catch (Exception)
        {


        }
        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox10.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked==true)
            {
            Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


            // SendKeys.Send(listBox1.Items[i].ToString());
            char[] karakterler = listBox9.SelectedItem.ToString().ToCharArray();
            foreach (char karakter in karakterler)
            {
                SendKeys.Send(karakter.ToString());
                if (Properties.Settings.Default.HGSDBool == true)
                {
                    Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                }
            }
            rdTus(karakterler);
            //  SendKeys.Send("DirilteİŞĞ");

            //Textbox1'deki veriyi gönderiyoruz
            this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox8.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{

            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox7.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox6.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox5.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox4.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString()); 
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox3.SelectedItem.ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }
                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }
    //    private void rdTusAsil(char[] kelime)
    //{
    //    if (rdE.Checked==true)
    //    {
    //      SendKeys.Send("{ENTER}");
    //    }

    //    else if (rdEB.Checked == true)
    //    {
    //        SendKeys.Send("{ENTER}");
    //        for (int i = 0; i < kelime.Length; i++)
    //        {
    //            SendKeys.Send("{BS}");
    //        }
    //    }

    //    else if (rdES.Checked == true)
    //    {
    //        SendKeys.Send("{ENTER}");
    //        SendKeys.Send(" ");
    //    }
    //}
        private void rdTus(char[] kelime)
        {
            if (Properties.Settings.Default.BasılacakTus == 1 || Properties.Settings.Default.BasılacakTus == 0)
            {
                SendKeys.Send("{ENTER}");
            }

            else if (Properties.Settings.Default.BasılacakTus == 2)
            {
                SendKeys.Send("{ENTER}");
                for (int i = 0; i < kelime.Length; i++)
                {
                    SendKeys.Send("{BS}");
                }
            }

            else if (Properties.Settings.Default.BasılacakTus == 3)
            {
                SendKeys.Send("{ENTER}");
                SendKeys.Send(" ");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());
                char[] karakterler = listBox1.Items[0].ToString().ToCharArray();
                foreach (char karakter in karakterler)
                {
                    SendKeys.Send(karakter.ToString());
                    if (Properties.Settings.Default.HGSDBool == true)
                    {
                        Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                    }
                }

                rdTus(karakterler);
                //  SendKeys.Send("DirilteİŞĞ");

                //Textbox1'deki veriyi gönderiyoruz
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }

            else
            {
                MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
            }
            }
            catch (Exception)
            {


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz

                for (int i = 0; i < 10; i++)
                {
                    if (i<listBox1.Items.Count)
                    {
                        char[] karakterler = listBox1.Items[i].ToString().ToCharArray();
                        foreach (char karakter in karakterler)
                        {
                           SendKeys.Send(karakter.ToString());
                           if (Properties.Settings.Default.HGSDBool == true)
                           {
                               Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                           }
                        }
                        rdTus(karakterler);

                        if (Properties.Settings.Default.KGSDBool == true)
                        {
                            Thread.Sleep(int.Parse(Properties.Settings.Default.KelimeGönderiktenSonraDur));
                        }
                        //  SendKeys.Send("DirilteİŞĞ");

                        //Textbox1'deki veriyi gönderiyoruz
                      
                    }
                }
                // SendKeys.Send(listBox1.Items[i].ToString());
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
                
            }

            else
            {
                MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
            } }
            catch (Exception)
            {
                
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {try{
            if (checkKelimeG.Checked == true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz

                for (int i = 0; i < 20; i++)
                {
                    if (i < listBox1.Items.Count)
                    {
                        char[] karakterler = listBox1.Items[i].ToString().ToCharArray();
                        foreach (char karakter in karakterler)
                        {
                            SendKeys.Send(karakter.ToString());
                            if (Properties.Settings.Default.HGSDBool == true)
                            {
                                Thread.Sleep(int.Parse(Properties.Settings.Default.HarfGönderdiktenSonraDur));
                            }
                        }
                        rdTus(karakterler);
                        //  SendKeys.Send("DirilteİŞĞ");
                        if (Properties.Settings.Default.KGSDBool == true)
                        {
                            Thread.Sleep(int.Parse(Properties.Settings.Default.KelimeGönderiktenSonraDur));
                        }
                        //Textbox1'deki veriyi gönderiyoruz
                     
                    }
                }
                // SendKeys.Send(listBox1.Items[i].ToString());
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            else
            {
                MessageBox.Show("Kelime Göndericiyi İşaretlemeniz Gerekiyor!");
            }
        }
        catch (Exception)
        {


        }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            try{
            Process[] Memory = Process.GetProcesses();
            comboBox1.DataSource = Memory.Where(eleman => (eleman.MainWindowTitle.Length > 0)).ToList();
            comboBox1.DisplayMember = "MainWindowTitle";
            comboBox1.ValueMember = "Id";
            }
            catch (Exception)
            {


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label17.Text ="Harf Sayısı : " + textBox1.Text.Length;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1bul;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1Bulo;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1lisans;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1lisanso;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1NormalArama;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1NormalAramao;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1En_Uzun_Kelimeyi_Gönder_over;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1En_Uzun_Kelimeyi_Göndero;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            button9.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1İlk_10_Kelimeyi_Gönder;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1İlk_10_Kelimeyi_Göndero;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1İlk_20_Kelimeyi_Gönder_over;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1İlk_20_Kelimeyi_Göndero;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1Hepsini_Gönder_over;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources._1Hepsini_Göndero;
        }

        private void checkKelimeG_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKelimeG.Checked==true)
            {
                Properties.Settings.Default.KelimeGöndericiBool = true;
                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(TK)") != -1)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(TK)";
                }
                this.Size = new Size(1180, 533);
                MessageBox.Show("Öncelikle Kelime Göndermek İstediğiniz Uygulamayı Seçin , Üzerine tıkladığınız kelimeler gönderilir. \n\nKısayollar \nF6 : En Uzun Kelimeyi Gönder \nF7 : İlk 10 Kelimeyi Gönder \nF8 : İlk 20 Kelimeyi Gönder \nF9 : Hepsini Gönder \n\nNot : Kısayollar seçtiğiniz uygulamaya değil , aktif uygulamaya kelime gönderir", "Kelime Gönderici Aktif", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                Properties.Settings.Default.KelimeGöndericiBool = false;
            }

            Properties.Settings.Default.Save();
        
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(888, 533);
         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.JokerHarfBool = false;
            Properties.Settings.Default.Save();
        //    Application.Exit();
            //Properties.Settings.Default.KelimeGönderiktenSonraDur = textBox2.Text;
            //Properties.Settings.Default.HarfGönderdiktenSonraDur = textBox4.Text;
            //Properties.Settings.Default.CheckKelimeG = checkBox14.CheckState.ToString();
            //Properties.Settings.Default.CheckHarfG = checkBox13.CheckState.ToString();
            //if (rdE.Checked==true)
            //{
            //    Properties.Settings.Default.BasılacakTus = 1;
            //}

            //else if (rdEB.Checked==true)
            //{
            //    Properties.Settings.Default.BasılacakTus = 2;
            //}

            //else
            //{
            //    Properties.Settings.Default.BasılacakTus = 3;
            //}
          
            //Properties.Settings.Default.Save();
            Application.ExitThread();

        }

        private void button8_Click_1(object sender, EventArgs e)
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
                programsürüm.Replace(" ", "$") + " " + filename.Replace(" ", "$") + " "
                + isimarg.Replace(" ", "$") + " " + lisansarg.Replace(" ", "$");
               Process.Start(startInfo2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("\"Azutka Kelime Bulucu Updater.exe\" Bulunamadı ! azutkakelimebulucu.blogspot.com adresinden manuel olarak indirebilirsiniz. \n Azutka Kelime Bulucu ' yu yönetici olarak çalıştırmayı deneyin");
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox11.Checked==true)
            {
                if (checkBoxJoker.Checked == true)
                {
                    checkBox11.Checked = false;
                    MessageBox.Show("Joker'li Kelime Açıkken Kelimeyi Kriterli Üretemezsiniz! \nİleriki sürümlerde bu özellik eklenecektir", "Azutka Kelime Bulucu - Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    checkBasson.Enabled = true;
                    txtKBAS.Enabled = true;
                    txtKSON.Enabled = true;
                }
               
            }

            else
            {
                checkBasson.Enabled = false;
                txtKBAS.Enabled = false;
                txtKSON.Enabled = false;
            }
        }

      

        private void lblSure_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Joker Harf Kullan\" işaretlediğinizde Jokerli Kelimeler de üretir \n\nJoker Harfi \"[ ]\" arasında gösterir  \n\nÖrneğin Karışık Harfler içerisinde PKTA varsa ve \"İ\" Joker Harfi seçili ise size K[İ]TAP kelimesini üretir \n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
                ,"Bilgi - Joker Harf",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üreteceği kelimeleri kriterli üretmenizi sağlar. \n\nÜreteceği kelimelerin başı ve sonu sizin belirtiğiniz şekilde olur \n\nÖrneğin Kelime Başı 'nı \"As\" belirttiyseniz ve Karışık Harfler içerisinde RKASE varsa size \"ASKER\" kelimesini üretirken \"KAS\" kelimesini üretmez \n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
               , "Bilgi - Kriterli Kelime Üretme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelimeleri veya harfleri gönderikten sonra belirttiğiniz süre kadar bekler. \n\nKelime gönderirken kelimelerin birbirine girmesini önlemek için yapılmıştır\n\n1000 Milisaniye = 1 Saniye,Örneğin ilk kutuya 500 yazarsanız her kelimeyi gönderdikten sonra yarım saniye bekler\n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
   , "Bilgi - Kelime Gönderdikten Sonra Durma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelimeleri gönderdikten sonra belirttiğiniz tuşa basar \n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
 , "Bilgi - Kelime Gönderdikten Sonra Basılacak Tuş", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Hakkinda frmHak = new Hakkinda();
            frmHak.ShowDialog();
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            button14.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Duyuru_______over;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Duyuru______;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Güncelle_over;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Güncelle;
        }

        private void button15_MouseMove(object sender, MouseEventArgs e)
        {
            button15.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Hakkında_over_1;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Hakkında_1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formDuyuru = new FormDuyuru();
            formDuyuru.frm1 = this;
            formDuyuru.ShowDialog();
        }
        string islemciSerialNumber2;
        string serial2;
        private void timer3_Tick(object sender, EventArgs e)
        {

            if (IsConnectedToInternet()==true)
            {
                
      
        string gelen;
        string adres = "http://programkontrol.blogspot.com/p/azutka-kelime-bulucu-kontrol.html";
        
       

        try
        {

            if (Properties.Settings.Default.ProgramKodu == null)
            {
                ManagementClass islemci;
                islemci = new ManagementClass("Win32_processor");
                foreach (ManagementObject cpu in islemci.GetInstances())
                {
                    islemciSerialNumber2 = Convert.ToString(cpu["ProcessorID"]);
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
                    serial2 = "AzizUtku" + hdd.Model + islemciSerialNumber2 ;


                    ++index;
                }
                Console.ReadLine();
                Properties.Settings.Default.ProgramKodu = serial2;
                Properties.Settings.Default.Save();
            }

            serial2 = Properties.Settings.Default.ProgramKodu;

            WebRequest istek = HttpWebRequest.Create(adres); //2
            WebResponse cevap; //3
            cevap = istek.GetResponse(); //4
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); //5
            gelen = donenBilgiler.ReadToEnd(); //6


            int ProgramKilitIndexi = gelen.IndexOf("ProgramKilit(" + Properties.Settings.Default.ProgramKodu + ")/&lt;");

            if (ProgramKilitIndexi != -1)
            {
                Properties.Settings.Default.GirişDurumu = 0;
                Properties.Settings.Default.Save();
                MessageBox.Show("Programınız Kullanıma Kapanmıştır! Niye kapandığını öğrenmek için azutkakelimebulucu@hotmail.com", "Programınız Kilitlendi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

            else
            {
                Properties.Settings.Default.GirişDurumu = 1;
                Properties.Settings.Default.Save();

            }


                

        }
        catch (Exception ex)
        {


        }

            }
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {
            button16.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Ayarlar_down;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Ayarlar;
        }

        private void rdE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void checkBoxJoker_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJoker.Checked==true)
            {
                
            if (checkBox11.Checked == true)
            {
                checkBoxJoker.Checked = false;
                MessageBox.Show("Kelimeyi Kriterli Üretme Açıkken Joker'li Kelime Üretemezsiniz! \nİleriki sürümlerde bu özellik eklenecektir", "Azutka Kelime Bulucu - Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
           

            else if (Properties.Settings.Default.JokerAyarlar == true)
            {
                Properties.Settings.Default.JokerHarfBool = true;
                Properties.Settings.Default.Save();
                frm3 = new Form3();
                frm3.ShowDialog();
            }
            Properties.Settings.Default.JokerHarfBool = true;
            Properties.Settings.Default.Save();
            }

            else
            {
                Properties.Settings.Default.JokerHarfBool = false;
            }
            Properties.Settings.Default.Save();

        }

        #region
        //private void JokerAsıl()
        //{
        //    try
        //    {

        //        int deger = 0;
        //        Jokerler = new string[29];
        //        if (checkBoxA.Checked == true)
        //        {

        //            Jokerler[deger] = "a";
        //            deger++;
        //        }

        //        if (checkBoxB.Checked == true)
        //        {

        //            Jokerler[deger] = "b";
        //            deger++;
        //        }

        //        if (checkBoxC.Checked == true)
        //        {

        //            Jokerler[deger] = "c";
        //            deger++;
        //        }

        //        if (checkBoxÇ.Checked == true)
        //        {

        //            Jokerler[deger] = "ç";
        //            deger++;
        //        }

        //        if (checkBoxD.Checked == true)
        //        {

        //            Jokerler[deger] = "d";
        //            deger++;
        //        }

        //        if (checkBoxE.Checked == true)
        //        {

        //            Jokerler[deger] = "e";
        //            deger++;
        //        }

        //        if (checkBoxF.Checked == true)
        //        {

        //            Jokerler[deger] = "f";
        //            deger++;
        //        }

        //        if (checkBoxG.Checked == true)
        //        {

        //            Jokerler[deger] = "g";
        //            deger++;
        //        }

        //        if (checkBoxĞ.Checked == true)
        //        {

        //            Jokerler[deger] = "ğ";
        //            deger++;
        //        }

        //        if (checkBoxH.Checked == true)
        //        {

        //            Jokerler[deger] = "h";
        //            deger++;
        //        }

        //        if (checkBoxI.Checked == true)
        //        {

        //            Jokerler[deger] = "ı";
        //            deger++;
        //        }

        //        if (checkBoxİ.Checked == true)
        //        {

        //            Jokerler[deger] = "i";
        //            deger++;
        //        }

        //        if (checkBoxJ.Checked == true)
        //        {

        //            Jokerler[deger] = "j";
        //            deger++;
        //        }

        //        if (checkBoxK.Checked == true)
        //        {

        //            Jokerler[deger] = "k";
        //            deger++;
        //        }

        //        if (checkBoxL.Checked == true)
        //        {

        //            Jokerler[deger] = "l";
        //            deger++;
        //        }

        //        if (checkBoxM.Checked == true)
        //        {

        //            Jokerler[deger] = "m";
        //            deger++;
        //        }
        //        //
        //        if (checkBoxN.Checked == true)
        //        {

        //            Jokerler[deger] = "n";
        //            deger++;
        //        }

        //        if (checkBoxO.Checked == true)
        //        {

        //            Jokerler[deger] = "o";
        //            deger++;
        //        }

        //        if (checkBoxÖ.Checked == true)
        //        {

        //            Jokerler[deger] = "ö";
        //            deger++;
        //        }

        //        if (checkBoxP.Checked == true)
        //        {

        //            Jokerler[deger] = "p";
        //            deger++;
        //        }

        //        if (checkBoxR.Checked == true)
        //        {

        //            Jokerler[deger] = "r";
        //            deger++;
        //        }

        //        if (checkBoxS.Checked == true)
        //        {

        //            Jokerler[deger] = "s";
        //            deger++;
        //        }

        //        if (checkBoxŞ.Checked == true)
        //        {

        //            Jokerler[deger] = "ş";
        //            deger++;
        //        }

        //        if (checkBoxT.Checked == true)
        //        {

        //            Jokerler[deger] = "t";
        //            deger++;
        //        }

        //        if (checkBoxU.Checked == true)
        //        {

        //            Jokerler[deger] = "u";
        //            deger++;
        //        }

        //        if (checkBoxÜ.Checked == true)
        //        {

        //            Jokerler[deger] = "ü";
        //            deger++;
        //        }

        //        if (checkBoxV.Checked == true)
        //        {

        //            Jokerler[deger] = "v";
        //            deger++;
        //        }

        //        if (checkBoxY.Checked == true)
        //        {

        //            Jokerler[deger] = "y";
        //            deger++;
        //        }

        //        if (checkBoxZ.Checked == true)
        //        {

        //            Jokerler[deger] = "z";

        //        }


        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
        #endregion








    }
}


 
            //    basari = 0;
            //textBox1.Text = textBox1.Text.ToLower();
            //Harfduzenle = textBox1.Text;

           

            //for (int i = 0; i < KarakterlerList.Count; i++)
            //{
              

        

            //    kactext = 0;
            //    Regex rgxText = new Regex(KarakterlerList[i].ToString());
            //    foreach (Match match in rgxText.Matches(Harfduzenle))
            //    { kactext++; }

            //    kackelime = 0;
            //    Regex rgxKelime = new Regex(KarakterlerList[i].ToString());
            //    foreach (Match match in rgxKelime.Matches(kelime))
            //    { kackelime++; }



            //    if (kackelime!=0 && kactext >= kackelime)
            //    {
            //        basari++;
            //    }

            //}
            //    // zizasi --> aziz
            //if (basari>=kelime.Length)
            //{
            //    listBox1.Items.Add(kelime);
            //}