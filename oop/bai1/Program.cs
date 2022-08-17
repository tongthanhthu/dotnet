
using System;
 
namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Phanso p1 = new Phanso();
            Phanso p2 = new Phanso();
            Phanso p3 = new Phanso();
 
            Console.WriteLine("nhập phân số 1");
            p1.NhapPhanso();
 
            Console.WriteLine("nhập phân số 2");
            p2.NhapPhanso();
 
            p3 = p3.tong(p1, p2);
            Console.WriteLine($"\n tổng 2 phân số");
            p3.InPhanso();

            p3 = p3.hieu(p1, p2);
            Console.WriteLine("\n hiệu 2 phân số ");
            p3.InPhanso();

            p3 = p3.tich(p1,p2);
            Console.WriteLine("\n tích 2 phân số");
            p3.InPhanso();

            p3 = p3.thuong(p1,p2);
            Console.WriteLine("\n chia 2 phân số");
            p3.InPhanso();

 
        }
    }
}