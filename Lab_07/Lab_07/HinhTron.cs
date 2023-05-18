using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    class HinhTron:HinhHoc
    {
        public float banKinh;
        public HinhTron() { }
        public HinhTron(float bk)
        {
            banKinh = bk;
        }
        public override float TinhDT()
        {
            return (float)Math.PI*banKinh*banKinh;
        }
        public override float TinhChuVi()
        {
            return (float)Math.PI * 2 * banKinh;
        }
        public override void Xuat()
        {
            Console.WriteLine("Hình tròn bán kính = " + banKinh +"Có diện tích = "+TinhDT());
        }
        public HinhTron(string ht)
        {
            string[] s=ht.Split(' ');
            type = s[0];
            banKinh = float.Parse(s[1]);
        }
    }
}
