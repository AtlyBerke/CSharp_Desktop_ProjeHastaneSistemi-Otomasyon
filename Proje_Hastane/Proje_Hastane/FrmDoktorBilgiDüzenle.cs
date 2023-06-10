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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCCC;
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_Doktorlar set Doktorad=@p1,Doktorsoyad=@p2,DoktorBrans=@p3,Doktorsifre=@p4 where DoktorTC=@p5", baglan.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5",mskTC.Text);
            komut.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCCC;
      
            SqlCommand komut2=new SqlCommand("Select * from Table_Doktorlar where DoktorTC=@s1",baglan.bağlanti());
            komut2.Parameters.AddWithValue("@s1",mskTC.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            baglan.bağlanti().Close();

        }
    }
}
