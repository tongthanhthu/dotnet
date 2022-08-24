using System;
using System.Text.RegularExpressions;
namespace bai12
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
                if(arr[i] < 0){
                    Console.WriteLine("vui lòng nhập số nguyên dương ");
                }
            }
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine("\n\n phần tử lớn nhất là: {0}", max);
            }
        }
    }