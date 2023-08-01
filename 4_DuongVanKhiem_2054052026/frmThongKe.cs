using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _4_DuongVanKhiem_2054052026
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        //
        Point pt = new Point(0, 60);
        public int tongban1;
        public int tongban2;
        public int tongban3;
        public int tongban4;
        public int tongban5;
        public int tongban6;
        //
        int tongthuduoc;

        string newstr;
        private void Thongke_Load(object sender, EventArgs e)
        {

            Tongban1txt.Text = tongban1.ToString() + ".000 VNĐ";
            Tongban2txt.Text = tongban2.ToString() + ".000 VNĐ";
            Tongban3txt.Text = tongban3.ToString() + ".000 VNĐ";
            Tongban4txt.Text = tongban4.ToString() + ".000 VNĐ";
            Tongban5txt.Text = tongban5.ToString() + ".000 VNĐ";
            Tongban6txt.Text = tongban6.ToString() + ".000 VNĐ";
        }

        private void btnTongthuduoc_Click(object sender, EventArgs e)
        {
            tongthuduoc = tongban1 + tongban2 + tongban3 + tongban4 + tongban5 + tongban6;
            txtTongthuduoc.Text = tongthuduoc.ToString() + ".000 VNĐ";
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    throw new Exception("Bạn phải nhập tên file txt");

                }
                newstr = textBox1.Text.Substring(textBox1.Text.Length - 4, 4);
                if (newstr != ".txt")
                {
                    throw new Exception("Nhập sai định dạng Vui lòng nhập lại");
                }
                else
                {
                    MessageBox.Show("Ghi file thành công");
                }
                StreamWriter write = new StreamWriter(textBox1.Text, true);
                write.Write("Bàn 1:");
                write.WriteLine(Tongban1txt.Text);
                write.Write("Bàn 2:");
                write.WriteLine(Tongban2txt.Text);
                write.Write("Bàn 3:");
                write.WriteLine(Tongban3txt.Text);
                write.Write("Bàn 4:");
                write.WriteLine(Tongban4txt.Text);
                write.Write("Bàn 5:");
                write.WriteLine(Tongban5txt.Text);
                write.Write("Bàn 6:");
                write.WriteLine(Tongban6txt.Text);
                write.Write("Tổng:");
                write.WriteLine(txtTongthuduoc.Text);
                write.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
