using System;
namespace bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
           Console.Write("Nhap so nguyen n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int l = fibonacci(n);
                Console.Write($"đầu ra {l} ");
        }
        static int fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;
 
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i <= n; i++)
                {                            
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
