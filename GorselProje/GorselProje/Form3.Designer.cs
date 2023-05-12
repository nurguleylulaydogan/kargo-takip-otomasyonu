
namespace GorselProje
{
    partial class Form3
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
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxMusteriAd = new System.Windows.Forms.TextBox();
            this.textBoxMusteriSoyad = new System.Windows.Forms.TextBox();
            this.textBoxMusteriAdres = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.dataGridViewForm3 = new System.Windows.Forms.DataGridView();
            this.buttonMusteriIslemleri = new System.Windows.Forms.Button();
            this.buttonKargoİşlemleri = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.labelAra = new System.Windows.Forms.Label();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.labelTC = new System.Windows.Forms.Label();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(315, 216);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 36);
            this.buttonEkle.TabIndex = 0;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(315, 258);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 32);
            this.buttonSil.TabIndex = 1;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(315, 296);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(89, 40);
            this.buttonGüncelle.TabIndex = 2;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(824, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(106, 194);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 26);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxMusteriAd
            // 
            this.textBoxMusteriAd.Location = new System.Drawing.Point(106, 258);
            this.textBoxMusteriAd.Name = "textBoxMusteriAd";
            this.textBoxMusteriAd.Size = new System.Drawing.Size(100, 26);
            this.textBoxMusteriAd.TabIndex = 5;
            // 
            // textBoxMusteriSoyad
            // 
            this.textBoxMusteriSoyad.Location = new System.Drawing.Point(106, 290);
            this.textBoxMusteriSoyad.Name = "textBoxMusteriSoyad";
            this.textBoxMusteriSoyad.Size = new System.Drawing.Size(100, 26);
            this.textBoxMusteriSoyad.TabIndex = 6;
            // 
            // textBoxMusteriAdres
            // 
            this.textBoxMusteriAdres.Location = new System.Drawing.Point(106, 322);
            this.textBoxMusteriAdres.Multiline = true;
            this.textBoxMusteriAdres.Name = "textBoxMusteriAdres";
            this.textBoxMusteriAdres.Size = new System.Drawing.Size(169, 56);
            this.textBoxMusteriAdres.TabIndex = 7;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(106, 384);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 26);
            this.textBoxTelefon.TabIndex = 8;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(106, 416);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 26);
            this.textBoxMail.TabIndex = 9;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(55, 197);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 18);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(47, 271);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(28, 18);
            this.labelAd.TabIndex = 11;
            this.labelAd.Text = "Ad";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(22, 303);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(53, 18);
            this.labelSoyad.TabIndex = 12;
            this.labelSoyad.Text = "Soyad";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(25, 340);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(50, 18);
            this.labelAdres.TabIndex = 13;
            this.labelAdres.Text = "Adres";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(18, 373);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(57, 18);
            this.labelTelefon.TabIndex = 14;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(38, 405);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(37, 18);
            this.labelMail.TabIndex = 15;
            this.labelMail.Text = "Mail";
            // 
            // dataGridViewForm3
            // 
            this.dataGridViewForm3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForm3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForm3.Location = new System.Drawing.Point(106, 21);
            this.dataGridViewForm3.Name = "dataGridViewForm3";
            this.dataGridViewForm3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForm3.Size = new System.Drawing.Size(714, 138);
            this.dataGridViewForm3.TabIndex = 16;
            this.dataGridViewForm3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForm3_CellContentClick);
            // 
            // buttonMusteriIslemleri
            // 
            this.buttonMusteriIslemleri.Location = new System.Drawing.Point(790, 165);
            this.buttonMusteriIslemleri.Name = "buttonMusteriIslemleri";
            this.buttonMusteriIslemleri.Size = new System.Drawing.Size(109, 69);
            this.buttonMusteriIslemleri.TabIndex = 17;
            this.buttonMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.buttonMusteriIslemleri.UseVisualStyleBackColor = true;
            this.buttonMusteriIslemleri.Click += new System.EventHandler(this.buttonMusteriIslemleri_Click);
            // 
            // buttonKargoİşlemleri
            // 
            this.buttonKargoİşlemleri.Location = new System.Drawing.Point(790, 237);
            this.buttonKargoİşlemleri.Name = "buttonKargoİşlemleri";
            this.buttonKargoİşlemleri.Size = new System.Drawing.Size(109, 69);
            this.buttonKargoİşlemleri.TabIndex = 18;
            this.buttonKargoİşlemleri.Text = "Kargo İşlemleri";
            this.buttonKargoİşlemleri.UseVisualStyleBackColor = true;
            this.buttonKargoİşlemleri.Click += new System.EventHandler(this.buttonKargoİşlemleri_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(545, 269);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 34);
            this.buttonAra.TabIndex = 19;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(480, 215);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(199, 26);
            this.textBoxAra.TabIndex = 20;
            // 
            // labelAra
            // 
            this.labelAra.AutoSize = true;
            this.labelAra.Location = new System.Drawing.Point(420, 218);
            this.labelAra.Name = "labelAra";
            this.labelAra.Size = new System.Drawing.Size(33, 18);
            this.labelAra.TabIndex = 21;
            this.labelAra.Text = "Ara";
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(790, 308);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(109, 70);
            this.buttonHesapla.TabIndex = 22;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(55, 234);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(29, 18);
            this.labelTC.TabIndex = 24;
            this.labelTC.Text = "TC";
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(106, 226);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(100, 26);
            this.textBoxTC.TabIndex = 23;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(927, 455);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.labelAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.buttonKargoİşlemleri);
            this.Controls.Add(this.buttonMusteriIslemleri);
            this.Controls.Add(this.dataGridViewForm3);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxMusteriAdres);
            this.Controls.Add(this.textBoxMusteriSoyad);
            this.Controls.Add(this.textBoxMusteriAd);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxMusteriAd;
        private System.Windows.Forms.TextBox textBoxMusteriSoyad;
        private System.Windows.Forms.TextBox textBoxMusteriAdres;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.DataGridView dataGridViewForm3;
        private System.Windows.Forms.Button buttonMusteriIslemleri;
        private System.Windows.Forms.Button buttonKargoİşlemleri;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label labelAra;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.TextBox textBoxTC;
    }
}