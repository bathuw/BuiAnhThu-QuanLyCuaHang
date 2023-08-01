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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
        int dem;
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập Còn Trống!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật Khẩu Còn Trống!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }


            if (txtMatKhau.Text == "123456" && txtTaiKhoan.Text == "admin")

            {
                //MessageBox.Show("Đăng Nhập Thành Công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //MessageBox.Show("Đăng Nhập Thất Bại");

                dem++;
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Thông báo");
                this.txtMatKhau.Text = string.Empty;
                this.txtTaiKhoan.Text = string.Empty;
                this.txtTaiKhoan.Focus();

                if (dem == 3)
                {

                    btDangNhap.Enabled = false;
                    frmDNFail fFail = new frmDNFail();
                    this.DialogResult = DialogResult.OK;
                    fFail.ShowDialog();
                    this.Hide();

                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
