using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TimDuongDiNguoiGiaoHang
{
    public class Diem
    {
        string tenDiem;
        Point diem;

        public string getTenDiem()
        {
            return this.tenDiem;
        }

        public void setTenDiem(string tenDiem)
        {
            this.tenDiem = tenDiem;
        }

        public Point getDiem()
        {
            return this.diem;
        }

        public void setDiem(Point diem)
        {
            this.diem = diem;
        }

        public Diem(string tenDiem, Point diem)
        {
            this.diem = diem;
            this.tenDiem = tenDiem;
        }
    }
}
