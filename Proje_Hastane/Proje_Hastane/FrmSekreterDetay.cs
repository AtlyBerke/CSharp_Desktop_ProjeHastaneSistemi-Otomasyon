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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public string sekretertc;
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = sekretertc;

            // tcye göre isim taşıma
            SqlCommand komut = new SqlCommand("Select Sekreteradsoyad from Table_Sekreterler where SekreterTC=@p1", baglan.bağlanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdsoyad.Text = dr[0].ToString();
            }
            baglan.bağlanti().Close();


            // Branşları Datagride Aktarma

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Bransad from Tbl_Branslar", baglan.bağlanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Doktorları Datagride Çekme    

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2= new SqlDataAdapter("Select (Doktorad+' '+Doktorsoyad),Doktorbrans from Table_Doktorlar", baglan.bağlanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Brans Çekme
            SqlCommand komut4 = new SqlCommand("Select Bransad from Tbl_Branslar", baglan.bağlanti());
            SqlDataReader rd4 = komut4.ExecuteReader();
            while (rd4.Read())
            {
                comboBoxbrans.Items.Add(rd4[0]);   
            }

            

            


            

            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3=new SqlCommand("insert into Table_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@p1,@p2,@p3,@p4)",baglan.bağlanti());
            komut3.Parameters.AddWithValue("@p1", msktxtboxtarih.Text);
            komut3.Parameters.AddWithValue("@p2", msktxtboxsaat.Text);
            komut3.Parameters.AddWithValue("@p3", comboBoxbrans.Text);
            komut3.Parameters.AddWithValue("@p4", comboBoxdoktor.Text);            
            komut3.ExecuteNonQuery();
            baglan.bağlanti().Close();
            MessageBox.Show("Randevu Başarıyla Eklenmiştir");
        }

        private void comboBoxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxdoktor.Items.Clear();

            SqlCommand komut5 = new SqlCommand("Select Doktorad,Doktorsoyad From Table_Doktorlar where Doktorbrans=@p1", baglan.bağlanti());
            komut5.Parameters.AddWithValue("@p1", comboBoxbrans.Text);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                comboBoxdoktor.Items.Add(dr5[0] + " " + dr5[1]);  
            }
            baglan.bağlanti().Close();

        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut6 = new SqlCommand("insert into Tbl_Duyurular(Duyurular) values (@p1)", baglan.bağlanti());
            komut6.Parameters.AddWithValue("@p1", richTextBoxduyuru.Text);
            komut6.ExecuteNonQuery();           
            baglan.bağlanti().Close();
            MessageBox.Show("Duyuru Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli doktorpaneli = new FrmDoktorPaneli();
            doktorpaneli.Show();
            
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi randevupaneli = new FrmRandevuListesi();
            randevupaneli.Show();
            
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            FrmBransid branspaneli = new FrmBransid();
            branspaneli.Show();
            
        }

        private void Duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
            
        }
    }
}
