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
    public partial class Form9 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=gorselproje;Integrated Security=True");

        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Mesaihesapla", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridViewForm9.DataSource = tablo;
            Con.Close();
        }
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Text = "MESAİYE KALAN PERSONEL MENÜSÜ";

            verigoster();


            MesaiHesapla.Ad = "Varsayılan";
            MesaiHesapla.Soyad = "Değer";
            MesaiHesapla.Tc = 00000000000;
            textBoxId.Text = (MesaiHesapla.Tc).ToString();
            textBoxAd.Text = (MesaiHesapla.Ad).ToString();   //Static değişken kullanımı
            textBoxSoyad.Text = (MesaiHesapla.Soyad).ToString();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Mesaihesapla (Personel_Id, Personel_TC, Personel_Ad, Personel_Soyad, Personel_MesaiSaat, Personel_Tutar) values (@personel_id, @personel_tc, @personel_ad, @personel_soyad, @personel_mesaisaat, @personel_tutar)", Con);
            komut.Parameters.AddWithValue("@personel_id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@personel_tc", (textBoxTC.Text).ToString());
            komut.Parameters.AddWithValue("@personel_ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@personel_soyad", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@personel_mesaisaat", (textBoxSaat.Text).ToString());
            komut.Parameters.AddWithValue("@personel_tutar", (textBoxSaatbasitutar.Text).ToString());

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Personel başarıyla kaydedildi");
            verigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Mesaihesapla where Personel_Id=@personel_id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@personel_id", dataGridViewForm9.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Personel başarıyla silindi.");
            verigoster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Mesaihesapla set Personel_TC=@personel_tc, Personel_Ad=@personel_ad, Personel_Soyad=@personel_soyad, Personel_MesaiSaat=@personel_mesaisaat, Personel_Tutar=@personel_tutar where Personel_Id=@personel_id", Con);
            komut.Parameters.AddWithValue("@personel_id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@personel_tc", (textBoxTC.Text).ToString());
            komut.Parameters.AddWithValue("@personel_ad", textBoxAd.Text);
            komut.Parameters.AddWithValue("@personel_soyad", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@personel_mesaisaat", (textBoxSaat.Text).ToString());
            komut.Parameters.AddWithValue("@personel_tutar", (textBoxSaatbasitutar.Text).ToString());
            

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Personel başarıyla güncellendi.");
            verigoster();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from Mesaihesapla where Personel_TC like '%" + textBoxAra.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridViewForm9.DataSource = tablo.Tables[0];
            Con.Close();
        }

        private void dataGridViewForm9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewForm9.CurrentRow.Cells[0].Value.ToString();
            textBoxTC.Text = dataGridViewForm9.CurrentRow.Cells[1].Value.ToString();
            textBoxAd.Text = dataGridViewForm9.CurrentRow.Cells[2].Value.ToString();
            textBoxSoyad.Text = dataGridViewForm9.CurrentRow.Cells[3].Value.ToString();
            textBoxSaat.Text = dataGridViewForm9.CurrentRow.Cells[4].Value.ToString();
            textBoxSaatbasitutar.Text = dataGridViewForm9.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            var tutar = MesaiHesapla.hesapla(int.Parse(textBoxSaat.Text), int.Parse(textBoxSaatbasitutar.Text));
            labelTutaryazdır.Text = tutar.ToString();  //Static metot kullanımı
        
        }
    }
}
