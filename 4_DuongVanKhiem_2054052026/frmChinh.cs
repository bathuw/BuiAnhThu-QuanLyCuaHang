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
    public partial class frmChinh : Form
{
    public frmChinh()
    {
        InitializeComponent();
    }

    private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmDangNhap dangnhap = new frmDangNhap();
        if (dangnhap.ShowDialog() == DialogResult.OK)
        {
            this.quảnLýTràSữaToolStripMenuItem.Enabled = true;
            this.đăngXuấtToolStripMenuItem.Visible = true;
            this.đăngNhậpToolStripMenuItem.Visible = false;
            this.pictureBox1.Visible = false;
        }
    }

    private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.quảnLýTràSữaToolStripMenuItem.Enabled = false;
        this.đăngNhậpToolStripMenuItem.Visible = true;
        this.đăngXuấtToolStripMenuItem.Visible = false;
    
    }

    private void quảnLýTràSữaToolStripMenuItem_Click(object sender, EventArgs e)
    {
            //frmQuanLi formQuanli = new frmQuanLi();
            //formQuanli.Show();
            frmQuanLi f = new frmQuanLi();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }
    }
}


