using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    class MangHinhHoc
    {
        List<HinhHoc> collection = new List<HinhHoc>();
        public void Them(HinhHoc h)
        {
            collection.Add(h);
        }
        public float TinhTongDT()
        {
            float tong = 0;
            foreach (var item in collection)
            {
                tong += item.TinhDT();
            }
            return tong;
        }
        public void Xuat()
        {
            foreach (var item in collection)
            {
                Console.WriteLine("Tong dien tich cac hinh ");
                item.Xuat();
                Console.WriteLine("La:" + TinhTongDT());
            }
        }
    }
}
