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
    public partial class Form4 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-PKL2GLS;Initial Catalog=gorselproje;Integrated Security=True");

        private void verigoster()
        {
            if (Con.State.ToString() == "Closed")
            {
                Con.Open();
            }
            SqlCommand komut = new SqlCommand("select * from Kargobilgi ", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridViewForm4.DataSource = tablo;
            Con.Close();
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "KARGO BİLGİ MENÜSÜ";
            verigoster();
        }

        private void buttonKargobayi_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void textBoxVarısadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand komut = new SqlCommand("select * from Kargobilgi where Kargo_Id like '%" + textBoxAra.Text + "%'", Con);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet tablo = new DataSet();
            adp.Fill(tablo);
            dataGridViewForm4.DataSource = tablo.Tables[0];
            Con.Close();
        }

        private void dataGridViewForm4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
