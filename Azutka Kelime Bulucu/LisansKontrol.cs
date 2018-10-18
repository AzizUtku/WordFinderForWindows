using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.IO;
using System.Runtime.InteropServices;


namespace Azutka_Kelime_Bulucu
{
    public partial class LisansKontrol : Form
    {
        public Form1 frm1;
        public Form2 frm2;
        public LisansKontrol()
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

        string serial;
        string sifreliserial;

        int uzunluk;
       
        string harf;
        int harfnumara;
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

        private void button2_Click(object sender, EventArgs e)
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
            //MessageBox.Show("Programı yönetici olarak çalıştırmadıysanız hata verebilir.");
            string sifreliserial = "";
            string sifreli;
            string yazi = textBox1.Text;
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
            //StreamWriter lisanskey = new StreamWriter("LisansKey.txt");
           
            if (serial == sifreliserial)
            {
                MessageBox.Show("Lisans Onaylandı , Tam Sürüm Olarak Kullanıyorsunuz.", "Azutka Kelime Bulucu");
                label6.Text = "Programınız Lisanslı";
               
              //  frm1.Text = "Azutka Kelime Bulucu - Detaylı Arama (Lisanslı Sürüm)";
               // frm1.label15.Text = "Programınız Lisanslı";
                Properties.Settings.Default.LisansKey = textBox1.Text;
                Properties.Settings.Default.Kullaniciİsmi = txtIsim.Text;
                Properties.Settings.Default.KullaniciİsmiBool = 1;
                Properties.Settings.Default.Save();
                //lisanskey.Close();
            }

            else
            {
                MessageBox.Show("Lisans Numaranız Geçersiz , Deneme Sürümü Olarak Kullanıyorsunuz", "Azutka Kelime Bulucu");
                label6.Text = "Program Lisanslı Değil";
                Properties.Settings.Default.LisansKey = "";
                Properties.Settings.Default.KullaniciİsmiBool = 0;
                Properties.Settings.Default.Save();
               //frm1.Text = "Azutka Kelime Bulucu - Detaylı Arama (Lisanssız Sürüm)";
                //frm1.label15.Text = "Program Lisanslı Değil";
                //lisanskey.Close();
            }






           
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (IsConnectedToInternet()==true)
                {
                    
              
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("azizutku1@gmail.com");
                //Buraya gmail hesabınızı gireceksiniz. (Mailleri bu gmail hesabı üzerinden gönderceksiniz.)

                ePosta.To.Add("azutkakelimebulucu@hotmail.com");
                ePosta.To.Add("azizutku1@hotmail.com");

                //Buraya maili hangi hesaba göndermek istiyorsanız onu yazın. Eğer textboxa girilen hesaba göndermek istiyorsanız:   ePosta.To.Add(textBox1.Text);



                ePosta.Subject = "Azutka Kelime Bulucu - Sipariş";
                //Eposta Konusu
                ePosta.Body = "Mail Adresi: " + textBox3.Text + "\n" + "Mesaj: " + textBox4.Text +"\n" + "Program Kodu: " + textBox2.Text;
                //Eposta İçeriği
                SmtpClient smtp = new SmtpClient();

                smtp.Credentials = new System.Net.NetworkCredential("*******@gmail.com", "*******");
                //Gmail hesabınızın adresi ve şifresi
                smtp.Port = 587;
                // Gmailin Portu
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                object userState = ePosta;



                try
                {
                    smtp.SendAsync(ePosta, (object)ePosta);
                    MessageBox.Show("Program kodunuz gönderildi. 24 Saat içerisinde cevap gelecektir. Teşekkür ederiz.", "Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException ex)
                {

                    System.Windows.Forms.MessageBox.Show(ex.Message, "");
                }

                }

                else
                {
                    MessageBox.Show("İnternet Bağlantısı Mevcut Değil! Lütfen Daha Sonra Tekrar Deneyiniz...","İnternet Yok",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }


            }
            catch (Exception)
            {


            }
        }
        string sifreliseriali;
        int uzunluku;
        string islemciSerialNumber;
        private void LisansKontrol_Load_1(object sender, System.EventArgs e)
        {
            try{


                if (Properties.Settings.Default.ProgramKodu == "")
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
                        textBox2.Text = serial;

                        ++index;
                    }
                    Console.ReadLine();
                    Properties.Settings.Default.ProgramKodu = serial;
                    Properties.Settings.Default.Save();
                }

                serial = Properties.Settings.Default.ProgramKodu;
                textBox2.Text = serial;
           

            string sifrelisansi;
            // lisans = new LisansKontrol();
         //   StreamReader lisansskontrol = new StreamReader("LisansKey.txt");
         //   textBox1.Text = lisansskontrol.ReadLine();
            textBox1.Text = Properties.Settings.Default.LisansKey;
            sifrelisansi = Properties.Settings.Default.LisansKey;
            txtIsim.Text = Properties.Settings.Default.Kullaniciİsmi;
         //   sifrelisansi = lisansskontrol.ReadLine();
         //   lisansskontrol.Close();
         //   button2.PerformClick();
            string sifreliserial = "";
            string sifreli;
            string yazi = textBox1.Text;
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
              //  MessageBox.Show("Lisans Onaylandı", "Azutka Kelime Bulucu");
                label6.Text = "Programınız Lisanslı";
                //      frm1.label15.Text = "Programınız Lisanslı";
              
            }

            else
            {
            //    MessageBox.Show("Lisans Numaranız Geçersiz", "Azutka Kelime Bulucu");
                label6.Text = "Program Lisanslı Değil";
                //   frm1.label15.Text = "Program Lisanslı Değil";
              
            }
            }
            catch (Exception)
            {


            }
           
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Aktive_Et_over;
        }

        private void button2_MouseLeave(object sender, System.EventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Aktive_Et;
        }

        private void button3_Click_1(object sender, System.EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button3_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            button3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Kopyala_over;
        }

        private void button3_MouseLeave(object sender, System.EventArgs e)
        {
            button3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Kopyala;
        }

        private void button1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Gönder_over;
           
        }

        private void button1_MouseLeave(object sender, System.EventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.Gönder;
        }

        private void LisansKontrol_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
