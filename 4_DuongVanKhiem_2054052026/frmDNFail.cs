using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DuongVanKhiem_2054052026
{
    public partial class frmDNFail : Form
    {
        public frmDNFail()
        {
            InitializeComponent();
        }
        int i, n;
        private void frmDNFail_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            i = 30;
            n = i;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = n;
            i--;
            this.lbthoigian.Text = "Vui lòng chờ " + i.ToString() + "s để khôi phục lại";
            if (i >= 0)
            {
                progressBar1.Value = i;
            }
            if (i < 0)
            {
                this.timer1.Enabled = false;
                frmDangNhap fLogin = new frmDangNhap();
                fLogin.ShowDialog();
                this.Hide();


            }
        }
    }
}
