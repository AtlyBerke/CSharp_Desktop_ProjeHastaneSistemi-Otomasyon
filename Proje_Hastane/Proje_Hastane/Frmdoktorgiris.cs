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
    public partial class Frmdoktorgiris : Form
    {
        public Frmdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Table_Doktorlar where DoktorTC=@p1 and Doktorsifre=@p2", baglan.bağlanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktordetay fr = new FrmDoktordetay();
                fr.TCC= maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola Ya da Şifre Yanlış", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }
    }
}
