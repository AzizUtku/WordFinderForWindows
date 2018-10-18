using Microsoft.VisualBasic;
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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu
{
    public partial class Form2 : Form
    {
        public Intro baslangic;
        public LisansKontrol lisans;
        public Form1 frm1;
        public Form3 frm3;
        public Form2()
        {
            InitializeComponent();
          

        }
        List<string> Listekelimeler = new List<string>();
        List<string> Liste = new List<string>();
        string HarfJoker;
        int harficeriyormu1;
        int harfne;
        string Harfduzenle;
        string kelimeduzenle;
        string[] Jokerler = { };
        private void listBoxTemizle()
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
                    kelime = "3 " + kelime;
                    Liste.Add(kelime);
                  
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

                    kelime = "4 " + kelime;
                   Liste.Add(kelime);
                   

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

                    kelime = "5 " + kelime;
                    Liste.Add(kelime);

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
                    kelime = "6 " + kelime;
                    Liste.Add(kelime);
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
                    kelime = "7 " + kelime;
                    Liste.Add(kelime);
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
                    kelime = "8 " + kelime;
                    Liste.Add(kelime);
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
                    kelime = "9 " + kelime;
                    Liste.Add(kelime);
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
                    kelime = "10 " + kelime;
                    Liste.Add(kelime);
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
                    kelime = "11 " + kelime;
                    Liste.Add(kelime);
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
                    kelime = "12 " + kelime;
                    Liste.Add(kelime);
                }
            }

            }
            catch (Exception)
            {


            }

        }
        private void KelimeBulJoker(string kelime, int txtharfsayisi, int kelimeuzunlugu)
        {
            try{
            textBox1.Text = textBox1.Text.ToLower();
            Harfduzenle = textBox1.Text;
            HarfJoker = textBox1.Text;
            kelimeduzenle = kelime;
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
               
                    if (harficeriyormu1 >= 2)
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
                                        kelime = "3 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                                //badat --> ba[ğ]dat

                            }



                        }


                    }

                    if (harficeriyormu1 >= 3)
                    {
                        kelime = "3 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "4 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                            }

                        }

                    }

                    if (harficeriyormu1 >= 4)
                    {
                        kelime = "4 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "5 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                            }

                        }

                    }

                    if (harficeriyormu1 >= 5)
                    {
                        kelime = "5 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "6 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                            }

                        }

                    }

                    if (harficeriyormu1 >= 6)
                    {
                        kelime = "6 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "7 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                            }

                        }

                    }
                    if (harficeriyormu1 >= 7)
                    {
                        kelime = "7 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "8 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                            }

                        }
                    }
                    if (harficeriyormu1 >= 8)
                    {
                        kelime = "8 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "9 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }
                            }


                        }
                    }
                    if (harficeriyormu1 >= 9)
                    {
                        kelime = "9 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "10 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                            }

                        }
                    }
                    if (harficeriyormu1 >= 10)
                    {
                        kelime = "10 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "11 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }


                            }
                        }
                    }
                    if (harficeriyormu1 >= 11)
                    {
                        kelime = "11 " + kelime;
                        Liste.Add(kelime);
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
                                        kelime = "12 " + kelime;
                                        Liste.Add(kelime);
                                        i = kelimeuzunlugu + 10;
                                        a = Jokerler.Length + 10;
                                    }


                                }

                            }

                        }

                    }
                    if (harficeriyormu1 >= 12)
                    {
                        kelime = "12 " + kelime;
                        Liste.Add(kelime);
                    }
                
            }

            }
            catch (Exception)
            {


            }

        }

        private void KelimeBulLisanssız(string kelime, int txtharfsayisi, int kelimeuzunlugu)
        {
            try{
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
                   
                        if (Liste.Count % 3 == 0)
                        {
                            kelime = "3 " + kelime;
                            Liste.Add(kelime);
                            
                        }

                        else
                        {

                            kelime = "**" + kelime.Substring(2, 1);
                            kelime = "3 " + kelime;
                            Liste.Add(kelime);
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
                    
                        if (Liste.Count % 3 == 0)
                        {
                            kelime = "4 " + kelime;
                            Liste.Add(kelime);
                           
                        }

                        else
                        {
                            kelime = "*" + kelime.Substring(1, 2) + "*";
                            kelime = "4 " + kelime;
                            Liste.Add(kelime);
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
                    
                        if (Liste.Count % 3 == 0)
                        {
                            kelime = "5 " + kelime;
                            Liste.Add(kelime);
                            
                        }

                        else
                        {
                            kelime = "*" + kelime.Substring(1, 2) + "**";
                            kelime = "5 " + kelime;
                            Liste.Add(kelime);
                           
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
                   
                        if (Liste.Count % 3 == 0)
                        {
                          
                            kelime = "6 " + kelime;
                            Liste.Add(kelime);
                        }

                        else
                        {
                            kelime = "**" + kelime.Substring(2, 2) + "**";
                            kelime = "6 " + kelime;
                            Liste.Add(kelime);
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
                   
                        if (Liste.Count % 3 == 1)
                        {
                          
                            kelime = "7 " + kelime;
                            Liste.Add(kelime);
                        }

                        else
                        {
                            kelime = "**" + kelime.Substring(2, 3) + "**";
                            kelime = "7 " + kelime;
                            Liste.Add(kelime);
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

                    if (Liste.Count % 4 == 3)
                        {
                            
                            kelime = "8 " + kelime;
                            Liste.Add(kelime);
                        }

                        else
                        {
                            kelime = "**" + kelime.Substring(2, 3) + "***";
                            kelime = "8 " + kelime;
                            Liste.Add(kelime);
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

                    if (Liste.Count % 4 == 3)
                        {
                         
                            kelime = "9 " + kelime;
                            Liste.Add(kelime);
                        }

                        else
                        {
                            kelime = "***" + kelime.Substring(3, 3) + "***";
                            kelime = "9 " + kelime;
                            Liste.Add(kelime);
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

                    if (Liste.Count % 4 == 3)
                        {
                            
                            kelime = "10 " + kelime;
                            Liste.Add(kelime);
                        }

                        else
                    {
                        kelime = "***" + kelime.Substring(3, 3) + "****";
                            kelime = "10 " + kelime;
                            Liste.Add(kelime);
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

                    if (Liste.Count % 4 == 3)
                        {
                       
                            kelime = "11 " + kelime;
                            Liste.Add(kelime);
                        }

                        else
                        {
                            kelime = "****" + kelime.Substring(4, 3) + "****";
                            kelime = "11 " + kelime;
                            Liste.Add(kelime);
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

                        if (Liste.Count % 5 == 4)
                        {
                         
                            kelime = "12 " + kelime;
                            Liste.Add(kelime);
                        }

                        else
                        {
                            kelime = "****" + kelime.Substring(4, 4) + "****";
                            kelime = "12 " + kelime;
                            Liste.Add(kelime);
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
            try{
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



                                        if (listBox1.Items.Count % 3 == 0)
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "3 " + kelime;
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                          

                                        }

                                        else
                                        {
                                            kelime = "**" + kelime.Substring(2, 1);
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "3 " + kelime;
                                            Liste.Add(kelime);
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
                        kelime = "3 " + kelime;
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 3 == 0)
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "4 " + kelime;
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                           

                                        }

                                        else
                                        {
                                            kelime = "*" + kelime.Substring(1, 2) + "*";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "4 " + kelime;
                                            Liste.Add(kelime);
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
                        kelime = "4 " + kelime;
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 3 == 0)
                                        {
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "5 " + kelime;
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;
                                        }

                                        else
                                        {
                                            kelime = "*" + kelime.Substring(1, 2) + "**";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "5 " + kelime;
                                            Liste.Add(kelime);
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
                        kelime = "5 " + kelime; 
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 3 == 0)
                                        {
                                           
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "6 " + kelime; 
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "**" + kelime.Substring(2, 2) + "**";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "6 " + kelime; 
                                            Liste.Add(kelime);
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
                        kelime = "6 " + kelime; 
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 3 == 1)
                                        {
                                          
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "7 " + kelime; 
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "**" + kelime.Substring(2, 3) + "**";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "7 " + kelime; 
                                            Liste.Add(kelime);
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
                        kelime = "7 " + kelime; 
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 4 == 3)
                                        {
                                        
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "8 " + kelime; 
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "**" + kelime.Substring(2, 3) + "***";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "8 " + kelime; 
                                            Liste.Add(kelime);
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
                        kelime = "8 " + kelime; 
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 4 == 3)
                                        {
                                       
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "9 " + kelime; 
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "***" + kelime.Substring(3, 3) + "***";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "9 " + kelime; 
                                            Liste.Add(kelime);
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
                        kelime = "9 " + kelime;
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 4 == 3)
                                        {
                                            
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "10 " + kelime; 
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "***" + kelime.Substring(3, 3) + "****";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "10 " + kelime; 
                                            Liste.Add(kelime);
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
                        kelime = "10 " + kelime; 
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 4 == 3)
                                        {
                                           
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "11 " + kelime; 
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "****" + kelime.Substring(4, 3) + "****";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "11 " + kelime; 
                                            Liste.Add(kelime);
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
                        kelime = "11 " + kelime; 
                        Liste.Add(kelime2);
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
                                        if (listBox1.Items.Count % 5 == 4)
                                        {
                                          
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "12 " + kelime; 
                                            Liste.Add(kelime);
                                            i = kelimeuzunlugu + 10;
                                            a = Jokerler.Length + 10;

                                        }

                                        else
                                        {
                                            kelime = "****" + kelime.Substring(4, 4) + "****";
                                            kelime = kelime.Substring(0, i) + "[" + kelime.Substring(i, 1) + "]" + kelime.Substring(i + 1);
                                            kelime = "12 " + kelime; 
                                            Liste.Add(kelime);
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
                        kelime = "12 " + kelime; 
                        Liste.Add(kelime2);
                    }
                
            }

            }
            catch (Exception)
            {


            }

        }
        private void Joker()
        {
            try
            {

                int deger = 0;
                Jokerler = new string[29];
                if (Properties.Settings.Default.Jokerler.IndexOf("(A)") != -1)
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
                if (Properties.Settings.Default.Jokerler.IndexOf("(N)") != -1)
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
     
        private void button1_Click(object sender, EventArgs e)
        {
            
           try{
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            Liste.Clear();
            string kelime;
            // int kelimesayısı;
         //   StreamReader oku = new StreamReader("C:\\Users\\AzizUtku\\Desktop\\Ensonbu.txt", Encoding.GetEncoding("windows-1254"));
            harficeriyormu1 = 0;
            //  kelime = oku.ReadLine();


            #region Lisansliysa
            if (lisanslımı == 8)
            {
                if (checkBoxJoker.Checked == true)
                {
                    for (int i = 0; i < Listekelimeler.Count; i++)
                    {
                        kelime = Listekelimeler[i];
                        int kelimeuzunluguu = Listekelimeler[i].Length;

                        int txtuzunlugu = textBox1.Text.Length;
                        KelimeBulJoker(kelime, txtuzunlugu, kelimeuzunluguu);
                    }
                }

                else
                {
                    for (int i = 0; i < Listekelimeler.Count; i++)
                    {
                        kelime = Listekelimeler[i];
                        int kelimeuzunluguu = Listekelimeler[i].Length;

                        int txtuzunlugu = textBox1.Text.Length;
                        KelimeBul(kelime, txtuzunlugu, kelimeuzunluguu);
                    }
                }
            }
            #endregion 

            #region Lisansli Degilse
            else
            {
                if (checkBoxJoker.Checked == true)
                {
                    for (int i = 0; i < Listekelimeler.Count; i++)
                    {
                        kelime = Listekelimeler[i];
                        int kelimeuzunluguu = Listekelimeler[i].Length;

                        int txtuzunlugu = textBox1.Text.Length;
                        KelimeBulJokerLisanssız(kelime, txtuzunlugu, kelimeuzunluguu);
                    }
                }

                else
                {
                    for (int i = 0; i < Listekelimeler.Count; i++)
                    {
                        kelime = Listekelimeler[i];
                        int kelimeuzunluguu = Listekelimeler[i].Length;

                        int txtuzunlugu = textBox1.Text.Length;
                        KelimeBulLisanssız(kelime, txtuzunlugu, kelimeuzunluguu);
                    }
                }
            }
            #endregion


           

            //while (kelime != null)
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
            Liste.Sort();
            Liste.Reverse();
            listBox1.DataSource = Liste;
            lblSayiHepsi.Text = (listBox1.Items.Count).ToString();
           }
           catch (Exception)
           {


           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
                this.Size=new Size(547,553);
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
                this.Size=new Size(336,553);
        }

   

        private void checkBoxJoker_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (checkBoxJoker.Checked == true)
                {

                   
                  if (Properties.Settings.Default.JokerAyarlar == true)
                    {
                        Properties.Settings.Default.JokerHarfBool = true;
                        Properties.Settings.Default.Save();
                        frm3 = new Form3();
                        frm3.ShowDialog();
                    }

                    Properties.Settings.Default.JokerHarfBool = true;

                }

                else
                {
                    Properties.Settings.Default.JokerHarfBool = false;
                }
                Properties.Settings.Default.Save();
      
            }
            catch (Exception)
            {

              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled =false;
                frm1 = new Form1();
                this.Hide();
                frm1.Show();
            }
            catch (Exception)
            {
                
               
            }
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string k = BasilanTus();
            if (k == "F6")
            {
                try
                {


                    if (checkBox1.Checked==true)
                    {


                       //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                        // SendKeys.Send(listBox1.Items[i].ToString());
                        char[] karakterler = listBox1.Items[0].ToString().Substring(listBox1.Items[0].ToString().IndexOf(" ") + 1).ToCharArray();
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


                    if (checkBox1.Checked==true)
                    {
                       

                        for (int i = 0; i < 10; i++)
                        {
                            if (i < listBox1.Items.Count)
                            {
                                char[] karakterler = listBox1.Items[i].ToString().Substring(listBox1.Items[i].ToString().IndexOf(" ") + 1).ToCharArray();
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

            else if (k == "F8")
            {
                try
                {


                    if (checkBox1.Checked==true)
                    {
                      

                        for (int i = 0; i < 20; i++)
                        {
                            if (i < listBox1.Items.Count)
                            {
                                char[] karakterler = listBox1.Items[i].ToString().Substring(listBox1.Items[i].ToString().IndexOf(" ") + 1).ToCharArray();
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

                    if (checkBox1.Checked==true)
                    {
                      
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            if (i < 2000)
                            {
                                char[] karakterler = listBox1.Items[i].ToString().Substring(listBox1.Items[i].ToString().IndexOf(" ") + 1).ToCharArray();
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
        int listi = -1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (listi<listBox1.Items.Count-1)
            {
                listi++;
                string lististring = listBox1.Items[listi].ToString();
                if (lististring.IndexOf("3") != -1 && lististring.IndexOf("4") != -1 && lististring.IndexOf("5") != -1 && lististring.IndexOf("6") != -1 && lististring.IndexOf("7") != -1 && lististring.IndexOf("8") != -1 && lististring.IndexOf("9") != -1 && lististring.IndexOf("10") != -1 && lististring.IndexOf("11") != -1 && lististring.IndexOf("12") != -1)
                {
                   lististring= listBox1.Items[listi].ToString().Remove(0, 2);
                }
                listBox1.Items[listi].ToString();
                SendKeys.Send(lististring);
            
               
          
            }
           
             
             
             
        }
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
        string serial;
      public  int lisanslımı;
        string harf;
        int uzunluk;
        int harfnumara;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;

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

                //if (Properties.Settings.Default.ProgramKodu == null)
                //{
                //    ManagementClass islemci;
                //    islemci = new ManagementClass("Win32_processor");
                //    foreach (ManagementObject cpu in islemci.GetInstances())
                //    {
                //        islemciSerialNumber = Convert.ToString(cpu["ProcessorID"]);
                //    }


                //    ArrayList hddCollection = new ArrayList();
                //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                //    foreach (ManagementObject disk in searcher.Get())
                //    {
                //        hardDisk hdd = new hardDisk();
                //        hdd.Model = disk["Model"];
                //        hdd.Tip = disk["InterfaceType"];
                //        hddCollection.Add(hdd);
                //    }
                //    int index = 0;
                //    index = 1;

                //    foreach (hardDisk hdd in hddCollection)
                //    {
                //        serial = "AzizUtku" + hdd.Model + islemciSerialNumber ;


                //        ++index;
                //    }
                //    Console.ReadLine();
                //    Properties.Settings.Default.ProgramKodu = serial;
                //    Properties.Settings.Default.Save();
                //}

                serial = Properties.Settings.Default.ProgramKodu;


                //StreamReader lisansskontrol = new StreamReader("LisansKey.txt");

                //string yazi = lisansskontrol.ReadLine();
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
                    // MessageBox.Show("Lisans Onaylandı , Tam Sürüm Olarak Kullanıyorsunuz", "Azutka Kelime Bulucu");
                    label15.Text = "Programınız Lisanslı";
                    this.Text = "Azutka Kelime Bulucu - Normal Arama (Lisanslı Sürüm)";

                    lisanslımı = 8;
                    //      frm1.label15.Text = "Programınız Lisanslı";

                }

                else
                {
                    //    MessageBox.Show("Lisans Numaranız Geçersiz , Deneme Sürümü Olarak Kullanıyorsunuz", "Azutka Kelime Bulucu");
                    label15.Text = "Program Lisanslı Değil";
                    this.Text = "Azutka Kelime Bulucu - Normal Arama (Lisanssız Sürüm)";
                    lisanslımı = 12;
                    //   frm1.label15.Text = "Program Lisanslı Değil";

                }
            }
            catch (Exception)
            {

               
            }
        }
        string islemciSerialNumber;
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                timer3.Enabled = true;
               
                lisans = new LisansKontrol();
                lisans.Show();
            }
            
            
         
            catch (Exception)
            {
                
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label15.Text == "Program Lisanslı Değil" && lisans.label6.Text == "Programınız Lisanslı")
            {
                label15.Text = "Programınız Lisanslı";
                this.Text = "Azutka Kelime Bulucu - Detaylı Arama (Lisanslı Sürüm)";
                lisanslımı = 8;
                timer1.Enabled = false;
            }

            if (lisans.label6.Text == "Program Lisanslı Değil")
            {
                label15.Text = "Program Lisanslı Değil";
                this.Text = "Azutka Kelime Bulucu - Detaylı Arama (Deneme Sürümü)";
                lisanslımı = 12;
                timer1.Enabled = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked==true)
            {
                MessageBox.Show("Öncelikle Kelime Göndermek İstediğiniz Uygulamayı Seçin , Üzerine tıkladığınız kelimeler gönderilir. \n\nKısayollar \nF6 : En Uzun Kelimeyi Gönder \nF7 : İlk 10 Kelimeyi Gönder \nF8 : İlk 20 Kelimeyi Gönder \nF9 : Hepsini Gönder \n\nNot : Kısayollar seçtiğiniz uygulamaya değil , aktif uygulamaya kelime gönderir", "Kelime Gönderici Aktif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                
               

            }

            else
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
            }
        }
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
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

           
            if (checkBox2.Checked==true)
            {
                
            
            Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz

         
            // SendKeys.Send(listBox1.Items[i].ToString());
            char[] karakterler = listBox1.Items[0].ToString().Substring(listBox1.Items[0].ToString().IndexOf(" ") +1).ToCharArray();
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

           
              if (checkBox3.Checked==true)
            {
            Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz

            for (int i = 0; i < 10; i++)
            {
                if (i < listBox1.Items.Count)
                {
                    char[] karakterler = listBox1.Items[i].ToString().Substring(listBox1.Items[i].ToString().IndexOf(" ") + 1).ToCharArray();
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
            this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {


            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

           
            if (checkBox5.Checked==true)
            {
            Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz

            for (int i = 0; i < 20; i++)
            {
                if (i < listBox1.Items.Count)
                {
                    char[] karakterler = listBox1.Items[i].ToString().Substring(listBox1.Items[i].ToString().IndexOf(" ") + 1).ToCharArray();
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
            this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }
            }
            catch (Exception)
            {

               
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

             if (checkBox4.Checked==true)
            {
            Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (i < 2000)
                {
                    char[] karakterler = listBox1.Items[i].ToString().Substring(listBox1.Items[i].ToString().IndexOf(" ") + 1).ToCharArray();
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

            }
            catch (Exception)
            {


            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            try
            {
            Process[] Memory = Process.GetProcesses();
            comboBox1.DataSource = Memory.Where(eleman => (eleman.MainWindowTitle.Length > 0)).ToList();
            comboBox1.DisplayMember = "MainWindowTitle";
            comboBox1.ValueMember = "Id";
            
            }
            catch (Exception)
            {
                
                
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Detaylı_Arama_over2;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Detaylı_Arama2;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Manuel_Joker_over;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Manuel_Joker;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Lisans2;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Lisans_over;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Bul_over;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Bul;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Gizle_over;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Gizle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label17.Text = "Harf Sayısı : " + textBox1.Text.Length;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

           
            if (checkBox1.Checked==true)
            {
                Interaction.AppActivate(Convert.ToInt32(comboBox1.SelectedValue)); //işlem id'sini alarak cmd'yi aktifleştiriyoruz


                // SendKeys.Send(listBox1.Items[i].ToString());

                char[] karakterler = listBox1.SelectedItem.ToString().Substring(listBox1.SelectedItem.ToString().IndexOf(" ") + 1).ToCharArray();
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
                this.Activate(); //uygulamamazı tekrar aktifleştiriyoruz
            }

            }
            catch (Exception)
            {


            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.JokerHarfBool = false;
                Properties.Settings.Default.Save();
            
            frm1 = new Form1();
            this.Hide();
            frm1.Show();
            }
           
             catch (Exception)
            {
                
               
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üreteceği kelimeleri kriterli üretmenizi sağlar. \n\nÜreteceği kelimelerin başı ve sonu sizin belirtiğiniz şekilde olur \n\nÖrneğin Kelime Başı 'nı \"As\" belirttiyseniz ve Karışık Harfler içerisinde RKASE varsa size \"ASKER\" kelimesini üretirken \"KAS\" kelimesini üretmez \n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
              , "Bilgi - Kriterli Kelime Üretme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {
            button16.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Ayarlar_down;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Ayarlar;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.ShowDialog();
        }

     
    }
}
