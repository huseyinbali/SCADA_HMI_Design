namespace TiaPortal_C_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_BaglantiDurum = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl_M1sicaklik = new System.Windows.Forms.Label();
            this.lbl_M2sicaklik = new System.Windows.Forms.Label();
            this.lbl_M3sicaklik = new System.Windows.Forms.Label();
            this.lbl_M1vibration = new System.Windows.Forms.Label();
            this.lbl_M2vibration = new System.Windows.Forms.Label();
            this.lbl_M3vibration = new System.Windows.Forms.Label();
            this.btn_PlcOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Temizle.Location = new System.Drawing.Point(12, 505);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(552, 64);
            this.btn_Temizle.TabIndex = 2;
            this.btn_Temizle.Text = "Listeyi Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bağlantı Durumu : ";
            // 
            // lbl_BaglantiDurum
            // 
            this.lbl_BaglantiDurum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_BaglantiDurum.ForeColor = System.Drawing.Color.Red;
            this.lbl_BaglantiDurum.Location = new System.Drawing.Point(285, 597);
            this.lbl_BaglantiDurum.Name = "lbl_BaglantiDurum";
            this.lbl_BaglantiDurum.Size = new System.Drawing.Size(256, 40);
            this.lbl_BaglantiDurum.TabIndex = 4;
            this.lbl_BaglantiDurum.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl3.Location = new System.Drawing.Point(570, 54);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(256, 40);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Motor1 Sıcaklık : ";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl4.Location = new System.Drawing.Point(570, 123);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(256, 40);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Motor2 Sıcaklık :";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl5.Location = new System.Drawing.Point(570, 196);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(256, 40);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "Motor3 Sıcaklık :";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl6.Location = new System.Drawing.Point(570, 268);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(256, 40);
            this.lbl6.TabIndex = 8;
            this.lbl6.Text = "Motor1 Vibration  :";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl7.Location = new System.Drawing.Point(570, 339);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(256, 40);
            this.lbl7.TabIndex = 9;
            this.lbl7.Text = "Motor2 Vibration  :";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl8.Location = new System.Drawing.Point(570, 417);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(256, 40);
            this.lbl8.TabIndex = 10;
            this.lbl8.Text = "Motor3 Vibration  :";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_M1sicaklik
            // 
            this.lbl_M1sicaklik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_M1sicaklik.Location = new System.Drawing.Point(912, 54);
            this.lbl_M1sicaklik.Name = "lbl_M1sicaklik";
            this.lbl_M1sicaklik.Size = new System.Drawing.Size(256, 40);
            this.lbl_M1sicaklik.TabIndex = 11;
            this.lbl_M1sicaklik.Text = "0";
            this.lbl_M1sicaklik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_M2sicaklik
            // 
            this.lbl_M2sicaklik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_M2sicaklik.Location = new System.Drawing.Point(912, 123);
            this.lbl_M2sicaklik.Name = "lbl_M2sicaklik";
            this.lbl_M2sicaklik.Size = new System.Drawing.Size(256, 40);
            this.lbl_M2sicaklik.TabIndex = 12;
            this.lbl_M2sicaklik.Text = "0";
            this.lbl_M2sicaklik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_M3sicaklik
            // 
            this.lbl_M3sicaklik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_M3sicaklik.Location = new System.Drawing.Point(912, 196);
            this.lbl_M3sicaklik.Name = "lbl_M3sicaklik";
            this.lbl_M3sicaklik.Size = new System.Drawing.Size(256, 40);
            this.lbl_M3sicaklik.TabIndex = 13;
            this.lbl_M3sicaklik.Text = "0";
            this.lbl_M3sicaklik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_M1vibration
            // 
            this.lbl_M1vibration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_M1vibration.Location = new System.Drawing.Point(912, 268);
            this.lbl_M1vibration.Name = "lbl_M1vibration";
            this.lbl_M1vibration.Size = new System.Drawing.Size(256, 40);
            this.lbl_M1vibration.TabIndex = 14;
            this.lbl_M1vibration.Text = "0";
            this.lbl_M1vibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_M2vibration
            // 
            this.lbl_M2vibration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_M2vibration.Location = new System.Drawing.Point(912, 339);
            this.lbl_M2vibration.Name = "lbl_M2vibration";
            this.lbl_M2vibration.Size = new System.Drawing.Size(256, 40);
            this.lbl_M2vibration.TabIndex = 15;
            this.lbl_M2vibration.Text = "0";
            this.lbl_M2vibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_M3vibration
            // 
            this.lbl_M3vibration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_M3vibration.Location = new System.Drawing.Point(912, 417);
            this.lbl_M3vibration.Name = "lbl_M3vibration";
            this.lbl_M3vibration.Size = new System.Drawing.Size(256, 40);
            this.lbl_M3vibration.TabIndex = 16;
            this.lbl_M3vibration.Text = "0";
            this.lbl_M3vibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PlcOku
            // 
            this.btn_PlcOku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_PlcOku.Location = new System.Drawing.Point(576, 505);
            this.btn_PlcOku.Name = "btn_PlcOku";
            this.btn_PlcOku.Size = new System.Drawing.Size(592, 64);
            this.btn_PlcOku.TabIndex = 17;
            this.btn_PlcOku.Text = "PLC\'den verileri çek";
            this.btn_PlcOku.UseVisualStyleBackColor = false;
            this.btn_PlcOku.Click += new System.EventHandler(this.btn_PlcOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(552, 252);
            this.listBox1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiaPortal_C_.Properties.Resources.Automatio;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TiaPortal_C_.Properties.Resources.huusp;
            this.pictureBox2.Location = new System.Drawing.Point(576, 586);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(592, 83);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1192, 699);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_PlcOku);
            this.Controls.Add(this.lbl_M3vibration);
            this.Controls.Add(this.lbl_M2vibration);
            this.Controls.Add(this.lbl_M1vibration);
            this.Controls.Add(this.lbl_M3sicaklik);
            this.Controls.Add(this.lbl_M2sicaklik);
            this.Controls.Add(this.lbl_M1sicaklik);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl_BaglantiDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Motor Takip Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_BaglantiDurum;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl_M1sicaklik;
        private System.Windows.Forms.Label lbl_M2sicaklik;
        private System.Windows.Forms.Label lbl_M3sicaklik;
        private System.Windows.Forms.Label lbl_M1vibration;
        private System.Windows.Forms.Label lbl_M2vibration;
        private System.Windows.Forms.Label lbl_M3vibration;
        private System.Windows.Forms.Button btn_PlcOku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

