using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GorselProje
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=gorselproje;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        public static string Id, Ad, Soyad, Yetki;

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from Giris", Con);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read()==true)
            {
                if (radioButtonPersonel.Checked==true)
                {
                    if (rdr["Ad"].ToString()==textBoxAdGiris.Text&& rdr["Sifre"].ToString()==textBoxSifre.Text&& rdr["Yetki"].ToString()=="Personel")
                    {
                        durum = true;
                        PersonelGirisFormu PerForm = new PersonelGirisFormu();
                        PerForm.Show();
                        break;
                    }
                }

                if (radioButtonMusteri.Checked == true)
                {
                    if (rdr["Ad"].ToString() == textBoxAdGiris.Text && rdr["Sifre"].ToString() == textBoxSifre.Text && rdr["Yetki"].ToString() == "Müşteri")
                    {
                        durum = true;
                        MusteriGirisFormu MusForm = new MusteriGirisFormu();
                        MusForm.Show();
                        break;
                    }
                }
            }
            Con.Close();
        }

        bool durum = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "GİRİŞ MENÜSÜ";
            this.AcceptButton = buttonGiris;
            this.CancelButton = butonKapat;
            radioButtonPersonel.Checked = true;

        }
        
        private void butonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
    }
}
