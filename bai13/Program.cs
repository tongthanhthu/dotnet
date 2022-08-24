using System;
using System.Text.RegularExpressions;
namespace bai13
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
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            Console.WriteLine("\n\n phần tử nhỏ nhất là: {0}", min);
            }
        }
    }