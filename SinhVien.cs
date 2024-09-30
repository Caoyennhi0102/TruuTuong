using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruuTuong
{
    abstract public  class SinhVien
    {
        public string Name;
        abstract public double DTB();
        public void XepLoai()
        {
            if ((DTB() <= 8))
            {
                Console.WriteLine("Khá");
            }
            else if((DTB() >= 5))
            {
                Console.WriteLine("Trung Bình ");
            }
            else
            {
                Console.WriteLine("Yếu");
            }
        }
       
    }
}
