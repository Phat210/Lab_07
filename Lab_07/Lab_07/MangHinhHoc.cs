using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
            Console.WriteLine("Tong dien tich cac hinh ");
            foreach (var item in collection)
            {
               
                item.Xuat();
             
            }
            Console.WriteLine("La:" + TinhTongDT());
        }
        public void NhapTuFile()
        {
            string tenFile = "test.csv";
            StreamReader s = new StreamReader(tenFile);
            string a = "";

            while ((a = s.ReadLine()) != null)
            {

                if (a.Contains("hinhtron") && a != null)
                {
                    HinhTron n = new HinhTron(a);
                    collection.Add(n);
                }
                if (a.Contains("hinhvuong") && a != null)
                {
                    HinhVuong n = new HinhVuong(a);
                    collection.Add(n);
                }
                if (a.Contains("hinhchunhat") && a != null)
                {
                    HinhChuNhat n = new HinhChuNhat(a);
                    collection.Add(n);
                }
            }
        }
        public List<HinhVuong> TimCanhNhoNhat()
        {
            List<HinhHoc> a = collection;
            List<HinhVuong> b= a.OfType<HinhVuong>().ToList();
            float minCanh = b.Min(HinhVuong => HinhVuong.canh);
            List<HinhVuong> c=b.Where(HinhVuong=>HinhVuong.canh == minCanh).ToList();
            return c;
        }
        public List<HinhVuong> TimCanhLonNhat()
        {
            List<HinhHoc> a = collection;
            List<HinhVuong> b= a.OfType<HinhVuong>().ToList();
            float maxCanh = b.Max(HinhVuong => HinhVuong.canh);
            List<HinhVuong> c = b.Where(HinhVuong => HinhVuong.canh == maxCanh).ToList();
            return c;
        }

    }
}
