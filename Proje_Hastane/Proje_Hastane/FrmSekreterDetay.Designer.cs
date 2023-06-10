namespace Proje_Hastane
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdsoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Duyurular = new System.Windows.Forms.Button();
            this.btnduyuruolustur = new System.Windows.Forms.Button();
            this.richTextBoxduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.chkdurum = new System.Windows.Forms.CheckBox();
            this.msktxtboxTC = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxdoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxbrans = new System.Windows.Forms.ComboBox();
            this.msktxtboxsaat = new System.Windows.Forms.MaskedTextBox();
            this.msktxtboxtarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnrandevuliste = new System.Windows.Forms.Button();
            this.btnbranspanel = new System.Windows.Forms.Button();
            this.btndoktorpanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.lblAdsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(145, 94);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(145, 29);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "00000000000";
            // 
            // lblAdsoyad
            // 
            this.lblAdsoyad.AutoSize = true;
            this.lblAdsoyad.Location = new System.Drawing.Point(157, 148);
            this.lblAdsoyad.Name = "lblAdsoyad";
            this.lblAdsoyad.Size = new System.Drawing.Size(102, 29);
            this.lblAdsoyad.TabIndex = 2;
            this.lblAdsoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.Duyurular);
            this.groupBox2.Controls.Add(this.btnduyuruolustur);
            this.groupBox2.Controls.Add(this.richTextBoxduyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // Duyurular
            // 
            this.Duyurular.Location = new System.Drawing.Point(24, 307);
            this.Duyurular.Name = "Duyurular";
            this.Duyurular.Size = new System.Drawing.Size(267, 49);
            this.Duyurular.TabIndex = 2;
            this.Duyurular.Text = "Duyurular";
            this.Duyurular.UseVisualStyleBackColor = true;
            this.Duyurular.Click += new System.EventHandler(this.Duyurular_Click);
            // 
            // btnduyuruolustur
            // 
            this.btnduyuruolustur.Location = new System.Drawing.Point(21, 258);
            this.btnduyuruolustur.Name = "btnduyuruolustur";
            this.btnduyuruolustur.Size = new System.Drawing.Size(270, 42);
            this.btnduyuruolustur.TabIndex = 1;
            this.btnduyuruolustur.Text = "Oluştur";
            this.btnduyuruolustur.UseVisualStyleBackColor = true;
            this.btnduyuruolustur.Click += new System.EventHandler(this.btnduyuruolustur_Click);
            // 
            // richTextBoxduyuru
            // 
            this.richTextBoxduyuru.Location = new System.Drawing.Point(21, 35);
            this.richTextBoxduyuru.Name = "richTextBoxduyuru";
            this.richTextBoxduyuru.Size = new System.Drawing.Size(270, 201);
            this.richTextBoxduyuru.TabIndex = 0;
            this.richTextBoxduyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.btnguncelle);
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.chkdurum);
            this.groupBox3.Controls.Add(this.msktxtboxTC);
            this.groupBox3.Controls.Add(this.comboBoxdoktor);
            this.groupBox3.Controls.Add(this.comboBoxbrans);
            this.groupBox3.Controls.Add(this.msktxtboxsaat);
            this.groupBox3.Controls.Add(this.msktxtboxtarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(364, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 564);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(102, 493);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(121, 41);
            this.btnguncelle.TabIndex = 13;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(102, 437);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(121, 41);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // chkdurum
            // 
            this.chkdurum.AutoSize = true;
            this.chkdurum.Location = new System.Drawing.Point(103, 397);
            this.chkdurum.Name = "chkdurum";
            this.chkdurum.Size = new System.Drawing.Size(106, 33);
            this.chkdurum.TabIndex = 12;
            this.chkdurum.Text = "Durum";
            this.chkdurum.UseVisualStyleBackColor = true;
            // 
            // msktxtboxTC
            // 
            this.msktxtboxTC.Location = new System.Drawing.Point(93, 340);
            this.msktxtboxTC.Mask = "00000000000";
            this.msktxtboxTC.Name = "msktxtboxTC";
            this.msktxtboxTC.Size = new System.Drawing.Size(143, 36);
            this.msktxtboxTC.TabIndex = 11;
            // 
            // comboBoxdoktor
            // 
            this.comboBoxdoktor.FormattingEnabled = true;
            this.comboBoxdoktor.Location = new System.Drawing.Point(93, 286);
            this.comboBoxdoktor.Name = "comboBoxdoktor";
            this.comboBoxdoktor.Size = new System.Drawing.Size(143, 36);
            this.comboBoxdoktor.TabIndex = 10;
            // 
            // comboBoxbrans
            // 
            this.comboBoxbrans.FormattingEnabled = true;
            this.comboBoxbrans.Location = new System.Drawing.Point(93, 231);
            this.comboBoxbrans.Name = "comboBoxbrans";
            this.comboBoxbrans.Size = new System.Drawing.Size(143, 36);
            this.comboBoxbrans.TabIndex = 9;
            this.comboBoxbrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxbrans_SelectedIndexChanged);
            // 
            // msktxtboxsaat
            // 
            this.msktxtboxsaat.Location = new System.Drawing.Point(93, 169);
            this.msktxtboxsaat.Mask = "00:00";
            this.msktxtboxsaat.Name = "msktxtboxsaat";
            this.msktxtboxsaat.Size = new System.Drawing.Size(143, 36);
            this.msktxtboxsaat.TabIndex = 8;
            this.msktxtboxsaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtboxtarih
            // 
            this.msktxtboxtarih.Location = new System.Drawing.Point(93, 109);
            this.msktxtboxtarih.Mask = "00/00/0000";
            this.msktxtboxtarih.Name = "msktxtboxtarih";
            this.msktxtboxtarih.Size = new System.Drawing.Size(143, 36);
            this.msktxtboxtarih.TabIndex = 7;
            this.msktxtboxtarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(93, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(143, 36);
            this.txtid.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "TC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(664, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 330);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(560, 313);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(664, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(566, 348);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox7.Controls.Add(this.btnrandevuliste);
            this.groupBox7.Controls.Add(this.btnbranspanel);
            this.groupBox7.Controls.Add(this.btndoktorpanel);
            this.groupBox7.Location = new System.Drawing.Point(329, 589);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(331, 113);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hızlı Erişim";
            // 
            // btnrandevuliste
            // 
            this.btnrandevuliste.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevuliste.Location = new System.Drawing.Point(217, 36);
            this.btnrandevuliste.Name = "btnrandevuliste";
            this.btnrandevuliste.Size = new System.Drawing.Size(112, 71);
            this.btnrandevuliste.TabIndex = 2;
            this.btnrandevuliste.Text = "Randevu Liste";
            this.btnrandevuliste.UseVisualStyleBackColor = true;
            this.btnrandevuliste.Click += new System.EventHandler(this.btnrandevuliste_Click);
            // 
            // btnbranspanel
            // 
            this.btnbranspanel.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbranspanel.Location = new System.Drawing.Point(116, 35);
            this.btnbranspanel.Name = "btnbranspanel";
            this.btnbranspanel.Size = new System.Drawing.Size(95, 71);
            this.btnbranspanel.TabIndex = 1;
            this.btnbranspanel.Text = "Branş Paneli";
            this.btnbranspanel.UseVisualStyleBackColor = true;
            this.btnbranspanel.Click += new System.EventHandler(this.btnbranspanel_Click);
            // 
            // btndoktorpanel
            // 
            this.btndoktorpanel.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndoktorpanel.Location = new System.Drawing.Point(9, 36);
            this.btndoktorpanel.Name = "btndoktorpanel";
            this.btndoktorpanel.Size = new System.Drawing.Size(101, 71);
            this.btndoktorpanel.TabIndex = 0;
            this.btndoktorpanel.Text = "Doktor Paneli";
            this.btndoktorpanel.UseVisualStyleBackColor = true;
            this.btndoktorpanel.Click += new System.EventHandler(this.btndoktorpanel_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1242, 714);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAdsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnduyuruolustur;
        private System.Windows.Forms.RichTextBox richTextBoxduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.CheckBox chkdurum;
        private System.Windows.Forms.MaskedTextBox msktxtboxTC;
        private System.Windows.Forms.ComboBox comboBoxdoktor;
        private System.Windows.Forms.ComboBox comboBoxbrans;
        private System.Windows.Forms.MaskedTextBox msktxtboxsaat;
        private System.Windows.Forms.MaskedTextBox msktxtboxtarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnrandevuliste;
        private System.Windows.Forms.Button btnbranspanel;
        private System.Windows.Forms.Button btndoktorpanel;
        private System.Windows.Forms.Button Duyurular;
    }
}