using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProje
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
           var tutar= Hesaplama.islem(int.Parse(textBoxGram.Text),int.Parse(textBoxGramfiyatı.Text));
            //textboxtaki değerlerin alınabilmesi için textboxtakları yazmalıyız.
            labelTutaryazdır.Text = tutar.ToString();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Text = "KARGO TUTARI HESAPLAMA MENÜSÜ";
        }
    }
}
