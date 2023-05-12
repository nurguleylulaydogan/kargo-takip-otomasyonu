
namespace GorselProje
{
    partial class Form4
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
            this.dataGridViewForm4 = new System.Windows.Forms.DataGridView();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonKargobayi = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.labelAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForm4
            // 
            this.dataGridViewForm4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForm4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForm4.Location = new System.Drawing.Point(46, 12);
            this.dataGridViewForm4.Name = "dataGridViewForm4";
            this.dataGridViewForm4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForm4.Size = new System.Drawing.Size(721, 220);
            this.dataGridViewForm4.TabIndex = 12;
            this.dataGridViewForm4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForm4_CellContentClick);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(222, 321);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 49);
            this.buttonAra.TabIndex = 21;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonKargobayi
            // 
            this.buttonKargobayi.Location = new System.Drawing.Point(393, 321);
            this.buttonKargobayi.Name = "buttonKargobayi";
            this.buttonKargobayi.Size = new System.Drawing.Size(75, 49);
            this.buttonKargobayi.TabIndex = 22;
            this.buttonKargobayi.Text = "Bayi Bilgileri";
            this.buttonKargobayi.UseVisualStyleBackColor = true;
            this.buttonKargobayi.Click += new System.EventHandler(this.buttonKargobayi_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(156, 270);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(213, 26);
            this.textBoxAra.TabIndex = 23;
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(716, 333);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(75, 53);
            this.buttonKapat.TabIndex = 24;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // labelAra
            // 
            this.labelAra.AutoSize = true;
            this.labelAra.Location = new System.Drawing.Point(102, 278);
            this.labelAra.Name = "labelAra";
            this.labelAra.Size = new System.Drawing.Size(33, 18);
            this.labelAra.TabIndex = 25;
            this.labelAra.Text = "Ara";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(803, 395);
            this.Controls.Add(this.labelAra);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.buttonKargobayi);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.dataGridViewForm4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Bilgi";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewForm4;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonKargobayi;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Label labelAra;
    }
}