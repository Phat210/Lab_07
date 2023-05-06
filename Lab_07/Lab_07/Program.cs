using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MangHinhHoc mhh = new MangHinhHoc();
            HinhVuong hv1 = new HinhVuong(2);
            HinhVuong hv2 = new HinhVuong(3);
            HinhVuong hv3 = new HinhVuong(4);
            HinhVuong hv4 = new HinhVuong(5);
          var b=  mhh.TinhTongDT(); 
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
