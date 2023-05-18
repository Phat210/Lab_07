using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    abstract class HinhHoc
    {
        public string type { get; set; }
        

        public abstract float TinhDT();

        public abstract void Xuat();
        public abstract float TinhChuVi();
    }
}
