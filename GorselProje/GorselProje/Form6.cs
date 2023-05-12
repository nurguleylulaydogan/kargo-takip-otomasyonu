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
    public partial class Form6 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=gorselproje;Integrated Security=True");

        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Kargoekle ", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridViewForm6.DataSource = tablo;
            Con.Close();
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "KARGO EKLEME MENÜSÜ";

            verigoster();
        }
        
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kargoekle (Kargo_Id, Varisadres, Cikisadres, Alici, Teslim, Alicitc, Gonderen) values (@kargo_id, @varis, @cikis, @alici, @teslim, @alicitc, @gonderen)", Con);
            komut.Parameters.AddWithValue("@kargo_id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@varis", textBoxVarısadres.Text);
            komut.Parameters.AddWithValue("@cikis", textBoxCıkısbayiadres.Text);
            komut.Parameters.AddWithValue("@alici", textBoxAlıcıbilgileri.Text);
            komut.Parameters.AddWithValue("@teslim", textBoxTeslimpersonel.Text);
            komut.Parameters.AddWithValue("@alicitc", (textBoxAlıcıtc.Text).ToString());
            komut.Parameters.AddWithValue("@gonderen", textBoxGonderenbilgileri.Text);
            

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Kargo başarıyla kaydedildi");
            verigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Kargoekle where Kargo_Id=@kargo_id";
            SqlCommand komut = new SqlCommand(sorgu, Con);
            komut.Parameters.AddWithValue("@kargo_id", dataGridViewForm6.CurrentRow.Cells[0].Value);
            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Kargo başarıyla silindi.");
            verigoster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Kargoekle set Varisadres=@varis, Cikisadres=@cikis, Alici=@alici, Teslim=@teslim, Alicitc=@alicitc, Gonderen=@gonderen where Kargo_Id=@kargo_id", Con);
            komut.Parameters.AddWithValue("@kargo_id", (textBoxId.Text).ToString());
            komut.Parameters.AddWithValue("@varis", textBoxVarısadres.Text);
            komut.Parameters.AddWithValue("@cikis", textBoxCıkısbayiadres.Text);
            komut.Parameters.AddWithValue("@alici", textBoxAlıcıbilgileri.Text);
            komut.Parameters.AddWithValue("@teslim", textBoxTeslimpersonel.Text);
            komut.Parameters.AddWithValue("@alicitc", (textBoxAlıcıtc.Text).ToString());
            komut.Parameters.AddWithValue("@gonderen", textBoxGonderenbilgileri.Text);

            Con.Open();
            komut.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Kargo başarıyla güncellendi.");
            verigoster();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewForm6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxId.Text = dataGridViewForm6.CurrentRow.Cells[0].Value.ToString();
            //textBoxVarısadres.Text = dataGridViewForm6.CurrentRow.Cells[1].Value.ToString();
            //textBoxCıkısbayiadres.Text = dataGridViewForm6.CurrentRow.Cells[2].Value.ToString();
            //textBoxAlıcıbilgileri.Text = dataGridViewForm6.CurrentRow.Cells[3].Value.ToString();
            //textBoxGonderenbilgileri.Text = dataGridViewForm6.CurrentRow.Cells[4].Value.ToString();
            //textBoxTeslimpersonel.Text = dataGridViewForm6.CurrentRow.Cells[5].Value.ToString();
            //textBoxAlıcıtc.Text = dataGridViewForm6.CurrentRow.Cells[6].Value.ToString();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from Kargoekle where Kargo_Id like '%" + textBoxAra.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridViewForm6.DataSource = tablo.Tables[0];
            Con.Close();
        }

        private void dataGridViewForm6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewForm6.CurrentRow.Cells[0].Value.ToString();
            textBoxVarısadres.Text = dataGridViewForm6.CurrentRow.Cells[1].Value.ToString();
            textBoxCıkısbayiadres.Text = dataGridViewForm6.CurrentRow.Cells[2].Value.ToString();
            textBoxAlıcıbilgileri.Text = dataGridViewForm6.CurrentRow.Cells[3].Value.ToString();
            textBoxGonderenbilgileri.Text = dataGridViewForm6.CurrentRow.Cells[4].Value.ToString();
            textBoxTeslimpersonel.Text = dataGridViewForm6.CurrentRow.Cells[5].Value.ToString();
            textBoxAlıcıtc.Text = dataGridViewForm6.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
