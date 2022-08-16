using System;
using System.Text.RegularExpressions;
namespace bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi ký tự cần kiểm tra");
            string a = Console.ReadLine();
            if (Regex.IsMatch(a,"^[A-Z][^\\s]{0,18}\\d"))
            {
                Console.WriteLine("duyệt");
            }
            else
            {
                Console.WriteLine("không duyệt");
            }
        }
    }
}
