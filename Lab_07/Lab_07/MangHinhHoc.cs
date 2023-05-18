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

        public List<HinhHoc> collection = new List<HinhHoc>();
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

                item.Xuat();

            }

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
            List<HinhVuong> b = a.OfType<HinhVuong>().ToList();
            float minCanh = b.Min(HinhVuong => HinhVuong.Canh);
            List<HinhVuong> c = b.Where(HinhVuong => HinhVuong.Canh == minCanh).ToList();
            return c;
        }
        public List<HinhVuong> TimCanhLonNhat()
        {
            List<HinhVuong> b = collection.OfType<HinhVuong>().ToList();
            float maxCanh = b.Max(HinhVuong => HinhVuong.Canh);
            List<HinhVuong> c = b.Where(HinhVuong => HinhVuong.Canh == maxCanh).ToList();
            return c;
        }
        public List<HinhChuNhat> TimCanhDaiNhoNhat()
        {
            List<HinhChuNhat> a = collection.OfType<HinhChuNhat>().ToList();
            float minDai = a.Min(HinhChuNhat => HinhChuNhat.chieuDai);
            List<HinhChuNhat> b = a.Where(HinhChuNhat => HinhChuNhat.chieuDai == minDai).ToList();
            return b;
        }
        public List<HinhChuNhat> TimCanhDaiLonNhat()
        {
            List<HinhChuNhat> a = collection.OfType<HinhChuNhat>().ToList();
            float maxDai = a.Max(HinhChuNhat => HinhChuNhat.chieuDai);
            List<HinhChuNhat> b = a.Where(HinhChuNhat => HinhChuNhat.chieuDai == maxDai).ToList();
            return b;
        }
        public List<HinhHoc> SapDienTichTheoChieuTang()
        {
            List<HinhHoc> a = collection;
            var b = a.OrderBy(HinhHoc => HinhHoc.TinhDT()).ToList();
            return b;

        }
        public List<HinhHoc> SapDienTichTheoChieuGiam()
        {
            List<HinhHoc> a = collection;
            var b = a.OrderByDescending(HinhHoc => HinhHoc.TinhDT()).ToList();
            return b;

        }
        public float TinhTongCV()
        {
            float tong = 0;
            foreach (var h in collection)
            {
                tong += h.TinhChuVi();
            }
            return tong;
        }
        public List<HinhTron> TimHinhTronCoChuViMin()
        {
            List<HinhTron> a = collection.OfType<HinhTron>().ToList();
            float minCanh = a.Min(HinhTron => HinhTron.TinhChuVi());
            List<HinhTron> b = a.Where(HinhTron => HinhTron.TinhChuVi() == minCanh).ToList();
            return b;
        }
        public List<HinhTron> TimHinhTronCoChuViMax()
        {
            List<HinhTron> a = collection.OfType<HinhTron>().ToList();
            float maxCanh = a.Max(HinhTron => HinhTron.TinhChuVi());
            List<HinhTron> b = a.Where(HinhTron => HinhTron.TinhChuVi() == maxCanh).ToList();
            return b;
        }
        public List<HinhHoc> TimDienTichMin()
        {
            List<HinhHoc> a = collection;
            float minCanh = a.Min(HinhHoc => HinhHoc.TinhDT());
            List<HinhHoc> b = a.Where(HinhHoc => HinhHoc.TinhDT() == minCanh).ToList();
            return b;
        }
        public List<HinhHoc> TimDienTichMax()
        {
            List<HinhHoc> a = collection;
            float maxCanh = a.Max(HinhHoc => HinhHoc.TinhDT());
            List<HinhHoc> b = a.Where(HinhHoc => HinhHoc.TinhDT() == maxCanh).ToList();
            return b;
        }
        public List<HinhHoc> TimViTri(float a, string h)
        {
            List<HinhHoc> b = collection.Where(x => x.type == h && x.TinhDT() == a).ToList();
            return b;
        }
        public List<HinhHoc> XoaHinhTheoDienTich(float b)
        {
            List<HinhHoc> a = collection;
            foreach (var item in a)
            {
                if (item.TinhDT() == b)
                {
                    a.Remove(item);
                }
            }
            return a;
        }
        public List<HinhVuong> XoaHinhVuongTheoX(float x)
        {
            List<HinhVuong> a = collection.OfType<HinhVuong>().ToList();

            foreach (var item in a)
            {
                if (item.TinhDT() == x)
                {
                    a.Remove(item);
                }
            }
            return a;
        }

        public void ChenHinh(int x)
        {
            Console.WriteLine("Chọn : HinhVuong, HinhTron, HinhChuNhat");
            string a = Console.ReadLine();
            if (a == "HinhVuong")
            {
                Console.WriteLine("Nhập cạnh");
                float b = (float)int.Parse(Console.ReadLine());
                HinhVuong h = new HinhVuong(b);
                collection.Insert(x, h);
            }
            if (a == "HinhTron")
            {
                Console.WriteLine("Nhập bán kính");
                float b = (float)int.Parse(Console.ReadLine());
                HinhTron h = new HinhTron(b);
                collection.Insert(x, h);
            }
            if (a == "HinhChuNhat")
            {
                Console.WriteLine("Nhập chiều dài, chiều rộng");
                float b = (float)int.Parse(Console.ReadLine());
                float c = (float)int.Parse(Console.ReadLine());
                HinhChuNhat h = new HinhChuNhat(b, c);
                collection.Insert(x, h);
            }
        }
        public void XoaHinh(int x)
        {
            collection.RemoveAt(x);
        }
        private int Dem(string vl)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item.type == vl)
                    dem++;
            }
            return dem;
        }
        public List<string> LoaiHinhNhieuNhat()
        {
            List<string> a = new List<string>();
            int max = int.MinValue;
            foreach (var item in collection)
            {
                if (max < Dem(item.type))
                    max = Dem(item.type);
            }
            foreach(var b in collection)
            {
                if (Dem(b.type) == max)
                    a.Add(b.type);
            }
            return a;
        }
        public List<string> LoaiHinhItNhat()
        {
            List<string> a = new List<string>();
            int min = int.MaxValue;
            foreach (var item in collection)
            {
                if (min > Dem(item.type))
                    min = Dem(item.type);
            }
            foreach(var b in collection)
            {
                if (Dem(b.type) == min)
                    a.Add(b.type);
            }
            return a;
        }
    }
}
