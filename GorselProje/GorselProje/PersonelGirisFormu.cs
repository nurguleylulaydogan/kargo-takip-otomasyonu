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
    public partial class PersonelGirisFormu : Form
    {
        public PersonelGirisFormu()
        {
            InitializeComponent();
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void buttonKargobilgi_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void buttonMesaiHesapla_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
