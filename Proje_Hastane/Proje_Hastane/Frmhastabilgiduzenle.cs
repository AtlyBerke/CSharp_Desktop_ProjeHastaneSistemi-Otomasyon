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
    public partial class Frmhastabilgiduzenle : Form
    {
        public Frmhastabilgiduzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Frmhastabilgiduzenle_Load(object sender, EventArgs e)
        {
            MskTextTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", MskTextTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTxtTel.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                Cmbtxtcinsiyet.Text = dr[6].ToString();
            }
            bgl.bağlanti().Close();
        }

        private void btnhastakayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hastalar set Hastaad=@p1,Hastasoyad=@p2,Hastatelefon=@p3,Hastasifre=@p4,Hastacinsiyet=@p5 where HastaTC=@p6",bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTxtTel.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", Cmbtxtcinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", MskTextTC.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
