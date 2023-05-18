using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class HinhChuNhat : HinhHoc
    {
        public float chieuDai;
        public float chieuRong;
        public HinhChuNhat() { }
        public HinhChuNhat( float cd, float cr)
        {
            this.chieuDai = cd;
            this.chieuRong = cr;
        }
        public override float TinhDT()
        {
            return (float)(chieuDai * chieuRong);
        }
        public override float TinhChuVi()
        {
            return (float)((chieuDai + chieuRong) * 2);
        }

        public override void Xuat()
        {
            Console.WriteLine("Hình chữ nhật có chiều dài = " + chieuDai + "và chiều rộng  =" + chieuRong + "có diện tích = " + TinhDT());
        }
        
        public HinhChuNhat(string hcn)
        {
            string[] s = hcn.Split(' ');
            type = s[0];
            chieuDai = float.Parse(s[1]);
            chieuRong = float.Parse(s[2]);
        }
    }
}
