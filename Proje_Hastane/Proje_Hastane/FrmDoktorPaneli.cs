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

namespace Proje_Hastane
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi baglan = new sqlbaglantisi();
        public string TC;
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Table_Doktorlar", baglan.bağlanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;


            // branş ekleme
            SqlCommand komut3 = new SqlCommand("Select Bransad from Tbl_Branslar", baglan.bağlanti());
            SqlDataReader rd = komut3.ExecuteReader();
            while (rd.Read())
            {
                cmbbrans.Items.Add(rd[0]).ToString();
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Table_Doktorlar set Doktorad=@p1,Doktorsoyad=@p2,Doktorbrans=@p3,Doktorsifre=@p5 where DoktorTC=@p4", baglan.bağlanti());
            komut3.Parameters.AddWithValue("@p1", txtad.Text);
            komut3.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut3.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut3.Parameters.AddWithValue("@p4", mskTC.Text);
            komut3.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut3.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Başarıyla Güncellendi", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Doktorlar (Doktorad,Doktorsoyad,Doktorbrans,DoktorTC,Doktorsifre) values (@p1,@p2,@p3,@p4,@p5)", baglan.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5",txtsifre.Text);
            komut.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Yeni Doktor Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Table_Doktorlar where DoktorTC=@p1", baglan.bağlanti());
            komut2.Parameters.AddWithValue("@p1", mskTC.Text);
            komut2.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Veri Başarıyla Silindi");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
      
    }
}
