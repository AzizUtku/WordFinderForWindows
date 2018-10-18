using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azutka_Kelime_Bulucu
{
    public partial class FormDuyuru2 : Form
    {
        public FormDuyuru frm2;
        public FormDuyuru2()
        {
            InitializeComponent();
            frm2 = new FormDuyuru();
            frm2.frm3 = this;
        }
        Bitmap Resim(string Url)
        {
            WebRequest rs = WebRequest.Create(Url);
            return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            try {
             this.BackgroundImage = Resim(@frm2.link1);
             if (frm2.link2 != "")
             {
                 pictureBox2.Visible = true;
             }

             if (frm2.link3 != "")
             {
                 pictureBox3.Visible = true;
             }

             if (frm2.link4 != "")
             {
                 pictureBox4.Visible = true;
             }

             if (frm2.link5 != "")
             {
                 pictureBox5.Visible = true;
             }


            }
            catch (Exception ex)
            {
              

            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.az3;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.az;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.az2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try{
            this.BackgroundImage = Resim(@frm2.link1);
                pictureBox1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.yesil;

                pictureBox2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
            }
            catch (Exception ex)
            {
               

            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try{
                this.BackgroundImage = Resim(@frm2.link2);
                pictureBox2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.yesil;

                pictureBox1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
             }
            catch (Exception ex)
            {
           
             
            }
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             try{
                this.BackgroundImage = Resim(@frm2.link3);
                pictureBox3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.yesil;

                pictureBox2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
             }
            catch (Exception ex)
            {
            
             
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          try{
                this.BackgroundImage = Resim(@frm2.link4);
                pictureBox4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.yesil;

                pictureBox2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
             }
            catch (Exception ex)
            {
           
             
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
             this.BackgroundImage = Resim(@frm2.link5);
                pictureBox5.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.yesil;

                pictureBox2.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox3.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox4.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
                pictureBox1.BackgroundImage = Azutka_Kelime_Bulucu.Properties.Resources.kırmızı;
             }
            catch (Exception ex)
            {
               
             
            }
        }
    }
}
