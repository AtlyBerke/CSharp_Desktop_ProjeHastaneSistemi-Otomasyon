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
    public partial class FrmDoktordetay : Form
    {
        public FrmDoktordetay()
        {
            InitializeComponent();
        }
        public string TCC;
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void FrmDoktordetay_Load(object sender, EventArgs e)
        {
            
            lblTC.Text = TCC;
            //Ad Soyad Çekme    

            SqlCommand komut = new SqlCommand("Select Doktorad,Doktorsoyad from Table_Doktorlar where DoktorTC=@p1", baglan.bağlanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lblad.Text = dr[0] + " " + dr[1].ToString();
            }
            
            //Doktora Göre Randevu Listesi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_Randevular where RandevuDoktor='" + Lblad.Text+"'", baglan.bağlanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle doktorbilgi = new FrmDoktorBilgiDüzenle();
            doktorbilgi.TCCC = lblTC.Text;
            doktorbilgi.Show();

        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular duyuru = new FrmDuyurular();
            duyuru.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richtextboxsikayethasta.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
