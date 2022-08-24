using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int cdigit;

            Console.Write("Nhập một số bất kì (0-9): ");
            cdigit = Convert.ToInt32(Console.ReadLine());

            switch (cdigit)
            {
                case 0:
                    Console.Write("Số không\n");
                    break;

                case 1:
                    Console.Write("Số một\n");
                    break;
                case 2:
                    Console.Write("Số hai\n");
                    break;
                case 3:
                    Console.Write("Số ba\n");
                    break;
                case 4:
                    Console.Write("Số bốn\n");
                    break;
                case 5:
                    Console.Write("Số năm\n");
                    break;
                case 6:
                    Console.Write("Số sáu\n");
                    break;
                case 7:
                    Console.Write("Số bảy\n");
                    break;
                case 8:
                    Console.Write("Số tám\n");
                    break;
                case 9:
                    Console.Write("Số chín\n");
                    break;
                default:
                    Console.Write("Bạn đã nhập số không hợp lệ!!!\n");
                    break;
            }               
        }
    }
}
