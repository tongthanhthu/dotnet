using System;
namespace bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên:");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > 0){
               for (int i = 0;i <= a ; i++)
                {        
                    if(i%2==0){
                       sum = sum + i;
                    }     
                }
                Console.WriteLine($"Tong = {sum}");
            }
            else{
                Console.WriteLine("số nhập vào phải là 1 số nguyên");
            }

               

            
    }
 }
}
