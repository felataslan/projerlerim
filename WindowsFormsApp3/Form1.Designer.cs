namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.not = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.fotograf = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cinsiyet = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.YazılımDilleri = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotograf)).BeginInit();
            this.Cinsiyet.SuspendLayout();
            this.YazılımDilleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Üni. bitirme notunuz:";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(115, 99);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(100, 26);
            this.ad.TabIndex = 5;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(115, 140);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(100, 26);
            this.soyad.TabIndex = 6;
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(115, 182);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(39, 26);
            this.yas.TabIndex = 7;
            // 
            // not
            // 
            this.not.Location = new System.Drawing.Point(248, 270);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(100, 26);
            this.not.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 33);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kadın";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(95, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 33);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // fotograf
            // 
            this.fotograf.Image = ((System.Drawing.Image)(resources.GetObject("fotograf.Image")));
            this.fotograf.Location = new System.Drawing.Point(121, 12);
            this.fotograf.Name = "fotograf";
            this.fotograf.Size = new System.Drawing.Size(121, 81);
            this.fotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotograf.TabIndex = 11;
            this.fotograf.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fotoğraf:";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(113, 319);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(127, 26);
            this.telefon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon:";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Controls.Add(this.radioButton2);
            this.Cinsiyet.Controls.Add(this.radioButton1);
            this.Cinsiyet.Location = new System.Drawing.Point(158, 223);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(190, 36);
            this.Cinsiyet.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(582, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 204);
            this.listBox1.TabIndex = 16;
            // 
            // YazılımDilleri
            // 
            this.YazılımDilleri.Controls.Add(this.checkBox4);
            this.YazılımDilleri.Controls.Add(this.checkBox3);
            this.YazılımDilleri.Controls.Add(this.checkBox2);
            this.YazılımDilleri.Controls.Add(this.checkBox1);
            this.YazılımDilleri.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YazılımDilleri.Location = new System.Drawing.Point(18, 351);
            this.YazılımDilleri.Name = "YazılımDilleri";
            this.YazılımDilleri.Size = new System.Drawing.Size(314, 198);
            this.YazılımDilleri.TabIndex = 17;
            this.YazılımDilleri.TabStop = false;
            this.YazılımDilleri.Text = "Yazılım Dilleri";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 159);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(139, 33);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Javascript";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 116);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 33);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Java";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 33);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Python";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 33);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "C#";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Başvuruyu Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(868, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YazılımDilleri);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fotograf);
            this.Controls.Add(this.not);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "İş Başvuru Formu";
            ((System.ComponentModel.ISupportInitialize)(this.fotograf)).EndInit();
            this.Cinsiyet.ResumeLayout(false);
            this.Cinsiyet.PerformLayout();
            this.YazılımDilleri.ResumeLayout(false);
            this.YazılımDilleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.TextBox not;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox fotograf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Cinsiyet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox YazılımDilleri;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}

