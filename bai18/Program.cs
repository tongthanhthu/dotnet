using System;
using System.Text.RegularExpressions;
namespace bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 chuỗi ký tự:");
            string a = Console.ReadLine();
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            if(regex.IsMatch(a)){
               Console.WriteLine("có");
            }else{
                Console.WriteLine("không");
            }
      
        }
    }
}
