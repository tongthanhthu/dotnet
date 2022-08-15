using System;
using System.Text.RegularExpressions;
namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập 5 mã sinh viên");
            for(int i=1 ;i<=5;i++){
            Console.WriteLine($"Nhập msv{i}:");
            string msv = Console.ReadLine();
              check(msv);
            }
        }
        static void check(string msv){
         if (Regex.IsMatch(msv,"B170\\d{4}"))
            {
                Console.WriteLine("msv chính xác");
            }
            else
            {
                Console.WriteLine("msv sai");
            }

        }
    }
}