﻿using System;
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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        sqlbaglantisi baglan = new sqlbaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Duyurular", baglan.bağlanti());
        da.Fill(dt);
        dataGridView1.DataSource = dt;

        }
    }
}
