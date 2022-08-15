using System;
using System.Text.RegularExpressions;
namespace bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập vào số phần tử của mảng ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[]arr  = new int[a];  
            for(int i=0; i<a ;i++) {
                Console.WriteLine($"phần tử thứ {i}");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            double total = 0;
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            average = total / arr.Length;
            Console.WriteLine("\n\n Trung binh cong cac phan tu la: {0}", average);
        }
    }
}
