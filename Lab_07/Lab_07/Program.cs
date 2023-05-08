using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        enum Menu { nhaptufile=1, timcanhhinhvuong, timchieudaihinhchunhat, sapxepdientich, thoat };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangHinhHoc mhh = new MangHinhHoc();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chọn chức năng");
                Console.WriteLine($"Nhập {(int)Menu.nhaptufile} để nhập từ file");
                Console.WriteLine($"Nhập {(int)Menu.timcanhhinhvuong} để tìm cạnh ngắn, dài nhất của hình vuông");
                Console.WriteLine($"Nhập {(int)Menu.timchieudaihinhchunhat} để tìm chiều dài ngắn, dài nhất");
                Console.WriteLine($"Nhập {(int)Menu.sapxepdientich} để sắp xếp diện tích");
                Console.WriteLine($"Nhập {(int)Menu.thoat} để thoát ");

                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.nhaptufile:
                        mhh.NhapTuFile();
                        break;
                    case Menu.timcanhhinhvuong:
                        List<HinhVuong> kq1 = mhh.TimCanhNhoNhat();
                        List<HinhVuong> kq1_1 = mhh.TimCanhLonNhat();
                        foreach (var a in kq1)
                        {
                            Console.WriteLine("Hinh vuong số " + a.stt + " " + a.canh);
                        }
                        Console.WriteLine("có cạnh nhỏ nhất");
                        foreach (var a in kq1_1)
                        {
                            Console.WriteLine("Hinh vuông số " + a.stt + " " + a.canh);
                        }
                        Console.WriteLine("có cạnh lớn nhất");
                        break;
                    case Menu.thoat:
                        return;
                }
                Console.WriteLine("Nhập 1 để tiếp tục");
                Console.ReadKey();
            }


        }
    }
}
