using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Joker Harf Kullan\" işaretlediğinizde Jokerli Kelimeler de üretir \n\nJoker Harfi \"[ ]\" arasında gösterir  \n\nÖrneğin Karışık Harfler içerisinde PKTA varsa ve \"İ\" Joker Harfi seçili ise size K[İ]TAP kelimesini üretir \n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
              , "Bilgi - Joker Harf", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşaretlediğiniz kritere göre kelime üretir \n\nİşaretlemediğinizi üretse bile göstermez \n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
              , "Bilgi - Üretilecek Kelimeler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelimeleri gönderdikten sonra belirttiğiniz tuşa basar \n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
, "Bilgi - Kelime Gönderdikten Sonra Basılacak Tuş", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelimeleri veya harfleri gönderikten sonra belirttiğiniz süre kadar bekler. \n\nKelime gönderirken kelimelerin birbirine girmesini önlemek için yapılmıştır\n\n1000 Milisaniye = 1 Saniye,Örneğin ilk kutuya 500 yazarsanız her kelimeyi gönderdikten sonra yarım saniye bekler\n\nDaha fazla bilgi için: azutkakelimebulucu@hotmail.com "
   , "Bilgi - Kelime Gönderdikten Sonra Durma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox2.Enabled = true;
            }

            else
            {
                textBox2.Enabled = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox4.Enabled = true;
            }

            else
            {
                textBox4.Enabled = false;
            }
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked == true)
            {
                checkBoxA.Checked = true;
                checkBoxB.Checked = true;
                checkBoxC.Checked = true;
                checkBoxÇ.Checked = true;
                checkBoxD.Checked = true;
                checkBoxE.Checked = true;
                checkBoxF.Checked = true;
                checkBoxG.Checked = true;
                checkBoxĞ.Checked = true;
                checkBoxH.Checked = true;
                checkBoxI.Checked = true;
                checkBoxİ.Checked = true;
                checkBoxJ.Checked = true;
                checkBoxK.Checked = true;
                checkBoxL.Checked = true;
                checkBoxM.Checked = true;
                checkBoxN.Checked = true;
                checkBoxO.Checked = true;
                checkBoxÖ.Checked = true;
                checkBoxP.Checked = true;
                checkBoxR.Checked = true;
                checkBoxS.Checked = true;
                checkBoxŞ.Checked = true;
                checkBoxT.Checked = true;
                checkBoxU.Checked = true;
                checkBoxÜ.Checked = true;
                checkBoxV.Checked = true;
                checkBoxY.Checked = true;
                checkBoxZ.Checked = true;

            }

            else
            {
                checkBoxA.Checked = false;
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxÇ.Checked = false;
                checkBoxD.Checked = false;
                checkBoxE.Checked = false;
                checkBoxF.Checked = false;
                checkBoxG.Checked = false;
                checkBoxĞ.Checked = false;
                checkBoxH.Checked = false;
                checkBoxI.Checked = false;
                checkBoxİ.Checked = false;
                checkBoxJ.Checked = false;
                checkBoxK.Checked = false;
                checkBoxL.Checked = false;
                checkBoxM.Checked = false;
                checkBoxN.Checked = false;
                checkBoxO.Checked = false;
                checkBoxÖ.Checked = false;
                checkBoxP.Checked = false;
                checkBoxR.Checked = false;
                checkBoxS.Checked = false;
                checkBoxŞ.Checked = false;
                checkBoxT.Checked = false;
                checkBoxU.Checked = false;
                checkBoxÜ.Checked = false;
                checkBoxV.Checked = false;
                checkBoxY.Checked = false;
                checkBoxZ.Checked = false;
            }
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {
            button16.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Kaydet_down;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____Kaydet;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____İptal___down;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.____İptal__;
        }
        private void JokerKontrol()
        {
            try
            {
                if (Properties.Settings.Default.JokerAyarlar==true)
                {
                    checkBoxJokerEnabled.Checked = true;
                }

                else
                {
                    checkBoxJokerEnabled.Checked = false;
                }
               
                if (Properties.Settings.Default.Jokerler.IndexOf("(A)") != -1)
                {
                    checkBoxA.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(B)") != -1)
                {
                    checkBoxB.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(C)") != -1)
                {
                    checkBoxC.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ç)") != -1)
                {
                    checkBoxÇ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(D)") != -1)
                {
                    checkBoxD.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(E)") != -1)
                {
                    checkBoxE.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(F)") != -1)
                {
                    checkBoxF.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(G)") != -1)
                {
                    checkBoxG.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ğ)") != -1)
                {
                    checkBoxĞ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(H)") != -1)
                {
                    checkBoxH.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(I)") != -1)
                {
                    checkBoxI.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(İ)") != -1)
                {
                    checkBoxİ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(J)") != -1)
                {
                    checkBoxJ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(K)") != -1)
                {
                    checkBoxK.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(L)") != -1)
                {
                    checkBoxL.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(M)") != -1)
                {
                    checkBoxM.Checked = true;
                }
                //
                if (Properties.Settings.Default.Jokerler.IndexOf("(N)") != -1)
                {
                    checkBoxN.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(O)") != -1)
                {
                    checkBoxO.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ö)") != -1)
                {
                    checkBoxÖ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(P)") != -1)
                {
                    checkBoxP.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(R)") != -1)
                {
                    checkBoxR.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(S)") != -1)
                {
                    checkBoxS.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ş)") != -1)
                {
                    checkBoxŞ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(T)") != -1)
                {
                    checkBoxT.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(U)") != -1)
                {
                    checkBoxU.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Ü)") != -1)
                {
                    checkBoxÜ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(V)") != -1)
                {
                    checkBoxV.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Y)") != -1)
                {
                    checkBoxY.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(Z)") != -1)
                {
                    checkBoxZ.Checked = true;
                }

                if (Properties.Settings.Default.Jokerler.IndexOf("(TS)") != -1)
                {
                    checkBox37.Checked = true;
                }


            }
            catch (Exception)
            {

            }
        }
        private void JokerGüncelle()
        {
            try
            {
                if (checkBoxJokerEnabled.Checked==true)
                {
                    Properties.Settings.Default.JokerAyarlar = true;
                }

                else
                {
                    Properties.Settings.Default.JokerAyarlar = false;
                }

                Properties.Settings.Default.Jokerler = "";
             
                if (checkBoxA.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(A)";
                }

                if (checkBoxB.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(B)";
                }

                if (checkBoxC.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(C)";
                }

                if (checkBoxÇ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(Ç)";
                }

                if (checkBoxD.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(D)";
                }

                if (checkBoxE.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(E)";
                }

                if (checkBoxF.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(F)";
                }

                if (checkBoxG.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(G)";
                }

                if (checkBoxĞ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(Ğ)";
                }

                if (checkBoxH.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(H)";
                }

                if (checkBoxI.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(I)";
                }

                if (checkBoxİ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(İ)";
                }

                if (checkBoxJ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(J)";
                }

                if (checkBoxK.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(K)";
                }

                if (checkBoxL.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(L)";
                }

                if (checkBoxM.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(M)";
                }
           
                if (checkBoxN.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(N)";
                }

                if (checkBoxO.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(O)";
                }

                if (checkBoxÖ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(Ö)";
                }

                if (checkBoxP.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(P)";
                }

                if (checkBoxR.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(R)";
                }

                if (checkBoxS.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(S)";
                }

                if (checkBoxŞ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(Ş)";
                }

                if (checkBoxT.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(T)";
                }

                if (checkBoxU.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(U)";
                }

                if (checkBoxÜ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(Ü)";
                }

                if (checkBoxV.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(V)";
                }

                if (checkBoxY.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(Y)";
                }

                if (checkBoxZ.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(Z)";
                }

                if (checkBox37.Checked == true)
                {
                    Properties.Settings.Default.Jokerler += "(TS)";
                }

                Properties.Settings.Default.Save();


            }
            catch (Exception)
            {

            }
        }
        private void rdTusKontrol()
        {
            if (Properties.Settings.Default.BasılacakTus == 1)
            {
                rdE.Checked = true;
            }

            else if (Properties.Settings.Default.BasılacakTus == 2)
            {
                rdEB.Checked = true;
            }

            else if (Properties.Settings.Default.BasılacakTus == 3)
            {
                rdES.Checked = true;
            }
        }
        private void rdTusGüncelle()
        {
            if (rdE.Checked == true)
            {
                Properties.Settings.Default.BasılacakTus = 1;
            }

            else if (rdEB.Checked == true)
            {
                Properties.Settings.Default.BasılacakTus = 2;
            }

            else if (rdES.Checked == true)
            {
                Properties.Settings.Default.BasılacakTus = 3;
            }
            Properties.Settings.Default.Save();
        }
        private void durmaKontrol()
        {
            if (Properties.Settings.Default.HGSDBool == true)
            {
                checkBox13.Checked = true;
            }

            else
            {
                checkBox13.Checked = false;
            }

            if (Properties.Settings.Default.KGSDBool == true)
            {
                checkBox14.Checked = true;
            }

            else
            {
                checkBox14.Checked = false;
            }

            textBox2.Text = Properties.Settings.Default.KelimeGönderiktenSonraDur;
            textBox4.Text = Properties.Settings.Default.HarfGönderdiktenSonraDur;
        }
        private void durmaGüncelle()
        {
            if (checkBox13.Checked==true)
            {
                Properties.Settings.Default.HGSDBool = true;
            }

            else
            {
                Properties.Settings.Default.HGSDBool = false;
            }

            if (checkBox14.Checked==true)
            {
                Properties.Settings.Default.KGSDBool = true;
            }

            else
            {
                Properties.Settings.Default.KGSDBool = false;
            }

            Properties.Settings.Default.KelimeGönderiktenSonraDur = textBox2.Text;
            Properties.Settings.Default.HarfGönderdiktenSonraDur = textBox4.Text;
            Properties.Settings.Default.Save();
        }
        private void üretilecekKontrol()
        {
            try
            {


                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(TK)") != -1)
                {
                    checkBoxTK.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(12)") != -1)
                {
                    checkBox7.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(11)") != -1)
                {
                    checkBox8.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(10)") != -1)
                {
                    checkBox9.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(9)") != -1)
                {
                    checkBox10.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(8)") != -1)
                {
                    checkBox12.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(7)") != -1)
                {
                    checkBox5.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(6)") != -1)
                {
                    checkBox4.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(5)") != -1)
                {
                    checkBox3.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(4)") != -1)
                {
                    checkBox2.Checked = true;
                }

                if (Properties.Settings.Default.ÜretilecekKelimeler.IndexOf("(3)") != -1)
                {
                    checkBox1.Checked = true;
                }



            }
            catch (Exception)
            {

            }
        }
        private void üretilecekGüncelle()
        {
            try
            {

                Properties.Settings.Default.ÜretilecekKelimeler = "";

                if (checkBoxTK.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(TK)";
                }

                if (checkBox7.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(12)";
                }

                if (checkBox8.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(11)";
                }

                if (checkBox9.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(10)";
                }

                if (checkBox10.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(9)";
                }

                if (checkBox12.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(8)";
                }

                if (checkBox5.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(7)";
                }

                if (checkBox4.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(6)";
                }

                if (checkBox3.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(5)";
                }

                if (checkBox2.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(4)";
                }

                if (checkBox1.Checked == true)
                {
                    Properties.Settings.Default.ÜretilecekKelimeler += "(3)";
                }

             
                Properties.Settings.Default.Save();

            }
            catch (Exception)
            {

            }
        }
        private void checkBoxJokerBoolKontrol()
        {

            if (Properties.Settings.Default.JokerHarfBool == true)
            {
             
             


                    checkBox37.Enabled = true;
                    checkBoxA.Enabled = true;
                    checkBoxB.Enabled = true;
                    checkBoxC.Enabled = true;
                    checkBoxÇ.Enabled = true;
                    checkBoxD.Enabled = true;
                    checkBoxE.Enabled = true;
                    checkBoxF.Enabled = true;
                    checkBoxG.Enabled = true;
                    checkBoxĞ.Enabled = true;
                    checkBoxH.Enabled = true;
                    checkBoxI.Enabled = true;
                    checkBoxİ.Enabled = true;
                    checkBoxJ.Enabled = true;
                    checkBoxK.Enabled = true;
                    checkBoxL.Enabled = true;
                    checkBoxM.Enabled = true;
                    checkBoxN.Enabled = true;
                    checkBoxO.Enabled = true;
                    checkBoxÖ.Enabled = true;
                    checkBoxP.Enabled = true;
                    checkBoxR.Enabled = true;
                    checkBoxS.Enabled = true;
                    checkBoxŞ.Enabled = true;
                    checkBoxT.Enabled = true;
                    checkBoxU.Enabled = true;
                    checkBoxÜ.Enabled = true;
                    checkBoxV.Enabled = true;
                    checkBoxY.Enabled = true;
                    checkBoxZ.Enabled = true;
                
            }

            else
            {

                checkBox37.Enabled = false;
                checkBoxA.Enabled = false;
                checkBoxB.Enabled = false;
                checkBoxC.Enabled = false;
                checkBoxÇ.Enabled = false;
                checkBoxD.Enabled = false;
                checkBoxE.Enabled = false;
                checkBoxF.Enabled = false;
                checkBoxG.Enabled = false;
                checkBoxĞ.Enabled = false;
                checkBoxH.Enabled = false;
                checkBoxI.Enabled = false;
                checkBoxİ.Enabled = false;
                checkBoxJ.Enabled = false;
                checkBoxK.Enabled = false;
                checkBoxL.Enabled = false;
                checkBoxM.Enabled = false;
                checkBoxN.Enabled = false;
                checkBoxO.Enabled = false;
                checkBoxÖ.Enabled = false;
                checkBoxP.Enabled = false;
                checkBoxR.Enabled = false;
                checkBoxS.Enabled = false;
                checkBoxŞ.Enabled = false;
                checkBoxT.Enabled = false;
                checkBoxU.Enabled = false;
                checkBoxÜ.Enabled = false;
                checkBoxV.Enabled = false;
                checkBoxY.Enabled = false;
                checkBoxZ.Enabled = false;
            }

        }
        private void cmbPuanKontrol()
        {
            string HarfPuan = Properties.Settings.Default.HarfPuan;
            cmbA.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<A") + 2, HarfPuan.IndexOf("A>") - HarfPuan.IndexOf("<A") - 2) + " Puan";
            cmbB.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<B") + 2, HarfPuan.IndexOf("B>") - HarfPuan.IndexOf("<B") - 2) + " Puan";
            cmbC.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<C") + 2, HarfPuan.IndexOf("C>") - HarfPuan.IndexOf("<C") - 2) + " Puan";
            cmbÇ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<Ç") + 2, HarfPuan.IndexOf("Ç>") - HarfPuan.IndexOf("<Ç") - 2) + " Puan";
            cmbD.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<D") + 2, HarfPuan.IndexOf("D>") - HarfPuan.IndexOf("<D") - 2) + " Puan";
            cmbE.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<E") + 2, HarfPuan.IndexOf("E>") - HarfPuan.IndexOf("<E") - 2) + " Puan";
            cmbF.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<F") + 2, HarfPuan.IndexOf("F>") - HarfPuan.IndexOf("<F") - 2) + " Puan";
            cmbG.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<G") + 2, HarfPuan.IndexOf("G>") - HarfPuan.IndexOf("<G") - 2) + " Puan";
            cmbĞ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<Ğ") + 2, HarfPuan.IndexOf("Ğ>") - HarfPuan.IndexOf("<Ğ") - 2) + " Puan";
            cmbH.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<H") + 2, HarfPuan.IndexOf("H>") - HarfPuan.IndexOf("<H") - 2) + " Puan";
            cmbI.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<I") + 2, HarfPuan.IndexOf("I>") - HarfPuan.IndexOf("<I") - 2) + " Puan";
            cmbİ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<İ") + 2, HarfPuan.IndexOf("İ>") - HarfPuan.IndexOf("<İ") - 2) + " Puan";
            cmbJ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<J") + 2, HarfPuan.IndexOf("J>") - HarfPuan.IndexOf("<J") - 2) + " Puan";
            cmbK.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<K") + 2, HarfPuan.IndexOf("K>") - HarfPuan.IndexOf("<K") - 2) + " Puan";
            cmbL.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<L") + 2, HarfPuan.IndexOf("L>") - HarfPuan.IndexOf("<L") - 2) + " Puan";
            cmbM.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<M") + 2, HarfPuan.IndexOf("M>") - HarfPuan.IndexOf("<M") - 2) + " Puan";
            cmbN.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<N") + 2, HarfPuan.IndexOf("N>") - HarfPuan.IndexOf("<N") - 2) + " Puan";
            cmbO.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<O") + 2, HarfPuan.IndexOf("O>") - HarfPuan.IndexOf("<O") - 2) + " Puan";
            cmbÖ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<Ö") + 2, HarfPuan.IndexOf("Ö>") - HarfPuan.IndexOf("<Ö") - 2) + " Puan";
            cmbP.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<P") + 2, HarfPuan.IndexOf("P>") - HarfPuan.IndexOf("<P") - 2) + " Puan";
            cmbR.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<R") + 2, HarfPuan.IndexOf("R>") - HarfPuan.IndexOf("<R") - 2) + " Puan";
            cmbS.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<S") + 2, HarfPuan.IndexOf("S>") - HarfPuan.IndexOf("<S") - 2) + " Puan";
            cmbŞ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<Ş") + 2, HarfPuan.IndexOf("Ş>") - HarfPuan.IndexOf("<Ş") - 2) + " Puan";
            cmbT.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<T") + 2, HarfPuan.IndexOf("T>") - HarfPuan.IndexOf("<T") - 2) + " Puan";
            cmbU.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<U") + 2, HarfPuan.IndexOf("U>") - HarfPuan.IndexOf("<U") - 2) + " Puan";
            cmbÜ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<Ü") + 2, HarfPuan.IndexOf("Ü>") - HarfPuan.IndexOf("<Ü") - 2) + " Puan";
            cmbV.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<V") + 2, HarfPuan.IndexOf("V>") - HarfPuan.IndexOf("<V") - 2) + " Puan";
            cmbY.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<Y") + 2, HarfPuan.IndexOf("Y>") - HarfPuan.IndexOf("<Y") - 2) + " Puan";
            cmbZ.SelectedItem = HarfPuan.Substring(HarfPuan.IndexOf("<Z") + 2, HarfPuan.IndexOf("Z>") - HarfPuan.IndexOf("<Z") - 2) + " Puan";
           
        }
        private void cmbPuanGüncelle()
        {
            Properties.Settings.Default.HarfPuan = "";
            Properties.Settings.Default.HarfPuan += "<A" + cmbA.SelectedItem.ToString().Remove(cmbA.SelectedItem.ToString().IndexOf(" ")) + "A>";
            Properties.Settings.Default.HarfPuan += "<B" + cmbB.SelectedItem.ToString().Remove(cmbB.SelectedItem.ToString().IndexOf(" ")) + "B>";
            Properties.Settings.Default.HarfPuan += "<C" + cmbC.SelectedItem.ToString().Remove(cmbC.SelectedItem.ToString().IndexOf(" ")) + "C>";
            Properties.Settings.Default.HarfPuan += "<Ç" + cmbÇ.SelectedItem.ToString().Remove(cmbÇ.SelectedItem.ToString().IndexOf(" ")) + "Ç>";
            Properties.Settings.Default.HarfPuan += "<D" + cmbD.SelectedItem.ToString().Remove(cmbD.SelectedItem.ToString().IndexOf(" ")) + "D>";
            Properties.Settings.Default.HarfPuan += "<E" + cmbE.SelectedItem.ToString().Remove(cmbE.SelectedItem.ToString().IndexOf(" ")) + "E>";
            Properties.Settings.Default.HarfPuan += "<F" + cmbF.SelectedItem.ToString().Remove(cmbF.SelectedItem.ToString().IndexOf(" ")) + "F>";
            Properties.Settings.Default.HarfPuan += "<G" + cmbG.SelectedItem.ToString().Remove(cmbG.SelectedItem.ToString().IndexOf(" ")) + "G>";
            Properties.Settings.Default.HarfPuan += "<Ğ" + cmbĞ.SelectedItem.ToString().Remove(cmbĞ.SelectedItem.ToString().IndexOf(" ")) + "Ğ>";
            Properties.Settings.Default.HarfPuan += "<H" + cmbH.SelectedItem.ToString().Remove(cmbH.SelectedItem.ToString().IndexOf(" ")) + "H>";
            Properties.Settings.Default.HarfPuan += "<I" + cmbI.SelectedItem.ToString().Remove(cmbI.SelectedItem.ToString().IndexOf(" ")) + "I>";
            Properties.Settings.Default.HarfPuan += "<İ" + cmbİ.SelectedItem.ToString().Remove(cmbİ.SelectedItem.ToString().IndexOf(" ")) + "İ>";
            Properties.Settings.Default.HarfPuan += "<J" + cmbJ.SelectedItem.ToString().Remove(cmbJ.SelectedItem.ToString().IndexOf(" ")) + "J>";
            Properties.Settings.Default.HarfPuan += "<K" + cmbK.SelectedItem.ToString().Remove(cmbK.SelectedItem.ToString().IndexOf(" ")) + "K>";
            Properties.Settings.Default.HarfPuan += "<L" + cmbL.SelectedItem.ToString().Remove(cmbL.SelectedItem.ToString().IndexOf(" ")) + "L>";
            Properties.Settings.Default.HarfPuan += "<M" + cmbM.SelectedItem.ToString().Remove(cmbM.SelectedItem.ToString().IndexOf(" ")) + "M>";
            Properties.Settings.Default.HarfPuan += "<N" + cmbN.SelectedItem.ToString().Remove(cmbN.SelectedItem.ToString().IndexOf(" ")) + "N>";
            Properties.Settings.Default.HarfPuan += "<O" + cmbO.SelectedItem.ToString().Remove(cmbO.SelectedItem.ToString().IndexOf(" ")) + "O>";
            Properties.Settings.Default.HarfPuan += "<Ö" + cmbÖ.SelectedItem.ToString().Remove(cmbÖ.SelectedItem.ToString().IndexOf(" ")) + "Ö>";
            Properties.Settings.Default.HarfPuan += "<P" + cmbP.SelectedItem.ToString().Remove(cmbP.SelectedItem.ToString().IndexOf(" ")) + "P>";
            Properties.Settings.Default.HarfPuan += "<R" + cmbR.SelectedItem.ToString().Remove(cmbR.SelectedItem.ToString().IndexOf(" ")) + "R>";
            Properties.Settings.Default.HarfPuan += "<S" + cmbS.SelectedItem.ToString().Remove(cmbS.SelectedItem.ToString().IndexOf(" ")) + "S>";
            Properties.Settings.Default.HarfPuan += "<Ş" + cmbŞ.SelectedItem.ToString().Remove(cmbŞ.SelectedItem.ToString().IndexOf(" ")) + "Ş>";
            Properties.Settings.Default.HarfPuan += "<T" + cmbT.SelectedItem.ToString().Remove(cmbT.SelectedItem.ToString().IndexOf(" ")) + "T>";
            Properties.Settings.Default.HarfPuan += "<U" + cmbU.SelectedItem.ToString().Remove(cmbU.SelectedItem.ToString().IndexOf(" ")) + "U>";
            Properties.Settings.Default.HarfPuan += "<Ü" + cmbÜ.SelectedItem.ToString().Remove(cmbÜ.SelectedItem.ToString().IndexOf(" ")) + "Ü>";
            Properties.Settings.Default.HarfPuan += "<V" + cmbV.SelectedItem.ToString().Remove(cmbV.SelectedItem.ToString().IndexOf(" ")) + "V>";
            Properties.Settings.Default.HarfPuan += "<Y" + cmbY.SelectedItem.ToString().Remove(cmbY.SelectedItem.ToString().IndexOf(" ")) + "Y>";
            Properties.Settings.Default.HarfPuan += "<Z" + cmbZ.SelectedItem.ToString().Remove(cmbZ.SelectedItem.ToString().IndexOf(" ")) + "Z>";
            Properties.Settings.Default.Save();
        }
       
        private void button16_Click(object sender, EventArgs e)
        {
            JokerGüncelle();
            rdTusGüncelle();
            durmaGüncelle();
            üretilecekGüncelle();
            cmbPuanGüncelle();
            kayit = 1;
            MessageBox.Show("Kaydedildi!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            JokerKontrol();
            rdTusKontrol();
            durmaKontrol();
            üretilecekKontrol();
            checkBoxJokerBoolKontrol();
            cmbPuanKontrol();
        }
        int kayit = 0;
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kayit==0)
            {
        
            if (MessageBox.Show("Ayarlarınız kaydedilsin mi ?", "Ayarlarınız kaydedilsin mi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                JokerGüncelle();
                rdTusGüncelle();
                durmaGüncelle();
                üretilecekGüncelle();
                cmbPuanGüncelle();
            }

            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxTK_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KelimeGöndericiBool == true)
            {
                if (checkBoxTK.Checked == false)
                {
                    MessageBox.Show("Kelime Gönderici Açıkken Tüm Kelimeleri Kapatamazsınız");
                }
                checkBoxTK.Checked = true;
            }
        }
    }
}
