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
    public partial class Form3 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=gorselproje;Integrated Security=True");

        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Personelbilgi ", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridViewForm3.DataSource = tablo;
            Con.Close();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "PERSONEL MENÜSÜ";

            verigoster();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personelbilgi (Personel_Id, Personel_TC, Personel_Ad, Personel_Soyad, Personel_Adres, Personel_Telefon, Personel_Mail) values (@personel_id, @personel_tc, @personel_ad, @personel_soyad, @personel_adres, @personel_telefon, @personel_mail)", Con);
            komut.Parameters.AddWithValue("@personel_id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@personel_tc", (textBoxTC.Text).ToString());
            komut.Parameters.AddWithValue("@personel_ad", textBoxMusteriAd.Text);
            komut.Parameters.AddWithValue("@personel_soyad", textBoxMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@personel_adres", textBoxMusteriAdres.Text);
            komut.Parameters.AddWithValue("@personel_telefon", (textBoxTelefon.Text).ToString());
            komut.Parameters.AddWithValue("@personel_mail", textBoxMail.Text);

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Personel başarıyla kaydedildi");
            verigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Personelbilgi where Personel_Id=@personel_id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@personel_id", dataGridViewForm3.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Personel başarıyla silindi.");
            verigoster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personelbilgi set Personel_TC=@personel_tc, Personel_Ad=@personel_ad, Personel_Soyad=@personel_soyad, Personel_Adres=@personel_adres, Personel_Telefon=@personel_telefon, Personel_Mail=@personel_mail where Personel_Id=@personel_id", Con);
            komut.Parameters.AddWithValue("@personel_TC", (textBoxTC.Text).ToString());
            komut.Parameters.AddWithValue("@personel_ad", textBoxMusteriAd.Text);
            komut.Parameters.AddWithValue("@personel_soyad", textBoxMusteriSoyad.Text);
            komut.Parameters.AddWithValue("@personel_adres", textBoxMusteriAdres.Text);
            komut.Parameters.AddWithValue("@personel_telefon", (textBoxTelefon.Text).ToString());
            komut.Parameters.AddWithValue("@personel_mail", textBoxMail.Text);
            komut.Parameters.AddWithValue("@personel_id", (textBoxId.Text).ToString());

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Personel başarıyla güncellendi.");
            verigoster();
        }

        private void dataGridViewForm3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewForm3.CurrentRow.Cells[0].Value.ToString();
            textBoxTC.Text = dataGridViewForm3.CurrentRow.Cells[1].Value.ToString();
            textBoxMusteriAd.Text = dataGridViewForm3.CurrentRow.Cells[2].Value.ToString();
            textBoxMusteriSoyad.Text = dataGridViewForm3.CurrentRow.Cells[3].Value.ToString();
            textBoxMusteriAdres.Text = dataGridViewForm3.CurrentRow.Cells[4].Value.ToString();
            textBoxTelefon.Text = dataGridViewForm3.CurrentRow.Cells[5].Value.ToString();
            textBoxMail.Text = dataGridViewForm3.CurrentRow.Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMusteriIslemleri_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();

        }

        private void buttonKargoİşlemleri_Click(object sender, EventArgs e)
        {

            Form6 f6 = new Form6();
            f6.Show();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from Personelbilgi where Personel_TC like '%" + textBoxAra.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridViewForm3.DataSource = tablo.Tables[0];
            Con.Close();
        }
        private int gram, tl,tutar;

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
           
            
            
        }
    }
}
