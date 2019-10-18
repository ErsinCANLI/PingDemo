using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Not
{
    public partial class CnlPingDemo : Form
    {
        public CnlPingDemo()
        {
            InitializeComponent();
        }

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            Ping sorgula = new Ping();
            PingReply PingCevabi = sorgula.Send(TxtIp1.Text);
            if (PingCevabi.Status==IPStatus.Success)
            {
                Lbl1.Visible = true;
                Lbl1.Text = "Cihaz ile iletişim sağlandı.";
                Lbl1.ForeColor = Color.Green;
            }
            else
            {
                Lbl1.Visible = true;
                Lbl1.Text = "Cihaza Ulaşılamıyor!";
                Lbl1.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {

            Ping sorgu = new Ping();
            PingReply pingcevap = sorgu.Send(TxtIp2.Text);
            if (pingcevap.Status == IPStatus.Success)
            {
                Online.Visible = true;
                Offline.Visible = false;

            }
            else
            {
                Offline.Visible = true;
                Online.Visible = false;
            }
        }
    }
}
