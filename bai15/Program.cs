using System;
using System.Text.RegularExpressions;
namespace bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập 5 mã sinh viên 00yLxxxx:");
            string[] arr = new string[5];
            for(int i=0;i<5;i++){
                string msv = Console.ReadLine();
                arr[i]=msv;
                if(checkmsv(msv)==0)
                {
                    Console.WriteLine("Đúng rồi!");
                }else
                {
                    Console.WriteLine("Sai rồi!");
                    break;
                }
            }
            
        }
        static int checkmsv(string msv)
        {
            if (Regex.IsMatch(msv,"00\\d{4}"))
                return 0;
            else
                return 1;
        }
    }
}
