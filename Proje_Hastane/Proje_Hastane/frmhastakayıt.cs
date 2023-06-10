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
    public partial class frmhastakayıt : Form
    {
        public frmhastakayıt()
        {
            InitializeComponent();
        }
        
        private void frmhastakayıt_Load(object sender, EventArgs e)
        {
            
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnhastakayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Hastalar (hastaad,hastasoyad,hastaTC,hastatelefon,hastasifre,hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.bağlanti());
            komut1.Parameters.AddWithValue("@p1", txtAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", MskTextTC.Text);
            komut1.Parameters.AddWithValue("@p4", MskTxtTel.Text);
            komut1.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut1.Parameters.AddWithValue("@p6", Cmbtxtcinsiyet.Text);
            komut1.ExecuteNonQuery();
            bgl.bağlanti().Close();
            
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz:" + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
