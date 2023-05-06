using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class HinhChuNhat:HinhHoc
    {
        float chieuDai;
        float chieuRong;
        public HinhChuNhat() { }
        public HinhChuNhat(float cd, float cr)
        {
            this.chieuDai = cd;
            this.chieuRong = cr;
        }
        public override float TinhDT()
        {
            return (float)(chieuDai*chieuRong)/2;
        }
    }
}
