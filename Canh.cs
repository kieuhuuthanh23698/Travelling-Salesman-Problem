using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TimDuongDiNguoiGiaoHang
{
    public class Canh
    {
        public string tenCanh;
        public Diem x, y;

        public Diem getX() 
        {
            return this.x;
        }

        public void setX(Diem x)
        {
            this.x = x;
        }

        public Diem getY()
        {
            return this.y;
        }

        public void sety(Diem y)
        {
            this.y = y;
        }

        public string getTenCanh()
        {
            return this.tenCanh;
        }

        public void setTenCanh(string tenCanh)
        {
            this.tenCanh = tenCanh;
        }

        public Canh(Diem x, Diem y)
        {
            this.x = x;
            this.y = y;
            this.tenCanh = this.x.getTenDiem() + this.y.getTenDiem();
        }

        public double lenght()
        {
            return Math.Sqrt(Math.Pow( (x.getDiem().X - y.getDiem().X) , 2 ) + Math.Pow( (x.getDiem().Y - y.getDiem().Y) , 2 ));
        }
    }
}
