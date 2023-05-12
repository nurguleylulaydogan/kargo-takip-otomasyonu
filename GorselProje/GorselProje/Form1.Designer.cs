
namespace GorselProje
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
            this.butonKapat = new System.Windows.Forms.Button();
            this.labelGiris = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdGiris = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.radioButtonPersonel = new System.Windows.Forms.RadioButton();
            this.radioButtonMusteri = new System.Windows.Forms.RadioButton();
            this.labelYetki = new System.Windows.Forms.Label();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butonKapat
            // 
            this.butonKapat.Location = new System.Drawing.Point(600, 334);
            this.butonKapat.Name = "butonKapat";
            this.butonKapat.Size = new System.Drawing.Size(75, 40);
            this.butonKapat.TabIndex = 3;
            this.butonKapat.Text = "Kapat";
            this.butonKapat.UseVisualStyleBackColor = true;
            this.butonKapat.Click += new System.EventHandler(this.butonKapat_Click);
            // 
            // labelGiris
            // 
            this.labelGiris.AutoSize = true;
            this.labelGiris.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGiris.Location = new System.Drawing.Point(155, 9);
            this.labelGiris.Name = "labelGiris";
            this.labelGiris.Size = new System.Drawing.Size(376, 55);
            this.labelGiris.TabIndex = 4;
            this.labelGiris.Text = "DÜZCE KARGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(183, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(165, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // textBoxAdGiris
            // 
            this.textBoxAdGiris.Location = new System.Drawing.Point(247, 107);
            this.textBoxAdGiris.Name = "textBoxAdGiris";
            this.textBoxAdGiris.Size = new System.Drawing.Size(237, 26);
            this.textBoxAdGiris.TabIndex = 10;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(247, 139);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(237, 26);
            this.textBoxSifre.TabIndex = 11;
            // 
            // radioButtonPersonel
            // 
            this.radioButtonPersonel.AutoSize = true;
            this.radioButtonPersonel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonPersonel.Location = new System.Drawing.Point(247, 171);
            this.radioButtonPersonel.Name = "radioButtonPersonel";
            this.radioButtonPersonel.Size = new System.Drawing.Size(111, 26);
            this.radioButtonPersonel.TabIndex = 12;
            this.radioButtonPersonel.TabStop = true;
            this.radioButtonPersonel.Text = "Personel";
            this.radioButtonPersonel.UseVisualStyleBackColor = true;
            // 
            // radioButtonMusteri
            // 
            this.radioButtonMusteri.AutoSize = true;
            this.radioButtonMusteri.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMusteri.Location = new System.Drawing.Point(247, 207);
            this.radioButtonMusteri.Name = "radioButtonMusteri";
            this.radioButtonMusteri.Size = new System.Drawing.Size(98, 26);
            this.radioButtonMusteri.TabIndex = 13;
            this.radioButtonMusteri.TabStop = true;
            this.radioButtonMusteri.Text = "Müşteri";
            this.radioButtonMusteri.UseVisualStyleBackColor = true;
            // 
            // labelYetki
            // 
            this.labelYetki.AutoSize = true;
            this.labelYetki.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYetki.Location = new System.Drawing.Point(163, 188);
            this.labelYetki.Name = "labelYetki";
            this.labelYetki.Size = new System.Drawing.Size(55, 22);
            this.labelYetki.TabIndex = 14;
            this.labelYetki.Text = "Yetki";
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(409, 188);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(75, 42);
            this.buttonGiris.TabIndex = 15;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(687, 386);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.labelYetki);
            this.Controls.Add(this.radioButtonMusteri);
            this.Controls.Add(this.radioButtonPersonel);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxAdGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGiris);
            this.Controls.Add(this.butonKapat);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Takip Sistemi Nurgül Eylül Aydoğan 201103046";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butonKapat;
        private System.Windows.Forms.Label labelGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdGiris;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.RadioButton radioButtonPersonel;
        private System.Windows.Forms.RadioButton radioButtonMusteri;
        private System.Windows.Forms.Label labelYetki;
        private System.Windows.Forms.Button buttonGiris;
    }
}

