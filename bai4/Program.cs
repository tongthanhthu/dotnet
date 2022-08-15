using System;

namespace bai4
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
            if(a<0 || b<0 || c<0 )
            {
                Console.WriteLine("3 số này không phải cạnh của tam giác vuông");
            }
            else if(a*a+b*b==c*c || a*a==b*b+c*c || a*a+c*c==b*b)
            {
                Console.WriteLine("3 số này là cạnh của tam giác vuông");
            }else
            {
                Console.WriteLine("3 số này không phải cạnh của tam giác vuông");
            }
        }
    }
}