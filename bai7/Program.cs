using System;
namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tich = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên:");
            int a = Convert.ToInt32(Console.ReadLine());
               for (int i = 1;i <= 20 ; i++)
                {  
                    tich  = a*i;
                    Console.WriteLine($"{a}x{i} = {tich}");             
                }
                
                         
    }
 }
}
