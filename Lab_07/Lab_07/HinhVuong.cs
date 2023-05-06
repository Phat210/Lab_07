using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class HinhVuong:HinhHoc
    {
        public float canh;
        public HinhVuong() { }
        public HinhVuong(float c)
        {
            canh = c;
        }
        public override float TinhDT()
        {
            return (float)  canh * canh;
        }
        public override void Xuat()
        {
            Console.WriteLine("Hinh vuong canh = " + canh + "Co dien tich" + TinhDT());
        }
    }
}
