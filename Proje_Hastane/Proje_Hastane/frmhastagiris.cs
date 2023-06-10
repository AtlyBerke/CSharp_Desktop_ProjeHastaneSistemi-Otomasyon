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
    public partial class frmhastagiris : Form
    {
        public frmhastagiris()
        {
            InitializeComponent();
        }

        private void linkLabeluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhastakayıt frhastakayıt = new frmhastakayıt();
            frhastakayıt.Show();
            
        }
        sqlbaglantisi baglanti = new sqlbaglantisi();
        private void buttongirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where hastaTC=@p1 and hastasifre=@p2", baglanti.bağlanti());
            komut.Parameters.AddWithValue("@p1", msktextTC.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader rd = komut.ExecuteReader();
            if (rd.Read())
            {
                FrmHastadetay hastadty = new FrmHastadetay();
                hastadty.tc = msktextTC.Text;                
                hastadty.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola ya da Şifre Yanlış", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
