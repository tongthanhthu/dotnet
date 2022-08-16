using System;
using System.Text.RegularExpressions;
namespace bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 chuỗi ký tự:");
            string a = Console.ReadLine();
            Console.WriteLine("Nhập vào 1 ký tự:");
            string b = Console.ReadLine();
            if(b.Length == 1){
                if(a.Contains(b))
                {
                    Console.WriteLine($"vị trí {a.IndexOf(b)}");
                }else
                {
                    Console.WriteLine("không có ký tự");
                }
            }else{
                Console.WriteLine("Nhập vào 1 ký tự thôi !");
            }      
        }
    }
}
