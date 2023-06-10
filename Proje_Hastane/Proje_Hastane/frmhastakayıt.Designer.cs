namespace Proje_Hastane
{
    partial class frmhastakayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskTextTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.Cmbtxtcinsiyet = new System.Windows.Forms.ComboBox();
            this.btnhastakayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasta Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(134, 64);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 36);
            this.txtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(134, 124);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(171, 36);
            this.TxtSoyad.TabIndex = 2;
            // 
            // MskTextTC
            // 
            this.MskTextTC.Location = new System.Drawing.Point(134, 175);
            this.MskTextTC.Mask = "00000000000";
            this.MskTextTC.Name = "MskTextTC";
            this.MskTextTC.Size = new System.Drawing.Size(171, 36);
            this.MskTextTC.TabIndex = 3;
            // 
            // MskTxtTel
            // 
            this.MskTxtTel.Location = new System.Drawing.Point(134, 226);
            this.MskTxtTel.Mask = "(999) 000-0000";
            this.MskTxtTel.Name = "MskTxtTel";
            this.MskTxtTel.Size = new System.Drawing.Size(171, 36);
            this.MskTxtTel.TabIndex = 4;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(134, 275);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(171, 36);
            this.TxtSifre.TabIndex = 5;
            // 
            // Cmbtxtcinsiyet
            // 
            this.Cmbtxtcinsiyet.FormattingEnabled = true;
            this.Cmbtxtcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cmbtxtcinsiyet.Location = new System.Drawing.Point(134, 334);
            this.Cmbtxtcinsiyet.Name = "Cmbtxtcinsiyet";
            this.Cmbtxtcinsiyet.Size = new System.Drawing.Size(171, 36);
            this.Cmbtxtcinsiyet.TabIndex = 6;
            // 
            // btnhastakayıt
            // 
            this.btnhastakayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnhastakayıt.Location = new System.Drawing.Point(148, 396);
            this.btnhastakayıt.Name = "btnhastakayıt";
            this.btnhastakayıt.Size = new System.Drawing.Size(143, 41);
            this.btnhastakayıt.TabIndex = 14;
            this.btnhastakayıt.Text = "Kayıt Yap";
            this.btnhastakayıt.UseVisualStyleBackColor = false;
            this.btnhastakayıt.Click += new System.EventHandler(this.btnhastakayıt_Click);
            // 
            // frmhastakayıt
            // 
            this.AcceptButton = this.btnhastakayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(454, 555);
            this.Controls.Add(this.btnhastakayıt);
            this.Controls.Add(this.Cmbtxtcinsiyet);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTxtTel);
            this.Controls.Add(this.MskTextTC);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmhastakayıt";
            this.Text = "HastaKayıt";
            this.Load += new System.EventHandler(this.frmhastakayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox MskTextTC;
        private System.Windows.Forms.MaskedTextBox MskTxtTel;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.ComboBox Cmbtxtcinsiyet;
        private System.Windows.Forms.Button btnhastakayıt;
    }
}