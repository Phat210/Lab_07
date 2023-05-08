using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class HinhChuNhat:HinhHoc
    {
        float chieuDai;
        float chieuRong;
        public HinhChuNhat() { }
        public HinhChuNhat(float cd, float cr)
        {
            this.chieuDai = cd;
            this.chieuRong = cr;
        }
        public override float TinhDT()
        {
            return (float)(chieuDai*chieuRong)/2;
        }
        public override void Xuat()
        {
            Console.WriteLine("Hinh chu nhat co chieu dai : "+chieuDai+"va chieu rong :"+chieuRong+"co dien tich :"+TinhDT());
        }
        public HinhChuNhat(string hcn)
        {
            string[] s = hcn.Split(' ');
            chieuDai = float.Parse(s[1]);
            chieuRong = float.Parse(s[2]);
        }
    }
}
