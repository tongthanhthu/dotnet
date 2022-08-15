using System;
using System.Text.RegularExpressions;
namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập msv:");
            string msv = Console.ReadLine();

            if (Regex.IsMatch(msv,"B\\d{7}"))
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