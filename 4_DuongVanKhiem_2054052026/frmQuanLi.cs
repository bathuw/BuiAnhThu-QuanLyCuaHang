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
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }

        Trasua loai1 = new Trasua();
        int gialoai1;
        int soluongts1;
        int tongloai1;
        //
        //
        Trasua loai2 = new Trasua();
        int gialoai2;
        int soluongts2;
        int tongloai2;
        //
        Trasua loai3 = new Trasua();
        int gialoai3;
        int soluongts3;
        int tongloai3;
        //
        Trasua loai4 = new Trasua();
        int gialoai4;
        int soluongts4;
        int tongloai4;
        //
        Trasua loai5 = new Trasua();
        int gialoai5;
        int soluongts5;
        int tongloai5;
        //
        Trasua loai6 = new Trasua();
        int gialoai6;
        int soluongts6;
        int tongloai6;


        // tongtienban
        int tongban1, tongban2, tongban3, tongban4, tongban5, tongban6;



        private void FormQuanli_Load(object sender, EventArgs e)
        {
            gialoai1 = 25;
            gialoai2 = 26;
            gialoai3 = 27;
            gialoai4 = 28;
            gialoai5 = 29;
            gialoai6 = 30;
            //
            soluongts1 = 0; soluongts2 = 0; soluongts3 = 0; soluongts4 = 0; soluongts5 = 0; soluongts6 = 0;
            SoluongTs1.Text = soluongts1.ToString();
            SoluongTs2.Text = soluongts2.ToString();
            SoluongTs3.Text = soluongts3.ToString();
            SoluongTs4.Text = soluongts4.ToString();
            SoluongTs5.Text = soluongts5.ToString();
            SoluongTs6.Text = soluongts6.ToString();
            //
            Ban1.Checked = true;
            // 
            // tongban1 = 0; tongban2 = 0; tongban3 = 0; tongban4 = 0;tongban5 = 0; tongban6 = 0;
        }


        //Chọn size cho từng loại => lấy ra giá tương ứng với từng loại từng size
        private void sizeTs1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs1.SelectedItem == "M")
            {
                loai1.Price = gialoai1;
            }
            if (sizeTs1.SelectedItem == "L")
            {
                loai1.Price = gialoai1 + 4;
            }
            if (sizeTs1.SelectedItem == "XL")
            {
                loai1.Price = gialoai1 + 8;
            }
            giaTs1.Text = loai1.Price.ToString();
        }

        private void sizeTs2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs2.SelectedItem == "M")
            {
                loai2.Price = gialoai2;
            }
            if (sizeTs2.SelectedItem == "L")
            {
                loai2.Price = gialoai2 + 4;
            }
            if (sizeTs2.SelectedItem == "XL")
            {
                loai2.Price = gialoai2 + 8;
            }
            giaTs2.Text = loai2.Price.ToString();
        }
        private void sizeTs3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs3.SelectedItem == "M")
            {
                loai3.Price = gialoai3;
            }
            if (sizeTs3.SelectedItem == "L")
            {
                loai3.Price = gialoai3 + 4;
            }
            if (sizeTs3.SelectedItem == "XL")
            {
                loai3.Price = gialoai3 + 8;
            }
            giaTs3.Text = loai3.Price.ToString();
        }

        private void sizeTs4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs4.SelectedItem == "M")
            {
                loai4.Price = gialoai4;
            }
            if (sizeTs4.SelectedItem == "L")
            {
                loai4.Price = gialoai4 + 4;
            }
            if (sizeTs4.SelectedItem == "XL")
            {
                loai4.Price = gialoai4 + 8;
            }
            giaTs4.Text = loai4.Price.ToString();
        }

        private void sizeTs5_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs5.SelectedItem == "M")
            {
                loai5.Price = gialoai5;
            }
            if (sizeTs5.SelectedItem == "L")
            {
                loai5.Price = gialoai5 + 4;
            }
            if (sizeTs5.SelectedItem == "XL")
            {
                loai5.Price = gialoai5 + 8;
            }
            giaTs5.Text = loai5.Price.ToString();
        }

        private void sizeTs6_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs6.SelectedItem == "M")
            {
                loai6.Price = gialoai6;
            }
            if (sizeTs6.SelectedItem == "L")
            {
                loai6.Price = gialoai6 + 4;
            }
            if (sizeTs6.SelectedItem == "XL")
            {
                loai6.Price = gialoai6 + 8;
            }
            giaTs6.Text = loai6.Price.ToString();
        }


        //Tăng Số lượng
        private void btnAddSL1_Click(object sender, EventArgs e)
        {
            soluongts1 += 1;
            soluongts1 = loai1.Soluong(soluongts1);
            SoluongTs1.Text = soluongts1.ToString();
        }
        private void btnAddSL2_Click(object sender, EventArgs e)
        {
            soluongts2 += 1;
            soluongts2 = loai2.Soluong(soluongts2);
            SoluongTs2.Text = soluongts2.ToString();
        }
        private void btnAddSL3_Click(object sender, EventArgs e)
        {
            soluongts3 += 1;
            soluongts3 = loai3.Soluong(soluongts3);
            SoluongTs3.Text = soluongts3.ToString();
        }
        private void btnAddSL4_Click(object sender, EventArgs e)
        {
            soluongts4 += 1;
            soluongts4 = loai4.Soluong(soluongts4);
            SoluongTs4.Text = soluongts4.ToString();
        }
        private void btnAddSL5_Click(object sender, EventArgs e)
        {
            soluongts5 += 1;
            soluongts5 = loai5.Soluong(soluongts5);
            SoluongTs5.Text = soluongts5.ToString();
        }
        private void btnAddSL6_Click(object sender, EventArgs e)
        {
            soluongts6 += 1;
            soluongts6 = loai6.Soluong(soluongts6);
            SoluongTs6.Text = soluongts6.ToString();
        }

        //Giảm số lượng
        private void btnTruSL1_Click(object sender, EventArgs e)
        {
            soluongts1 -= 1;
            if (soluongts1 < 0)
            {
                soluongts1 = 0;
            }
            soluongts1 = loai1.Soluong(soluongts1);
            SoluongTs1.Text = soluongts1.ToString();
        }
        private void btnTruSL2_Click(object sender, EventArgs e)
        {
            soluongts2 -= 1;
            if (soluongts2 < 0)
            {
                soluongts2 = 0;
            }
            soluongts2 = loai2.Soluong(soluongts2);
            SoluongTs2.Text = soluongts2.ToString();
        }
        private void btnTruSL3_Click(object sender, EventArgs e)
        {
            soluongts3 -= 1;
            if (soluongts3 < 0)
            {
                soluongts3 = 0;
            }
            soluongts3 = loai3.Soluong(soluongts3);
            SoluongTs3.Text = soluongts3.ToString();
        }
        private void btnTruSL4_Click(object sender, EventArgs e)
        {
            soluongts4 -= 1;
            if (soluongts4 < 0)
            {
                soluongts4 = 0;
            }
            soluongts4 = loai4.Soluong(soluongts4);
            SoluongTs4.Text = soluongts4.ToString();
        }
        private void btnTruSL5_Click(object sender, EventArgs e)
        {
            soluongts5 -= 1;
            if (soluongts5 < 0)
            {
                soluongts5 = 0;
            }
            soluongts5 = loai5.Soluong(soluongts5);
            SoluongTs5.Text = soluongts5.ToString();
        }
        private void btnTruSL6_Click(object sender, EventArgs e)
        {
            soluongts6 -= 1;
            if (soluongts6 < 0)
            {
                soluongts6 = 0;
            }
            soluongts6 = loai6.Soluong(soluongts6);
            SoluongTs6.Text = soluongts6.ToString();
        }

        // Nhập số lượng
        private void SoluongTs1_TextChanged(object sender, EventArgs e)
        {
            if (SoluongTs1.Text == "")
            {
                soluongts1 = 0;
            }
            else
            {
                soluongts1 = int.Parse(SoluongTs1.Text);
            }
            if (soluongts1 > 99)
            {
                btnAddSL1.Visible = false;
                SoluongTs1.Width = 57;
                SoluongTs1.Height = 27;
            }
        }
        private void SoluongTs2_TextChanged(object sender, EventArgs e)
        {
            if (SoluongTs2.Text == "")
            {
                soluongts2 = 0;
            }
            else
            {
                soluongts2 = int.Parse(SoluongTs2.Text);
            }
            if (soluongts2 > 99)
            {
                btnAddSL2.Visible = false;
                SoluongTs2.Width = 57;
                SoluongTs2.Height = 27;
            }
        }
        private void SoluongTs3_TextChanged(object sender, EventArgs e)
        {

            if (SoluongTs3.Text == "")
            {
                soluongts3 = 0;
            }
            else
            {
                soluongts3 = int.Parse(SoluongTs3.Text);
            }
            if (soluongts3 > 99)
            {
                btnAddSL3.Visible = false;
                SoluongTs3.Width = 57;
                SoluongTs3.Height = 27;
            }
        }
        private void SoluongTs4_TextChanged(object sender, EventArgs e)
        {
            if (SoluongTs4.Text == "")
            {
                soluongts4 = 0;
            }
            else
            {
                soluongts4 = int.Parse(SoluongTs4.Text);
            }
            if (soluongts4 > 99)
            {
                btnAddSL4.Visible = false;
                SoluongTs4.Width = 57;
                SoluongTs4.Height = 27;
            }
        }
        private void SoluongTs5_TextChanged(object sender, EventArgs e)
        {
            if (SoluongTs5.Text == "")
            {
                soluongts5 = 0;
            }
            else
            {
                soluongts5 = int.Parse(SoluongTs5.Text);
            }
            if (soluongts5 > 99)
            {
                btnAddSL5.Visible = false;
                SoluongTs5.Width = 57;
                SoluongTs5.Height = 27;
            }
        }
        private void SoluongTs6_TextChanged(object sender, EventArgs e)
        {
            if (SoluongTs6.Text == "")
            {
                soluongts6 = 0;
            }
            else
            {
                soluongts6 = int.Parse(SoluongTs6.Text);
            }
            if (soluongts6 > 99)
            {
                btnAddSL6.Visible = false;
                SoluongTs6.Width = 57;
                SoluongTs6.Height = 27;
            }
        }


        // Tính ra tổng số tiền của từng món khi khách hàng chọn 
        private void trasua1_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua1.Checked == true)
            {
                btnAddSL1.Enabled = true;
                btnTruSL1.Enabled = true;
            }
            else
            {
                btnAddSL1.Enabled = false;
                btnTruSL1.Enabled = false;
            }
            // TongBantxt.Text = tongloai1.ToString() + ".000 VNĐ";
            // biến tongloai1 thêm vào listview
        }

        private void trasua2_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua2.Checked == true)
            {
                tongloai2 = Cacpheptinh.TinhTienMoiLoai(loai2.Price, soluongts2);
                btnAddSL2.Enabled = true;
                btnTruSL2.Enabled = true;
            }
            else
            {
                tongloai2 = 0;
            }
        }

        private void trasua3_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua3.Checked == true)
            {
                tongloai3 = Cacpheptinh.TinhTienMoiLoai(loai3.Price, soluongts3);
                btnAddSL3.Enabled = true;
                btnTruSL3.Enabled = true;
            }
            else
            {
                tongloai3 = 0;
            }
        }

        private void trasua4_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua4.Checked == true)
            {
                tongloai4 = Cacpheptinh.TinhTienMoiLoai(loai4.Price, soluongts4);
                btnAddSL4.Enabled = true;
                btnTruSL4.Enabled = true;
            }
            else
            {
                tongloai4 = 0;
            }
        }

        private void trasua5_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua5.Checked == true)
            {
                tongloai5 = Cacpheptinh.TinhTienMoiLoai(loai5.Price, soluongts5);
                btnAddSL5.Enabled = true;
                btnTruSL5.Enabled = true;
            }
            else
            {
                tongloai5 = 0;
            }
        }

        private void trasua6_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua6.Checked == true)
            {
                tongloai6 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                btnAddSL6.Enabled = true;
                btnTruSL6.Enabled = true;
            }
            else
            {
                tongloai6 = 0;
            }
        }


        // Hiển thị số bàn theo số bàn chọn để quản lí
        private void Ban1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton soban = (RadioButton)sender;
            SoBanhientai.Text = soban.Text;
            ResetMenu();



            //Chọn bàn nào thì listView của bàn đó hiện lên
            if (Ban1.Checked == true)
            {
                listViewTS.Visible = true;
                listViewTS3.Visible = false;
                listViewTS2.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban1.ToString() + ".000 VNĐ";
            }
            if (Ban2.Checked == true)
            {
                listViewTS2.Visible = true;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban2.ToString() + ".000 VNĐ";
            }
            if (Ban3.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = true;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban3.ToString() + ".000 VNĐ";
            }
            if (Ban4.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = true;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban4.ToString() + ".000 VNĐ";
            }
            if (Ban5.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = true;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban5.ToString() + ".000 VNĐ";
            }
            if (Ban6.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = true;
                TongBantxt.Text = tongban6.ToString() + ".000 VNĐ";
            }
        }

        //Reset khi đổi bàn
        private void ResetMenu()
        {
            foreach (Control chk in Menu.Controls)
            {
                if (chk is CheckBox)
                    ((CheckBox)chk).Checked = false;

            }

            foreach (Control tbx in Menu.Controls)
            {
                if (tbx is TextBox)
                    ((TextBox)tbx).Text = "0";
            }
            foreach (Control size in Menu.Controls)
            {
                if (size is ComboBox)
                    ((ComboBox)size).Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.tongban1 = tongban1;
            frm.tongban2 = tongban2;
            frm.tongban3 = tongban3;
            frm.tongban4 = tongban4;
            frm.tongban5 = tongban5;
            frm.tongban6 = tongban6;
            frm.ShowDialog();
        }

        private void sizeTs1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Hàm thêm món vào list khi check
        private void AddFoodListView(CheckBox trasuaX, ListView lv, ListViewItem item)
        {
            if (trasuaX.Checked == true)
            {
                item.Text = trasuaX.Text;
                lv.Items.Add(item);
                trasuaX.Checked = false;
            }
        }

        //Tra sua nao dc chon thi add vao listView


        //Add món vào lv
        private void AddMon_Click(object sender, EventArgs e)
        {

            //lvTS
            try
            {

                if (Ban1.Checked == true)
                {
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs1.Text == "")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai1 = Cacpheptinh.TinhTienMoiLoai(loai1.Price, soluongts1);
                        TestGia.Text = tongloai1.ToString();
                        ListViewItem itemlv11 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS, itemlv11);
                        itemlv11.SubItems.Add(SoluongTs1.Text);
                        itemlv11.SubItems.Add(TestGia.Text + ".000đ");
                        string strlv11 = itemlv11.SubItems[2].Text.Replace(itemlv11.SubItems[2].Text, tongloai1.ToString());

                    }
                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs2.Text == "")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }

                        tongloai2 = Cacpheptinh.TinhTienMoiLoai(loai2.Price, soluongts2);
                        TestGia.Text = tongloai2.ToString();
                        ListViewItem itemlv12 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS, itemlv12);
                        itemlv12.SubItems.Add(SoluongTs2.Text);
                        itemlv12.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs3.Text == "")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai3 = Cacpheptinh.TinhTienMoiLoai(loai3.Price, soluongts3);
                        TestGia.Text = tongloai3.ToString();
                        ListViewItem itemlv13 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS, itemlv13);
                        itemlv13.SubItems.Add(SoluongTs3.Text);
                        itemlv13.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs4.Text == "")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai4 = Cacpheptinh.TinhTienMoiLoai(loai4.Price, soluongts4);
                        TestGia.Text = tongloai4.ToString();
                        ListViewItem itemlv14 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS, itemlv14);
                        itemlv14.SubItems.Add(SoluongTs4.Text);
                        itemlv14.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs5.Text == "")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai5 = Cacpheptinh.TinhTienMoiLoai(loai5.Price, soluongts5);
                        TestGia.Text = tongloai5.ToString();
                        ListViewItem itemlv15 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS, itemlv15);
                        itemlv15.SubItems.Add(SoluongTs5.Text);
                        itemlv15.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs6.Text == "")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai6 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                        TestGia.Text = tongloai6.ToString();
                        ListViewItem itemlv16 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS, itemlv16);
                        itemlv16.SubItems.Add(SoluongTs6.Text);
                        itemlv16.SubItems.Add(TestGia.Text + ".000đ");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //lvTS2
            /// // Add món 1
            ///

            try
            {
                if (Ban2.Checked == true)
                {

                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs1.Text == "")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai1 = Cacpheptinh.TinhTienMoiLoai(loai1.Price, soluongts1);
                        TestGia.Text = tongloai1.ToString();
                        ListViewItem itemlv21 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS2, itemlv21);
                        itemlv21.SubItems.Add(SoluongTs1.Text);
                        itemlv21.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs2.Text == "")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai2 = Cacpheptinh.TinhTienMoiLoai(loai2.Price, soluongts2);
                        TestGia.Text = tongloai2.ToString();
                        ListViewItem itemlv22 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS2, itemlv22);
                        itemlv22.SubItems.Add(SoluongTs2.Text);
                        itemlv22.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs3.Text == "")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai3 = Cacpheptinh.TinhTienMoiLoai(loai3.Price, soluongts3);
                        TestGia.Text = tongloai3.ToString();
                        ListViewItem itemlv23 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS2, itemlv23);
                        itemlv23.SubItems.Add(SoluongTs3.Text);
                        itemlv23.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs4.Text == "")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai4 = Cacpheptinh.TinhTienMoiLoai(loai4.Price, soluongts4);
                        TestGia.Text = tongloai4.ToString();
                        ListViewItem itemlv24 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS2, itemlv24);
                        itemlv24.SubItems.Add(SoluongTs4.Text);
                        itemlv24.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs5.Text == "")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai5 = Cacpheptinh.TinhTienMoiLoai(loai5.Price, soluongts5);
                        TestGia.Text = tongloai5.ToString();
                        ListViewItem itemlv25 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS2, itemlv25);
                        itemlv25.SubItems.Add(SoluongTs5.Text);
                        itemlv25.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs6.Text == "")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai6 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                        TestGia.Text = tongloai6.ToString();
                        ListViewItem itemlv26 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS2, itemlv26);
                        itemlv26.SubItems.Add(SoluongTs6.Text);
                        itemlv26.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            //
            //lv3
            //Add mon lv3
            try
            {
                if (Ban3.Checked == true)
                {
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs1.Text == "")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai1 = Cacpheptinh.TinhTienMoiLoai(loai1.Price, soluongts1);
                        TestGia.Text = tongloai1.ToString();
                        ListViewItem itemlv31 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS3, itemlv31);
                        itemlv31.SubItems.Add(SoluongTs1.Text);
                        itemlv31.SubItems.Add(TestGia.Text + ".000đ");
                    }
                    // Add món 1

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs2.Text == "")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai2 = Cacpheptinh.TinhTienMoiLoai(loai2.Price, soluongts2);
                        TestGia.Text = tongloai2.ToString();
                        ListViewItem itemlv32 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS3, itemlv32);
                        itemlv32.SubItems.Add(SoluongTs2.Text);
                        itemlv32.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs3.Text == "")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai3 = Cacpheptinh.TinhTienMoiLoai(loai3.Price, soluongts3);
                        TestGia.Text = tongloai3.ToString();

                        ListViewItem itemlv33 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS3, itemlv33);
                        itemlv33.SubItems.Add(SoluongTs3.Text);
                        itemlv33.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs4.Text == "")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai4 = Cacpheptinh.TinhTienMoiLoai(loai4.Price, soluongts4);
                        TestGia.Text = tongloai4.ToString();
                        ListViewItem itemlv34 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS3, itemlv34);
                        itemlv34.SubItems.Add(SoluongTs4.Text);
                        itemlv34.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs5.Text == "")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai5 = Cacpheptinh.TinhTienMoiLoai(loai5.Price, soluongts5);
                        TestGia.Text = tongloai5.ToString();
                        ListViewItem itemlv35 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS3, itemlv35);
                        itemlv35.SubItems.Add(SoluongTs5.Text);
                        itemlv35.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs6.Text == "")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }

                        tongloai6 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                        TestGia.Text = tongloai6.ToString();
                        ListViewItem itemlv36 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS3, itemlv36);
                        itemlv36.SubItems.Add(SoluongTs6.Text);
                        itemlv36.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //
            //lv4
            try
            {
                if (Ban4.Checked == true)
                {
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs1.Text == "")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai1 = Cacpheptinh.TinhTienMoiLoai(loai1.Price, soluongts1);
                        TestGia.Text = tongloai1.ToString();
                        ListViewItem itemlv41 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS4, itemlv41);
                        itemlv41.SubItems.Add(SoluongTs1.Text);
                        itemlv41.SubItems.Add(TestGia.Text + ".000đ");
                    }
                    // Add món 1

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs2.Text == "")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai2 = Cacpheptinh.TinhTienMoiLoai(loai2.Price, soluongts2);
                        TestGia.Text = tongloai2.ToString();
                        ListViewItem itemlv42 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS4, itemlv42);
                        itemlv42.SubItems.Add(SoluongTs2.Text);
                        itemlv42.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs3.Text == "")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai3 = Cacpheptinh.TinhTienMoiLoai(loai3.Price, soluongts3);
                        TestGia.Text = tongloai3.ToString();
                        ListViewItem itemlv43 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS4, itemlv43);
                        itemlv43.SubItems.Add(SoluongTs3.Text);
                        itemlv43.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs4.Text == "")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai4 = Cacpheptinh.TinhTienMoiLoai(loai4.Price, soluongts4);
                        TestGia.Text = tongloai4.ToString();
                        ListViewItem itemlv44 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS4, itemlv44);
                        itemlv44.SubItems.Add(SoluongTs4.Text);
                        itemlv44.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs5.Text == "")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai5 = Cacpheptinh.TinhTienMoiLoai(loai5.Price, soluongts5);
                        TestGia.Text = tongloai5.ToString();
                        ListViewItem itemlv45 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS4, itemlv45);
                        itemlv45.SubItems.Add(SoluongTs5.Text);
                        itemlv45.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs6.Text == "")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai6 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                        TestGia.Text = tongloai6.ToString();
                        ListViewItem itemlv46 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS4, itemlv46);
                        itemlv46.SubItems.Add(SoluongTs6.Text);
                        itemlv46.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //
            //lv5 
            //Add mon ban 5
            try
            {
                if (Ban5.Checked == true)
                {
                    // Add món 1
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs1.Text == "")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai1 = Cacpheptinh.TinhTienMoiLoai(loai1.Price, soluongts1);
                        TestGia.Text = tongloai1.ToString();
                        ListViewItem itemlv51 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS5, itemlv51);
                        itemlv51.SubItems.Add(SoluongTs1.Text);
                        itemlv51.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs2.Text == "")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai2 = Cacpheptinh.TinhTienMoiLoai(loai2.Price, soluongts2);
                        TestGia.Text = tongloai2.ToString();

                        ListViewItem itemlv52 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS5, itemlv52);
                        itemlv52.SubItems.Add(SoluongTs2.Text);
                        itemlv52.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs3.Text == "")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }

                        tongloai3 = Cacpheptinh.TinhTienMoiLoai(loai3.Price, soluongts3);
                        TestGia.Text = tongloai3.ToString();
                        ListViewItem itemlv53 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS5, itemlv53);
                        itemlv53.SubItems.Add(SoluongTs3.Text);
                        itemlv53.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs4.Text == "")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai4 = Cacpheptinh.TinhTienMoiLoai(loai4.Price, soluongts4);
                        TestGia.Text = tongloai4.ToString();
                        ListViewItem itemlv54 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS5, itemlv54);
                        itemlv54.SubItems.Add(SoluongTs4.Text);
                        itemlv54.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs5.Text == "")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai5 = Cacpheptinh.TinhTienMoiLoai(loai5.Price, soluongts5);
                        TestGia.Text = tongloai5.ToString();
                        ListViewItem itemlv55 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS5, itemlv55);
                        itemlv55.SubItems.Add(SoluongTs5.Text);
                        itemlv55.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs6.Text == "")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai6 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                        TestGia.Text = tongloai6.ToString();
                        ListViewItem itemlv56 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS5, itemlv56);
                        itemlv56.SubItems.Add(SoluongTs6.Text);
                        itemlv56.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //
            //lv6
            //Add mon ban 6
            try
            {
                if (Ban6.Checked == true)
                {
                    // Add món 1
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs1.Text == "")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai1 = Cacpheptinh.TinhTienMoiLoai(loai1.Price, soluongts1);
                        TestGia.Text = tongloai1.ToString();
                        ListViewItem itemlv61 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS6, itemlv61);
                        itemlv61.SubItems.Add(SoluongTs1.Text);
                        itemlv61.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs2.Text == "")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai2 = Cacpheptinh.TinhTienMoiLoai(loai2.Price, soluongts2);
                        TestGia.Text = tongloai2.ToString();
                        ListViewItem itemlv62 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS6, itemlv62);
                        itemlv62.SubItems.Add(SoluongTs2.Text);
                        itemlv62.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs3.Text == "")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai3 = Cacpheptinh.TinhTienMoiLoai(loai3.Price, soluongts3);
                        TestGia.Text = tongloai3.ToString();
                        ListViewItem itemlv63 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS6, itemlv63);
                        itemlv63.SubItems.Add(SoluongTs3.Text);
                        itemlv63.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs4.Text == "")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai4 = Cacpheptinh.TinhTienMoiLoai(loai4.Price, soluongts4);
                        TestGia.Text = tongloai4.ToString();
                        ListViewItem itemlv64 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS6, itemlv64);
                        itemlv64.SubItems.Add(SoluongTs4.Text);
                        itemlv64.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs5.Text == "")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai5 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                        TestGia.Text = tongloai5.ToString();
                        ListViewItem itemlv65 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS6, itemlv65);
                        itemlv65.SubItems.Add(SoluongTs5.Text);
                        itemlv65.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        if (sizeTs6.Text == "")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải chọn size");
                        }
                        tongloai6 = Cacpheptinh.TinhTienMoiLoai(loai6.Price, soluongts6);
                        TestGia.Text = tongloai6.ToString();
                        ListViewItem itemlv66 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS6, itemlv66);
                        itemlv66.SubItems.Add(SoluongTs6.Text);
                        itemlv66.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Xóa một dòng trong listView
        private void RemoveMon_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection list1 = listViewTS.SelectedItems;
            ListView.SelectedListViewItemCollection list2 = listViewTS2.SelectedItems;
            ListView.SelectedListViewItemCollection list3 = listViewTS3.SelectedItems;
            ListView.SelectedListViewItemCollection list4 = listViewTS4.SelectedItems;
            ListView.SelectedListViewItemCollection list5 = listViewTS5.SelectedItems;
            ListView.SelectedListViewItemCollection list6 = listViewTS6.SelectedItems;
            foreach (ListViewItem item in list1)
            {
                listViewTS.Items.Remove(item);
            }
            foreach (ListViewItem item in list2)
            {
                listViewTS2.Items.Remove(item);
            }
            foreach (ListViewItem item in list3)
            {
                listViewTS3.Items.Remove(item);
            }
            foreach (ListViewItem item in list4)
            {
                listViewTS4.Items.Remove(item);
            }
            foreach (ListViewItem item in list5)
            {
                listViewTS5.Items.Remove(item);
            }
            foreach (ListViewItem item in list6)
            {
                listViewTS6.Items.Remove(item);
            }
        }

        // Tính tổng tiền từng bàn
        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            if (Ban1.Checked == true)
            {
                tongban1 = TinhTienBan(listViewTS, tongban1);
                if (checkThanThiet.Checked == true)
                {
                    tongban1 = tongban1 - (tongban1 * 5 / 100);
                }
                if (checkVIP.Checked == true)
                {
                    tongban1 = tongban1 - (tongban1 * 10 / 100);
                }
                TongBantxt.Text = tongban1.ToString() + ".000 VNĐ";
            }
            if (Ban2.Checked == true)
            {
                tongban2 = TinhTienBan(listViewTS2, tongban2);
                if (checkThanThiet.Checked == true)
                {
                    tongban2 = tongban2 - (tongban2 * 5 / 100);
                }
                if (checkVIP.Checked == true)
                {
                    tongban2 = tongban2 - (tongban2 * 10 / 100);
                }
                TongBantxt.Text = tongban2.ToString() + ".000 VNĐ";
            }
            if (Ban3.Checked == true)
            {
                tongban3 = TinhTienBan(listViewTS3, tongban3);
                if (checkThanThiet.Checked == true)
                {
                    tongban3 = tongban3 - (tongban3 * 5 / 100);
                }
                if (checkVIP.Checked == true)
                {
                    tongban3 = tongban3 - (tongban3 * 10 / 100);
                }
                TongBantxt.Text = tongban3.ToString() + ".000 VNĐ";
            }
            if (Ban4.Checked == true)
            {
                tongban4 = TinhTienBan(listViewTS4, tongban4);
                if (checkThanThiet.Checked == true)
                {
                    tongban4 = tongban4 - (tongban4 * 5 / 100);
                }
                if (checkVIP.Checked == true)
                {
                    tongban4 = tongban4 - (tongban4 * 10 / 100);
                }
                TongBantxt.Text = tongban4.ToString() + ".000 VNĐ";
            }
            if (Ban5.Checked == true)
            {
                tongban5 = TinhTienBan(listViewTS5, tongban5);
                if (checkThanThiet.Checked == true)
                {
                    tongban5 = tongban5 - (tongban5 * 5 / 100);
                }
                if (checkVIP.Checked == true)
                {
                    tongban5 = tongban5 - (tongban5 * 10 / 100);
                }
                TongBantxt.Text = tongban5.ToString() + ".000 VNĐ";
            }
            if (Ban6.Checked == true)
            {
                tongban6 = TinhTienBan(listViewTS6, tongban6);
                if (checkThanThiet.Checked == true)
                {
                    tongban6 = tongban6 - (tongban6 * 5 / 100);
                }
                if (checkVIP.Checked == true)
                {
                    tongban6 = tongban6 - (tongban6 * 10 / 100);
                }
                TongBantxt.Text = tongban6.ToString() + ".000 VNĐ";
            }

        }

        // Hàm để tính tiền từng bàn
        private int TinhTienBan(ListView lv, int tongban)
        {
            tongban = 0;
            foreach (ListViewItem item in lv.Items)
            {
                tongban += int.Parse(item.SubItems[2].Text.Remove(item.SubItems[2].Text.Length - 5));
            }
            return tongban;
        }
    }


}
