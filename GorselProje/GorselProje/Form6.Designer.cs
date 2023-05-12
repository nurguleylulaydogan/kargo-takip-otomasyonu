
namespace GorselProje
{
    partial class Form6
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.labelGonderenbilgileri = new System.Windows.Forms.Label();
            this.labelAlıcıbilgileri = new System.Windows.Forms.Label();
            this.labelCıkısadres = new System.Windows.Forms.Label();
            this.labelVarısadres = new System.Windows.Forms.Label();
            this.textBoxGonderenbilgileri = new System.Windows.Forms.TextBox();
            this.textBoxAlıcıbilgileri = new System.Windows.Forms.TextBox();
            this.textBoxCıkısbayiadres = new System.Windows.Forms.TextBox();
            this.textBoxVarısadres = new System.Windows.Forms.TextBox();
            this.dataGridViewForm6 = new System.Windows.Forms.DataGridView();
            this.labelTeslimpersonel = new System.Windows.Forms.Label();
            this.labelAlıcıtc = new System.Windows.Forms.Label();
            this.textBoxTeslimpersonel = new System.Windows.Forms.TextBox();
            this.textBoxAlıcıtc = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.labelAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm6)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(246, 200);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(217, 26);
            this.textBoxId.TabIndex = 31;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(112, 203);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(67, 18);
            this.labelId.TabIndex = 30;
            this.labelId.Text = "Kargo Id";
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(941, 575);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(75, 41);
            this.buttonKapat.TabIndex = 29;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(828, 341);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(84, 41);
            this.buttonGüncelle.TabIndex = 28;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(707, 341);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 41);
            this.buttonSil.TabIndex = 27;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(577, 343);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 39);
            this.buttonEkle.TabIndex = 26;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // labelGonderenbilgileri
            // 
            this.labelGonderenbilgileri.AutoSize = true;
            this.labelGonderenbilgileri.Location = new System.Drawing.Point(52, 575);
            this.labelGonderenbilgileri.Name = "labelGonderenbilgileri";
            this.labelGonderenbilgileri.Size = new System.Drawing.Size(133, 18);
            this.labelGonderenbilgileri.TabIndex = 25;
            this.labelGonderenbilgileri.Text = "Gönderen Bilgileri";
            // 
            // labelAlıcıbilgileri
            // 
            this.labelAlıcıbilgileri.AutoSize = true;
            this.labelAlıcıbilgileri.Location = new System.Drawing.Point(87, 481);
            this.labelAlıcıbilgileri.Name = "labelAlıcıbilgileri";
            this.labelAlıcıbilgileri.Size = new System.Drawing.Size(92, 18);
            this.labelAlıcıbilgileri.TabIndex = 24;
            this.labelAlıcıbilgileri.Text = "Alıcı Bilgileri";
            // 
            // labelCıkısadres
            // 
            this.labelCıkısadres.AutoSize = true;
            this.labelCıkısadres.Location = new System.Drawing.Point(12, 392);
            this.labelCıkısadres.Name = "labelCıkısadres";
            this.labelCıkısadres.Size = new System.Drawing.Size(169, 18);
            this.labelCıkısadres.TabIndex = 23;
            this.labelCıkısadres.Text = "Kargo Çıkış Bayi Adres";
            // 
            // labelVarısadres
            // 
            this.labelVarısadres.AutoSize = true;
            this.labelVarısadres.Location = new System.Drawing.Point(46, 288);
            this.labelVarısadres.Name = "labelVarısadres";
            this.labelVarısadres.Size = new System.Drawing.Size(139, 18);
            this.labelVarısadres.TabIndex = 22;
            this.labelVarısadres.Text = "Kargo Varış Adresi";
            // 
            // textBoxGonderenbilgileri
            // 
            this.textBoxGonderenbilgileri.Location = new System.Drawing.Point(246, 540);
            this.textBoxGonderenbilgileri.Multiline = true;
            this.textBoxGonderenbilgileri.Name = "textBoxGonderenbilgileri";
            this.textBoxGonderenbilgileri.Size = new System.Drawing.Size(217, 83);
            this.textBoxGonderenbilgileri.TabIndex = 21;
            // 
            // textBoxAlıcıbilgileri
            // 
            this.textBoxAlıcıbilgileri.Location = new System.Drawing.Point(246, 446);
            this.textBoxAlıcıbilgileri.Multiline = true;
            this.textBoxAlıcıbilgileri.Name = "textBoxAlıcıbilgileri";
            this.textBoxAlıcıbilgileri.Size = new System.Drawing.Size(217, 88);
            this.textBoxAlıcıbilgileri.TabIndex = 20;
            // 
            // textBoxCıkısbayiadres
            // 
            this.textBoxCıkısbayiadres.Location = new System.Drawing.Point(246, 349);
            this.textBoxCıkısbayiadres.Multiline = true;
            this.textBoxCıkısbayiadres.Name = "textBoxCıkısbayiadres";
            this.textBoxCıkısbayiadres.Size = new System.Drawing.Size(217, 91);
            this.textBoxCıkısbayiadres.TabIndex = 19;
            // 
            // textBoxVarısadres
            // 
            this.textBoxVarısadres.Location = new System.Drawing.Point(246, 248);
            this.textBoxVarısadres.Multiline = true;
            this.textBoxVarısadres.Name = "textBoxVarısadres";
            this.textBoxVarısadres.Size = new System.Drawing.Size(217, 95);
            this.textBoxVarısadres.TabIndex = 18;
            // 
            // dataGridViewForm6
            // 
            this.dataGridViewForm6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForm6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForm6.Location = new System.Drawing.Point(115, 12);
            this.dataGridViewForm6.Name = "dataGridViewForm6";
            this.dataGridViewForm6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForm6.Size = new System.Drawing.Size(808, 158);
            this.dataGridViewForm6.TabIndex = 17;
            this.dataGridViewForm6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForm6_CellClick);
            this.dataGridViewForm6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForm6_CellContentClick);
            // 
            // labelTeslimpersonel
            // 
            this.labelTeslimpersonel.AutoSize = true;
            this.labelTeslimpersonel.Location = new System.Drawing.Point(486, 203);
            this.labelTeslimpersonel.Name = "labelTeslimpersonel";
            this.labelTeslimpersonel.Size = new System.Drawing.Size(159, 18);
            this.labelTeslimpersonel.TabIndex = 32;
            this.labelTeslimpersonel.Text = "Teslim Eden Personel";
            // 
            // labelAlıcıtc
            // 
            this.labelAlıcıtc.AutoSize = true;
            this.labelAlıcıtc.Location = new System.Drawing.Point(584, 251);
            this.labelAlıcıtc.Name = "labelAlıcıtc";
            this.labelAlıcıtc.Size = new System.Drawing.Size(61, 18);
            this.labelAlıcıtc.TabIndex = 33;
            this.labelAlıcıtc.Text = "Alıcı TC";
            // 
            // textBoxTeslimpersonel
            // 
            this.textBoxTeslimpersonel.Location = new System.Drawing.Point(707, 195);
            this.textBoxTeslimpersonel.Name = "textBoxTeslimpersonel";
            this.textBoxTeslimpersonel.Size = new System.Drawing.Size(216, 26);
            this.textBoxTeslimpersonel.TabIndex = 34;
            // 
            // textBoxAlıcıtc
            // 
            this.textBoxAlıcıtc.Location = new System.Drawing.Point(707, 246);
            this.textBoxAlıcıtc.Name = "textBoxAlıcıtc";
            this.textBoxAlıcıtc.Size = new System.Drawing.Size(216, 26);
            this.textBoxAlıcıtc.TabIndex = 35;
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(744, 497);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 41);
            this.buttonAra.TabIndex = 36;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(661, 446);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(234, 26);
            this.textBoxAra.TabIndex = 37;
            // 
            // labelAra
            // 
            this.labelAra.AutoSize = true;
            this.labelAra.Location = new System.Drawing.Point(606, 449);
            this.labelAra.Name = "labelAra";
            this.labelAra.Size = new System.Drawing.Size(33, 18);
            this.labelAra.TabIndex = 38;
            this.labelAra.Text = "Ara";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1028, 632);
            this.Controls.Add(this.labelAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxAlıcıtc);
            this.Controls.Add(this.textBoxTeslimpersonel);
            this.Controls.Add(this.labelAlıcıtc);
            this.Controls.Add(this.labelTeslimpersonel);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.labelGonderenbilgileri);
            this.Controls.Add(this.labelAlıcıbilgileri);
            this.Controls.Add(this.labelCıkısadres);
            this.Controls.Add(this.labelVarısadres);
            this.Controls.Add(this.textBoxGonderenbilgileri);
            this.Controls.Add(this.textBoxAlıcıbilgileri);
            this.Controls.Add(this.textBoxCıkısbayiadres);
            this.Controls.Add(this.textBoxVarısadres);
            this.Controls.Add(this.dataGridViewForm6);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label labelGonderenbilgileri;
        private System.Windows.Forms.Label labelAlıcıbilgileri;
        private System.Windows.Forms.Label labelCıkısadres;
        private System.Windows.Forms.Label labelVarısadres;
        private System.Windows.Forms.TextBox textBoxGonderenbilgileri;
        private System.Windows.Forms.TextBox textBoxAlıcıbilgileri;
        private System.Windows.Forms.TextBox textBoxCıkısbayiadres;
        private System.Windows.Forms.TextBox textBoxVarısadres;
        private System.Windows.Forms.DataGridView dataGridViewForm6;
        private System.Windows.Forms.Label labelTeslimpersonel;
        private System.Windows.Forms.Label labelAlıcıtc;
        private System.Windows.Forms.TextBox textBoxTeslimpersonel;
        private System.Windows.Forms.TextBox textBoxAlıcıtc;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label labelAra;
    }
}