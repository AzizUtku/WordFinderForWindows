using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu
{
    public partial class _9luKelime : Form
    {
        public _9luKelime()
        {
            InitializeComponent();
        }

        List<string> Listekelimeler = new List<string>();
        List<string> Listuretilen = new List<string>();
        List<string> Listuretilen2 = new List<string>();
        int harficeriyormu1;
        int harfne;
        string Harfduzenle;
        string kelimeduzenle;
        int txtboxint1;
        int txtboxint2;
        int txtboxint3;
        int txtboxint4;
        int txtboxint5;
        int txtboxint6;
        int txtboxint7;
        int txtboxint8;
        int txtboxint9;
        int txtboxint10;
        int txtboxint11;
        int txtboxint12;
        int txtboxint13;
        int txtboxint14;
        int txtboxint15;
        int txtboxint16;
        string txtboxstring1 = "unlock";
        string txtboxstring2 = "unlock";
        string txtboxstring3 = "unlock";
        string txtboxstring4 = "unlock";
        string txtboxstring5 = "unlock";
        string txtboxstring6 = "unlock";
        string txtboxstring7 = "unlock";
        string txtboxstring8 = "unlock";
        string txtboxstring9 = "unlock";
        string txtboxstring10 = "unlock";
        string txtboxstring11 = "unlock";
        string txtboxstring12 = "unlock";
        string txtboxstring13 = "unlock";
        string txtboxstring14 = "unlock";
        string txtboxstring15 = "unlock";
        string txtboxstring16 = "unlock";
        string txtboxkontrol1 = "open";
        string txtboxkontrol2 = "open";
        string txtboxkontrol3 = "open";
        string txtboxkontrol4 = "open";
        string txtboxkontrol5 = "open";
        string txtboxkontrol6 = "open";
        string txtboxkontrol7 = "open";
        string txtboxkontrol8 = "open";
        string txtboxkontrol9 = "open";
        string txtboxkontrol10 = "open";
        string txtboxkontrol11 = "open";
        string txtboxkontrol12 = "open";
        string txtboxkontrol13 = "open";
        string txtboxkontrol14 = "open";
        string txtboxkontrol15 = "open";
        string txtboxkontrol16 = "open";
        int aziz;

        private void KelimeBul(string kelime, int txtharfsayisi, int kelimeuzunlugu)
        {
            string toplamkelime;

            string txtbox1 =textBox1.Text;
            string txtbox2 =textBox2.Text;
            string txtbox3 =textBox3.Text;
            string txtbox4 =textBox4.Text;
            string txtbox5 =textBox5.Text;
            string txtbox6 =textBox6.Text;
            string txtbox7 =textBox7.Text;
            string txtbox8 =textBox8.Text;
            string txtbox9 =textBox9.Text;
            string txtbox10 =textBox10.Text;
            string txtbox11 =textBox11.Text;
            string txtbox12 =textBox12.Text;
            string txtbox13 =textBox13.Text;
            string txtbox14 =textBox14.Text;
            string txtbox15 =textBox15.Text;
            string txtbox16 =textBox16.Text;
          
             string kelime1 =  txtbox1+txtbox2;
             string kelime2 =  txtbox1+txtbox5;
             string kelime3 =  txtbox1+txtbox6;
			

/*
            1 --> 2,5,6
            2 --> 1,3,5,6,7
            3 --> 2,4,6,7,8
            4 --> 3,7,8
            5 --> 1,2,6,9,10
            6 --> 1,2,3,5,7,9,10,11
            7 --> 2,3,4,6,8,10,11,12
            8 --> 1,3,5,6,7
            9 --> 5,6,10,13,14
            10 --> 5,6,7,9,11,13,14,15
            11 --> 6,7,8,10,12,14,15,16
            12 --> 7,8,11,15,16
            13 --> 9,10,14
            14 --> 9,10,11,13,15
            15 --> 10,11,12,14,16
            16 --> 11,12,15
*/

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
                    
                    listBox1.Items.Add(kelime);
                    
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
                    
                        listBox1.Items.Add(kelime);
                  
                 
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
                   
                        listBox1.Items.Add(kelime);
                    
                   
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
                  
                      listBox1.Items.Add(kelime);
                    
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
                   
                        listBox1.Items.Add(kelime);
                    
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
                  
                        listBox1.Items.Add(kelime);
                    
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
                  
                        listBox1.Items.Add(kelime);
                   
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
                  
                        listBox1.Items.Add(kelime);
                   
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
                   
                        listBox1.Items.Add(kelime);
                    
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
                   
                        listBox1.Items.Add(kelime);
                   
                }
            }



        }

        private void KelimeUret1(string kelime)
        {
            if (txtboxkontrol1=="open")
            {
                if (Listuretilen.Count<32000)
                {
                    txtboxkontrol1 = "close";

                    kelime = kelime + textBox1.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }

                    }

                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }


                    KelimeUret2(kelime);
                    KelimeUret5(kelime);
                    KelimeUret6(kelime);

                }

                else
                {
                    txtboxkontrol1 = "close";

                    kelime = kelime + textBox1.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen2.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }

                    }

                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }


                    KelimeUret2(kelime);
                    KelimeUret5(kelime);
                    KelimeUret6(kelime);

                }
           
            }
        }

        private void KelimeUret2(string kelime)
        {
            if (txtboxkontrol2 == "open")
            {
                if (Listuretilen.Count<30000)
                {
                    
               

                txtboxkontrol2 = "close";

                kelime = kelime + textBox2.Text;
                if (kelime.Length > 2 && kelime.Length < 13)
                {
                    bool sonuc;
                    sonuc = Listuretilen.Contains(kelime);
                    if (sonuc == false)
                    {
                        Listuretilen.Add(kelime);
                    }
                }

                if (kelime.Length > 12)
                {
                    kelime = "";
                    txtOpen();
                }


                KelimeUret1(kelime);
                KelimeUret3(kelime);
                KelimeUret5(kelime);
                KelimeUret6(kelime);
                KelimeUret7(kelime);

            }
            }
        }

        private void KelimeUret3(string kelime)
        {
            if (txtboxkontrol3 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol3 = "close";

                    kelime = kelime + textBox3.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }

                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret2(kelime);
                    KelimeUret4(kelime);
                    KelimeUret6(kelime);
                    KelimeUret7(kelime);
                    KelimeUret8(kelime);

                }
            }
        }

        private void KelimeUret4(string kelime)
        {
            if (txtboxkontrol4 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol4 = "close";

                    kelime = kelime + textBox4.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }

                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }
                    KelimeUret3(kelime);
                    KelimeUret7(kelime);
                    KelimeUret8(kelime);

                }
            }
        }

        private void KelimeUret5(string kelime)
        {
            if (txtboxkontrol5 == "open")
            {
                if (Listuretilen.Count < 30000)
                {

                    txtboxkontrol5 = "close";

                    kelime = kelime + textBox5.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret1(kelime);
                    KelimeUret2(kelime);
                    KelimeUret6(kelime);
                    KelimeUret9(kelime);
                    KelimeUret10(kelime);

                }
            }
        }

        private void KelimeUret6(string kelime)
        {
            if (txtboxkontrol6 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol6 = "close";

                    kelime = kelime + textBox6.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }

                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }
                    KelimeUret1(kelime);
                    KelimeUret2(kelime);
                    KelimeUret3(kelime);
                    KelimeUret5(kelime);
                    KelimeUret7(kelime);
                    KelimeUret9(kelime);
                    KelimeUret10(kelime);
                    KelimeUret11(kelime);

                }
            }
        }
        private void KelimeUret7(string kelime)
        {
            if (txtboxkontrol7 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol7 = "close";

                    kelime = kelime + textBox7.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret2(kelime);
                    KelimeUret3(kelime);
                    KelimeUret4(kelime);
                    KelimeUret6(kelime);
                    KelimeUret8(kelime);
                    KelimeUret10(kelime);
                    KelimeUret11(kelime);
                    KelimeUret12(kelime);

                }
            }
        }

        private void KelimeUret8(string kelime)
        {
            if (txtboxkontrol8 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol8 = "close";

                    kelime = kelime + textBox8.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }

                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }
                    KelimeUret1(kelime);
                    KelimeUret3(kelime);
                    KelimeUret5(kelime);
                    KelimeUret6(kelime);
                    KelimeUret7(kelime);
                }

            }
        }

        private void KelimeUret9(string kelime)
        {
            if (txtboxkontrol9 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol9 = "close";

                    kelime = kelime + textBox9.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret5(kelime);
                    KelimeUret6(kelime);
                    KelimeUret10(kelime);
                    KelimeUret13(kelime);
                    KelimeUret14(kelime);


                }
            }
        }

        private void KelimeUret10(string kelime)
        {
            if (txtboxkontrol10 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol10 = "close";

                    kelime = kelime + textBox10.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret5(kelime);
                    KelimeUret6(kelime);
                    KelimeUret7(kelime);
                    KelimeUret9(kelime);
                    KelimeUret11(kelime);
                    KelimeUret13(kelime);
                    KelimeUret14(kelime);
                    KelimeUret15(kelime);

                }
            }
        }

        private void KelimeUret11(string kelime)
        {
            if (txtboxkontrol11 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol11 = "close";

                    kelime = kelime + textBox11.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret6(kelime);
                    KelimeUret7(kelime);
                    KelimeUret8(kelime);
                    KelimeUret10(kelime);
                    KelimeUret12(kelime);
                    KelimeUret14(kelime);
                    KelimeUret15(kelime);
                    KelimeUret16(kelime);
                }
            }
        }

        private void KelimeUret12(string kelime)
        {
            if (txtboxkontrol12 == "open")
            {
                if (Listuretilen.Count < 30000)
                {

                    txtboxkontrol12 = "close";

                    kelime = kelime + textBox12.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret7(kelime);
                    KelimeUret8(kelime);
                    KelimeUret11(kelime);
                    KelimeUret15(kelime);
                    KelimeUret16(kelime);

                }
            }
        }

        private void KelimeUret13(string kelime)
        {
            if (txtboxkontrol13 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol13 = "close";

                    kelime = kelime + textBox13.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret9(kelime);
                    KelimeUret10(kelime);
                    KelimeUret14(kelime);

                }

            }
        }

        private void KelimeUret14(string kelime)
        {
            if (txtboxkontrol14 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol14 = "close";

                    kelime = kelime + textBox14.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret9(kelime);
                    KelimeUret10(kelime);
                    KelimeUret11(kelime);
                    KelimeUret13(kelime);
                    KelimeUret15(kelime);
                }

            }
        }

        private void KelimeUret15(string kelime)
        {
            if (txtboxkontrol15 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol15 = "close";

                    kelime = kelime + textBox15.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret10(kelime);
                    KelimeUret11(kelime);
                    KelimeUret12(kelime);
                    KelimeUret14(kelime);
                    KelimeUret16(kelime);

                }
            }
        }

        private void KelimeUret16(string kelime)
        {
            if (txtboxkontrol16 == "open")
            {
                if (Listuretilen.Count < 30000)
                {
                    txtboxkontrol16 = "close";

                    kelime = kelime + textBox16.Text;
                    if (kelime.Length > 2 && kelime.Length < 13)
                    {
                        bool sonuc;
                        sonuc = Listuretilen.Contains(kelime);
                        if (sonuc == false)
                        {
                            Listuretilen.Add(kelime);
                        }
                    }
                    if (kelime.Length > 12)
                    {
                        kelime = "";
                        txtOpen();
                    }

                    KelimeUret11(kelime);
                    KelimeUret12(kelime);
                    KelimeUret15(kelime);

                }
            }
        }

        private void KelimeKarsilastir()
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                bool sonuc;
                sonuc = Listekelimeler.Contains(listBox1.Items[i].ToString());
                if (sonuc == true)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
            }
        }
        private void txtOpen()
        {
           kelimeson = "";
            txtboxkontrol1 = "open";
            txtboxkontrol2 = "open";
            txtboxkontrol3 = "open";
            txtboxkontrol4 = "open";
            txtboxkontrol5 = "open";
            txtboxkontrol6 = "open";
            txtboxkontrol7 = "open";
            txtboxkontrol8 = "open";
            txtboxkontrol9 = "open";
            txtboxkontrol10 = "open";
            txtboxkontrol11 = "open";
            txtboxkontrol12 = "open";
            txtboxkontrol13 = "open";
            txtboxkontrol14 = "open";
            txtboxkontrol15 = "open";
            txtboxkontrol16 = "open";
        }
        /*
        1 --> 2,5,6
        2 --> 1,3,5,6,7
        3 --> 2,4,6,7,8
        4 --> 3,7,8
        5 --> 1,2,6,9,10
        6 --> 1,2,3,5,7,9,10,11
        7 --> 2,3,4,6,8,10,11,12
        8 --> 1,3,5,6,7
        9 --> 5,6,10,13,14
        10 --> 5,6,7,9,11,13,14,15
        11 --> 6,7,8,10,12,14,15,16
        12 --> 7,8,11,15,16
        13 --> 9,10,14
        14 --> 9,10,11,13,15
        15 --> 10,11,12,14,16
        16 --> 11,12,15
*/

        string kelimeson = "";
        private void toplamtxtbox(int sayi1, string kelime1)
        {
            if (textBox1.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint1 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {



                        if (textBox1.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint1++;
                            sayi1++;

                            if (textBox2.Text == listBox1.Items[sayi1].ToString())
                            {
                                if (textBox1.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol1 == "open")
                                {
                                    txtboxkontrol1 = "close";
                                    txtboxstring2 = "unlock";
                                    txtboxstring5 = "unlock";
                                    txtboxstring6 = "unlock";
                                    sayi1++;


                                }

                                txtbox2(sayi1, kelime1);
                            }

                            if (textBox5.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox5(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox6(sayi1, kelime1);
                            }

                        }

                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox2.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint2 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {

                        if (textBox2.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint2++;
                            sayi1++;
                            if (textBox1.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox1(sayi1, kelime1);
                            }

                            if (textBox3.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox3(sayi1, kelime1);
                            }

                            if (textBox5.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox5(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox7(sayi1, kelime1);
                            }

                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }
            }

            else if (textBox3.Text == listBox1.Items[sayi1].ToString())
            {
                aziz = sayi1;
                if (txtboxint3 == 0)
                {

                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox3.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint3++;

                            sayi1++;
                            if (textBox2.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox2(sayi1, kelime1);
                            }

                            if (textBox4.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox4(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox7(sayi1, kelime1);
                            }

                            if (textBox8.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox8(sayi1, kelime1);
                            }

                        }
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox4.Text == listBox1.Items[sayi1].ToString())
            {
                aziz = sayi1;
                if (txtboxint4 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox4.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint4++;
                            sayi1++;
                            if (textBox3.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox3(sayi1, kelime1);
                            }

                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox7(sayi1, kelime1);
                            }

                            if (textBox8.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox8(sayi1, kelime1);
                            }



                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox5.Text == listBox1.Items[sayi1].ToString())
            {
                aziz = sayi1;
                if (txtboxint5 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox5.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint5++;
                            sayi1++;
                            if (textBox1.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox1(sayi1, kelime1);
                            }

                            if (textBox2.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox2(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox9.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox9(sayi1, kelime1);
                            }

                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox10(sayi1, kelime1);
                            }

                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox6.Text == listBox1.Items[sayi1].ToString())
            {
                aziz = sayi1;
                if (txtboxint6 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox6.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint6++;
                            sayi1++;
                            if (textBox1.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox1(sayi1, kelime1);
                            }

                            if (textBox2.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox2(sayi1, kelime1);
                            }

                            if (textBox3.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox3(sayi1, kelime1);
                            }

                            if (textBox5.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox5(sayi1, kelime1);
                            }

                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox7(sayi1, kelime1);
                            }

                            if (textBox9.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox9(sayi1, kelime1);
                            }

                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox10(sayi1, kelime1);
                            }

                            if (textBox11.Text == listBox1.Items[sayi1].ToString())
                            {

                                txtbox11(sayi1, kelime1);
                            }

                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox7.Text == listBox1.Items[sayi1].ToString())
            {
                aziz = sayi1;
                if (txtboxint7 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox7.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint7++;
                            sayi1++;
                            if (textBox2.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox2(sayi1, kelime1);
                            }

                            if (textBox3.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox3(sayi1, kelime1);
                            }

                            if (textBox4.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox4(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox8.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox8(sayi1, kelime1);
                            }

                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox10(sayi1, kelime1);
                            }

                            if (textBox11.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox11(sayi1, kelime1);
                            }

                            if (textBox12.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox12(sayi1, kelime1);
                            }

                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox8.Text == listBox1.Items[sayi1].ToString())
            {
                aziz = sayi1;
                if (txtboxint8 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox8.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint8++;
                            sayi1++;
                            if (textBox1.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox1(sayi1, kelime1);
                            }

                            if (textBox3.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox3(sayi1, kelime1);
                            }

                            if (textBox5.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox5(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox7(sayi1, kelime1);
                            }



                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox9.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint9 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox9.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint9++;
                            sayi1++;
                            if (textBox5.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox5(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox10(sayi1, kelime1);
                            }

                            if (textBox13.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox13(sayi1, kelime1);
                            }

                            if (textBox14.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox14(sayi1, kelime1);
                            }



                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox10.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint10 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox10.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint10++;
                            sayi1++;
                            if (textBox5.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox5(sayi1, kelime1);
                            }

                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox7(sayi1, kelime1);
                            }

                            if (textBox9.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox9(sayi1, kelime1);
                            }

                            if (textBox11.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox11(sayi1, kelime1);
                            }

                            if (textBox13.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox13(sayi1, kelime1);
                            }

                            if (textBox14.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox14(sayi1, kelime1);
                            }

                            if (textBox15.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox15(sayi1, kelime1);
                            }

                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox11.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint11 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox11.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint11++;
                            sayi1++;
                            if (textBox6.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox6(sayi1, kelime1);
                            }

                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox7(sayi1, kelime1);
                            }

                            if (textBox8.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox8(sayi1, kelime1);
                            }

                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox10(sayi1, kelime1);
                            }

                            if (textBox12.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox12(sayi1, kelime1);
                            }

                            if (textBox14.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox14(sayi1, kelime1);
                            }

                            if (textBox15.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox15(sayi1, kelime1);
                            }

                            if (textBox16.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox16(sayi1, kelime1);
                            }

                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox12.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint12 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox12.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint12++;
                            sayi1++;
                            if (textBox7.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox7(sayi1, kelime1);
                            }

                            if (textBox8.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox8(sayi1, kelime1);
                            }

                            if (textBox11.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox11(sayi1, kelime1);
                            }

                            if (textBox15.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox15(sayi1, kelime1);
                            }

                            if (textBox16.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox16(sayi1, kelime1);
                            }



                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox13.Text == listBox1.Items[sayi1].ToString())
            {
                aziz = sayi1;
                if (txtboxint13 == 0)
                {

                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox13.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint13++;
                            sayi1++;
                            if (textBox9.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox9(sayi1, kelime1);
                            }

                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox10(sayi1, kelime1);
                            }

                            if (textBox14.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox14(sayi1, kelime1);
                            }



                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox14.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint14 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox14.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint14++;
                            sayi1++;
                            if (textBox9.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox9(sayi1, kelime1);
                            }

                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox10(sayi1, kelime1);
                            }

                            if (textBox11.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox11(sayi1, kelime1);
                            }

                            if (textBox13.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox13(sayi1, kelime1);
                            }

                            if (textBox15.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox15(sayi1, kelime1);
                            }



                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox15.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint15 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox15.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint15++;
                            sayi1++;
                            if (textBox10.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox10(sayi1, kelime1);
                            }

                            if (textBox11.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox11(sayi1, kelime1);
                            }

                            if (textBox12.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox12(sayi1, kelime1);
                            }

                            if (textBox14.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox14(sayi1, kelime1);
                            }

                            if (textBox16.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox16(sayi1, kelime1);
                            }



                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }

            else if (textBox16.Text == listBox1.Items[sayi1].ToString())
            {
                if (txtboxint16 == 0)
                {


                    if (sayi1 < kelime1.Length - 1)
                    {
                        if (textBox16.Text == listBox1.Items[sayi1].ToString())
                        {
                            txtboxint16++;
                            sayi1++;
                            if (textBox11.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox11(sayi1, kelime1);
                            }

                            if (textBox12.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox12(sayi1, kelime1);
                            }

                            if (textBox15.Text == listBox1.Items[sayi1].ToString())
                            {
                                txtbox15(sayi1, kelime1);
                            }





                        }
                    }
                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }
            }
        }
        private void KilitKontrol(int sayi1, string kelime1)
        {
            if (txtboxstring1 == "unlock")
            {
                txtbox1(sayi1, kelime1);
            }

            if (txtboxstring2 == "unlock")
            {
                txtbox2(sayi1, kelime1);
            }

            if (txtboxstring3 == "unlock")
            {
                txtbox3(sayi1, kelime1);
            }

            if (txtboxstring4 == "unlock")
            {
                txtbox4(sayi1, kelime1);
            }

            if (txtboxstring5 == "unlock")
            {
                txtbox5(sayi1, kelime1);
            }

            if (txtboxstring6 == "unlock")
            {
                txtbox6(sayi1, kelime1);
            }

            if (txtboxstring7 == "unlock")
            {
                txtbox7(sayi1, kelime1);
            }

            if (txtboxstring8 == "unlock")
            {
                txtbox8(sayi1, kelime1);
            }

            if (txtboxstring9 == "unlock")
            {
                txtbox9(sayi1, kelime1);
            }

            if (txtboxstring10 == "unlock")
            {
                txtbox10(sayi1, kelime1);
            }

            if (txtboxstring11 == "unlock")
            {
                txtbox11(sayi1, kelime1);
            }

            if (txtboxstring12 == "unlock")
            {
                txtbox12(sayi1, kelime1);
            }

            if (txtboxstring13 == "unlock")
            {
                txtbox13(sayi1, kelime1);
            }

            if (txtboxstring14 == "unlock")
            {
                txtbox14(sayi1, kelime1);
            }

            if (txtboxstring15 == "unlock")
            {
                txtbox15(sayi1, kelime1);
            }

            if (txtboxstring16 == "unlock")
            {
                txtbox16(sayi1, kelime1);
            }

        }
        private void txtbox1(int sayi1,string kelime1)
        {
         



                if (textBox1.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol1 == "open")
                {
                    txtboxkontrol1 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "unlock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "unlock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";
                   
                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                  

                }




               
            
        }
        private void txtbox2(int sayi1,string kelime1)
        {

         


                if (textBox2.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol2 == "open")
                {
                    txtboxkontrol2 = "close";

                    txtboxstring1 = "unlock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "unlock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "unlock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }
             


          
        }
        private void txtbox3(int sayi1,string kelime1)
        {
           


                if (textBox3.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol3 == "open")
                {
                    txtboxkontrol3  = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "unlock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "unlock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "unlock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }

             
        }
        private void txtbox4(int sayi1, string kelime1)
        {
          


                if (textBox4.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol4 == "open")
                {
                    txtboxkontrol4 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "unlock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "lock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "unlock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }

              

           
        }
        private void txtbox5(int sayi1, string kelime1)
        {
         



                if (textBox5.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol5 == "open")
                {
                    txtboxkontrol5 = "close";

                    txtboxstring1 = "unlock";
                    txtboxstring2 = "unlock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "unlock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }



               
        }
        private void txtbox6(int sayi1, string kelime1)
        {
           


                if (textBox6.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol6 == "open")
                {
                    txtboxkontrol6 = "close";

                    txtboxstring1 = "unlock";
                    txtboxstring2 = "unlock";
                    txtboxstring3 = "unlock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "unlock";
                    txtboxstring6 = "lock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "unlock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "unlock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }


              
        }
        private void txtbox7(int sayi1, string kelime1)
        {
         



                if (textBox7.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol7 == "open")
                {
                    txtboxkontrol7 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "unlock";
                    txtboxstring3 = "unlock";
                    txtboxstring4 = "unlock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "unlock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "unlock";
                    txtboxstring12 = "unlock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }

              
           
        }
        private void txtbox8(int sayi1, string kelime1)
        {
          



                if (textBox8.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol8 == "open")
                {
                    txtboxkontrol8 = "close";

                    txtboxstring1 = "unlock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "unlock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "unlock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";
                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }


               
          
        }
        private void txtbox9(int sayi1, string kelime1)
        {
         


                if (textBox9.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol9 == "open")
                {
                    txtboxkontrol9 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "unlock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "unlock";
                    txtboxstring14 = "unlock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }

                
        }
        private void txtbox10(int sayi1, string kelime1)
        {
          



                if (textBox10.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol10 == "open")
                {
                    txtboxkontrol10 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "unlock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "unlock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "unlock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "unlock";
                    txtboxstring14 = "unlock";
                    txtboxstring15 = "unlock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }



               
        }
        private void txtbox11(int sayi1, string kelime1)
        {
          


                if (textBox11.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol11 == "open")
                {
                    txtboxkontrol11 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "unlock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "unlock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "unlock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "unlock";
                    txtboxstring15 = "unlock";
                    txtboxstring16 = "unlock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }


               
        }
        private void txtbox12(int sayi1, string kelime1)
        {
            


                if (textBox12.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol12 == "open")
                {
                    txtboxkontrol12 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "lock";
                    txtboxstring7 = "unlock";
                    txtboxstring8 = "unlock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "unlock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "unlock";
                    txtboxstring16 = "unlock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }
                }

                

        }
        private void txtbox13(int sayi1, string kelime1)
        {
          


                if (textBox13.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol13 == "open")
                {
                    txtboxkontrol13 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "lock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "unlock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "lock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "unlock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "lock";
                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }

 
        }
        private void txtbox14(int sayi1, string kelime1)
        {
            



                if (textBox14.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol14 == "open")
                {
                    txtboxkontrol14 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "lock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "unlock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "unlock";
                    txtboxstring12 = "lock";
                    txtboxstring13 = "unlock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "unlock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }



              
        }
        private void txtbox15(int sayi1, string kelime1)
        {
         


                if (textBox15.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol15 == "open")
                {
                    txtboxkontrol15 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "lock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "unlock";
                    txtboxstring11 = "unlock";
                    txtboxstring12 = "unlock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "unlock";
                    txtboxstring15 = "lock";
                    txtboxstring16 = "unlock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }

 
        }
        private void txtbox16(int sayi1, string kelime1)
        {
           


                if (textBox16.Text == listBox1.Items[sayi1].ToString() && txtboxkontrol16 == "open")
                {
                    txtboxkontrol16 = "close";

                    txtboxstring1 = "lock";
                    txtboxstring2 = "lock";
                    txtboxstring3 = "lock";
                    txtboxstring4 = "lock";
                    txtboxstring5 = "lock";
                    txtboxstring6 = "lock";
                    txtboxstring7 = "lock";
                    txtboxstring8 = "lock";
                    txtboxstring9 = "lock";
                    txtboxstring10 = "lock";
                    txtboxstring11 = "unlock";
                    txtboxstring12 = "unlock";
                    txtboxstring13 = "lock";
                    txtboxstring14 = "lock";
                    txtboxstring15 = "unlock";
                    txtboxstring16 = "lock";

                    sayi1++;
                    if (sayi1 < kelime1.Length - 1)
                    {
                        KilitKontrol(sayi1, kelime1);
                    }

                    else
                    {
                        listBox2.Items.Add(kelime1);
                    }

                }


 
        }
        private void button1_Click(object sender, EventArgs e)
        {
              
            //string kelime;
            //// int kelimesayısı;
            //StreamReader oku = new StreamReader("C:\\Users\\AzizUtku\\Desktop\\Ensonbu.txt", Encoding.GetEncoding("windows-1254"));
            //harficeriyormu1 = 0;
            //    kelime = oku.ReadLine();
          
              
             
             

            //while (kelime !=null)
            //{
            //    int i = 0;
               

            //    txtboxstring1 = "unlock";
            //    txtboxstring2 = "unlock";
            //    txtboxstring3 = "unlock";
            //    txtboxstring4 = "unlock";
            //    txtboxstring5 = "unlock";
            //    txtboxstring6 = "unlock";
            //    txtboxstring7 = "unlock";
            //    txtboxstring8 = "unlock";
            //    txtboxstring9 = "unlock";
            //    txtboxstring10 = "unlock";
            //    txtboxstring11 = "unlock";
            //    txtboxstring12 = "unlock";
            //    txtboxstring13 = "unlock";
            //    txtboxstring14 = "unlock";
            //    txtboxstring15 = "unlock";
            //    txtboxstring16 = "unlock";

            //    listBox1.Items.Clear();
         
            //    char[] karakterler = kelime.ToCharArray(); 
            //    foreach (char karakter in karakterler)
            //    {
            //        listBox1.Items.Add(karakter);
            //    }

            //    KilitKontrol(i, kelime);
            //    kelime = oku.ReadLine();
            //}
            //oku.Close();
           

            txtOpen();
            KelimeUret1(kelimeson);

            txtOpen();
            KelimeUret2(kelimeson);

            txtOpen();
            KelimeUret3(kelimeson);

            txtOpen();
            KelimeUret4(kelimeson);

            txtOpen();
            KelimeUret5(kelimeson);

            txtOpen();
            KelimeUret6(kelimeson);

            txtOpen();
            KelimeUret7(kelimeson);

            txtOpen();
            KelimeUret8(kelimeson);

            txtOpen();
            KelimeUret9(kelimeson);

            txtOpen();
            KelimeUret10(kelimeson);

            txtOpen();
            KelimeUret11(kelimeson);

            txtOpen();
            KelimeUret12(kelimeson);

            txtOpen();
            KelimeUret13(kelimeson);

            txtOpen();
            KelimeUret14(kelimeson);

            txtOpen();
            KelimeUret15(kelimeson);

            txtOpen();
            KelimeUret16(kelimeson);
            KelimeKarsilastir();




        

            /*
            1 --> 2,5,6
            2 --> 1,3,5,6,7
            3 --> 2,4,6,7,8
            4 --> 3,7,8
            5 --> 1,2,6,9,10
            6 --> 1,2,3,5,7,9,10,11
            7 --> 2,3,4,6,8,10,11,12
            8 --> 1,3,5,6,7
            9 --> 5,6,10,13,14
            10 --> 5,6,7,9,11,13,14,15
            11 --> 6,7,8,10,12,14,15,16
            12 --> 7,8,11,15,16
            13 --> 9,10,14
            14 --> 9,10,11,13,15
            15 --> 10,11,12,14,16
            16 --> 11,12,15
*/

        }

        private void _9luKelime_Load(object sender, EventArgs e)
        {
            try
            {

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













            }
            catch (Exception)
            {


            }
           
            
        }
        
    }
}
