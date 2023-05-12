
namespace GorselProje
{
    partial class Form8
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
            this.labelGram = new System.Windows.Forms.Label();
            this.labelTl = new System.Windows.Forms.Label();
            this.textBoxGram = new System.Windows.Forms.TextBox();
            this.textBoxGramfiyatı = new System.Windows.Forms.TextBox();
            this.labelTutar = new System.Windows.Forms.Label();
            this.labelTutaryazdır = new System.Windows.Forms.Label();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGram
            // 
            this.labelGram.AutoSize = true;
            this.labelGram.Location = new System.Drawing.Point(116, 35);
            this.labelGram.Name = "labelGram";
            this.labelGram.Size = new System.Drawing.Size(94, 18);
            this.labelGram.TabIndex = 0;
            this.labelGram.Text = "Kargo Gram";
            // 
            // labelTl
            // 
            this.labelTl.AutoSize = true;
            this.labelTl.Location = new System.Drawing.Point(122, 80);
            this.labelTl.Name = "labelTl";
            this.labelTl.Size = new System.Drawing.Size(88, 18);
            this.labelTl.TabIndex = 1;
            this.labelTl.Text = "Gram Fiyatı";
            // 
            // textBoxGram
            // 
            this.textBoxGram.Location = new System.Drawing.Point(231, 32);
            this.textBoxGram.Name = "textBoxGram";
            this.textBoxGram.Size = new System.Drawing.Size(123, 26);
            this.textBoxGram.TabIndex = 2;
            // 
            // textBoxGramfiyatı
            // 
            this.textBoxGramfiyatı.Location = new System.Drawing.Point(231, 72);
            this.textBoxGramfiyatı.Name = "textBoxGramfiyatı";
            this.textBoxGramfiyatı.Size = new System.Drawing.Size(123, 26);
            this.textBoxGramfiyatı.TabIndex = 3;
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Location = new System.Drawing.Point(160, 135);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(42, 18);
            this.labelTutar.TabIndex = 4;
            this.labelTutar.Text = "Tutar";
            // 
            // labelTutaryazdır
            // 
            this.labelTutaryazdır.AutoSize = true;
            this.labelTutaryazdır.Location = new System.Drawing.Point(231, 135);
            this.labelTutaryazdır.Name = "labelTutaryazdır";
            this.labelTutaryazdır.Size = new System.Drawing.Size(63, 18);
            this.labelTutaryazdır.TabIndex = 5;
            this.labelTutaryazdır.Text = "-----------";
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(206, 186);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(75, 42);
            this.buttonHesapla.TabIndex = 6;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(412, 244);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(75, 42);
            this.buttonKapat.TabIndex = 7;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(499, 298);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.labelTutaryazdır);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.textBoxGramfiyatı);
            this.Controls.Add(this.textBoxGram);
            this.Controls.Add(this.labelTl);
            this.Controls.Add(this.labelGram);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGram;
        private System.Windows.Forms.Label labelTl;
        private System.Windows.Forms.TextBox textBoxGram;
        private System.Windows.Forms.TextBox textBoxGramfiyatı;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Label labelTutaryazdır;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Button buttonKapat;
    }
}