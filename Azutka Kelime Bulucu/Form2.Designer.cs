namespace Azutka_Kelime_Bulucu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblSayiHepsi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxJoker = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayiHepsi
            // 
            this.lblSayiHepsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayiHepsi.ForeColor = System.Drawing.Color.Crimson;
            this.lblSayiHepsi.Location = new System.Drawing.Point(29, 397);
            this.lblSayiHepsi.Name = "lblSayiHepsi";
            this.lblSayiHepsi.Size = new System.Drawing.Size(100, 13);
            this.lblSayiHepsi.TabIndex = 53;
            this.lblSayiHepsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tüm Kelimeler";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "     Tüm Kelimeler"});
            this.listBox1.Location = new System.Drawing.Point(13, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 327);
            this.listBox1.TabIndex = 51;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBoxJoker
            // 
            this.checkBoxJoker.AutoSize = true;
            this.checkBoxJoker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxJoker.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBoxJoker.Location = new System.Drawing.Point(157, 216);
            this.checkBoxJoker.Name = "checkBoxJoker";
            this.checkBoxJoker.Size = new System.Drawing.Size(126, 21);
            this.checkBoxJoker.TabIndex = 54;
            this.checkBoxJoker.Text = "Joker Harf Kullan";
            this.toolTip1.SetToolTip(this.checkBoxJoker, "Joker Harfleri [ ] arasında gösterir");
            this.checkBoxJoker.UseVisualStyleBackColor = true;
            this.checkBoxJoker.CheckedChanged += new System.EventHandler(this.checkBoxJoker_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(13, 413);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 25);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBox1.Location = new System.Drawing.Point(157, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 21);
            this.checkBox1.TabIndex = 127;
            this.checkBox1.Text = "Kelime Gönderici";
            this.toolTip1.SetToolTip(this.checkBox1, "Bulunan kelimeleri diğer uygulamalara gönderebilirsiniz");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox2.Location = new System.Drawing.Point(157, 270);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(154, 21);
            this.checkBox2.TabIndex = 128;
            this.checkBox2.Text = "En Uzunu Gönder [F6]\r\n";
            this.toolTip1.SetToolTip(this.checkBox2, "Seçilen uygulamaya en uzun kelimeyi gönderir");
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(154, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 26);
            this.label16.TabIndex = 130;
            this.label16.Text = "Kelimeleri Göndermek \r\nİstediğiniz Uygulamayı Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 416);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 129;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox3.Location = new System.Drawing.Point(157, 297);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(130, 21);
            this.checkBox3.TabIndex = 131;
            this.checkBox3.Text = "İlk 10 Gönder [F7]\r\n";
            this.toolTip1.SetToolTip(this.checkBox3, "Seçilen uygulamaya ilk 10 kelimeyi gönderir.");
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox4.Location = new System.Drawing.Point(157, 351);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(143, 21);
            this.checkBox4.TabIndex = 133;
            this.checkBox4.Text = "Hepsini Gönder [F9]";
            this.toolTip1.SetToolTip(this.checkBox4, "Seçilen uygulamaya tüm kelimeleri gönderir.");
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox5.Location = new System.Drawing.Point(157, 324);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(130, 21);
            this.checkBox5.TabIndex = 132;
            this.checkBox5.Text = "İlk 20 Gönder [F8]";
            this.toolTip1.SetToolTip(this.checkBox5, "Seçilen uygulamaya ilk 20 kelimeyi gönderir.");
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(16, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 21);
            this.label18.TabIndex = 134;
            this.label18.Text = "Aziz Utku Kağıtcı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(162, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 13);
            this.label15.TabIndex = 136;
            this.label15.Text = "Program Lisanslı Değil";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Azutka_Kelime_Bulucu.Properties.Resources.Lisans2;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Location = new System.Drawing.Point(162, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 27);
            this.button5.TabIndex = 135;
            this.toolTip1.SetToolTip(this.button5, "Lisans İşlemleri \' ni açar");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Azutka_Kelime_Bulucu.Properties.Resources.Gizle;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Location = new System.Drawing.Point(546, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 29);
            this.button4.TabIndex = 126;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Azutka_Kelime_Bulucu.Properties.Resources.Detaylı_Arama2;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(162, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 27);
            this.button3.TabIndex = 58;
            this.toolTip1.SetToolTip(this.button3, "Detaylı bir şekilde arama yapabilirsiniz");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Azutka_Kelime_Bulucu.Properties.Resources.Manuel_Joker;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(162, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 57;
            this.toolTip1.SetToolTip(this.button2, "29 Harften istediğinizi Joker Harf seçebilirsiniz");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Azutka_Kelime_Bulucu.Properties.Resources.Bul;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(18, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 56;
            this.toolTip1.SetToolTip(this.button1, "Karışık Harfler \' den anlamlı kelimeler üretir");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label17.ForeColor = System.Drawing.Color.IndianRed;
            this.label17.Location = new System.Drawing.Point(4, 476);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 17);
            this.label17.TabIndex = 137;
            this.label17.Text = "Harf Sayısı : ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::Azutka_Kelime_Bulucu.Properties.Resources.____Ayarlar;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(157, 171);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(130, 33);
            this.button16.TabIndex = 150;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            this.button16.MouseLeave += new System.EventHandler(this.button16_MouseLeave);
            this.button16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button16_MouseMove);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 515);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxJoker);
            this.Controls.Add(this.lblSayiHepsi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Azutka Kelime Bulucu - Normal Arama (Lisanssız Sürüm)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayiHepsi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxJoker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button16;
    }
}