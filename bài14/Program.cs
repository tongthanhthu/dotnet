using System;
using System.Text.RegularExpressions;
namespace bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int i = 0, j = 0, temp;
            Console.WriteLine("nhập vào số phần tử của mảng ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[]arr  = new int[a];  
            for( i=0; i<a ;i++) {
                Console.WriteLine($"phần tử thứ {i}");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            j = i - 1;
            i = 0;
            while(i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }

            Console.Write("\n Mang  sau khi dao nguoc: ");
            for(i = 0; i < a;i++)
            {
                Console.Write(arr[i] + " ");
            }

            }
        }
    }
