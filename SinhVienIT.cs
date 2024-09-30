using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruuTuong
{
    public class SinhVienIT:SinhVien
    {
        public string name;
        public double diemJava;
        public double diemC;
        public override double DTB()
        {
            return diemJava + diemC / 2;
        }
    }
}
