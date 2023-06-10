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
    public partial class FrmBransid : Form
    {
        public FrmBransid()
        {
            InitializeComponent();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void FrmBransid_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", baglan.bağlanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Branslar(Bransad) values (@p1)", baglan.bağlanti());
            komut1.Parameters.AddWithValue("@p1", txtad.Text);
            komut1.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Branş Başarıyla Eklenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2=new SqlCommand("Delete Tbl_Branslar where Bransad=@p1",baglan.bağlanti());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Branş Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Tbl_Branslar set Bransad=@p1 where Bransid=@p2", baglan.bağlanti());
            komut3.Parameters.AddWithValue("@p1", txtad.Text);
            komut3.Parameters.AddWithValue("@p2", txtid.Text);
            komut3.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Branslar Başarıyla Güncellenmiştir");
        }
    }
}
