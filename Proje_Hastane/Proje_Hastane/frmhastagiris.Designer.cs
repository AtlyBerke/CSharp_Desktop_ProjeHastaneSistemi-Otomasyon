namespace Proje_Hastane
{
    partial class frmhastagiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhastagiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktextTC = new System.Windows.Forms.MaskedTextBox();
            this.linkLabeluyeol = new System.Windows.Forms.LinkLabel();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.buttongirisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // msktextTC
            // 
            this.msktextTC.Location = new System.Drawing.Point(201, 124);
            this.msktextTC.Mask = "00000000000";
            this.msktextTC.Name = "msktextTC";
            this.msktextTC.Size = new System.Drawing.Size(157, 30);
            this.msktextTC.TabIndex = 1;
            // 
            // linkLabeluyeol
            // 
            this.linkLabeluyeol.AutoSize = true;
            this.linkLabeluyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabeluyeol.Location = new System.Drawing.Point(224, 279);
            this.linkLabeluyeol.Name = "linkLabeluyeol";
            this.linkLabeluyeol.Size = new System.Drawing.Size(66, 20);
            this.linkLabeluyeol.TabIndex = 4;
            this.linkLabeluyeol.TabStop = true;
            this.linkLabeluyeol.Text = "Üye Ol";
            this.linkLabeluyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabeluyeol_LinkClicked);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(201, 172);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(157, 30);
            this.txtsifre.TabIndex = 2;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // buttongirisyap
            // 
            this.buttongirisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttongirisyap.Location = new System.Drawing.Point(222, 222);
            this.buttongirisyap.Name = "buttongirisyap";
            this.buttongirisyap.Size = new System.Drawing.Size(112, 45);
            this.buttongirisyap.TabIndex = 3;
            this.buttongirisyap.Text = "Giriş Yap";
            this.buttongirisyap.UseVisualStyleBackColor = true;
            this.buttongirisyap.Click += new System.EventHandler(this.buttongirisyap_Click);
            // 
            // frmhastagiris
            // 
            this.AcceptButton = this.buttongirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(469, 395);
            this.Controls.Add(this.buttongirisyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.linkLabeluyeol);
            this.Controls.Add(this.msktextTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmhastagiris";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktextTC;
        private System.Windows.Forms.LinkLabel linkLabeluyeol;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button buttongirisyap;
    }
}