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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void buttongirisyap_Click(object sender, EventArgs e)
        {
     SqlCommand komut=new SqlCommand("Select * from Table_Sekreterler where SekreterTC=@p1 and Sekretersifre=@p2",baglan.bağlanti());
            komut.Parameters.AddWithValue("@p1",msktextTC.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader rd=komut.ExecuteReader();
            if(rd.Read())
	{
	        FrmSekreterDetay skrtr=new FrmSekreterDetay();
            skrtr.sekretertc = msktextTC.Text;
                skrtr.Show();
                this.Hide();
	}
            else
            {
                MessageBox.Show("Parola ya da Şifre Yanlış", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            baglan.bağlanti().Close();
        }
    }
}
