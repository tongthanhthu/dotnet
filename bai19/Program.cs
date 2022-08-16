using System;

namespace bai19 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập vào 1 chuỗi");
			string s = Console.ReadLine();
			char a = 'a';
            int dem = 0;
			for (int i = 0; i < s.Length; i++) {
				if (s[i] == a) {
                    dem ++;
					Console.WriteLine($"vị trí {i}");
				}
			}
            Console.WriteLine($"xuất hiên {dem}");
		}
    }
}