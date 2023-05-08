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
        public override void Xuat()
        {
            Console.WriteLine("Hinh tron bk= " + banKinh +"Co dien tich"+TinhDT());
        }
        public HinhTron(string ht)
        {
            string[] s=ht.Split(' ');
            banKinh = float.Parse(s[1]);
        }
    }
}
