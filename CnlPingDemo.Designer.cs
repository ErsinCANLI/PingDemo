namespace Not
{
    partial class CnlPingDemo
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CnlPingDemo));
            this.TxtIp1 = new System.Windows.Forms.TextBox();
            this.TxtIp2 = new System.Windows.Forms.TextBox();
            this.BtnSorgula = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Online = new System.Windows.Forms.PictureBox();
            this.Offline = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGrafik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Online)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Offline)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIp1
            // 
            this.TxtIp1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIp1.Location = new System.Drawing.Point(20, 82);
            this.TxtIp1.MaxLength = 15;
            this.TxtIp1.Name = "TxtIp1";
            this.TxtIp1.Size = new System.Drawing.Size(249, 33);
            this.TxtIp1.TabIndex = 0;
            this.TxtIp1.Text = "192.168.2.1";
            // 
            // TxtIp2
            // 
            this.TxtIp2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIp2.Location = new System.Drawing.Point(27, 78);
            this.TxtIp2.MaxLength = 15;
            this.TxtIp2.Name = "TxtIp2";
            this.TxtIp2.Size = new System.Drawing.Size(221, 33);
            this.TxtIp2.TabIndex = 0;
            this.TxtIp2.Text = "192.168.1.1";
            // 
            // BtnSorgula
            // 
            this.BtnSorgula.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSorgula.Location = new System.Drawing.Point(20, 138);
            this.BtnSorgula.Name = "BtnSorgula";
            this.BtnSorgula.Size = new System.Drawing.Size(153, 36);
            this.BtnSorgula.TabIndex = 1;
            this.BtnSorgula.Text = "Sorgula";
            this.BtnSorgula.UseVisualStyleBackColor = true;
            this.BtnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl1.Location = new System.Drawing.Point(20, 198);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(84, 24);
            this.Lbl1.TabIndex = 2;
            this.Lbl1.Text = "SONUÇ";
            this.Lbl1.Visible = false;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl2.Location = new System.Drawing.Point(20, 53);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(103, 24);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "IP ADRESİ";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl3.Location = new System.Drawing.Point(22, 49);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(103, 24);
            this.Lbl3.TabIndex = 2;
            this.Lbl3.Text = "IP ADRESİ";
            // 
            // Online
            // 
            this.Online.Image = ((System.Drawing.Image)(resources.GetObject("Online.Image")));
            this.Online.Location = new System.Drawing.Point(27, 194);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(68, 68);
            this.Online.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Online.TabIndex = 3;
            this.Online.TabStop = false;
            this.Online.Visible = false;
            // 
            // Offline
            // 
            this.Offline.Image = ((System.Drawing.Image)(resources.GetObject("Offline.Image")));
            this.Offline.Location = new System.Drawing.Point(101, 194);
            this.Offline.Name = "Offline";
            this.Offline.Size = new System.Drawing.Size(68, 68);
            this.Offline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Offline.TabIndex = 3;
            this.Offline.TabStop = false;
            this.Offline.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl2);
            this.groupBox1.Controls.Add(this.TxtIp1);
            this.groupBox1.Controls.Add(this.BtnSorgula);
            this.groupBox1.Controls.Add(this.Lbl1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 290);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buton";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGrafik);
            this.groupBox2.Controls.Add(this.TxtIp2);
            this.groupBox2.Controls.Add(this.Lbl3);
            this.groupBox2.Controls.Add(this.Offline);
            this.groupBox2.Controls.Add(this.Online);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(328, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 286);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafik";
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.Location = new System.Drawing.Point(26, 134);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(222, 36);
            this.BtnGrafik.TabIndex = 4;
            this.BtnGrafik.Text = "Sorgula";
            this.BtnGrafik.UseVisualStyleBackColor = true;
            this.BtnGrafik.Click += new System.EventHandler(this.BtnGrafik_Click);
            // 
            // CnlPingDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CnlPingDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Online)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Offline)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIp1;
        private System.Windows.Forms.TextBox TxtIp2;
        private System.Windows.Forms.Button BtnSorgula;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.PictureBox Online;
        private System.Windows.Forms.PictureBox Offline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGrafik;
    }
}

