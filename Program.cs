using TruuTuong;

internal class Program
{
    private static void Main(string[] args)
    {
        SinhVienIT sinhVienIT = new SinhVienIT();
        sinhVienIT.name = "Lưu Vĩnh Phát ";
        sinhVienIT.diemC = 5;
        sinhVienIT.diemJava = 5;
        Console.WriteLine("Họ và Tên : " + sinhVienIT.name + "Điểm Trung Bình : " + sinhVienIT.DTB().ToString());
        sinhVienIT.XepLoai();
        
    }
}