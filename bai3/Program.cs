using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập 3 số thực:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"số thứ 1 là :{a}, số thứ 2 là :{b}, số thứ 3 là :{c}");
            if(a<0 || b<0 || c<0 || a+b<c || a+c<b || b+c<a)
            {
                Console.WriteLine("3 số này không phải cạnh của tam giác");
            }else
            {
                Console.WriteLine("3 số này là 3 cạnh của tam giác");
            }
        }
    }
}