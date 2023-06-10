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
    public partial class FrmHastadetay : Form
    {
        public FrmHastadetay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnkhastabilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmhastabilgiduzenle frmduzenle = new Frmhastabilgiduzenle();
            frmduzenle.TCno = lblTC.Text;
            frmduzenle.Show();
        }
        
        public string tc;

        sqlbaglantisi baglan = new sqlbaglantisi();
        
        private void FrmHastadetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            

            //ad soyad çekme

            SqlCommand komut = new SqlCommand("Select Hastaad,Hastasoyad From Tbl_Hastalar where HastaTC=@p1", baglan.bağlanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];

            }
            baglan.bağlanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Randevular where HastaTC='" + tc + "'and RandevuDurum=1" , baglan.bağlanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branş Çekme
            SqlCommand komut2 = new SqlCommand("Select * from Tbl_Branslar", baglan.bağlanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[1]); 
            }
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select Doktorad,Doktorsoyad From Table_Doktorlar where Doktorbrans=@p1", baglan.bağlanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            baglan.bağlanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter ad2 = new SqlDataAdapter("Select * from Table_Randevular where RandevuDoktor='" + cmbdoktor.Text + "'and RandevuDurum=0", baglan.bağlanti());
            ad2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut10 = new SqlCommand("update Table_Randevular set RandevuDurum=1,HastaTC=@p1,Hastasikayet=@p2 where Randevuid=@p3", baglan.bağlanti());
            komut10.Parameters.AddWithValue("@p1", lblTC.Text);
            komut10.Parameters.AddWithValue("@p2", richTxtboxsikayet.Text);
            komut10.Parameters.AddWithValue("@p3", textBox1.Text);
            komut10.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
