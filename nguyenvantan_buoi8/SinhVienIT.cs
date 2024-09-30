using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyenvantan_buoi8
{
    internal class SinhVienIT : SinhVien
    {
        public double diemJava;
        public double diemCss;
        public override double getDiemTB() {

            return (2 * diemJava + diemCss)/3;
    
    }
  }
}


