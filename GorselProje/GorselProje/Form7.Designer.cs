
namespace GorselProje
{
    partial class Form7
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
            this.dataGridViewForm7 = new System.Windows.Forms.DataGridView();
            this.buttonAra = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.Kapat = new System.Windows.Forms.Button();
            this.labelAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForm7
            // 
            this.dataGridViewForm7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForm7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForm7.Location = new System.Drawing.Point(40, 12);
            this.dataGridViewForm7.Name = "dataGridViewForm7";
            this.dataGridViewForm7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForm7.Size = new System.Drawing.Size(678, 183);
            this.dataGridViewForm7.TabIndex = 0;
            this.dataGridViewForm7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForm7_CellContentClick);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(247, 291);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 57);
            this.buttonAra.TabIndex = 1;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(156, 235);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(253, 26);
            this.textBoxAra.TabIndex = 14;
            // 
            // Kapat
            // 
            this.Kapat.Location = new System.Drawing.Point(684, 334);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(75, 40);
            this.Kapat.TabIndex = 15;
            this.Kapat.Text = "Kapat";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // labelAra
            // 
            this.labelAra.AutoSize = true;
            this.labelAra.Location = new System.Drawing.Point(90, 243);
            this.labelAra.Name = "labelAra";
            this.labelAra.Size = new System.Drawing.Size(33, 18);
            this.labelAra.TabIndex = 20;
            this.labelAra.Text = "Ara";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(771, 386);
            this.Controls.Add(this.labelAra);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.dataGridViewForm7);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForm7;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.Label labelAra;
    }
}