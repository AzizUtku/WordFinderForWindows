namespace Azutka_Kelime_Bulucu_Updater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblYeniSurum = new System.Windows.Forms.Label();
            this.lblSürüm = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblYukluSurum = new System.Windows.Forms.Label();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYeniSurum
            // 
            this.lblYeniSurum.AutoSize = true;
            this.lblYeniSurum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSurum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYeniSurum.Location = new System.Drawing.Point(21, 119);
            this.lblYeniSurum.Name = "lblYeniSurum";
            this.lblYeniSurum.Size = new System.Drawing.Size(73, 13);
            this.lblYeniSurum.TabIndex = 24;
            this.lblYeniSurum.Text = "Yeni Sürüm : ";
            // 
            // lblSürüm
            // 
            this.lblSürüm.AutoSize = true;
            this.lblSürüm.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSürüm.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSürüm.Location = new System.Drawing.Point(20, 60);
            this.lblSürüm.Name = "lblSürüm";
            this.lblSürüm.Size = new System.Drawing.Size(0, 23);
            this.lblSürüm.TabIndex = 23;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProgress.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProgress.Location = new System.Drawing.Point(20, 140);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(183, 23);
            this.lblProgress.TabIndex = 22;
            this.lblProgress.Text = "Güncelleme Bekleniyor";
            // 
            // lblYukluSurum
            // 
            this.lblYukluSurum.AutoSize = true;
            this.lblYukluSurum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukluSurum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYukluSurum.Location = new System.Drawing.Point(21, 96);
            this.lblYukluSurum.Name = "lblYukluSurum";
            this.lblYukluSurum.Size = new System.Drawing.Size(80, 13);
            this.lblYukluSurum.TabIndex = 21;
            this.lblYukluSurum.Text = "Yüklü Sürüm : ";
            // 
            // prgDownload
            // 
            this.prgDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prgDownload.Location = new System.Drawing.Point(24, 166);
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(436, 22);
            this.prgDownload.TabIndex = 20;
            // 
            // btnDownload
            // 
            this.btnDownload.BackgroundImage = global::Azutka_Kelime_Bulucu_Updater.Properties.Resources.____Güncelle;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(172, 202);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(148, 33);
            this.btnDownload.TabIndex = 139;
            this.btnDownload.Tag = "Güncelle";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.button8_Click);
            this.btnDownload.MouseLeave += new System.EventHandler(this.button8_MouseLeave);
            this.btnDownload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button8_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 140;
            this.label1.Text = "Azutka Kelime Bulucu Updater";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblYeniSurum);
            this.Controls.Add(this.lblSürüm);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblYukluSurum);
            this.Controls.Add(this.prgDownload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Azutka Kelime Bulucu Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYeniSurum;
        private System.Windows.Forms.Label lblSürüm;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblYukluSurum;
        private System.Windows.Forms.ProgressBar prgDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
    }
}

