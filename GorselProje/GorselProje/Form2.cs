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
    public partial class Form2 : Form
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
            dataGridViewForm2.DataSource = tablo;
            Con.Close();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "MÜŞTERİ MENÜSÜ";

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
            komut.Parameters.AddWithValue("@musteri_telefon",(textBoxTelefon.Text).ToString());
            komut.Parameters.AddWithValue("@musteri_mail", textBoxMail.Text);
           

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Müşteri başarıyla güncellendi.");
            verigoster();
        }

        private void dataGridViewForm2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewForm2.CurrentRow.Cells[0].Value.ToString();
            textBoxTC.Text = dataGridViewForm2.CurrentRow.Cells[1].Value.ToString();
            textBoxMusteriAd.Text = dataGridViewForm2.CurrentRow.Cells[2].Value.ToString();
            textBoxMusteriSoyad.Text = dataGridViewForm2.CurrentRow.Cells[3].Value.ToString();
            textBoxMusteriAdres.Text = dataGridViewForm2.CurrentRow.Cells[4].Value.ToString();
            textBoxTelefon.Text = dataGridViewForm2.CurrentRow.Cells[5].Value.ToString();
            textBoxMail.Text = dataGridViewForm2.CurrentRow.Cells[6].Value.ToString();

        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from Musteribilgi where Musteri_TC like '%"+textBoxAra.Text+"%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridViewForm2.DataSource = tablo.Tables[0];
            Con.Close();
        }
    }
}
