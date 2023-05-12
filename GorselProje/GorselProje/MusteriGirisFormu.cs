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
    public partial class MusteriGirisFormu : Form
    {
        public MusteriGirisFormu()
        {
            InitializeComponent();
        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void buttonKargobilgi_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
