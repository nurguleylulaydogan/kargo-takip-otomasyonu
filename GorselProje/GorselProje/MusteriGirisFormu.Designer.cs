
namespace GorselProje
{
    partial class MusteriGirisFormu
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
            this.buttonMusteri = new System.Windows.Forms.Button();
            this.buttonKargobilgi = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusteri
            // 
            this.buttonMusteri.Location = new System.Drawing.Point(85, 70);
            this.buttonMusteri.Name = "buttonMusteri";
            this.buttonMusteri.Size = new System.Drawing.Size(151, 80);
            this.buttonMusteri.TabIndex = 0;
            this.buttonMusteri.Text = "Müşteri Bilgilerini Düzenlemek İçin Tıklayın";
            this.buttonMusteri.UseVisualStyleBackColor = true;
            this.buttonMusteri.Click += new System.EventHandler(this.buttonMusteri_Click);
            // 
            // buttonKargobilgi
            // 
            this.buttonKargobilgi.Location = new System.Drawing.Point(12, 208);
            this.buttonKargobilgi.Name = "buttonKargobilgi";
            this.buttonKargobilgi.Size = new System.Drawing.Size(107, 57);
            this.buttonKargobilgi.TabIndex = 1;
            this.buttonKargobilgi.Text = "Kargo Bilgi";
            this.buttonKargobilgi.UseVisualStyleBackColor = true;
            this.buttonKargobilgi.Click += new System.EventHandler(this.buttonKargobilgi_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(245, 208);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(75, 57);
            this.buttonKapat.TabIndex = 2;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // MusteriGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(332, 277);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonKargobilgi);
            this.Controls.Add(this.buttonMusteri);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriGirisFormu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMusteri;
        private System.Windows.Forms.Button buttonKargobilgi;
        private System.Windows.Forms.Button buttonKapat;
    }
}