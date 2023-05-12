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
    public partial class Form5 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=gorselproje;Integrated Security=True");

        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Musteribilgi ", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridViewForm5.DataSource = tablo;
            Con.Close();
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridViewForm5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewForm5.CurrentRow.Cells[0].Value.ToString();
            textBoxTC.Text = dataGridViewForm5.CurrentRow.Cells[1].Value.ToString();
            textBoxMusteriAd.Text = dataGridViewForm5.CurrentRow.Cells[2].Value.ToString();
            textBoxMusteriSoyad.Text = dataGridViewForm5.CurrentRow.Cells[3].Value.ToString();
            textBoxMusteriAdres.Text = dataGridViewForm5.CurrentRow.Cells[4].Value.ToString();
            textBoxTelefon.Text = dataGridViewForm5.CurrentRow.Cells[5].Value.ToString();
            textBoxMail.Text = dataGridViewForm5.CurrentRow.Cells[6].Value.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            this.Text = "PERSONEL MÜŞTERİ MENÜSÜ GÖRÜNTÜLEME";

            verigoster();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Musteribilgi (Musteri_Id, Musteri_TC, Musteri_Ad, Musteri_Soyad, Musteri_Adres, Musteri_Telefon, Musteri_Mail) values (@musteri_id, @musteri_tc, @musteri_ad, @musteri_soyad, @musteri_adres, @musteri_telefon, @musteri_mail)", Con);
            komut.Parameters.AddWithValue("@musteri_id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@musteri_tc", (textBoxTC.Text).ToString());
            komut.Parameters.AddWithValue("@musteri_ad", textBoxMusteriAd.Text);
            komut.Parameters.AddWithValue("@musteri_soyad", textBoxMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@musteri_adres", textBoxMusteriAdres.Text);
            komut.Parameters.AddWithValue("@musteri_telefon", (textBoxTelefon.Text).ToString());
            komut.Parameters.AddWithValue("@musteri_mail", textBoxMail.Text);

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Müşteri başarıyla kaydedildi");
            verigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Musteribilgi where Musteri_Id=@musteri_id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@musteri_id", dataGridViewForm5.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Müşteri başarıyla silindi.");
            verigoster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Musteribilgi set Musteri_TC=@musteri_tc, Musteri_Ad=@musteri_ad, Musteri_Soyad=@musteri_soyad, Musteri_Adres=@musteri_adres, Musteri_Telefon=@musteri_telefon, Musteri_Mail=@musteri_mail where Musteri_Id=@musteri_id", Con);
            komut.Parameters.AddWithValue("@musteri_id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@musteri_tc", (textBoxTC.Text).ToString());
            komut.Parameters.AddWithValue("@musteri_ad", textBoxMusteriAd.Text);
            komut.Parameters.AddWithValue("@musteri_soyad", textBoxMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@musteri_adres", textBoxMusteriAdres.Text);
            komut.Parameters.AddWithValue("@musteri_telefon", (textBoxTelefon.Text).ToString());
            komut.Parameters.AddWithValue("@musteri_mail", textBoxMail.Text);
           

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Müşteri başarıyla güncellendi.");
            verigoster();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from Musteribilgi where Musteri_TC like '%" + textBoxAra.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridViewForm5.DataSource = tablo.Tables[0];
            Con.Close();
        }
    }
}
