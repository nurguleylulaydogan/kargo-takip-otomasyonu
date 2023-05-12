
namespace GorselProje
{
    partial class PersonelGirisFormu
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
            this.buttonPersonel = new System.Windows.Forms.Button();
            this.buttonKargobilgi = new System.Windows.Forms.Button();
            this.buttonMesaiHesapla = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonel
            // 
            this.buttonPersonel.Location = new System.Drawing.Point(92, 71);
            this.buttonPersonel.Name = "buttonPersonel";
            this.buttonPersonel.Size = new System.Drawing.Size(136, 83);
            this.buttonPersonel.TabIndex = 1;
            this.buttonPersonel.Text = "Personel İşlemleri İçin Tıklayın";
            this.buttonPersonel.UseVisualStyleBackColor = true;
            this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
            // 
            // buttonKargobilgi
            // 
            this.buttonKargobilgi.Location = new System.Drawing.Point(12, 222);
            this.buttonKargobilgi.Name = "buttonKargobilgi";
            this.buttonKargobilgi.Size = new System.Drawing.Size(108, 59);
            this.buttonKargobilgi.TabIndex = 2;
            this.buttonKargobilgi.Text = "Kargo Bilgi";
            this.buttonKargobilgi.UseVisualStyleBackColor = true;
            this.buttonKargobilgi.Click += new System.EventHandler(this.buttonKargobilgi_Click);
            // 
            // buttonMesaiHesapla
            // 
            this.buttonMesaiHesapla.Location = new System.Drawing.Point(126, 222);
            this.buttonMesaiHesapla.Name = "buttonMesaiHesapla";
            this.buttonMesaiHesapla.Size = new System.Drawing.Size(75, 59);
            this.buttonMesaiHesapla.TabIndex = 6;
            this.buttonMesaiHesapla.Text = "Mesai Hesapla";
            this.buttonMesaiHesapla.UseVisualStyleBackColor = true;
            this.buttonMesaiHesapla.Click += new System.EventHandler(this.buttonMesaiHesapla_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(237, 222);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(75, 59);
            this.buttonKapat.TabIndex = 7;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // PersonelGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(324, 285);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonMesaiHesapla);
            this.Controls.Add(this.buttonKargobilgi);
            this.Controls.Add(this.buttonPersonel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGirisFormu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPersonel;
        private System.Windows.Forms.Button buttonKargobilgi;
        private System.Windows.Forms.Button buttonMesaiHesapla;
        private System.Windows.Forms.Button buttonKapat;
    }
}