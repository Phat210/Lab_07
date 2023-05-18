using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class HinhVuong : HinhHoc
    {
        public float Canh { get; set; }
        public HinhVuong() { }
        public HinhVuong(float c)
        {
            Canh = c;
        }
        public override float TinhDT()
        {
            return (float)  Canh * Canh;
        }
        public override float TinhChuVi()
        {
            return Canh*4;
        }
        public override void Xuat()
        {
            Console.WriteLine("Hình vuông cạnh = " + Canh + " Có diện tích = " + TinhDT());
        }   

        public HinhVuong(string hv)
        {
            string[] s = hv.Split(' ');
            type = s[0];
            Canh = float.Parse(s[1]);
        }
    }
}
