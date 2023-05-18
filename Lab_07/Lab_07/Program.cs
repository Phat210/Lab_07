using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        public enum Menu { thoat, nhaptufile = 1, timcanhhinhvuong, timchieudaihinhchunhat, sapxepdientich, tongchuvi, timchuvihinhtron, timvitricuadientich, timvitri };
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
                Console.WriteLine($"Nhập {(int)Menu.timchieudaihinhchunhat} để tìm chiều dài ngắn, dài nhất của hình chữ nhật");
                Console.WriteLine($"Nhập {(int)Menu.sapxepdientich} để sắp xếp diện tích");
                Console.WriteLine($"Nhập {(int)Menu.tongchuvi} để tính tổng chu vi");
                Console.WriteLine($"Nhập {(int)Menu.timchuvihinhtron} để tìm chu vi nhỏ nhất, lớn nhất của hình tròn");
                Console.WriteLine($"Nhập {(int)Menu.timvitricuadientich} để tìm vị trí hình có diện tích nhỏ nhất, lớn nhất");
                Console.WriteLine($"Nhập {(int)Menu.timvitri} để tìm vị trí theo hình, theo diện tích");
                Console.WriteLine($"Nhập {(int)Menu.thoat} để thoát ");
                Console.Write("Nhập : ");
                
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case Menu.nhaptufile:
                        mhh.NhapTuFile();
                        break;
                    case Menu.timcanhhinhvuong:
                        List<HinhVuong> kq1 = mhh.TimCanhNhoNhat();
                        List<HinhVuong> a1 = mhh.collection.OfType<HinhVuong>().ToList();
                        List<HinhVuong> kq1_1 = mhh.TimCanhLonNhat();
                        foreach (var a in kq1)
                        {
                            float index = a1.IndexOf(a);
                            Console.WriteLine("Hinh vuong số " + (index + 1) + " " + a.Canh);
                        }
                        Console.WriteLine("có cạnh nhỏ nhất");
                        foreach (var a in kq1_1)
                        {
                            float index = a1.IndexOf(a);
                            Console.WriteLine("Hinh vuông số " + (index + 1) + " " + a.Canh);
                        }
                        Console.WriteLine("có cạnh lớn nhất");
                        break;
                    case Menu.timchieudaihinhchunhat:
                        List<HinhChuNhat> kq2 = mhh.TimCanhDaiNhoNhat();
                        List<HinhChuNhat> kq2_1 = mhh.TimCanhDaiLonNhat();
                        List<HinhChuNhat> a2 = mhh.collection.OfType<HinhChuNhat>().ToList();
                        foreach (var a in kq2)
                        {
                            float index = a2.IndexOf(a); // lấy vị trí của phần tử a trong danh sách kq2
                            Console.WriteLine("Hình chữ nhật số " + (index + 1) + " có chiều dài là " + a.chieuDai);
                        }
                        Console.WriteLine("có chiều dài nhỏ nhất");
                        foreach (var a in kq2_1)
                        {
                            int index = a2.IndexOf(a); // lấy vị trí của phần tử a trong danh sách kq2_1
                            Console.WriteLine("Hình chữ nhật số " + (index + 1) + " có chiều dài là " + a.chieuDai);
                        }
                        Console.WriteLine("có chiều dài lớn nhất");
                        break;
                    case Menu.sapxepdientich:
                        List<HinhHoc> kq3 = mhh.SapDienTichTheoChieuTang();
                        List<HinhHoc> kq3_1 = mhh.SapDienTichTheoChieuGiam();
                        Console.WriteLine("Theo chiều tăng");
                        kq3.ForEach(x => x.Xuat());
                        Console.WriteLine("Theo chiều giảm");
                        kq3_1.ForEach(x => x.Xuat());
                        break;
                    case Menu.tongchuvi:
                        float kq5 = mhh.TinhTongCV();
                        mhh.Xuat();
                        Console.WriteLine("Tổng chu vi là : " + kq5);
                        break;
                    case Menu.timchuvihinhtron:
                        List<HinhTron> kq4 = mhh.TimHinhTronCoChuViMin();
                        List<HinhTron> kq4_1 = mhh.TimHinhTronCoChuViMax();
                        List<HinhTron> a3 = mhh.collection.OfType<HinhTron>().ToList();
                        Console.WriteLine("Hình tròn có chu vi bé nhất là :");
                        foreach (var a in kq4)
                        {
                            float index = a3.IndexOf(a);
                            Console.WriteLine("Hình tròn " + (index + 1) + " có chu vi " + a.TinhChuVi());
                        }
                        Console.WriteLine("Hình tròn có chu vi lớn nhất là :");
                        foreach (var a in kq4_1)
                        {
                            float index = a3.IndexOf(a);
                            Console.WriteLine("Hình tròn " + (index + 1) + " có chu vi " + a.TinhChuVi());
                        }
                        break;
                    case Menu.timvitricuadientich:
                        List<HinhHoc> kq7 = mhh.TimDienTichMin();
                        List<HinhHoc> kq7_1 = mhh.TimDienTichMax();
                        List<HinhHoc> a7 = mhh.collection;
                        mhh.Xuat();
                        foreach (var item in kq7)
                        {
                            float index = a7.IndexOf(item);
                            Console.WriteLine("Hinh có diện tích bé nhất ở vị trí :" + (index + 1));
                        }
                        foreach (var item in kq7_1)
                        {
                            float index = a7.IndexOf(item);
                            Console.WriteLine("Hinh có diện tích lớn nhất ở vị trí :" + (index + 1));
                        }
                        break;
                    case Menu.timvitri:
                        Console.WriteLine("nhập hình cần tìm : hinhvuong, hinhtron, hinh chu nhat");
                        string a8=Console.ReadLine();
                        Console.WriteLine("Nhập diện tích");
                        float b8=(float)int.Parse(Console.ReadLine());
                        List<HinhHoc> a8_1=mhh.TimViTri(b8, a8);
                        foreach (var item in a8_1)
                        {
                            item.Xuat();
                        }
                        break;
                    case Menu.thoat:
                        return;
                }
                Console.WriteLine("Nhập 1 để tiếp tục ");
                Console.ReadKey();
            }

        }
    }
}
