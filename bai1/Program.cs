using System;
namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Số đã nhập là: {input}");
            if(input>0){
                Console.WriteLine($"Số {input} là số nguyên dương");
            }else
                Console.WriteLine($"Số {input} là số nguyên âm");
        }
    }
}