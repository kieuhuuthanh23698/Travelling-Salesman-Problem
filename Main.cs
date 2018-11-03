using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimDuongDiNguoiGiaoHang
{
    public partial class Main : Form
    {
        int soLuongDiem;
        List<Diem> dsDiem;
        List<Canh> dsCanh;
        List<Canh> dsChonDuong;
        string[] dsTen = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L", "M", "N", "P","Q", "O", "U", "Y", "T", "S", "R", "X", "V", "Z", "W"};
        Graphics gp;
        SolidBrush sb;
        Pen pen;

        public Main(int n)
        {
            InitializeComponent();
            this.soLuongDiem = n;
            dsDiem = new List<Diem>();
            dsCanh = new List<Canh>();
            dsChonDuong = new List<Canh>();
            gp = panel1.CreateGraphics();
            sb = new SolidBrush(Color.Green);
            pen = new Pen(sb, 1);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Point a = new Point(10, 10);
            Point b = new Point(100, 100);
            Graphics ve = this.CreateGraphics();        
            SolidBrush sb = new SolidBrush(Color.Red);
            Pen but = new Pen(sb, 1);
            ve.DrawLine(but,a,b);
        }

        public bool kiemTraDiem(Diem x)
        {
            for (int i = 0; i < dsDiem.Count; i++)
            {
                Canh a = new Canh(x, dsDiem[i]);
                if (a.lenght() < 100)
                    return false;
            }
            return true;
        }

        public void taoListDiem()
        {
            Random rd = new Random();
            for (int i = 0; i < soLuongDiem; i++)
            {
                Point p = new Point( rd.Next(panel1.Width - 50) , rd.Next(panel1.Height - 50) );
                Diem diem = new Diem(dsTen[i], p);
                if(kiemTraDiem(diem) == true)
                    dsDiem.Add(diem);
                else
                    i--;
            }
        }

        public void loadDsDiemLenForm()
        {
            for (int i = 0; i < dsDiem.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = dsDiem[i].getTenDiem();
                lbl.Location = dsDiem[i].getDiem();
                lbl.Height = 15;
                lbl.Width = 15;
                lbl.BackColor = Color.LightGray;
                lbl.ForeColor = Color.Red;
                panel1.Controls.Add(lbl);
            }
        }

        public void taoDsCanh()
        {
            for(int i = 0 ; i < dsDiem.Count - 1 ; i++)
                for (int j = i + 1; j < dsDiem.Count; j++)
                {
                    Canh a = new Canh(dsDiem[i], dsDiem[j]);
                    dsCanh.Add(a);
                }
        }

        public void loadDsCanh()
        {
            for (int i = 0; i < dsCanh.Count; i++)
            {
                string[] mang = { i + "", dsCanh[i].getTenCanh(), (dsCanh[i].lenght() + " ") };
                ListViewItem item = new ListViewItem(mang);
                if (i % 2 == 0)
                    item.BackColor = Color.Orange;
                else
                    item.BackColor = Color.Gray;
                listView1.Items.Add(item);
            }
        }

        public void swap(Canh a, Canh b)
        {
            Canh temp = new Canh(a.getX(), a.getY());

            a.setX(b.getX());
            a.sety(b.getY()); 
            a.setTenCanh(b.getTenCanh());

            b.setX(temp.getX()); 
            b.sety(temp.getY());
            b.setTenCanh(temp.getTenCanh());
        }

        public void sapXepDsCanh()
        {
            if (dsCanh.Count > 1)
            {
                for (int i = 0; i < dsCanh.Count - 1; i++)
                    for (int j = i + 1; j < dsCanh.Count; j++)
                        if (dsCanh[i].lenght() > dsCanh[j].lenght())
                            swap(dsCanh[i], dsCanh[j]);
                listView1.Items.Clear();
                loadDsCanh();
            }
        }

        private void btnLoadDiem_Click(object sender, EventArgs e)
        {
            taoListDiem();
            loadDsDiemLenForm();
            btnLoadDiem.Enabled = false;
            btnTaoDsCanh.Enabled = true;
            btnTaoDsCanh.Focus();
            MessageBox.Show("Đã tạo ngẫu nhiên " + soLuongDiem + " điểm .");
        }

        private void btnTaoDsCanh_Click(object sender, EventArgs e)
        {
            taoDsCanh();
            loadDsCanh();
            btnTaoDsCanh.Enabled = false;
            btnSapXepCanh.Enabled = true;
            btnSapXepCanh.Focus();
            MessageBox.Show("Đã tạo danh sách các cạnh nối liền các điểm.");
        }

        private void btnSapXepCanh_Click(object sender, EventArgs e)
        {
            sapXepDsCanh();
            btnSapXepCanh.Enabled = false;
            btnChonDuong.Enabled = true;
            btnChonDuong.Focus();
            MessageBox.Show("Đã sắp xếp danh sách cạnh !");
        }

        public void loadDsDuongDaChon()
        {
            for (int i = 0; i < dsChonDuong.Count; i++)
            {
                string[] mang = { i + "", dsChonDuong[i].getTenCanh(), (dsChonDuong[i].lenght() + " ") };
                ListViewItem item = new ListViewItem(mang);
                if (i % 2 == 0)
                    item.BackColor = Color.Orange;
                else
                    item.BackColor = Color.Gray;
                listView2.Items.Add(item);
            }
        }

        public bool ktraDoanChuTrinhThieu(Canh c1, Canh c2, Canh c3)
        {
            List<Diem> ds = new List<Diem>();
            ds.Add(c1.getX());
            
            if(ds.Contains(c1.getY()) == false)
                ds.Add(c1.getY());

            if(ds.Contains(c2.getX()) == false)
                ds.Add(c2.getX());
            
            if (ds.Contains(c2.getY()) == false)
                ds.Add(c2.getY());

            if (ds.Contains(c3.getX()) == false)
                ds.Add(c3.getX());

            if (ds.Contains(c3.getY()) == false)
                ds.Add(c3.getY());
            if (ds.Count > 3)
                return false;//ko tạo chu trinh thieu
            return true;
        }

        public bool ktraTaoChuTrinhThieu(Canh canh)
        {//canh ko tao thanh tam giac voi 2 canh bat kì
            for (int i = 0; i < dsChonDuong.Count; i++)
                for (int j = 0; j < dsChonDuong.Count; j++)
                {
                    if (i != j )//2 cạnh bất kì trong những cạnh đã chọn
                    {
                        if (ktraDoanChuTrinhThieu(canh, dsChonDuong[i], dsChonDuong[j]) == true)
                        {
                            MessageBox.Show("Cạnh " + canh.getTenCanh() + " có tạo thành chu trình thiếu !");
                            return true;// co tao chu trinh thieu
                            
                        }
                    }
                }
            return false;
        }

        public bool kTraTaoDinhCap3(Canh canh)
        {
            int demXuatHienX = 0;
            int demXuatHienY = 0;
            for (int i = 0; i < dsChonDuong.Count; i++)
            {
                if (dsChonDuong[i].getX() == canh.getX() || dsChonDuong[i].getY() == canh.getX() )
                    demXuatHienX++;
                if (dsChonDuong[i].getX() == canh.getY() || dsChonDuong[i].getY() == canh.getY())
                    demXuatHienY++;
            }
            if (demXuatHienX  == 2 || demXuatHienY == 2)
            {
                MessageBox.Show("Cạnh " + canh.getTenCanh() + " có tạo thành 1 đỉnh cấp 3 !");
                return true;
            }
            return false;
        }

        public bool kTraCanh(Canh canh)
        {
            if (kTraTaoDinhCap3(canh) == false && ktraTaoChuTrinhThieu(canh) == false)
                return true;
            return false;
        }
        
        private void btnChonDuong_Click(object sender, EventArgs e)
        {
            if (dsCanh.Count > 1)
            {
                while (dsChonDuong.Count != soLuongDiem)
                {
                    for (int i = 0; i < dsCanh.Count; i++)
                    {
                        if (kTraCanh(dsCanh[i]) == true)
                        {
                            dsChonDuong.Add(dsCanh[i]);
                            MessageBox.Show("Thêm cạnh " + dsCanh[i].getTenCanh() + "\nSố lượng cạnh đã chọn là  " + dsChonDuong.Count);

                            dsCanh.Remove(dsCanh[i]);
                            i--;
                        }
                        else
                        {
                            dsCanh.Remove(dsCanh[i]);
                            i--;
                        }
                    }
                }
            }
            else
                dsChonDuong.Add(dsCanh[0]);
            loadDsDuongDaChon();
            btnChonDuong.Enabled = false;
            btnTimDuong.Enabled = true;
            btnTimDuong.Focus();
        }

        int i = 0;

        private void btnTimDuong_Click(object sender, EventArgs e)
        {
            if (i == dsChonDuong.Count)
            {
                MessageBox.Show("KẾT THÚC TÌM ĐƯỜNG");
                btnTimDuong.Enabled = false;
                return;
            }
            Canh canh = dsChonDuong[i];
            noiDiem(canh.getX().getDiem(),canh.getY().getDiem());
            MessageBox.Show(listView1.Items[i].SubItems[1].Text);
            i++;
            btnTimDuong.Focus();
        }

        public void noiDiem(Point p1, Point p2)
        {
            gp.DrawLine(pen, p1, p2);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
