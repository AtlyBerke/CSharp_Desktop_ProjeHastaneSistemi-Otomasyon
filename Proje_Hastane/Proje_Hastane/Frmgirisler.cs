using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Frmgirisler : Form
    {
        public Frmgirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhastagiris frmhasta = new frmhastagiris();
            frmhasta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmdoktorgiris doktorgiris = new Frmdoktorgiris();
            doktorgiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frsekreter = new FrmSekreterGiris();
            frsekreter.Show();
            this.Hide();
        }
    }
}
